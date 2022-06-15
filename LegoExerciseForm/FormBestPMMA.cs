using LegoExerciseForm.Database;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoExerciseForm
{
    public partial class FormBestPMMA : Form
    {
        private DatabaseLego _db;
        private List<MaterialEco> _allMaterialsFiltered;
        public FormBestPMMA(DatabaseLego db)
        {
            InitializeComponent();
            _db = db;
            var allMaterialsFiltered = _db.FindBestOption();
            _allMaterialsFiltered = allMaterialsFiltered;
            var bindingList = new BindingList<MaterialEco>(_allMaterialsFiltered);
            var source = new BindingSource(bindingList, null);
            dataGridBestPMMA.DataSource = source;
        }

        private void buttonFindBest_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> materialValue = new Dictionary<int, int>();
            foreach (var material in _allMaterialsFiltered)
            {
                materialValue.Add(material.ID, 0);
            }

            var ecoMaterials = _allMaterialsFiltered.Where(c => c.ECOFriendly == true).ToList();

            foreach (var material in ecoMaterials)
            {
                materialValue[material.ID] += 10;
            }

            var priceMaterial = _allMaterialsFiltered.OrderBy(c => c.PricePerUnit).ToList();

            var pointsPrice = 10;

            for (int i = 0; i < priceMaterial.Count; i++)
            {
                materialValue[priceMaterial[i].ID] += pointsPrice;
                pointsPrice--;
                if (i>=10)
                {
                    break;
                }
            }

            var deliveryMaterial = _allMaterialsFiltered.OrderBy(c => c.DeliveryTimeDays).ToList();

            var pointsDelivery = 10;

            for (int i = 0; i < deliveryMaterial.Count; i++)
            {
                materialValue[deliveryMaterial[i].ID] += pointsDelivery;
                pointsDelivery--;
                if (i >= 10)
                {
                    break;
                }
            }

            var materialKeys = materialValue.OrderByDescending(c=>c.Value).Select(c => c.Key).ToList();

            var orderedMaterials = _allMaterialsFiltered.OrderBy(c=> materialKeys.IndexOf(c.ID)).ToList();

            var bindingList = new BindingList<MaterialEco>(orderedMaterials);
            var source = new BindingSource(bindingList, null);
            dataGridBestPMMA.DataSource = source;

        }
    }
}
