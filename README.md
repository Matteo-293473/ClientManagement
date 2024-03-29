# Progetto Programmazione e Modellazione ad Oggetti
Nome : Matteo

Cognome : Pulcinelli

Titolo:	Client Management

### Specifica Progetto
Si richiede di realizzare un software con interfaccia grafica per sistemi Windows-based che consenta la gestione dei clienti. Il software in questione terrà traccia dei clienti e delle varie commissioni
associate ad essi. Dei clienti ci interessano nome, cognome, il numero di telefono e email, mentre per ogni commissione ci interessano
la data di scadenza e la descrizione.

Il software sarà composto da un menù principale con 4 tab 

* **Home**: Questa è la schermata principale con cui si apre il software, all'interno
troviamo la lista delle commissioni con scadenza in settimana e la possibilità di visualizzare, modificare
 e aggiungere commissioni. Sempre in questa schermata si ha la possibilità di salvare le modifiche apportate.
* **Rubrica**: In questa schermata troviamo tutti i contatti salvati con la possibilità di aggiungerne nuovi, modificare quelli già presenti o eliminarli (eliminando tutte le relative commissioni).
* **Commissioni**: Qui possiamo visualizzare tutte le commissioni (completate e non). Anche qui sono presenti i tasti visualizza, modifica e elimina.
* **Scadenze**: In quest'ultima tab verranno mostrate solo le commissioni non ancora completate, con la possibilità di visualizzarle.

Il software inoltre offre la possibilità di salvare i dati in locale in formato Json per un eventuale
salvataggio su database.

Ogni elemento, cliente o commissione che sia, può essere visualizzato aggiunto, modificato o eliminato.
Una volta selezionato un elemento.
Quando si richiede la modifica, verrà mostrata una schermata dedicata, mentre per quanto concerne l'eliminazione  
sarà richiesta una conferma prima di eliminare definitivamente l'elemento.