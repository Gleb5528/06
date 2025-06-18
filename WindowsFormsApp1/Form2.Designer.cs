namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.mebelDataSet = new WindowsFormsApp1.MebelDataSet();
            this.partners_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partners_TableAdapter = new WindowsFormsApp1.MebelDataSetTableAdapters.Partners_TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MebelDataSetTableAdapters.TableAdapterManager();
            this.partners_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.partners_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.partners_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.mebelDataSet1 = new WindowsFormsApp1.MebelDataSet1();
            this.partners_BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partners_TableAdapter1 = new WindowsFormsApp1.MebelDataSet1TableAdapters.Partners_TableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.MebelDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingNavigator)).BeginInit();
            this.partners_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partners_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mebelDataSet
            // 
            this.mebelDataSet.DataSetName = "MebelDataSet";
            this.mebelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partners_BindingSource
            // 
            this.partners_BindingSource.DataMember = "Partners$";
            this.partners_BindingSource.DataSource = this.mebelDataSet;
            // 
            // partners_TableAdapter
            // 
            this.partners_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Material_type_TableAdapter = null;
            this.tableAdapterManager.Partner_products_TableAdapter = null;
            this.tableAdapterManager.Partners_TableAdapter = this.partners_TableAdapter;
            this.tableAdapterManager.PartnerTypes_TableAdapter = null;
            this.tableAdapterManager.Product_type_TableAdapter = null;
            this.tableAdapterManager.Products_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partners_BindingNavigator
            // 
            this.partners_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partners_BindingNavigator.BindingSource = this.partners_BindingSource;
            this.partners_BindingNavigator.CountItem = null;
            this.partners_BindingNavigator.DeleteItem = null;
            this.partners_BindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.partners_BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.partners_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.partners_BindingNavigatorSaveItem});
            this.partners_BindingNavigator.Location = new System.Drawing.Point(103, 344);
            this.partners_BindingNavigator.MoveFirstItem = null;
            this.partners_BindingNavigator.MoveLastItem = null;
            this.partners_BindingNavigator.MoveNextItem = null;
            this.partners_BindingNavigator.MovePreviousItem = null;
            this.partners_BindingNavigator.Name = "partners_BindingNavigator";
            this.partners_BindingNavigator.PositionItem = null;
            this.partners_BindingNavigator.Size = new System.Drawing.Size(328, 34);
            this.partners_BindingNavigator.TabIndex = 0;
            this.partners_BindingNavigator.Text = "bindingNavigator1";
            // 
            // partners_DataGridView
            // 
            this.partners_DataGridView.AutoGenerateColumns = false;
            this.partners_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partners_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.partners_DataGridView.DataSource = this.partners_BindingSource;
            this.partners_DataGridView.Location = new System.Drawing.Point(12, 30);
            this.partners_DataGridView.Name = "partners_DataGridView";
            this.partners_DataGridView.RowHeadersWidth = 62;
            this.partners_DataGridView.RowTemplate.Height = 28;
            this.partners_DataGridView.Size = new System.Drawing.Size(776, 220);
            this.partners_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "INN";
            this.dataGridViewTextBoxColumn1.HeaderText = "INN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type_part";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type_part";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name_part";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name_part";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn4.HeaderText = "Director";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "telephone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "adress";
            this.dataGridViewTextBoxColumn7.HeaderText = "adress";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Raiting";
            this.dataGridViewTextBoxColumn8.HeaderText = "Raiting";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(118, 29);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // partners_BindingNavigatorSaveItem
            // 
            this.partners_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partners_BindingNavigatorSaveItem.Image")));
            this.partners_BindingNavigatorSaveItem.Name = "partners_BindingNavigatorSaveItem";
            this.partners_BindingNavigatorSaveItem.Size = new System.Drawing.Size(192, 29);
            this.partners_BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.partners_BindingNavigatorSaveItem.Click += new System.EventHandler(this.partners_BindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mebelDataSet1
            // 
            this.mebelDataSet1.DataSetName = "MebelDataSet1";
            this.mebelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partners_BindingSource1
            // 
            this.partners_BindingSource1.DataMember = "Partners$";
            this.partners_BindingSource1.DataSource = this.mebelDataSet1;
            // 
            // partners_TableAdapter1
            // 
            this.partners_TableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Material_type_TableAdapter = null;
            this.tableAdapterManager1.Partner_products_TableAdapter = null;
            this.tableAdapterManager1.Partners_TableAdapter = this.partners_TableAdapter1;
            this.tableAdapterManager1.PartnerTypes_TableAdapter = null;
            this.tableAdapterManager1.Product_type_TableAdapter = null;
            this.tableAdapterManager1.Products_TableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.MebelDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partners_DataGridView);
            this.Controls.Add(this.partners_BindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingNavigator)).EndInit();
            this.partners_BindingNavigator.ResumeLayout(false);
            this.partners_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partners_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource partners_BindingSource;
        private MebelDataSetTableAdapters.Partners_TableAdapter partners_TableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partners_BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton partners_BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView partners_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private MebelDataSet1 mebelDataSet1;
        private System.Windows.Forms.BindingSource partners_BindingSource1;
        private MebelDataSet1TableAdapters.Partners_TableAdapter partners_TableAdapter1;
        private MebelDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}