using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TechSupportData;

namespace CRPG200Lab3TechSupport
{
    public partial class ProductMaintenance : Form
    {
        
        public ProductMaintenance()
        {
            InitializeComponent();
        }

        private TechSupportContext context = new TechSupportContext();
        private Product selectedProduct;

        // display products on form load
        private void ProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProducts();

            
        }

        // display products in the DataGridView
        private void DisplayProducts()
        {
            dgvProducts.Columns.Clear();
            var products = context.Products
                .OrderBy(p => p.ProductCode)
                .Select(p => new { p.ProductCode, p.Name, p.Version, p.ReleaseDate })
                .ToList();

            dgvProducts.DataSource = products;

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvProducts.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvProducts.Columns.Add(deleteColumn);

            // format headers
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.AntiqueWhite;

            // format alternating rows (zebra style)
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // format the columns
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.Columns[0].HeaderText = "Product Code";
            dgvProducts.Columns[1].HeaderText = "Product Name";
            dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[3].HeaderText = "Release Date";
        }

        // open add product form, add product if OK result sent, do nothing if OK not sent
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct addProductForm = new frmAddModifyProduct();
            addProductForm.addProduct = true;
            DialogResult result = addProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addProductForm.product;
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    this.DisplayProducts();
                }

                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }


        // create modify/delete buttons and attach functions to them
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // create index values for Modify and Delete
            const int MODIFY_INDEX = 4;
            const int DELETE_INDEX = 5;

            if (e.ColumnIndex == MODIFY_INDEX || e.ColumnIndex == DELETE_INDEX)
            {
                string productCode = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedProduct = context.Products.Find(productCode);
            }

            if (e.ColumnIndex == MODIFY_INDEX)
            {
                ModifyProduct();
            }
            else if (e.ColumnIndex == DELETE_INDEX)
            {
                DeleteProduct();
            }
        }

        // load Modify form preloaded with selected product information
        private void ModifyProduct()
        {
            var addModifyProductForm = new frmAddModifyProduct()
            {
                addProduct = false,
                product = selectedProduct
            };

            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyProductForm.product;
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }


        // delete selected product, require confirmation before deletion
        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Are you sure you want to delete {selectedProduct.ProductCode.Trim()}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Products.Remove(selectedProduct);
                    context.SaveChanges(true);
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "Error Code: " + error.Number + " " + error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();
            var state = context.Entry(selectedProduct).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted selected product", "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated selected product.\n" + "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            this.DisplayProducts();
        }

        // terminate application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
