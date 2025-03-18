namespace TDE
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBoxCMYK = new GroupBox();
            textBox1 = new TextBox();
            buttonCONVERTER = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownBLUE = new NumericUpDown();
            numericUpDownGREEN = new NumericUpDown();
            numericUpDownRED = new NumericUpDown();
            trackBarBLUE = new TrackBar();
            trackBarGREEN = new TrackBar();
            trackBarRED = new TrackBar();
            panelColor = new Panel();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxCMYK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBLUE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGREEN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRED).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBLUE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGREEN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRED).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(662, 576);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBoxCMYK);
            tabPage1.Controls.Add(buttonCONVERTER);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDownBLUE);
            tabPage1.Controls.Add(numericUpDownGREEN);
            tabPage1.Controls.Add(numericUpDownRED);
            tabPage1.Controls.Add(trackBarBLUE);
            tabPage1.Controls.Add(trackBarGREEN);
            tabPage1.Controls.Add(trackBarRED);
            tabPage1.Controls.Add(panelColor);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(654, 548);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxCMYK
            // 
            groupBoxCMYK.Controls.Add(textBox1);
            groupBoxCMYK.Location = new Point(9, 295);
            groupBoxCMYK.Name = "groupBoxCMYK";
            groupBoxCMYK.Size = new Size(192, 57);
            groupBoxCMYK.TabIndex = 13;
            groupBoxCMYK.TabStop = false;
            groupBoxCMYK.Text = "CMYK";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonCONVERTER
            // 
            buttonCONVERTER.Location = new Point(222, 194);
            buttonCONVERTER.Name = "buttonCONVERTER";
            buttonCONVERTER.Size = new Size(153, 99);
            buttonCONVERTER.TabIndex = 12;
            buttonCONVERTER.Text = "CONVERTER";
            buttonCONVERTER.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(18, 92);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 11;
            label3.Text = "BLUE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(9, 142);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 10;
            label2.Text = "GREEN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 9;
            label1.Text = "RED:";
            // 
            // numericUpDownBLUE
            // 
            numericUpDownBLUE.Location = new Point(63, 90);
            numericUpDownBLUE.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBLUE.Name = "numericUpDownBLUE";
            numericUpDownBLUE.Size = new Size(43, 23);
            numericUpDownBLUE.TabIndex = 8;
            numericUpDownBLUE.ValueChanged += NumericUpDownBLUE_ValueChanged;
            // 
            // numericUpDownGREEN
            // 
            numericUpDownGREEN.Location = new Point(63, 140);
            numericUpDownGREEN.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGREEN.Name = "numericUpDownGREEN";
            numericUpDownGREEN.Size = new Size(43, 23);
            numericUpDownGREEN.TabIndex = 7;
            numericUpDownGREEN.ValueChanged += NumericUpDownGREEN_ValueChanged;
            // 
            // numericUpDownRED
            // 
            numericUpDownRED.Location = new Point(63, 40);
            numericUpDownRED.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRED.Name = "numericUpDownRED";
            numericUpDownRED.Size = new Size(43, 23);
            numericUpDownRED.TabIndex = 6;
            numericUpDownRED.ValueChanged += NumericUpDown1_ValueChanged;
            // 
            // trackBarBLUE
            // 
            trackBarBLUE.Location = new Point(112, 79);
            trackBarBLUE.Maximum = 255;
            trackBarBLUE.Name = "trackBarBLUE";
            trackBarBLUE.Size = new Size(104, 45);
            trackBarBLUE.TabIndex = 3;
            trackBarBLUE.Scroll += trackBarBLUE_Scroll;
            // 
            // trackBarGREEN
            // 
            trackBarGREEN.Location = new Point(112, 130);
            trackBarGREEN.Maximum = 255;
            trackBarGREEN.Name = "trackBarGREEN";
            trackBarGREEN.Size = new Size(104, 45);
            trackBarGREEN.TabIndex = 2;
            trackBarGREEN.Scroll += trackBarGREEN_Scroll;
            // 
            // trackBarRED
            // 
            trackBarRED.Location = new Point(112, 28);
            trackBarRED.Maximum = 255;
            trackBarRED.Name = "trackBarRED";
            trackBarRED.Size = new Size(104, 45);
            trackBarRED.TabIndex = 1;
            trackBarRED.Scroll += trackBarRED_Scroll;
            // 
            // panelColor
            // 
            panelColor.BorderStyle = BorderStyle.Fixed3D;
            panelColor.Location = new Point(222, 28);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(153, 147);
            panelColor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(578, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(9, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 57);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "CMYK";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(9, 484);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(192, 57);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "CMYK";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Location = new Point(9, 421);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 57);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "CMYK";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 605);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBoxCMYK.ResumeLayout(false);
            groupBoxCMYK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBLUE).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGREEN).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRED).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBLUE).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGREEN).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRED).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private NumericUpDown numericUpDownBLUE;
        private NumericUpDown numericUpDownGREEN;
        private NumericUpDown numericUpDownRED;
        private TrackBar trackBarBLUE;
        private TrackBar trackBarGREEN;
        private TrackBar trackBarRED;
        private Panel panelColor;
        private Label label3;
        private Label label2;
        private Button buttonCONVERTER;
        private GroupBox groupBoxCMYK;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private TextBox textBox2;
    }
}
