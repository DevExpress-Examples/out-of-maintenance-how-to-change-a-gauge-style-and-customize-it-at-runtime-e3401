Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Core


Namespace WindowsApplication3
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private selectedGauge As String = String.Empty, selectedGaugeContainer As String = String.Empty

		Private Sub OnRunStyleChooser(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Select Case selectedGauge
				Case "Circular Gauge"
					StyleChooser.Show(circularGauge1)
				Case "Linear Gauge"
					StyleChooser.Show(linearGauge1)
			End Select
		End Sub

		Private Sub OnRunStyleManager(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Select Case selectedGaugeContainer
				Case "Gauge1"
					StyleManager.Show(gaugeControl1)
				Case "Gauge2"
					StyleManager.Show(gaugeControl2)
			End Select
		End Sub

		Private Sub OnGaugeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.EditValueChanged
			Dim edit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			selectedGauge = edit.Text
		End Sub

		Private Sub OnGaugeContainerChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit2.EditValueChanged
			Dim edit As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			selectedGaugeContainer = edit.Text
		End Sub
	End Class
End Namespace
