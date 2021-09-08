using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Composite
{
    // classe che permetti di raggruppare gli oggetti
    internal class Composite : IComponent
    {
        private readonly List<IComponent> components = new List<IComponent>();

        // aggiunge un componente alla lista 
        public void Add(IComponent leaf)
        {
            components.Add(leaf);
        }

        // resetto il gruppo di componenti
        public void Clear()
        {
            components.Clear();
        }

        // Metodo del Composite che richiama per ogni componente lo stesso metodo (leaf)
        public string[] ToArrayString()
        {
            var j = 0;
            var rowList = components.Select(component => component.ToArrayString()).ToList();
            var row = new string[rowList.Capacity*rowList.Count]; 
            foreach (var s in rowList.SelectMany(arrayString => arrayString))
            {
                row[j] = s;
                j++;
            }

            return row;
        }

    }
}