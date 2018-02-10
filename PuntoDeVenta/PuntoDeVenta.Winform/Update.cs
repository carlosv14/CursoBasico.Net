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
    public partial class Update : Form
    {
        IRepositorio<Cliente> repositorioClientes = new RepositorioCliente(new DbConnectionManager());
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            repositorioClientes.Actualizar(cliente);
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            txtDireccion.Text = Form1.Direccion;
            txtNombre.Text = Form1.Nombre;
            txtId.Text = Form1.Id;
        }
    }
}
