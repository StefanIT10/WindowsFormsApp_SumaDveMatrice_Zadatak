using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDvejuMatrica
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();

        }

        int red1, kol1, red2, kol2, sumaPrveMat = 0, sumaDrugeMat = 0, suma = 0;
        int[,] matrica1;
        int[,] matrica2;

        

        private void btnUnesiRedMat2_Click(object sender, EventArgs e)
        {
            red2 = Convert.ToInt32(txtBoxRedMat2.Text);
            txtBoxRedMat2.Enabled = false;
            btnUnesiRedMat2.Enabled = false;
        }

        private void btnUnesiKolMat2_Click(object sender, EventArgs e)
        {
            kol2 = Convert.ToInt32(txtBoxKolMat2.Text);
            txtBoxKolMat2.Enabled = false;
            btnUnesiKolMat2.Enabled = false;
            matrica2 = new int[red2, kol2];
        }

       

        private void btnGenerisiMat2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < red2; i++)
            {
                for (int j = 0; j < kol2; j++)
                {
                    matrica2[i, j] = random.Next(0, 999);

                }
            }
            MessageBox.Show("Matrica2 koja se sastoji od random brojeva je uspesno generisana.",
                "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGenerisiMat2.Enabled = false;
        }

        

        private void btnPrikaziMat2_Click(object sender, EventArgs e)
        {
            txtBoxPrikazMat2.Clear();
            for (int i = 0; i < red2; i++)
            {
                for (int j = 0; j < kol2; j++)
                {
                    txtBoxPrikazMat2.AppendText(matrica2[i, j] + "\t");
                }
                txtBoxPrikazMat2.AppendText(Environment.NewLine);
            }
            btnPrikaziMat2.Enabled = false;
            txtBoxPrikazMat2.Enabled = false;
        }

        

        private void btnSumaElMat2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < red2; i++)
            {
                for (int j = 0; j < kol2; j++)
                {
                    sumaDrugeMat += matrica2[i, j];
                }
            }
            lblRezMat2.Text = sumaDrugeMat + ".";
            btnSumaElMat2.Enabled = false;
        }



        private void btnUnesiRedMat1_Click(object sender, EventArgs e)
        {
            red1 = Convert.ToInt32(txtBoxRedMat1.Text);
            txtBoxRedMat1.Enabled = false;
            btnUnesiRedMat1.Enabled = false;
         
        }

        private void btnUnesiKolMat1_Click(object sender, EventArgs e)
        {
            kol1 = Convert.ToInt32(txtBoxKolMat1.Text);
            txtBoxKolMat1.Enabled = false;
            btnUnesiKolMat1.Enabled = false;
            matrica1 = new int[red1, kol1];
        }

        private void btnUnesiElMat1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < red1; i++)
            {
                for (int j = 0; j < kol1; j++)
                {
                    matrica1[i, j] = random.Next(0, 999);
                    
                }
            }
            MessageBox.Show("Matrica1 koja se sastoji od random brojeva je uspesno generisana.", 
                "Obavestenje",MessageBoxButtons.OK, MessageBoxIcon.Information );
            btnGenerisi.Enabled = false;
        }


        private void btnPrikaziMat1_Click(object sender, EventArgs e)
        {
            txtBoxPrikazMat1.Clear();
            for (int i = 0; i < red1; i++)
            {
                for (int j = 0; j < kol1; j++)
                {
                    txtBoxPrikazMat1.AppendText(matrica1[i, j] + "\t");
                }
                txtBoxPrikazMat1.AppendText(Environment.NewLine);
            }
            btnPrikaziMat1.Enabled = false;
            txtBoxPrikazMat1.Enabled = false;
        }

        private void btnSumaMat1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < red1; i++)
            {
                for (int j = 0; j < kol1; j++)
                {
                    sumaPrveMat += matrica1[i, j];
                }
            }
            lblRezMat1.Text = sumaPrveMat + ".";
            btnSumaMat1.Enabled = false;
        }

        private void btnKonacnaSumaRez_Click(object sender, EventArgs e)
        {
            suma = sumaPrveMat + sumaDrugeMat;
            lblKonacnaSumaRezultat.Text = suma + ".";
            btnKonacnaSumaRez.Enabled = false;
        }
    }
}
