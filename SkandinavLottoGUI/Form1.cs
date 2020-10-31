using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkandinavLottoGUI
{
    public partial class Form1 : Form
    {
        List<string> szamok = new List<string>();
        Random vel = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSzamok_TextChanged(object sender, EventArgs e)
        {

            szelveny aktualis = new szelveny(textBoxSzamok);
            
            //7 db szám ellenőrzése
            if(aktualis.szamokSzama()) checkBoxTippekSzama.Checked = true;
            else checkBoxTippekSzama.Checked = false;
            labelSzamDb.Text = aktualis.szamokDb().ToString();


            //szamok = textBoxSzamok.Text.Split(' ').ToList();
            //if (szamok.Last().Equals("")) szamok.RemoveAt(szamok.Count-1);

            /*dbSzamok();
            dbJoSzam();
            if (!checkBoxNemMegfeleloSzamok.Checked) azonosSzamok();

            if (!checkBoxTippekSzama.Checked && !checkBoxNemMegfeleloSzamok.Checked && !checkBoxAzonosSzamok.Checked) buttonJatek.Enabled = true;
            else buttonJatek.Enabled = false;*/
        }

        /*private void azonosSzamok()
        {
            HashSet<int> ellenorzes = new HashSet<int>();
            foreach (var item in szamok) ellenorzes.Add(Convert.ToInt32(item));
            if (ellenorzes.Count != szamok.Count) checkBoxAzonosSzamok.Checked = true;
            else checkBoxAzonosSzamok.Checked = false;
        }*/

        /*private void dbJoSzam()
        {          
            int db = 0;
            foreach (var item in szamok)
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
            if(db>0) checkBoxNemMegfeleloSzamok.Checked = true;
            else checkBoxNemMegfeleloSzamok.Checked = false;
            labelNemJoSzam.Text = db.ToString();
        }
        */
        
        /*public void sorsoltSzamok(TextBox nev, Label db)
        {
            SortedSet<int> sorsolas = new SortedSet<int>();
            while (sorsolas.Count != 7) sorsolas.Add(vel.Next(1, 36));
            nev.Text = string.Join(" ",sorsolas);

            HashSet<int> metszet = new HashSet<int>();
            foreach (var item in szamok) metszet.Add(Convert.ToInt32(item));
            metszet.IntersectWith(sorsolas);
            db.Text = metszet.Count.ToString();
        }*/
        
        private void buttonJatek_Click(object sender, EventArgs e)
        {
            //sorsoltSzamok(textBoxGepi, labelGepiTalaltDb);
            //sorsoltSzamok(textBoxKezi, labelKeziTalaltDb);
        }
    }
}
