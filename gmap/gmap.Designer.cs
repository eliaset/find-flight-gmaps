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
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btClearFilter = new System.Windows.Forms.Button();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbMunicipaly = new System.Windows.Forms.RadioButton();
            this.rbFlag = new System.Windows.Forms.RadioButton();
            this.rbProduct = new System.Windows.Forms.RadioButton();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btFilter = new System.Windows.Forms.Button();
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
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(701, 410);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btClearFilter
            // 
            this.btClearFilter.Location = new System.Drawing.Point(723, 474);
            this.btClearFilter.Name = "btClearFilter";
            this.btClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btClearFilter.TabIndex = 4;
            this.btClearFilter.Text = "Limpiar";
            this.btClearFilter.UseVisualStyleBackColor = true;
            this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(723, 277);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(45, 17);
            this.rbMonth.TabIndex = 6;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Mes";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // rbMunicipaly
            // 
            this.rbMunicipaly.AutoSize = true;
            this.rbMunicipaly.Location = new System.Drawing.Point(723, 301);
            this.rbMunicipaly.Name = "rbMunicipaly";
            this.rbMunicipaly.Size = new System.Drawing.Size(70, 17);
            this.rbMunicipaly.TabIndex = 7;
            this.rbMunicipaly.TabStop = true;
            this.rbMunicipaly.Text = "Municipio";
            this.rbMunicipaly.UseVisualStyleBackColor = true;
            this.rbMunicipaly.CheckedChanged += new System.EventHandler(this.rbMunicipaly_CheckedChanged);
            // 
            // rbFlag
            // 
            this.rbFlag.AutoSize = true;
            this.rbFlag.Location = new System.Drawing.Point(723, 325);
            this.rbFlag.Name = "rbFlag";
            this.rbFlag.Size = new System.Drawing.Size(68, 17);
            this.rbFlag.TabIndex = 8;
            this.rbFlag.TabStop = true;
            this.rbFlag.Text = "Bandera ";
            this.rbFlag.UseVisualStyleBackColor = true;
            this.rbFlag.CheckedChanged += new System.EventHandler(this.rbFlag_CheckedChanged);
            // 
            // rbProduct
            // 
            this.rbProduct.AutoSize = true;
            this.rbProduct.Location = new System.Drawing.Point(723, 349);
            this.rbProduct.Name = "rbProduct";
            this.rbProduct.Size = new System.Drawing.Size(68, 17);
            this.rbProduct.TabIndex = 9;
            this.rbProduct.TabStop = true;
            this.rbProduct.Text = "Producto";
            this.rbProduct.UseVisualStyleBackColor = true;
            this.rbProduct.CheckedChanged += new System.EventHandler(this.rbProduct_CheckedChanged);
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Location = new System.Drawing.Point(723, 373);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(55, 17);
            this.rbPrice.TabIndex = 10;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "Precio";
            this.rbPrice.UseVisualStyleBackColor = true;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtros";
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(723, 445);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(75, 23);
            this.btFilter.TabIndex = 12;
            this.btFilter.Text = "Filtrar";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // gmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPrice);
            this.Controls.Add(this.rbProduct);
            this.Controls.Add(this.rbFlag);
            this.Controls.Add(this.rbMunicipaly);
            this.Controls.Add(this.rbMonth);
            this.Controls.Add(this.btClearFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.gMapC);
            this.Name = "gmap";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.gmap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapC;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btClearFilter;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbMunicipaly;
        private System.Windows.Forms.RadioButton rbFlag;
        private System.Windows.Forms.RadioButton rbProduct;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFilter;
    }
}

