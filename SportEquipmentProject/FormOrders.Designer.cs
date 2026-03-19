namespace SportEquipmentProject
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            panelTop = new Panel();
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnLogout = new Button();
            lblUsername = new Label();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            panelTop.SuspendLayout();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(233, 245, 255);
            panelTop.Controls.Add(flowLayoutPanelTop);
            panelTop.Controls.Add(flowLayoutPanelButtons);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1123, 65);
            panelTop.TabIndex = 4;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.BackColor = Color.Transparent;
            flowLayoutPanelTop.Controls.Add(btnLogout);
            flowLayoutPanelTop.Controls.Add(lblUsername);
            flowLayoutPanelTop.Dock = DockStyle.Right;
            flowLayoutPanelTop.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelTop.Location = new Point(538, 0);
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
            flowLayoutPanelButtons.Dock = DockStyle.Left;
            flowLayoutPanelButtons.Location = new Point(0, 0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(576, 65);
            flowLayoutPanelButtons.TabIndex = 2;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1143, 630);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormOrders";
            Padding = new Padding(10);
            Text = "Заказы";
            panelTop.ResumeLayout(false);
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnLogout;
        private Label lblUsername;
        private FlowLayoutPanel flowLayoutPanelButtons;
    }
}