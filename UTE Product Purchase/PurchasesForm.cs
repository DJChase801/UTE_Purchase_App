using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTE_Product_Purchase
{
    public partial class PurchasesForm : Form
    {
        public PurchasesForm()
        {
            InitializeComponent();
            GetData();
            GetTotals();
            SetLatestDate();
        }

        private void GetTotals()
        {

            if (purchaseDataGrid.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in purchaseDataGrid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool isDone = false;
                        var name = row.Cells[0].Value.ToString().Trim();
                        var prod = row.Cells[1].Value.ToString();

                        if (totalGridView.Rows.Count > 1)
                        {
                            foreach (DataGridViewRow totRow in totalGridView.Rows)
                            {
                                if (!totRow.IsNewRow)
                                {
                                    if (totRow.Cells[0].Value.ToString().Trim() == name && totRow.Cells[1].Value.ToString() == prod)
                                    {
                                        isDone = true;
                                    }
                                }
                            }
                        }

                        if (!isDone)
                        {
                            int qnty = 0;
                            foreach (DataGridViewRow getRow in purchaseDataGrid.Rows)
                            {
                                if (!getRow.IsNewRow)
                                {
                                    if (getRow.Cells[0].Value.ToString().Trim() == row.Cells[0].Value.ToString().Trim() &&
                                        getRow.Cells[1].Value.ToString() == row.Cells[1].Value.ToString())
                                    {
                                        qnty++;
                                    }
                                }
                            }
                            DataGridViewRow setRow = (DataGridViewRow)totalGridView.Rows[0].Clone();
                            setRow.Cells[0].Value = name;
                            setRow.Cells[1].Value = prod;
                            setRow.Cells[2].Value = qnty;
                            totalGridView.Rows.Add(setRow);
                        }
                    }
                }
            }
        }

        private void GetData()
        {
            List<PurchaseModel> purchases = SqliteDataAccess.LoadPurchases();
            try
            {
                purchaseDataGrid.Rows.Clear();
                totalGridView.Rows.Clear();
                foreach (PurchaseModel purchase in purchases)
                {
                    DataGridViewRow row = (DataGridViewRow)purchaseDataGrid.Rows[0].Clone();
                    row.Cells[0].Value = purchase.MemberName;
                    row.Cells[1].Value = purchase.ProductName;
                    row.Cells[2].Value = purchase.Date;
                    purchaseDataGrid.Rows.Add(row);
                }
            }
            catch
            {
                MessageBox.Show("No data to show");
            }
        }

        private void clearDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to clear the data? This will be lost forever!", "WARNING", MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
            {
                return;
            }
            else
            {
                string folderName = Application.StartupPath.ToString();
                string pathString = Path.Combine(folderName, "UTEAPP");
                string fileName = "DATA.txt";
                pathString = Path.Combine(pathString, fileName);
                File.Delete(pathString);
                Close();
            }
        }
        /// <summary>
        /// Returns all the purchase models from the dates specified on purchase form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetPurchasesBtn_Click(object sender, EventArgs e)
        {
            purchaseDataGrid.Rows.Clear();
            totalGridView.Rows.Clear();
            string start = startDatePicker.Value.ToString("yyyy-MM-dd");
            string end = endDatePicker.Value.ToString("yyyy-MM-dd");

            List<PurchaseModel> purchases = SqliteDataAccess.LoadSpecificPurchases(start, end);
            try
            {
                foreach (PurchaseModel purchase in purchases)
                {
                    DataGridViewRow row = (DataGridViewRow)purchaseDataGrid.Rows[0].Clone();
                    row.Cells[0].Value = purchase.MemberName;
                    row.Cells[1].Value = purchase.ProductName;
                    row.Cells[2].Value = purchase.Date;
                    purchaseDataGrid.Rows.Add(row);
                }
                GetTotals();
            }
            catch
            {
                MessageBox.Show("No data to show");
            }
        }
        /// <summary>
        /// Writes everything from the Purchase db to the Long term Purchase db. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setChargeDateBtn_Click(object sender, EventArgs e)
        {
            //write everything to the long term db
            List<PurchaseModel> purchases = SqliteDataAccess.LoadPurchases();

            foreach (PurchaseModel purchase in purchases)
            {
                SqliteDataAccess.SavePurchaseLT(purchase, endDatePicker.Value);
            }
            GetData();

            //Set the last charge label to the latest date of the long term db 
            SetLatestDate(); 
        }

        private void SetLatestDate()
        {
            try
            {
                string lastCharge = SqliteDataAccess.LatestChargeDate();
                MessageBox.Show(lastCharge); 
                lastChargeLbl.Text = "Last Charge: " + lastCharge; 
            }
            catch
            {
                lastChargeLbl.Text = "Last Charge: ";
            }
        }
    }
}
