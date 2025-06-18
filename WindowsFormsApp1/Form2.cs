using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void partners_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partners_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet1._Partners_". При необходимости она может быть перемещена или удалена.
            this.partners_TableAdapter1.Fill(this.mebelDataSet1._Partners_);
            try
            { 
            // данная строка кода позволяет загрузить данные в таблицу "mebelDataSet._Partners_".
            this.partners_TableAdapter.Fill(this.mebelDataSet._Partners_);
            }
            catch {
                MessageBox.Show("Ошибка при загрузке формы: ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                Form1 form1 = new Form1();
                form1.Show();
            this.Hide();

        }
    }
}
