using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_INVENTARIO
{
    public partial class Form1 : Form
    {
        DataGridViewRow row;
        public Form1()
        {
            InitializeComponent();
        }

        Product2 x = new Product2();
        public void save(int a)
        {
            if (a == 1) //hacer un boton de save o dos botones de save que tengan la misma funcion pero diferentes cosas, polimorfismo y  quitar los if 
            {
                row = new DataGridViewRow();
                row.CreateCells(dgvBoard);
                try
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvBoard);
                    row.Cells[0].Value = txtcode.Text.ToUpper();
                    row.Cells[1].Value = dateTimePicker1.Text;
                    row.Cells[2].Value = txtproduct.Text.ToUpper();
                    row.Cells[3].Value = txtpurchase_price.Text;
                    row.Cells[4].Value = txtamount.Text;
                    row.Cells[5].Value = txtsale_price.Text;
                    StreamWriter sw = new StreamWriter("PROYECT.txt", true, Encoding.ASCII);

                    sw.WriteLine(txtcode.Text.ToUpper() + "," + dateTimePicker1.Text + "," + txtproduct.Text.ToUpper() + "," + txtpurchase_price.Text + "," + txtamount.Text + "," + txtsale_price.Text + "," + txtexit.Text);
                    sw.Close();

                    dgvBoard.Rows.Add(row);
                    txtcode.Text = " ";
                    dateTimePicker1.Text = null;
                    txtproduct.Text = " ";
                    txtpurchase_price.Text = " ";
                    txtamount.Text = " ";
                    txtsale_price.Text = " ";
                }
                catch
                {
                    MessageBox.Show("IT SEEMS SOMETHING WENT WRONG..., PLEASE REVIEW AND FILL IN EACH FIELD CORRECTLY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (a == 2)
            {
                //row.Cells[6].Value = txtexit.Text;
                dgvBoard.Rows.Add(txtexit.Text);
                //txtexit.Text = dgvBoard.CurrentRow.Cells[6].Value.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvBoard.Rows.Remove(dgvBoard.CurrentRow);
        }
        private void dgvBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcode.Text = dgvBoard.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dgvBoard.CurrentRow.Cells[1].Value.ToString();
            txtproduct.Text = dgvBoard.CurrentRow.Cells[2].Value.ToString();
            txtpurchase_price.Text = dgvBoard.CurrentRow.Cells[3].Value.ToString();
            txtamount.Text = dgvBoard.CurrentRow.Cells[4].Value.ToString();
            txtsale_price.Text = dgvBoard.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnmost_Click(object sender, EventArgs e)
        {
            double totalA, totalB, totalC;
            totalA = 0; totalB = 0; totalC = 0;
            foreach (DataGridViewRow row in dgvBoard.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    double value = 0;
                    if (double.TryParse(row.Cells[3].Value.ToString(), out value))
                    { totalA += value; }
                    txtentries.Text = totalA.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    double value1 = 0;
                    if (double.TryParse(row.Cells[4].Value.ToString(), out value1))
                    { totalB += value1; }
                    txttotal1.Text = totalB.ToString("C");
                }
                if (row.Cells[5].Value != null)
                {
                    double value2 = 0;
                    if (double.TryParse(row.Cells[5].Value.ToString(), out value2))
                    { totalC += value2; }
                    txttotal2.Text = totalC.ToString("C");
                }
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            save(2);
        }
        private void btnSave1_Click(object sender, EventArgs e)
        {
            save(1);
        }
        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("PROYECT.txt");
            rtxtboxmost.Text = sr.ReadToEnd();
        }
    }
}