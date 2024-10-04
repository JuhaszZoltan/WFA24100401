namespace WFA24100401
{
    partial class FrmIntervallum
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
            nudAlso = new NumericUpDown();
            lblUI01 = new Label();
            btnMegallapit = new Button();
            nudFelso = new NumericUpDown();
            lblUI02 = new Label();
            nudSzam = new NumericUpDown();
            lblUI03 = new Label();
            lblSzoveg = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAlso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFelso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSzam).BeginInit();
            SuspendLayout();
            // 
            // nudAlso
            // 
            nudAlso.Font = new Font("Segoe UI", 20F);
            nudAlso.Increment = new decimal(new int[] { 20, 0, 0, 0 });
            nudAlso.Location = new Point(12, 33);
            nudAlso.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAlso.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nudAlso.Name = "nudAlso";
            nudAlso.Size = new Size(130, 43);
            nudAlso.TabIndex = 0;
            nudAlso.Value = new decimal(new int[] { 20, 0, 0, int.MinValue });
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 12F);
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(81, 21);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "alsó határ:";
            // 
            // btnMegallapit
            // 
            btnMegallapit.Font = new Font("Segoe UI", 20F);
            btnMegallapit.Location = new Point(187, 91);
            btnMegallapit.Name = "btnMegallapit";
            btnMegallapit.Size = new Size(214, 67);
            btnMegallapit.TabIndex = 2;
            btnMegallapit.Text = "megállapít";
            btnMegallapit.UseVisualStyleBackColor = true;
            // 
            // nudFelso
            // 
            nudFelso.Font = new Font("Segoe UI", 20F);
            nudFelso.Increment = new decimal(new int[] { 20, 0, 0, 0 });
            nudFelso.Location = new Point(271, 33);
            nudFelso.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudFelso.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nudFelso.Name = "nudFelso";
            nudFelso.Size = new Size(130, 43);
            nudFelso.TabIndex = 0;
            nudFelso.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 12F);
            lblUI02.Location = new Point(271, 9);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(86, 21);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "felső határ:";
            // 
            // nudSzam
            // 
            nudSzam.Font = new Font("Segoe UI", 20F);
            nudSzam.Increment = new decimal(new int[] { 20, 0, 0, 0 });
            nudSzam.Location = new Point(12, 115);
            nudSzam.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSzam.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nudSzam.Name = "nudSzam";
            nudSzam.Size = new Size(169, 43);
            nudSzam.TabIndex = 0;
            nudSzam.Value = new decimal(new int[] { 26, 0, 0, 0 });
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Font = new Font("Segoe UI", 12F);
            lblUI03.Location = new Point(12, 91);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(132, 21);
            lblUI03.TabIndex = 1;
            lblUI03.Text = "a megadott szám:";
            // 
            // lblSzoveg
            // 
            lblSzoveg.AutoSize = true;
            lblSzoveg.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSzoveg.Location = new Point(12, 180);
            lblSzoveg.Name = "lblSzoveg";
            lblSzoveg.Size = new Size(224, 25);
            lblSzoveg.TabIndex = 3;
            lblSzoveg.Text = "###placeholder-text###";
            // 
            // FrmIntervallum
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 228);
            Controls.Add(lblSzoveg);
            Controls.Add(btnMegallapit);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Controls.Add(nudSzam);
            Controls.Add(nudFelso);
            Controls.Add(nudAlso);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmIntervallum";
            Text = "Intervallum";
            ((System.ComponentModel.ISupportInitialize)nudAlso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFelso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSzam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudAlso;
        private Label lblUI01;
        private Button btnMegallapit;
        private NumericUpDown nudFelso;
        private Label lblUI02;
        private NumericUpDown nudSzam;
        private Label lblUI03;
        private Label lblSzoveg;
    }
}
