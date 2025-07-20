using GMap.NET.MapProviders;
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
        public Form1()
        {
            InitializeComponent();
            InitializeMap();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void InitializeMap()
        {
            gmp1.MapProvider = GMapProviders.OpenStreetMap;
            gmp1.Position = new GMap.NET.PointLatLng(39.717186, 43.039186);
            gmp1.Zoom = 4;
            gmp1.MinZoom = 3;
            gmp1.MaxZoom = 20;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            gmp1.Dispose();
            Application.Exit();
        }
    }
}
