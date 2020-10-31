using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkandinavLottoGUI
{
    class szelveny
    {
        public List<string> megjatszottSzamok { get; set; }

        public szelveny(TextBox textBoxString)
        {
            megjatszottSzamok = textBoxString.Text.Split(' ').ToList();
            if (megjatszottSzamok.Last().Equals("")) megjatszottSzamok.RemoveAt(megjatszottSzamok.Count - 1);
        }

        public bool szamokSzama()
        {
            if (megjatszottSzamok.Count != 7) return  true;
            else return false;
        }

        public int szamokDb() { return megjatszottSzamok.Count; }
    }
}
