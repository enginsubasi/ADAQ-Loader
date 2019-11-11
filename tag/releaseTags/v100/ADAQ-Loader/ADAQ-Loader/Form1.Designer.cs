namespace ADAQ_Loader {
    partial class FormADAQLoaderPanel {
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
            this.comboBoxSerialPortList = new System.Windows.Forms.ComboBox();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.buttonJTA = new System.Windows.Forms.Button();
            this.buttonEnterBtl = new System.Windows.Forms.Button();
            this.buttonBtlFlagClear = new System.Windows.Forms.Button();
            this.timer100ms = new System.Windows.Forms.Timer(this.components);
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonRepo = new System.Windows.Forms.Button();
            this.buttonWho = new System.Windows.Forms.Button();
            this.labelVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLCP
            // 
            this.labelLCP.AutoSize = true;
            this.labelLCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLCP.Location = new System.Drawing.Point(13, 13);
            this.labelLCP.Name = "labelLCP";
            this.labelLCP.Size = new System.Drawing.Size(211, 26);
            this.labelLCP.TabIndex = 0;
            this.labelLCP.Text = "ADAQ-Loader Panel";
            // 
            // serialPortLoader
            // 
            this.serialPortLoader.BaudRate = 115200;
            // 
            // comboBoxSerialPortList
            // 
            this.comboBoxSerialPortList.FormattingEnabled = true;
            this.comboBoxSerialPortList.Location = new System.Drawing.Point(18, 65);
            this.comboBoxSerialPortList.Name = "comboBoxSerialPortList";
            this.comboBoxSerialPortList.Size = new System.Drawing.Size(203, 21);
            this.comboBoxSerialPortList.TabIndex = 1;
            this.comboBoxSerialPortList.Text = "Select Com Port...";
            this.comboBoxSerialPortList.TextChanged += new System.EventHandler(this.comboBoxSerialPortList_TextChanged);
            // 
            // buttonProgram
            // 
            this.buttonProgram.Location = new System.Drawing.Point(18, 92);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(203, 23);
            this.buttonProgram.TabIndex = 5;
            this.buttonProgram.Text = "Program";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(18, 122);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(203, 23);
            this.progressBarLoad.TabIndex = 6;
            // 
            // buttonJTA
            // 
            this.buttonJTA.Location = new System.Drawing.Point(18, 152);
            this.buttonJTA.Name = "buttonJTA";
            this.buttonJTA.Size = new System.Drawing.Size(203, 23);
            this.buttonJTA.TabIndex = 7;
            this.buttonJTA.Text = "Jump to application";
            this.buttonJTA.UseVisualStyleBackColor = true;
            this.buttonJTA.Click += new System.EventHandler(this.buttonJTA_Click);
            // 
            // buttonEnterBtl
            // 
            this.buttonEnterBtl.Location = new System.Drawing.Point(18, 210);
            this.buttonEnterBtl.Name = "buttonEnterBtl";
            this.buttonEnterBtl.Size = new System.Drawing.Size(203, 23);
            this.buttonEnterBtl.TabIndex = 8;
            this.buttonEnterBtl.Text = "Enter bootloader mode";
            this.buttonEnterBtl.UseVisualStyleBackColor = true;
            this.buttonEnterBtl.Click += new System.EventHandler(this.buttonEnterBtl_Click);
            // 
            // buttonBtlFlagClear
            // 
            this.buttonBtlFlagClear.Location = new System.Drawing.Point(18, 181);
            this.buttonBtlFlagClear.Name = "buttonBtlFlagClear";
            this.buttonBtlFlagClear.Size = new System.Drawing.Size(203, 23);
            this.buttonBtlFlagClear.TabIndex = 9;
            this.buttonBtlFlagClear.Text = "Bootloader flag clear";
            this.buttonBtlFlagClear.UseVisualStyleBackColor = true;
            this.buttonBtlFlagClear.Click += new System.EventHandler(this.buttonBtlFlagClear_Click);
            // 
            // timer100ms
            // 
            this.timer100ms.Enabled = true;
            this.timer100ms.Tick += new System.EventHandler(this.timer100ms_Tick);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(18, 239);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(98, 23);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(123, 239);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(98, 23);
            this.buttonVer.TabIndex = 11;
            this.buttonVer.Text = "Version";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonRepo
            // 
            this.buttonRepo.Location = new System.Drawing.Point(123, 268);
            this.buttonRepo.Name = "buttonRepo";
            this.buttonRepo.Size = new System.Drawing.Size(98, 23);
            this.buttonRepo.TabIndex = 12;
            this.buttonRepo.Text = "Repo";
            this.buttonRepo.UseVisualStyleBackColor = true;
            this.buttonRepo.Click += new System.EventHandler(this.buttonRepo_Click);
            // 
            // buttonWho
            // 
            this.buttonWho.Location = new System.Drawing.Point(18, 268);
            this.buttonWho.Name = "buttonWho";
            this.buttonWho.Size = new System.Drawing.Size(98, 23);
            this.buttonWho.TabIndex = 13;
            this.buttonWho.Text = "Who";
            this.buttonWho.UseVisualStyleBackColor = true;
            this.buttonWho.Click += new System.EventHandler(this.buttonWho_Click);
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(181, 39);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(40, 13);
            this.labelVer.TabIndex = 14;
            this.labelVer.Text = "v.1.0.0";
            // 
            // FormADAQLoaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 303);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.buttonWho);
            this.Controls.Add(this.buttonRepo);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonBtlFlagClear);
            this.Controls.Add(this.buttonEnterBtl);
            this.Controls.Add(this.buttonJTA);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.buttonProgram);
            this.Controls.Add(this.comboBoxSerialPortList);
            this.Controls.Add(this.labelLCP);
            this.MaximumSize = new System.Drawing.Size(258, 342);
            this.MinimumSize = new System.Drawing.Size(258, 342);
            this.Name = "FormADAQLoaderPanel";
            this.Text = "ADAQ-Loader Panel";
            this.Load += new System.EventHandler(this.FormADAQLoaderPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLCP;
        private System.IO.Ports.SerialPort serialPortLoader;
        private System.Windows.Forms.ComboBox comboBoxSerialPortList;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.Button buttonJTA;
        private System.Windows.Forms.Button buttonEnterBtl;
        private System.Windows.Forms.Button buttonBtlFlagClear;
        private System.Windows.Forms.Timer timer100ms;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonRepo;
        private System.Windows.Forms.Button buttonWho;
        private System.Windows.Forms.Label labelVer;
    }
}

