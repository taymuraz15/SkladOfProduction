using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkladOfProduction
{
    public partial class FormDate : Form
    {
        public DateTime VybrannayaData { get; private set; }
        public bool IsConfirmed = false;
        public FormDate()
        {
            InitializeComponent();
            datetimeAddProdutcToSklad.Value = DateTime.Today;
        }

        private void FormDate_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            VybrannayaData = datetimeAddProdutcToSklad.Value;
            IsConfirmed = true; 
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
