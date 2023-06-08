namespace TrabalhoTopicoLinguagem01
{
    partial class formListaUsuarios
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
            this.topoPanel = new System.Windows.Forms.Panel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.pesquisaTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.fecharButton = new System.Windows.Forms.Button();
            this.rodapePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.topoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.botoesPanel.SuspendLayout();
            this.rodapePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // topoPanel
            // 
            this.topoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topoPanel.Controls.Add(this.buscarButton);
            this.topoPanel.Controls.Add(this.pesquisaTextBox);
            this.topoPanel.Controls.Add(this.nomeLabel);
            this.topoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topoPanel.Location = new System.Drawing.Point(0, 0);
            this.topoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topoPanel.Name = "topoPanel";
            this.topoPanel.Size = new System.Drawing.Size(961, 84);
            this.topoPanel.TabIndex = 6;
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Buscar;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(472, 27);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 31);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // pesquisaTextBox
            // 
            this.pesquisaTextBox.Location = new System.Drawing.Point(23, 31);
            this.pesquisaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisaTextBox.Name = "pesquisaTextBox";
            this.pesquisaTextBox.Size = new System.Drawing.Size(447, 22);
            this.pesquisaTextBox.TabIndex = 1;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(16, 11);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(131, 16);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Pesquise pelo nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(961, 438);
            this.dataGridView1.TabIndex = 5;
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.fecharButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.botoesPanel.Location = new System.Drawing.Point(680, 0);
            this.botoesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(281, 59);
            this.botoesPanel.TabIndex = 1;
            // 
            // fecharButton
            // 
            this.fecharButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fecharButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Excluir;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(168, 15);
            this.fecharButton.Margin = new System.Windows.Forms.Padding(4);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(100, 37);
            this.fecharButton.TabIndex = 6;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // rodapePanel
            // 
            this.rodapePanel.Controls.Add(this.botoesPanel);
            this.rodapePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodapePanel.Location = new System.Drawing.Point(0, 438);
            this.rodapePanel.Margin = new System.Windows.Forms.Padding(4);
            this.rodapePanel.Name = "rodapePanel";
            this.rodapePanel.Size = new System.Drawing.Size(961, 59);
            this.rodapePanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 354);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(961, 354);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // formListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topoPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rodapePanel);
            this.Name = "formListaUsuarios";
            this.Text = "Lista usuarios";
            this.topoPanel.ResumeLayout(false);
            this.topoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.botoesPanel.ResumeLayout(false);
            this.rodapePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topoPanel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox pesquisaTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Panel rodapePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
    }
}