namespace ejercicio_telegrama
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
            label1 = new Label();
            txtTelegrama = new TextBox();
            chkUrgente = new CheckBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(18, 47);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(356, 84);
            txtTelegrama.TabIndex = 1;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(18, 148);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(78, 19);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "¿Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(64, 193);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 196);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Coste:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(203, 183);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(171, 40);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 249);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(chkUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelegrama;
        private CheckBox chkUrgente;
        private TextBox txtPrecio;
        private Label label2;
        private Button btnCalcular;
    }
}
