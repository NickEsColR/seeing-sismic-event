using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace seeing_sismic_event
{
    public partial class Form1: Form
    {
        //attributes
        private List<PointLatLng> points;
        private List<PointLatLng> shapes;
        GMapOverlay markers = new GMapOverlay("markers");
        GMapOverlay polygons = new GMapOverlay("polygond");

        public Form1()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
            shapes = new List<PointLatLng>();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(3.42158, -76.5205);
            gMapControl1.Overlays.Add(markers);
            gMapControl1.Overlays.Add(polygons);
        }

        private void setMarkers()
        {
            foreach(PointLatLng p in points)
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker);
            }
        }

        private void setPolygons()
        {
            GMapPolygon polygon = new GMapPolygon(shapes, "polygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polygons.Polygons.Add(polygon);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double latitude = double.Parse(txtLatitude.Text);
            txtLatitude.Text = "";
            double longitude = double.Parse(txtLongitude.Text);
            txtLongitude.Text = "";
            PointLatLng p = new PointLatLng(latitude, longitude);
            if (comboBox.Text == "Marker")
            {
                points.Add(p);
            }else if (comboBox.Text == "Polygon")
            {
                shapes.Add(p);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (comboBox.Text == "Marker")
            {
                setMarkers();
                points.Clear();
            }else if (comboBox.Text == "Polygon")
            {
                setPolygons();
                shapes.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            points.Clear();
            markers.Clear();
            polygons.Clear();
            shapes.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int pos = cbbFilter.SelectedIndex;
            double mag = 0;
            PointLatLng p = new PointLatLng();
            List<String> data = new List<String>(); //cambiar por la lista del modelo
            foreach (String n in data)
            {
                string[] row = n.Split(' ');
                mag = double.Parse(row[4]);
                switch(pos)
                {
                case 0:
                        if (mag < 4.5)
                        {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                    }
                    MessageBox.Show("0");
                break;
                case 1:
                    if(mag >= 4.5 && mag < 5)
                    {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                        }
                    MessageBox.Show("1");
                    break;
                case 2:
                    if(mag >= 5 && mag <= 6)
                    {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                        }
                    MessageBox.Show("2");
                    break;
                case 3:
                    if(mag > 6)
                    {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                        }
                    MessageBox.Show("3");
                    break;
                 }
            }
            setMarkers();
            points.Clear();
        }

    }
}
