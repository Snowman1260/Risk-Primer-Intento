using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk_Primer_Intento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnP1FirstCountry_Click(object sender, EventArgs e)
        {
            AgregarNumeros(btnP1FirstCountry, lblTurno);
        }

        private void btnP1SecondCountry_Click(object sender, EventArgs e)
        {
            AgregarNumeros(btnP1SecondCountry, lblTurno);
        }

        private void btnP1ThirdCountry_Click(object sender, EventArgs e)
        {
            AgregarNumeros(btnP1ThirdCountry, lblTurno);
        }


        private void btnP1FourthCountry_Click(object sender, EventArgs e)
        {
            AgregarNumeros(btnP1FourthCountry, lblTurno);
        }


        void AgregarNumeros(Button BotonCountry, Label Turno)
        {

            int contador = 0;

            if (Turno.Text=="0")
            {
                int botonesNumero;
                botonesNumero = Convert.ToInt32(BotonCountry.Text);
                botonesNumero++;
                BotonCountry.Text = botonesNumero.ToString();


            }
           
        }

    }
}
