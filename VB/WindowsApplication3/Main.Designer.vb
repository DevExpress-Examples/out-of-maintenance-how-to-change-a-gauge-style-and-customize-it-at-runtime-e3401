Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Main
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
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
			Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.comboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
			Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.linearScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
			Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
			Me.linearScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Sharp"
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(374, 279)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 362, 267)
			Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() { Me.arcScaleEffectLayerComponent1})
			Me.circularGauge1.Name = "circularGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1, Me.arcScaleComponent2})
			Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() { Me.arcScaleSpindleCapComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg1"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style6
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold)
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -7.3F
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_5
			Me.arcScaleComponent1.MajorTickmark.TextOffset = -20F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -3.3F
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_4
			Me.arcScaleComponent1.Name = "scale1"
			Me.arcScaleComponent1.RadiusX = 98F
			Me.arcScaleComponent1.RadiusY = 98F
			Me.arcScaleComponent1.StartAngle = -240F
			' 
			' arcScaleEffectLayerComponent1
			' 
			Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleEffectLayerComponent1.Name = "effect1"
			Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.533F, 0.95F)
			Me.arcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.15]")
			Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style6
			Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(190F, 105F)
			Me.arcScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = -7F
			Me.arcScaleNeedleComponent1.Name = "needle1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6
			Me.arcScaleNeedleComponent1.StartOffset = -23F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent2.EndAngle = -30F
			Me.arcScaleComponent2.MajorTickCount = 8
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -8F
			Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_3
			Me.arcScaleComponent2.MajorTickmark.TextOffset = -20F
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 700F
			Me.arcScaleComponent2.MinorTickCount = 4
			Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style6_1
			Me.arcScaleComponent2.Name = "scale2"
			Me.arcScaleComponent2.RadiusX = 65F
			Me.arcScaleComponent2.RadiusY = 65F
			Me.arcScaleComponent2.StartAngle = -240F
			Me.arcScaleComponent2.ZOrder = -1
			' 
			' arcScaleSpindleCapComponent1
			' 
			Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleSpindleCapComponent1.Name = "cap1"
			Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style6
			Me.arcScaleSpindleCapComponent1.ZOrder = -25
			' 
			' gaugeControl2
			' 
			Me.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Right
			Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.linearGauge1})
			Me.gaugeControl2.Location = New System.Drawing.Point(374, 0)
			Me.gaugeControl2.Name = "gaugeControl2"
			Me.gaugeControl2.Size = New System.Drawing.Size(258, 279)
			Me.gaugeControl2.TabIndex = 1
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.comboBoxEdit2)
			Me.panelControl1.Controls.Add(Me.labelControl2)
			Me.panelControl1.Controls.Add(Me.simpleButton2)
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit1)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 279)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(632, 81)
			Me.panelControl1.TabIndex = 2
			' 
			' comboBoxEdit2
			' 
			Me.comboBoxEdit2.Location = New System.Drawing.Point(428, 12)
			Me.comboBoxEdit2.Name = "comboBoxEdit2"
			Me.comboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit2.Properties.Items.AddRange(New Object() { "Gauge1", "Gauge2"})
			Me.comboBoxEdit2.Size = New System.Drawing.Size(183, 20)
			Me.comboBoxEdit2.TabIndex = 5
'			Me.comboBoxEdit2.EditValueChanged += New System.EventHandler(Me.OnGaugeContainerChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(309, 15)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(113, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "Select Gauge Container"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(309, 47)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(302, 29)
			Me.simpleButton2.TabIndex = 3
			Me.simpleButton2.Text = "Run Style Manager"
'			Me.simpleButton2.Click += New System.EventHandler(Me.OnRunStyleManager);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 47)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(268, 29)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Run Style Chooser"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnRunStyleChooser);
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(97, 12)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "Circular Gauge", "Linear Gauge"})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(183, 20)
			Me.comboBoxEdit1.TabIndex = 1
'			Me.comboBoxEdit1.EditValueChanged += New System.EventHandler(Me.OnGaugeChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(63, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Select Gauge"
			' 
			' linearGauge1
			' 
			Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() { Me.linearScaleBackgroundLayerComponent1})
			Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 246, 267)
			Me.linearGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent() { Me.linearScaleEffectLayerComponent1})
			Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() { Me.linearScaleLevelComponent1})
			Me.linearGauge1.Name = "linearGauge1"
			Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1, Me.linearScaleComponent2})
			' 
			' linearScaleComponent1
			' 
			Me.linearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 32F)
			Me.linearScaleComponent1.MajorTickCount = 6
			Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent1.MajorTickmark.ShapeOffset = 5F
			Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_3
			Me.linearScaleComponent1.MajorTickmark.TextOffset = 35F
			Me.linearScaleComponent1.MaxValue = 50F
			Me.linearScaleComponent1.MinorTickCount = 4
			Me.linearScaleComponent1.MinorTickmark.ShapeOffset = 5F
			Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_2
			Me.linearScaleComponent1.Name = "scale1"
			Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 218F)
			Me.linearScaleComponent1.Value = 20F
			' 
			' linearScaleComponent2
			' 
			Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
			Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 32F)
			Me.linearScaleComponent2.MajorTickCount = 6
			Me.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent2.MajorTickmark.ShapeOffset = -22F
			Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_3
			Me.linearScaleComponent2.MajorTickmark.TextOffset = -35F
			Me.linearScaleComponent2.MaxValue = 500F
			Me.linearScaleComponent2.MinorTickCount = 4
			Me.linearScaleComponent2.MinorTickmark.ShapeOffset = -11F
			Me.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_2
			Me.linearScaleComponent2.Name = "scale2"
			Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 218F)
			' 
			' linearScaleBackgroundLayerComponent1
			' 
			Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleBackgroundLayerComponent1.Name = "bg1"
			Me.linearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.125F)
			Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.875F)
			Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style6
			Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' linearScaleLevelComponent1
			' 
			Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleLevelComponent1.Name = "level1"
			Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style6
			Me.linearScaleLevelComponent1.ZOrder = -50
			' 
			' linearScaleEffectLayerComponent1
			' 
			Me.linearScaleEffectLayerComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleEffectLayerComponent1.Name = "effect1"
			Me.linearScaleEffectLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 2F)
			Me.linearScaleEffectLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.15F)
			Me.linearScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.5]")
			Me.linearScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.Linear_Style6
			Me.linearScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(632, 360)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Controls.Add(Me.gaugeControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "Style Chooser & Style Manager"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents comboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
		Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
		Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent
		Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
		Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
	End Class
End Namespace

