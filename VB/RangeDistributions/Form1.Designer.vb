Namespace RangeDistributions
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim vectorItemsLayer2 As New DevExpress.XtraMap.VectorItemsLayer()
            Dim choroplethColorizer2 As New DevExpress.XtraMap.ChoroplethColorizer()
            Dim linearRangeDistribution2 As New DevExpress.XtraMap.LinearRangeDistribution()
            Dim shapeAttributeValueProvider2 As New DevExpress.XtraMap.ShapeAttributeValueProvider()
            Dim shapefileDataAdapter2 As New DevExpress.XtraMap.ShapefileDataAdapter()
            Dim colorScaleLegend2 As New DevExpress.XtraMap.ColorScaleLegend()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.seFactor = New DevExpress.XtraEditors.SpinEdit()
            Me.cbRangeDistribution = New System.Windows.Forms.ComboBox()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cbApproximateColors = New System.Windows.Forms.CheckBox()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.seFactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbApproximateColors)
            Me.layoutControl1.Controls.Add(Me.seFactor)
            Me.layoutControl1.Controls.Add(Me.cbRangeDistribution)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(784, 561)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' seFactor
            ' 
            Me.seFactor.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.seFactor.Location = New System.Drawing.Point(540, 12)
            Me.seFactor.Name = "seFactor"
            Me.seFactor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seFactor.Properties.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
            Me.seFactor.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
            Me.seFactor.Size = New System.Drawing.Size(232, 20)
            Me.seFactor.StyleController = Me.layoutControl1
            Me.seFactor.TabIndex = 6
            ' 
            ' cbRangeDistribution
            ' 
            Me.cbRangeDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbRangeDistribution.FormattingEnabled = True
            Me.cbRangeDistribution.Location = New System.Drawing.Point(227, 12)
            Me.cbRangeDistribution.Name = "cbRangeDistribution"
            Me.cbRangeDistribution.Size = New System.Drawing.Size(214, 21)
            Me.cbRangeDistribution.TabIndex = 1
            ' 
            ' mapControl1
            ' 
            choroplethColorizer2.ApproximateColors = True
            choroplethColorizer2.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Criteria
            choroplethColorizer2.RangeDistribution = linearRangeDistribution2
            choroplethColorizer2.RangeStops.Add(0R)
            choroplethColorizer2.RangeStops.Add(3000R)
            choroplethColorizer2.RangeStops.Add(10000R)
            choroplethColorizer2.RangeStops.Add(18000R)
            choroplethColorizer2.RangeStops.Add(28000R)
            choroplethColorizer2.RangeStops.Add(44000R)
            choroplethColorizer2.RangeStops.Add(82000R)
            choroplethColorizer2.RangeStops.Add(185000R)
            choroplethColorizer2.RangeStops.Add(1000000R)
            choroplethColorizer2.RangeStops.Add(2500000R)
            choroplethColorizer2.RangeStops.Add(15000000R)
            shapeAttributeValueProvider2.AttributeName = "GDP_MD_EST"
            choroplethColorizer2.ValueProvider = shapeAttributeValueProvider2
            vectorItemsLayer2.Colorizer = choroplethColorizer2
            vectorItemsLayer2.Data = shapefileDataAdapter2
            vectorItemsLayer2.Name = "MapLayer"
            vectorItemsLayer2.ToolTipPattern = "{NAME}: ${GDP_MD_EST}"
            Me.mapControl1.Layers.Add(vectorItemsLayer2)
            colorScaleLegend2.Description = "In US dollars"
            colorScaleLegend2.Header = "GDP By Countries"
            colorScaleLegend2.Layer = vectorItemsLayer2
            Me.mapControl1.Legends.Add(colorScaleLegend2)
            Me.mapControl1.Location = New System.Drawing.Point(12, 37)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(760, 512)
            Me.mapControl1.TabIndex = 4
            Me.mapControl1.ToolTipController = Me.toolTipController1
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.AllowHtmlText = True
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(784, 561)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 25)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(764, 516)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbRangeDistribution
            Me.layoutControlItem2.Location = New System.Drawing.Point(120, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(313, 25)
            Me.layoutControlItem2.Text = "Range Distribution:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.seFactor
            Me.layoutControlItem3.Location = New System.Drawing.Point(433, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(331, 25)
            Me.layoutControlItem3.Text = "Factor Value:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' cbApproximateColors
            ' 
            Me.cbApproximateColors.Location = New System.Drawing.Point(12, 12)
            Me.cbApproximateColors.Name = "cbApproximateColors"
            Me.cbApproximateColors.Size = New System.Drawing.Size(116, 20)
            Me.cbApproximateColors.TabIndex = 7
            Me.cbApproximateColors.Text = "Approximate Colors"
            Me.cbApproximateColors.UseVisualStyleBackColor = True
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbApproximateColors
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(120, 25)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.seFactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents seFactor As DevExpress.XtraEditors.SpinEdit
        Private WithEvents cbRangeDistribution As System.Windows.Forms.ComboBox
        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private toolTipController1 As DevExpress.Utils.ToolTipController
        Private WithEvents cbApproximateColors As System.Windows.Forms.CheckBox
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace

