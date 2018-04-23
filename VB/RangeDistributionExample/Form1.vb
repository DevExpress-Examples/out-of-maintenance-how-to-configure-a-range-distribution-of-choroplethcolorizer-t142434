Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace RangeDistributionExample

    Partial Public Class Form1
        Inherits Form

        Private Const LinearDistributionIndex As Integer = 0
        Private Const LogarithmicDistributionIndex As Integer = 1
        Private Const ExponentialDistributionIndex As Integer = 2

        Private Const filePath As String = "..\..\Countries.shp"
        Private fileLayer As New VectorFileLayer()
        Private ReadOnly Property Colorizer() As ChoroplethColorizer
            Get
                Return TryCast(fileLayer.Colorizer, ChoroplethColorizer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            mapControl1.Layers.Add(fileLayer)
            mapControl1.Legends.Add(CreateLegend())

            fileLayer.FileLoader = CreateLoader(filePath)
            fileLayer.Colorizer = CreateColorizer()

            comboRangeDistribution.SelectedIndex = 0
        End Sub

        Private Function CreateLoader(ByVal filePath As String) As MapFileLoaderBase
            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Dim loader As New ShapefileLoader() With {.FileUri = New Uri(baseUri, filePath)}
            Return loader
        End Function

        Private Function CreateColorizer() As MapColorizer

            Dim colorizer_Renamed As New ChoroplethColorizer() With { _
                .ApproximateColors = True, .RangeDistribution = New LinearRangeDistribution(), .ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"} _
            }

            colorizer_Renamed.ColorItems.Add(New ColorizerColorItem(Color.Blue))
            colorizer_Renamed.ColorItems.Add(New ColorizerColorItem(Color.Red))

            colorizer_Renamed.RangeStops.Add(0)
            colorizer_Renamed.RangeStops.Add(1000)
            colorizer_Renamed.RangeStops.Add(100000)
            colorizer_Renamed.RangeStops.Add(10000000)
            colorizer_Renamed.RangeStops.Add(1000000000)

            Return colorizer_Renamed
        End Function

        Private Function CreateLegend() As MapLegendBase
            Dim legend As New ColorScaleLegend() With {.Header = "GDP in Countries", .Layer = fileLayer}

            Return legend
        End Function

        Private Sub checkApproximateColors_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkApproximateColors.CheckedChanged
            Colorizer.ApproximateColors = checkApproximateColors.Checked
        End Sub

        Private Sub OnParametersChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbFactor.TextChanged, comboRangeDistribution.SelectedIndexChanged
            ' Set selected range distribution and factor if it is needed.
            Select Case comboRangeDistribution.SelectedIndex
                Case LogarithmicDistributionIndex
                    tbFactor.Enabled = True
                    Colorizer.RangeDistribution = New LogarithmicRangeDistribution() With {.Factor = GetFactor()}
                Case LinearDistributionIndex
                    tbFactor.Enabled = True
                    Colorizer.RangeDistribution = New ExponentialRangeDistribution() With {.Factor = GetFactor()}
                Case Else
                    Colorizer.RangeDistribution = New LinearRangeDistribution()
                    tbFactor.Enabled = False
            End Select
        End Sub

        Private Function GetFactor() As Double
            Return If(String.IsNullOrEmpty(tbFactor.Text), 0, Convert.ToDouble(tbFactor.Text))
        End Function
    End Class
End Namespace
