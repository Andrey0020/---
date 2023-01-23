
namespace Demo_exam
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.updateBtn = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonchage = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.demo_examDataSet = new Demo_exam.demo_examDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Demo_exam.demo_examDataSetTableAdapters.productsTableAdapter();
            this.наименованиепродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальнаястоимостьдляагентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типпродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествочеловекдляпроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерцехадляпроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // updateBtn
            // 
            this.updateBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 22);
            this.updateBtn.Text = "Обновить данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиепродукцииDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.минимальнаястоимостьдляагентаDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn,
            this.типпродукцииDataGridViewTextBoxColumn,
            this.количествочеловекдляпроизводстваDataGridViewTextBoxColumn,
            this.номерцехадляпроизводстваDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 470);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.White;
            this.buttonadd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.buttonadd.Location = new System.Drawing.Point(174, 574);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(106, 33);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "Добавить запись";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonchage
            // 
            this.buttonchage.BackColor = System.Drawing.Color.White;
            this.buttonchage.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.buttonchage.Location = new System.Drawing.Point(286, 574);
            this.buttonchage.Name = "buttonchage";
            this.buttonchage.Size = new System.Drawing.Size(106, 33);
            this.buttonchage.TabIndex = 3;
            this.buttonchage.Text = "Изменить";
            this.buttonchage.UseVisualStyleBackColor = false;
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.White;
            this.buttonsave.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.buttonsave.Location = new System.Drawing.Point(398, 574);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(106, 33);
            this.buttonsave.TabIndex = 4;
            this.buttonsave.Text = "Сохранить";
            this.buttonsave.UseVisualStyleBackColor = false;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.White;
            this.buttondelete.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.buttondelete.Location = new System.Drawing.Point(510, 574);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(106, 33);
            this.buttondelete.TabIndex = 5;
            this.buttondelete.Text = "Удалить";
            this.buttondelete.UseVisualStyleBackColor = false;
            // 
            // demo_examDataSet
            // 
            this.demo_examDataSet.DataSetName = "demo_examDataSet";
            this.demo_examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.demo_examDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // наименованиепродукцииDataGridViewTextBoxColumn
            // 
            this.наименованиепродукцииDataGridViewTextBoxColumn.DataPropertyName = "Наименование_продукции";
            this.наименованиепродукцииDataGridViewTextBoxColumn.HeaderText = "Наименование_продукции";
            this.наименованиепродукцииDataGridViewTextBoxColumn.Name = "наименованиепродукцииDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // минимальнаястоимостьдляагентаDataGridViewTextBoxColumn
            // 
            this.минимальнаястоимостьдляагентаDataGridViewTextBoxColumn.DataPropertyName = "Минимальная_стоимость_для_агента";
            this.минимальнаястоимостьдляагентаDataGridViewTextBoxColumn.HeaderText = "Минимальная_стоимость_для_агента";
            this.минимальнаястоимостьдляагентаDataGridViewTextBoxColumn.Name = "минимальнаястоимостьдляагентаDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            // 
            // типпродукцииDataGridViewTextBoxColumn
            // 
            this.типпродукцииDataGridViewTextBoxColumn.DataPropertyName = "Тип_продукции";
            this.типпродукцииDataGridViewTextBoxColumn.HeaderText = "Тип_продукции";
            this.типпродукцииDataGridViewTextBoxColumn.Name = "типпродукцииDataGridViewTextBoxColumn";
            // 
            // количествочеловекдляпроизводстваDataGridViewTextBoxColumn
            // 
            this.количествочеловекдляпроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Количество_человек_для_производства";
            this.количествочеловекдляпроизводстваDataGridViewTextBoxColumn.HeaderText = "Количество_человек_для_производства";
            this.количествочеловекдляпроизводстваDataGridViewTextBoxColumn.Name = "количествочеловекдляпроизводстваDataGridViewTextBoxColumn";
            // 
            // номерцехадляпроизводстваDataGridViewTextBoxColumn
            // 
            this.номерцехадляпроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Номер_цеха_для_производства";
            this.номерцехадляпроизводстваDataGridViewTextBoxColumn.HeaderText = "Номер_цеха_для_производства";
            this.номерцехадляпроизводстваDataGridViewTextBoxColumn.Name = "номерцехадляпроизводстваDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Управление данными";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttonchage);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonchage;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttondelete;
        private demo_examDataSet demo_examDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private demo_examDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиепродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальнаястоимостьдляагентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типпродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествочеловекдляпроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерцехадляпроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}