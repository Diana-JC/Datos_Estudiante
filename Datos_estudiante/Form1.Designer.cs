namespace Datos_estudiante
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Edad = new TextBox();
            txt_Carrera = new TextBox();
            btn_Ingresar = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            label6 = new Label();
            label7 = new Label();
            txt_Datos = new TextBox();
            txt_Matricula = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label1.Location = new Point(50, 158);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label2.Location = new Point(50, 226);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label3.Location = new Point(50, 282);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label4.Location = new Point(50, 342);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label5.Location = new Point(50, 401);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Carrera";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(158, 226);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(150, 31);
            txt_Nombre.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(158, 282);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(150, 31);
            txt_Apellido.TabIndex = 7;
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(158, 341);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(150, 31);
            txt_Edad.TabIndex = 8;
            // 
            // txt_Carrera
            // 
            txt_Carrera.Location = new Point(158, 400);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(150, 31);
            txt_Carrera.TabIndex = 9;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btn_Ingresar.Location = new Point(415, 173);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(133, 41);
            btn_Ingresar.TabIndex = 10;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(415, 226);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(133, 41);
            btn_Limpiar.TabIndex = 11;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btn_Salir.Location = new Point(415, 282);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(133, 41);
            btn_Salir.TabIndex = 12;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(188, 47);
            label6.Name = "label6";
            label6.Size = new Size(319, 45);
            label6.TabIndex = 13;
            label6.Text = "Datos_Estudiante";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(147, 479);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 14;
            label7.Text = "Datos";
            // 
            // txt_Datos
            // 
            txt_Datos.Location = new Point(221, 480);
            txt_Datos.Name = "txt_Datos";
            txt_Datos.Size = new Size(350, 31);
            txt_Datos.TabIndex = 15;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(160, 158);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(150, 31);
            txt_Matricula.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(630, 533);
            Controls.Add(txt_Matricula);
            Controls.Add(txt_Datos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Ingresar);
            Controls.Add(txt_Carrera);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Edad;
        private TextBox txt_Carrera;
        private Button btn_Ingresar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Label label6;
        private Label label7;
        private TextBox txt_Datos;
        private TextBox txt_Matricula;
    }
}
