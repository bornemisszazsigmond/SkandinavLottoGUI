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
        szelveny aktualis = new szelveny();
        Random vel = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSzamok_TextChanged(object sender, EventArgs e)
        {

            aktualis = new szelveny(textBoxSzamok);

            //7 db szám ellenőrzése
            if (aktualis.szamokSzama()) checkBoxTippekSzama.Checked = true;
            else checkBoxTippekSzama.Checked = false;
            labelSzamDb.Text = aktualis.szamokDb().ToString();

            //Nem jó tippek száma
            if (aktualis.nemMegfeleltSzamok() > 0) checkBoxNemMegfeleloSzamok.Checked = true;
            else checkBoxNemMegfeleloSzamok.Checked = false;
            labelNemJoSzam.Text = aktualis.nemMegfeleltSzamok().ToString();

            //Azonos számok
            if (aktualis.azonosSzamok()) checkBoxAzonosSzamok.Checked = true;
            else checkBoxAzonosSzamok.Checked = false;
            
            //Tippek beküldése
            if (!checkBoxTippekSzama.Checked && !checkBoxNemMegfeleloSzamok.Checked && !checkBoxAzonosSzamok.Checked) buttonJatek.Enabled = true;
            else buttonJatek.Enabled = false;
        }

        private void buttonJatek_Click(object sender, EventArgs e)
        {
            sorsoltSzamok(textBoxGepi, labelGepiTalaltDb);
            sorsoltSzamok(textBoxKezi, labelKeziTalaltDb);
        }


        public void sorsoltSzamok(TextBox nev, Label db)
        {
            SortedSet<int> sorsolas = new SortedSet<int>();
            while (sorsolas.Count != 7) sorsolas.Add(vel.Next(1, 36));
            nev.Text = string.Join(" ",sorsolas);

            HashSet<int> metszet = new HashSet<int>();
            foreach (var item in aktualis.megjatszottSzamok) metszet.Add(Convert.ToInt32(item));
            metszet.IntersectWith(sorsolas);
            db.Text = metszet.Count.ToString();
        }
    }
}
