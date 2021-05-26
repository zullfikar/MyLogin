using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin
{
    public partial class MasterProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CIJN2E2A\SQLEXPRESS;Initial Catalog=MyPratice;Integrated Security=True;");
        public MasterProduct()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        void LoadData()
        {
            var st = from tb in db.TB_M_PRODUCTs select tb;
            dataGridView1.DataSource = st;
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProduk.Text);
            string item = txtItem2.Text;
            string design = txtDesign2.Text;
            string color = cbColor.Text;
            DateTime expiredDate = DateTime.Parse(dtExpiredDate.Text);
            var data = new TB_M_PRODUCT
            {
                ID = id,
                itemName = item,
                color = color,
                design = design,
                expiredDate = expiredDate
            };
            db.TB_M_PRODUCTs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtDesign2.Clear();
            txtItem2.Clear();
            cbColor.Items.Clear();
            LoadData();
        }

        private void MasterProduct_Load_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (ID as int)), 0) +1 from TB_M_PRODUCT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtProduk.Text = dt.Rows[0][0].ToString();
            LoadData();
            con.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            var st = from s in db.TB_M_PRODUCTs where s.itemName == txtItem1.Text || s.design == txtDesign1.Text select s;
            dataGridView1.DataSource = st;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string item = txtItem2.Text;
            string design = txtDesign2.Text;
            string color = cbColor.Text;
            DateTime expiredDate = DateTime.Parse(dtExpiredDate.Text);

            var st = (from s in db.TB_M_PRODUCTs where s.ID == int.Parse(txtProduk.Text) select s).First();
            st.itemName = item;
            st.color = color;
            st.design = design;
            st.expiredDate = expiredDate;
            db.SubmitChanges();

            MessageBox.Show("Update Succesfuly");
            txtDesign2.Clear();
            txtItem2.Clear();
            cbColor.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = from s in db.TB_M_PRODUCTs where s.itemName == txtItem1.Text select s;
            foreach (var t in delete)
            {
                db.TB_M_PRODUCTs.DeleteOnSubmit(t);
            }
            db.SubmitChanges();
            MessageBox.Show("Delete Succesfully");
            txtDesign1.Clear();
            txtItem1.Clear();
            LoadData();
        }
    }
}
