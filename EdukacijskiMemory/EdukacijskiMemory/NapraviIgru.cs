using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdukacijskiMemory
{
    public partial class NapraviIgru : Form
    {
            public static List<TextBox> lstTextBox = new List<TextBox>();
        //Omogućava korisniku unos 3x4 igara
        public NapraviIgru()
        {
            InitializeComponent();
            lstTextBox.Add(tbImeIgre);
            lstTextBox.Add(tb1par1);
            lstTextBox.Add(tb1par2);
            lstTextBox.Add(tb2par1);
            lstTextBox.Add(tb2par2);
            lstTextBox.Add(tb3par1);
            lstTextBox.Add(tb3par2);
            lstTextBox.Add(tb4par1);
            lstTextBox.Add(tb4par2);
            lstTextBox.Add(tb5par1);
            lstTextBox.Add(tb5par2);
            lstTextBox.Add(tb6par1);
            lstTextBox.Add(tb6par2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool SvePopunjeno = true;
            foreach (TextBox tb in lstTextBox)
            {
                if(tb.Text=="")
                {
                    SvePopunjeno = false;
                    break;
                }
            }
            if (SvePopunjeno == false)
            {
                MessageBox.Show("Sva polja moraju biti popunjana");
            }
            else if (SvePopunjeno == true)
            {
                string[] RazlomljenaLinija = new string[14];
                RazlomljenaLinija[0] = MainMenu.Korisnik[0];
                int i = 1;
                foreach (TextBox tb in lstTextBox)
                {
                    RazlomljenaLinija[i] = tb.Text;
                    i++;
                }
                Admin.UpisIgre3x4(RazlomljenaLinija);
                foreach (TextBox tb in lstTextBox)
                {
                    tb.Clear();
                }
            }
        }
    }
}
