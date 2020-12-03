using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ExcelLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cn = string.Empty;
        string nombre = string.Empty;
        
        public DataTable Datos()
        {
                //cn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ nombre +";Extended Properties='Excel 12.0;HDR=No;IMEX=0'"; excel 2010
                cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + nombre + ";Extended Properties='Excel 8.0;HDR=No;IMEX=1'";
                DataTable dt = new DataTable();
                using (OleDbConnection cnn = new OleDbConnection(cn))
                {
                    string sql = "SELECT *FROM [Hoja1$] where ISNUMERIC(f1)";

                    OleDbCommand command = new OleDbCommand(sql, cnn);

                    OleDbDataAdapter da = new OleDbDataAdapter(command);

                    da.Fill(dt);
                    return dt;
                }
           
        }

        public void CargarDatos()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.DataSource = Datos();

        }
       
        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sl_fecha.Text = "Fecha:  " + DateTime.Today.ToLongDateString();
            tiempo.Start();
            sl_usuario.Text = Environment.MachineName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection cnn = new OleDbConnection(cn))
            {
                cnn.Open();
                using (OleDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Hoja1$] values(@id,@nom,@suel)"; //Ingresar datos
                    //cmd.CommandText = "UPDATE [Hoja1$] SET f2 = @nom, f3= @suel WHERE ID =" + textBox1.Text; modificar datos
                    //cmd.CommandText = "DELETE FROM [Hoja1$] WHERE ID =" + textBox1.Text; //delete no funciona 
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nom", textBox2.Text);
                    cmd.Parameters.AddWithValue("@suel", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Ingresados Correctamente...");
                }
                cnn.Close();
            }
            CargarDatos();
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.ColumnCount <= 0)
                {
                    MessageBox.Show("Debe cargar primero el archivo \nEn registro y cargar lista ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DataTable dt = Datos();
                    string sueldo = txtbuscar.Text;
                    var query = from datos in dt.AsEnumerable() where datos.Field<string>("f4").StartsWith(sueldo, System.StringComparison.OrdinalIgnoreCase) select datos;
                    //var query = dt.AsEnumerable().Where(datos=> datos.Field<int>("Sueldo") >= sueldo);
                    if (query.Count() > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = query.CopyToDataTable();
                    }
                    else
                        MessageBox.Show("No Se Encontraron Registros","Validacion",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error al buscar el dato especificado","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            sl_hora.Text = "Hora:   " + DateTime.Now.ToShortTimeString();
            tiempo.Start();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Excel Files(.xls)(.xlsx)(.xlsm)|*.xls|*.xlsx|*.xlsm";
                openFileDialog1.ShowDialog();
                nombre = openFileDialog1.FileName;
                CargarDatos();
                if (dataGridView1.ColumnCount < 28)
                {
                    MessageBox.Show("El archivo no cuenta con un formato valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = null;
                    return;
                }
                else
                {
                    dataGridView1.Visible = true;
                    usuariosToolStripMenuItem.Enabled = false;
                    groupBox2.Visible = true;
                }
                
                // MessageBox.Show("Archivo " + nombre, "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al encontrar el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ts_reiniciarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reiniciar la Aplicacion?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                return;
            }
            
        }

        private void ts_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir de la Aplicacion?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount <= 0)
            {
                MessageBox.Show("Debe cargar primero el archivo \nEn registro y cargar lista ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show(":D");
            }
        }
    }
}
