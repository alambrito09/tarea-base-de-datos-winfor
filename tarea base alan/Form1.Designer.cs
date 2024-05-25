namespace tarea_base_alan
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
            buscar = new Button();
            probar = new Button();
            insertar = new Button();
            cargar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxraza = new ComboBox();
            dateTimePickerfechacreacion = new DateTimePicker();
            dataGridViewpersonajes = new DataGridView();
            numericUpDownnivelpoder = new NumericUpDown();
            fileSystemWatcher1 = new FileSystemWatcher();
            textBoxid = new TextBox();
            textBoxnombre = new TextBox();
            textBoxraza = new TextBox();
            textBoxhistoria = new TextBox();
            fileSystemWatcher2 = new FileSystemWatcher();
            actualizar = new Button();
            eliminar = new Button();
            historia = new Button();
            limpiar = new Button();
            fechacreacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpersonajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownnivelpoder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            SuspendLayout();
            // 
            // buscar
            // 
            buscar.Location = new Point(321, 56);
            buscar.Name = "buscar";
            buscar.Size = new Size(75, 23);
            buscar.TabIndex = 0;
            buscar.Text = "buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // probar
            // 
            probar.Location = new Point(648, 243);
            probar.Name = "probar";
            probar.Size = new Size(173, 23);
            probar.TabIndex = 1;
            probar.Text = "probar conexion";
            probar.UseVisualStyleBackColor = true;
            probar.Click += probar_Click;
            // 
            // insertar
            // 
            insertar.Location = new Point(48, 402);
            insertar.Name = "insertar";
            insertar.Size = new Size(75, 23);
            insertar.TabIndex = 2;
            insertar.Text = "insertar";
            insertar.UseVisualStyleBackColor = true;
            insertar.Click += insertar_Click;
            // 
            // cargar
            // 
            cargar.Location = new Point(1080, 455);
            cargar.Name = "cargar";
            cargar.Size = new Size(75, 23);
            cargar.TabIndex = 3;
            cargar.Text = "cargar";
            cargar.UseVisualStyleBackColor = true;
            cargar.Click += cargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 59);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 96);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 131);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "raza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 198);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 7;
            label4.Text = "nivel poder";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 241);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 8;
            label5.Text = "fecha naciemiento+";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 290);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 9;
            label6.Text = "historia";
            // 
            // comboBoxraza
            // 
            comboBoxraza.FormattingEnabled = true;
            comboBoxraza.Location = new Point(149, 157);
            comboBoxraza.Name = "comboBoxraza";
            comboBoxraza.Size = new Size(143, 23);
            comboBoxraza.TabIndex = 13;
            comboBoxraza.SelectedIndexChanged += comboBoxraza_SelectedIndexChanged;
            // 
            // dateTimePickerfechacreacion
            // 
            dateTimePickerfechacreacion.Location = new Point(208, 235);
            dateTimePickerfechacreacion.Name = "dateTimePickerfechacreacion";
            dateTimePickerfechacreacion.Size = new Size(226, 23);
            dateTimePickerfechacreacion.TabIndex = 14;
            dateTimePickerfechacreacion.ValueChanged += dateTimePickerfechacreacion_ValueChanged;
            // 
            // dataGridViewpersonajes
            // 
            dataGridViewpersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpersonajes.Location = new Point(208, 319);
            dataGridViewpersonajes.Name = "dataGridViewpersonajes";
            dataGridViewpersonajes.Size = new Size(767, 305);
            dataGridViewpersonajes.TabIndex = 16;
            dataGridViewpersonajes.CellContentClick += dataGridViewpersonajes_CellContentClick;
            // 
            // numericUpDownnivelpoder
            // 
            numericUpDownnivelpoder.Location = new Point(149, 196);
            numericUpDownnivelpoder.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownnivelpoder.Name = "numericUpDownnivelpoder";
            numericUpDownnivelpoder.Size = new Size(120, 23);
            numericUpDownnivelpoder.TabIndex = 17;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(149, 56);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(41, 23);
            textBoxid.TabIndex = 18;
            textBoxid.TextChanged += textBoxid_TextChanged;
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(149, 93);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(135, 23);
            textBoxnombre.TabIndex = 19;
            // 
            // textBoxraza
            // 
            textBoxraza.Location = new Point(149, 128);
            textBoxraza.Name = "textBoxraza";
            textBoxraza.Size = new Size(135, 23);
            textBoxraza.TabIndex = 20;
            // 
            // textBoxhistoria
            // 
            textBoxhistoria.Location = new Point(149, 290);
            textBoxhistoria.Name = "textBoxhistoria";
            textBoxhistoria.Size = new Size(870, 23);
            textBoxhistoria.TabIndex = 21;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // actualizar
            // 
            actualizar.Location = new Point(48, 455);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(75, 23);
            actualizar.TabIndex = 22;
            actualizar.Text = "actualizar";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(51, 507);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(75, 23);
            eliminar.TabIndex = 23;
            eliminar.Text = "eliminar";
            eliminar.UseVisualStyleBackColor = true;
            eliminar.Click += eliminar_Click;
            // 
            // historia
            // 
            historia.Location = new Point(28, 356);
            historia.Name = "historia";
            historia.Size = new Size(131, 23);
            historia.TabIndex = 24;
            historia.Text = "buscar historia";
            historia.UseVisualStyleBackColor = true;
            historia.Click += historia_Click;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(321, 114);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(75, 23);
            limpiar.TabIndex = 25;
            limpiar.Text = "limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // fechacreacion
            // 
            fechacreacion.Location = new Point(28, 327);
            fechacreacion.Name = "fechacreacion";
            fechacreacion.Size = new Size(110, 23);
            fechacreacion.TabIndex = 26;
            fechacreacion.Text = "buscar fecha";
            fechacreacion.UseVisualStyleBackColor = true;
            fechacreacion.Click += fechacreacion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 636);
            Controls.Add(fechacreacion);
            Controls.Add(limpiar);
            Controls.Add(historia);
            Controls.Add(eliminar);
            Controls.Add(actualizar);
            Controls.Add(textBoxhistoria);
            Controls.Add(textBoxraza);
            Controls.Add(textBoxnombre);
            Controls.Add(textBoxid);
            Controls.Add(numericUpDownnivelpoder);
            Controls.Add(dataGridViewpersonajes);
            Controls.Add(dateTimePickerfechacreacion);
            Controls.Add(comboBoxraza);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cargar);
            Controls.Add(insertar);
            Controls.Add(probar);
            Controls.Add(buscar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewpersonajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownnivelpoder).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buscar;
        private Button probar;
        private Button insertar;
        private Button cargar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxraza;
        private DateTimePicker dateTimePickerfechacreacion;
        private DataGridView dataGridViewpersonajes;
        private NumericUpDown numericUpDownnivelpoder;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBoxid;
        private TextBox textBoxraza;
        private TextBox textBoxnombre;
        private TextBox textBoxhistoria;
        private FileSystemWatcher fileSystemWatcher2;
        private Button actualizar;
        private Button eliminar;
        private Button historia;
        private Button limpiar;
        private Button fecha;
        private Button fechacreacion;
    }
}
