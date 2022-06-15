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
    public partial class FormSorting : Form
    {
        private DatabaseLego _db;
        private CacheLego _cacheLego;
        private List<Vendor> vendors;
        private List<Material> materials;
        private bool sortAscendingVendors = false;
        private bool sortAscendingMaterials = false;
        public FormSorting(CacheLego cacheLego, DatabaseLego db)
        {
            InitializeComponent();
            _db = db;
            _cacheLego = cacheLego;
            vendors = _cacheLego.GetVendors();
            materials = _cacheLego.GetMaterials();
            var bindingList = new BindingList<Vendor>(vendors);
            var source = new BindingSource(bindingList, null);
            dataGridVendors.DataSource = source;
            
        }

        private void dataGridVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridVendors.CurrentRow.Selected = true;
            var valueId = dataGridVendors.SelectedRows[0].Cells[0].Value.ToString();
            if (valueId==null)
            {
                return;
            }

            DataGridViewRow row = dataGridVendors.Rows[e.RowIndex];
            var materialsFiltered = materials.Where(c => c.VendorID ==Int32.Parse(valueId)).ToList();

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
                dataGridMaterials.DataSource = new BindingList<Material>(materials.AsQueryable().OrderBy(dataGridMaterials.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList());
            sortAscendingMaterials = !sortAscendingMaterials;
        }

        private void buttonCheapestMaterials_Click(object sender, EventArgs e)
        {

            FormCheapestMaterial formCheapestMaterial = new FormCheapestMaterial(_db);
            formCheapestMaterial.ShowDialog();
        }

        private void buttonFindBest_Click(object sender, EventArgs e)
        {
            FormBestPMMA formBestPMMA = new FormBestPMMA(_db);
            formBestPMMA.ShowDialog();
        }
    }
}
