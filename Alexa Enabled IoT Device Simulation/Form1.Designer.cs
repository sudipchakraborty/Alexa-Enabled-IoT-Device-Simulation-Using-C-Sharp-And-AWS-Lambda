namespace Alexa_Enabled_IoT_Device_Simulation
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
            this.pb_light = new System.Windows.Forms.PictureBox();
            this.txt_command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_night_lamp = new System.Windows.Forms.PictureBox();
            this.pb_smart_bulb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_night_lamp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fan_status = new System.Windows.Forms.TextBox();
            this.txt_fan_speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_night_lamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smart_bulb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_light
            // 
            this.pb_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_light.Location = new System.Drawing.Point(79, 81);
            this.pb_light.Name = "pb_light";
            this.pb_light.Size = new System.Drawing.Size(87, 87);
            this.pb_light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_light.TabIndex = 0;
            this.pb_light.TabStop = false;
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(79, 242);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(238, 20);
            this.txt_command.TabIndex = 1;
            this.txt_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_command_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alexa Enabled Virtual IoT Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command Input";
            // 
            // pb_night_lamp
            // 
            this.pb_night_lamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_night_lamp.Location = new System.Drawing.Point(195, 81);
            this.pb_night_lamp.Name = "pb_night_lamp";
            this.pb_night_lamp.Size = new System.Drawing.Size(87, 87);
            this.pb_night_lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_night_lamp.TabIndex = 0;
            this.pb_night_lamp.TabStop = false;
            // 
            // pb_smart_bulb
            // 
            this.pb_smart_bulb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_smart_bulb.Location = new System.Drawing.Point(308, 81);
            this.pb_smart_bulb.Name = "pb_smart_bulb";
            this.pb_smart_bulb.Size = new System.Drawing.Size(80, 87);
            this.pb_smart_bulb.TabIndex = 0;
            this.pb_smart_bulb.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LIGHT";
            // 
            // lbl_night_lamp
            // 
            this.lbl_night_lamp.AutoSize = true;
            this.lbl_night_lamp.ForeColor = System.Drawing.Color.White;
            this.lbl_night_lamp.Location = new System.Drawing.Point(209, 171);
            this.lbl_night_lamp.Name = "lbl_night_lamp";
            this.lbl_night_lamp.Size = new System.Drawing.Size(73, 13);
            this.lbl_night_lamp.TabIndex = 4;
            this.lbl_night_lamp.Text = "NIGHT LAMP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Smart Bulb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(452, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FAN";
            // 
            // txt_fan_status
            // 
            this.txt_fan_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fan_status.Location = new System.Drawing.Point(416, 137);
            this.txt_fan_status.Name = "txt_fan_status";
            this.txt_fan_status.Size = new System.Drawing.Size(100, 31);
            this.txt_fan_status.TabIndex = 5;
            this.txt_fan_status.Text = "STOP";
            // 
            // txt_fan_speed
            // 
            this.txt_fan_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fan_speed.Location = new System.Drawing.Point(416, 81);
            this.txt_fan_speed.Name = "txt_fan_speed";
            this.txt_fan_speed.Size = new System.Drawing.Size(100, 31);
            this.txt_fan_speed.TabIndex = 5;
            this.txt_fan_speed.Text = "50%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(441, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SPEED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(441, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "STATUS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(574, 281);
            this.Controls.Add(this.txt_fan_speed);
            this.Controls.Add(this.txt_fan_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_night_lamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.pb_smart_bulb);
            this.Controls.Add(this.pb_night_lamp);
            this.Controls.Add(this.pb_light);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alexa Enabled Virtual IoT Device V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pb_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_night_lamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_smart_bulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_light;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_night_lamp;
        private System.Windows.Forms.PictureBox pb_smart_bulb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_night_lamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fan_status;
        private System.Windows.Forms.TextBox txt_fan_speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

