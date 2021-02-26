using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<String> data;
        private List<String> magProf; //magnitud y profundidad para el filtro
        private List<PointLatLng> points;
        private List<PointLatLng> shapes;
        GMapOverlay markers = new GMapOverlay("markers");
        GMapOverlay polygons = new GMapOverlay("polygond");

        public Form1()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
            shapes = new List<PointLatLng>();
            data = new List<string>();
            magProf = new List<string>();
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
            int numMagProf = 0; //posicion en lista magProf
            foreach(PointLatLng p in points)
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                String[] row = magProf[numMagProf].Split(' ');
                marker.ToolTipText = "Mag: " + row[0] + "\n" + "Prof: " + row[1]+ "\n" + row[2]; 
                markers.Markers.Add(marker);
                numMagProf++;
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
                data.Add(lines[i]);
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int pos = cbbFilter.SelectedIndex;
            double mag = 0;
            PointLatLng p = new PointLatLng();
            foreach (String n in data)
            {
                string[] row = n.Split(' ');
                mag = double.Parse(row[4]);
                switch (pos)
                {
                    case 0:
                        if (mag < 4.5)
                        {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                            magProf.Add(row[4] +" "+ row[5]+" " +row[6]);
                        }
                        break;
                    case 1:
                        if ((mag >= 4.5) && (mag < 5))
                        {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                            magProf.Add(row[4] + " " + row[5] + " " + row[6]);
                        }
                        break;
                    case 2:
                        if ((mag >= 5) && (mag <= 6))
                        {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                            magProf.Add(row[4] + " " + row[5] + " " + row[6]);
                        }
                        break;
                    case 3:
                        if (mag > 6)
                        {
                            double lat = double.Parse(row[2]);
                            double lng = double.Parse(row[3]);
                            p = new PointLatLng(lat, lng);
                            points.Add(p);
                            magProf.Add(row[4] + " " + row[5] + " " + row[6]);
                        }
                        break;
                }
            }
            setMarkers();
            points.Clear();
        }
    }
}
