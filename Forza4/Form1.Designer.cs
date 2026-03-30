namespace Forza4
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
            dgvCampo = new DataGridView();
            btnNuovaPartita = new Button();
            lblTurno = new Label();
            lblTitolo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCampo).BeginInit();
            SuspendLayout();
            // 
            // dgvCampo
            // 
            dgvCampo.AllowUserToResizeColumns = false;
            dgvCampo.AllowUserToResizeRows = false;
            dgvCampo.BackgroundColor = SystemColors.ControlLight;
            dgvCampo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCampo.GridColor = SystemColors.ControlDark;
            dgvCampo.Location = new Point(349, 266);
            dgvCampo.Name = "dgvCampo";
            dgvCampo.ReadOnly = true;
            dgvCampo.RowHeadersWidth = 82;
            dgvCampo.Size = new Size(808, 690);
            dgvCampo.TabIndex = 0;
            dgvCampo.CellContentClick += dgvCampo_CellClick;
            // 
            // btnNuovaPartita
            // 
            btnNuovaPartita.BackColor = Color.Red;
            btnNuovaPartita.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuovaPartita.Location = new Point(1211, 166);
            btnNuovaPartita.Name = "btnNuovaPartita";
            btnNuovaPartita.Size = new Size(263, 87);
            btnNuovaPartita.TabIndex = 2;
            btnNuovaPartita.Text = "Nuova Partita";
            btnNuovaPartita.UseVisualStyleBackColor = false;
            btnNuovaPartita.Click += btnNuovaPartita_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurno.Location = new Point(701, 166);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(103, 45);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe Print", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitolo.Location = new Point(605, 28);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(295, 112);
            lblTitolo.TabIndex = 4;
            lblTitolo.Text = "Forza 4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1506, 1046);
            Controls.Add(lblTitolo);
            Controls.Add(lblTurno);
            Controls.Add(btnNuovaPartita);
            Controls.Add(dgvCampo);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCampo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCampo;
        private Button btnNuovaPartita;
        private Label lblTurno;
        private Label lblTitolo;
    }
}
