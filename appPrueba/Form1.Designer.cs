namespace appPrueba
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
            btnConexion = new Button();
            lblResultadook = new Label();
            lblResultadoNO = new Label();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(81, 46);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(181, 101);
            btnConexion.TabIndex = 0;
            btnConexion.Text = "Prueba conexion";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // lblResultadook
            // 
            lblResultadook.AutoSize = true;
            lblResultadook.Font = new Font("Futura XBlkCnIt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadook.ForeColor = Color.Green;
            lblResultadook.Location = new Point(81, 192);
            lblResultadook.Name = "lblResultadook";
            lblResultadook.Size = new Size(0, 25);
            lblResultadook.TabIndex = 1;
            // 
            // lblResultadoNO
            // 
            lblResultadoNO.AutoSize = true;
            lblResultadoNO.Font = new Font("Futura XBlkCnIt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoNO.ForeColor = Color.Red;
            lblResultadoNO.Location = new Point(81, 236);
            lblResultadoNO.Name = "lblResultadoNO";
            lblResultadoNO.Size = new Size(0, 25);
            lblResultadoNO.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoNO);
            Controls.Add(lblResultadook);
            Controls.Add(btnConexion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConexion;
        private Label lblResultadook;
        private Label lblResultadoNO;
    }
}
