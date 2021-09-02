using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Composite
{
    // classe che funge da gruppo di oggetti
    class Composite : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent leaf)
        {
            components.Add(leaf);
        }

        public void Clear()
        {
            components.Clear();
        }

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

        public static ListViewItem ToListView(IComponent item)
        {
            var row = item.ToArrayString();
            return new ListViewItem(row);
        }
    }
}