
namespace CargoShipLoaderWin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_trainCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_newShip = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CargoShipLoaderWin.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(41, 305);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(235, 45);
            this.track_motorCycles.TabIndex = 1;
            this.track_motorCycles.Scroll += new System.EventHandler(this.track_motorCycles_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(502, 305);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(235, 45);
            this.track_trucks.TabIndex = 2;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(41, 435);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(235, 45);
            this.track_cars.TabIndex = 3;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(502, 435);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(235, 45);
            this.track_trainCars.TabIndex = 4;
            this.track_trainCars.Scroll += new System.EventHandler(this.track_trainCars_Scroll);
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cycleCount.Location = new System.Drawing.Point(134, 279);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(18, 20);
            this.label_cycleCount.TabIndex = 5;
            this.label_cycleCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MotorCycles (3 units)";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_truckCount.Location = new System.Drawing.Point(598, 279);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(18, 20);
            this.label_truckCount.TabIndex = 7;
            this.label_truckCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trucks (11 units)";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_carCount.Location = new System.Drawing.Point(134, 412);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(18, 20);
            this.label_carCount.TabIndex = 9;
            this.label_carCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cars (5 units)";
            // 
            // label_trainCount
            // 
            this.label_trainCount.AutoSize = true;
            this.label_trainCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trainCount.Location = new System.Drawing.Point(598, 412);
            this.label_trainCount.Name = "label_trainCount";
            this.label_trainCount.Size = new System.Drawing.Size(18, 20);
            this.label_trainCount.TabIndex = 11;
            this.label_trainCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(548, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Train Cars (17 units)";
            // 
            // btn_newShip
            // 
            this.btn_newShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newShip.Location = new System.Drawing.Point(53, 528);
            this.btn_newShip.Name = "btn_newShip";
            this.btn_newShip.Size = new System.Drawing.Size(116, 45);
            this.btn_newShip.TabIndex = 13;
            this.btn_newShip.Text = "New Ship";
            this.btn_newShip.UseVisualStyleBackColor = true;
            this.btn_newShip.Click += new System.EventHandler(this.btn_newShip_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(228, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 132);
            this.progressBar1.TabIndex = 14;
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shipLabel.Location = new System.Drawing.Point(189, 163);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(51, 20);
            this.label_shipLabel.TabIndex = 15;
            this.label_shipLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 593);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_newShip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_trainCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cargo Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_trainCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_newShip;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

