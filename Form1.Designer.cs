namespace pryBlaiottaEtapa6
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
            pctVehiculos = new PictureBox();
            btnCargar = new Button();
            btnMover = new Button();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctVehiculos).BeginInit();
            SuspendLayout();
            // 
            // pctVehiculos
            // 
            pctVehiculos.Location = new Point(11, 12);
            pctVehiculos.Name = "pctVehiculos";
            pctVehiculos.Size = new Size(792, 400);
            pctVehiculos.TabIndex = 0;
            pctVehiculos.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(223, 418);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(407, 418);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(75, 23);
            btnMover.TabIndex = 2;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 418);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(176, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad de vehiculos a generar";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(11, 445);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnMover);
            Controls.Add(btnCargar);
            Controls.Add(pctVehiculos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctVehiculos;
        private Button btnCargar;
        private Button btnMover;
        private Label lblCantidad;
        private TextBox txtCantidad;
    }
}