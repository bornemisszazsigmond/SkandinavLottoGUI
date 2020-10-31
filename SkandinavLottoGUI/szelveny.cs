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

        public szelveny()
        {

        }

        public bool szamokSzama()
        {
            if (megjatszottSzamok.Count != 7) return  true;
            else return false;
        }

        public int szamokDb() { return megjatszottSzamok.Count; }

        public int nemMegfeleltSzamok()
        {
            int db = 0;
            foreach (var item in megjatszottSzamok)
            {
                try
                {
                    if (Convert.ToInt32(item) < 1 || Convert.ToInt32(item) > 35) db++;
                }
                catch (Exception)
                {
                    db++;
                }
            }
            return db;
        }

        public bool azonosSzamok()
        {
            HashSet<int> ellenorzes = new HashSet<int>();
            foreach (var item in megjatszottSzamok) ellenorzes.Add(Convert.ToInt32(item));
            if (ellenorzes.Count != megjatszottSzamok.Count) return true;
            else return false;
        }
    }
}
