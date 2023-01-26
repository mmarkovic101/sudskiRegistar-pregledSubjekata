using SudskiRegistar.Classes;
using SudskiRegistar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudskiRegistar
{
    public partial class SudskiRegistarForm : Form
    {
        public SudskiRegistarForm()
        {
            InitializeComponent();
            lblResponse.Text = "";
        }

        private void btnOib_Click(object sender, EventArgs e)
        {
            if (ProvjeriUpis(txtOib.Text))
            {
                Subjekt subjekt = DohvatPodataka.DohvatiPodatke(txtOib.Text);
                if (subjekt != null)
                {
                    rtbDetalji.Text = IspisiSubjekt(subjekt);
                }
                else
                {
                    lblResponse.Text = "Subjekt nije pronađen!";
                }
            }
        }

        private bool ProvjeriUpis(string upis)
        {
            if (upis.Length != 11)
            {
                lblResponse.Text = "Pogrešan unos!";
                return false;
            }
            foreach (Char slovo in upis)
            {
                if (!"0123456789".Contains(slovo))
                {
                    lblResponse.Text = "Pogrešan unos!";
                    return false;
                }
            }

            lblResponse.Text = "";
            return true;
        }
        private string IspisiSubjekt(Subjekt subjekt)
        {
            string ispis = "";

            //Nadlezni sud
            ispis += $"Nadležni sud:\n{subjekt.sud_nadlezan.naziv}\n";

            //Status
            ispis += "\nStatus:\n";

            for (int i = 0; i < subjekt.postupci.Count; i++)
            {
                ispis += $"{subjekt.postupci[i].vrsta.znacenje}\n";
            }

            ispis += "\n";

            // MBS i OIB
            ispis += $"MBS:\n{subjekt.potpuni_mbs}\n\n";
            ispis += $"OIB:\n{subjekt.potpuni_oib}\n";

            //Pravni oblik
            ispis += "\nPravni oblik:\n";

            for (int i = 0; i < subjekt.pravni_oblici.Count; i++)
            {
                ispis += $"{subjekt.pravni_oblici[i].vrsta_pravnog_oblika.naziv}\n";
            }

            //Tvrtka
            ispis += "\nTvrtka:\n";

            for (int i = 0; i < subjekt.tvrtke.Count; i++)
            {
                ispis += $"{subjekt.tvrtke[i].ime}\n";
            }

            //Temeljni kapital
            if (subjekt.temeljni_kapitali != null)
            {
                ispis += "\nTemeljni kapital:\n";

                for (int i = 0; i < subjekt.temeljni_kapitali.Count; i++)
                {
                    ispis += $"{subjekt.temeljni_kapitali[i].iznos} {subjekt.temeljni_kapitali[i].valuta.naziv}\n";
                }
            }
            
            //Predmet poslovanja
            ispis += "\nPredmeti poslovanja:\n";

            for (int i = 0; i < subjekt.predmeti_poslovanja.Count; i++)
            {
                if (subjekt.predmeti_poslovanja[i].nac_klas_djelatnosti != null)
                {
                    ispis += $"{subjekt.predmeti_poslovanja[i].nac_klas_djelatnosti.sifra} {subjekt.predmeti_poslovanja[i].nac_klas_djelatnosti.puni_naziv}\n";
                }
                else
                {
                    ispis += $"{subjekt.predmeti_poslovanja[i].djelatnost_tekst}\n";
                }  
            }

            return ispis;
        }
    }
}
