using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace ClientManagement.Extensions
{

    // Classe dedicata al controllo degli errori
    static class Controllo
    {
        // Controllo caratteri, utilizzato all'interno delle textbox
        public static void ControllaNumeri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void ControllaCaratteri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void ControllaSpazi(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        // Controllo sulla selezione dell'elemento nella ListView
        public static void ControlloListViewSelezione(ListView listView)
        {
            if (listView.Items.Count == 0)
                throw new Exception("Non sono presenti elementi");

            if (listView.SelectedItems.Count == 0)
                throw new Exception("Seleziona un elemento dalla lista");

            if (listView.SelectedItems.Count > 1)
                throw new Exception("Seleziona un solo elemento dalla lista");
        }



        public static void ControlloInputCliente(string nome, string cognome, string numero, string email)
        {
            // controllo degli input
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) ||
                string.IsNullOrEmpty(numero))
                throw new Exception("Uno dei campi è vuoto");

            // usiamo una libreria per controllare la validità dell'email
            // nel caso in cui l'email sia in un formato sbagliato, viene
            // generata un'eccezione
            var mail = new MailAddress(email);

            // il numero di telefono in genere ha tra le 10 e le 15 cifre
            if (!numero.Any(char.IsLetter) && (numero.Length > 15
                                               || numero.Length < 10))
                throw new Exception("Numero di telefono non valido");

            if (!cognome.All(char.IsLetter))
                throw new Exception("Cognome non valido, ci sono caratteri errati");

            if (!numero.All(char.IsDigit))
                throw new Exception("Numero di telefono non valido");

            if (!nome.All(char.IsLetter))
                throw new Exception("Nome non valido, ci sono caratteri errati");

            if (nome.Length > 20)
                throw new Exception("Nome troppo lungo, Max 20 caratteri");

            if (cognome.Length > 20)
                throw new Exception("Cognome troppo lungo, Max 20 caratteri");

            if (email.Length > 40)
                throw new Exception("Email troppo lunga, Max 20 caratteri");


        }


        public static void ControlloInputCommissione(string descrizione, DateTime data)
        {
            if (String.IsNullOrEmpty(descrizione))
                throw new Exception("Il campo \"descrizione della commissione\" non può essere vuoto");

            if (data.Date < DateTime.Now.Date)  // controlliamo che non sia una data passata
                throw new Exception("La data non può essere una passata");
        }


        // usiamo questo metodo per la modifica delle commissioni
        public static void ControlloInputCommissione(string descrizione, DateTime dataScelta, DateTime oldData)
        {
            if (string.IsNullOrEmpty(descrizione))
                throw new Exception("Il campo \"descrizione della commissione\" non può essere vuoto");

            // Non si può scegliere una data passata diversa da quella che era stata inserita
            if (dataScelta.Date != oldData.Date && oldData.Date < DateTime.Now.Date && dataScelta.Date < DateTime.Now.Date)
                throw new Exception("Non si può scegliere una data passata differente da quella che già c'era");

            if (oldData.Date >= DateTime.Now.Date && dataScelta.Date < DateTime.Now.Date)
                throw new Exception("La data non può essere una passata");

        }

    }
}
