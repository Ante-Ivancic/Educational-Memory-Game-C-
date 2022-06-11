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
    public partial class Igra4x4 : Form
    {
        //Objasnjeno u Igra3x4

        public static int BrojPoteza = 0;
        public static int MeduPotez = 0;
        public static int ParovaPronadeno = 0;
        public static int TrenutniPar = 0;
        public static int RedniBrojIgre = 0;
        public static List<Kartica> lstMemory = new List<Kartica>();
        public static List<PictureBox> lstPictureBox = new List<PictureBox>();
        public Igra4x4(List<Kartica> memory, int RedniBroj)
        {
            InitializeComponent();
            BrojPoteza = 0;
            MeduPotez = 0;
            ParovaPronadeno = 0;
            TrenutniPar = 0;
            lstPictureBox.RemoveRange(0, lstPictureBox.Count());
            RedniBrojIgre = RedniBroj;
            lstMemory = memory;
            List<Label> lstLabel = new List<Label>();
            lstLabel.Add(label1);
            lstLabel.Add(label2);
            lstLabel.Add(label3);
            lstLabel.Add(label4);
            lstLabel.Add(label5);
            lstLabel.Add(label6);
            lstLabel.Add(label7);
            lstLabel.Add(label8);
            lstLabel.Add(label9);
            lstLabel.Add(label10);
            lstLabel.Add(label11);
            lstLabel.Add(label12);
            lstLabel.Add(label13);
            lstLabel.Add(label14);
            lstLabel.Add(label15);
            lstLabel.Add(label16);
            lstPictureBox.Add(pictureBox1);
            lstPictureBox.Add(pictureBox2);
            lstPictureBox.Add(pictureBox4);
            lstPictureBox.Add(pictureBox3);
            lstPictureBox.Add(pictureBox5);
            lstPictureBox.Add(pictureBox6);
            lstPictureBox.Add(pictureBox7);
            lstPictureBox.Add(pictureBox8);
            lstPictureBox.Add(pictureBox9);
            lstPictureBox.Add(pictureBox10);
            lstPictureBox.Add(pictureBox11);
            lstPictureBox.Add(pictureBox12);
            lstPictureBox.Add(pictureBox13);
            lstPictureBox.Add(pictureBox14);
            lstPictureBox.Add(pictureBox15);
            lstPictureBox.Add(pictureBox16);
            ListaKartica.PromijesajKartice(lstMemory);
            int f = 0;
            foreach (Label lbl in lstLabel)
            {
                lbl.BackColor = Color.Transparent;
                lbl.Text = lstMemory[f].tekst;

                f++;
            }
        }

        private void tmrPronadenPar_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in lstPictureBox)
            {

                pb.Enabled = false;
                if (pb.Visible == false)
                {
                    pb.BackColor = Color.Transparent;
                    pb.Image = null;
                    pb.Visible = true;
                }
            }
            bool EveryPbTransparent = true;
            foreach (PictureBox pb in lstPictureBox)
            {
                if (pb.BackColor != Color.Transparent)
                {
                    EveryPbTransparent = false;
                    break;
                }
            }
            if (EveryPbTransparent == true)
            {
                foreach (PictureBox pb in lstPictureBox)
                {
                    pb.Visible = false;
                }
                if (RedniBrojIgre != 0)
                {
                    Admin.AzuriranjeKorisnikaNakonZavrseneIgre(RedniBrojIgre);
                }
            }
            foreach (PictureBox pb in lstPictureBox)
            {
                if (pb.BackColor != Color.Transparent)
                {
                    pb.Enabled = true;
                }
            }
            TrenutniPar = 0;
            TrenutniPar = 0;
            tmrPronadenPar.Enabled = false;
        }

        private void tmrKriviPar_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in lstPictureBox)
            {
                if (pb.Visible == false)
                {
                    pb.Visible = true;
                }
                if (pb.BackColor != Color.Transparent)
                    pb.Enabled = true;
            }
            TrenutniPar = 0;
            TrenutniPar = 0;
            tmrKriviPar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox1.Visible = false;
                    TrenutniPar = lstMemory[0].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[0].par)
                    {

                        pictureBox1.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[0].par)
                    {
                        pictureBox1.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez = MeduPotez + 1;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox2.Visible = false;
                    TrenutniPar = lstMemory[1].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[1].par)
                    {
                        pictureBox2.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[1].par)
                    {
                        pictureBox2.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox3.Visible = false;
                    TrenutniPar = lstMemory[2].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[2].par)
                    {
                        pictureBox3.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[2].par)
                    {
                        pictureBox3.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox4.Visible = false;
                    TrenutniPar = lstMemory[3].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[3].par)
                    {
                        pictureBox4.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[3].par)
                    {
                        pictureBox4.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox5.Visible = false;
                    TrenutniPar = lstMemory[4].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[4].par)
                    {
                        pictureBox5.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[4].par)
                    {
                        pictureBox5.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox6.Visible = false;
                    TrenutniPar = lstMemory[5].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[5].par)
                    {
                        pictureBox6.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[5].par)
                    {
                        pictureBox6.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox7.Visible = false;
                    TrenutniPar = lstMemory[6].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[6].par)
                    {
                        pictureBox7.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[6].par)
                    {
                        pictureBox7.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox8.Visible = false;
                    TrenutniPar = lstMemory[7].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[7].par)
                    {
                        pictureBox8.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[7].par)
                    {
                        pictureBox8.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox9.Visible = false;
                    TrenutniPar = lstMemory[8].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[8].par)
                    {
                        pictureBox9.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[8].par)
                    {
                        pictureBox9.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox10.Visible = false;
                    TrenutniPar = lstMemory[9].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[9].par)
                    {
                        pictureBox10.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[9].par)
                    {
                        pictureBox10.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox11.Visible = false;
                    TrenutniPar = lstMemory[10].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[10].par)
                    {
                        pictureBox11.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[10].par)
                    {
                        pictureBox11.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox12.Visible = false;
                    TrenutniPar = lstMemory[11].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[11].par)
                    {
                        pictureBox12.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[11].par)
                    {
                        pictureBox12.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox13.Visible = false;
                    TrenutniPar = lstMemory[12].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[12].par)
                    {
                        pictureBox13.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[12].par)
                    {
                        pictureBox13.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox14.Visible = false;
                    TrenutniPar = lstMemory[13].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[13].par)
                    {
                        pictureBox14.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[13].par)
                    {
                        pictureBox14.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox15.Visible = false;
                    TrenutniPar = lstMemory[14].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false; pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;

                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[14].par)
                    {
                        pictureBox15.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[14].par)
                    {
                        pictureBox15.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (ParovaPronadeno != (lstMemory.Count / 2) - 1)
            {
                MeduPotez++;
                if (MeduPotez % 2 == 1)
                {
                    pictureBox16.Visible = false;
                    TrenutniPar = lstMemory[15].par;
                }
                else if (MeduPotez % 2 == 0)
                {
                    pictureBox1.Enabled = pictureBox10.Enabled = pictureBox11.Enabled = pictureBox12.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = pictureBox6.Enabled = pictureBox7.Enabled = pictureBox8.Enabled = pictureBox9.Enabled = false;
                    pictureBox13.Enabled = pictureBox14.Enabled = pictureBox15.Enabled = pictureBox16.Enabled = false;
                    MeduPotez = 0;
                    BrojPoteza++;
                    lblBrojPoteza.Text = "Broj poteza: " + BrojPoteza.ToString();

                    if (TrenutniPar == lstMemory[15].par)
                    {
                        pictureBox16.Visible = false;
                        tmrPronadenPar.Enabled = true;
                    }
                    else if (TrenutniPar != lstMemory[15].par)
                    {
                        pictureBox16.Visible = false;
                        tmrKriviPar.Enabled = true;
                    }
                }
            }

        }
    }
}
