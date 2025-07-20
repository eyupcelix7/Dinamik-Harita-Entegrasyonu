using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CografiBilgiSistemiProjesi
{
    public partial class Form1 : Form
    {
        GMapOverlay katman1;
        PointLatLng lokasyon = new PointLatLng(39.719122, 43.032772);

        public Form1()
        {
            InitializeComponent();
            InitializeMap();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Prototipdir, Deneme Amaçlı Hazırlanmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void InitializeMap()
        {
            gmp1.DragButton = MouseButtons.Left;
            gmp1.MapProvider = GMapProviders.GoogleMap;
            gmp1.Position = new GMap.NET.PointLatLng(39.717186, 43.039186);
            gmp1.MinZoom = 13;
            gmp1.MaxZoom = 24;
            gmp1.Zoom = 9;
            katman1 = new GMapOverlay();
            gmp1.Overlays.Add(katman1);
            GMarkerGoogle gMarker1 = new GMarkerGoogle(lokasyon, GMarkerGoogleType.red_dot);
            katman1.Markers.Add(gMarker1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            katman1.Markers.Clear();
            lokasyon = new PointLatLng(lokasyon.Lat+1,lokasyon.Lng+1);
            GMarkerGoogle gMarker1 = new GMarkerGoogle(lokasyon, GMarkerGoogleType.red_dot);
            gMarker1.ToolTipText = "\nKurye: Eyüp ÇELİK\n";
            gMarker1.ToolTip.Fill = Brushes.Black;
            gMarker1.ToolTip.Foreground = Brushes.White;
            gMarker1.ToolTip.TextPadding = new Size(5, 5);
            katman1.Markers.Add(gMarker1);
        }
    }
}
