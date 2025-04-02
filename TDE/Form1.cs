using System.Drawing.Text;
using System.Windows.Forms;

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

        // Fun��o que atualiza a cor do painel com base nos valores de RED, GREEN e BLUE
        private void AtualizarCorDoPainel()
        {
            // Atualiza a cor de fundo do painel com os valores de RGB
            panelColor.BackColor = Color.FromArgb(trackBarRED.Value, trackBarGREEN.Value, trackBarBLUE.Value);
        }

        private void buttonCONVERTER_Click(object sender, EventArgs e)
        {
            // Obt�m os valores RGB dos controles

            float r = (float)numericUpDownRED.Value;
            float g = (float)numericUpDownGREEN.Value;
            float b = (float)numericUpDownBLUE.Value;

            float C, M, Y, K;

            RGBtoRGBNormal(r, g, b);
            RGBToHSV(r, g, b);
            RGBtoCMYK(r, g, b, out C, out M, out Y, out K); 
            RGBtoEscalaCinza(r, g, b);
        }

        private void RGBtoCMYK(float r, float g, float b, out float C, out float M, out float Y, out float K)
        {
            // Garantir que os valores RGB estejam no intervalo [0, 1]
            r /= 255f;
            g /= 255f;
            b /= 255f;

            // Calcular K (preto)
            K = 1 - Math.Max(r, Math.Max(g, b));

            if (K == 1)
            {
                // Se K for igual a 1 (preto), ent�o C, M e Y s�o zero
                C = 0;
                M = 0;
                Y = 0;
            }
            else
            {
                // Calcular os valores de C, M e Y corretamente
                C = (1 - r - K) / (1 - K);
                M = (1 - g - K) / (1 - K);
                Y = (1 - b - K) / (1 - K);
            }

            // Converter os valores de CMYK para porcentagem
            C *= 100;
            M *= 100;
            Y *= 100;
            K *= 100;

            // Exibe os valores no textBox com precis�o
            textBoxCMYK.Text = Convert.ToInt32(C).ToString() + "% " + Convert.ToInt32(M).ToString() + "% " + Convert.ToInt32(Y).ToString() + "% " + Convert.ToInt32(K).ToString() + "% ";
        }


        private void CMYKToRGB(float C, float M, float Y, float K)
        {
            // Garantir que os valores CMYK estejam entre 0 e 1
            C = Math.Clamp(C, 0f, 1f);
            M = Math.Clamp(M, 0f, 1f);
            Y = Math.Clamp(Y, 0f, 1f);
            K = Math.Clamp(K, 0f, 1f);

            // Calcula os valores de RGB
            float R = (1 - C) * (1 - K) * 255;
            float G = (1 - M) * (1 - K) * 255;
            float B = (1 - Y) * (1 - K) * 255;

            // Garantir que os valores RGB estejam entre 0 e 255
            R = Math.Clamp(R, 0f, 255f);
            G = Math.Clamp(G, 0f, 255f);
            B = Math.Clamp(B, 0f, 255f);

            // Arredondar os valores de RGB
            int rInt = (int)Math.Round(R);
            int gInt = (int)Math.Round(G);
            int bInt = (int)Math.Round(B);

            // Exibir os valores no TextBox
            textBoxCMYKtoRGB.Text = $"R: {rInt} G: {gInt} B: {bInt}";

            // Atualizar a cor do painel na interface
            panel3.BackColor = Color.FromArgb(rInt, gInt, bInt);
        }

        private void RGBToHSV(float r, float g, float b)
        {
            // Normaliza os valores RGB para o intervalo [0, 1]
            r /= 255f;
            g /= 255f;
            b /= 255f;

            // Calcula MAX, MIN e a diferen�a entre eles (delta)
            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));
            float delta = max - min;

            // Inicializa as vari�veis de H, S e V
            float h = 0;
            float s = (max == 0) ? 0 : (delta / max); // Se max == 0, S deve ser 0
            float v = max; // V � simplesmente o valor m�ximo normalizado

            // C�lculo de H baseado na f�rmula da imagem
            if (delta > 0)
            {
                if (max == r)
                {
                    h = 60 * ((g - b) / delta);
                    if (g < b) h += 360; // Ajuste para valores negativos
                }
                else if (max == g)
                {
                    h = 60 * ((b - r) / delta) + 120;
                }
                else if (max == b)
                {
                    h = 60 * ((r - g) / delta) + 240;
                }
            }

            // Corrige o valor de H se ele for negativo
            if (h < 0) h += 360;

            // Caso a cor seja entre duas cores iguais
            if (r == g && g == b)
            {
                h = 60; // O valor correto � 60� para uma cor amarela (com RGB igual para r e g)
            }

            // Converte S e V para porcentagem
            s *= 100;
            v *= 100;

            // Exibe os valores no textBoxHSV
            textBoxHSV.Text = h.ToString("0") + "�, " + s.ToString("0") + "%, " + v.ToString("0") + "%";
        }


        private void HSVToRGB(float h, float s, float v)
        {
            // Converter S e V de porcentagem (0-100) para escala de 0 a 1
            s /= 100f;
            v /= 100f;

            // Calcular C, X e m
            float c = v * s;
            float x = c * (1 - Math.Abs((h / 60f) % 2 - 1));
            float m = v - c;

            // Vari�veis tempor�rias para R', G', B'
            float rPrime = 0, gPrime = 0, bPrime = 0;

            // Determinar R', G', B' baseado no valor de H
            if (h >= 0 && h < 60)
            {
                rPrime = c;
                gPrime = x;
                bPrime = 0;
            }
            else if (h >= 60 && h < 120)
            {
                rPrime = x;
                gPrime = c;
                bPrime = 0;
            }
            else if (h >= 120 && h < 180)
            {
                rPrime = 0;
                gPrime = c;
                bPrime = x;
            }
            else if (h >= 180 && h < 240)
            {
                rPrime = 0;
                gPrime = x;
                bPrime = c;
            }
            else if (h >= 240 && h < 300)
            {
                rPrime = x;
                gPrime = 0;
                bPrime = c;
            }
            else if (h >= 300 && h < 360)
            {
                rPrime = c;
                gPrime = 0;
                bPrime = x;
            }

            // Converter para escala de 0 a 255
            int r = (int)((rPrime + m) * 255);
            int g = (int)((gPrime + m) * 255);
            int b = (int)((bPrime + m) * 255);

            // Garantir que os valores fiquem entre 0 e 255
            r = Math.Clamp(r, 0, 255);
            g = Math.Clamp(g, 0, 255);
            b = Math.Clamp(b, 0, 255);

            // Mostrando os valores no TextBox correspondente
            textBoxRGB.Text = $"R: {r}, G: {g}, B: {b}";

            // Atualizando a cor do painel na interface
            panel2.BackColor = Color.FromArgb(r, g, b);
        }

        private void RGBtoRGBNormal(float r, float g, float b)
        {
            // Normalizar os valores RGB dividindo cada componente por 255
            float rNorm = r / 255f;
            float gNorm = g / 255f;
            float bNorm = b / 255f;

            // Exibir os valores normalizados com maior precis�o no textBox
            textBoxRGBNormal.Text = rNorm.ToString ("F2") + " " + gNorm.ToString ("F2") + " " + bNorm.ToString ("F2");
        }

        private void RGBtoEscalaCinza(float r, float g, float b)
        {
            // Calcular o valor de cinza usando a f�rmula de lumin�ncia
            float cinza = (r + g + b) / 3;

            // Arredondar o valor de cinza para o inteiro mais pr�ximo e converter para float
            cinza = (float)Math.Round(cinza);

            // Garantir que o valor de cinza esteja dentro do intervalo de 0 a 255
            cinza = Math.Clamp(cinza, 0f, 255f);

            // Exibir o valor em escala de cinza no textBox
            textBoxEscalaCinza.Text = cinza.ToString() + " " + cinza.ToString() + " " + cinza.ToString() + " ";
        }

        private void button2Converter_Click(object sender, EventArgs e)
        {
            // Pegando os valores inseridos nos NumericUpDowns da guia "HSV to RGB"

            float h = (float)numericUpDownH.Value; // Matiz (Hue)
            float s = (float)numericUpDownS.Value / 100f; // Satura��o (convertida para 0 a 1)
            float v = (float)numericUpDownV.Value / 100f; // Brilho (convertido para 0 a 1)

            // Chamando a fun��o que converte HSV para RGB
            HSVToRGB(h, s, v);

        }

        private void AtualizarCorDoPainelHSV()
        {
            // Obt�m os valores de H, S e V
            float h = trackBarH.Value;  // Hue (0 - 360)
            float s = trackBarS.Value;  // Saturation (0 - 100)
            float v = trackBarV.Value;  // Value (0 - 100)

            // Chama a fun��o que converte HSV para RGB
            HSVToRGB(h, s, v);
        }

        private void trackBarH_Scroll(object sender, EventArgs e)
        {
            // Sincroniza o valor da TrackBar H com o Numeric
            numericUpDownH.Value = trackBarH.Value;
            AtualizarCorDoPainelHSV(); // Atualiza a cor do painel HSV to RGB
        }
        private void numericUpDownH_ValueChanged(object sender, EventArgs e)
        {
            // Sincroniza o valor do Numeric com a TrackBar
            trackBarH.Value = (int)numericUpDownH.Value;
            AtualizarCorDoPainelHSV(); // Atualiza cor do painel
        }
        private void trackBarS_Scroll(object sender, EventArgs e)
        {
            // Sincroniza o valor da TrackBar H com o Numeric
            numericUpDownS.Value = trackBarS.Value;
            AtualizarCorDoPainelHSV(); // Atualiza a cor do painel HSV to RGB
        }
        private void numericUpDownS_ValueChanged(object sender, EventArgs e)
        {

            // Sincroniza o valor do Numeric com a TrackBar
            trackBarS.Value = (int)numericUpDownS.Value;
            AtualizarCorDoPainelHSV(); // Atualiza cor do painel
        }
        private void trackBarV_Scroll(object sender, EventArgs e)
        {

            numericUpDownV.Value = trackBarV.Value;   // Sincroniza o valor da TrackBar H com o Numeric
            AtualizarCorDoPainelHSV(); // Atualiza a cor do painel HSV to RGB
        }
        private void numericUpDownV_ValueChanged(object sender, EventArgs e)
        {

            // Sincroniza o valor do Numeric com a TrackBar
            trackBarV.Value = (int)numericUpDownV.Value;
            AtualizarCorDoPainelHSV(); // Atualiza cor do painel
        }
        private void button3Converter_Click(object sender, EventArgs e)
        {
            // Pegando os valores de CMYK dos NumericUpDowns
            float C = (float)numericUpDownC.Value / 100f;  // Converte de porcentagem para valor entre 0 e 1
            float M = (float)numericUpDownM.Value / 100f;
            float Y = (float)numericUpDownY.Value / 100f;
            float K = (float)numericUpDownK.Value / 100f;

            // Chama a fun��o CMYKToRGB para realizar a convers�o
            CMYKToRGB(C, M, Y, K);
        }

        private void AtualizarCorDoPainelCMYK()
        {
            // Obt�m os valores de CMYK dos NumericUpDowns
            float C = (float)numericUpDownC.Value / 100f; // Converte de porcentagem para valor entre 0 e 1
            float M = (float)numericUpDownM.Value / 100f;
            float Y = (float)numericUpDownY.Value / 100f;
            float K = (float)numericUpDownK.Value / 100f;

            // Converte CMYK para RGB
            float r = (1 - C) * (1 - K) * 255;
            float g = (1 - M) * (1 - K) * 255;
            float b = (1 - Y) * (1 - K) * 255;

            // Garantir que os valores RGB estejam entre 0 e 255
            r = Math.Clamp(r, 0f, 255f);
            g = Math.Clamp(g, 0f, 255f);
            b = Math.Clamp(b, 0f, 255f);

            // Converte os valores RGB para inteiros
            int rInt = (int)r;
            int gInt = (int)g;
            int bInt = (int)b;

            // Exibe os valores RGB no painel 3
            panel3.BackColor = Color.FromArgb(rInt, gInt, bInt);
        }
        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            numericUpDownC.Value = trackBarC.Value;  // Sincroniza o valor do TrackBar com o NumericUpDown
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void trackBarM_Scroll(object sender, EventArgs e)
        {
            numericUpDownM.Value = trackBarM.Value;  // Sincroniza o valor do TrackBar com o NumericUpDown
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            numericUpDownY.Value = trackBarY.Value;  // Sincroniza o valor do TrackBar com o NumericUpDown
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void numericUpDownK_ValueChanged(object sender, EventArgs e)
        {
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }

        private void trackBarK_Scroll(object sender, EventArgs e)
        {
            numericUpDownK.Value = trackBarK.Value;  // Sincroniza o valor do TrackBar com o NumericUpDown
            AtualizarCorDoPainelCMYK();  // Atualiza a cor do painel com os valores de CMYK
        }


    }
}
 

