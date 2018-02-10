using PuntoDeVenta.BaseDeDatos.Modelos;
using PuntoDeVenta.BaseDeDatos.Repositorios;
using PuntoDeVenta.BaseDeDatos.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Winform
{
    public partial class Form1 : Form
    {
        IRepositorio<Cliente> repositorioClientes = new RepositorioCliente(new DbConnectionManager());
        public static string Nombre = "";
        public static string Direccion = "";
        public static string Id = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create createForm = new Create();
            createForm.ShowDialog();
            clientesDataGrid.DataSource = repositorioClientes.Obtener();
        }

        private void Update(object sender, DataGridViewCellEventArgs e)
        {
            Update updateForm = new Update();
            Direccion = this.clientesDataGrid.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            Nombre = this.clientesDataGrid.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            Id = this.clientesDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            updateForm.ShowDialog();
            clientesDataGrid.DataSource = repositorioClientes.Obtener();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientesDataGrid.DataSource = repositorioClientes.Obtener();
        }

        private void clientesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnDelete.Enabled = true;
            Id = this.clientesDataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Id);
            repositorioClientes.Borrar(id);
            clientesDataGrid.DataSource = repositorioClientes.Obtener();
        }
    }
}
