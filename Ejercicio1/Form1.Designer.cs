namespace Ejercicio1
{
    partial class HubCJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTardanza = new System.Windows.Forms.TextBox();
            this.textAtencion = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.labelNumEmpleados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CATEGORIA : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MINUTOS DE TARDANZA : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° LLAMADAS DE ATENCION : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TOTAL DE EMPLEADOS : ";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(128, 118);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(154, 23);
            this.buttonRegistrar.TabIndex = 5;
            this.buttonRegistrar.Text = "REGISTRAR EMPLEADO";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(371, 118);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(128, 6);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(447, 20);
            this.textNombre.TabIndex = 7;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textTardanza
            // 
            this.textTardanza.Location = new System.Drawing.Point(181, 81);
            this.textTardanza.Name = "textTardanza";
            this.textTardanza.Size = new System.Drawing.Size(100, 20);
            this.textTardanza.TabIndex = 8;
            this.textTardanza.TextChanged += new System.EventHandler(this.textTardanza_TextChanged);
            this.textTardanza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTardanza_KeyPress);
            // 
            // textAtencion
            // 
            this.textAtencion.Location = new System.Drawing.Point(474, 81);
            this.textAtencion.Name = "textAtencion";
            this.textAtencion.Size = new System.Drawing.Size(100, 20);
            this.textAtencion.TabIndex = 9;
            this.textAtencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAtencion_KeyPress);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 146);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(127, 43);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 11;
            // 
            // labelNumEmpleados
            // 
            this.labelNumEmpleados.AutoSize = true;
            this.labelNumEmpleados.Location = new System.Drawing.Point(520, 313);
            this.labelNumEmpleados.Name = "labelNumEmpleados";
            this.labelNumEmpleados.Size = new System.Drawing.Size(13, 13);
            this.labelNumEmpleados.TabIndex = 12;
            this.labelNumEmpleados.Text = "0";
            // 
            // HubCJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 350);
            this.Controls.Add(this.labelNumEmpleados);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textAtencion);
            this.Controls.Add(this.textTardanza);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HubCJ";
            this.Text = "HubCJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTardanza;
        private System.Windows.Forms.TextBox textAtencion;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label labelNumEmpleados;
    }
}

