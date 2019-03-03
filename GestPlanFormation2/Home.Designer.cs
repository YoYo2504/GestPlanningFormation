namespace GestPlanFormation
{
    partial class Home
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
            this.Connect = new System.Windows.Forms.Button();
            this.Inscription = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInscription = new System.Windows.Forms.Button();
            this.Formations = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.formationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestPlanFormationDataSet1 = new GestPlanFormation.GestPlanFormationDataSet1();
            this.txtBxPrenom = new System.Windows.Forms.TextBox();
            this.txtBxNom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.formationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestPlanFormationDataSet = new GestPlanFormation.GestPlanFormationDataSet();
            this.formationsTableAdapter = new GestPlanFormation.GestPlanFormationDataSetTableAdapters.FormationsTableAdapter();
            this.formationsTableAdapter1 = new GestPlanFormation.GestPlanFormationDataSet1TableAdapters.FormationsTableAdapter();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestPlanFormationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestPlanFormationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Cursor = System.Windows.Forms.Cursors.Default;
            this.Connect.Location = new System.Drawing.Point(518, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(97, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Se connecter";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Inscription
            // 
            this.Inscription.Controls.Add(this.Refresh);
            this.Inscription.Controls.Add(this.listView1);
            this.Inscription.Controls.Add(this.btnInscription);
            this.Inscription.Controls.Add(this.Formations);
            this.Inscription.Controls.Add(this.listBox1);
            this.Inscription.Controls.Add(this.txtBxPrenom);
            this.Inscription.Controls.Add(this.txtBxNom);
            this.Inscription.Controls.Add(this.Prenom);
            this.Inscription.Controls.Add(this.Nom);
            this.Inscription.Location = new System.Drawing.Point(12, 12);
            this.Inscription.Name = "Inscription";
            this.Inscription.Size = new System.Drawing.Size(497, 393);
            this.Inscription.TabIndex = 1;
            this.Inscription.TabStop = false;
            this.Inscription.Text = "Inscription Formation";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(416, 196);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 8;
            this.Refresh.Text = "Actualiser";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(7, 225);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 162);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom De La Formation";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Places";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre de Participants";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(6, 150);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(206, 23);
            this.btnInscription.TabIndex = 6;
            this.btnInscription.Text = "S\'incrire";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // Formations
            // 
            this.Formations.AutoSize = true;
            this.Formations.Location = new System.Drawing.Point(6, 118);
            this.Formations.Name = "Formations";
            this.Formations.Size = new System.Drawing.Size(58, 13);
            this.Formations.TabIndex = 5;
            this.Formations.Text = "Formations";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.formationsBindingSource1;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(73, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 43);
            this.listBox1.TabIndex = 4;
            this.listBox1.ValueMember = "Name";
            // 
            // formationsBindingSource1
            // 
            this.formationsBindingSource1.DataMember = "Formations";
            this.formationsBindingSource1.DataSource = this.gestPlanFormationDataSet1;
            // 
            // gestPlanFormationDataSet1
            // 
            this.gestPlanFormationDataSet1.DataSetName = "GestPlanFormationDataSet1";
            this.gestPlanFormationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBxPrenom
            // 
            this.txtBxPrenom.Location = new System.Drawing.Point(73, 60);
            this.txtBxPrenom.Name = "txtBxPrenom";
            this.txtBxPrenom.Size = new System.Drawing.Size(142, 20);
            this.txtBxPrenom.TabIndex = 3;
            // 
            // txtBxNom
            // 
            this.txtBxNom.Location = new System.Drawing.Point(73, 35);
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(142, 20);
            this.txtBxNom.TabIndex = 2;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(6, 63);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 1;
            this.Prenom.Text = "Prénom";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(6, 35);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // formationsBindingSource
            // 
            this.formationsBindingSource.DataMember = "Formations";
            this.formationsBindingSource.DataSource = this.gestPlanFormationDataSet;
            // 
            // gestPlanFormationDataSet
            // 
            this.gestPlanFormationDataSet.DataSetName = "GestPlanFormationDataSet";
            this.gestPlanFormationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formationsTableAdapter
            // 
            this.formationsTableAdapter.ClearBeforeFill = true;
            // 
            // formationsTableAdapter1
            // 
            this.formationsTableAdapter1.ClearBeforeFill = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date limite";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 417);
            this.Controls.Add(this.Inscription);
            this.Controls.Add(this.Connect);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Inscription.ResumeLayout(false);
            this.Inscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestPlanFormationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestPlanFormationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.GroupBox Inscription;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBxPrenom;
        private System.Windows.Forms.TextBox txtBxNom;
        private GestPlanFormationDataSet gestPlanFormationDataSet;
        private System.Windows.Forms.BindingSource formationsBindingSource;
        private GestPlanFormationDataSetTableAdapters.FormationsTableAdapter formationsTableAdapter;
        private GestPlanFormationDataSet1 gestPlanFormationDataSet1;
        private System.Windows.Forms.BindingSource formationsBindingSource1;
        private GestPlanFormationDataSet1TableAdapters.FormationsTableAdapter formationsTableAdapter1;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Label Formations;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}