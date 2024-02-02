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
            this.labcity = new System.Windows.Forms.Label();
            this.cities = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.labcondition = new System.Windows.Forms.Label();
            this.labdetails = new System.Windows.Forms.Label();
            this.labtemp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labfeelslike = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labwindspeed = new System.Windows.Forms.Label();
            this.labpressure = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labhumidity = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labcity
            // 
            this.labcity.AutoSize = true;
            this.labcity.BackColor = System.Drawing.Color.Transparent;
            this.labcity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcity.ForeColor = System.Drawing.Color.White;
            this.labcity.Location = new System.Drawing.Point(53, 47);
            this.labcity.Name = "labcity";
            this.labcity.Size = new System.Drawing.Size(41, 23);
            this.labcity.TabIndex = 0;
            this.labcity.Text = "City";
            // 
            // cities
            // 
            this.cities.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cities.Location = new System.Drawing.Point(100, 44);
            this.cities.Name = "cities";
            this.cities.Size = new System.Drawing.Size(200, 31);
            this.cities.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(326, 47);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // labcondition
            // 
            this.labcondition.AutoSize = true;
            this.labcondition.BackColor = System.Drawing.Color.Transparent;
            this.labcondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcondition.ForeColor = System.Drawing.Color.White;
            this.labcondition.Location = new System.Drawing.Point(53, 278);
            this.labcondition.Name = "labcondition";
            this.labcondition.Size = new System.Drawing.Size(86, 23);
            this.labcondition.TabIndex = 3;
            this.labcondition.Text = "Condition";
            // 
            // labdetails
            // 
            this.labdetails.AutoSize = true;
            this.labdetails.BackColor = System.Drawing.Color.Transparent;
            this.labdetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdetails.ForeColor = System.Drawing.Color.White;
            this.labdetails.Location = new System.Drawing.Point(53, 332);
            this.labdetails.Name = "labdetails";
            this.labdetails.Size = new System.Drawing.Size(66, 23);
            this.labdetails.TabIndex = 4;
            this.labdetails.Text = "Details";
            this.labdetails.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // labtemp
            // 
            this.labtemp.AutoSize = true;
            this.labtemp.BackColor = System.Drawing.Color.Transparent;
            this.labtemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtemp.ForeColor = System.Drawing.Color.White;
            this.labtemp.Location = new System.Drawing.Point(595, 220);
            this.labtemp.Name = "labtemp";
            this.labtemp.Size = new System.Drawing.Size(42, 23);
            this.labtemp.TabIndex = 5;
            this.labtemp.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(450, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Temperature";
            // 
            // labfeelslike
            // 
            this.labfeelslike.AutoSize = true;
            this.labfeelslike.BackColor = System.Drawing.Color.Transparent;
            this.labfeelslike.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labfeelslike.ForeColor = System.Drawing.Color.White;
            this.labfeelslike.Location = new System.Drawing.Point(595, 258);
            this.labfeelslike.Name = "labfeelslike";
            this.labfeelslike.Size = new System.Drawing.Size(42, 23);
            this.labfeelslike.TabIndex = 10;
            this.labfeelslike.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(460, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Feels Like";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(450, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Wind Speed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(460, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pressure:";
            // 
            // labwindspeed
            // 
            this.labwindspeed.AutoSize = true;
            this.labwindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labwindspeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labwindspeed.ForeColor = System.Drawing.Color.White;
            this.labwindspeed.Location = new System.Drawing.Point(595, 344);
            this.labwindspeed.Name = "labwindspeed";
            this.labwindspeed.Size = new System.Drawing.Size(42, 23);
            this.labwindspeed.TabIndex = 14;
            this.labwindspeed.Text = "N/A";
            // 
            // labpressure
            // 
            this.labpressure.AutoSize = true;
            this.labpressure.BackColor = System.Drawing.Color.Transparent;
            this.labpressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpressure.ForeColor = System.Drawing.Color.White;
            this.labpressure.Location = new System.Drawing.Point(595, 386);
            this.labpressure.Name = "labpressure";
            this.labpressure.Size = new System.Drawing.Size(42, 23);
            this.labpressure.TabIndex = 15;
            this.labpressure.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(464, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Humidity";
            // 
            // labhumidity
            // 
            this.labhumidity.AutoSize = true;
            this.labhumidity.BackColor = System.Drawing.Color.Transparent;
            this.labhumidity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhumidity.ForeColor = System.Drawing.Color.White;
            this.labhumidity.Location = new System.Drawing.Point(595, 304);
            this.labhumidity.Name = "labhumidity";
            this.labhumidity.Size = new System.Drawing.Size(42, 23);
            this.labhumidity.TabIndex = 17;
            this.labhumidity.Text = "N/A";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.BackColor = System.Drawing.Color.Transparent;
            this.labname.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labname.ForeColor = System.Drawing.Color.White;
            this.labname.Location = new System.Drawing.Point(44, 156);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(174, 78);
            this.labname.TabIndex = 18;
            this.labname.Text = "place";
            // 
            // Form1
            // 
            this.BackgroundImage = global::WeatherApp.Properties.Resources.backiee_118606_landscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 478);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.labhumidity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labpressure);
            this.Controls.Add(this.labwindspeed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labfeelslike);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labtemp);
            this.Controls.Add(this.labdetails);
            this.Controls.Add(this.labcondition);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cities);
            this.Controls.Add(this.labcity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labcity;
        private System.Windows.Forms.TextBox cities;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label labcondition;
        private System.Windows.Forms.Label labdetails;
        private System.Windows.Forms.Label labtemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labfeelslike;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labwindspeed;
        private System.Windows.Forms.Label labpressure;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labhumidity;
        private System.Windows.Forms.Label labname;
    }
}

