
namespace RegistrodeAlumnos
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelAddStudent = new System.Windows.Forms.Label();
            this.BoxNameStudent = new System.Windows.Forms.TextBox();
            this.LabelNameStudent = new System.Windows.Forms.Label();
            this.LabelLastname1 = new System.Windows.Forms.Label();
            this.LabelLastName2 = new System.Windows.Forms.Label();
            this.ButtonSaveName = new System.Windows.Forms.Button();
            this.BoxLastname1 = new System.Windows.Forms.TextBox();
            this.BoxLastName2 = new System.Windows.Forms.TextBox();
            this.BoxSearchStudent = new System.Windows.Forms.TextBox();
            this.LabelSearchStudent = new System.Windows.Forms.Label();
            this.ButtonClearStudents = new System.Windows.Forms.Button();
            this.GridStudents = new System.Windows.Forms.DataGridView();
            this.NameStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSearchStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Gold;
            this.LabelTitle.Location = new System.Drawing.Point(303, 50);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(328, 37);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "REGISTRO DE ALUMNOS";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAddStudent
            // 
            this.LabelAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAddStudent.AutoSize = true;
            this.LabelAddStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddStudent.ForeColor = System.Drawing.Color.Gold;
            this.LabelAddStudent.Location = new System.Drawing.Point(30, 120);
            this.LabelAddStudent.Name = "LabelAddStudent";
            this.LabelAddStudent.Size = new System.Drawing.Size(177, 30);
            this.LabelAddStudent.TabIndex = 1;
            this.LabelAddStudent.Text = "Agregar Alumno";
            this.LabelAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoxNameStudent
            // 
            this.BoxNameStudent.BackColor = System.Drawing.Color.DimGray;
            this.BoxNameStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNameStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNameStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BoxNameStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxNameStudent.Location = new System.Drawing.Point(35, 190);
            this.BoxNameStudent.Margin = new System.Windows.Forms.Padding(5);
            this.BoxNameStudent.Name = "BoxNameStudent";
            this.BoxNameStudent.Size = new System.Drawing.Size(210, 27);
            this.BoxNameStudent.TabIndex = 2;
            this.BoxNameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxNameStudent_KeyPress);
            // 
            // LabelNameStudent
            // 
            this.LabelNameStudent.AutoSize = true;
            this.LabelNameStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameStudent.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelNameStudent.Location = new System.Drawing.Point(30, 160);
            this.LabelNameStudent.Name = "LabelNameStudent";
            this.LabelNameStudent.Size = new System.Drawing.Size(103, 25);
            this.LabelNameStudent.TabIndex = 4;
            this.LabelNameStudent.Text = "Nombre(s)";
            // 
            // LabelLastname1
            // 
            this.LabelLastname1.AutoSize = true;
            this.LabelLastname1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastname1.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelLastname1.Location = new System.Drawing.Point(270, 160);
            this.LabelLastname1.Name = "LabelLastname1";
            this.LabelLastname1.Size = new System.Drawing.Size(154, 25);
            this.LabelLastname1.TabIndex = 6;
            this.LabelLastname1.Text = "Apellido Paterno";
            // 
            // LabelLastName2
            // 
            this.LabelLastName2.AutoSize = true;
            this.LabelLastName2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName2.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelLastName2.Location = new System.Drawing.Point(510, 160);
            this.LabelLastName2.Name = "LabelLastName2";
            this.LabelLastName2.Size = new System.Drawing.Size(162, 25);
            this.LabelLastName2.TabIndex = 8;
            this.LabelLastName2.Text = "Apellido Materno";
            // 
            // ButtonSaveName
            // 
            this.ButtonSaveName.BackColor = System.Drawing.Color.Gold;
            this.ButtonSaveName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveName.Location = new System.Drawing.Point(760, 185);
            this.ButtonSaveName.Name = "ButtonSaveName";
            this.ButtonSaveName.Size = new System.Drawing.Size(144, 35);
            this.ButtonSaveName.TabIndex = 5;
            this.ButtonSaveName.Text = "Guardar";
            this.ButtonSaveName.UseVisualStyleBackColor = false;
            this.ButtonSaveName.Click += new System.EventHandler(this.ButtonSaveName_Click);
            // 
            // BoxLastname1
            // 
            this.BoxLastname1.BackColor = System.Drawing.Color.DimGray;
            this.BoxLastname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxLastname1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLastname1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BoxLastname1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxLastname1.Location = new System.Drawing.Point(275, 190);
            this.BoxLastname1.Margin = new System.Windows.Forms.Padding(5);
            this.BoxLastname1.Name = "BoxLastname1";
            this.BoxLastname1.Size = new System.Drawing.Size(210, 27);
            this.BoxLastname1.TabIndex = 3;
            this.BoxLastname1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxLastname1_KeyPress);
            // 
            // BoxLastName2
            // 
            this.BoxLastName2.BackColor = System.Drawing.Color.DimGray;
            this.BoxLastName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxLastName2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLastName2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BoxLastName2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxLastName2.Location = new System.Drawing.Point(515, 190);
            this.BoxLastName2.Margin = new System.Windows.Forms.Padding(5);
            this.BoxLastName2.Name = "BoxLastName2";
            this.BoxLastName2.Size = new System.Drawing.Size(210, 27);
            this.BoxLastName2.TabIndex = 4;
            this.BoxLastName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxLastName2_KeyPress);
            // 
            // BoxSearchStudent
            // 
            this.BoxSearchStudent.BackColor = System.Drawing.Color.DimGray;
            this.BoxSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxSearchStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearchStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BoxSearchStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxSearchStudent.Location = new System.Drawing.Point(35, 300);
            this.BoxSearchStudent.Margin = new System.Windows.Forms.Padding(5);
            this.BoxSearchStudent.Name = "BoxSearchStudent";
            this.BoxSearchStudent.Size = new System.Drawing.Size(516, 27);
            this.BoxSearchStudent.TabIndex = 7;
            // 
            // LabelSearchStudent
            // 
            this.LabelSearchStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSearchStudent.AutoSize = true;
            this.LabelSearchStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchStudent.ForeColor = System.Drawing.Color.Gold;
            this.LabelSearchStudent.Location = new System.Drawing.Point(33, 256);
            this.LabelSearchStudent.Name = "LabelSearchStudent";
            this.LabelSearchStudent.Size = new System.Drawing.Size(162, 30);
            this.LabelSearchStudent.TabIndex = 6;
            this.LabelSearchStudent.Text = "Buscar Alumno";
            this.LabelSearchStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonClearStudents
            // 
            this.ButtonClearStudents.BackColor = System.Drawing.Color.Gold;
            this.ButtonClearStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearStudents.Location = new System.Drawing.Point(700, 295);
            this.ButtonClearStudents.Name = "ButtonClearStudents";
            this.ButtonClearStudents.Size = new System.Drawing.Size(210, 35);
            this.ButtonClearStudents.TabIndex = 9;
            this.ButtonClearStudents.Text = "Limpiar Registros";
            this.ButtonClearStudents.UseVisualStyleBackColor = false;
            this.ButtonClearStudents.Click += new System.EventHandler(this.ButtonClearStudents_Click);
            // 
            // GridStudents
            // 
            this.GridStudents.AllowUserToAddRows = false;
            this.GridStudents.AllowUserToDeleteRows = false;
            this.GridStudents.AllowUserToResizeColumns = false;
            this.GridStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.GridStudents.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GridStudents.CausesValidation = false;
            this.GridStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridStudents.ColumnHeadersHeight = 45;
            this.GridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameStudents,
            this.LastnameA,
            this.LastNameB});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridStudents.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GridStudents.Location = new System.Drawing.Point(35, 348);
            this.GridStudents.Name = "GridStudents";
            this.GridStudents.ReadOnly = true;
            this.GridStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridStudents.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.GridStudents.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridStudents.ShowCellErrors = false;
            this.GridStudents.ShowCellToolTips = false;
            this.GridStudents.Size = new System.Drawing.Size(875, 267);
            this.GridStudents.TabIndex = 10;
            // 
            // NameStudents
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.NameStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameStudents.FillWeight = 120F;
            this.NameStudents.HeaderText = "Nombre(s)";
            this.NameStudents.MinimumWidth = 100;
            this.NameStudents.Name = "NameStudents";
            this.NameStudents.ReadOnly = true;
            this.NameStudents.Width = 290;
            // 
            // LastnameA
            // 
            this.LastnameA.HeaderText = "Apellido Paterno";
            this.LastnameA.Name = "LastnameA";
            this.LastnameA.ReadOnly = true;
            this.LastnameA.Width = 292;
            // 
            // LastNameB
            // 
            this.LastNameB.HeaderText = "Apellido Materno";
            this.LastNameB.Name = "LastNameB";
            this.LastNameB.ReadOnly = true;
            this.LastNameB.Width = 292;
            // 
            // ButtonSearchStudent
            // 
            this.ButtonSearchStudent.BackColor = System.Drawing.Color.Gold;
            this.ButtonSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchStudent.Location = new System.Drawing.Point(576, 295);
            this.ButtonSearchStudent.Name = "ButtonSearchStudent";
            this.ButtonSearchStudent.Size = new System.Drawing.Size(102, 35);
            this.ButtonSearchStudent.TabIndex = 8;
            this.ButtonSearchStudent.Text = "Buscar";
            this.ButtonSearchStudent.UseVisualStyleBackColor = false;
            this.ButtonSearchStudent.Click += new System.EventHandler(this.ButtonSearchStudent_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(939, 641);
            this.Controls.Add(this.ButtonSearchStudent);
            this.Controls.Add(this.GridStudents);
            this.Controls.Add(this.ButtonClearStudents);
            this.Controls.Add(this.BoxSearchStudent);
            this.Controls.Add(this.LabelSearchStudent);
            this.Controls.Add(this.BoxLastName2);
            this.Controls.Add(this.BoxLastname1);
            this.Controls.Add(this.ButtonSaveName);
            this.Controls.Add(this.LabelLastName2);
            this.Controls.Add(this.LabelLastname1);
            this.Controls.Add(this.LabelNameStudent);
            this.Controls.Add(this.BoxNameStudent);
            this.Controls.Add(this.LabelAddStudent);
            this.Controls.Add(this.LabelTitle);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Alumnos ";
            ((System.ComponentModel.ISupportInitialize)(this.GridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelAddStudent;
        private System.Windows.Forms.TextBox BoxNameStudent;
        private System.Windows.Forms.Label LabelNameStudent;
        private System.Windows.Forms.Label LabelLastname1;
        private System.Windows.Forms.Label LabelLastName2;
        private System.Windows.Forms.Button ButtonSaveName;
        private System.Windows.Forms.TextBox BoxLastname1;
        private System.Windows.Forms.TextBox BoxLastName2;
        private System.Windows.Forms.TextBox BoxSearchStudent;
        private System.Windows.Forms.Label LabelSearchStudent;
        private System.Windows.Forms.Button ButtonClearStudents;
        private System.Windows.Forms.DataGridView GridStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameB;
        private System.Windows.Forms.Button ButtonSearchStudent;
    }
}

