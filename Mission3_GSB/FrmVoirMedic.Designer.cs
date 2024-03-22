
namespace Mission3_GSB
{
    partial class FrmVoirMedic
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceVMedic = new System.Windows.Forms.BindingSource(this.components);
            this.cmBxFam = new System.Windows.Forms.ComboBox();
            this.bdgSourceFamille = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grBFiltre = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.bdgSourceOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.lblCountResult = new System.Windows.Forms.Label();
            this.btnXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceFamille)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grBFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Location = new System.Drawing.Point(737, 800);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(228, 52);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgSourceVMedic;
            this.dataGridView1.Location = new System.Drawing.Point(0, 295);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 439);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            this.idFamilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            this.compositionDataGridViewTextBoxColumn.Visible = false;
            this.compositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            this.effetsDataGridViewTextBoxColumn.Visible = false;
            this.effetsDataGridViewTextBoxColumn.Width = 125;
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "famille";
            this.familleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            this.familleDataGridViewTextBoxColumn.Visible = false;
            this.familleDataGridViewTextBoxColumn.Width = 125;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.Visible = false;
            this.contreIndicationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdgSourceVMedic
            // 
            this.bdgSourceVMedic.DataSource = typeof(Mission3_GSB.medicament);
            // 
            // cmBxFam
            // 
            this.cmBxFam.DataSource = this.bdgSourceFamille;
            this.cmBxFam.DisplayMember = "id";
            this.cmBxFam.FormattingEnabled = true;
            this.cmBxFam.Location = new System.Drawing.Point(99, 54);
            this.cmBxFam.Margin = new System.Windows.Forms.Padding(4);
            this.cmBxFam.Name = "cmBxFam";
            this.cmBxFam.Size = new System.Drawing.Size(160, 24);
            this.cmBxFam.TabIndex = 4;
            this.cmBxFam.SelectedIndexChanged += new System.EventHandler(this.cmBxFam_SelectedIndexChanged);
            // 
            // bdgSourceFamille
            // 
            this.bdgSourceFamille.DataSource = typeof(Mission3_GSB.famille);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Famille";
            // 
            // btnAddFam
            // 
            this.btnAddFam.Location = new System.Drawing.Point(280, 53);
            this.btnAddFam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFam.Name = "btnAddFam";
            this.btnAddFam.Size = new System.Drawing.Size(100, 28);
            this.btnAddFam.TabIndex = 6;
            this.btnAddFam.Text = "Ajouter";
            this.btnAddFam.UseVisualStyleBackColor = true;
            this.btnAddFam.Click += new System.EventHandler(this.btnAddFam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddFam);
            this.groupBox1.Controls.Add(this.cmBxFam);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Famille";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 801);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 53);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(128, 801);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(113, 53);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 801);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 53);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grBFiltre
            // 
            this.grBFiltre.Controls.Add(this.lblError);
            this.grBFiltre.Controls.Add(this.txtFiltre);
            this.grBFiltre.Controls.Add(this.lblRecherche);
            this.grBFiltre.Location = new System.Drawing.Point(7, 137);
            this.grBFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.grBFiltre.Name = "grBFiltre";
            this.grBFiltre.Padding = new System.Windows.Forms.Padding(4);
            this.grBFiltre.Size = new System.Drawing.Size(407, 123);
            this.grBFiltre.TabIndex = 8;
            this.grBFiltre.TabStop = false;
            this.grBFiltre.Text = "Filtre";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(85, 95);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 7;
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(115, 55);
            this.txtFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(163, 22);
            this.txtFiltre.TabIndex = 6;
            this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(16, 59);
            this.lblRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(73, 16);
            this.lblRecherche.TabIndex = 5;
            this.lblRecherche.Text = "Recherche";
            // 
            // bdgSourceOffrir
            // 
            this.bdgSourceOffrir.DataSource = typeof(Mission3_GSB.offrir);
            // 
            // lblCountResult
            // 
            this.lblCountResult.AutoSize = true;
            this.lblCountResult.Location = new System.Drawing.Point(16, 279);
            this.lblCountResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountResult.Name = "lblCountResult";
            this.lblCountResult.Size = new System.Drawing.Size(0, 16);
            this.lblCountResult.TabIndex = 11;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(370, 800);
            this.btnXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(113, 53);
            this.btnXml.TabIndex = 12;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // FrmVoirMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 883);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCountResult);
            this.Controls.Add(this.grBFiltre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFermer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVoirMedic";
            this.Text = "FrmVoirMedic";
            this.Load += new System.EventHandler(this.FrmVoirMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceFamille)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grBFiltre.ResumeLayout(false);
            this.grBFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceOffrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.BindingSource bdgSourceVMedic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmBxFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdgSourceOffrir;
        private System.Windows.Forms.BindingSource bdgSourceFamille;
        private System.Windows.Forms.Button btnAddFam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grBFiltre;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblCountResult;
        private System.Windows.Forms.Button btnXml;
    }
}