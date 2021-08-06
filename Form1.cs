using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-8VT8NLKN;Database = dilliganesh;Integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommandcmd = new SqlCommand("insert into Application('" + textBox1.Text + "','" + textBox2.Text + '",'" + textbox3.Text + '", '" + textBox4.Text + '")", con);
            Cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added");


        }

              

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtFirstname.Text = row.Cells[0].Value.ToString();
                    txtLastname.Text = row.Cells[1].Value.ToString();
                    txtPercentage.Text = row.Cells[2].Value.ToString();
                    txtEnrollmentno.Text = row cells[3].value.To.String();
                }
    }
}

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Selected Item.to String() = "gender")
                {
                combobox2.Items.Add clear();
                combobox2.Items.Add("male");
                combobox2.Items.Add("female");
            }
        }