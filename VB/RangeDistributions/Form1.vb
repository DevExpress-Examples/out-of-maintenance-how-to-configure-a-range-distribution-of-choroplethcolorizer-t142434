Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Map
Imports DevExpress.XtraMap

Namespace RangeDistributions
    Partial Public Class Form1
        Inherits Form

        Private Const filepath As String = "../../Data/Countries.shp"

        Private distributions As New List(Of RangeDistributionBase)() From { _
            New LinearRangeDistribution(), _
            New LogarithmicRangeDistribution(), _
            New ExponentialRangeDistribution() _
        }

        Private ReadOnly Property MapLayer() As VectorItemsLayer
            Get
                Return CType(mapControl1.Layers("MapLayer"), VectorItemsLayer)
            End Get
        End Property
        Private ReadOnly Property Colorizer() As ChoroplethColorizer
            Get
                Return CType(MapLayer.Colorizer, ChoroplethColorizer)
            End Get
        End Property
        Private ReadOnly Property Adapter() As ShapefileDataAdapter
            Get
                Return CType(MapLayer.Data, ShapefileDataAdapter)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            cbRangeDistribution.DataSource = distributions

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Adapter.FileUri = New Uri(baseUri, filepath)
        End Sub

        Private Sub cbRangeDistribution_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRangeDistribution.SelectedIndexChanged
            Dim selectedDistribution As RangeDistributionBase = TryCast(cbRangeDistribution.SelectedItem, RangeDistributionBase)
            If selectedDistribution Is Nothing Then
                Return
            End If

            If selectedDistribution.Equals(distributions(0)) Then
                seFactor.Enabled = False
            Else
                seFactor.Enabled = True
                Dim eqDistribution As EquationRangeDistribution = TryCast(selectedDistribution, EquationRangeDistribution)
                eqDistribution.Factor = CDbl(seFactor.Value)
            End If

            Colorizer.RangeDistribution = selectedDistribution
        End Sub

        Private Sub seFactor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seFactor.EditValueChanged
            Dim distribution As EquationRangeDistribution = TryCast(Colorizer.RangeDistribution, EquationRangeDistribution)
            If distribution Is Nothing Then
                Return
            End If

            distribution.Factor = CDbl(seFactor.Value)
        End Sub

        #Region "#ApproximateColors"
        Private Sub cbApproximateColors_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbApproximateColors.CheckedChanged
            Colorizer.ApproximateColors = cbApproximateColors.Checked
        End Sub
        #End Region ' #ApproximateColors
    End Class
End Namespace
