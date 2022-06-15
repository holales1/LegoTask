using LegoExerciseForm.Database;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Windows.Forms;

namespace LegoExerciseForm
{
    public partial class FormCheapestMaterial : Form
    {
        private DatabaseLego _db;
        private List<VendorDeliveryDays> _allVendorsFiltered;
        private bool allVendorsBool = false;
        public FormCheapestMaterial(DatabaseLego db)
        {
            InitializeComponent();
            _db = db;
            var allVendorsFiltered = _db.GetCheapestMaterial();
            _allVendorsFiltered = allVendorsFiltered;
            var bindingList = new BindingList<VendorDeliveryDays>(allVendorsFiltered);
            var source = new BindingSource(bindingList, null);
            dataGridCheapestMaterials.DataSource = source;
        }

        private void dataGridCheapestMaterials_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (allVendorsBool == false)
                dataGridCheapestMaterials.DataSource = new BindingList<VendorDeliveryDays>(_allVendorsFiltered.AsQueryable().OrderBy(dataGridCheapestMaterials.Columns[e.ColumnIndex].DataPropertyName).ToList());
            else
                dataGridCheapestMaterials.DataSource = new BindingList<VendorDeliveryDays>(_allVendorsFiltered.AsQueryable().OrderBy(dataGridCheapestMaterials.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList());
            allVendorsBool = !allVendorsBool;
        }
    }
}
