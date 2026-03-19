using Microsoft.EntityFrameworkCore;
using SportEquipmentProject.Models;
using SportEquipmentProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportEquipmentProject
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvProducts.Columns;
            dgvProducts.Columns.AddRange(
            [
                colPhoto, colInfo, colDiscount
            ]);

            lblUsername.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            //Циклом
            foreach(Button button in flowLayoutPanelButtons.Controls)
            {
                button.Visible = !IsGuest;
            }

            //Или отдельно
            //btnGetOrders.Visible = !IsGuest;

            LoadProducts();
        }

        private void LoadProducts()
        {
            //throw new NotImplementedException();
            try
            {
                using (var db = new DemDbContext())
                {
                    //Пока с такими названиями
                    var products = db.Products
                        .Include(i => i.IdProductCategoryNavigation)
                        .Include(i => i.IdManufacturerNavigation)
                        .Include(i => i.IdSupplierNavigation)
                        .Include(i => i.IdUnitOfMeasurementNavigation)
                        .ToList();

                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = Resources.picture;

                        row.Cells["colInfo"].Value = FormatProductInfo(product);

                        row.Cells["colDiscount"].Value = $"{product.Discount}%";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, product);
                    }

                    dgvProducts.ResumeLayout();
                    dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private object LoadProductImage(object photoUrl)
        //{
        //    //throw new NotImplementedException();
        //}

        private string FormatProductInfo(Product product)
        {
            string priceText;

            if (product.Discount > 0)
            {
                decimal finalPrice = product.Price * (100 - product.Discount) / 100;
                priceText = $"Цена: {product.Price:C} -> {finalPrice:C}";
            }
            else
            {
                priceText = $"Цена: {product.Price:C}";
            }


            return $"{product.IdProductCategoryNavigation.CategoryName} | {product.ProductName} " + Environment.NewLine +
                 $"Описание товара: {product.Description}" + Environment.NewLine +
                 $"Производитель: {product.IdManufacturerNavigation.ManufacturerName}" + Environment.NewLine +
                 $"Поставщик: {product.IdSupplierNavigation.SupplierName}" + Environment.NewLine +
                 $"Цена: {priceText}" + Environment.NewLine +
                 $"Единица измерения: {product.IdUnitOfMeasurementNavigation.UnitName}" + Environment.NewLine +
                 $"Количество на складе: {product.Count}" + Environment.NewLine;
                
        }

        private void ApplyRowStyles(DataGridViewRow row, Product product)
        {
            if (product.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2EC4B6");
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            if (product.Count <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E9F5FF");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void BtnGetOrders_Click(object sender, EventArgs e)
        {
            var formOrders = new FormOrders();
            formOrders.ShowDialog();
        }
    }
}
