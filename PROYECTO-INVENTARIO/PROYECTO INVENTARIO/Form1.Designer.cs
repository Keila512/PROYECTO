namespace PROYECTO_INVENTARIO
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
            btnSave1 = new Button();
            label5 = new Label();
            label6 = new Label();
            dgvBoard = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            txtpurchase_price = new TextBox();
            txtproduct = new TextBox();
            txtamount = new TextBox();
            txtcode = new TextBox();
            label8 = new Label();
            txtsale_price = new TextBox();
            btnDelete = new Button();
            label9 = new Label();
            txtentries = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txttotal1 = new TextBox();
            txttotal2 = new TextBox();
            btnmost = new Button();
            label = new Label();
            label11 = new Label();
            btnSave2 = new Button();
            txtexit = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            rtxtboxmost = new RichTextBox();
            btnStreamReader = new Button();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 110);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "DESCRIPCION:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "CÓDIGO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 50);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "ENTRADAS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 114);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 3;
            label4.Text = "PRECIO DE VENTA:";
            // 
            // btnSave1
            // 
            btnSave1.Location = new Point(783, 43);
            btnSave1.Margin = new Padding(3, 4, 3, 4);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(86, 31);
            btnSave1.TabIndex = 4;
            btnSave1.Text = "AGREGAR";
            btnSave1.UseVisualStyleBackColor = true;
            btnSave1.Click += btnSave1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 55);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 7;
            label5.Text = "FECHA DE ENTRADA:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Font = new Font("Corbel", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(150, 172);
            label6.Name = "label6";
            label6.Size = new Size(586, 54);
            label6.TabIndex = 8;
            label6.Text = "INVENTARIO DE PRODUCTOS";
            // 
            // dgvBoard
            // 
            dgvBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBoard.BackgroundColor = SystemColors.ActiveCaption;
            dgvBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoard.Columns.AddRange(new DataGridViewColumn[] { codigo, Column2, descripcion, Column4, Column6, Column5, Column1, Column3 });
            dgvBoard.Location = new Point(12, 230);
            dgvBoard.Margin = new Padding(3, 4, 3, 4);
            dgvBoard.Name = "dgvBoard";
            dgvBoard.RowHeadersWidth = 51;
            dgvBoard.RowTemplate.Height = 25;
            dgvBoard.Size = new Size(1213, 376);
            dgvBoard.TabIndex = 9;
            dgvBoard.CellContentClick += dgvBoard_CellContentClick;
            // 
            // codigo
            // 
            codigo.HeaderText = "CÓDIGO";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "FECHA DE ENTRADA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "DESCRIPCION";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "ENTRADAS";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "PRECIO DE COMPRA";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "PRECIO DE VENTA";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "SALIDAS";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "STOCK";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(178, 50);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtpurchase_price
            // 
            txtpurchase_price.Location = new Point(580, 80);
            txtpurchase_price.Margin = new Padding(3, 4, 3, 4);
            txtpurchase_price.Name = "txtpurchase_price";
            txtpurchase_price.Size = new Size(114, 27);
            txtpurchase_price.TabIndex = 11;
            // 
            // txtproduct
            // 
            txtproduct.Location = new Point(131, 107);
            txtproduct.Margin = new Padding(3, 4, 3, 4);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(183, 27);
            txtproduct.TabIndex = 12;
            // 
            // txtamount
            // 
            txtamount.Location = new Point(518, 43);
            txtamount.Margin = new Padding(3, 4, 3, 4);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(114, 27);
            txtamount.TabIndex = 13;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(95, 79);
            txtcode.Margin = new Padding(3, 4, 3, 4);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(179, 27);
            txtcode.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 82);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 16;
            label8.Text = "PRECIO DE COMPRA:";
            // 
            // txtsale_price
            // 
            txtsale_price.Location = new Point(565, 114);
            txtsale_price.Margin = new Padding(3, 4, 3, 4);
            txtsale_price.Name = "txtsale_price";
            txtsale_price.Size = new Size(114, 27);
            txtsale_price.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(783, 99);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1152, 48);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 20;
            label9.Text = "ENTRADAS:";
            // 
            // txtentries
            // 
            txtentries.Location = new Point(1245, 43);
            txtentries.Name = "txtentries";
            txtentries.Size = new Size(153, 27);
            txtentries.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1404, 46);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 22;
            label7.Text = "COMPRAS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1652, 43);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 23;
            label10.Text = "VENTAS:";
            // 
            // txttotal1
            // 
            txttotal1.Location = new Point(1490, 39);
            txttotal1.Name = "txttotal1";
            txttotal1.Size = new Size(156, 27);
            txttotal1.TabIndex = 24;
            // 
            // txttotal2
            // 
            txttotal2.Location = new Point(1723, 36);
            txttotal2.Name = "txttotal2";
            txttotal2.Size = new Size(147, 27);
            txttotal2.TabIndex = 25;
            // 
            // btnmost
            // 
            btnmost.Location = new Point(1612, 87);
            btnmost.Name = "btnmost";
            btnmost.Size = new Size(94, 29);
            btnmost.TabIndex = 26;
            btnmost.Text = "MOSTRAR";
            btnmost.UseVisualStyleBackColor = true;
            btnmost.Click += btnmost_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(1040, 41);
            label.Name = "label";
            label.Size = new Size(106, 31);
            label.TabIndex = 27;
            label.Text = "TOTALES";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveBorder;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(21, 9);
            label11.Name = "label11";
            label11.Size = new Size(239, 20);
            label11.TabIndex = 28;
            label11.Text = "REGISTRO DE PRODUCTOS";
            // 
            // btnSave2
            // 
            btnSave2.Location = new Point(1552, 243);
            btnSave2.Name = "btnSave2";
            btnSave2.Size = new Size(165, 29);
            btnSave2.TabIndex = 30;
            btnSave2.Text = "MOSTRAR STOCK";
            btnSave2.UseVisualStyleBackColor = true;
            btnSave2.Click += btnSave2_Click;
            // 
            // txtexit
            // 
            txtexit.Location = new Point(1404, 245);
            txtexit.Name = "txtexit";
            txtexit.Size = new Size(125, 27);
            txtexit.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1328, 248);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 34;
            label13.Text = "SALIDAS:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1183, 90);
            label12.Name = "label12";
            label12.Size = new Size(124, 20);
            label12.TabIndex = 32;
            label12.Text = "TOTAL DE STOCK:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1313, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 33;
            // 
            // rtxtboxmost
            // 
            rtxtboxmost.Location = new Point(1328, 422);
            rtxtboxmost.Name = "rtxtboxmost";
            rtxtboxmost.Size = new Size(542, 321);
            rtxtboxmost.TabIndex = 35;
            rtxtboxmost.Text = "";
            // 
            // btnStreamReader
            // 
            btnStreamReader.Location = new Point(1776, 387);
            btnStreamReader.Name = "btnStreamReader";
            btnStreamReader.Size = new Size(94, 29);
            btnStreamReader.TabIndex = 36;
            btnStreamReader.Text = "MOSTRAR";
            btnStreamReader.UseVisualStyleBackColor = true;
            btnStreamReader.Click += btnStreamReader_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1445, 344);
            label14.Name = "label14";
            label14.Size = new Size(310, 31);
            label14.TabIndex = 37;
            label14.Text = "PRODUCTOS REGISTRADOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1882, 746);
            Controls.Add(label14);
            Controls.Add(btnStreamReader);
            Controls.Add(rtxtboxmost);
            Controls.Add(label13);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(txtexit);
            Controls.Add(btnSave2);
            Controls.Add(label11);
            Controls.Add(label);
            Controls.Add(btnmost);
            Controls.Add(txttotal2);
            Controls.Add(txttotal1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtentries);
            Controls.Add(label9);
            Controls.Add(btnDelete);
            Controls.Add(txtsale_price);
            Controls.Add(label8);
            Controls.Add(txtcode);
            Controls.Add(txtamount);
            Controls.Add(txtproduct);
            Controls.Add(txtpurchase_price);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvBoard);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSave1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave1;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtpurchase_price;
        private TextBox txtproduct;
        private TextBox txtamount;
        private TextBox txtcode;
        private Label label8;
        private TextBox txtsale_price;
        private Button btnDelete;
        private DataGridView dgvBoard;
        private Label label9;
        private TextBox txtentries;
        private Label label7;
        private Label label10;
        private TextBox txttotal1;
        private TextBox txttotal2;
        private Button btnmost;
        private Label label;
        private Label label11;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Button btnSave2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtexit;
        private Label label13;
        private Label label12;
        private TextBox textBox1;
        private RichTextBox rtxtboxmost;
        private Button btnStreamReader;
        private Label label14;
    }
}