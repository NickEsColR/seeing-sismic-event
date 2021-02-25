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
using System.IO;

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

        private void btnSearchDataBase(object sender, EventArgs e)
        {

            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                searchDataBase.Text = buscar.FileName;
            }
            String[] lines;
            lines = File.ReadAllLines(searchDataBase.Text);

            for (int i = 0; i < lines.Length; i++)
            {
                String[] values = lines[i].Split(' ');

                int n = table.Rows.Add();

                table.Rows[n].Cells[0].Value = values[0];
                table.Rows[n].Cells[1].Value = values[1];
                table.Rows[n].Cells[2].Value = values[2];
                table.Rows[n].Cells[3].Value = values[3];
                table.Rows[n].Cells[4].Value = values[4];
                table.Rows[n].Cells[5].Value = values[5];

                string localidad = "";

                for (int k = 6; k < values.Length; k++)
                {
                    localidad = localidad + " " + values[k];
                }

                table.Rows[n].Cells[6].Value = localidad;

            }


        }

    }
}
