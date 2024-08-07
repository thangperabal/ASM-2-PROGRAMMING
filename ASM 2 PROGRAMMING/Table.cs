using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_2_PROGRAMMING
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            comboBoxCustomerType.SelectedIndex = 0;
            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtName.Text;
                double lastMonthReading = Convert.ToDouble(txtLast.Text);
                double thisMonthReading = Convert.ToDouble(txtThis.Text);
                string customerType = comboBoxCustomerType.SelectedItem.ToString();
                int numberOfPeople = int.Parse(comboBoxNumOfPeople.Text); 

                double waterConsumed = thisMonthReading - lastMonthReading;
                double totalBill = CalculateTotalWaterBill(customerType, waterConsumed, numberOfPeople);
                string[] row = { customerName, lastMonthReading.ToString(), thisMonthReading.ToString(),
                    waterConsumed.ToString(), customerType, numberOfPeople.ToString(), totalBill.ToString("C") };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                txtName.Clear();
                txtLast.Clear();
                txtThis.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtName.Text;
                double lastMonthReading = Convert.ToDouble(txtLast.Text);
                double thisMonthReading = Convert.ToDouble(txtThis.Text);
                string customerType = comboBoxCustomerType.SelectedItem.ToString();
                int numberOfPeople = int.Parse(comboBoxNumOfPeople.Text);

                double waterConsumed = thisMonthReading - lastMonthReading;
                double totalBill = CalculateTotalWaterBill(customerType, waterConsumed, numberOfPeople);

                string result = "Bill:\r\n" +
                                $"Customer Name: {customerName}\r\n" +
                                $"Last Month Reading: {lastMonthReading}\r\n" +
                                $"This Month Reading: {thisMonthReading}\r\n" +
                                $"Water Consumed: {waterConsumed}\r\n" +
                                $"Customer Type: {customerType}\r\n" +
                                $"Number of People: {numberOfPeople}\r\n" +
                                $"Total Bill: {totalBill:C}";

                txtShow.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public double CalculateWaterPrices(string customerType, double waterConsumed, double numberOfPeople)
        {
            double price = 0;

            if (customerType == "household")
            {
                double waterAmountPerPerson = waterConsumed / numberOfPeople;
                if (waterAmountPerPerson <= 10)
                {
                    price = 5973 * waterConsumed;
                }
                else if (waterAmountPerPerson <= 20)
                {
                    price = 7052 * waterConsumed;
                }
                else if (waterAmountPerPerson <= 30)
                {
                    price = 8699 * waterConsumed;
                }
                else 
                {
                    price = 15929 * waterConsumed;
                }
            }
            else if (customerType == "administrative")
            {
                price = 9955 * waterConsumed;
            }
            else if (customerType == "production")
            {
                price = 11615 * waterConsumed;
            }
            else if (customerType == "business")
            {
                price = 22068 * waterConsumed;
            }

            return price;
        }

        public double CalculateTotalWaterBill(string customerType, double waterConsumed, double numberOfPeople)
        {
            double price = CalculateWaterPrices(customerType, waterConsumed, numberOfPeople);
            double environmentalProtectionFee = price * 0.10;
            double totalInvoiceWithoutVAT = price + environmentalProtectionFee;
            double VAT = 0.10 * totalInvoiceWithoutVAT;
            double totalBill = totalInvoiceWithoutVAT + VAT;

            return totalBill;
        }


        private void btnSE_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.ToLower();
            foreach (ListViewItem item in listView1.Items)
            {
                bool itemContainsSearchQuery = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchQuery))
                    {
                        itemContainsSearchQuery = true;
                        break;
                    }
                }

                item.BackColor = itemContainsSearchQuery ? Color.Yellow : Color.White;

            }

        }


        private int currentColumn = -1;

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (currentColumn >= 0)
            {
                if (listView1.Sorting == SortOrder.Ascending)
                {
                    listView1.Sorting = SortOrder.Descending;
                }
                else
                {
                    listView1.Sorting = SortOrder.Ascending;
                }
            }
            else
            {
                currentColumn = 0;
                listView1.Sorting = SortOrder.Ascending;
            }

            listView1.ListViewItemSorter = new ListViewItemComparer(currentColumn, listView1.Sorting);

        }

        public class ListViewItemComparer : System.Collections.IComparer
        {
            private int column;
            private SortOrder order;

            public ListViewItemComparer(int column, SortOrder order)
            {
                this.column = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                ListViewItem item1 = (ListViewItem)x;
                ListViewItem item2 = (ListViewItem)y;

                int result = String.Compare(item1.SubItems[column].Text, item2.SubItems[column].Text);

                if (order == SortOrder.Descending)
                {
                    result = -result;
                }

                return result;
            }
        }
    }
}


