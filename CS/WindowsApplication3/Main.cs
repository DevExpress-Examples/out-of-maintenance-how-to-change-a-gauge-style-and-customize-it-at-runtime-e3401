using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core;


namespace WindowsApplication3 {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        string selectedGauge = string.Empty, selectedGaugeContainer = string.Empty;

        private void OnRunStyleChooser(object sender, EventArgs e)
        {
            switch (selectedGauge)
            {
                case "Circular Gauge":
                    StyleChooser.Show(circularGauge1);
                    break;
                case "Linear Gauge":
                    StyleChooser.Show(linearGauge1);
                    break;
            }
        }

        private void OnRunStyleManager(object sender, EventArgs e)
        {
            switch (selectedGaugeContainer)
            {
                case "Gauge1":
                    StyleManager.Show(gaugeControl1);
                    break;
                case "Gauge2":
                    StyleManager.Show(gaugeControl2);
                    break;
            }
        }

        private void OnGaugeChanged(object sender, EventArgs e)
        {
            ComboBoxEdit edit = sender as ComboBoxEdit;
            selectedGauge = edit.Text;
        }

        private void OnGaugeContainerChanged(object sender, EventArgs e)
        {
            ComboBoxEdit edit = sender as ComboBoxEdit;
            selectedGaugeContainer = edit.Text;
        }
    }
}
