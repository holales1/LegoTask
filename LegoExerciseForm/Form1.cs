using LegoExerciseForm.Cache;
using LegoExerciseForm.Database;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Windows.Forms;

namespace LegoExerciseForm
{
    public partial class Form1 : Form
    {
        private CacheLego _cacheLego;
        private List<Vendor> vendors;
        private List<Material> materials;
        private bool sortAscendingVendors = false;
        private bool sortAscendingMaterials = false;
        public Form1(CacheLego cacheLego)
        {
            InitializeComponent();
            _cacheLego = cacheLego;
            vendors = _cacheLego.GetVendors();
            materials = _cacheLego.GetMaterials();
            var bindingList = new BindingList<Vendor>(vendors);
            var source = new BindingSource(bindingList, null);
            dataGridVendors.DataSource = source;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridVendors.CurrentRow.Selected = true;
            var materialsFiltered = materials;
            var bindingList = new BindingList<Material>(materialsFiltered);
            var source = new BindingSource(bindingList, null);
            dataGridMaterials.DataSource = source;

        }

        private void dataGridVendors_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortAscendingVendors == false)
                dataGridVendors.DataSource = new BindingList<Vendor>(vendors.AsQueryable().OrderBy(dataGridVendors.Columns[e.ColumnIndex].DataPropertyName).ToList());
            else
                dataGridVendors.DataSource = new BindingList<Vendor>(vendors.AsQueryable().OrderBy(dataGridVendors.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList());
            sortAscendingVendors = !sortAscendingVendors;
        }

        private void dataGridMaterials_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortAscendingMaterials == false)
                dataGridMaterials.DataSource = new BindingList<Material>(materials.AsQueryable().OrderBy(dataGridMaterials.Columns[e.ColumnIndex].DataPropertyName).ToList());
            else
                dataGridVendors.DataSource = new BindingList<Material>(materials.AsQueryable().OrderBy(dataGridMaterials.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList());
            sortAscendingMaterials = !sortAscendingMaterials;
        }
    }
}
