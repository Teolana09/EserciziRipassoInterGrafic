namespace EserciziRipassoInterGrafic
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
            GradiCelsius = new Label();
            GradiC = new TextBox();
            GradiFa = new Label();
            GradiF = new TextBox();
            InversioneC = new Button();
            InverisioneF = new Button();
            RisultatoC = new TextBox();
            RisultatoF = new TextBox();
            SuspendLayout();
            // 
            // GradiCelsius
            // 
            GradiCelsius.AutoSize = true;
            GradiCelsius.Location = new Point(163, 139);
            GradiCelsius.Name = "GradiCelsius";
            GradiCelsius.Size = new Size(72, 15);
            GradiCelsius.TabIndex = 0;
            GradiCelsius.Text = "GradiCelsius";
            // 
            // GradiC
            // 
            GradiC.Location = new Point(163, 157);
            GradiC.Name = "GradiC";
            GradiC.Size = new Size(100, 23);
            GradiC.TabIndex = 1;
            // 
            // GradiFa
            // 
            GradiFa.AutoSize = true;
            GradiFa.Location = new Point(381, 139);
            GradiFa.Name = "GradiFa";
            GradiFa.Size = new Size(77, 15);
            GradiFa.TabIndex = 2;
            GradiFa.Text = "GradiFarenite";
            // 
            // GradiF
            // 
            GradiF.Location = new Point(381, 157);
            GradiF.Name = "GradiF";
            GradiF.Size = new Size(100, 23);
            GradiF.TabIndex = 3;
            // 
            // InversioneC
            // 
            InversioneC.Location = new Point(163, 186);
            InversioneC.Name = "InversioneC";
            InversioneC.Size = new Size(75, 23);
            InversioneC.TabIndex = 4;
            InversioneC.Text = "<=>";
            InversioneC.UseVisualStyleBackColor = true;
            InversioneC.Click += Inversione_Click;
            // 
            // InverisioneF
            // 
            InverisioneF.Location = new Point(381, 186);
            InverisioneF.Name = "InverisioneF";
            InverisioneF.Size = new Size(75, 23);
            InverisioneF.TabIndex = 5;
            InverisioneF.Text = "<=>";
            InverisioneF.UseVisualStyleBackColor = true;
            InverisioneF.Click += InverisioneF_Click;
            // 
            // RisultatoC
            // 
            RisultatoC.Location = new Point(163, 215);
            RisultatoC.Name = "RisultatoC";
            RisultatoC.Size = new Size(100, 23);
            RisultatoC.TabIndex = 6;
            // 
            // RisultatoF
            // 
            RisultatoF.Location = new Point(381, 215);
            RisultatoF.Name = "RisultatoF";
            RisultatoF.Size = new Size(100, 23);
            RisultatoF.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RisultatoF);
            Controls.Add(RisultatoC);
            Controls.Add(InverisioneF);
            Controls.Add(InversioneC);
            Controls.Add(GradiF);
            Controls.Add(GradiFa);
            Controls.Add(GradiC);
            Controls.Add(GradiCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GradiCelsius;
        private TextBox GradiC;
        private Label GradiFa;
        private TextBox GradiF;
        private Button InversioneC;
        private Button InverisioneF;
        private TextBox RisultatoC;
        private TextBox RisultatoF;
    }
}
