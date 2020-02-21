namespace gmap
{
    partial class gmap
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
            this.gMapC = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSearchStation = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btClearFilter = new System.Windows.Forms.Button();
            this.btClearStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapC
            // 
            this.gMapC.Bearing = 0F;
            this.gMapC.CanDragMap = true;
            this.gMapC.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapC.GrayScaleMode = false;
            this.gMapC.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapC.LevelsKeepInMemmory = 5;
            this.gMapC.Location = new System.Drawing.Point(2, 4);
            this.gMapC.MarkersEnabled = true;
            this.gMapC.MaxZoom = 2;
            this.gMapC.MinZoom = 2;
            this.gMapC.MouseWheelZoomEnabled = true;
            this.gMapC.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapC.Name = "gMapC";
            this.gMapC.NegativeMode = false;
            this.gMapC.PolygonsEnabled = true;
            this.gMapC.RetryLoadTile = 0;
            this.gMapC.RoutesEnabled = true;
            this.gMapC.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapC.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapC.ShowTileGridLines = false;
            this.gMapC.Size = new System.Drawing.Size(615, 527);
            this.gMapC.TabIndex = 0;
            this.gMapC.Zoom = 0D;
            this.gMapC.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btSearchStation
            // 
            this.btSearchStation.Location = new System.Drawing.Point(704, 87);
            this.btSearchStation.Name = "btSearchStation";
            this.btSearchStation.Size = new System.Drawing.Size(109, 23);
            this.btSearchStation.TabIndex = 2;
            this.btSearchStation.Text = "Buscar Estación";
            this.btSearchStation.UseVisualStyleBackColor = true;
            this.btSearchStation.Click += new System.EventHandler(this.btSearchStation_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(704, 222);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btClearFilter
            // 
            this.btClearFilter.Location = new System.Drawing.Point(726, 277);
            this.btClearFilter.Name = "btClearFilter";
            this.btClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btClearFilter.TabIndex = 4;
            this.btClearFilter.Text = "Limpiar";
            this.btClearFilter.UseVisualStyleBackColor = true;
            this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
            // 
            // btClearStation
            // 
            this.btClearStation.Location = new System.Drawing.Point(726, 116);
            this.btClearStation.Name = "btClearStation";
            this.btClearStation.Size = new System.Drawing.Size(75, 23);
            this.btClearStation.TabIndex = 5;
            this.btClearStation.Text = "Limpiar";
            this.btClearStation.UseVisualStyleBackColor = true;
            this.btClearStation.Click += new System.EventHandler(this.btClearStation_Click);
            // 
            // gmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.Controls.Add(this.btClearStation);
            this.Controls.Add(this.btClearFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btSearchStation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gMapC);
            this.Name = "gmap";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.gmap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSearchStation;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btClearFilter;
        private System.Windows.Forms.Button btClearStation;
    }
}

