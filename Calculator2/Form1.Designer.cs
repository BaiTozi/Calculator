namespace Calculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtEnterNumber = new TextBox();
            txtAverage = new TextBox();
            txtMode = new TextBox();
            txtMedian = new TextBox();
            btnReset = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter number:\r\n";
            // 
            // txtEnterNumber
            // 
            txtEnterNumber.Cursor = Cursors.IBeam;
            txtEnterNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnterNumber.Location = new Point(242, 24);
            txtEnterNumber.Name = "txtEnterNumber";
            txtEnterNumber.Size = new Size(189, 33);
            txtEnterNumber.TabIndex = 4;
            // 
            // txtAverage
            // 
            txtAverage.Cursor = Cursors.IBeam;
            txtAverage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAverage.Location = new Point(21, 134);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(120, 33);
            txtAverage.TabIndex = 5;
            // 
            // txtMode
            // 
            txtMode.Cursor = Cursors.IBeam;
            txtMode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMode.Location = new Point(362, 134);
            txtMode.Name = "txtMode";
            txtMode.Size = new Size(120, 33);
            txtMode.TabIndex = 6;
            // 
            // txtMedian
            // 
            txtMedian.Cursor = Cursors.IBeam;
            txtMedian.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedian.Location = new Point(656, 134);
            txtMedian.Name = "txtMedian";
            txtMedian.Size = new Size(120, 33);
            txtMedian.TabIndex = 7;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(352, 471);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(141, 42);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset\r\n";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 Blk BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 87);
            label2.Name = "label2";
            label2.Size = new Size(96, 44);
            label2.TabIndex = 9;
            label2.Text = "Average\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(387, 87);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 10;
            label3.Text = "Mode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 Blk BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(670, 87);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 11;
            label4.Text = "Median";
            // 
            // BtnCalculate
            // 
            BtnCalculate.BackColor = SystemColors.ButtonFace;
            BtnCalculate.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCalculate.Location = new Point(504, 17);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(155, 42);
            BtnCalculate.TabIndex = 12;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = false;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 525);
            Controls.Add(BtnCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnReset);
            Controls.Add(txtMedian);
            Controls.Add(txtMode);
            Controls.Add(txtAverage);
            Controls.Add(txtEnterNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnterNumber;
        private TextBox txtAverage;
        private TextBox txtMode;
        private TextBox txtMedian;
        private Button btnReset;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnCalculate;
    }
}