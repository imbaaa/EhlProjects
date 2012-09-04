namespace SimpleSNMP
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
            this.ktbResult = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnGetInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.ktbIPAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kcbCommunity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.krypTxtBxRepeaters = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.krbSNMP = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbTest = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kbtnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcbMethod = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonWrapLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.krypTxtBxOid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kcbCommunity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // ktbResult
            // 
            this.ktbResult.Location = new System.Drawing.Point(1, 70);
            this.ktbResult.Multiline = true;
            this.ktbResult.Name = "ktbResult";
            this.ktbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ktbResult.Size = new System.Drawing.Size(566, 310);
            this.ktbResult.TabIndex = 5;
            // 
            // kbtnGetInfo
            // 
            this.kbtnGetInfo.Location = new System.Drawing.Point(442, 10);
            this.kbtnGetInfo.Name = "kbtnGetInfo";
            this.kbtnGetInfo.Size = new System.Drawing.Size(111, 42);
            this.kbtnGetInfo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetInfo.TabIndex = 6;
            this.kbtnGetInfo.Values.Text = "Get Info";
            this.kbtnGetInfo.Click += new System.EventHandler(this.kbtnGetInfo_Click);
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(31, 37);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(56, 15);
            this.kryptonWrapLabel1.Text = "Object ID";
            // 
            // ktbIPAddress
            // 
            this.ktbIPAddress.Location = new System.Drawing.Point(93, 10);
            this.ktbIPAddress.Name = "ktbIPAddress";
            this.ktbIPAddress.Size = new System.Drawing.Size(343, 20);
            this.ktbIPAddress.TabIndex = 0;
            this.ktbIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktbIPAddress_KeyDown);
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(25, 14);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(62, 15);
            this.kryptonWrapLabel2.Text = "IP Address";
            // 
            // kryptonWrapLabel3
            // 
            this.kryptonWrapLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel3.Location = new System.Drawing.Point(16, 69);
            this.kryptonWrapLabel3.Name = "kryptonWrapLabel3";
            this.kryptonWrapLabel3.Size = new System.Drawing.Size(71, 15);
            this.kryptonWrapLabel3.Text = "Community";
            // 
            // kcbCommunity
            // 
            this.kcbCommunity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbCommunity.DropDownWidth = 109;
            this.kcbCommunity.Items.AddRange(new object[] {
            "private",
            "public"});
            this.kcbCommunity.Location = new System.Drawing.Point(93, 67);
            this.kcbCommunity.Name = "kcbCommunity";
            this.kcbCommunity.Size = new System.Drawing.Size(109, 21);
            this.kcbCommunity.TabIndex = 3;
            this.kcbCommunity.Text = "public";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(1, 1);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.krypTxtBxRepeaters);
            this.kryptonGroupBox1.Panel.Controls.Add(this.krbSNMP);
            this.kryptonGroupBox1.Panel.Controls.Add(this.krbTest);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnRemove);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnAdd);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGetInfo);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kcbMethod);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kcbCommunity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.krypTxtBxOid);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktbIPAddress);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(566, 66);
            this.kryptonGroupBox1.TabIndex = 7;
            // 
            // krypTxtBxRepeaters
            // 
            this.krypTxtBxRepeaters.Location = new System.Drawing.Point(224, 64);
            this.krypTxtBxRepeaters.Name = "krypTxtBxRepeaters";
            this.krypTxtBxRepeaters.Size = new System.Drawing.Size(49, 20);
            this.krypTxtBxRepeaters.TabIndex = 15;
            this.krypTxtBxRepeaters.Text = "100";
            // 
            // krbSNMP
            // 
            this.krbSNMP.Checked = true;
            this.krbSNMP.Location = new System.Drawing.Point(480, 67);
            this.krbSNMP.Name = "krbSNMP";
            this.krbSNMP.Size = new System.Drawing.Size(56, 20);
            this.krbSNMP.TabIndex = 10;
            this.krbSNMP.Values.Text = "SNMP";
            // 
            // krbTest
            // 
            this.krbTest.Location = new System.Drawing.Point(427, 67);
            this.krbTest.Name = "krbTest";
            this.krbTest.Size = new System.Drawing.Size(45, 20);
            this.krbTest.TabIndex = 10;
            this.krbTest.Values.Text = "Test";
            // 
            // kbtnRemove
            // 
            this.kbtnRemove.Location = new System.Drawing.Point(337, 62);
            this.kbtnRemove.Name = "kbtnRemove";
            this.kbtnRemove.Size = new System.Drawing.Size(65, 25);
            this.kbtnRemove.TabIndex = 6;
            this.kbtnRemove.Values.Text = "Remove";
            // 
            // kbtnAdd
            // 
            this.kbtnAdd.Location = new System.Drawing.Point(279, 62);
            this.kbtnAdd.Name = "kbtnAdd";
            this.kbtnAdd.Size = new System.Drawing.Size(52, 25);
            this.kbtnAdd.TabIndex = 6;
            this.kbtnAdd.Values.Text = "Add";
            // 
            // kcbMethod
            // 
            this.kcbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbMethod.DropDownWidth = 121;
            this.kcbMethod.Items.AddRange(new object[] {
            "Get NEXT",
            "Get BULK",
            "GET",
            "Walk"});
            this.kcbMethod.Location = new System.Drawing.Point(347, 33);
            this.kcbMethod.Name = "kcbMethod";
            this.kcbMethod.Size = new System.Drawing.Size(89, 21);
            this.kcbMethod.TabIndex = 4;
            // 
            // kryptonWrapLabel4
            // 
            this.kryptonWrapLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel4.Location = new System.Drawing.Point(292, 37);
            this.kryptonWrapLabel4.Name = "kryptonWrapLabel4";
            this.kryptonWrapLabel4.Size = new System.Drawing.Size(49, 15);
            this.kryptonWrapLabel4.Text = "Method";
            // 
            // krypTxtBxOid
            // 
            this.krypTxtBxOid.Location = new System.Drawing.Point(93, 34);
            this.krypTxtBxOid.Name = "krypTxtBxOid";
            this.krypTxtBxOid.Size = new System.Drawing.Size(183, 20);
            this.krypTxtBxOid.TabIndex = 0;
            this.krypTxtBxOid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktbIPAddress_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 381);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.ktbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SNMP Query";
            ((System.ComponentModel.ISupportInitialize)(this.kcbCommunity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcbMethod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbResult;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGetInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbIPAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbCommunity;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbMethod;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton krbSNMP;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton krbTest;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox krypTxtBxRepeaters;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox krypTxtBxOid;
    }
}

