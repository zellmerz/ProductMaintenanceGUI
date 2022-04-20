using System;
using System.Windows.Forms;
using TechSupportData;

namespace CRPG200Lab3TechSupport
{
    public partial class frmAddModifyProduct : Form
    {
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        public bool addProduct;
        public Product product;


        // load second form, label it appropriately and enable/disable ability to enter new product code depending on form
        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (addProduct)
            {
                this.Text = "Add Product";
                txtProductCode.ReadOnly = false; // enable ability to enter new product code
            }
            else
            {
                this.Text = "Modify Product";
                txtProductCode.ReadOnly = true; // cannot change product code
                this.DisplayProduct();
            }
        }

        // display selected product in form for modification
        private void DisplayProduct()
        {
            txtProductCode.Text = product.ProductCode;
            txtName.Text = product.Name;
            txtVersion.Text = product.Version.ToString();
            txtReleaseDate.Text = product.ReleaseDate.ToString();
        }

        // modify existing product or create new product depding on form
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addProduct)
                {
                    // initialize the Product property with new object
                    this.product = new Product();
                }
                this.LoadProductData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LoadProductData()
        {
            product.ProductCode = txtProductCode.Text;
            product.Name = txtName.Text;
            product.Version = Convert.ToDecimal(txtVersion.Text);
            product.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        }

        // verify valid data has been entered
        private bool IsValidData()
        {
            return
                validator.IsPresent(txtProductCode) &&
                validator.IsPresent(txtName) &&
                validator.IsPresent(txtVersion) &&
                validator.IsNonNegativeDecimal(txtVersion) &&
                validator.IsValidDate(txtReleaseDate);
            
        }
    }
}
