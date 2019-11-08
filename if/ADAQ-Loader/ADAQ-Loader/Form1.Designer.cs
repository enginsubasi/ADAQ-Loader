namespace ADAQ_Loader {
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
            this.labelLCP = new System.Windows.Forms.Label();
            this.serialPortLoader = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonEraseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLCP
            // 
            this.labelLCP.AutoSize = true;
            this.labelLCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLCP.Location = new System.Drawing.Point(13, 13);
            this.labelLCP.Name = "labelLCP";
            this.labelLCP.Size = new System.Drawing.Size(287, 26);
            this.labelLCP.TabIndex = 0;
            this.labelLCP.Text = "ADAQ-Loader Control Panel";
            // 
            // serialPortLoader
            // 
            this.serialPortLoader.BaudRate = 115200;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(146, 65);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonEraseApp
            // 
            this.buttonEraseApp.Location = new System.Drawing.Point(18, 93);
            this.buttonEraseApp.Name = "buttonEraseApp";
            this.buttonEraseApp.Size = new System.Drawing.Size(203, 23);
            this.buttonEraseApp.TabIndex = 3;
            this.buttonEraseApp.Text = "Erase Application";
            this.buttonEraseApp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEraseApp);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelLCP);
            this.Name = "Form1";
            this.Text = "ADAQ-Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLCP;
        private System.IO.Ports.SerialPort serialPortLoader;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonEraseApp;
    }
}

