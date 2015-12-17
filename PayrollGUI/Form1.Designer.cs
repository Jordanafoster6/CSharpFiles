namespace PayrollGUI
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.sscBox = new System.Windows.Forms.TextBox();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(52, 45);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(242, 22);
            this.nameBox.TabIndex = 0;
            // 
            // sscBox
            // 
            this.sscBox.Location = new System.Drawing.Point(52, 94);
            this.sscBox.Name = "sscBox";
            this.sscBox.Size = new System.Drawing.Size(242, 22);
            this.sscBox.TabIndex = 1;
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(52, 146);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(100, 22);
            this.rateBox.TabIndex = 2;
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(242, 146);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(52, 22);
            this.hoursBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Social Security Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hourly Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours Worked:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click To Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(52, 267);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(239, 17);
            this.lblName.TabIndex = 9;
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(58, 284);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(0, 17);
            this.lblSsn.TabIndex = 10;
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(58, 319);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(0, 17);
            this.lblGross.TabIndex = 11;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.Location = new System.Drawing.Point(58, 347);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(0, 17);
            this.lblFed.TabIndex = 12;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(58, 377);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 17);
            this.lblState.TabIndex = 13;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(58, 409);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(0, 17);
            this.lblNet.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 452);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.sscBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox sscBox;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNet;
    }
}

