namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tmrTimer = new System.Windows.Forms.Timer(components);
            lblcronometro = new Label();
            inicio = new Button();
            detener = new Button();
            resetear = new Button();
            SuspendLayout();
            // 
            // tmrTimer
            // 
            tmrTimer.Tick += cronometro_Tick;
            // 
            // lblcronometro
            // 
            lblcronometro.AutoSize = true;
            lblcronometro.Font = new Font("Arial Black", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcronometro.Location = new Point(127, 59);
            lblcronometro.Name = "lblcronometro";
            lblcronometro.Size = new Size(520, 106);
            lblcronometro.TabIndex = 0;
            lblcronometro.Text = "00:00:00:00";
            lblcronometro.Click += lblcronometro_Click;
            // 
            // inicio
            // 
            inicio.Image = (Image)resources.GetObject("inicio.Image");
            inicio.Location = new Point(177, 209);
            inicio.Name = "inicio";
            inicio.Size = new Size(102, 100);
            inicio.TabIndex = 2;
            inicio.UseVisualStyleBackColor = true;
            inicio.Click += inicio_Click;
            // 
            // detener
            // 
            detener.BackgroundImageLayout = ImageLayout.Center;
            detener.FlatStyle = FlatStyle.Flat;
            detener.Image = (Image)resources.GetObject("detener.Image");
            detener.Location = new Point(358, 213);
            detener.Name = "detener";
            detener.Size = new Size(98, 100);
            detener.TabIndex = 3;
            detener.UseVisualStyleBackColor = true;
            detener.Click += detener_Click;
            // 
            // resetear
            // 
            resetear.Image = (Image)resources.GetObject("resetear.Image");
            resetear.Location = new Point(517, 205);
            resetear.Name = "resetear";
            resetear.Size = new Size(115, 108);
            resetear.TabIndex = 4;
            resetear.UseVisualStyleBackColor = true;
            resetear.Click += resetear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(resetear);
            Controls.Add(detener);
            Controls.Add(inicio);
            Controls.Add(lblcronometro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrTimer;
        private Label lblcronometro;
        private Button inicio;
        private Button detener;
        private Button resetear;
    }
}
