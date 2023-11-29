using BLL_DAL.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangTienLoi.UserControls
{
    public partial class UC_SanPhamItem : UserControl
    {
        private FlowLayoutPanel _container;
        private TextBox _txtTotalPrice;

        public string product_id;
        public string product_name;
        public float product_price;
        public int product_quantity;
        public double total_value;
        public UC_SanPhamItem(FlowLayoutPanel container, TextBox txtTotalPrice,
            string product_id, string product_name, float product_price)
        {
            InitializeComponent();

            this._container = container;
            this._txtTotalPrice = txtTotalPrice;

            this.product_id = product_id;
            this.product_name = product_name;
            this.product_price = product_price;
            this.product_quantity = 1;
        }

        public void CalculateTotalPrice()
        {
            double bill_sum = 0;

            foreach (UC_SanPhamItem item in _container.Controls)
            {
                bill_sum += item.total_value;
            }

            _txtTotalPrice.Text = bill_sum.ToString();
        }

        private void IncreaseQuantity()
        {
            numUDQuantity.Value += 1;
        }

        public void SettingMaxQuantity(int max_quantity)
        {
            numUDQuantity.Maximum = max_quantity;
        }

        public int FindThisItemInContainer()
        {
            foreach (UC_SanPhamItem item in _container.Controls)
            {
                if (item.product_id == this.product_id)
                {
                    return _container.Controls.GetChildIndex(item);
                }
            }
            return -1;
        }

        /// <summary>
        /// Add new item or increase if they was availabled
        /// </summary>
        public void SettingItem()
        {
            int index = FindThisItemInContainer();
            if (index == -1) // New
            {
                lblTenSP.Text = product_name;
                lblGiaTien.Text = GetFormatString.GetCurrencyString(product_price);
                txtValueSanPham.Text = product_price.ToString();
                total_value = product_price;

                _container.Controls.Add(this);
            }
            else
            {
                ((UC_SanPhamItem)_container.Controls[index]).IncreaseQuantity();
            }
            CalculateTotalPrice();
        }

        private void numUDQuantity_ValueChanged(object sender, EventArgs e)
        {
            product_quantity = (int)numUDQuantity.Value;
            total_value = product_quantity * product_price;
            txtValueSanPham.Text = total_value.ToString();
            CalculateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _container.Controls.Remove(this);
            CalculateTotalPrice();
        }
    }
}
