﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace seeing_sismic_event
{
    public partial class Form1: Form
    {
        //attributes
        private List<String> data;
        private List<String> magProf; //magnitud y profundidad para el filtro
        private List<PointLatLng> points;
        private List<PointLatLng> shapes;
        private String[] lines;
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

            grfBarras.Series.Clear();
            String[] region = { "sureste", "noreste", "suroeste", "noroeste" };
            grfPastel.Titles.Clear();

            int sureste = 0;
            int suroeste = 0;
            int noroeste = 0;
            int noreste = 0;
            String[] magnitudes = { "3", "4", "5", "6" };
            grfBarras.Titles.Clear();
            int mag3 = 0;
            int mag4 = 0;
            int mag5 = 0;
            int mag6 = 0;

            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                searchDataBase.Text = buscar.FileName;
            }
            lines = File.ReadAllLines(searchDataBase.Text);

            // table

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

                //////////////////////////// grafico de barras conteo

                double latitud = double.Parse(values[2]);
                double logitud = double.Parse(values[3]);

                if ((latitud >= 0) && (logitud < 0))
                {
                    noroeste++;
                }
                else if ((latitud < 0) && (logitud < 0))
                {
                    suroeste++;
                }
                else if ((latitud >= 0) && (logitud >= 0))
                {
                    noreste++;
                }
                else
                {
                    sureste++;
                }

                //////////////////////////// grafico de pastel conteo

                double magnitudCurrent = double.Parse(values[4]);

                if ((magnitudCurrent >= 3.0) && (magnitudCurrent < 4.0))
                {
                    mag3++;

                }
                else if ((magnitudCurrent >= 4.0) && (magnitudCurrent < 5.0))
                {
                    mag4++;

                }
                else if ((magnitudCurrent >= 5.0) && (magnitudCurrent < 6.0))
                {
                    mag5++;

                }
                else if ((magnitudCurrent >= 6.0) && (magnitudCurrent < 7.0))
                {
                    mag6++;

                }
                //grafica de puntos
                double deep = double.Parse(values[5]);
                grfPuntos.Series["Sismos"].Points.AddXY(magnitudCurrent, deep);
            }


            // graficas

            //punto
            grfPuntos.Titles.Add("magnitud y profundidad");
           

            //barras

            int[] cantB = { noroeste, noreste, sureste, suroeste };
            for (int i = 0; i < region.Length ; i++)
            {
                Series serie = grfBarras.Series.Add(region[i]);

                serie.Label = cantB[i].ToString();
                serie.Points.Add(cantB[i]);
            }
                grfBarras.Titles.Add("Distribucion por zona geografica");

            //pastel

            int[] cantP = { mag3, mag4, mag5, mag6 };


            for (int i = 0; i < magnitudes.Length; i++)
            {
                grfPastel.Series["Series2"].Points.AddXY(magnitudes[i], cantP[i]);
            }
                grfPastel.Titles.Add("distibucion de Magnitudes");

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

        private void btnFilterLocalidad_Click(object sender, EventArgs e)
        {

            table.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                String[] values = lines[i].Split(' ');

                String localidad = "";

                for (int k = 6; k < values.Length; k++)
                {
                    localidad = localidad + " " + values[k];
                }

                String localidadSelected = txtLocalidadF.Text;

                if (localidad.Contains(localidadSelected))
                {
                    data.Add(lines[i]);
                    int n = table.Rows.Add();

                    table.Rows[n].Cells[0].Value = values[0];
                    table.Rows[n].Cells[1].Value = values[1];
                    table.Rows[n].Cells[2].Value = values[2];
                    table.Rows[n].Cells[3].Value = values[3];
                    table.Rows[n].Cells[4].Value = values[4];
                    table.Rows[n].Cells[5].Value = values[5];
                    table.Rows[n].Cells[6].Value = localidad;

                }

                

            }



        }

        private void btnHoraF_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                String[] values = lines[i].Split(' ');


                String hourSelected = txtHoraF.Text;

                String[] hourCurrent = values[1].Split(':');


                if (hourCurrent[0].Equals(hourSelected))
                {
                    data.Add(lines[i]);
                    int n = table.Rows.Add();
                    String localidad = "";

                    for (int k = 6; k < values.Length; k++)
                    {
                        localidad = localidad + " " + values[k];
                    }

                    table.Rows[n].Cells[0].Value = values[0];
                    table.Rows[n].Cells[1].Value = values[1];
                    table.Rows[n].Cells[2].Value = values[2];
                    table.Rows[n].Cells[3].Value = values[3];
                    table.Rows[n].Cells[4].Value = values[4];
                    table.Rows[n].Cells[5].Value = values[5];
                    table.Rows[n].Cells[6].Value = localidad;

                }



            }
        }

        private void btnMagnitud_Click(object sender, EventArgs e)
        {

            table.Rows.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                String[] values = lines[i].Split(' ');


                double magMin = double.Parse(txtMagMin.Text);
                double magMax = double.Parse(txtMagMax.Text);
                double magCurrent = double.Parse(values[4]);

                if ( magMin<=magCurrent && magCurrent <= magMax )
                {

                        data.Add(lines[i]);
                        int n = table.Rows.Add();
                        String localidad = "";

                        for (int k = 6; k < values.Length; k++)
                        {
                            localidad = localidad + " " + values[k];
                        }

                        table.Rows[n].Cells[0].Value = values[0];
                        table.Rows[n].Cells[1].Value = values[1];
                        table.Rows[n].Cells[2].Value = values[2];
                        table.Rows[n].Cells[3].Value = values[3];
                        table.Rows[n].Cells[4].Value = values[4];
                        table.Rows[n].Cells[5].Value = values[5];
                        table.Rows[n].Cells[6].Value = localidad;

                }
                

            }

        }

        private void btnFilterOptions_Click(object sender, EventArgs e)
        {
            int pos = cbbFilterOptions.SelectedIndex;
            switch (pos)
            {
                case 0:
                    cbbFilter.Visible = true;
                    btnFilter.Visible = true;
                    lblFilters.Visible = false;
                    txtLocalidadF.Visible = false;
                    btnFilterLocalidad.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    txtMagMin.Visible = false;
                    txtMagMax.Visible = false;
                    btnMagnitud.Visible = false;
                    break;
                case 1:
                    lblFilters.Visible = true;
                    txtLocalidadF.Visible = true;
                    btnFilterLocalidad.Visible = true;
                    cbbFilter.Visible = false;
                    btnFilter.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    txtMagMin.Visible = false;
                    txtMagMax.Visible = false;
                    btnMagnitud.Visible = false;
                    break;
                case 2:
                    label4.Visible = true;
                    label5.Visible = true;
                    txtMagMin.Visible = true;
                    txtMagMax.Visible = true;
                    btnMagnitud.Visible = true;
                    lblFilters.Visible = true;
                    txtLocalidadF.Visible = false;
                    btnFilterLocalidad.Visible = false;
                    cbbFilter.Visible = false;
                    btnFilter.Visible = false;
                    break;
            }
        }
    }
}
