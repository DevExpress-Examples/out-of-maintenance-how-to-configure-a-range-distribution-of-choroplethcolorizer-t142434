using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace RangeDistributionExample {

    public partial class Form1 : Form {
        const int LinearDistributionIndex = 0;
        const int LogarithmicDistributionIndex = 1;
        const int ExponentialDistributionIndex = 2;

        const string filePath = "..\\..\\Countries.shp";
        VectorFileLayer fileLayer = new VectorFileLayer();
        ChoroplethColorizer Colorizer {
            get { return fileLayer.Colorizer as ChoroplethColorizer; }
        }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            mapControl1.Layers.Add(fileLayer);
            mapControl1.Legends.Add(CreateLegend());

            fileLayer.FileLoader = CreateLoader(filePath);
            fileLayer.Colorizer = CreateColorizer();

            comboRangeDistribution.SelectedIndex = 0;
        }

        private MapFileLoaderBase CreateLoader(string filePath) {
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            ShapefileLoader loader = new ShapefileLoader() {
                FileUri = new Uri(baseUri, filePath)
            };
            return loader;
        }

        private MapColorizer CreateColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer() {
                ApproximateColors = true,
                RangeDistribution = new LinearRangeDistribution(),
                ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "GDP_MD_EST" }
            };

            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Blue));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Red));

            colorizer.RangeStops.Add(0);
            colorizer.RangeStops.Add(1000);
            colorizer.RangeStops.Add(100000);
            colorizer.RangeStops.Add(10000000);
            colorizer.RangeStops.Add(1000000000);

            return colorizer;
        }

        private MapLegendBase CreateLegend() {
            ColorScaleLegend legend = new ColorScaleLegend() {
                Header = "GDP in Countries",
                Layer = fileLayer
            };

            return legend;
        }

        private void checkApproximateColors_CheckedChanged(object sender, EventArgs e) {
            Colorizer.ApproximateColors = checkApproximateColors.Checked;
        }

        private void OnParametersChanged(object sender, EventArgs e) {
            // Set selected range distribution and factor if it is needed.
            switch (comboRangeDistribution.SelectedIndex) {
                case LogarithmicDistributionIndex:
                    tbFactor.Enabled = true;
                    Colorizer.RangeDistribution = new LogarithmicRangeDistribution() { Factor = GetFactor() };
                    break;
                case LinearDistributionIndex:
                    tbFactor.Enabled = true;
                    Colorizer.RangeDistribution = new ExponentialRangeDistribution() { Factor = GetFactor() };
                    break;
                default:
                    Colorizer.RangeDistribution = new LinearRangeDistribution();
                    tbFactor.Enabled = false;
                    break;
            }
        }

        private double GetFactor() {
            return (String.IsNullOrEmpty(tbFactor.Text)) ? 0 : Convert.ToDouble(tbFactor.Text);
        }
    }
}
