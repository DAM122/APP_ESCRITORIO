using GestionAppTurismo.model;
using GestionAppTurismo.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GestionAppTurismo
{
    public partial class MonumentoForm : Form
    {
        private bool modo;
        private readonly ApiService apiService;
        private Monumento monumentoActual;
        public MonumentoForm(bool edicion)
        {
            InitializeComponent();
            modo = edicion;
            apiService = new ApiService();
            LoadLocalidadesAsync();
            btnGuardar.Click += async (s, ev) => await btnGuardar_Click(s, ev);
            btnCancelar.Click += (s, ev) => btnCancelar_Click(s, ev);
        }

        public MonumentoForm(bool edicion, Monumento monumento)
        {
            monumentoActual = monumento;
            InitializeComponent();
            modo = edicion;
            apiService = new ApiService();
            LoadLocalidadesAsync();
            txNombre.Text = monumento.Nombre;
            txFecha.Text = monumento.Fecha.HasValue ? monumento.Fecha.Value.ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");
            txEstilo.Text = monumento.Estilo;
            txDescripcion.Text = monumento.Descripcion;
            chkVisitable.Checked = monumento.Visitable;
            chkParking.Checked = monumento.Parking;
            txTelefono.Text = monumento.Telefono;
            txImagen.Text = monumento.Imagen;
            txValoracion.Text = monumento.Valoracion?.ToString(CultureInfo.InvariantCulture);
            if (monumento.Localidad != null)
            {
                cmbLocalidad.SelectedValue = monumento.Localidad.Id;
            }
            btnGuardar.Click += async (s, ev) => await btnGuardar_Click(s, ev);
            btnCancelar.Click += (s, ev) => btnCancelar_Click(s, ev);
        }

        private void MonumentoForm_Load(object sender, EventArgs e)
        {
        }

        private async void LoadLocalidadesAsync()
        {
            try
            {
                var localidades = await apiService.GetLocalidadesAsync();

                cmbLocalidad.DataSource = localidades;
                cmbLocalidad.DisplayMember = "Nombre";
                cmbLocalidad.ValueMember = "Id";

                if (monumentoActual != null && monumentoActual.Localidad != null)
                {
                    cmbLocalidad.SelectedValue = monumentoActual.Localidad.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar localidades: " + ex.Message);
            }
        }

        private async Task btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var seleccionada = (Localidad)cmbLocalidad.SelectedItem;

                DateTime? fecha = null;
                if (!string.IsNullOrWhiteSpace(txFecha.Text))
                {
                    if (DateTime.TryParseExact(txFecha.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedFecha))
                    {
                        fecha = parsedFecha;
                    }
                    else
                    {
                        MessageBox.Show("Fecha debe tener el formato yyyy-MM-dd.");
                        return;
                    }
                }

                double? valoracion = null;
                if (!string.IsNullOrWhiteSpace(txValoracion.Text))
                {
                    if (double.TryParse(txValoracion.Text, out double parsedValoracion))
                    {
                        valoracion = parsedValoracion;
                    }
                    else
                    {
                        MessageBox.Show("Valoración debe ser un número válido.");
                        return;
                    }
                }

                var nuevoMonumento = new Monumento
                {
                    Nombre = txNombre.Text,
                    Fecha = fecha,
                    Estilo = string.IsNullOrWhiteSpace(txEstilo.Text) ? null : txEstilo.Text,
                    Descripcion = txDescripcion.Text,
                    Visitable = chkVisitable.Checked,
                    Parking = chkParking.Checked,
                    Telefono = string.IsNullOrWhiteSpace(txTelefono.Text) ? null : txTelefono.Text,
                    Imagen = string.IsNullOrWhiteSpace(txImagen.Text) ? null : txImagen.Text,
                    Valoracion = valoracion,
                    Localidad = seleccionada
                };

                HttpResponseMessage response;
                if (modo && monumentoActual != null)
                {
                    nuevoMonumento.Id = monumentoActual.Id;
                    response = await apiService.UpdateMonumentoAsync(monumentoActual.Id, nuevoMonumento);
                }
                else
                {
                    response = await apiService.PostMonumento(nuevoMonumento);
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Operación completada exitosamente.");
                    this.Close();
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al realizar la operación. StatusCode: {response.StatusCode}. Detalles: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar realizar la operación: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
