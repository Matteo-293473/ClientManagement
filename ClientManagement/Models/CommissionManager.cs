﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Models
{
    static class CommissionManager
    {
        //private static CommissionManager instance = null;
        public static Dictionary<int, List<Commissione>> clienteCommissioni = new Dictionary<int, List<Commissione>>();

        public static Dictionary<int, Cliente> clienti = new Dictionary<int, Cliente>();
        
        //private static List<Commissione> commissioni = new List<Commissione>();


        public static event EventHandler<Dictionary<int, List<Commissione>>> OnClienteCommissioniCambia;

        public static event EventHandler<Dictionary<int, Cliente>> OnClientiCambia;



        // facciamo iniziare il valore a 1 perché quando ritorna un valore non trovato il valore è 0
        private static int value = 1; 


        //applichiamo l'overload
        public static void AggiungiEntry(Cliente cl)
        {
            var c = confrontaChiave(cl);

            if (clienti.ContainsKey(c))
                throw new Exception("Il cliente è già presente");

            // aggiungo il cliente
            clienti.Add(value, cl);
            value += 1;
            OnClientiCambia?.Invoke(cl, clienti);
            
        }


        public static void AggiungiEntry(Cliente cl, Commissione cm)
        {
            List<Commissione> commissioni = new List<Commissione>();

            var c = confrontaChiave(cl);

            if (clienteCommissioni.ContainsKey(c))
            {
                // se il cliente non esiste nè tra le commissioni nè nella rubrica

                // aggiungi cm alla lista delle commissioni del cliente
                //clienteCommissioni.Add(cl, commissioni);
                commissioni = clienteCommissioni[c];
                commissioni.Add(cm);
                clienteCommissioni[c] = commissioni;
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
            }
            
            else if(clienti.ContainsKey(c))
            {
                
                // se il cliente non esiste tra le commissioni ma esiste nella rubrica

                commissioni.Add(cm);
                clienteCommissioni.Add(c, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
            }
            else
            {
                // se il cliente non esiste

                commissioni.Add(cm);
                clienti.Add(value, cl);
                OnClientiCambia?.Invoke(cl, clienti);
                clienteCommissioni.Add(value, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
                value += 1; // aggiorno il valore. Autoincrement
            }
            
        }



        private static int confrontaChiave(Cliente cl)
        {
            return clienti.Where(s =>
                clienti[s.Key].Nome == cl.Nome &&
                clienti[s.Key].Cognome == cl.Cognome &&
                clienti[s.Key].Numero == cl.Numero).Select(s => s.Key).FirstOrDefault();
            // nel caso in cui il cliente non si trova nella lista clienteCommissioni, viene restituito il valore 0


        }


    }
}
