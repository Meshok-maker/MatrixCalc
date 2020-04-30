namespace MatrixCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.MatrixA = new System.Windows.Forms.Label();
			this.MatrixB = new System.Windows.Forms.Label();
			this.MatrixResult = new System.Windows.Forms.Label();
			this.Replace = new System.Windows.Forms.Button();
			this.MultMatrBtn = new System.Windows.Forms.Button();
			this.DiffMatrBtn = new System.Windows.Forms.Button();
			this.SumMatrBtn = new System.Windows.Forms.Button();
			this.ClearBtn1 = new System.Windows.Forms.Button();
			this.RandBtn1 = new System.Windows.Forms.Button();
			this.ChangeDimsBtn1 = new System.Windows.Forms.Button();
			this.DetermBtn1 = new System.Windows.Forms.Button();
			this.InverseBtn1 = new System.Windows.Forms.Button();
			this.TransBtn1 = new System.Windows.Forms.Button();
			this.RaiseBtn1 = new System.Windows.Forms.Button();
			this.MultBtn1 = new System.Windows.Forms.Button();
			this.FromNum1 = new System.Windows.Forms.TextBox();
			this.ToNum1 = new System.Windows.Forms.TextBox();
			this.RaiseNum1 = new System.Windows.Forms.TextBox();
			this.MultNum1 = new System.Windows.Forms.TextBox();
			this.MultNum2 = new System.Windows.Forms.TextBox();
			this.RaiseNum2 = new System.Windows.Forms.TextBox();
			this.ToNum2 = new System.Windows.Forms.TextBox();
			this.FromNum2 = new System.Windows.Forms.TextBox();
			this.MultBtn2 = new System.Windows.Forms.Button();
			this.RaiseBtn2 = new System.Windows.Forms.Button();
			this.TransBtn2 = new System.Windows.Forms.Button();
			this.InverseBtn2 = new System.Windows.Forms.Button();
			this.DetermBtn2 = new System.Windows.Forms.Button();
			this.ChangeDimsBtn2 = new System.Windows.Forms.Button();
			this.RandBtn2 = new System.Windows.Forms.Button();
			this.ClearBtn2 = new System.Windows.Forms.Button();
			this.Triangle1 = new System.Windows.Forms.Button();
			this.Triangle2 = new System.Windows.Forms.Button();
			this.CopyToA = new System.Windows.Forms.Button();
			this.CopyToB = new System.Windows.Forms.Button();
			this.ResultNum1 = new System.Windows.Forms.TextBox();
			this.ResultNum2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MatrixA
			// 
			this.MatrixA.AutoSize = true;
			this.MatrixA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MatrixA.Location = new System.Drawing.Point(139, 32);
			this.MatrixA.Name = "MatrixA";
			this.MatrixA.Size = new System.Drawing.Size(158, 25);
			this.MatrixA.TabIndex = 3;
			this.MatrixA.Text = "МАТРИЦА (A):";
			// 
			// MatrixB
			// 
			this.MatrixB.AutoSize = true;
			this.MatrixB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MatrixB.Location = new System.Drawing.Point(647, 32);
			this.MatrixB.Name = "MatrixB";
			this.MatrixB.Size = new System.Drawing.Size(154, 25);
			this.MatrixB.TabIndex = 4;
			this.MatrixB.Text = "МАТРИЦА (B):";
			// 
			// MatrixResult
			// 
			this.MatrixResult.AutoSize = true;
			this.MatrixResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MatrixResult.Location = new System.Drawing.Point(419, 450);
			this.MatrixResult.Name = "MatrixResult";
			this.MatrixResult.Size = new System.Drawing.Size(76, 25);
			this.MatrixResult.TabIndex = 5;
			this.MatrixResult.Text = "Result:";
			// 
			// Replace
			// 
			this.Replace.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Replace.FlatAppearance.BorderSize = 0;
			this.Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Replace.Location = new System.Drawing.Point(416, 59);
			this.Replace.Name = "Replace";
			this.Replace.Size = new System.Drawing.Size(79, 44);
			this.Replace.TabIndex = 6;
			this.Replace.Text = "  →     \r\n←";
			this.Replace.UseVisualStyleBackColor = false;
			this.Replace.Click += new System.EventHandler(this.Replace_Click);
			// 
			// MultMatrBtn
			// 
			this.MultMatrBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.MultMatrBtn.FlatAppearance.BorderSize = 0;
			this.MultMatrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MultMatrBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MultMatrBtn.Location = new System.Drawing.Point(416, 162);
			this.MultMatrBtn.Name = "MultMatrBtn";
			this.MultMatrBtn.Size = new System.Drawing.Size(79, 31);
			this.MultMatrBtn.TabIndex = 7;
			this.MultMatrBtn.Text = "A * B";
			this.MultMatrBtn.UseVisualStyleBackColor = false;
			this.MultMatrBtn.Click += new System.EventHandler(this.MultMatrBtn_Click_1);
			// 
			// DiffMatrBtn
			// 
			this.DiffMatrBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.DiffMatrBtn.FlatAppearance.BorderSize = 0;
			this.DiffMatrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DiffMatrBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DiffMatrBtn.Location = new System.Drawing.Point(416, 236);
			this.DiffMatrBtn.Name = "DiffMatrBtn";
			this.DiffMatrBtn.Size = new System.Drawing.Size(79, 31);
			this.DiffMatrBtn.TabIndex = 8;
			this.DiffMatrBtn.Text = "A - B";
			this.DiffMatrBtn.UseVisualStyleBackColor = false;
			this.DiffMatrBtn.Click += new System.EventHandler(this.DiffMatrBtn_Click_1);
			// 
			// SumMatrBtn
			// 
			this.SumMatrBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.SumMatrBtn.FlatAppearance.BorderSize = 0;
			this.SumMatrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SumMatrBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SumMatrBtn.Location = new System.Drawing.Point(416, 199);
			this.SumMatrBtn.Name = "SumMatrBtn";
			this.SumMatrBtn.Size = new System.Drawing.Size(79, 31);
			this.SumMatrBtn.TabIndex = 9;
			this.SumMatrBtn.Text = "A + B";
			this.SumMatrBtn.UseVisualStyleBackColor = false;
			this.SumMatrBtn.Click += new System.EventHandler(this.SumMatrBtn_Click_1);
			// 
			// ClearBtn1
			// 
			this.ClearBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClearBtn1.FlatAppearance.BorderSize = 0;
			this.ClearBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ClearBtn1.Location = new System.Drawing.Point(13, 271);
			this.ClearBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.ClearBtn1.Name = "ClearBtn1";
			this.ClearBtn1.Size = new System.Drawing.Size(105, 44);
			this.ClearBtn1.TabIndex = 10;
			this.ClearBtn1.Text = "Очистить";
			this.ClearBtn1.UseVisualStyleBackColor = false;
			this.ClearBtn1.Click += new System.EventHandler(this.ClearBtn1_Click_1);
			// 
			// RandBtn1
			// 
			this.RandBtn1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.RandBtn1.FlatAppearance.BorderSize = 0;
			this.RandBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RandBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RandBtn1.Location = new System.Drawing.Point(227, 271);
			this.RandBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.RandBtn1.Name = "RandBtn1";
			this.RandBtn1.Size = new System.Drawing.Size(105, 44);
			this.RandBtn1.TabIndex = 11;
			this.RandBtn1.Text = "Рандом";
			this.RandBtn1.UseVisualStyleBackColor = false;
			this.RandBtn1.Click += new System.EventHandler(this.RandBtn1_Click_1);
			// 
			// ChangeDimsBtn1
			// 
			this.ChangeDimsBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ChangeDimsBtn1.FlatAppearance.BorderSize = 0;
			this.ChangeDimsBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeDimsBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChangeDimsBtn1.Location = new System.Drawing.Point(120, 271);
			this.ChangeDimsBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.ChangeDimsBtn1.Name = "ChangeDimsBtn1";
			this.ChangeDimsBtn1.Size = new System.Drawing.Size(105, 44);
			this.ChangeDimsBtn1.TabIndex = 12;
			this.ChangeDimsBtn1.Text = "Изменить";
			this.ChangeDimsBtn1.UseVisualStyleBackColor = false;
			this.ChangeDimsBtn1.Click += new System.EventHandler(this.ChangeDimsBtn1_Click_1);
			// 
			// DetermBtn1
			// 
			this.DetermBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.DetermBtn1.FlatAppearance.BorderSize = 0;
			this.DetermBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DetermBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DetermBtn1.Location = new System.Drawing.Point(13, 317);
			this.DetermBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.DetermBtn1.Name = "DetermBtn1";
			this.DetermBtn1.Size = new System.Drawing.Size(105, 44);
			this.DetermBtn1.TabIndex = 16;
			this.DetermBtn1.Text = "Determinant";
			this.DetermBtn1.UseVisualStyleBackColor = false;
			this.DetermBtn1.Click += new System.EventHandler(this.DetermBtn1_Click_1);
			// 
			// InverseBtn1
			// 
			this.InverseBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.InverseBtn1.FlatAppearance.BorderSize = 0;
			this.InverseBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InverseBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.InverseBtn1.Location = new System.Drawing.Point(13, 363);
			this.InverseBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.InverseBtn1.Name = "InverseBtn1";
			this.InverseBtn1.Size = new System.Drawing.Size(105, 44);
			this.InverseBtn1.TabIndex = 17;
			this.InverseBtn1.Text = " обратная";
			this.InverseBtn1.UseVisualStyleBackColor = false;
			this.InverseBtn1.Click += new System.EventHandler(this.InverseBtn1_Click_1);
			// 
			// TransBtn1
			// 
			this.TransBtn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.TransBtn1.FlatAppearance.BorderSize = 0;
			this.TransBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TransBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TransBtn1.Location = new System.Drawing.Point(120, 317);
			this.TransBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.TransBtn1.Name = "TransBtn1";
			this.TransBtn1.Size = new System.Drawing.Size(105, 44);
			this.TransBtn1.TabIndex = 18;
			this.TransBtn1.Text = "Tranpose";
			this.TransBtn1.UseVisualStyleBackColor = false;
			this.TransBtn1.Click += new System.EventHandler(this.TransBtn1_Click_1);
			// 
			// RaiseBtn1
			// 
			this.RaiseBtn1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.RaiseBtn1.FlatAppearance.BorderSize = 0;
			this.RaiseBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RaiseBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RaiseBtn1.Location = new System.Drawing.Point(227, 363);
			this.RaiseBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.RaiseBtn1.Name = "RaiseBtn1";
			this.RaiseBtn1.Size = new System.Drawing.Size(105, 44);
			this.RaiseBtn1.TabIndex = 19;
			this.RaiseBtn1.Text = "Возвести в";
			this.RaiseBtn1.UseVisualStyleBackColor = false;
			this.RaiseBtn1.Click += new System.EventHandler(this.RaiseBtn1_Click_1);
			// 
			// MultBtn1
			// 
			this.MultBtn1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.MultBtn1.FlatAppearance.BorderSize = 0;
			this.MultBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MultBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MultBtn1.Location = new System.Drawing.Point(227, 317);
			this.MultBtn1.Margin = new System.Windows.Forms.Padding(1);
			this.MultBtn1.Name = "MultBtn1";
			this.MultBtn1.Size = new System.Drawing.Size(105, 44);
			this.MultBtn1.TabIndex = 21;
			this.MultBtn1.Text = "Умножить на";
			this.MultBtn1.UseVisualStyleBackColor = false;
			this.MultBtn1.Click += new System.EventHandler(this.MultBtn1_Click_1);
			// 
			// FromNum1
			// 
			this.FromNum1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.FromNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FromNum1.Font = new System.Drawing.Font("Tahoma", 14.5F);
			this.FromNum1.Location = new System.Drawing.Point(334, 271);
			this.FromNum1.Multiline = true;
			this.FromNum1.Name = "FromNum1";
			this.FromNum1.Size = new System.Drawing.Size(76, 24);
			this.FromNum1.TabIndex = 54;
			this.FromNum1.Text = "-10";
			this.FromNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ToNum1
			// 
			this.ToNum1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ToNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ToNum1.Font = new System.Drawing.Font("Tahoma", 14.5F);
			this.ToNum1.Location = new System.Drawing.Point(334, 291);
			this.ToNum1.Multiline = true;
			this.ToNum1.Name = "ToNum1";
			this.ToNum1.Size = new System.Drawing.Size(76, 24);
			this.ToNum1.TabIndex = 55;
			this.ToNum1.Text = "10";
			this.ToNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// RaiseNum1
			// 
			this.RaiseNum1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.RaiseNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RaiseNum1.Font = new System.Drawing.Font("Tahoma", 27F);
			this.RaiseNum1.Location = new System.Drawing.Point(334, 363);
			this.RaiseNum1.Name = "RaiseNum1";
			this.RaiseNum1.Size = new System.Drawing.Size(76, 44);
			this.RaiseNum1.TabIndex = 58;
			this.RaiseNum1.Text = "2";
			this.RaiseNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MultNum1
			// 
			this.MultNum1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.MultNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MultNum1.Font = new System.Drawing.Font("Tahoma", 27F);
			this.MultNum1.Location = new System.Drawing.Point(334, 317);
			this.MultNum1.Name = "MultNum1";
			this.MultNum1.Size = new System.Drawing.Size(76, 44);
			this.MultNum1.TabIndex = 59;
			this.MultNum1.Text = "2";
			this.MultNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MultNum2
			// 
			this.MultNum2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.MultNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MultNum2.Font = new System.Drawing.Font("Tahoma", 27F);
			this.MultNum2.Location = new System.Drawing.Point(822, 317);
			this.MultNum2.Margin = new System.Windows.Forms.Padding(1);
			this.MultNum2.Name = "MultNum2";
			this.MultNum2.Size = new System.Drawing.Size(76, 44);
			this.MultNum2.TabIndex = 74;
			this.MultNum2.Text = "2";
			this.MultNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// RaiseNum2
			// 
			this.RaiseNum2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.RaiseNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RaiseNum2.Font = new System.Drawing.Font("Tahoma", 27F);
			this.RaiseNum2.Location = new System.Drawing.Point(822, 363);
			this.RaiseNum2.Margin = new System.Windows.Forms.Padding(1);
			this.RaiseNum2.Name = "RaiseNum2";
			this.RaiseNum2.Size = new System.Drawing.Size(76, 44);
			this.RaiseNum2.TabIndex = 73;
			this.RaiseNum2.Text = "2";
			this.RaiseNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ToNum2
			// 
			this.ToNum2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ToNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ToNum2.Font = new System.Drawing.Font("Tahoma", 14.5F);
			this.ToNum2.Location = new System.Drawing.Point(822, 291);
			this.ToNum2.Margin = new System.Windows.Forms.Padding(1);
			this.ToNum2.Name = "ToNum2";
			this.ToNum2.Size = new System.Drawing.Size(76, 24);
			this.ToNum2.TabIndex = 70;
			this.ToNum2.Text = "10";
			this.ToNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// FromNum2
			// 
			this.FromNum2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.FromNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FromNum2.Font = new System.Drawing.Font("Tahoma", 14.5F);
			this.FromNum2.Location = new System.Drawing.Point(822, 271);
			this.FromNum2.Margin = new System.Windows.Forms.Padding(1);
			this.FromNum2.Name = "FromNum2";
			this.FromNum2.Size = new System.Drawing.Size(76, 24);
			this.FromNum2.TabIndex = 69;
			this.FromNum2.Text = "-10";
			this.FromNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MultBtn2
			// 
			this.MultBtn2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.MultBtn2.FlatAppearance.BorderSize = 0;
			this.MultBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MultBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.MultBtn2.Location = new System.Drawing.Point(715, 317);
			this.MultBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.MultBtn2.Name = "MultBtn2";
			this.MultBtn2.Size = new System.Drawing.Size(105, 44);
			this.MultBtn2.TabIndex = 68;
			this.MultBtn2.Text = "Умножить на";
			this.MultBtn2.UseVisualStyleBackColor = false;
			this.MultBtn2.Click += new System.EventHandler(this.MultBtn2_Click_1);
			// 
			// RaiseBtn2
			// 
			this.RaiseBtn2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.RaiseBtn2.FlatAppearance.BorderSize = 0;
			this.RaiseBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RaiseBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.RaiseBtn2.Location = new System.Drawing.Point(715, 363);
			this.RaiseBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.RaiseBtn2.Name = "RaiseBtn2";
			this.RaiseBtn2.Size = new System.Drawing.Size(105, 44);
			this.RaiseBtn2.TabIndex = 66;
			this.RaiseBtn2.Text = "Возвести в";
			this.RaiseBtn2.UseVisualStyleBackColor = false;
			this.RaiseBtn2.Click += new System.EventHandler(this.RaiseBtn2_Click_1);
			// 
			// TransBtn2
			// 
			this.TransBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.TransBtn2.FlatAppearance.BorderSize = 0;
			this.TransBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TransBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.TransBtn2.Location = new System.Drawing.Point(608, 317);
			this.TransBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.TransBtn2.Name = "TransBtn2";
			this.TransBtn2.Size = new System.Drawing.Size(105, 44);
			this.TransBtn2.TabIndex = 65;
			this.TransBtn2.Text = "Traspose";
			this.TransBtn2.UseVisualStyleBackColor = false;
			this.TransBtn2.Click += new System.EventHandler(this.TransBtn2_Click_1);
			// 
			// InverseBtn2
			// 
			this.InverseBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.InverseBtn2.FlatAppearance.BorderSize = 0;
			this.InverseBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InverseBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.InverseBtn2.Location = new System.Drawing.Point(501, 363);
			this.InverseBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.InverseBtn2.Name = "InverseBtn2";
			this.InverseBtn2.Size = new System.Drawing.Size(105, 44);
			this.InverseBtn2.TabIndex = 64;
			this.InverseBtn2.Text = "Обратная";
			this.InverseBtn2.UseVisualStyleBackColor = false;
			this.InverseBtn2.Click += new System.EventHandler(this.InverseBtn2_Click_1);
			// 
			// DetermBtn2
			// 
			this.DetermBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.DetermBtn2.FlatAppearance.BorderSize = 0;
			this.DetermBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DetermBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.DetermBtn2.Location = new System.Drawing.Point(501, 317);
			this.DetermBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.DetermBtn2.Name = "DetermBtn2";
			this.DetermBtn2.Size = new System.Drawing.Size(105, 44);
			this.DetermBtn2.TabIndex = 63;
			this.DetermBtn2.Text = "Determinant";
			this.DetermBtn2.UseVisualStyleBackColor = false;
			this.DetermBtn2.Click += new System.EventHandler(this.DetermBtn2_Click_1);
			// 
			// ChangeDimsBtn2
			// 
			this.ChangeDimsBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ChangeDimsBtn2.FlatAppearance.BorderSize = 0;
			this.ChangeDimsBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeDimsBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.ChangeDimsBtn2.Location = new System.Drawing.Point(608, 271);
			this.ChangeDimsBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.ChangeDimsBtn2.Name = "ChangeDimsBtn2";
			this.ChangeDimsBtn2.Size = new System.Drawing.Size(105, 44);
			this.ChangeDimsBtn2.TabIndex = 62;
			this.ChangeDimsBtn2.Text = "Изменить";
			this.ChangeDimsBtn2.UseVisualStyleBackColor = false;
			this.ChangeDimsBtn2.Click += new System.EventHandler(this.ChangeDimsBtn2_Click_1);
			// 
			// RandBtn2
			// 
			this.RandBtn2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.RandBtn2.FlatAppearance.BorderSize = 0;
			this.RandBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RandBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.RandBtn2.Location = new System.Drawing.Point(715, 271);
			this.RandBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.RandBtn2.Name = "RandBtn2";
			this.RandBtn2.Size = new System.Drawing.Size(105, 44);
			this.RandBtn2.TabIndex = 61;
			this.RandBtn2.Text = "Рандом";
			this.RandBtn2.UseVisualStyleBackColor = false;
			this.RandBtn2.Click += new System.EventHandler(this.RandBtn2_Click_1);
			// 
			// ClearBtn2
			// 
			this.ClearBtn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClearBtn2.FlatAppearance.BorderSize = 0;
			this.ClearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearBtn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.ClearBtn2.Location = new System.Drawing.Point(501, 271);
			this.ClearBtn2.Margin = new System.Windows.Forms.Padding(1);
			this.ClearBtn2.Name = "ClearBtn2";
			this.ClearBtn2.Size = new System.Drawing.Size(105, 44);
			this.ClearBtn2.TabIndex = 60;
			this.ClearBtn2.Text = "Очистить";
			this.ClearBtn2.UseVisualStyleBackColor = false;
			this.ClearBtn2.Click += new System.EventHandler(this.ClearBtn2_Click_1);
			// 
			// Triangle1
			// 
			this.Triangle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Triangle1.FlatAppearance.BorderSize = 0;
			this.Triangle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Triangle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Triangle1.Location = new System.Drawing.Point(120, 363);
			this.Triangle1.Margin = new System.Windows.Forms.Padding(1);
			this.Triangle1.Name = "Triangle1";
			this.Triangle1.Size = new System.Drawing.Size(105, 44);
			this.Triangle1.TabIndex = 77;
			this.Triangle1.Text = "Треугольный вид";
			this.Triangle1.UseVisualStyleBackColor = false;
			this.Triangle1.Click += new System.EventHandler(this.Triangle1_Click);
			// 
			// Triangle2
			// 
			this.Triangle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Triangle2.FlatAppearance.BorderSize = 0;
			this.Triangle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Triangle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.Triangle2.Location = new System.Drawing.Point(608, 363);
			this.Triangle2.Margin = new System.Windows.Forms.Padding(1);
			this.Triangle2.Name = "Triangle2";
			this.Triangle2.Size = new System.Drawing.Size(105, 44);
			this.Triangle2.TabIndex = 79;
			this.Triangle2.Text = "Треугольный вид";
			this.Triangle2.UseVisualStyleBackColor = false;
			this.Triangle2.Click += new System.EventHandler(this.Triangle2_Click);
			// 
			// CopyToA
			// 
			this.CopyToA.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.CopyToA.FlatAppearance.BorderSize = 0;
			this.CopyToA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopyToA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.CopyToA.Location = new System.Drawing.Point(266, 443);
			this.CopyToA.Margin = new System.Windows.Forms.Padding(1);
			this.CopyToA.Name = "CopyToA";
			this.CopyToA.Size = new System.Drawing.Size(131, 44);
			this.CopyToA.TabIndex = 82;
			this.CopyToA.Text = "Скопировать В A";
			this.CopyToA.UseVisualStyleBackColor = false;
			this.CopyToA.Click += new System.EventHandler(this.CopyToA_Click);
			// 
			// CopyToB
			// 
			this.CopyToB.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.CopyToB.FlatAppearance.BorderSize = 0;
			this.CopyToB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopyToB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.CopyToB.Location = new System.Drawing.Point(532, 443);
			this.CopyToB.Margin = new System.Windows.Forms.Padding(1);
			this.CopyToB.Name = "CopyToB";
			this.CopyToB.Size = new System.Drawing.Size(131, 44);
			this.CopyToB.TabIndex = 83;
			this.CopyToB.Text = "Скопировать в B";
			this.CopyToB.UseVisualStyleBackColor = false;
			this.CopyToB.Click += new System.EventHandler(this.CopyToB_Click);
			// 
			// ResultNum1
			// 
			this.ResultNum1.BackColor = System.Drawing.Color.Gray;
			this.ResultNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ResultNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.ResultNum1.Location = new System.Drawing.Point(206, 415);
			this.ResultNum1.Name = "ResultNum1";
			this.ResultNum1.Size = new System.Drawing.Size(91, 24);
			this.ResultNum1.TabIndex = 84;
			this.ResultNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ResultNum2
			// 
			this.ResultNum2.BackColor = System.Drawing.Color.Gray;
			this.ResultNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ResultNum2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ResultNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.ResultNum2.Location = new System.Drawing.Point(691, 415);
			this.ResultNum2.Name = "ResultNum2";
			this.ResultNum2.Size = new System.Drawing.Size(91, 24);
			this.ResultNum2.TabIndex = 85;
			this.ResultNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(9, 415);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 24);
			this.label4.TabIndex = 86;
			this.label4.Text = "Определитель А:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(497, 415);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 24);
			this.label3.TabIndex = 87;
			this.label3.Text = "Определитель В:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.ColumnHeadersVisible = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.NullValue = "0";
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.Location = new System.Drawing.Point(13, 59);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(397, 208);
			this.dataGridView1.TabIndex = 88;
			this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded_1);
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved_1);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.BackgroundColor = System.Drawing.Color.Gray;
			this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView2.ColumnHeadersVisible = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.NullValue = "0";
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView2.Location = new System.Drawing.Point(501, 59);
			this.dataGridView2.Name = "dataGridView2";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(397, 208);
			this.dataGridView2.TabIndex = 89;
			this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded_1);
			this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AllowUserToResizeColumns = false;
			this.dataGridView3.AllowUserToResizeRows = false;
			this.dataGridView3.BackgroundColor = System.Drawing.Color.Gray;
			this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView3.ColumnHeadersVisible = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView3.Location = new System.Drawing.Point(266, 491);
			this.dataGridView3.Name = "dataGridView3";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView3.RowHeadersVisible = false;
			this.dataGridView3.RowTemplate.Height = 23;
			this.dataGridView3.Size = new System.Drawing.Size(397, 208);
			this.dataGridView3.TabIndex = 90;
			this.dataGridView3.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView3_RowsAdded_1);
			this.dataGridView3.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView3_RowsRemoved_1);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(914, 24);
			this.menuStrip1.TabIndex = 91;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(914, 714);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ResultNum2);
			this.Controls.Add(this.ResultNum1);
			this.Controls.Add(this.CopyToB);
			this.Controls.Add(this.CopyToA);
			this.Controls.Add(this.Triangle2);
			this.Controls.Add(this.Triangle1);
			this.Controls.Add(this.MultNum2);
			this.Controls.Add(this.RaiseNum2);
			this.Controls.Add(this.ToNum2);
			this.Controls.Add(this.FromNum2);
			this.Controls.Add(this.MultBtn2);
			this.Controls.Add(this.RaiseBtn2);
			this.Controls.Add(this.TransBtn2);
			this.Controls.Add(this.InverseBtn2);
			this.Controls.Add(this.DetermBtn2);
			this.Controls.Add(this.ChangeDimsBtn2);
			this.Controls.Add(this.RandBtn2);
			this.Controls.Add(this.ClearBtn2);
			this.Controls.Add(this.MultNum1);
			this.Controls.Add(this.RaiseNum1);
			this.Controls.Add(this.ToNum1);
			this.Controls.Add(this.FromNum1);
			this.Controls.Add(this.MultBtn1);
			this.Controls.Add(this.RaiseBtn1);
			this.Controls.Add(this.TransBtn1);
			this.Controls.Add(this.InverseBtn1);
			this.Controls.Add(this.DetermBtn1);
			this.Controls.Add(this.ChangeDimsBtn1);
			this.Controls.Add(this.RandBtn1);
			this.Controls.Add(this.ClearBtn1);
			this.Controls.Add(this.SumMatrBtn);
			this.Controls.Add(this.DiffMatrBtn);
			this.Controls.Add(this.MultMatrBtn);
			this.Controls.Add(this.Replace);
			this.Controls.Add(this.MatrixResult);
			this.Controls.Add(this.MatrixB);
			this.Controls.Add(this.MatrixA);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MatrixA;
        private System.Windows.Forms.Label MatrixB;
        private System.Windows.Forms.Label MatrixResult;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button MultMatrBtn;
        private System.Windows.Forms.Button DiffMatrBtn;
        private System.Windows.Forms.Button SumMatrBtn;
        private System.Windows.Forms.Button ClearBtn1;
        private System.Windows.Forms.Button RandBtn1;
        private System.Windows.Forms.Button ChangeDimsBtn1;
        private System.Windows.Forms.Button DetermBtn1;
        private System.Windows.Forms.Button InverseBtn1;
        private System.Windows.Forms.Button TransBtn1;
        private System.Windows.Forms.Button RaiseBtn1;
        private System.Windows.Forms.Button MultBtn1;
        private System.Windows.Forms.TextBox FromNum1;
        private System.Windows.Forms.TextBox ToNum1;
        private System.Windows.Forms.TextBox RaiseNum1;
        private System.Windows.Forms.TextBox MultNum1;
        private System.Windows.Forms.TextBox MultNum2;
        private System.Windows.Forms.TextBox RaiseNum2;
        private System.Windows.Forms.TextBox ToNum2;
        private System.Windows.Forms.TextBox FromNum2;
        private System.Windows.Forms.Button MultBtn2;
        private System.Windows.Forms.Button RaiseBtn2;
        private System.Windows.Forms.Button TransBtn2;
        private System.Windows.Forms.Button InverseBtn2;
        private System.Windows.Forms.Button DetermBtn2;
        private System.Windows.Forms.Button ChangeDimsBtn2;
        private System.Windows.Forms.Button RandBtn2;
        private System.Windows.Forms.Button ClearBtn2;
        private System.Windows.Forms.Button Triangle1;
        private System.Windows.Forms.Button Triangle2;
        private System.Windows.Forms.Button CopyToA;
        private System.Windows.Forms.Button CopyToB;
        private System.Windows.Forms.TextBox ResultNum1;
        private System.Windows.Forms.TextBox ResultNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

