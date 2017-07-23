namespace protect_health {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbMilliSecond = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnMoreTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(332, 224);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(591, 48);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Bạn đã làm việc liên tục 30 phút";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("Blackoak Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.ForeColor = System.Drawing.Color.White;
            this.lbMinutes.Location = new System.Drawing.Point(403, 426);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(105, 39);
            this.lbMinutes.TabIndex = 1;
            this.lbMinutes.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Blackoak Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(508, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("Blackoak Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.ForeColor = System.Drawing.Color.White;
            this.lbSecond.Location = new System.Drawing.Point(543, 426);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(105, 39);
            this.lbSecond.TabIndex = 3;
            this.lbSecond.Text = "00";
            // 
            // lbMilliSecond
            // 
            this.lbMilliSecond.AutoSize = true;
            this.lbMilliSecond.Font = new System.Drawing.Font("Blackoak Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMilliSecond.ForeColor = System.Drawing.Color.White;
            this.lbMilliSecond.Location = new System.Drawing.Point(683, 426);
            this.lbMilliSecond.Name = "lbMilliSecond";
            this.lbMilliSecond.Size = new System.Drawing.Size(105, 39);
            this.lbMilliSecond.TabIndex = 4;
            this.lbMilliSecond.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Blackoak Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(648, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = ":";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(428, 528);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 43);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok, nghỉ tay";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMoreTime
            // 
            this.btnMoreTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreTime.ForeColor = System.Drawing.Color.White;
            this.btnMoreTime.Location = new System.Drawing.Point(589, 528);
            this.btnMoreTime.Name = "btnMoreTime";
            this.btnMoreTime.Size = new System.Drawing.Size(134, 43);
            this.btnMoreTime.TabIndex = 5;
            this.btnMoreTime.Text = "Thêm 5 phút";
            this.btnMoreTime.UseVisualStyleBackColor = true;
            this.btnMoreTime.Click += new System.EventHandler(this.btnMoreTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãy nghỉ ngơi 5 phút để bảo vệ sức khỏe ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "và tập trung vào công việc hơn";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(986, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1132, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMoreTime);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbMilliSecond);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Protect your health";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbMilliSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnMoreTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

