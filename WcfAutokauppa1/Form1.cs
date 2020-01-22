using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfAutokauppa1
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client registerHandler = new ServiceReference1.Service1Client();


        ServiceReference1.Auto nykAuto = new ServiceReference1.Auto();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e) //
        {
            merkkiCB.DataSource = registerHandler.getAllAutoMakers();
            merkkiCB.DisplayMember = "MerkkiNimi";
            merkkiCB.ValueMember = "Id";
        }

        private void LisaaMallit(object sender, EventArgs e) //Lisää mallit 
        {
            try
            {
                if (merkkiCB.SelectedValue is int)
                {
                    int MerkkiId = (int)merkkiCB.SelectedValue;
                    var mallit = registerHandler.getAutoModels(MerkkiId);
                    malliCB.DataSource = mallit;
                    malliCB.DisplayMember = "MalliNimi";
                    malliCB.ValueMember = "Id";
                    variCB.DataSource = registerHandler.GetCarColors();
                    variCB.DisplayMember = "Varin_nimi";
                    variCB.ValueMember = "Id";
                    polttoaineCB.DataSource = registerHandler.GetCarFuels();
                    polttoaineCB.DisplayMember = "Polttoaineen_nimi";
                    polttoaineCB.ValueMember = "Id";
                }
            }
            catch
            {

            }
        }


        private void testaaTietokantayhteyttä_Click(object sender, EventArgs e)
        {
            if (registerHandler.TestDatabaseConnection())
            {
                MessageBox.Show("Toimii", "Message");
            }

            else
            {
                MessageBox.Show("Ei toimi", "Message");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void uusitietue_Click(object sender, EventArgs e)//Tyhjentää kaikki kentät
        {
            ClearBoxes(this);
        }


        void ClearBoxes(Control control) // tyhjennä kentän toiminnot
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }

                else
                {
                    ClearBoxes(c);
                }
            }

        }



        private void tallennna_Click(object sender, EventArgs e)// Tallentaa auton
        {
            ServiceReference1.Auto kultainenhaikala = new ServiceReference1.Auto();
            kultainenhaikala.AutonMerkkiID = (int)merkkiCB.SelectedValue;
            kultainenhaikala.AutonMalliID = (int)malliCB.SelectedValue;
            kultainenhaikala.VaritID = (int)variCB.SelectedValue;
            kultainenhaikala.PolttoaineID = (int)polttoaineCB.SelectedValue;
            kultainenhaikala.Moottorin_Tilavuus = decimal.Parse(moottoritilavuusCB.Text);
            kultainenhaikala.Hinta = decimal.Parse(hintaCB.Text);
            kultainenhaikala.Mittarilukema = int.Parse(mittarilukemaCB.Text);
            kultainenhaikala.Rekisteri_paivamaara = rekisterointipvaCB.Value;

            registerHandler.saveAuto(kultainenhaikala);

            MessageBox.Show("Auto tallennettu", "Message");
            ClearBoxes(this);
        }


        private void seuraava_Click(object sender, EventArgs e)
        {
            nykAuto = registerHandler.NextAuto(nykAuto.Id);
            TulostaAuto(nykAuto);
        }


        private void TulostaAuto(ServiceReference1.Auto uusiAuto)
        {
            merkkiCB.SelectedValue = uusiAuto.AutonMerkkiID;
            malliCB.SelectedValue = uusiAuto.AutonMalliID;
            variCB.SelectedValue = uusiAuto.VaritID;
            polttoaineCB.SelectedValue = uusiAuto.PolttoaineID;
            moottoritilavuusCB.Text = uusiAuto.Moottorin_Tilavuus.ToString();
            hintaCB.Text = uusiAuto.Hinta.ToString();
            mittarilukemaCB.Text = uusiAuto.Mittarilukema.ToString();
            rekisterointipvaCB.Text = uusiAuto.Rekisteri_paivamaara.ToString();

        }

        private void edellinen_Click(object sender, EventArgs e)
        {
            nykAuto = registerHandler.PrevAuto(nykAuto.Id);
            TulostaAuto(nykAuto);
        }

    }
}
