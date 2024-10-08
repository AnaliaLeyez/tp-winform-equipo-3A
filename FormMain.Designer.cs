﻿namespace TpWinForms
{
    partial class FormArticles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticles));
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.pboxImg = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboxField = new System.Windows.Forms.ComboBox();
            this.cboxMatch = new System.Windows.Forms.ComboBox();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblAdvFilter = new System.Windows.Forms.Label();
            this.txtAdvFilter = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFastFilter = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.categToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.AllowUserToResizeColumns = false;
            this.dgvArticles.AllowUserToResizeRows = false;
            this.dgvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.EnableHeadersVisualStyles = false;
            this.dgvArticles.Location = new System.Drawing.Point(12, 88);
            this.dgvArticles.MultiSelect = false;
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.RowHeadersWidth = 82;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(404, 184);
            this.dgvArticles.TabIndex = 0;
            this.dgvArticles.SelectionChanged += new System.EventHandler(this.dgvArticles_SelectionChanged);
            // 
            // pboxImg
            // 
            this.pboxImg.Location = new System.Drawing.Point(460, 88);
            this.pboxImg.Margin = new System.Windows.Forms.Padding(2);
            this.pboxImg.Name = "pboxImg";
            this.pboxImg.Size = new System.Drawing.Size(189, 184);
            this.pboxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImg.TabIndex = 1;
            this.pboxImg.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(103, 305);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.ForeColor = System.Drawing.Color.Black;
            this.lblField.Location = new System.Drawing.Point(28, 30);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(34, 15);
            this.lblField.TabIndex = 33;
            this.lblField.Text = "Field";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(592, 28);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(47, 27);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "Find";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboxField
            // 
            this.cboxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxField.FormattingEnabled = true;
            this.cboxField.Location = new System.Drawing.Point(80, 30);
            this.cboxField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxField.Name = "cboxField";
            this.cboxField.Size = new System.Drawing.Size(89, 21);
            this.cboxField.TabIndex = 32;
            this.cboxField.SelectedIndexChanged += new System.EventHandler(this.cboxField_SelectedIndexChanged);
            // 
            // cboxMatch
            // 
            this.cboxMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMatch.FormattingEnabled = true;
            this.cboxMatch.Location = new System.Drawing.Point(232, 32);
            this.cboxMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxMatch.Name = "cboxMatch";
            this.cboxMatch.Size = new System.Drawing.Size(100, 21);
            this.cboxMatch.TabIndex = 34;
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.ForeColor = System.Drawing.Color.Black;
            this.lblMatch.Location = new System.Drawing.Point(185, 33);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(41, 15);
            this.lblMatch.TabIndex = 35;
            this.lblMatch.Text = "Match";
            // 
            // lblAdvFilter
            // 
            this.lblAdvFilter.AutoSize = true;
            this.lblAdvFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvFilter.ForeColor = System.Drawing.Color.Black;
            this.lblAdvFilter.Location = new System.Drawing.Point(346, 33);
            this.lblAdvFilter.Name = "lblAdvFilter";
            this.lblAdvFilter.Size = new System.Drawing.Size(34, 15);
            this.lblAdvFilter.TabIndex = 36;
            this.lblAdvFilter.Text = "Filter";
            // 
            // txtAdvFilter
            // 
            this.txtAdvFilter.Location = new System.Drawing.Point(382, 33);
            this.txtAdvFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdvFilter.Name = "txtAdvFilter";
            this.txtAdvFilter.Size = new System.Drawing.Size(200, 20);
            this.txtAdvFilter.TabIndex = 37;
            this.txtAdvFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvFilter_KeyPress);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.Location = new System.Drawing.Point(172, 61);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(274, 23);
            this.txtFilter.TabIndex = 38;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFastFilter
            // 
            this.lblFastFilter.AutoSize = true;
            this.lblFastFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastFilter.Location = new System.Drawing.Point(87, 61);
            this.lblFastFilter.Name = "lblFastFilter";
            this.lblFastFilter.Size = new System.Drawing.Size(67, 15);
            this.lblFastFilter.TabIndex = 39;
            this.lblFastFilter.Text = "Fast filter";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(292, 305);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 40;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categToolStrip,
            this.brandsToolStrip});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(50, 22);
            this.tsmMenu.Text = "Menu";
            // 
            // categToolStrip
            // 
            this.categToolStrip.Name = "categToolStrip";
            this.categToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.categToolStrip.Size = new System.Drawing.Size(172, 22);
            this.categToolStrip.Text = "&Categories";
            this.categToolStrip.Click += new System.EventHandler(this.categToolStrip_Click);
            // 
            // brandsToolStrip
            // 
            this.brandsToolStrip.Name = "brandsToolStrip";
            this.brandsToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.brandsToolStrip.Size = new System.Drawing.Size(172, 22);
            this.brandsToolStrip.Text = "&Brands";
            this.brandsToolStrip.Click += new System.EventHandler(this.brandsToolStrip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblFastFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboxField);
            this.Controls.Add(this.cboxMatch);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.lblAdvFilter);
            this.Controls.Add(this.txtAdvFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pboxImg);
            this.Controls.Add(this.dgvArticles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(755, 489);
            this.MinimumSize = new System.Drawing.Size(755, 489);
            this.Name = "FormArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles Administrator";
            this.Load += new System.EventHandler(this.FormArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.PictureBox pboxImg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboxField;
        private System.Windows.Forms.ComboBox cboxMatch;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblAdvFilter;
        private System.Windows.Forms.TextBox txtAdvFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFastFilter;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem categToolStrip;
        private System.Windows.Forms.ToolStripMenuItem brandsToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

