namespace TDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarRED_Scroll(object sender, EventArgs e)
        {
            // Sincroniza o valor do TrackBar com o NumericUpDown
            numericUpDownRED.Value = trackBarRED.Value;
            AtualizarCorDoPainel();  // Atualiza a cor do painel
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Sincroniza o valor do NumericUpDown com o TrackBar
            trackBarRED.Value = (int)numericUpDownRED.Value;
            AtualizarCorDoPainel();  // Atualiza a cor do painel
        }

        private void trackBarBLUE_Scroll(object sender, EventArgs e)
        {
            // Sincroniza o valor do TrackBar com o NumericUpDown
            numericUpDownBLUE.Value = trackBarBLUE.Value;
            AtualizarCorDoPainel();  // Atualiza a cor do painel
        }

        private void NumericUpDownBLUE_ValueChanged(object sender, EventArgs e)
        {
            // Sincroniza o valor do NumericUpDown com o TrackBar
            trackBarBLUE.Value = (int)numericUpDownBLUE.Value;
            AtualizarCorDoPainel();  // Atualiza a cor do painel
        }

        private void trackBarGREEN_Scroll(object sender, EventArgs e)
        {
            // Sincroniza o valor do TrackBar com o NumericUpDown
            numericUpDownGREEN.Value = trackBarGREEN.Value;
            AtualizarCorDoPainel();  // Atualiza a cor do painel
        }

        private void NumericUpDownGREEN_ValueChanged(object sender, EventArgs e)
        {
            // Sincroniza o valor do NumericUpDown com o TrackBar
            trackBarGREEN.Value = (int)numericUpDownGREEN.Value;
            AtualizarCorDoPainel();  // Atualiza a cor do painel
        }

        // Função que atualiza a cor do painel com base nos valores de RED, GREEN e BLUE
        private void AtualizarCorDoPainel()
        {
            // Atualiza a cor de fundo do painel com os valores de RGB
            panelColor.BackColor = Color.FromArgb(trackBarRED.Value, trackBarGREEN.Value, trackBarBLUE.Value);
        }
    }
}


