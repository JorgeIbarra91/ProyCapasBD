using Negocio;

namespace CapaPresentación
{
    public partial class CRUD_Productos : Form
    {
         // intancia de variable de la clase negocio
          CN_Productos objetoCN = new CN_Productos();
        

         private string idProducto = null;
         private bool Editar = false;

        public CRUD_Productos()// asi se llama mi formulario
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //ebento from LOAD
        {
            MostrarProdctos(); //llamada a metodo de negocio


        }

        private void MostrarProdctos()//
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProdctos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarProdctos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //boton editar
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void limpiarForm()
        {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarPRod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProdctos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
