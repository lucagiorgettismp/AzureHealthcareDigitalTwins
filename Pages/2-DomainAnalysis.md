---
permalink: /domain_analysis.html
---

# Analisi del Dominio

<p>Questo capitolo verte su tutta l’analisi impiegata sulla conoscenza del dominio dell’applicativo, sull’identificazione dei requisiti, dei casi d’uso nonché sull’analisi dei principi della filosofia Domain Driven Design.</p>
<p>Questa fase è stata di grande importanza poiché ci ha permesso, da una parte di avere un ottima conoscenza del dominio applicativo e dall’altra di discutere sui principali aspetti di sviluppo agevolando notevolmente la successiva fase di implementazione.</p>

<h2 id="il-dominio">Il dominio</h2>
<p>In questa sezione verrà descritto il dominio dell’applicativo: verrà presentato l’obiettivo da raggiungere, lo stato dell’arte e l’<em>ubiquitous language</em> individuato.</p>

<h3 id="obiettivo">Obiettivo</h3>
<p>L’obiettivo del progetto è la creazione di un sistema che consenta a tutto il team della sala operatoria (medici, infermieri e anestesisti) di accedere in maniera agevole a tutte le informazioni del paziente durante un intervento chirurgico. In particolare quello che si richiede è di poter virtualizzare attraverso un ologramma il monitor a parametri vitali del paziente. In questo modo, durante un intervento, ogni membro del team può visualizzare ed interagire con l’ologramma controllando i relativi valori dei parametri del monitor indipendentemente dalla locazione del dispositivo fisico.</p>
<p>Questo approccio porta a semplificare tutta una serie di operazioni che possono essere svolte sul paziente durante l’operazione. Si pensi se durante un intervento è necessario eseguire una TAC d’urgenza: significherebbe trasportare il paziente, tutti i sensori a cui è collegato e il relativo monitor in una stanza adiacente a quella chirurgica con il rischio di perdere del tempo prezioso per problemi che possono incorrere durante il trasferimento. Se si adottasse la soluzione proposta, sarebbe necessario spostare solamente il paziente e non i dispositivi fisici poiché ogni membro del team continua a visualizzare l’ologramma, riducendo così il tempo impiegato nel trasferimento del paziente. Un altro vantaggio è dato dalla connessione in remoto allo stato del monitor del paziente da parte di altri medici che possono essere coinvolti nell’operazione.</p>

<h3 id="stato-dellarte">Stato dell’arte</h3>
<p>Molte grandi città del mondo stanno già impiegando questa tecnologia in ambito sanitario. Ad esempio nell’ospedale di Singapore, i chirurgi utilizzano questo approccio per visualizzare ologrammi di referti dei pazienti (come una risonanza magnetica) durante un intervento chirurgico (maggiori informazioni a questo <a href="https://govinsider.asia/citizen-centric/how-a-singapore-hospital-uses-holograms-to-assist-surgery-nuhs-ngiam-kee-yuan/"><em>link</em></a>). Si tratta di un caso simile al nostro ma con una principale differenza: nel nostro caso l’ologramma viene aggiornato in <em>real-time</em> con i dati del paziente.</p>

<div id="#pic:monitor_example">
    <p align="center">
        <img width="450" src="Images/monitor.png" />
        <center>Immagine 1.1</center>
    </p>    
</div>

<p>Durante l’intervento, al paziente vengono collegati diversi sensori per monitorare i parametri vitali. I valori dei parametri vengono mostrati nel monitor ognuno con uno specifico colore. In particolare per ogni parametro viene mostrato il valore puntuale, l’unità di misura e per alcuni di loro anche un grafico. Nella figura <a href="#pic:monitor_example" data-reference-type="ref" data-reference="pic:monitor_example">1.1</a> è presente un esempio di monitor a parametri vitali ed è quello a cui noi ci siamo basati per la parte di simulazione. I parametri vitali monitorati sono: la temperatura, la pressione sanguigna, la frequenza respiratoria e cardiaca e la saturazione. Per ognuno di questi si è deciso anche di aggiungere un allarme che si attiva qualora il relativo valore supera una certa soglia sia inferiormente che superiormente.</p>

<h3 id="ubiquitous-language">Ubiquitous Language</h3>
<p>L’<em>ubiquitous language</em> contiene un insieme di termini usati nella definizione del dominio al fine di eliminare incertezze, imprecisioni e fraintendimenti che possono derivare da ogni membro del team di progetto, esperti del dominio e altri partecipanti. E’ importante non solo specificare il significato di un termine ma anche il suo contesto di utilizzo. Tale linguaggio è sempre in continuo aggiornamento anche durante tutta la fase di sviluppo e non definito solamente all’inizio. La tabella <a href="#tab:mixed-reality-ubiquitous-language-table" data-reference-type="ref" data-reference="tab:mixed-reality-ubiquitous-language-table">1.1</a> illustra l’<em>ubiquitous language</em> per il nostro applicativo.</p>
<table>
<thead>
<tr class="header">
<th style="text-align: left;"><strong>Termine</strong></th>
<th style="text-align: left;"><strong>Equivalenza</strong></th>
<th style="text-align: left;"><strong>Descrizione</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td style="text-align: left;">Monitor a parametri vitali</td>
<td style="text-align: left;">Vital Signs Monitor</td>
<td style="text-align: left;">Monitor utilizzato per visualizzare i parametri vitali di un paziente durante un intervento chirurgico.</td>
</tr>
<tr class="even">
<td style="text-align: left;">Dispositivi fisici</td>
<td style="text-align: left;">Phisical Assets</td>
<td style="text-align: left;">Si intende il monitor a parametri vitali fisico e i relativi sensori.</td>
</tr>
<tr class="odd">
<td style="text-align: left;">Temperatura</td>
<td style="text-align: left;">Temperature</td>
<td style="text-align: left;">Parametro vitale riferito alla temperatura corporea del paziente che è possibile visualizzare nel monitor.</td>
</tr>
<tr class="even">
<td style="text-align: left;">Saturazione</td>
<td style="text-align: left;">Saturation</td>
<td style="text-align: left;">Parametro vitale riferito alla saturazione del paziente che è possibile visualizzare nel monitor.</td>
</tr>
<tr class="odd">
<td style="text-align: left;">Pressione sanguigna</td>
<td style="text-align: left;">Blood Pressure</td>
<td style="text-align: left;">Parametro vitale riferito alla pressione sanguigna del paziente che è possibile visualizzare nel monitor.</td>
</tr>
<tr class="even">
<td style="text-align: left;">Frequenza cardiaca</td>
<td style="text-align: left;">Heart Frequency</td>
<td style="text-align: left;">Parametro vitale riferito alla frequenza cardiaca del paziente che è possibile visualizzare nel monitor.</td>
</tr>
<tr class="odd">
<td style="text-align: left;">Frequenza respiratoria</td>
<td style="text-align: left;">Breath Frequency</td>
<td style="text-align: left;">Parametro vitale riferito alla frequenza respiratoria del paziente che è possibile visualizzare nel monitor.</td>
</tr>
<tr class="even">
<td style="text-align: left;">Allarme</td>
<td style="text-align: left;">Alert</td>
<td style="text-align: left;">Stato in cui si trova un parametro vitale quando il suo valore è troppo alto o troppo basso rispetto ad uno specifico range di valori impostato.</td>
</tr>
<tr class="odd">
<td style="text-align: left;">Unità di misura</td>
<td style="text-align: left;">Unit of measurement</td>
<td style="text-align: left;">Unità di misura utilizzata per rappresentare il valore di uno specifico parametro vitale.</td>
</tr>
<tr class="odd">
<td style="text-align: left;">Paziente</td>
<td style="text-align: left;">Patient</td>
<td style="text-align: left;">Persona che usufruisce del sistema realizzato.</td>
</tr>
<tr class="even">
<td style="text-align: left;">Scheda Clinica</td>
<td style="text-align: left;">Medical Record</td>
<td style="text-align: left;">Documento che raccoglie le informazioni di tipo medico-anagrafico del paziente.</td>
</tr>
<tr class="odd">
<td style="text-align: left;">Team</td>
<td style="text-align: left;">Team</td>
<td style="text-align: left;">L’insieme delle persone che utilizzeranno il sistema realizzato ovvero tutti i soggetti attivi nella sala operatoria durante un intervento chirurgico.</td>
</tr>
<tr class="even">
<td style="text-align: left;">Ologramma</td>
<td style="text-align: left;">Hologram</td>
<td style="text-align: left;">Rappresentazione tridimensionale dei dati nello spazio che consente l’interazione con essi.</td>
</tr>
</tbody>
</table>
<h2 id="requisiti">Requisiti</h2>
<p>Una delle fasi fondamentali dell’intero processo di analisi, è ricaduta nella definizione dei requisiti che il progetto dovrà soddisfare. Questi verranno raffinati in corso d’opera andando a creare una comprensione del dominio sempre più approfondita. Verranno descritti i requisiti di business, utente, quelli legati al sistema, funzionali e non funzionali.</p>
<h3 id="business">Business</h3>
<p>I requisiti di business sono così descritti:</p>
<ul>
<li><p>Il prodotto dovrà fornire un monitoraggio a distanza. Questo consentirà al personale incaricato di poter controllare i parametri vitali del paziente in remoto;</p></li>
<li><p>Il prodotto dovrà consentire di agevolare l’insieme delle operazioni svolte in sala operatoria che richiedono lo spostamento di dispositivi fisici;</p></li>
<li><p>I dati mostrati nell’ologramma devono essere aggiornati in tempo reale, minimizzando il tempo di latenza.</p></li>
</ul>
<h3 id="utente">Utente</h3>
<p>I requisiti utente sono così descritti:</p>
<ul>
<li><p>Il prodotto deve permettere di creare la scheda clinica del paziente quando questo viene ricoverato in ospedale;</p></li>
<li><p>L’ologramma deve avere un interfaccia intuitiva simile il più possibile a quella di un monitor a parametri vitali fisico, con possibilità di un menù per poter fare un focus su uno specifico parametro vitale;</p></li>
<li><p>L’ologramma deve avere un sistema di allerta se i valori dei parametri vitali sono al di sopra o al di sotto di uno specifico range;</p></li>
<li><p>Il prodotto deve poter fornire la possibilità di personalizzare i parametri vitali. In particolare il personale incaricato potrà personalizzare il range di ogni parametro vitale e l’unità di misura con cui quel dato è rappresentato;</p></li>
<li><p>L’ologramma dovrà mostrare la scheda clinica del paziente.</p></li>
</ul>
<h3 id="legati-al-sistema">Legati al Sistema</h3>
<p>I requisiti di sistema sono così descritti:</p>
<ul>
<li><p>Il paziente deve poter essere identificato univocamente tramite il suo codice fiscale;</p></li>
<li><p>L’accesso dello stato del paziente in sala operatoria tramite l’ologramma deve essere fatto per mezzo di un QR code.</p></li>
</ul>
<h3 id="funzionali">Funzionali</h3>
<p>Si elencano i requisiti funzionali per ognuno dei seguenti contesti:</p>
<ul>
<li><p>Accesso del paziente in ospedale;</p></li>
<li><p>Intervento chirurgico.</p></li>
</ul>
<p>L’immagine <a href="#pic:use-cases" data-reference-type="ref" data-reference="pic:use-cases">1.2</a> mostra i caso d’uso del sistema relativi ai contesti citati.</p>

<div id="#pic:use-cases">
<p align="center">
    <img width="450" src="Images/useCase.png">
    <center>Immagine 1.2</center>
</p>
</div>

<h4 id="accesso-del-paziente-in-ospedale">Accesso del paziente in ospedale</h4>
<p>Quando il paziente deve essere ricoverato in ospedale è necessario registrarlo nel sistema informatico dell’ospedale. L’operatore incaricato dovrà quindi creare la sua scheda clinica compilando i dati richiesti. Successivamente, il chirurgo se lo ritiene necessario può configurare le soglie di allerta per i parametri vitali e infine si dovrà generare il relativo QR code che sarà utilizzato per il riconoscimento del paziente in sala operatoria.</p>

<h4 id="intervento-chirurgico">Intervento chirurgico</h4>
<p>Se è necessario eseguire un operazione chirurgica al paziente, il chirurgo può utilizzare oltre al monitor a parametri vitali fisico anche quello virtuale grazie alla visualizzazione di un ologramma. Per fare ciò sarà necessario scannerizzare il QR code del paziente (generato in fase di ricovero) sia nel monitor fisico sia nell’ologramma al fine di creare la connessione tra i due sistemi per la ricezione dei dati. In questo modo il chirurgo potrà visualizzare nell’ologramma i dati relativi ai parametri vitali del paziente, eventuali allarmi, i grafici, i valori puntuali e scegliere di monitorare un preciso parametro anziché avere una schermata generale di tutti. Inoltre sarà possibile visualizzare la scheda clinica del paziente compilata in fase di ricovero.</p>

<h3 id="non-funzionali">Non funzionali</h3>
<p>I requisiti non funzionali sono così descritti.</p>

<h4 id="usabilità">Usabilità</h4>
<p>Il sistema deve fornire agli utenti finali un’interfaccia chiara, semplice, ben organizzata in modo da poter utilizzare al meglio tutte le sue funzionalità messe a disposizione e visualizzate.</p>

<h4 id="legati-al-sistema-1">Legati al Sistema</h4>
<ul>
<li><p><strong>Reattività</strong>. L’utente non deve percepire ritardi tra la visualizzazione dei dati nel monitor a parametri vitali fisico e la visualizzazione degli stessi nell’ologramma;</p></li>
<li><p><strong>Fault tolerance</strong>. Deve essere implementato un adeguato sistema di gestione degli errori affinché le interruzioni involontarie non compromettono la salute del paziente durante un intervento chirurgico;</p></li>
<li><p><strong>Sicurezza</strong>. Utilizzando <em>Azure Digital Twins</em> i dati salvati nel cloud e quelli in transito tra due o più componenti di Azure sono crittografati;</p></li>
<li><p><strong>Scalabilità</strong>. L’applicativo deve necessariamente consentire di aumentare o diminuire il numero di pazienti gestiti senza influire negativamente sulla prestazione del sistema.</p></li>
</ul>

<h3 id="implementativi">Implementativi</h3>
<p>Il software dovrà essere realizzato utilizzando la filosofia <em>Domain Driven Design</em>. Dovranno inoltre essere utilizzate metodologie di DevOps al fine di automatizzare e integrare quanti più processi possibili. Si utilizzerà il servizio Azure Digital Twins (PaaS - Platform As A Service) per la gestione dei digital twins e l’interfacciamento con i diversi clients. Per la parte di mixed reality si utilizzerà la piattaforma Unity e i visori Microsoft Hololens 2.</p>

<h2 id="aspetti-di-domain-driven-design">Aspetti di Domain Driven Design</h2>
<p>Partendo dall’analisi dei requisiti evidenziati al paragrafo precedente e dall’approfondimento dei processi che avvengono nel contesto ospedaliero, abbiamo cercato di semplificare il dominio in cui si deve implementare la nostra soluzione dividendolo in più sotto-domini, alcuni di questi di interesse per la nostra implementazione, altri non correlati.</p>

<div id="#pic:domain-model">
<p align="center">
    <img width="450" src="Images/domain_model.png">
    <center>Immagine 1.3</center>
</p>
</div>

<h3 id="core-domain">Core-Domain</h3>
<p>Il Core-Domain della nostra applicazione è quello che in figura <a href="#pic:domain-model" data-reference-type="ref" data-reference="pic:domain-model">1.3</a> abbiamo definito Surgical Intervention. Ovvero l’intervento chirurgico vero e proprio, in cui la nostra applicazione real time deve ottenere i dati dall’asset fisico (monitor dei parametri vitali presente in sala operatoria), associarlo al paziente e deve essere proiettato come ologramma interattivo sugli occhiali Hololens del personale.</p>
<p>Contenendo approvvigionamento dei dati, alimentazione del digital twin e presentazione dei dati, questo dominio è risultato quello principale, ma in base all’ordine delle operazioni che vengono svolte all’interno del processo ospedaliero, abbiamo evidenziato anche altri Sub-Domains che sono in qualche modo correlati o da supporto al Core-Domain.</p>

<h3 id="sub-domains">Sub-Domains</h3>
<p>Abbiamo evidenziato altri tre Sub-Domains:</p>
<ul>
<li><p><strong>Ospitalization</strong>: Ricovero del paziente. In questa fase viene compilata la scheda del paziente con i dati necessari all’operazione che deve eseguire.</p></li>
<li><p><strong>Diagnosis</strong>: Visite e analisi relative all’operazione, svolte prima e dopo l’operazione stessa.</p></li>
<li><p><strong>Discharging</strong>: Dimissione del paziente. Conclusa l’operazione, la scheda del paziente e le informazioni relative all’operazione vengono archiviate.</p></li>
</ul>
<p>La fase di ricovero e di dimissione del paziente sono domini che in qualche modo sono di supporto al Core-Domain evidenziato. Durante il ricovero, alla creazione della scheda del paziente sarà possibile inizializzare il nostro sistema, mentre alla dimissione si potranno chiudere l’istanza del digital twin non più necessario.</p>
<h3 id="bounded-context">Bounded Context</h3>
<p>Per ogni Sub-Domain abbiamo individuato i bounded context che racchiudessero delle funzionalità indipendenti le une dalle altre.</p>

<div id="#pic:bounded-context">
<p align="center">
    <img width="450" src="Images/bounded_context.png">
    <center>Immagine 1.4</center>
</p>
</div>>

<p>Come mostrato in figura <a href="#pic:bounded-context" data-reference-type="ref" data-reference="pic:bounded-context">1.4</a>, il <em>Surgical Intevention Subdomain</em> è suddiviso in tre diversi Bounded Context:</p>
<ul>
<li><p><strong>Vital Signs Monitor Display</strong>: Visualizzazione del digital twin del monitor parametri vitali ed interazione con esso;</p></li>
<li><p><strong>Vital Signs Monitor Detection</strong>: Rilevazione dei parametri vitali del paziente e della verifica del superamento delle soglie di allarme;</p></li>
<li><p><strong>Monitor Device Configuration</strong>: Configurazione dell’asset fisico.</p></li>
</ul>

<a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/">Indietro</a>
