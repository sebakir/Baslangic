﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //var result = productDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
            var result = productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added!!");
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            productDal.GetById(1);
        }
    }
}
