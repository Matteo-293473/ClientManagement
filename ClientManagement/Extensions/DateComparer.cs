using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Extensions
{
    // questa classe ci permette di confrontare due oggetti al fine di creare una lista ordinata
    class DateComparer : IComparer
    {
        private readonly int pointsColumnIndex = 0;

        public DateComparer(int indiceColonna)
        {
            this.pointsColumnIndex = indiceColonna;
        }

        // metodo per paragonare due date
        public int Compare(object x, object y)
        {
            var valoreX = DateTime.Parse(((ListViewItem) x).SubItems[pointsColumnIndex].Text);
            var valoreY = DateTime.Parse(((ListViewItem) y).SubItems[pointsColumnIndex].Text);
            return valoreY.CompareTo(valoreX);
        }
    }
}
