using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Map;
using DevExpress.XtraMap;

namespace RangeDistributions {
    public partial class Form1 : Form {
        const string filepath = "../../Data/Countries.shp";
        
        List<RangeDistributionBase> distributions = new List<RangeDistributionBase>{ 
            new LinearRangeDistribution(),
            new LogarithmicRangeDistribution(),
            new ExponentialRangeDistribution()
        };

        VectorItemsLayer MapLayer { get { return (VectorItemsLayer)mapControl1.Layers["MapLayer"]; } }
        ChoroplethColorizer Colorizer { get { return (ChoroplethColorizer)MapLayer.Colorizer; } }
        ShapefileDataAdapter Adapter { get { return (ShapefileDataAdapter)MapLayer.Data; } }

        public Form1() {
            InitializeComponent();

            cbRangeDistribution.DataSource = distributions;

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            Adapter.FileUri = new Uri(baseUri, filepath);
        }

        private void cbRangeDistribution_SelectedIndexChanged(object sender, EventArgs e) {
            RangeDistributionBase selectedDistribution = cbRangeDistribution.SelectedItem as RangeDistributionBase;
            if (selectedDistribution == null) return;

            if (selectedDistribution.Equals(distributions[0])) seFactor.Enabled = false;
            else {
                seFactor.Enabled = true;
                EquationRangeDistribution eqDistribution = selectedDistribution as EquationRangeDistribution;
                eqDistribution.Factor = (double)seFactor.Value;
            }

            Colorizer.RangeDistribution = selectedDistribution;
        }

        private void seFactor_EditValueChanged(object sender, EventArgs e) {
            EquationRangeDistribution distribution = Colorizer.RangeDistribution as EquationRangeDistribution;
            if (distribution == null) return;

            distribution.Factor = (double)seFactor.Value;
        }

        #region #ApproximateColors
        private void cbApproximateColors_CheckedChanged(object sender, EventArgs e) {
            Colorizer.ApproximateColors = cbApproximateColors.Checked;
        }
        #endregion #ApproximateColors
    }
}
