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

        private void buttonCONVERTER_Click(object sender, EventArgs e)
        {
            float r;
            float g;
            float b;

            r = (float)numericUpDownRED.Value;
            g = (float)numericUpDownGREEN.Value;
            b = (float)numericUpDownBLUE.Value;

            RGBtoCMYK(r, g, b);
           // RGBtoHSV(r, g, b);
           // RGBtoEscalaCinza(r, g, b);
           // RGBtoRGBNormal(r, g, b);

        }
        private void RGBtoCMYK(float r, float g, float b)
        {
            r = r / 255f;
            g = g / 255f;
            b = b / 255f;

            // Calcular o valor K = black
            float k = 1 - Math.Max(r, Math.Max(g, b));

            // Caso o K seja 1, então C,M  Y são 0
            if (k == 1)
            {
                textBoxCMYK.Text = "0%, 0%, 0%, " + k.ToString();
            }

            // fomrmula para os valores c,m,y
   
            float c = (1 - r - k) / (1 - k);
            float m = (1 - g - k) / (1 - k);
            float y = (1 - b - k) / (1 - k);

            // mostra os valores no textBox

            textBoxCMYK.Text = c.ToString() + "%, " + m.ToString() + "%, " + y.ToString() + "%, " + k.ToString() + "%"; 

        }
        private void CMYKToRGB(float C, float M, float Y, float K)
        {
            // Garantir que os valores de C, M, Y, K estejam entre 0 e 1
            C = Math.Clamp(C, 0f, 1f);
            M = Math.Clamp(M, 0f, 1f);
            Y = Math.Clamp(Y, 0f, 1f);
            K = Math.Clamp(K, 0f, 1f);

            // Calcula os valores de RGB
            float R = (float)((1 - C) * (1 - K) * 255);
            float G = (float)((1 - M) * (1 - K) * 255);
            float B = (float)((1 - Y) * (1 - K) * 255);

            // Garantir que os valores de RGB estejam entre 0 e 255
            R = Math.Clamp(R, 0, 255);
            G = Math.Clamp(G, 0, 255);
            B = Math.Clamp(B, 0, 255);

        }

        private void RGBtoHSV()
        {


        }
        private void RGBtoEscalaCinza()
        {


        }
        private void RGBtoRGBNormal()
        {


        }



    }
}


