using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikestore
{
    public partial class MAPFORM : Form
    {
        public MAPFORM()
        {
            InitializeComponent();
        }

        private void MAPFORM_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            keyValues["AF"] = 1546;
            keyValues["AO"] = 646;
            keyValues["AL"] = 1546;
            keyValues["AE"] = 1546;
            keyValues["AR"] = 16546;
            keyValues["AM"] = 1546;
            keyValues["AU"] = 1546;
            geoMap.HeatMap = keyValues;
            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}
