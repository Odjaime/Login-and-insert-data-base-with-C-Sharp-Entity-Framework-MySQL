using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginTeste.Controllers;
using LoginTeste.Models;

namespace LoginTeste.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            bindCombo();
        }

        public List<navio> vessel { get; set; }

        protected void bindCombo()
        {
            DadosModelo db = new DadosModelo();
            var item = db.navio.ToList();
            ListVessel.DataSource = item;
            ListVessel.DisplayMember = "vesselName";
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            bindCombo();
                
        }


    }
}
