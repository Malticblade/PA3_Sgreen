namespace WindowsFormsApplicationTest
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblInput = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.grpConverted = new System.Windows.Forms.GroupBox();
            this.txtbxConvertedWeight = new System.Windows.Forms.TextBox();
            this.txtbxHeightClass = new System.Windows.Forms.TextBox();
            this.txtbxWeightClass = new System.Windows.Forms.TextBox();
            this.txtbxConvertedHeight = new System.Windows.Forms.TextBox();
            this.lblWeightClass = new System.Windows.Forms.Label();
            this.lblConvertedWeight = new System.Windows.Forms.Label();
            this.lblHeightClass = new System.Windows.Forms.Label();
            this.lblConvertedHeight = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.grpConverted.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 15);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input";
            this.lblInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(212, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(118, 250);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 27);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(68, 45);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(60, 15);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height (m)";
            this.lblHeight.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblweight
            // 
            this.lblweight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(68, 74);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(68, 15);
            this.lblweight.TabIndex = 7;
            this.lblweight.Text = "Weight (kg)";
            this.lblweight.Click += new System.EventHandler(this.lblweight_Click);
            // 
            // grpConverted
            // 
            this.grpConverted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConverted.Controls.Add(this.txtbxConvertedWeight);
            this.grpConverted.Controls.Add(this.txtbxHeightClass);
            this.grpConverted.Controls.Add(this.txtbxWeightClass);
            this.grpConverted.Controls.Add(this.txtbxConvertedHeight);
            this.grpConverted.Controls.Add(this.lblWeightClass);
            this.grpConverted.Controls.Add(this.lblConvertedWeight);
            this.grpConverted.Controls.Add(this.lblHeightClass);
            this.grpConverted.Controls.Add(this.lblConvertedHeight);
            this.grpConverted.Location = new System.Drawing.Point(3, 100);
            this.grpConverted.Name = "grpConverted";
            this.grpConverted.Size = new System.Drawing.Size(296, 144);
            this.grpConverted.TabIndex = 10;
            this.grpConverted.TabStop = false;
            this.grpConverted.Text = "Converted";
            this.grpConverted.Enter += new System.EventHandler(this.grpConverted_Enter);
            // 
            // txtbxConvertedWeight
            // 
            this.txtbxConvertedWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxConvertedWeight.Location = new System.Drawing.Point(155, 75);
            this.txtbxConvertedWeight.Name = "txtbxConvertedWeight";
            this.txtbxConvertedWeight.ReadOnly = true;
            this.txtbxConvertedWeight.Size = new System.Drawing.Size(133, 23);
            this.txtbxConvertedWeight.TabIndex = 19;
            this.txtbxConvertedWeight.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtbxHeightClass
            // 
            this.txtbxHeightClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHeightClass.Location = new System.Drawing.Point(155, 46);
            this.txtbxHeightClass.Name = "txtbxHeightClass";
            this.txtbxHeightClass.ReadOnly = true;
            this.txtbxHeightClass.Size = new System.Drawing.Size(133, 23);
            this.txtbxHeightClass.TabIndex = 18;
            this.txtbxHeightClass.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtbxWeightClass
            // 
            this.txtbxWeightClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxWeightClass.Location = new System.Drawing.Point(155, 105);
            this.txtbxWeightClass.Name = "txtbxWeightClass";
            this.txtbxWeightClass.ReadOnly = true;
            this.txtbxWeightClass.Size = new System.Drawing.Size(133, 23);
            this.txtbxWeightClass.TabIndex = 22;
            this.txtbxWeightClass.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtbxConvertedHeight
            // 
            this.txtbxConvertedHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxConvertedHeight.Location = new System.Drawing.Point(155, 17);
            this.txtbxConvertedHeight.Name = "txtbxConvertedHeight";
            this.txtbxConvertedHeight.ReadOnly = true;
            this.txtbxConvertedHeight.Size = new System.Drawing.Size(133, 23);
            this.txtbxConvertedHeight.TabIndex = 17;
            this.txtbxConvertedHeight.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblWeightClass
            // 
            this.lblWeightClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeightClass.AutoSize = true;
            this.lblWeightClass.Location = new System.Drawing.Point(65, 108);
            this.lblWeightClass.Name = "lblWeightClass";
            this.lblWeightClass.Size = new System.Drawing.Size(74, 15);
            this.lblWeightClass.TabIndex = 20;
            this.lblWeightClass.Text = "Weight Class";
            this.lblWeightClass.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblConvertedWeight
            // 
            this.lblConvertedWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConvertedWeight.AutoSize = true;
            this.lblConvertedWeight.Location = new System.Drawing.Point(65, 78);
            this.lblConvertedWeight.Name = "lblConvertedWeight";
            this.lblConvertedWeight.Size = new System.Drawing.Size(68, 15);
            this.lblConvertedWeight.TabIndex = 16;
            this.lblConvertedWeight.Text = "Weight (oz)";
            this.lblConvertedWeight.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblHeightClass
            // 
            this.lblHeightClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeightClass.AutoSize = true;
            this.lblHeightClass.Location = new System.Drawing.Point(65, 49);
            this.lblHeightClass.Name = "lblHeightClass";
            this.lblHeightClass.Size = new System.Drawing.Size(70, 15);
            this.lblHeightClass.TabIndex = 15;
            this.lblHeightClass.Text = "Height Class";
            this.lblHeightClass.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblConvertedHeight
            // 
            this.lblConvertedHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConvertedHeight.AutoSize = true;
            this.lblConvertedHeight.Location = new System.Drawing.Point(65, 19);
            this.lblConvertedHeight.Name = "lblConvertedHeight";
            this.lblConvertedHeight.Size = new System.Drawing.Size(62, 15);
            this.lblConvertedHeight.TabIndex = 14;
            this.lblConvertedHeight.Text = "Height (in)";
            this.lblConvertedHeight.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxName.Location = new System.Drawing.Point(158, 13);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(135, 23);
            this.txtbxName.TabIndex = 11;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHeight.Location = new System.Drawing.Point(158, 42);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.Size = new System.Drawing.Size(135, 23);
            this.txtbxHeight.TabIndex = 12;
            this.txtbxHeight.TextChanged += new System.EventHandler(this.txtbxHeight_TextChanged);
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxWeight.Location = new System.Drawing.Point(158, 71);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(135, 23);
            this.txtbxWeight.TabIndex = 13;
            this.txtbxWeight.TextChanged += new System.EventHandler(this.txtbxWeight_TextChanged);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.txtbxWeight);
            this.Controls.Add(this.txtbxHeight);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.grpConverted);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokémon Stat Converter";
            this.TopMost = true;
            this.grpConverted.ResumeLayout(false);
            this.grpConverted.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.GroupBox grpConverted;
        private System.Windows.Forms.TextBox txtbxHeight;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.TextBox txtbxWeightClass;
        private System.Windows.Forms.Label lblWeightClass;
        private System.Windows.Forms.TextBox txtbxConvertedWeight;
        private System.Windows.Forms.TextBox txtbxHeightClass;
        private System.Windows.Forms.TextBox txtbxConvertedHeight;
        private System.Windows.Forms.Label lblConvertedWeight;
        private System.Windows.Forms.Label lblHeightClass;
        private System.Windows.Forms.Label lblConvertedHeight;
    }
}

