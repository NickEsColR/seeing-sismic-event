﻿
namespace seeing_sismic_event
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.searchDataBase = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Magnitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterLocalidad = new System.Windows.Forms.Button();
            this.btnHoraF = new System.Windows.Forms.Button();
            this.txtLocalidadF = new System.Windows.Forms.TextBox();
            this.txtHoraF = new System.Windows.Forms.TextBox();
            this.lblFilters = new System.Windows.Forms.Label();
            this.btnMagnitud = new System.Windows.Forms.Button();
            this.txtMagMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMagMax = new System.Windows.Forms.TextBox();
            this.grfPuntos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grfBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grfPastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbFilterOptions = new System.Windows.Forms.ComboBox();
            this.btnFilterOptions = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfPastel)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(239, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(605, 389);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(75, 141);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(135, 20);
            this.txtLatitude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(76, 178);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(135, 20);
            this.txtLongitude.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Marker",
            "Polygon"});
            this.comboBox.Location = new System.Drawing.Point(75, 222);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(135, 21);
            this.comboBox.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(124, 267);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // searchDataBase
            // 
            this.searchDataBase.Location = new System.Drawing.Point(14, 41);
            this.searchDataBase.Margin = new System.Windows.Forms.Padding(2);
            this.searchDataBase.Name = "searchDataBase";
            this.searchDataBase.Size = new System.Drawing.Size(195, 19);
            this.searchDataBase.TabIndex = 10;
            this.searchDataBase.Text = "SearchDataBase";
            this.searchDataBase.UseVisualStyleBackColor = true;
            this.searchDataBase.Click += new System.EventHandler(this.btnSearchDataBase);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Latitud,
            this.Longitud,
            this.Magnitud,
            this.Profundidad,
            this.Localidad});
            this.table.Location = new System.Drawing.Point(239, 406);
            this.table.Margin = new System.Windows.Forms.Padding(2);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(605, 332);
            this.table.TabIndex = 11;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.Width = 125;
            // 
            // Latitud
            // 
            this.Latitud.HeaderText = "Latitud";
            this.Latitud.MinimumWidth = 6;
            this.Latitud.Name = "Latitud";
            this.Latitud.Width = 125;
            // 
            // Longitud
            // 
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.MinimumWidth = 6;
            this.Longitud.Name = "Longitud";
            this.Longitud.Width = 125;
            // 
            // Magnitud
            // 
            this.Magnitud.HeaderText = "Magnitud";
            this.Magnitud.MinimumWidth = 6;
            this.Magnitud.Name = "Magnitud";
            this.Magnitud.Width = 125;
            // 
            // Profundidad
            // 
            this.Profundidad.HeaderText = "Profundidad";
            this.Profundidad.MinimumWidth = 6;
            this.Profundidad.Name = "Profundidad";
            this.Profundidad.Width = 125;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 6;
            this.Localidad.Name = "Localidad";
            this.Localidad.Width = 125;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(9, 380);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Visible = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbbFilter
            // 
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "Magnitud menores a 4.5",
            "Magnitudes entre 4.5 y 5",
            "Magnitudes entre 5 y 6",
            "Magnitudes de 6 en adelante"});
            this.cbbFilter.Location = new System.Drawing.Point(90, 380);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(140, 21);
            this.cbbFilter.TabIndex = 13;
            this.cbbFilter.Visible = false;
            // 
            // btnFilterLocalidad
            // 
            this.btnFilterLocalidad.Location = new System.Drawing.Point(134, 449);
            this.btnFilterLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterLocalidad.Name = "btnFilterLocalidad";
            this.btnFilterLocalidad.Size = new System.Drawing.Size(66, 19);
            this.btnFilterLocalidad.TabIndex = 14;
            this.btnFilterLocalidad.Text = "Localidad";
            this.btnFilterLocalidad.UseVisualStyleBackColor = true;
            this.btnFilterLocalidad.Visible = false;
            this.btnFilterLocalidad.Click += new System.EventHandler(this.btnFilterLocalidad_Click);
            // 
            // btnHoraF
            // 
            this.btnHoraF.Location = new System.Drawing.Point(134, 493);
            this.btnHoraF.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoraF.Name = "btnHoraF";
            this.btnHoraF.Size = new System.Drawing.Size(66, 19);
            this.btnHoraF.TabIndex = 15;
            this.btnHoraF.Text = "Hora";
            this.btnHoraF.UseVisualStyleBackColor = true;
            this.btnHoraF.Visible = false;
            this.btnHoraF.Click += new System.EventHandler(this.btnHoraF_Click);
            // 
            // txtLocalidadF
            // 
            this.txtLocalidadF.Location = new System.Drawing.Point(8, 448);
            this.txtLocalidadF.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidadF.Name = "txtLocalidadF";
            this.txtLocalidadF.Size = new System.Drawing.Size(91, 20);
            this.txtLocalidadF.TabIndex = 16;
            this.txtLocalidadF.Visible = false;
            // 
            // txtHoraF
            // 
            this.txtHoraF.Location = new System.Drawing.Point(8, 492);
            this.txtHoraF.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraF.Name = "txtHoraF";
            this.txtHoraF.Size = new System.Drawing.Size(91, 20);
            this.txtHoraF.TabIndex = 17;
            this.txtHoraF.Visible = false;
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(69, 433);
            this.lblFilters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(55, 13);
            this.lblFilters.TabIndex = 18;
            this.lblFilters.Text = "Filter table";
            this.lblFilters.Visible = false;
            // 
            // btnMagnitud
            // 
            this.btnMagnitud.Location = new System.Drawing.Point(62, 592);
            this.btnMagnitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnMagnitud.Name = "btnMagnitud";
            this.btnMagnitud.Size = new System.Drawing.Size(74, 19);
            this.btnMagnitud.TabIndex = 19;
            this.btnMagnitud.Text = "Magnitud";
            this.btnMagnitud.UseVisualStyleBackColor = true;
            this.btnMagnitud.Visible = false;
            this.btnMagnitud.Click += new System.EventHandler(this.btnMagnitud_Click);
            // 
            // txtMagMin
            // 
            this.txtMagMin.Location = new System.Drawing.Point(20, 559);
            this.txtMagMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMagMin.Name = "txtMagMin";
            this.txtMagMin.Size = new System.Drawing.Size(54, 20);
            this.txtMagMin.TabIndex = 20;
            this.txtMagMin.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 532);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "mag min";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 532);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "mag max";
            this.label5.Visible = false;
            // 
            // txtMagMax
            // 
            this.txtMagMax.Location = new System.Drawing.Point(134, 559);
            this.txtMagMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtMagMax.Name = "txtMagMax";
            this.txtMagMax.Size = new System.Drawing.Size(54, 20);
            this.txtMagMax.TabIndex = 22;
            this.txtMagMax.Visible = false;
            // 
            // grfPuntos
            // 
            chartArea1.Name = "ChartArea1";
            this.grfPuntos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grfPuntos.Legends.Add(legend1);
            this.grfPuntos.Location = new System.Drawing.Point(865, 12);
            this.grfPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.grfPuntos.Name = "grfPuntos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Sismos";
            this.grfPuntos.Series.Add(series1);
            this.grfPuntos.Size = new System.Drawing.Size(389, 254);
            this.grfPuntos.TabIndex = 24;
            this.grfPuntos.Text = "chart1";
            // 
            // grfBarras
            // 
            chartArea2.Name = "ChartArea1";
            this.grfBarras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grfBarras.Legends.Add(legend2);
            this.grfBarras.Location = new System.Drawing.Point(865, 280);
            this.grfBarras.Margin = new System.Windows.Forms.Padding(2);
            this.grfBarras.Name = "grfBarras";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grfBarras.Series.Add(series2);
            this.grfBarras.Size = new System.Drawing.Size(389, 254);
            this.grfBarras.TabIndex = 25;
            this.grfBarras.Text = "chart2";
            // 
            // grfPastel
            // 
            chartArea3.Name = "ChartArea1";
            this.grfPastel.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grfPastel.Legends.Add(legend3);
            this.grfPastel.Location = new System.Drawing.Point(865, 544);
            this.grfPastel.Margin = new System.Windows.Forms.Padding(2);
            this.grfPastel.Name = "grfPastel";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.grfPastel.Series.Add(series3);
            this.grfPastel.Size = new System.Drawing.Size(389, 254);
            this.grfPastel.TabIndex = 26;
            this.grfPastel.Text = "chart3";
            // 
            // cbbFilterOptions
            // 
            this.cbbFilterOptions.FormattingEnabled = true;
            this.cbbFilterOptions.Items.AddRange(new object[] {
            "Categorico",
            "Cadena",
            "Numerico"});
            this.cbbFilterOptions.Location = new System.Drawing.Point(90, 330);
            this.cbbFilterOptions.Name = "cbbFilterOptions";
            this.cbbFilterOptions.Size = new System.Drawing.Size(140, 21);
            this.cbbFilterOptions.TabIndex = 27;
            // 
            // btnFilterOptions
            // 
            this.btnFilterOptions.Location = new System.Drawing.Point(8, 330);
            this.btnFilterOptions.Name = "btnFilterOptions";
            this.btnFilterOptions.Size = new System.Drawing.Size(75, 23);
            this.btnFilterOptions.TabIndex = 28;
            this.btnFilterOptions.Text = "Go";
            this.btnFilterOptions.UseVisualStyleBackColor = true;
            this.btnFilterOptions.Click += new System.EventHandler(this.btnFilterOptions_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "seleccione un metodo de filtrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFilterOptions);
            this.Controls.Add(this.cbbFilterOptions);
            this.Controls.Add(this.grfPastel);
            this.Controls.Add(this.grfBarras);
            this.Controls.Add(this.grfPuntos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMagMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMagMin);
            this.Controls.Add(this.btnMagnitud);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.txtHoraF);
            this.Controls.Add(this.txtLocalidadF);
            this.Controls.Add(this.btnHoraF);
            this.Controls.Add(this.btnFilterLocalidad);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.table);
            this.Controls.Add(this.searchDataBase);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Sismic Event";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfPastel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button searchDataBase;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magnitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.Button btnFilterLocalidad;
        private System.Windows.Forms.Button btnHoraF;
        private System.Windows.Forms.TextBox txtLocalidadF;
        private System.Windows.Forms.TextBox txtHoraF;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Button btnMagnitud;
        private System.Windows.Forms.TextBox txtMagMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMagMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfPuntos;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfPastel;
        private System.Windows.Forms.ComboBox cbbFilterOptions;
        private System.Windows.Forms.Button btnFilterOptions;
        private System.Windows.Forms.Label label6;
    }
}

