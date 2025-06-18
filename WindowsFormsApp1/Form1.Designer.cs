namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label type_partLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label raitingLabel;
            System.Windows.Forms.Label directorLabel2;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.type_partLabel1 = new System.Windows.Forms.Label();
            this.partners_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelDataSet = new WindowsFormsApp1.MebelDataSet();
            this.directorLabel1 = new System.Windows.Forms.Label();
            this.telephoneLabel1 = new System.Windows.Forms.Label();
            this.raitingLabel1 = new System.Windows.Forms.Label();
            this.partners_TableAdapter = new WindowsFormsApp1.MebelDataSetTableAdapters.Partners_TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MebelDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.directorLabel3 = new System.Windows.Forms.Label();
            this.partners_BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mebelDataSet2 = new WindowsFormsApp1.MebelDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.partners_BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mebelDataSet1 = new WindowsFormsApp1.MebelDataSet1();
            this.partners_TableAdapter1 = new WindowsFormsApp1.MebelDataSet1TableAdapters.Partners_TableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.MebelDataSet1TableAdapters.TableAdapterManager();
            this.partners_TableAdapter2 = new WindowsFormsApp1.MebelDataSet2TableAdapters.Partners_TableAdapter();
            this.tableAdapterManager2 = new WindowsFormsApp1.MebelDataSet2TableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            type_partLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            raitingLabel = new System.Windows.Forms.Label();
            directorLabel2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // type_partLabel
            // 
            type_partLabel.AutoSize = true;
            type_partLabel.Location = new System.Drawing.Point(14, 17);
            type_partLabel.Name = "type_partLabel";
            type_partLabel.Size = new System.Drawing.Size(79, 20);
            type_partLabel.TabIndex = 1;
            type_partLabel.Text = "Type part:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(3, 46);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(69, 20);
            directorLabel.TabIndex = 3;
            directorLabel.Text = "Director:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(3, 69);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(84, 20);
            telephoneLabel.TabIndex = 5;
            telephoneLabel.Text = "telephone:";
            // 
            // raitingLabel
            // 
            raitingLabel.AutoSize = true;
            raitingLabel.Location = new System.Drawing.Point(3, 98);
            raitingLabel.Name = "raitingLabel";
            raitingLabel.Size = new System.Drawing.Size(63, 20);
            raitingLabel.TabIndex = 7;
            raitingLabel.Text = "Raiting:";
            // 
            // directorLabel2
            // 
            directorLabel2.AutoSize = true;
            directorLabel2.Location = new System.Drawing.Point(28, 62);
            directorLabel2.Name = "directorLabel2";
            directorLabel2.Size = new System.Drawing.Size(69, 20);
            directorLabel2.TabIndex = 9;
            directorLabel2.Text = "Director:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Мастер_пол;
            pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.Мастер_пол;
            pictureBox1.Location = new System.Drawing.Point(158, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // type_partLabel1
            // 
            this.type_partLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partners_BindingSource, "Type_part", true));
            this.type_partLabel1.Location = new System.Drawing.Point(99, 17);
            this.type_partLabel1.Name = "type_partLabel1";
            this.type_partLabel1.Size = new System.Drawing.Size(100, 23);
            this.type_partLabel1.TabIndex = 2;
            this.type_partLabel1.Text = "label1";
            // 
            // partners_BindingSource
            // 
            this.partners_BindingSource.DataMember = "Partners$";
            this.partners_BindingSource.DataSource = this.mebelDataSet;
            // 
            // mebelDataSet
            // 
            this.mebelDataSet.DataSetName = "MebelDataSet";
            this.mebelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorLabel1
            // 
            this.directorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partners_BindingSource, "Director", true));
            this.directorLabel1.Location = new System.Drawing.Point(78, 46);
            this.directorLabel1.Name = "directorLabel1";
            this.directorLabel1.Size = new System.Drawing.Size(100, 23);
            this.directorLabel1.TabIndex = 4;
            this.directorLabel1.Text = "label1";
            // 
            // telephoneLabel1
            // 
            this.telephoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partners_BindingSource, "telephone", true));
            this.telephoneLabel1.Location = new System.Drawing.Point(93, 69);
            this.telephoneLabel1.Name = "telephoneLabel1";
            this.telephoneLabel1.Size = new System.Drawing.Size(100, 23);
            this.telephoneLabel1.TabIndex = 6;
            this.telephoneLabel1.Text = "label1";
            // 
            // raitingLabel1
            // 
            this.raitingLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partners_BindingSource, "Raiting", true));
            this.raitingLabel1.Location = new System.Drawing.Point(72, 98);
            this.raitingLabel1.Name = "raitingLabel1";
            this.raitingLabel1.Size = new System.Drawing.Size(100, 23);
            this.raitingLabel1.TabIndex = 8;
            this.raitingLabel1.Text = "label1";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(raitingLabel);
            this.panel1.Controls.Add(this.type_partLabel1);
            this.panel1.Controls.Add(this.raitingLabel1);
            this.panel1.Controls.Add(type_partLabel);
            this.panel1.Controls.Add(telephoneLabel);
            this.panel1.Controls.Add(this.directorLabel1);
            this.panel1.Controls.Add(this.telephoneLabel1);
            this.panel1.Controls.Add(directorLabel);
            this.panel1.Location = new System.Drawing.Point(17, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 129);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "10%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(directorLabel2);
            this.panel2.Controls.Add(this.directorLabel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 129);
            this.panel2.TabIndex = 10;
            // 
            // directorLabel3
            // 
            this.directorLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partners_BindingSource2, "Director", true));
            this.directorLabel3.Location = new System.Drawing.Point(103, 62);
            this.directorLabel3.Name = "directorLabel3";
            this.directorLabel3.Size = new System.Drawing.Size(100, 23);
            this.directorLabel3.TabIndex = 10;
            this.directorLabel3.Text = "label3";
            // 
            // partners_BindingSource2
            // 
            this.partners_BindingSource2.DataMember = "Partners$";
            this.partners_BindingSource2.DataSource = this.mebelDataSet2;
            // 
            // mebelDataSet2
            // 
            this.mebelDataSet2.DataSetName = "MebelDataSet2";
            this.mebelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "10%";
            // 
            // partners_BindingSource1
            // 
            this.partners_BindingSource1.DataMember = "Partners$";
            this.partners_BindingSource1.DataSource = this.mebelDataSet1;
            // 
            // mebelDataSet1
            // 
            this.mebelDataSet1.DataSetName = "MebelDataSet1";
            this.mebelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // partners_TableAdapter2
            // 
            this.partners_TableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Material_type_TableAdapter = null;
            this.tableAdapterManager2.Partner_products_TableAdapter = null;
            this.tableAdapterManager2.Partners_TableAdapter = this.partners_TableAdapter2;
            this.tableAdapterManager2.PartnerTypes_TableAdapter = null;
            this.tableAdapterManager2.Product_type_TableAdapter = null;
            this.tableAdapterManager2.Products_TableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = WindowsFormsApp1.MebelDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Парнеры";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Итсория";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partners_BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource partners_BindingSource;
        private MebelDataSetTableAdapters.Partners_TableAdapter partners_TableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label type_partLabel1;
        private System.Windows.Forms.Label directorLabel1;
        private System.Windows.Forms.Label telephoneLabel1;
        private System.Windows.Forms.Label raitingLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MebelDataSet1 mebelDataSet1;
        private System.Windows.Forms.BindingSource partners_BindingSource1;
        private MebelDataSet1TableAdapters.Partners_TableAdapter partners_TableAdapter1;
        private MebelDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private MebelDataSet2 mebelDataSet2;
        private System.Windows.Forms.BindingSource partners_BindingSource2;
        private MebelDataSet2TableAdapters.Partners_TableAdapter partners_TableAdapter2;
        private MebelDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Label directorLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}

