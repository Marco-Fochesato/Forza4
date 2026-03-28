namespace Forza4
{
    public partial class Form1 : Form
    {
        //Dimensione campo
        const int righe = 6;
        const int colonne = 7;

        int[,] griglia = new int[righe, colonne];

        int giocatore = 1; //1 = rosso, 2 = giallo
        bool PartitaFinita = false;

        public Form1()
        {
            InitializeComponent();
            dgvCampo.CellClick += dataGridView1_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImpostaGriglia();
        }

        private void ImpostaGriglia()
        {
            dgvCampo.RowCount = righe;
            dgvCampo.ColumnCount = colonne;

            dgvCampo.RowHeadersVisible = false;
            dgvCampo.ColumnHeadersVisible = false;

            // Seleziona solo una cella alla volta
            dgvCampo.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //Dimensione celle
            for (int c = 0; c < colonne; c++)
            {
                dgvCampo.Columns[c].Width = 110;
            }
            for (int r = 0; r < righe; r++)
            {
                dgvCampo.Rows[r].Height = 110;
            }

            dgvCampo.ClearSelection();
            dgvCampo.Enabled = true;
            griglia = new int[righe, colonne];
            giocatore = 1;
            PartitaFinita = false;
            lblTurno.Text = "Turno: Rosso";
            lblTurno.ForeColor = Color.Red;

            //rimette di colore grigio le celle
            for (int r = 0; r < righe; r++)
                for (int c = 0; c < colonne; c++)
                {
                    dgvCampo.Rows[r].Cells[c].Style.BackColor = Color.LightGray;
                }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (PartitaFinita) return;
            int colonna = e.ColumnIndex;

            int rigaLibera = TrovaRigaLibera(colonna);
            if (rigaLibera == -1)
            {
                MessageBox.Show("Colonna piena! Scegli un'altra colonna.");
                return;
            }

            // Posiziona il disco
            griglia[rigaLibera, colonna] = giocatore;

            if (giocatore == 1)
                dgvCampo.Rows[rigaLibera].Cells[colonna].Style.BackColor = Color.Red;
            else
                dgvCampo.Rows[rigaLibera].Cells[colonna].Style.BackColor = Color.Yellow;

            dgvCampo.ClearSelection();

            if (ControllaVittoria(rigaLibera, colonna))
            {
                PartitaFinita = true;
                string vincitore = giocatore == 1 ? "Rosso" : "Giallo";
                MessageBox.Show($"Ha vinto il giocatore {vincitore}!");
                btnNuovaPartita.Enabled = true;
                dgvCampo.Enabled = false;
                return;
            }

            if (GrigliaPiena())
            {
                PartitaFinita = true;
                MessageBox.Show("pareggio");
            }

            // Cambia turno
            giocatore = (giocatore == 1) ? 2 : 1;

            if (giocatore == 1)
            {
                lblTurno.Text = "Turno: Rosso";
                lblTurno.ForeColor = Color.Red;
            }
            else
            {
                lblTurno.Text = "Turno: Giallo";
                lblTurno.ForeColor = Color.Goldenrod;
            }

        }
        private int TrovaRigaLibera(int colonna)
        {
            for (int r = righe - 1; r >= 0; r--)
                if (griglia[r, colonna] == 0)
                    return r;
            return -1;
        }

        private bool ControllaVittoria(int riga, int colonna)
        {
            int p = giocatore;

            // Le 4 direzioni: orizzontale, verticale, diagonale /, diagonale \
            int[,] direzioni = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } };

            for (int d = 0; d < 4; d++)
            {
                int dr = direzioni[d, 0];
                int dc = direzioni[d, 1];
                int conta = 1;

                // Conta in una direzione
                conta += ContaInDirezione(riga, colonna, dr, dc, p);
                // Conta nella direzione opposta
                conta += ContaInDirezione(riga, colonna, -dr, -dc, p);

                if (conta >= 4)
                    return true;
            }
            return false;
        }

        private int ContaInDirezione(int riga, int colonna, int dr, int dc, int giocatore)
        {
            int conta = 0;
            int r = riga + dr;
            int c = colonna + dc;

            while (r >= 0 && r < righe && c >= 0 && c < colonne && griglia[r, c] == giocatore)
            {
                conta++;
                r += dr;
                c += dc;
            }
            return conta;
        }
        private bool GrigliaPiena()
        {
            for (int c = 0; c < colonne; c++)
                if (griglia[0, c] == 0)
                    return false;
            return true;
        }

        private void btnNuovaPartita_Click(object sender, EventArgs e)
        {
            ImpostaGriglia();
            btnNuovaPartita.Enabled = false;
        }


    }
}
