---
permalink: /deployment.html
---

# Deployment

<p>Il progetto sviluppato si compone di tre applicazioni:</p>
<ul>
<li><p>Applicazione Client backend;</p></li>
<li><p>Applicazione Simulator;</p></li>
<li><p>Applicazione Hololens.</p></li>
</ul>

<p>Le prime due sono rilasciate su GitHub, pertanto basterà recuperare l’ultima release dal nostro repository a questo <a href="https://github.com/lucagiorgettismp/AzureHealthcareDigitalTwins/releases"><em>link</em></a>. Allegati alla release si trovano i file .zip contenenti gli eseguibili di Client e Simulator.</p>

<h2 id="client-backend">Client backend</h2>

<p>L’applicazione client di backend permette di visualizzare le schede paziente precedentemente create e la creazione di nuovi pazienti. Per poter utilizzare il sistema progettato, è necessario che almeno un paziente sia stato creato prima di avviare il simulatore, in quanto al momento della creazione della scheda paziente viene creato anche il device IoTHub per il relativo monitor parametri vitali.</p>

<div id="#pic:client-deployment">
  <p align="center">
      <img width="500" src="Images/client_screen.png" />
      <center>Immagine 1.1</center>
  </p>
</div>

<h2 id="simulatore-backend">Simulatore backend</h2>
<p>Questa applicazione permette di simulare l’asset fisico, pertanto è necessario che venga avviata per emettere dati sul monitor parametri vitali del paziente.</p><p> All’apertura, viene recuperata la lista dei devices presenti, e una volta selezionato quello desiderato (eventualmente creato tramite il Client al paragrafo precedente), è possibile configurare range dei valori, unità di misura e soglie di allarme. Diversamente, il simulatore viene avviato con i valori di default. Con il device selezionato, è possibile avviare il monitor parametri vitali che ad ogni iterazione genererà nuovi valori che verranno notificati al digital twin.<br />
Se il simulatore è spento, non viene aggiornato il digital twin, pertanto non viene inviato nessun messaggio su SignalR.</p>

<div id="#pic:simulator-deployment">
  <p align="center">
      <img width="500" src="Images/simulator_screen.png" />
      <center>Immagine 1.2</center>
  </p>
</div>

<h2 id="applicazione-hololens">Applicazione Hololens</h2>
<p>Non essendo rilasciata su Microsoft Store, la nostra applicazione deve essere prima compilata, ed in seguito rilasciata sul device Hololens.</p>
<p>Durante lo sviluppo abbiamo utilizzato Unity v2020.3.4f1 e Visual Studio 2019 v16.11.11.</p>
<h3 id="import-di-mixed-reality-toolkit">Import di Mixed Reality Toolkit</h3>
<p>Prima di aprire il progetto, è necessario importare le componenti del Mixed Reality Toolkit.</p>
<ol>
<li><p>Avviare il Mixed Reality Toolkit (MixedRealityFeatureTool) scaricato precedentemente.</p></li>
<li><p>Fare clic sull’icona dell’ingranaggio.</p></li>
<li><p>Nella sezione Feature Settings, attivare “Show preview releases” e cliccare su OK.</p></li>
<li><p>Fare clic su Start.</p></li>
<li><p>Impostare il percorso del progetto Unity creato precedentemente e fare clic su “Discover Features”.</p></li>
<li><p>Nella sezione “Mixed Reality Toolkit” selezionare “Mixed Reality Toolkit foundation”</p></li>
<li><p>Nella sezione “Platform Support” selezionare “Mixed Reality OpenXR Plugin”.</p></li>
<li><p>Cliccare su ”Get Features”.</p></li>
<li><p>Cliccare su “Validate”, poi su OK e infine su Import.</p></li>
<li><p>Cliccare su “Approve” e poi su “Exit”, a questo punto i componenti dovrebbero essere stati importati in Unity correttamente.</p></li>
</ol>

<h3 id="configurazione-di-mixed-reality-toolkit">Configurazione di Mixed Reality Toolkit</h3>

<p>Aprendo il progetto su Unity dovrebbe comparire la finestra “MRTK Project Configurator”. In caso contrario, la si può aprire da menù<br />
Mixed Reality &gt; Toolkit &gt; Utilities &gt; Configure Project for MRTK.</p>

<ol>
<li><p>Controllare che tutte le opzioni siano spuntate e cliccare su “Apply”, a questo punto Unity dovrebbe riavviarsi.</p></li>
<li><p>Selezionare Edit &gt; Project Settings.</p></li>
<li><p>Selezionare XR Plug-in Management &gt; Install XR Plug-in Management.</p></li>
<li><p>In Universal Windows Platform attivare “ XR Plug-in Management &gt; Install XR Plug-in Management”, “OpenXR” e “Microsoft HoloLens feature set”.</p></li>
<li><p>Se sono presenti dei warning cliccare sul punto esclamativo e poi su “Fix All”, dovrebbero scomparire.</p></li>
</ol>
<h3 id="nuget">NuGet</h3>
<p>E’ necessario installare NuGet in Unity e scaricare i pacchetti utilizzati dal nostro progetto:</p>
<ol>
<li><p>Installare NuGet il wiki presente al seguente link: <a href="https://github.com/GlitchEnzo/NuGetForUnity">https://github.com/GlitchEnzo/NuGetForUnity</a>.</p></li>
<li><p>Riavviare Unity.</p></li>
<li><p>Scaricare i pacchetti utilizzati tramite menu NuGet &gt; Restore Packages.</p></li>
</ol>
<h3 id="build-e-deploy">Build e Deploy</h3>
<ol>
<li><p>In Unity selezionare File &gt; Build Settings.</p></li>
<li><p>Cliccare su Add Open Scenes per aggiungere le scene.</p></li>
<li><p>Configuare la build come mosttrato in figura <a href="#pic:build-settings" data-reference-type="ref" data-reference="pic:build-settings">1.3</a>.</p>
  
<div id="#pic:build-settings">
  <p align="center">
      <img width="500" height="250" src="Images/hololens_build_settings.png" />
      <center>Immagine 1.3</center>
  </p>
</div>
  
<li><p>Cliccare su “Build” e selezionare la cartella delle build (solitamente “Builds”, nella directory del progetto Unity)</p></li>
<li><p>Dopo aver compilato dovrebbe aprire una nuova finestra del gestore dei file, entrare nella cartella delle build e avviare il progetto di Visual Studio.</p></li>
<li><p>In Visual Studio selezionare “Release”, architettura: “ARM64”, target: “Device”</p></li>
<li><p>Collegare Hololens 2 al PC (Usare le porte USB della scheda madre se possibile)</p></li>
<li><p>Quando si fa il deploy da un nuovo PC per la prima volta bisogna fare il pairing dei device:</p></li>
<li><p>Su Visual Studio avviare il deploy da Build &gt; Deploy solution, verrà richiesto un PIN.</p></li>
<li><p>Su Hololens andare in Settings &gt; For Developers e cliccare su “Pair”, comparirà un PIN, inserirlo in Visual Studio.</p></li>
<li><p>A questo punto si può accedere all’app installata direttamente dal menu delle applicazioni di Hololens 2.</p></li>

<h3 id="creazione-qr-code">Creazione QR code</h3>
<p>E’ possibile utilizzare uno dei QR code presenti in all’interno della release su GitHub, oppure generarne uno custom; in questo caso:</p>
<ol>
<li><p>Andare all’url <a href="https://www.qrcode-monkey.com/en/#text">https://www.qrcode-monkey.com/en/#text</a>.</p></li>
<li><p>Inserire una stringa di tipo Json fatta come segue:</p>
<div class="sourceCode" id="cb1" data-language="json" data-startFrom="1"><pre class="sourceCode json"><code class="sourceCode json"><span id="cb1-1"><a href="#cb1-1" aria-hidden="true" tabindex="-1"></a><span class="fu">{</span><span class="dt">&quot;deviceId&quot;</span><span class="fu">:</span> <span class="st">&quot;CODICE_FISCALE_DEL_PAZIENTE&quot;</span><span class="fu">}</span></span></code></pre></div></li>
<li><p>Generare e scaricare il QR code appena creato.</p></li>
</ol>
<p>Una volta avviata l’applicazione su Hololens, inquadrare il QR code.<br />
Quando viene rilevato l’identificativo del paziente, verranno caricate le informazioni sul paziente, il menù di selezione delle schermate e la schermata precedentemente selezionata (o di default la schermata Home se si tratta della prima apertura).</p>


<a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/">Indietro</a>
