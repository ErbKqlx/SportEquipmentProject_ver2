namespace SportEquipmentProject
{
    partial class FormProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnLogout = new Button();
            lblUsername = new Label();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            btnGetOrders = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            panelTop = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.BackColor = Color.Transparent;
            flowLayoutPanelTop.Controls.Add(btnLogout);
            flowLayoutPanelTop.Controls.Add(lblUsername);
            flowLayoutPanelTop.Dock = DockStyle.Right;
            flowLayoutPanelTop.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelTop.Location = new Point(579, 0);
            flowLayoutPanelTop.Margin = new Padding(0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(585, 65);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(67, 97, 238);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(456, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 57);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Выход";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(399, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(51, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "ФИО";
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(btnGetOrders);
            flowLayoutPanelButtons.Controls.Add(btnAdd);
            flowLayoutPanelButtons.Controls.Add(btnEdit);
            flowLayoutPanelButtons.Controls.Add(btnDelete);
            flowLayoutPanelButtons.Dock = DockStyle.Left;
            flowLayoutPanelButtons.Location = new Point(0, 0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(576, 65);
            flowLayoutPanelButtons.TabIndex = 2;
            // 
            // btnGetOrders
            // 
            btnGetOrders.BackColor = Color.FromArgb(67, 97, 238);
            btnGetOrders.FlatAppearance.BorderSize = 0;
            btnGetOrders.FlatStyle = FlatStyle.Flat;
            btnGetOrders.Location = new Point(3, 3);
            btnGetOrders.Name = "btnGetOrders";
            btnGetOrders.Size = new Size(126, 59);
            btnGetOrders.TabIndex = 1;
            btnGetOrders.Text = "Заказы";
            btnGetOrders.UseVisualStyleBackColor = false;
            btnGetOrders.Click += BtnGetOrders_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(67, 97, 238);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(135, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 59);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(67, 97, 238);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(267, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 59);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(67, 97, 238);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(423, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 59);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(67, 97, 238);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Location = new Point(10, 75);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1164, 676);
            dgvProducts.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(233, 245, 255);
            panelTop.Controls.Add(flowLayoutPanelTop);
            panelTop.Controls.Add(flowLayoutPanelButtons);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1164, 65);
            panelTop.TabIndex = 3;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1184, 749);
            Controls.Add(panelTop);
            Controls.Add(dgvProducts);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormProducts";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnLogout;
        private Label lblUsername;
        private DataGridView dgvProducts;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button btnGetOrders;
        private Panel panelTop;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}