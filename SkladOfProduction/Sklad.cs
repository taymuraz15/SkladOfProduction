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
    public partial class Sklad : Form
    {
        private List<Product> catalog = new List<Product>();
        private List<Product> skladList = new List<Product>();

        public Sklad()
        {
            InitializeComponent();
            ZapolnitCatalog();
        }

        private void ZapolnitCatalog()
        {
            catalog.Add(new Product("Молоко", 7));
            catalog.Add(new Product("Творог", 5));
            catalog.Add(new Product("Клубника", 3));
            catalog.Add(new Product("Куриное филе", 6));
            catalog.Add(new Product("Свежая рыба", 2));
            catalog.Add(new Product("Торт", 4));

            foreach (Product p in catalog)
            {
                listBoxCatalog.Items.Add(p.Name + " (Срок: " + p.OstatokDney + " дн.)");
            }
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCatalog.SelectedIndex != -1)
            {
                int index = listBoxCatalog.SelectedIndex;
                Product vybrannyiProd = catalog[index];

                FormDate oknoDaty = new FormDate();
                oknoDaty.ShowDialog();

                if (oknoDaty.IsConfirmed == true)
                {
                    Product novyiNaSklad = new Product(vybrannyiProd.Name, vybrannyiProd.OstatokDney, oknoDaty.VybrannayaData);
                    skladList.Add(novyiNaSklad);
                    listBoxSklad.Items.Add(novyiNaSklad.Name + " — Поступил: " + novyiNaSklad.DataPostupleniya.ToShortDateString());
                }

                listBoxCatalog.SelectedIndex = -1;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            DateTime segodnya = DateTime.Today;
            List<Product> naUcenkuList = new List<Product>();

            foreach (Product p in skladList)
            {
                DateTime dataOkonchaniya = p.DataPostupleniya.AddDays(p.OstatokDney);

                if (dataOkonchaniya <= segodnya.AddDays(3))
                {
                    naUcenkuList.Add(p);
                }
            }

            skladList = naUcenkuList;
            listBoxSklad.Items.Clear();

            foreach (Product p in skladList)
            {
                listBoxSklad.Items.Add(p.Name + " — Поступил: " + p.DataPostupleniya.ToShortDateString());
            }

            MessageBox.Show("Проверка завершена! На складе оставлены только товары для уценки.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
