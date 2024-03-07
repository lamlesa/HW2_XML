namespace HW2_XML
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("ст. 228");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ст. 230");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("ст. 231");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Статьи", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Жировая дистрофия");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Цирроз печени");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Гепатит");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Смерть");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Побочные действия", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Tree = new System.Windows.Forms.TreeView();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.InfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.Indent = 19;
            this.Tree.Location = new System.Drawing.Point(29, 196);
            this.Tree.Name = "Tree";
            treeNode19.Name = "Узел1";
            treeNode19.Text = "ст. 228";
            treeNode20.Name = "Узел2";
            treeNode20.Text = "ст. 230";
            treeNode21.Name = "Узел3";
            treeNode21.Text = "ст. 231";
            treeNode22.BackColor = System.Drawing.Color.MediumAquamarine;
            treeNode22.Name = "Узел0";
            treeNode22.Text = "Статьи";
            treeNode23.Name = "Узел5";
            treeNode23.Text = "Жировая дистрофия";
            treeNode24.Name = "Узел6";
            treeNode24.Text = "Цирроз печени";
            treeNode25.Name = "Узел1";
            treeNode25.Text = "Гепатит";
            treeNode26.Name = "Узел4";
            treeNode26.Text = "Смерть";
            treeNode27.BackColor = System.Drawing.Color.MediumAquamarine;
            treeNode27.Name = "Узел4";
            treeNode27.Text = "Побочные действия";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode27});
            this.Tree.Size = new System.Drawing.Size(252, 211);
            this.Tree.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.Khaki;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(21, 23);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.Size = new System.Drawing.Size(415, 322);
            this.DataGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Таблица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(3, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(306, 177);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 3;
            this.Picture.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // SplitContainer
            // 
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer.Location = new System.Drawing.Point(12, 12);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.Picture);
            this.SplitContainer.Panel1.Controls.Add(this.Tree);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.InfoButton);
            this.SplitContainer.Panel2.Controls.Add(this.DataGrid);
            this.SplitContainer.Panel2.Controls.Add(this.button1);
            this.SplitContainer.Size = new System.Drawing.Size(776, 426);
            this.SplitContainer.SplitterDistance = 314;
            this.SplitContainer.TabIndex = 5;
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Red;
            this.InfoButton.Location = new System.Drawing.Point(39, 363);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(166, 44);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Информация";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.Info_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.SplitContainer);
            this.Name = "MainForm";
            this.Text = "Пособие для начинающих";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Button InfoButton;
    }
}

