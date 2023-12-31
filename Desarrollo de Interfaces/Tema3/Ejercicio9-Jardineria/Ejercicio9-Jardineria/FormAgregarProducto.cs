﻿using Ejercicio9_Jardineria.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9_Jardineria
{
    public partial class FormAgregarProducto : Form
    {
        private Servicio Servicio;

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Gama { get; set; }
        public String Dimensiones { get; set; }
        public String Proveedor { get; set; }
        public String Descripcion { get; set; }
        public int CantidadStock { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioProveedor { get; set; }

        public FormAgregarProducto()
        {
            InitializeComponent();

            Servicio = Servicio.GetInstance();

            foreach (string gama in Servicio.GetGamas())
            {
                cmbGama.Items.Add(gama);
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                errCodigo.SetError(txtCodigo, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                Codigo = txtCodigo.Text;

                errCodigo.SetError(txtCodigo, "");
                e.Cancel = false;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errNombre.SetError(txtNombre, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                Nombre = txtNombre.Text;

                errNombre.SetError(txtNombre, "");
                e.Cancel = false;
            }
        }

        private void cmbGama_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGama.SelectedIndex == -1)
            {
                errGama.SetError(txtNombre, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                Gama = cmbGama.SelectedItem.ToString()!;

                errGama.SetError(txtNombre, "");
                e.Cancel = false;
            }
        }

        private void txtCantidadStock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidadStock.Text))
            {
                errCantidadStock.SetError(txtCantidadStock, "Campo obligatorio");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtCantidadStock.Text, @"^\d*$"))
            {
                errCantidadStock.SetError(txtCantidadStock, "Debe introducir un número");
                e.Cancel = true;
            }
            else
            {
                CantidadStock = Convert.ToInt32(txtCantidadStock.Text);

                errCantidadStock.SetError(txtCantidadStock, "");
                e.Cancel = false;
            }
        }

        private void txtPrecioVenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                errPrecioVenta.SetError(txtPrecioVenta, "Campo obligatorio");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrecioVenta.Text, @"^\d*.?\d*$"))
            {
                errPrecioVenta.SetError(txtPrecioVenta, "Debe introducir un número");
                e.Cancel = true;
            }
            else
            {
                PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);

                errPrecioVenta.SetError(txtPrecioVenta, "");
                e.Cancel = false;
            }
        }

        private void txtPrecioProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtPrecioProveedor.Text, @"^\d*.?\d*$") && !txtPrecioProveedor.Equals(""))
            {
                errPrecioProveedor.SetError(txtPrecioProveedor, "Solo puede introducir un número");
                e.Cancel = true;
            }
            else
            {
                PrecioProveedor = Convert.ToDouble(txtPrecioProveedor.Text);

                errPrecioProveedor.SetError(txtPrecioProveedor, "");
                e.Cancel = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Dimensiones = txtDimensiones.Text;
                Proveedor = txtProveedor.Text;
                Descripcion = txtDescripcion.Text;

                Servicio.AgregarProducto(Codigo, Nombre, Gama, Dimensiones, Proveedor, Descripcion, CantidadStock, PrecioVenta, PrecioProveedor);
                MessageBox.Show("Producto añadido correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Error al añadir el producto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
