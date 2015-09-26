using GMap.NET;
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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // Initialize map:
            gMapControl.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl.Position = new GMap.NET.PointLatLng(0.06,34);
            // gMapControl.SetPositionByKeywords("Embu, kenya");

            //Placing a marker on a certain position
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new  PointLatLng(0.06, 34.2),
              GMarkerGoogleType.green);

            GMapOverlay markersOverlaymaseno = new GMapOverlay("markers");
            GMarkerGoogle masenomarker = new GMarkerGoogle(new PointLatLng(45, 45),
              GMarkerGoogleType.blue);

            markersOverlay.Markers.Add(marker);
            gMapControl.Overlays.Add(markersOverlay);
          
            markersOverlay.Markers.Add(masenomarker);
            gMapControl.Overlays.Add(markersOverlay);



            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(-25.969562, 32.585789));
            points.Add(new PointLatLng(-25.966205, 32.588171));
            points.Add(new PointLatLng(-25.968134, 32.591647));
            points.Add(new PointLatLng(-25.971684, 32.589759));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gMapControl.Overlays.Add(polyOverlay);


        }
    }
    }

