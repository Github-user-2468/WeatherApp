namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Searchlbl = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBT = new System.Windows.Forms.Button();
            this.conditionlbl = new System.Windows.Forms.Label();
            this.detailslbl = new System.Windows.Forms.Label();
            this.Sunriselbl = new System.Windows.Forms.Label();
            this.sunsetlbl = new System.Windows.Forms.Label();
            this.SunsetValuelbl = new System.Windows.Forms.Label();
            this.SunriseValuelbl = new System.Windows.Forms.Label();
            this.WindValuelbl = new System.Windows.Forms.Label();
            this.PressureValuelbl = new System.Windows.Forms.Label();
            this.Pressuelbl = new System.Windows.Forms.Label();
            this.WindSpeedlbl = new System.Windows.Forms.Label();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.BackColor = System.Drawing.Color.Transparent;
            this.Searchlbl.Font = new System.Drawing.Font("Sans Serif Collection", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.ForeColor = System.Drawing.Color.White;
            this.Searchlbl.Location = new System.Drawing.Point(5, 27);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(69, 68);
            this.Searchlbl.TabIndex = 0;
            this.Searchlbl.Text = "City:";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(80, 39);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(167, 30);
            this.SearchBox.TabIndex = 1;
            // 
            // SearchBT
            // 
            this.SearchBT.BackColor = System.Drawing.Color.Transparent;
            this.SearchBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBT.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchBT.Location = new System.Drawing.Point(266, 39);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(89, 30);
            this.SearchBT.TabIndex = 2;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = false;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // conditionlbl
            // 
            this.conditionlbl.AutoSize = true;
            this.conditionlbl.BackColor = System.Drawing.Color.Transparent;
            this.conditionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlbl.ForeColor = System.Drawing.Color.White;
            this.conditionlbl.Location = new System.Drawing.Point(39, 210);
            this.conditionlbl.Name = "conditionlbl";
            this.conditionlbl.Size = new System.Drawing.Size(95, 25);
            this.conditionlbl.TabIndex = 3;
            this.conditionlbl.Text = "Condition";
            // 
            // detailslbl
            // 
            this.detailslbl.AutoSize = true;
            this.detailslbl.BackColor = System.Drawing.Color.Transparent;
            this.detailslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailslbl.ForeColor = System.Drawing.Color.White;
            this.detailslbl.Location = new System.Drawing.Point(39, 253);
            this.detailslbl.Name = "detailslbl";
            this.detailslbl.Size = new System.Drawing.Size(71, 25);
            this.detailslbl.TabIndex = 4;
            this.detailslbl.Text = "Details";
            // 
            // Sunriselbl
            // 
            this.Sunriselbl.AutoSize = true;
            this.Sunriselbl.BackColor = System.Drawing.Color.Transparent;
            this.Sunriselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunriselbl.ForeColor = System.Drawing.Color.White;
            this.Sunriselbl.Location = new System.Drawing.Point(39, 301);
            this.Sunriselbl.Name = "Sunriselbl";
            this.Sunriselbl.Size = new System.Drawing.Size(79, 25);
            this.Sunriselbl.TabIndex = 5;
            this.Sunriselbl.Text = "Sunrise";
            // 
            // sunsetlbl
            // 
            this.sunsetlbl.AutoSize = true;
            this.sunsetlbl.BackColor = System.Drawing.Color.Transparent;
            this.sunsetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetlbl.ForeColor = System.Drawing.Color.White;
            this.sunsetlbl.Location = new System.Drawing.Point(42, 352);
            this.sunsetlbl.Name = "sunsetlbl";
            this.sunsetlbl.Size = new System.Drawing.Size(74, 25);
            this.sunsetlbl.TabIndex = 6;
            this.sunsetlbl.Text = "Sunset";
            // 
            // SunsetValuelbl
            // 
            this.SunsetValuelbl.AutoSize = true;
            this.SunsetValuelbl.BackColor = System.Drawing.Color.Transparent;
            this.SunsetValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetValuelbl.ForeColor = System.Drawing.Color.White;
            this.SunsetValuelbl.Location = new System.Drawing.Point(143, 352);
            this.SunsetValuelbl.Name = "SunsetValuelbl";
            this.SunsetValuelbl.Size = new System.Drawing.Size(46, 25);
            this.SunsetValuelbl.TabIndex = 7;
            this.SunsetValuelbl.Text = "N/A";
            // 
            // SunriseValuelbl
            // 
            this.SunriseValuelbl.AutoSize = true;
            this.SunriseValuelbl.BackColor = System.Drawing.Color.Transparent;
            this.SunriseValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseValuelbl.ForeColor = System.Drawing.Color.White;
            this.SunriseValuelbl.Location = new System.Drawing.Point(143, 301);
            this.SunriseValuelbl.Name = "SunriseValuelbl";
            this.SunriseValuelbl.Size = new System.Drawing.Size(46, 25);
            this.SunriseValuelbl.TabIndex = 8;
            this.SunriseValuelbl.Text = "N/A";
            // 
            // WindValuelbl
            // 
            this.WindValuelbl.AutoSize = true;
            this.WindValuelbl.BackColor = System.Drawing.Color.Transparent;
            this.WindValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindValuelbl.ForeColor = System.Drawing.Color.White;
            this.WindValuelbl.Location = new System.Drawing.Point(582, 212);
            this.WindValuelbl.Name = "WindValuelbl";
            this.WindValuelbl.Size = new System.Drawing.Size(46, 25);
            this.WindValuelbl.TabIndex = 12;
            this.WindValuelbl.Text = "N/A";
            // 
            // PressureValuelbl
            // 
            this.PressureValuelbl.AutoSize = true;
            this.PressureValuelbl.BackColor = System.Drawing.Color.Transparent;
            this.PressureValuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureValuelbl.ForeColor = System.Drawing.Color.White;
            this.PressureValuelbl.Location = new System.Drawing.Point(582, 255);
            this.PressureValuelbl.Name = "PressureValuelbl";
            this.PressureValuelbl.Size = new System.Drawing.Size(46, 25);
            this.PressureValuelbl.TabIndex = 11;
            this.PressureValuelbl.Text = "N/A";
            // 
            // Pressuelbl
            // 
            this.Pressuelbl.AutoSize = true;
            this.Pressuelbl.BackColor = System.Drawing.Color.Transparent;
            this.Pressuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressuelbl.ForeColor = System.Drawing.Color.White;
            this.Pressuelbl.Location = new System.Drawing.Point(438, 255);
            this.Pressuelbl.Name = "Pressuelbl";
            this.Pressuelbl.Size = new System.Drawing.Size(90, 25);
            this.Pressuelbl.TabIndex = 10;
            this.Pressuelbl.Text = "Pressure";
            // 
            // WindSpeedlbl
            // 
            this.WindSpeedlbl.AutoSize = true;
            this.WindSpeedlbl.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedlbl.ForeColor = System.Drawing.Color.White;
            this.WindSpeedlbl.Location = new System.Drawing.Point(438, 212);
            this.WindSpeedlbl.Name = "WindSpeedlbl";
            this.WindSpeedlbl.Size = new System.Drawing.Size(121, 25);
            this.WindSpeedlbl.TabIndex = 9;
            this.WindSpeedlbl.Text = "Wind Speed";
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.WeatherIcon.Location = new System.Drawing.Point(58, 89);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(122, 97);
            this.WeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherIcon.TabIndex = 13;
            this.WeatherIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.WindValuelbl);
            this.Controls.Add(this.PressureValuelbl);
            this.Controls.Add(this.Pressuelbl);
            this.Controls.Add(this.WindSpeedlbl);
            this.Controls.Add(this.SunriseValuelbl);
            this.Controls.Add(this.SunsetValuelbl);
            this.Controls.Add(this.sunsetlbl);
            this.Controls.Add(this.Sunriselbl);
            this.Controls.Add(this.detailslbl);
            this.Controls.Add(this.conditionlbl);
            this.Controls.Add(this.SearchBT);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Searchlbl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label conditionlbl;
        private System.Windows.Forms.Label detailslbl;
        private System.Windows.Forms.Label Sunriselbl;
        private System.Windows.Forms.Label sunsetlbl;
        private System.Windows.Forms.Label SunsetValuelbl;
        private System.Windows.Forms.Label SunriseValuelbl;
        private System.Windows.Forms.Label WindValuelbl;
        private System.Windows.Forms.Label PressureValuelbl;
        private System.Windows.Forms.Label Pressuelbl;
        private System.Windows.Forms.Label WindSpeedlbl;
        private System.Windows.Forms.PictureBox WeatherIcon;
    }
}

