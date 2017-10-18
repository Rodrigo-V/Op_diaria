using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Op_Diaria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();


        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
           


        }
        private void PictureBox1_Click(object sender, EventArgs e)

        {

            this.label3.Text = "Cargando componentes del formulario";




            for (int i = 1; i <= 100; i++)
            {


                Thread.Sleep(100);
                progressBar1.Value = i;
                progressBar1.Update();


            }

           

            
                     
            registro res = new registro();
            res.Show();
            this.Hide();


        }

       
    }


}   

        

        
         







            
        
    

    

  

