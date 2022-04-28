---
permalink: /detailed_design.html
---

# Design di Dettaglio

<p>In questo capitolo verrà illustrata l’organizzazione del codice per i componenti dell’architettura, i pattern utilizzati e le principali scelte implementative.</p>
<h2 id="pattern-utilizzati">Pattern utilizzati</h2>
<p>Sia per quanto riguarda l’architettura della parte client (simulatore e backend) che per quella della Mixed Reality è stato implementato il pattern MVC (<em>Model</em>-<em>View</em>-<em>Controller</em>). Il pattern è composto da tre componenti principali:</p>
<ul>
<li><p><strong>Model</strong>: incapsula i dati, il recupero e la persistenza di questi nelle varie sorgenti;</p></li>
<li><p><strong>View</strong>: si occupa della presentazione dei dati all’utente;</p></li>
<li><p><strong>Controller</strong>: contiene tutta la business logic dell’applicazione, elaborando l’input dell’utente, recuperando e aggiornando le informazioni nel model.</p></li>
</ul>

<div id="#pic:mvc-pattern">
  <p align="center">
      <img width="450" src="Images/mvcPattern.png" />
      <center>Immagine 1.1</center>
  </p>
</div>

<p>L’organizzazione del codice fatta in questo modo ci ha permesso di attribuire chiare responsabilità ad ognuno dei componenti, rendendoli indipendenti tra loro, facilmente integrabili e manutenibili. L’immagine <a href="#pic:mvc-pattern" data-reference-type="ref" data-reference="pic:mvc-pattern">1.1</a> mostra l’architettura del pattern MVC. Il componente cuore è il <em>controller</em> che ha i riferimenti sia del model che della view. Quest’ultimo avrà quindi modo di recuperare ed aggiornare i dati nel model, preparandoli e comunicandoli alla view. Viceversa quando l’utente interagisce con essa, la view richiama il controller per soddisfare la richiesta dell’utente.</p><p>Il recupero ed il salvataggio dei dati nel model avviene tramite servizi che mettono a disposizione chiamate Http REST e l’interrogazione della suite di Azure. Per sfruttare i benefici del pattern MVC e mantenere una singola istanza per ciascuna componente (pattern Singleton) abbiamo dovuto confrontarci con framework che nativamente non sono predisposti a tale scopo.</p>
<h3 id="mvc-e-windows-form">MVC e Windows Form</h3>
<p>Nelle applicazioni <em>Windows Form</em> abbiamo utilizzato le classi <em>Program.cs</em> come entry point delle applicazioni, ed in queste vengono avviati i vari controller che si occupano di creare e visualizzare le <em>Forms</em> passandogli il proprio riferimento. I controller comunicano con l’entry point attraverso l’uso di funzioni passate dalla classe principale ai controller per mezzo del costruttore.</p>
<h3 id="mvc-e-unity-platform">MVC e Unity Platform</h3>
<p>Per quanto riguarda la piattaforma Unity, siamo riusciti ad applicare l’MVC creando degli oggetti rappresentanti le varie componenti del pattern. In questo modo le componenti si sono legate al life cycle della piattaforma Unity, permettendoci di applicare il pattern Singleton. Anche in questo caso <em>Application</em> istanzia i vari controller che hanno il riferimento delle views e dei models. Le views hanno il riferimento del controllers per poter comunicare le interazioni dell’utente, mentre i controllers comunicano ad <em>Application</em> tramite l’utilizzo di funzioni passate da questa ai controller per mezzo del costruttore.</p><p> All’avvio di <em>VitalSignsMonitorController</em>, questo esegue un servizio in background che si mette in ascolto dei messaggi di SignalR per un determinato digital twin.</p>
<h2 id="organizzazione-del-codice">Organizzazione del Codice</h2>
<p>Il progetto è consultabile al seguente <a href="https://github.com/lucagiorgettismp/AzureHealthcareDigitalTwins"><em>repository</em></a> di GitHub. Il repository è organizzato nelle seguenti directory:</p>
<ul>
<li><p><strong>HealthcareVitalSignsMonitor</strong>: contiene la soluzione C# del simulatore e del client;</p></li>
<li><p><strong>DTDLModels</strong>: contiene i file <code>.json</code> che rappresentano i modelli per la definizione dei digital twins;</p></li>
<li><p><strong>AzureAppFunctions</strong>: contiene la soluzione C# di tutte le Azure function implementate;</p></li>
<li><p><strong>HealthcareHololensClient</strong>: contiene il progetto Unity per la parte di mixed reality;</p></li>
<li><p><strong>doc</strong>: contiene la documentazione in formato <code>.latex</code> e <code>.pdf</code>.</p></li>
</ul>
<h3 id="healthcare-vital-signs-monitor">Healthcare Vital Signs Monitor</h3>
<p>E’ una solution .NET scritta in C# che contiene tre progetti:</p>
<ul>
<li><p><strong>Client</strong> Permette all’operatore di creare la scheda del paziente, al salvataggio della quale avviene la creazione del digital twin di questo, del monitor a parametri vitali e la creazione del device su IoTHub.</p></li>
<li><p><strong>Simulator</strong> Simula il funzionamento dell’asset fisico. Permette di selezionare su quale digital twin del monitor a parametri vitali emettere i valori, settare le soglie di allarme, i range dei valori e le unità di misura. Una volta selezionato il device, è possibile avviare il simulatore vero e proprio, che a ogni iterazione genera dei nuovi valori dei parametri. I nuovi valori sono quelli ottenuti dall’iterazione precedente, spostati in positivo o in negativo di un valore compreso in un range che va da <em>+delta</em> a <em>-delta</em>, dove <em>delta</em> è una soglia preimpostata per il parametro;</p></li>
<li><p><strong>Common</strong> Viene referenziato da entrambi i progetti precedentemente citati e contiene le classi condivise.</p></li>
</ul>
<h3 id="azure-digital-twins">Azure Digital Twins</h3>
<h4 id="modelli">Modelli</h4>
<p>In questa directory sono contenuti i modelli che permettono di definire le proprietà e che costituiscono lo stato dei digital twins. Questa fase è stata una delle prime, di tutte quelle di analisi, e ci ha aiutato a capire come poter meglio modellare successivamente i digital twins.</p><p> I modelli vengono definiti usando il linguaggio <a href="https://github.com/Azure/opendigitaltwins-dtdl/blob/master/DTDL/v2/dtdlv2.md">DTDL</a> (Digital Twins Definition Language). Si possono utilizzare diverse strutture e tipi di dati a seconda del contesto di utilizzo e da cosa si deve andare a modellare: noi abbiamo utilizzato prevalentemente <em>Property</em>, <em>Object</em> e <em>Component</em>. Le prime descrivono lo stato in lettura e scrittura di un digital twin. L’<em>Object</em> è un tipo di dato composto da campi (simile ad un oggetto in OOP). I <em>Components</em> possono essere considerati come delle interfacce che permettono di descrivere <em>Property</em> utilizzate da altri modelli che utilizzeranno questa interfaccia. Il risultato della modellazione ha portato a creare un modello con <em>Property</em> comuni (<em>Base Param Content</em>), un modello per ogni sensore, uno per il monitor a parametri vitali e infine quello per la modellazione del paziente. L’immagine <a href="#pic:model-graph" data-reference-type="ref" data-reference="pic:model-graph">1.2</a> mostra il grafo dei modelli e le loro relazioni.</p>

<div id="#pic:model-graph">
  <p align="center">
      <img width="500" height="300" src="Images/modelGraph.PNG" />
      <center>Immagine 1.2</center>
  </p>
</div>

<p>Il significato delle frecce è il seguente:</p>
<ul>
<li><p>la freccia verde indica una ereditarietà: ogni modello di un sensore eredita le proprietà comuni dal modello base;</p></li>
<li><p>la freccia blu indica che ogni modello di un sensore è un <em>Component</em> del modello del monitor a parametri vitali;</p></li>
<li><p>la freccia gialla indica una relazione tra il modello del monitor e quello del paziente.</p></li>
</ul>
<h4 id="modello-di-base-base-param-content">Modello di Base (Base Param Content)</h4>
<p>Questo modello contiene le proprietà comuni ereditate da tutti gli altri modelli che rappresentano un sensore (parametri vitali e batteria). Nel frammento <a href="#lst:model-graph" data-reference-type="ref" data-reference="lst:model-graph">1.1</a> è presente una parte del corpo del modello. Contestualizziamo il <code>json</code> per chi non conosce il linguaggio DTDL, descrivendo alcune <em>keyword</em>: con <code>@type</code> si indica il tipo di dato a cui appartiene un elemento del modello (ad esempio <em>Property</em> o <em>Object</em>) con <code>name</code> si indica l’id con cui identificare un elemento e con <code>schema</code> il tipo di dato di quel elemento (ad esempio se è un intero, double o stringa).</p>
<div class="sourceCode" id="lst:model-graph" label="lst:model-graph" data-caption="Proprietà comuni del modello Base Param Content ereditate dai modelli." data-language="json" data-startFrom="1"><pre class="sourceCode json"><code class="sourceCode json"><span id="lst:model-graph-1"><a href="#lst:model-graph-1" aria-hidden="true" tabindex="-1"></a><span class="fu">{</span></span>
<span id="lst:model-graph-2"><a href="#lst:model-graph-2" aria-hidden="true" tabindex="-1"></a>    <span class="dt">&quot;@type&quot;</span><span class="fu">:</span> <span class="st">&quot;Property&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-3"><a href="#lst:model-graph-3" aria-hidden="true" tabindex="-1"></a>    <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;sensor_value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-4"><a href="#lst:model-graph-4" aria-hidden="true" tabindex="-1"></a>    <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Sensor value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-5"><a href="#lst:model-graph-5" aria-hidden="true" tabindex="-1"></a>    <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="fu">{</span></span>
<span id="lst:model-graph-6"><a href="#lst:model-graph-6" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;@type&quot;</span><span class="fu">:</span> <span class="st">&quot;Object&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-7"><a href="#lst:model-graph-7" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;fields&quot;</span><span class="fu">:</span> <span class="ot">[</span></span>
<span id="lst:model-graph-8"><a href="#lst:model-graph-8" aria-hidden="true" tabindex="-1"></a>        <span class="fu">{</span></span>
<span id="lst:model-graph-9"><a href="#lst:model-graph-9" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-10"><a href="#lst:model-graph-10" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-11"><a href="#lst:model-graph-11" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="st">&quot;double&quot;</span></span>
<span id="lst:model-graph-12"><a href="#lst:model-graph-12" aria-hidden="true" tabindex="-1"></a>        <span class="fu">}</span><span class="ot">,</span></span>
<span id="lst:model-graph-13"><a href="#lst:model-graph-13" aria-hidden="true" tabindex="-1"></a>        <span class="fu">{</span></span>
<span id="lst:model-graph-14"><a href="#lst:model-graph-14" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;min_value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-15"><a href="#lst:model-graph-15" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Min value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-16"><a href="#lst:model-graph-16" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="st">&quot;double&quot;</span></span>
<span id="lst:model-graph-17"><a href="#lst:model-graph-17" aria-hidden="true" tabindex="-1"></a>        <span class="fu">}</span><span class="ot">,</span></span>
<span id="lst:model-graph-18"><a href="#lst:model-graph-18" aria-hidden="true" tabindex="-1"></a>          <span class="fu">{</span></span>
<span id="lst:model-graph-19"><a href="#lst:model-graph-19" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;max_value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-20"><a href="#lst:model-graph-20" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Max value&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-21"><a href="#lst:model-graph-21" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="st">&quot;double&quot;</span></span>
<span id="lst:model-graph-22"><a href="#lst:model-graph-22" aria-hidden="true" tabindex="-1"></a>        <span class="fu">}</span><span class="ot">,</span></span>
<span id="lst:model-graph-23"><a href="#lst:model-graph-23" aria-hidden="true" tabindex="-1"></a>        <span class="fu">{</span></span>
<span id="lst:model-graph-24"><a href="#lst:model-graph-24" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;unit&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-25"><a href="#lst:model-graph-25" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Unit of measurement&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-26"><a href="#lst:model-graph-26" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="st">&quot;string&quot;</span></span>
<span id="lst:model-graph-27"><a href="#lst:model-graph-27" aria-hidden="true" tabindex="-1"></a>        <span class="fu">}</span><span class="ot">,</span></span>
<span id="lst:model-graph-28"><a href="#lst:model-graph-28" aria-hidden="true" tabindex="-1"></a>        <span class="fu">{</span></span>
<span id="lst:model-graph-29"><a href="#lst:model-graph-29" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;type&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-30"><a href="#lst:model-graph-30" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Value type&quot;</span><span class="fu">,</span></span>
<span id="lst:model-graph-31"><a href="#lst:model-graph-31" aria-hidden="true" tabindex="-1"></a>          <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="st">&quot;string&quot;</span></span>
<span id="lst:model-graph-32"><a href="#lst:model-graph-32" aria-hidden="true" tabindex="-1"></a>        <span class="fu">}</span></span>
<span id="lst:model-graph-33"><a href="#lst:model-graph-33" aria-hidden="true" tabindex="-1"></a>      <span class="ot">]</span></span>
<span id="lst:model-graph-34"><a href="#lst:model-graph-34" aria-hidden="true" tabindex="-1"></a>    <span class="fu">}</span></span>
<span id="lst:model-graph-35"><a href="#lst:model-graph-35" aria-hidden="true" tabindex="-1"></a>  <span class="fu">}</span></span></code></pre></div>
<p>Nel frammento di codice mostrato è definito un <em>Object</em> i cui campi sono le proprietà ereditate. I campi modellati sono: il valore corrente del sensore, il valore minimo e massimo del sensore per essere considerato nella norma, l’unità di misura e il tipo di dato (nell’immagine con <code>name</code> type) a cui appartiene il valore corrente.</p>
<h4 id="modello-di-ogni-sensore">Modello di ogni Sensore</h4>
<p>Tutte le proprietà che non sono comuni ai sensori, e che quindi non possono ereditate dal modello base, sono contenute nei singoli modelli. Un’ esempio è l’informazione del colore che i grafici e il valore puntuale del sensore devono assumere. Tale informazione, non presente nel sensore della batteria, è una stringa che rappresenta una tupla e contiene tre interi che rappresentano rispettivamente il canale del modello colore RGB.</p>
<h4 id="modello-del-monitor-a-parametri-vitali">Modello del Monitor a Parametri Vitali</h4>
<p>Nel modello del monitor a parametri vitali è stato definito un <em>Component</em> per ogni sensore. Il frammento <a href="#lst:component-monitor-model" data-reference-type="ref" data-reference="lst:component-monitor-model">1.2</a> illustra la dichiarazione del <em>Component</em> relativo alla temperatura. Per brevità si è deciso di mostrarne solamente uno ma è esteso a tutti gli altri sensori.</p>
<div class="sourceCode" id="lst:component-monitor-model" label="lst:component-monitor-model" data-caption="Componente temperature del modello del monitor." data-language="json" data-startFrom="1"><pre class="sourceCode json"><code class="sourceCode json"><span id="lst:component-monitor-model-1"><a href="#lst:component-monitor-model-1" aria-hidden="true" tabindex="-1"></a><span class="fu">{</span></span>
<span id="lst:component-monitor-model-2"><a href="#lst:component-monitor-model-2" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;@type&quot;</span><span class="fu">:</span> <span class="st">&quot;Component&quot;</span><span class="fu">,</span></span>
<span id="lst:component-monitor-model-3"><a href="#lst:component-monitor-model-3" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;temperature&quot;</span><span class="fu">,</span></span>
<span id="lst:component-monitor-model-4"><a href="#lst:component-monitor-model-4" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Temperature Sensor&quot;</span><span class="fu">,</span></span>
<span id="lst:component-monitor-model-5"><a href="#lst:component-monitor-model-5" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;schema&quot;</span><span class="fu">:</span> <span class="st">&quot;dtmi:healthCareDT:TemperatureParam;1&quot;</span></span>
<span id="lst:component-monitor-model-6"><a href="#lst:component-monitor-model-6" aria-hidden="true" tabindex="-1"></a>    <span class="fu">}</span></span></code></pre></div>
<p>Oltre ai <em>Components</em>, vi sono due <em>Property</em> di fondamentale importanza da descrivere:</p>
<ul>
<li><p><em>device_id</em>: identifica l’id univoco (che coincide con il codice fiscale del paziente) del dispositivo IoT nel Hub IoT precedentemente descritto. In questo modo si permette ai diversi clients Hololens di rimanere in ascolto in attesa di ricevere dei messaggi aventi questo id;</p></li>
<li><p><em>last_selected_view</em>: permette di tenere traccia dell’ultimo pannello aperto in un client Hololens attraverso un intero. In questo modo alla riapertura dell’ologramma verrà visualizzato sempre quel pannello. Si tratta di una personalizzazione che abbiamo voluto realizzare in modo da rendere più agevole la visualizzazione dell’ologramma.</p></li>
</ul>
<p>Infine, l’ultimo elemento è la relazione che lega i modelli (e quindi i digital twins) del monitor a parametri vitali e quello del paziente. Il frammento <a href="#lst:relation-monitor-model" data-reference-type="ref" data-reference="lst:relation-monitor-model">1.3</a> illustra la sua definizione. Il significato di questa relazione è quello di stabilire che ogni paziente ha un solo monitor a parametri vitali di riferimento.</p>
<div class="sourceCode" id="lst:relation-monitor-model" label="lst:relation-monitor-model" data-caption="Relazione del modello del monitor e quello del paziente." data-language="json" data-startFrom="1"><pre class="sourceCode json"><code class="sourceCode json"><span id="lst:relation-monitor-model-1"><a href="#lst:relation-monitor-model-1" aria-hidden="true" tabindex="-1"></a><span class="fu">{</span></span>
<span id="lst:relation-monitor-model-2"><a href="#lst:relation-monitor-model-2" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;@type&quot;</span><span class="fu">:</span> <span class="st">&quot;Relationship&quot;</span><span class="fu">,</span></span>
<span id="lst:relation-monitor-model-3"><a href="#lst:relation-monitor-model-3" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;@id&quot;</span><span class="fu">:</span> <span class="st">&quot;dtmi:healthCareDT:VitalParametersMonitor:rel_has_monitor;1&quot;</span><span class="fu">,</span></span>
<span id="lst:relation-monitor-model-4"><a href="#lst:relation-monitor-model-4" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;name&quot;</span><span class="fu">:</span> <span class="st">&quot;rel_has_monitor&quot;</span><span class="fu">,</span></span>
<span id="lst:relation-monitor-model-5"><a href="#lst:relation-monitor-model-5" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;displayName&quot;</span><span class="fu">:</span> <span class="st">&quot;Patient has a monitor&quot;</span><span class="fu">,</span></span>
<span id="lst:relation-monitor-model-6"><a href="#lst:relation-monitor-model-6" aria-hidden="true" tabindex="-1"></a>      <span class="dt">&quot;target&quot;</span><span class="fu">:</span> <span class="st">&quot;dtmi:healthCareDT:Patient;1&quot;</span></span>
<span id="lst:relation-monitor-model-7"><a href="#lst:relation-monitor-model-7" aria-hidden="true" tabindex="-1"></a>    <span class="fu">}</span></span></code></pre></div>
<p>Nei campi <code>@id</code> e <code>target</code> si specificano gli id dei modelli coinvolti nella relazione.</p>
<h4 id="modello-del-paziente">Modello del Paziente</h4>
<p>In questo modello sono contenute tutte le <em>Property</em> relative alle informazioni che costituiscono la cartella clinica di un paziente come descritto nel capitolo <a href="#chap:architectural-design" data-reference-type="ref" data-reference="chap:architectural-design">4</a> nella sezione dedicata al simulatore e a Hololens. </p><p>Dove si è potuto, si sono utilizzati i <em>Semantic Types</em>: insieme di tipi semantici che possono essere applicati a delle proprietà per caratterizzarle. Ad esempio per l’altezza e peso di un paziente si è utilizzato rispettivamente il tipo semantico <code>Length</code> (<span class="math inline"><em>m</em></span>) e <code>Mass</code> (<span class="math inline"><em>K</em><em>g</em></span>). L’indice di massa corporea, la cui unità di misura è <span class="math inline"><em>K</em><em>g</em>/<em>m</em><sup>2</sup></span>, non ha un tipo semantico supportato. Per questo motivo si è creata una specifica proprietà che modella questa informazione.</p>
<h4 id="azure-function">Azure function</h4>
<p>In questa sezione non ci sono particolari scelte implementative da evidenziare. Come già detto, l’obbiettivo delle Azure functions è quello di propagare nuove informazioni relative ai sensori e ai pazienti a componenti dell’architettura. I componenti coinvolti sono:</p>
<ul>
<li><p>IoT Hub istanza dei digital twins: per aggiornate lo stato dei digital twins a partire dai dati ricevuti dall’hub;</p></li>
<li><p>Digital twins client Hololens: per far si che i client (Hololens, nel nostro caso) possano ricevere i nuovi dati per mezzo della libreria SignalR;</p></li>
<li><p>Digital twins Time Series Insight: per permettere la persistenza dei dati in questo componente.</p></li>
</ul>
<p>Quando vengono aggiornati i dati dai devices creati nel IoTHub, vengono eseguiti degli eventi che chiamano le funzioni create e aggiornano il digital twin di quel device e inviano un messaggio tramite SignalR. All’aggiornamento del digital twin, un altro evento permette di inviare uno snapshot del digital twin aggiornato a Time Series Insight. In ciascuna funzione si sono quindi implementate le operazioni di parsing che analizzano il contenuto dei dati ricevuto in input, per poi propagarle al destinatario della funzione.</p><p> La directory <em>Model</em> contiene le classi POCO che modellano tutti i payload che le diverse Azure functions inviano ai rispettivi destinatari, permettendo di serializzare e deserializzare i messaggi rapidamente.</p>
<h3 id="healthcare-hololens-client">Healthcare Hololens Client</h3>
<p>L’applicazione per client Hololens sviluppata ha un funzionamento che si divide in due fasi:</p>
<ul>
<li><p>La lettura del QR code del paziente, il quale contiene il riferimento del proprio device di Azure;</p></li>
<li><p>La visualizzazione del monitor a parametri vitali con la possibilità di selezionare diverse modalità di visualizzazione dei parametri.</p></li>
</ul>
<p>L’entry point dell’applicazione è lo script <em>Application.cs</em>, che gestisce il passaggio da una fase all’altra, istanziando due differenti controller:</p>
<ul>
<li><p><strong>QRCodeController</strong>: avvia il servizio background di rilevazione del QR code e prende in input una funzione da invocare non appena il QR code viene letto;</p></li>
<li><p><strong>VitalSignsMonitorController</strong>: una volta ottenuto l’id del device, recupera i dati del paziente, la schermata selezionata in precedenza e avvia il servizio di ascolto dei messaggi provenienti da SignalR. Al cambio della schermata notifica il pannello selezionato al server.</p></li>
</ul>
<p>Tutte le classi contenute all’iterno alla cartella <em>/View</em> degli script estendono <em>MonoBeahaviour</em> e sono collegate al relativo elemento UI, così come lo sono i controller e <em>Application.cs</em>.<br />
La cartella <em>/Model</em> contiene le classi POCO per la serializzazione e deserializzazione dei messaggi SignalR e verso il server, mentre nella cartella <em>/Api</em> si trovano le classi per l’interazione con il database realtime di Firebase e per interrogare ed autenticarsi presso la suite di Azure.</p>


<a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/">Indietro</a>
