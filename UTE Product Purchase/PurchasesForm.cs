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
        }

        private void GetTotals()
        {
            if(purchaseDataGrid.Rows.Count > 1)
            {
                foreach(DataGridViewRow row in purchaseDataGrid.Rows)
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
            string folderName = Application.StartupPath.ToString();
            string pathString = Path.Combine(folderName, "UTEAPP");
            string fileName = "DATA.txt";
            pathString = Path.Combine(pathString, fileName);
            try
            {

                string[] lines = File.ReadAllLines(pathString);
                foreach (string line in lines)
                {
                    DataGridViewRow row = (DataGridViewRow)purchaseDataGrid.Rows[0].Clone();
                    string[] segments = line.Split('|');
                    row.Cells[0].Value = segments[0];
                    row.Cells[1].Value = segments[1];
                    row.Cells[2].Value = segments[2];
                    row.Cells[3].Value = segments[3];
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
    }
}
