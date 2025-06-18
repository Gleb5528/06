namespace WindowsFormsApp1
{
    partial class Form3
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
            System.Windows.Forms.Label productionLabel;
            System.Windows.Forms.Label articulLabel;
            System.Windows.Forms.Label name_partLabel;
            System.Windows.Forms.Label kolvoLabel;
            System.Windows.Forms.Label dateLabel;
            this.mebelDataSet = new WindowsFormsApp1.MebelDataSet();
            this.partner_products_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner_products_TableAdapter = new WindowsFormsApp1.MebelDataSetTableAdapters.Partner_products_TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MebelDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.productionLabel1 = new System.Windows.Forms.Label();
            this.articulLabel1 = new System.Windows.Forms.Label();
            this.name_partLabel1 = new System.Windows.Forms.Label();
            this.kolvoLabel1 = new System.Windows.Forms.Label();
            this.dateLabel1 = new System.Windows.Forms.Label();
            productionLabel = new System.Windows.Forms.Label();
            articulLabel = new System.Windows.Forms.Label();
            name_partLabel = new System.Windows.Forms.Label();
            kolvoLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_products_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mebelDataSet
            // 
            this.mebelDataSet.DataSetName = "MebelDataSet";
            this.mebelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partner_products_BindingSource
            // 
            this.partner_products_BindingSource.DataMember = "Partner_products$";
            this.partner_products_BindingSource.DataSource = this.mebelDataSet;
            // 
            // partner_products_TableAdapter
            // 
            this.partner_products_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Material_type_TableAdapter = null;
            this.tableAdapterManager.Partner_products_TableAdapter = this.partner_products_TableAdapter;
            this.tableAdapterManager.Partners_TableAdapter = null;
            this.tableAdapterManager.PartnerTypes_TableAdapter = null;
            this.tableAdapterManager.Product_type_TableAdapter = null;
            this.tableAdapterManager.Products_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productionLabel
            // 
            productionLabel.AutoSize = true;
            productionLabel.Location = new System.Drawing.Point(109, 109);
            productionLabel.Name = "productionLabel";
            productionLabel.Size = new System.Drawing.Size(89, 20);
            productionLabel.TabIndex = 11;
            productionLabel.Text = "Production:";
            // 
            // productionLabel1
            // 
            this.productionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_products_BindingSource, "Production", true));
            this.productionLabel1.Location = new System.Drawing.Point(204, 109);
            this.productionLabel1.Name = "productionLabel1";
            this.productionLabel1.Size = new System.Drawing.Size(100, 23);
            this.productionLabel1.TabIndex = 12;
            this.productionLabel1.Text = "label1";
            // 
            // articulLabel
            // 
            articulLabel.AutoSize = true;
            articulLabel.Location = new System.Drawing.Point(109, 132);
            articulLabel.Name = "articulLabel";
            articulLabel.Size = new System.Drawing.Size(57, 20);
            articulLabel.TabIndex = 13;
            articulLabel.Text = "Articul:";
            // 
            // articulLabel1
            // 
            this.articulLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_products_BindingSource, "Articul", true));
            this.articulLabel1.Location = new System.Drawing.Point(204, 132);
            this.articulLabel1.Name = "articulLabel1";
            this.articulLabel1.Size = new System.Drawing.Size(100, 23);
            this.articulLabel1.TabIndex = 14;
            this.articulLabel1.Text = "label1";
            // 
            // name_partLabel
            // 
            name_partLabel.AutoSize = true;
            name_partLabel.Location = new System.Drawing.Point(109, 155);
            name_partLabel.Name = "name_partLabel";
            name_partLabel.Size = new System.Drawing.Size(87, 20);
            name_partLabel.TabIndex = 15;
            name_partLabel.Text = "Name part:";
            // 
            // name_partLabel1
            // 
            this.name_partLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_products_BindingSource, "Name_part", true));
            this.name_partLabel1.Location = new System.Drawing.Point(204, 155);
            this.name_partLabel1.Name = "name_partLabel1";
            this.name_partLabel1.Size = new System.Drawing.Size(100, 23);
            this.name_partLabel1.TabIndex = 16;
            this.name_partLabel1.Text = "label1";
            // 
            // kolvoLabel
            // 
            kolvoLabel.AutoSize = true;
            kolvoLabel.Location = new System.Drawing.Point(109, 178);
            kolvoLabel.Name = "kolvoLabel";
            kolvoLabel.Size = new System.Drawing.Size(49, 20);
            kolvoLabel.TabIndex = 17;
            kolvoLabel.Text = "kolvo:";
            // 
            // kolvoLabel1
            // 
            this.kolvoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_products_BindingSource, "kolvo", true));
            this.kolvoLabel1.Location = new System.Drawing.Point(204, 178);
            this.kolvoLabel1.Name = "kolvoLabel1";
            this.kolvoLabel1.Size = new System.Drawing.Size(100, 23);
            this.kolvoLabel1.TabIndex = 18;
            this.kolvoLabel1.Text = "label1";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(109, 201);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(45, 20);
            dateLabel.TabIndex = 19;
            dateLabel.Text = "date:";
            // 
            // dateLabel1
            // 
            this.dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_products_BindingSource, "date", true));
            this.dateLabel1.Location = new System.Drawing.Point(204, 201);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.dateLabel1.TabIndex = 20;
            this.dateLabel1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(productionLabel);
            this.Controls.Add(this.productionLabel1);
            this.Controls.Add(articulLabel);
            this.Controls.Add(this.articulLabel1);
            this.Controls.Add(name_partLabel);
            this.Controls.Add(this.name_partLabel1);
            this.Controls.Add(kolvoLabel);
            this.Controls.Add(this.kolvoLabel1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_products_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource partner_products_BindingSource;
        private MebelDataSetTableAdapters.Partner_products_TableAdapter partner_products_TableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label productionLabel1;
        private System.Windows.Forms.Label articulLabel1;
        private System.Windows.Forms.Label name_partLabel1;
        private System.Windows.Forms.Label kolvoLabel1;
        private System.Windows.Forms.Label dateLabel1;
    }
}