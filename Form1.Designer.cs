namespace CografiBilgiSistemiProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gmp1 = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gmp1
            // 
            this.gmp1.Bearing = 0F;
            this.gmp1.CanDragMap = true;
            this.gmp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmp1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmp1.GrayScaleMode = false;
            this.gmp1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmp1.LevelsKeepInMemory = 5;
            this.gmp1.Location = new System.Drawing.Point(0, 0);
            this.gmp1.MarkersEnabled = true;
            this.gmp1.MaxZoom = 2;
            this.gmp1.MinZoom = 2;
            this.gmp1.MouseWheelZoomEnabled = true;
            this.gmp1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmp1.Name = "gmp1";
            this.gmp1.NegativeMode = false;
            this.gmp1.PolygonsEnabled = true;
            this.gmp1.RetryLoadTile = 0;
            this.gmp1.RoutesEnabled = true;
            this.gmp1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmp1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmp1.ShowTileGridLines = false;
            this.gmp1.Size = new System.Drawing.Size(1250, 606);
            this.gmp1.TabIndex = 0;
            this.gmp1.Zoom = 0D;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 606);
            this.Controls.Add(this.gmp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmp1;
        private System.Windows.Forms.Timer timer1;
    }
}

