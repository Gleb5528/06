using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void partners_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partners_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void partners_BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.partners_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet2._Partners_". При необходимости она может быть перемещена или удалена.
            this.partners_TableAdapter2.Fill(this.mebelDataSet2._Partners_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet1._Partners_". При необходимости она может быть перемещена или удалена.
            this.partners_TableAdapter1.Fill(this.mebelDataSet1._Partners_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet._Partners_". При необходимости она может быть перемещена или удалена.
            this.partners_TableAdapter.Fill(this.mebelDataSet._Partners_);
            fillByToolStripButton_Click(null,null);
            fillBy1ToolStripButton_Click(null, null);

            fillBy2ToolStripButton_Click(null, null);

            fillBy3ToolStripButton_Click(null, null);//первая


            fillBy1ToolStripButton_Click_1(null, null);
            fillBy2ToolStripButton_Click_1(null, null);
            fillBy3ToolStripButton_Click_1(null, null);
            fillBy4ToolStripButton_Click(null, null);



            fillByToolStripButton_Click_1(null, null);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter.FillBy(this.mebelDataSet._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter.FillBy1(this.mebelDataSet._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter.FillBy2(this.mebelDataSet._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter.FillBy3(this.mebelDataSet._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter1.FillBy1(this.mebelDataSet1._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter1.FillBy2(this.mebelDataSet1._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter1.FillBy3(this.mebelDataSet1._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter1.FillBy4(this.mebelDataSet1._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.partners_TableAdapter2.FillBy(this.mebelDataSet2._Partners_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();          
        }

        private void discount(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }
    }
}
