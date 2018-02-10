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
    public partial class Create : Form
    {
        IRepositorio<Cliente> repositorioClientes = new RepositorioCliente(new DbConnectionManager());
        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            repositorioClientes.Insertar(cliente);
            this.Close();
        }
    }
}
