namespace RangeDistributions {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.ChoroplethColorizer choroplethColorizer2 = new DevExpress.XtraMap.ChoroplethColorizer();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution2 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.ShapeAttributeValueProvider shapeAttributeValueProvider2 = new DevExpress.XtraMap.ShapeAttributeValueProvider();
            DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter2 = new DevExpress.XtraMap.ShapefileDataAdapter();
            DevExpress.XtraMap.ColorScaleLegend colorScaleLegend2 = new DevExpress.XtraMap.ColorScaleLegend();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.seFactor = new DevExpress.XtraEditors.SpinEdit();
            this.cbRangeDistribution = new System.Windows.Forms.ComboBox();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbApproximateColors = new System.Windows.Forms.CheckBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbApproximateColors);
            this.layoutControl1.Controls.Add(this.seFactor);
            this.layoutControl1.Controls.Add(this.cbRangeDistribution);
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(784, 561);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // seFactor
            // 
            this.seFactor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFactor.Location = new System.Drawing.Point(540, 12);
            this.seFactor.Name = "seFactor";
            this.seFactor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFactor.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seFactor.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seFactor.Size = new System.Drawing.Size(232, 20);
            this.seFactor.StyleController = this.layoutControl1;
            this.seFactor.TabIndex = 6;
            this.seFactor.EditValueChanged += new System.EventHandler(this.seFactor_EditValueChanged);
            // 
            // cbRangeDistribution
            // 
            this.cbRangeDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRangeDistribution.FormattingEnabled = true;
            this.cbRangeDistribution.Location = new System.Drawing.Point(227, 12);
            this.cbRangeDistribution.Name = "cbRangeDistribution";
            this.cbRangeDistribution.Size = new System.Drawing.Size(214, 21);
            this.cbRangeDistribution.TabIndex = 1;
            this.cbRangeDistribution.SelectedIndexChanged += new System.EventHandler(this.cbRangeDistribution_SelectedIndexChanged);
            // 
            // mapControl1
            // 
            choroplethColorizer2.ApproximateColors = true;
            choroplethColorizer2.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Criteria;
            choroplethColorizer2.RangeDistribution = linearRangeDistribution2;
            choroplethColorizer2.RangeStops.Add(0D);
            choroplethColorizer2.RangeStops.Add(3000D);
            choroplethColorizer2.RangeStops.Add(10000D);
            choroplethColorizer2.RangeStops.Add(18000D);
            choroplethColorizer2.RangeStops.Add(28000D);
            choroplethColorizer2.RangeStops.Add(44000D);
            choroplethColorizer2.RangeStops.Add(82000D);
            choroplethColorizer2.RangeStops.Add(185000D);
            choroplethColorizer2.RangeStops.Add(1000000D);
            choroplethColorizer2.RangeStops.Add(2500000D);
            choroplethColorizer2.RangeStops.Add(15000000D);
            shapeAttributeValueProvider2.AttributeName = "GDP_MD_EST";
            choroplethColorizer2.ValueProvider = shapeAttributeValueProvider2;
            vectorItemsLayer2.Colorizer = choroplethColorizer2;
            vectorItemsLayer2.Data = shapefileDataAdapter2;
            vectorItemsLayer2.Name = "MapLayer";
            vectorItemsLayer2.ToolTipPattern = "{NAME}: ${GDP_MD_EST}";
            this.mapControl1.Layers.Add(vectorItemsLayer2);
            colorScaleLegend2.Description = "In US dollars";
            colorScaleLegend2.Header = "GDP By Countries";
            colorScaleLegend2.Layer = vectorItemsLayer2;
            this.mapControl1.Legends.Add(colorScaleLegend2);
            this.mapControl1.Location = new System.Drawing.Point(12, 37);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(760, 512);
            this.mapControl1.TabIndex = 4;
            this.mapControl1.ToolTipController = this.toolTipController1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 561);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 516);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbRangeDistribution;
            this.layoutControlItem2.Location = new System.Drawing.Point(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(313, 25);
            this.layoutControlItem2.Text = "Range Distribution:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.seFactor;
            this.layoutControlItem3.Location = new System.Drawing.Point(433, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(331, 25);
            this.layoutControlItem3.Text = "Factor Value:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(92, 13);
            // 
            // cbApproximateColors
            // 
            this.cbApproximateColors.Location = new System.Drawing.Point(12, 12);
            this.cbApproximateColors.Name = "cbApproximateColors";
            this.cbApproximateColors.Size = new System.Drawing.Size(116, 20);
            this.cbApproximateColors.TabIndex = 7;
            this.cbApproximateColors.Text = "Approximate Colors";
            this.cbApproximateColors.UseVisualStyleBackColor = true;
            this.cbApproximateColors.CheckedChanged += new System.EventHandler(this.cbApproximateColors_CheckedChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbApproximateColors;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(120, 25);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit seFactor;
        private System.Windows.Forms.ComboBox cbRangeDistribution;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.CheckBox cbApproximateColors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}

