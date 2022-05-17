---
permalink: /development_process.html
---

# Processi di Sviluppo

<h2 id="gestione-di-progetto">Gestione di Progetto</h2>

<p>Si è utilizzato <em>Git</em> come sistema di DVCS del codice durante lo sviluppo, attraverso la piattaforma GitHub. L’abbiamo utilizzato sfruttando la tecnica del <em>GitFlow</em> come mostrato nella figura <a href="#pic:workflow" data-reference-type="ref" data-reference="pic:workflow">1.1</a>: il branch di default è sempre il <em>main</em>, al quale <em>development</em> è sempre allineato. Ogni volta che è necessario implementare una nuova <em>feature</em> viene creato un branch da <em>development</em>. Nel caso in cui debbano essere prodotti degli hotfix o risolti dei bug, essi vengono effettuati su un branch che parte da <em>development</em> e vi ritorna, prima di essere mergiato nuovamente su <em>main</em>. Successivamente, a lavoro ultimato, veniva creata una pull request per mergiare sul branch <em>development</em> e infine sul <em>main</em>.</p>

<div id="#pic:workflow">
  <p align="center">
      <img width="450" src="Images/gitWorkflow.png" />
      <center>Immagine 1.1</center>
  </p>
</div>

<h3 id="versioning">Versioning</h3>
<p>Il versioning è una scelta importante nello sviluppo di un progetto, perchè permette di dare un identificativo univoco ad una determinata versione del software.</p><p> Nella scelta della tipologia di sistema di versioning, il fattore che ha pesato di più è la frequenza di commit/modifiche del codice durante l’intero sviluppo della applicazione. Ci siamo da subito aspettati, infatti, che nella prima parte di progetto i commit sul nostro DVCS fossero più frequenti rispetto a quelli nella fase avanzata del progetto.</p><p> Abbiamo deciso quindi di adottare la tecnica del Semantic Versioning (<a href="https://semver.org/lang/it/">SEMVER</a>) che permette di capire, di versione in versione, quanto è effettivamente cambiato il codice, senza essere condizionato dalla frequenza di rilascio. Il semantic versioning è anche facilmente integrabile con il DVCS.</p><p> Ogni numero di release rispetta il pattern <code>MAJOR.MINOR.PATCH</code>, in cui ad ogni release viene incrementato in base alle modifiche effettuate:</p>

<ul>
<li><p><code>MAJOR</code>: quando viene modificata l’API in maniera non retrocompatibile;</p></li>
<li><p><code>MINOR</code>: quando viene aggiunta una funzionalità in maniera retrocompatibile;</p></li>
<li><p><code>PATCH</code>: quando viene corretto un bug in maniera retrocompatibile.</p></li>
</ul>

<p>Nel semantic versioning, vige inoltre la politica del no-retract, pertanto i numeri di versione sono sempre incrementali e non è possibile creare una release con versione precedente ad una già rilasciata, questo al fine di garantire maggior chiarezza e sapendo che a numero di versione più alto corrisponde la versione più recente.</p><p> Nel nostro progetto la scelta del numero di versione è stata lasciata agli sviluppatori. Ogni volta che viene fatta la push sul DVCS di un tag in formato <code>vMAJOR.MINOR.PATCH</code>, in automatico tramite un apposito workflow viene creata una release con allegati i compilati delle applicazioni e la documentazione aggiornata.</p>

<h3 id="licensing">Licensing</h3>

<p>Sono state considerate le principali licenze esistenti per progetti <em>open-source</em> consultabili al seguente <a href="https://choosealicense.com/licenses/"><em>link</em></a>.<br />

La scelta è ricaduta sulla licenza di tipo GNU GPLv3 (GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007). Questo tipo di licenza fa si che il nostro software possa essere utilizzato da altri autori purché questi pubblichino il proprio software con una licenza compatibile con quella del nostro applicativo.</p>

<h2 id="build-automation-e-continuos-integration">Build Automation e continuos integration</h2>
<h3 id="panoramica">Panoramica</h3>

<p>La build automation è stata realizzata utilizzando il servizio delle GitHub Actions. Tutti i <em>job</em> implementati vengono eseguiti sui branch <em>main</em> e <em>development</em> ad ogni commit, pull-request e al push di un tag. Vengono descritti tutti i <em>job</em> realizzati che vengono eseguiti sui diversi <em>workflow</em> previsti:</p>
<ul>
<li><p><strong>build-and-deploy-app-function</strong>: utilizzato per deployare le <em>Azure Function</em> di Azure;</p></li>
<li><p><strong>build-simulator</strong>: utilizzato per eseguire la build del simulatore e creare il rispettivo <em>artifact</em>;</p></li>
<li><p><strong>build-client</strong>: utilizzato per eseguire la build del client (lato simulatore) e creare il rispettivo <em>artifact</em>;</p></li>
<li><p><strong>build-report</strong>: utilizzato per compilare la relazione in Latex e creare l’<em>artifact</em> relativo al file <code>.pdf</code>;</p></li>
<li><p><strong>execute-tests</strong>: utilizzato per eseguire i test implementati;</p></li>
<li><p><strong>release</strong>: utilizzato per caricare gli artifacts nelle releases e per creare le versioni del progetto.</p></li>
</ul>

<p>Inoltre sono stati implementati ulteriori due <em>job</em> con lo scopo di notificarci se la build automation è terminata con successo o con un fallimento. La notifica si basa nel inviare un messaggio su un bot Telegram realizzato appositamente per il progetto (accessibile tramite questo <a href="https://telegram.me/AzureHealthcareNotificator_bot"><em>link</em></a>). Questi <em>job</em> sono stati utilizzati nel workflow del branch <em>development</em> e <em>master</em>.</p>

<ul>
<li><p><strong>jobs-failure</strong>: notifica tramite un messaggio sul bot Telegram che la build è fallita;</p></li>
<li><p><strong>jobs-success</strong>: notifica tramite un messaggio sul bot Telegram che la build è completata con successo.</p></li>
</ul>

<div id="#pic:job-workflow">
  <p align="center">
      <img width="500" src="Images/jobWorkflow.PNG" />
      <center>Immagine 1.2</center>
  </p>
</div>

<h3 id="relazione">Relazione</h3>

<p>La relazione è stata scritta in Latex utilizzando l’editor <a href="https://it.overleaf.com/"><em>Overleaf</em></a>. L’idea era quella di poter sincronizzare <em>Overleaf</em> con il repository del progetto di <em>GitHub</em> così che ad ogni modifica sull’editor corrispondeva un commit sul repository. Purtroppo questa è una funzionalità Premium che <em>Overleaf</em> mette a disposizione e che non abbiamo potuto sfruttare. Oltre alla relazione in <code>.pdf</code> abbiamo realizzato anche quella web tramite le <a href="https://pages.github.com/"><em>GitHub Pages</em></a> consultabile al seguente <a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/"><em>link</em></a>, in cui è possibile vedere i video dell'applicativo realizzato.</p>

<h3 id="test">Test</h3>

<p>I test del progetto si sono concentrati sulla parte di generazione dei valori del simulatore. Non sono stati effettuati test né per la parte relativa ad Azure né per quella legata alla mixed reality. Questo perché nel primo caso, si tratta di un’infrastruttura cloud che non dispone di strumenti per effettuare i test mentre per la parte legata alla mixed reality, la motivazione è data dal troppo tempo richiesto per approfondire questa tematica in contesti come il nostro. Si è utilizzato il framework <em>Visual Studio Unit Testing</em> con la quale ci ha permesso di testare:</p>
<ul>
  
<li><p>la generazione dei valori dei sensori rispetto al valore minimo e massimo che questi possono raggiungere e ai propri valori di delta. In particolare, ogni nuovo valore di un determinato sensore da generare, deve ricadere in un range di <span class="math inline">$\mypm$</span> delta calcolato a partire dal vecchio valore di quel sensore;</p></li>
<li><p>il corretto funzionamento dell’allarme se un valore appartiene (o meno) ad un range per descrivere se tale valore è nella norma o in una situazione di pericolo;</p></li>
<li><p>la corretta generazione decrescente dei valori della batteria;</p></li>
</ul>

<h3 id="quality-assurance">Quality Assurance</h3>

<p>Per quanto riguarda la parte di qualità del codice, la scelta è ricaduta sui servizi <a href="https://www.codefactor.io/"><em>Codefactor</em></a> e <a href="https://deepsource.io/"><em>DeepSource</em></a>.</p>
<p><span>CodeFactor</span> permette di essere facilmente integrabile a repository pubblici di Git Hub analizzando la qualità sintattica del codice. In questo modo ci ha permesso di correggere piccole imprecisioni e di conseguenza aumentarne la qualità. </p><p>Un altro tool molto utile è DeepSource. Questo strumento permette di eseguire l’analisi semantica del codice, consentendo di rilevare diversi problemi, inclusi anti-pattern o rischi di bug in fase di esecuzione dell’applicativo.</p>

<a href="https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/">Indietro</a>
