using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginTeste.Models;
using LoginTeste.View;

namespace LoginTeste.View
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var db = new DadosModelo();

            var Navio = db.Set<navio>();
            Navio.Add(new navio
            {
                idNavio = 01,
                vesselName = vesselName.Text,
                flag = flag.Text,
                callSign = callSign.Text,
                imo = Convert.ToInt32(imo.Text),
                loa = Convert.ToInt32(loa.Text),
                nrt = Convert.ToInt32(nrt.Text),
                grt = Convert.ToInt32(grt.Text),
                dwt = Convert.ToInt32(dwt.Text),
                builtYear = Convert.ToInt16(built.Text)
            });

            db.SaveChanges();

            MessageBox.Show("Navio cadastrado com sucesso");

            this.Close();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
