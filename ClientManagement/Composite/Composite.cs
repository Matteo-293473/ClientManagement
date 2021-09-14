using System.Collections.Generic;
using System.Linq;

namespace ClientManagement.Composite
{
    // classe che permetti di raggruppare gli oggetti
    internal class Composite : IComponent
    {
        // lista che compone il gruppo di oggetti
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

        // Metodo del Composite che richiama per ogni componente (leaf) lo stesso metodo (ToArrayString())
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