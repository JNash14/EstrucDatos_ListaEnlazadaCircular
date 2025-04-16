namespace Lista_enlazada_circular
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVerLista = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtModifica = new System.Windows.Forms.TextBox();
            this.btnInsertFinal = new System.Windows.Forms.Button();
            this.btnInsertInicio = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVerLista
            // 
            this.BtnVerLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerLista.Location = new System.Drawing.Point(71, 58);
            this.BtnVerLista.Name = "BtnVerLista";
            this.BtnVerLista.Size = new System.Drawing.Size(75, 22);
            this.BtnVerLista.TabIndex = 0;
            this.BtnVerLista.Text = "Ver Lista";
            this.BtnVerLista.UseVisualStyleBackColor = true;
            this.BtnVerLista.Click += new System.EventHandler(this.BtnVerLista_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(71, 110);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(75, 225);
            this.lstBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modifica";
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(184, 60);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevo.TabIndex = 3;
            // 
            // txtModifica
            // 
            this.txtModifica.Location = new System.Drawing.Point(320, 60);
            this.txtModifica.Name = "txtModifica";
            this.txtModifica.Size = new System.Drawing.Size(100, 20);
            this.txtModifica.TabIndex = 3;
            // 
            // btnInsertFinal
            // 
            this.btnInsertFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFinal.Location = new System.Drawing.Point(184, 124);
            this.btnInsertFinal.Name = "btnInsertFinal";
            this.btnInsertFinal.Size = new System.Drawing.Size(103, 23);
            this.btnInsertFinal.TabIndex = 4;
            this.btnInsertFinal.Text = "Insertar Final";
            this.btnInsertFinal.UseVisualStyleBackColor = true;
            this.btnInsertFinal.Click += new System.EventHandler(this.btnInsertFinal_Click);
            // 
            // btnInsertInicio
            // 
            this.btnInsertInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInicio.Location = new System.Drawing.Point(184, 153);
            this.btnInsertInicio.Name = "btnInsertInicio";
            this.btnInsertInicio.Size = new System.Drawing.Size(103, 23);
            this.btnInsertInicio.TabIndex = 4;
            this.btnInsertInicio.Text = "Insertar Inicio";
            this.btnInsertInicio.UseVisualStyleBackColor = true;
            this.btnInsertInicio.Click += new System.EventHandler(this.btnInsertInicio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(184, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(184, 211);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(184, 240);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(103, 23);
            this.btnContar.TabIndex = 7;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 401);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertInicio);
            this.Controls.Add(this.btnInsertFinal);
            this.Controls.Add(this.txtModifica);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.BtnVerLista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerLista;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtModifica;
        private System.Windows.Forms.Button btnInsertFinal;
        private System.Windows.Forms.Button btnInsertInicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnContar;
    }
}

