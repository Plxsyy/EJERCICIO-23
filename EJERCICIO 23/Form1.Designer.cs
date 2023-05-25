namespace EJERCICIO_23
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonCheckedListBox = new System.Windows.Forms.RadioButton();
            this.radioButtonComboBox = new System.Windows.Forms.RadioButton();
            this.radioButtonListBox = new System.Windows.Forms.RadioButton();
            this.labelElemento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxListBox = new System.Windows.Forms.TextBox();
            this.textBoxComboBox = new System.Windows.Forms.TextBox();
            this.textBoxCheckedListBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.radioButtonCheckedListBox);
            this.panel1.Controls.Add(this.radioButtonComboBox);
            this.panel1.Controls.Add(this.radioButtonListBox);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 66);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonCheckedListBox
            // 
            this.radioButtonCheckedListBox.AutoSize = true;
            this.radioButtonCheckedListBox.Location = new System.Drawing.Point(239, 25);
            this.radioButtonCheckedListBox.Name = "radioButtonCheckedListBox";
            this.radioButtonCheckedListBox.Size = new System.Drawing.Size(125, 20);
            this.radioButtonCheckedListBox.TabIndex = 2;
            this.radioButtonCheckedListBox.TabStop = true;
            this.radioButtonCheckedListBox.Text = "CheckedListBox";
            this.radioButtonCheckedListBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonComboBox
            // 
            this.radioButtonComboBox.AutoSize = true;
            this.radioButtonComboBox.Location = new System.Drawing.Point(129, 25);
            this.radioButtonComboBox.Name = "radioButtonComboBox";
            this.radioButtonComboBox.Size = new System.Drawing.Size(95, 20);
            this.radioButtonComboBox.TabIndex = 1;
            this.radioButtonComboBox.TabStop = true;
            this.radioButtonComboBox.Text = "ComboBox";
            this.radioButtonComboBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonListBox
            // 
            this.radioButtonListBox.AutoSize = true;
            this.radioButtonListBox.Location = new System.Drawing.Point(19, 25);
            this.radioButtonListBox.Name = "radioButtonListBox";
            this.radioButtonListBox.Size = new System.Drawing.Size(71, 20);
            this.radioButtonListBox.TabIndex = 0;
            this.radioButtonListBox.TabStop = true;
            this.radioButtonListBox.Text = "ListBox";
            this.radioButtonListBox.UseVisualStyleBackColor = true;
            // 
            // labelElemento
            // 
            this.labelElemento.AutoSize = true;
            this.labelElemento.BackColor = System.Drawing.Color.DarkGray;
            this.labelElemento.Location = new System.Drawing.Point(46, 13);
            this.labelElemento.Name = "labelElemento";
            this.labelElemento.Size = new System.Drawing.Size(64, 16);
            this.labelElemento.TabIndex = 1;
            this.labelElemento.Text = "Elemento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(95, 43);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadir.TabIndex = 3;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(195, 43);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(21, 110);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(172, 212);
            this.listBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(497, 110);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(232, 208);
            this.checkedListBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elementos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.textBoxCheckedListBox);
            this.panel2.Controls.Add(this.textBoxComboBox);
            this.panel2.Controls.Add(this.textBoxListBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 69);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.buttonAñadir);
            this.panel3.Controls.Add(this.buttonEliminar);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.labelElemento);
            this.panel3.Location = new System.Drawing.Point(448, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 85);
            this.panel3.TabIndex = 10;
            // 
            // textBoxListBox
            // 
            this.textBoxListBox.Location = new System.Drawing.Point(187, 24);
            this.textBoxListBox.Name = "textBoxListBox";
            this.textBoxListBox.Size = new System.Drawing.Size(23, 22);
            this.textBoxListBox.TabIndex = 9;
            this.textBoxListBox.Text = "0";
            // 
            // textBoxComboBox
            // 
            this.textBoxComboBox.Location = new System.Drawing.Point(355, 24);
            this.textBoxComboBox.Name = "textBoxComboBox";
            this.textBoxComboBox.Size = new System.Drawing.Size(22, 22);
            this.textBoxComboBox.TabIndex = 10;
            this.textBoxComboBox.Text = "0";
            // 
            // textBoxCheckedListBox
            // 
            this.textBoxCheckedListBox.Location = new System.Drawing.Point(576, 24);
            this.textBoxCheckedListBox.Name = "textBoxCheckedListBox";
            this.textBoxCheckedListBox.Size = new System.Drawing.Size(20, 22);
            this.textBoxCheckedListBox.TabIndex = 11;
            this.textBoxCheckedListBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonCheckedListBox;
        private System.Windows.Forms.RadioButton radioButtonComboBox;
        private System.Windows.Forms.RadioButton radioButtonListBox;
        private System.Windows.Forms.Label labelElemento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCheckedListBox;
        private System.Windows.Forms.TextBox textBoxComboBox;
        private System.Windows.Forms.TextBox textBoxListBox;
        private System.Windows.Forms.Panel panel3;
    }
}

