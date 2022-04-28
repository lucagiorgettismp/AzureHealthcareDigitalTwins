---
permalink: /architectural_design.html
---

# Design Architetturale

<p>In questo capitolo verrà descritta l’architettura del sistema, illustrando i componenti principali. Si rimanda al
  capitolo <a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/architectural_design.html">4</a> per ulteriori informazioni riguardante il codice
  dell’applicativo e le specifiche di implementazione.</p>
<h2 id="architettura-generale">Architettura Generale</h2>
<p>L’architettura generale del sistema è illustrata nella figura <a href="#pic:architecture" data-reference-type="ref"
    data-reference="pic:architecture">1.1</a>.</p>

<div id="#pic:architecture">
  <p align="center">
    <img width="450" src="Images/architecture.png" />
    <center>Immagine 1.1</center>
  </p>
</div>

<p>Le componenti principali dell’architettura sono:</p>
<ul>
  <li>
    <p><strong>Healthcare Vital Signs Monitor</strong>: emula il monitor a parametri vitali fisico. Invia i dati ad
      Azure Digital Twins. Nella figura <a href="#pic:architecture" data-reference-type="ref"
        data-reference="pic:architecture">1.1</a> è la componente blu;</p>
  </li>
  <li>
    <p><strong>Azure Digital Twins (ADT)</strong>: una piattaforma PaaS fornita da Microsoft che mette a disposizione
      un’insieme di funzionalità per poter implementare e gestire i Digital Twins. Questa piattaforma permette di
      creare un gemello digitale dell’asset fisico, memorizzare un’insieme di dati che costituiscono lo stato del
      digital twin e propagarlo ad altri clients: in questo caso Hololens. Nella figura <a href="#pic:architecture"
        data-reference-type="ref" data-reference="pic:architecture">1.1</a> è la componente verde;</p>
  </li>
  <li>
    <p><strong>Healthcare Hololens Client</strong>: riceve lo stato dell’asset fisico da Azure Digital Twins tramite
      la libreria SignalR. Invia i dati di configurazione dell’ologramma ad Azure Digital Twins. Nella figura <a
        href="#pic:architecture" data-reference-type="ref" data-reference="pic:architecture">1.1</a> è la componente
      rossa;</p>
  </li>
</ul>
<h2 id="healthcare-vital-signs-monitor">Healthcare Vital Signs Monitor</h2>
<p>Questa componente permette di creare la cartella clinica di un paziente compilando uno specifico form. Una volta
  completata viene creato il dispositivo IoT nell’IoT Hub e vengono creati i due digital twins in ADT: quello relativo
  al paziente e quello relativo al monitor a parametri vitali. A questo punto si è in grado eseguire il simulatore su
  uno specifico paziente. I parametri vitali monitorati dal simulatore sono cinque:</p>
<ul>
  <li>
    <p>Temperatura corporea (colore bianco) misurata in gradi Celcius (°C);</p>
  </li>
  <li>
    <p>Frequenza cardiaca (colore verde) misurata in BPM (Beat per minute);</p>
  </li>
  <li>
    <p>Frequenza respiratoria (colore verde) misurata in RPM (Revolution per minute);</p>
  </li>
  <li>
    <p>Saturazione (colore rosso) misurata in percentuale (%);</p>
  </li>
  <li>
    <p>Pressione sanguigna (di colore gialla) misurata in millimetri di mercurio o Torr (mmHg).</p>
  </li>
</ul>

<div id="#pic:simulator">
  <p align="center">
    <img width="450" src="Images/simulator.PNG" />
    <center>Immagine 1.2</center>
  </p>
</div>

<p>Come si evince dalla figura <a href="#pic:simulator" data-reference-type="ref"
    data-reference="pic:simulator">1.2</a>, per tutti questi parametri vitali (eccetto la temperatura), è mostrato un
  grafico degli ultimi N campioni acquisiti con il colore di riferimento.</p>
<p> Per tutti i parametri è presente anche un
  sensore di allerta (sia visivo che acustico) che si attiva se un valore supera (o diventa inferiore) il valore
  massimo (o minimo) di un determinato range (specifico per ogni parametro vitale). Tali sensori sono posti a sinistra
  dei grafici e alla destra del valore della temperatura e della batteria. Se si prende in considerazione l’immagine
  <a href="#pic:simulator" data-reference-type="ref" data-reference="pic:simulator">1.2</a>, questi non sono visibili
  poiché tutti i valori sono nella norma. L’infermiere o il chirurgo possono personalizzare i range e l’unità di
  misura.</p>
  <p>A destra del simulatore invece possiamo individuare due colonne: la prima indica l’unità di misura usata per
  rappresentare il valore del parametro vitale mentre la seconda mostra il suo valore numerico. In alto a destra si
  trova la data e l’orario corrente mentre in basso a destra il livello della batteria rimanente.</p>
  <p>Una volta che il
  simulatore è in esecuzione, ogni volta che ha nuovi dati, questi vengono trasmessi al ADT.
</p>
<h2 id="azure-digital-twins">Azure Digital Twins</h2>
<p>Questa è la componente più corposa del sistema che funge da server. I diversi componenti vengono descritti a
  seconda dell’ordine di esecuzione in accordo con l’immagine <a href="#pic:architecture" data-reference-type="ref"
    data-reference="pic:architecture">1.1</a>:</p>
<ul>
  <li>
    <p><strong>IoT Hub</strong>: è l’Hub di Azure che offre un back-end per ospitare sul cloud e connettere qualsiasi
      dispositivo IoT. All’interno dell’Hub sono presenti i dispositivi IoT “<em>virtuali</em>" relativi a monitors a
      parametri vitali di specifici pazienti. Tali dispositivi vengono aggiunti nell’Hub quando viene compilata la
      cartella clinica di un nuovo paziente. Tali dispositivi ricevono i dati dal simulatore e li propagano
      all’istanza <em>Azure Digital Twins</em> attraverso l’esecuzione di una <em>azure function</em>;</p>
  </li>
  <li>
    <p><strong>Azure function</strong>: è un servizio cloud che fornisce l’infrastruttura e le risorse necessarie per
      eseguire le applicazioni. L’azure function in questione è chiamata <em>ProcessHubToDTEvents</em>. Tale funzione
      è in grado di eseguire il parsing del contenuto del messaggio inviato dal simulatore e aggiornare le proprietà
      dei digital twins.</p>
  </li>
  <li>
    <p><strong>Azure Digital Twins</strong>: rappresenta l’istanza dove risiedono i digital twins. Per ogni paziente
      creato esistono due digital twins: quello del paziente e quello del monitor a parametri vitali. Essi sono legati
      da una relazione “<em>un paziente ha un monitor associato</em>". Tramite questa istanza è possibile consultare
      lo stato delle proprietà dei digital twins e fare queries. Ogni qualvolta che i digital twins vengono aggiornati
      vengono eseguite in parallelo due azure function descritte nel punto successivo;</p>
  </li>
  <li>
    <p><strong>Azure functions</strong>. La prima azure function è chiamata <em>ProcessDTUpdatetoTSI</em> ed è
      dedicata a propagare lo stato dei digital twins al Time Series Insights (TSI). La seconda azure function è
      chiamata <em>SignalRFunction</em> ed implementa la libreria SignalR per poter comunicare con il client Hololens.
      Tale funzione ha due sotto-funzioni: la prima (<em>negotiate</em>) permette di creare la connessione con il
      client, la seconda (<em>broadcast</em>) permette di inviare i dati al client;</p>
  </li>
  <li>
    <p><strong>Time Series Insights (TSI)</strong>: è una soluzione per archiviare, visualizzare ed eseguire queries
      su grandi quantità di dati relativi a quelli generati dai dispositivi IoT. Nel nostro applicativo i dati vengono
      solamente archiviati. Una funzionalità futura potrebbe essere quella di eseguire delle queries a partire dai
      clients per mostrare uno storico dei dati prodotti dal simulatore;</p>
  </li>
  <li>
    <p><strong>SignalR</strong>: SignalR è una libreria sviluppata da Microsoft che permette al server di inviare
      notifiche asincrone alle applicazioni clients creando una connessione bi-direzionale. Risulta essere performante
      per applicazioni <em>real-time</em> come nel nostro caso.</p>
  </li>
</ul>
<h2 id="healthcare-hololens-client">Healthcare Hololens Client</h2>
<p>L’ultima componente del nostro sistema è il client Hololens che permette di usare la mixed reality. Dopo aver
  indossato gli occhiali e avviata l’applicazione, è necessario scansionare il QR code del paziente. Quando il QR code
  viene riconosciuto viene mostrato l’ologramma del monitor a parametri vitali e la cartella clinica del paziente. Una
  volta avviato il simulatore, l’ologramma del monitor si popolerà di nuovi dati e aggiornerà i valori dei parametri.
  Per avere un maggior controllo sulla visualizzazione dei dati abbiamo pensato ad un menù interattivo con cui
  scegliere quale tipo di dato osservare: se visualizzare la situazione generale del paziente o focalizzarsi su un
  singolo parametro vitale. Grazie alla mixed reality, il grande vantaggio è dato dall’interazione dell’uomo con
  l’ologramma. Infatti è possibile spostare il monitor ovunque si voglia nello spazio reale, “<em>prendendolo</em>"
  appunto con le mani. Invece per cambiare schermata è possibile premere su uno dei pulsanti del menù interattivo. Per
  una maggiore comodità abbiamo pensato fosse utile far si che gli ologrammi si spostino automaticamente in base a
  dove l’uomo si sta muovendo o guardando nell’ambiente (ad esempio come la funzionalità <em>follow me</em>). Per fare
  ciò, è possibile attivare il pulsante PIN premendolo (in alto a destra di ogni ologramma). Come impostazione
  predefinita, tale pulsante è disattivato: in questo modo gli ologrammi rimangono fermi nell’ambiente se non vengono
  spostati direttamente dall’uomo.</p>
<h3 id="qr-code">QR Code</h3>
<p>La parte relativa alla lettura del QR Code non ha nessuna interfaccia di interesse. Una volta avviata l’app su
  Hololens verrà mostrato un <em>loading progress</em> in attesa della lettura di un QR Code. Dopo aver mostrato il QR
  Code, se è valido, verrà mostrato il menù, il monitor a parametri vitali e la scheda del paziente.</p>
  <p>Per l’implementazione di questa parte ci siamo avvalsi del seguente <a
    href="https://github.com/LocalJoost/QRCodeService"><em>repository</em></a>.</p>
<h3 id="menù-interattivo">Menù Interattivo</h3>
<p>Il menù si presenta come nell’immagine <a href="#pic:menu-hololens" data-reference-type="ref"
    data-reference="pic:menu-hololens">1.3</a>. E’ composto da sette pulsanti:</p>
<ul>
  <li>
    <p>il pulsante <em>Home</em> permette di visualizzare il monitor a parametri vitali di un paziente come quello
      mostrato nel simulatore;</p>
  </li>
  <li>
    <p>ogni pulsante, in riferimento ad un parametro vitale, permette di visualizzare il suo pannello dedicato;</p>
  </li>
  <li>
    <p>il pulsante <em>Values</em> permette di visualizzare solamente i valori dei parametri vitali del paziente,
      senza mostrare grafici;</p>
  </li>
  <li>
    <p>il pulsante <em>Exit</em> permette di uscire dal programma.</p>
  </li>
</ul>


<div id="#pic:menu-hololens">
  <p align="center">
    <img width="450" src="Images/hololensMenu.PNG" />
    <center>Immagine 1.3</center>
  </p>
</div>

<h3 id="monitor-a-parametri-vitali">Monitor a parametri vitali</h3>
<p>L’immagine 1.4 mostra alcuni esempi: nella figura <a href="#pic:monitor-hololens" data-reference-type="ref"
    data-reference="pic:monitor-hololens">1.4a</a> è mostrato il
  monitor a parametri vitali generale mentre nell’immagine <a href="#pic:saturation-hololens" data-reference-type="ref"
    data-reference="pic:saturation-hololens">1.4b</a> è presente il pannello dedicato ad un
  singolo parametro vitale. In questo caso si è scelto la saturazione premendo il pulsante <em>Saturation Graph</em>
  dal menù. Durante la realizzazione dei pannelli della mixed reality si è cercato di preservare il più possibile la
  grafica del simulatore così da evitare confusione tra i due monitors: quello fisico e quello virtuale. </p>

<div id="#pic:monitor-hololens">
  <p align="center">
    <img width="450" src="Images/hololensMonitor.PNG" />
    <center>Immagine 1.4a</center>
  </p>
</div>

<div id="#pic:saturation-hololens">
  <p align="center">
    <img width="450" src="Images/saturationHololens.PNG" />
    <center>Immagine 1.4b</center>
  </p>
</div>

<p>Come descritto in precedenza, l’immagine <a href="#pic:monitor-hololens" data-reference-type="ref"
    data-reference="pic:monitor-hololens">1.4</a> mostra a sinistra i sensori di allerta dei parametri vitali: di
  colore bianco quando i valori sono nella norma e di colore rosso quando assumono valori di pericolo per il paziente.
  Nell’esempio, la temperatura e la frequenza cardiaca sono in una situazione critica e vengono caratterizzati da un
  sensore di allarme di colore rosso. Proseguendo verso destra sono presenti i grafici dei quattro parametri vitali
  più importanti.Successivamente sono presenti tre colonne e contengono rispettivamente il nome del parametro vitale, il valore
  numerico e l’unità di misura utilizzata.</p>
  <p>La figura <a href="#pic:saturation-hololens" data-reference-type="ref"
    data-reference="pic:saturation-hololens">1.5</a> mostra il pannello focalizzandosi su uno specifico parametro
  vitale. In questo modo si può osservare con più accuratezza e livello di dettaglio l’andamento del grafico. Tutti
  gli altri valori sono mostrati sotto il grafico.</p>

<h3 id="pannello-del-paziente">Pannello del Paziente</h3>
<p>L’ultimo ologramma è quello legato al paziente e mostra la sua cartella clinica. Tale pannello contiene le seguenti
  informazioni:</p>
<ul>
  <li>
    <p>il nome e il cognome;</p>
  </li>
  <li>
    <p>il sesso;</p>
  </li>
  <li>
    <p>l’età, il peso e l’altezza</p>
  </li>
  <li>
    <p>l’indice di massa corporea;</p>
  </li>
  <li>
    <p>una descrizione riguardante la sua situazione clinica prima di entrare in sala operatoria. Può contenere note
      del team, il suo stato di salute e tutto ciò che è rilevante e da tenere in considerazione quando si effettua
      l’operazione;</p>
  </li>
  <li>
    <p>il suo codice fiscale;</p>
  </li>
</ul>
<p>Questo pannello contiene informazioni statiche poiché durante l’intervento queste non possono essere modificate. Il
  pannello del paziente si presenta come è mostrato nella figura <a href="#pic:patient-panel" data-reference-type="ref"
    data-reference="pic:patient-panel">1.5</a>.</p>
<div id="#pic:patient-panel">
  <p align="center">
    <img width="450" src="Images/patientPanel.PNG" />
    <center>Immagine 1.5</center>
  </p>
</div>

<a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/">Indietro</a>
