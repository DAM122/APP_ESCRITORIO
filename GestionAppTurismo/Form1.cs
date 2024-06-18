using GestionAppTurismo.model;
using GestionAppTurismo.service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GestionAppTurismo
{
    public partial class Form1 : Form
    {
        private readonly ApiService _apiService;
        private List<Monumento> monumentosData;
        private List<Localidad> localidadesData;
        private List<Artista> artistasData;
        private List<Usuario> usuariosData;
        private List<Comentario> comentariosData;
        private List<object> currentDataList;
        private readonly ApiService apiService = new ApiService();
        public Form1()
        {
            InitializeComponent();
            _apiService = new ApiService();
            Load += Form1_Load;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            btnFiltrar.Click += btnFiltrar_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTablas.Items.Add("monumentos");
            comboBoxTablas.Items.Add("localidades");
            comboBoxTablas.Items.Add("artistas");
            comboBoxTablas.Items.Add("usuarios");
            comboBoxTablas.Items.Add("comentarios");

            comboBoxTablas.SelectedIndexChanged += ComboBoxTablas_SelectedIndexChanged;
            comboBoxTablas.SelectedItem = "monumentos";

            await CargarDatosTablaSeleccionada("monumentos");
        }


        private async void ComboBoxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablaSeleccionada = comboBoxTablas.SelectedItem.ToString();
            await CargarDatosTablaSeleccionada(tablaSeleccionada);
        }

        private async Task CargarDatosTablaSeleccionada(string tablaSeleccionada)
        {
            try
            {
                string endpoint = $"http://localhost:8080/{tablaSeleccionada}";

                switch (tablaSeleccionada)
                {
                    case "monumentos":
                        monumentosData = await _apiService.GetDataAsync<Monumento>(endpoint);
                        dataGridView1.DataSource = monumentosData;
                        ConfigurarColumnas<Monumento>();
                        lbNombre.Text = "Nombre";
                        txNickName.Enabled = false;
                        txProvincia.Enabled = false;
                        txRol.Enabled = false;
                        txLocalidad.Enabled = true;
                        txNombre.Enabled = true;
                        currentDataList = monumentosData.Cast<object>().ToList();
                        break;
                    case "localidades":
                        localidadesData = await _apiService.GetDataAsync<Localidad>(endpoint);
                        dataGridView1.DataSource = localidadesData;
                        ConfigurarColumnas<Localidad>();
                        lbNombre.Text = "Nombre";
                        txNickName.Enabled = false;
                        txProvincia.Enabled = false;
                        txRol.Enabled = false;
                        txLocalidad.Enabled = false;
                        txNombre.Enabled = true;
                        currentDataList = localidadesData.Cast<object>().ToList();
                        break;
                    case "artistas":
                        artistasData = await _apiService.GetDataAsync<Artista>(endpoint);
                        dataGridView1.DataSource = artistasData;
                        ConfigurarColumnas<Artista>();
                        lbNombre.Text = "Nombre";
                        txNickName.Enabled = false;
                        txProvincia.Enabled = false;
                        txRol.Enabled = false;
                        txLocalidad.Enabled = false;
                        txNombre.Enabled = true;
                        currentDataList = artistasData.Cast<object>().ToList();
                        break;
                    case "usuarios":
                        usuariosData = await _apiService.GetDataAsync<Usuario>(endpoint);
                        dataGridView1.DataSource = usuariosData;
                        ConfigurarColumnas<Usuario>();
                        lbNombre.Text = "Nombre";
                        txNickName.Enabled = true;
                        txProvincia.Enabled = false;
                        txRol.Enabled = true;
                        txLocalidad.Enabled = false;
                        txNombre.Enabled = true;
                        currentDataList = usuariosData.Cast<object>().ToList();
                        break;
                    case "comentarios":
                        comentariosData = await _apiService.GetDataAsync<Comentario>(endpoint);
                        dataGridView1.DataSource = comentariosData;
                        ConfigurarColumnas<Comentario>();
                        lbNombre.Text = "Usuario";
                        txNickName.Enabled = false;
                        txProvincia.Enabled = false;
                        txRol.Enabled = false;
                        txLocalidad.Enabled = false;
                        txNombre.Enabled = true;
                        currentDataList = comentariosData.Cast<object>().ToList();
                        break;
                    default:
                        MessageBox.Show("Tabla seleccionada no reconocida");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos de la tabla {tablaSeleccionada}: {ex.Message}");
            }
        }

        private void ConfigurarColumnas<T>()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            if (typeof(T) == typeof(Monumento))
            {

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nombre",
                    HeaderText = "Nombre"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Localidad",
                    CellTemplate = new DataGridViewTextBoxCell(),
                    ReadOnly = true,
                    Visible = true
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Fecha",
                    HeaderText = "Fecha"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Estilo",
                    HeaderText = "Estilo"
                });

                DataGridViewCheckBoxColumn visitableColumn = new DataGridViewCheckBoxColumn();
                visitableColumn.DataPropertyName = "Visitable";
                visitableColumn.HeaderText = "Visitable";
                dataGridView1.Columns.Add(visitableColumn);

                DataGridViewCheckBoxColumn parkingColumn = new DataGridViewCheckBoxColumn();
                parkingColumn.DataPropertyName = "Parking";
                parkingColumn.HeaderText = "Parking";
                dataGridView1.Columns.Add(parkingColumn);

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Telefono",
                    HeaderText = "Telefono"
                });

            }
            else if (typeof(T) == typeof(Localidad))
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nombre",
                    HeaderText = "Nombre"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Provincia",
                    HeaderText = "Provincia"
                });
            }
            else if (typeof(T) == typeof(Artista))
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nombre",
                    HeaderText = "Nombre"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Apellido1",
                    HeaderText = "Apellido1"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Apellido2",
                    HeaderText = "Apellido2"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Profesion",
                    HeaderText = "Profesion"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "FechaNacimiento",
                    HeaderText = "FechaNacimiento"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "FechaMuerte",
                    HeaderText = "FechaMuerte"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Procedencia",
                    HeaderText = "Procedencia"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PaisOrigen",
                    HeaderText = "PaisOrigen"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Historia",
                    HeaderText = "Historia"
                });
            }
            else if (typeof(T) == typeof(Usuario))
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nombre",
                    HeaderText = "Nombre"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Apellido1",
                    HeaderText = "Apellido1"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Apellido2",
                    HeaderText = "Apellido2"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Password",
                    HeaderText = "Password"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nickname",
                    HeaderText = "Nickname"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PerfilRol",
                    HeaderText = "Perfil"
                });
            }
            else if (typeof(T) == typeof(Comentario))
            {

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "UsuarioNombre",
                    HeaderText = "Usuario"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Mensaje",
                    HeaderText = "Mensaje"
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Puntuacion",
                    HeaderText = "Puntuacion"
                });
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column.HeaderText == "Localidad" && e.Value == null)
                {
                    Monumento monumento = dataGridView1.Rows[e.RowIndex].DataBoundItem as Monumento;
                    if (monumento != null && monumento.Localidad != null)
                    {
                        e.Value = monumento.Localidad.Nombre;
                        e.FormattingApplied = true;
                    }
                }
                else if (column.HeaderText == "Usuario" && e.Value == null)
                {
                    Comentario comentario = dataGridView1.Rows[e.RowIndex].DataBoundItem as Comentario;
                    if (comentario != null && comentario.Usuario != null)
                    {
                        e.Value = comentario.Usuario.Nombre;
                        e.FormattingApplied = true;
                    }
                }
                else if (column.HeaderText == "Perfil" && e.Value == null)
                {
                    Usuario usuario = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                    if (usuario != null && usuario.Perfil != null)
                    {
                        e.Value = usuario.Perfil.Rol;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string textoFiltroNombre = txNombre.Text.Trim();
            string textoFiltroLocalidad = txLocalidad.Text.Trim();
            string textoFiltroProvincia = txProvincia.Text.Trim();
            string textoFiltroNickname = txNickName.Text.Trim();
            string textoFiltroRol = txRol.Text.Trim();

            if (!string.IsNullOrEmpty(textoFiltroNombre) || !string.IsNullOrEmpty(textoFiltroLocalidad) || !string.IsNullOrEmpty(textoFiltroProvincia) ||
         !string.IsNullOrEmpty(textoFiltroNickname) || !string.IsNullOrEmpty(textoFiltroRol))
            {
                FiltrarDatos(textoFiltroNombre, textoFiltroLocalidad, textoFiltroProvincia, textoFiltroNickname, textoFiltroRol);
            }
            else
            {
                dataGridView1.DataSource = currentDataList;
            }
        }

        private void FiltrarDatos(string textoFiltroNombre,string textoFiltroLocalidad, string textoFiltroProvincia, string textoFiltroNickname, string textoFiltroRol)
        {

            if (currentDataList == null)                  
            {                                             
                return;                                   
            }

            if (currentDataList.Count > 0)
            {
                if (currentDataList[0] is Monumento)
                {
                    var listaFiltrada = monumentosData;

                    if (!string.IsNullOrEmpty(textoFiltroNombre))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Nombre != null &&
                                        m.Nombre.IndexOf(textoFiltroNombre, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(textoFiltroLocalidad))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Localidad != null &&
                                        m.Localidad.Nombre != null &&
                                        m.Localidad.Nombre.IndexOf(textoFiltroLocalidad, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }

                    dataGridView1.DataSource = listaFiltrada;
                }
                else if (currentDataList[0] is Localidad)
                {
                    var listaFiltrada = localidadesData;
                    if (!string.IsNullOrEmpty(textoFiltroNombre))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Nombre != null &&
                                        m.Nombre.IndexOf(textoFiltroNombre, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(textoFiltroProvincia))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Provincia != null &&
                                        m.Provincia.IndexOf(textoFiltroProvincia, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }
                    dataGridView1.DataSource = listaFiltrada;
                }
                else if (currentDataList[0] is Artista)
                {
                    var listaFiltrada = artistasData
                        .Where(a => a.Nombre != null && a.Nombre.IndexOf(textoFiltroNombre, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    dataGridView1.DataSource = listaFiltrada;
                }
                else if (currentDataList[0] is Usuario)
                {
                    var listaFiltrada = usuariosData;
                    if (!string.IsNullOrEmpty(textoFiltroNombre))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Nombre != null &&
                                        m.Nombre.IndexOf(textoFiltroNombre, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(textoFiltroNickname))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Nickname != null &&
                                        m.Nickname.IndexOf(textoFiltroNickname, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(textoFiltroRol))
                    {
                        listaFiltrada = listaFiltrada
                            .Where(m => m.Perfil != null &&
                                        m.Perfil.Rol != null &&
                                        m.Perfil.Rol.IndexOf(textoFiltroRol, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
                    }
                    dataGridView1.DataSource = listaFiltrada;
                }
                else if (currentDataList[0] is Comentario)
                {
                    var listaFiltrada = comentariosData
                        .Where(c => c.Usuario.Nombre != null && c.Usuario.Nombre.IndexOf(textoFiltroNombre, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    dataGridView1.DataSource = listaFiltrada;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txLocalidad.Text = string.Empty;
            txNombre.Text = string.Empty;
            txNickName.Text = string.Empty;
            txProvincia.Text = string.Empty;
            txRol.Text = string.Empty;
            btnFiltrar_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTablas.SelectedItem.ToString();
            Monumento monumento = ObtenerMonumentoSeleccionado();
            Form formToOpen = null;

            switch (selectedTable)
            {
                case "monumentos":
                    formToOpen = new MonumentoForm(false);
                    break;
                case "localidades":
                    formToOpen = new LocalidadForm();
                    break;
                case "artistas":
                    formToOpen = new ArtistaForm();
                    break;
                case "usuarios":
                    formToOpen = new UsuarioForm();
                    break;
                case "comentarios":
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione una tabla válida.");
                    return;
            }

            if (formToOpen != null)
            {
                formToOpen.ShowDialog();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar este monumento?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Monumento monumentoSeleccionado = ObtenerMonumentoSeleccionado();

                if (monumentoSeleccionado != null)
                {
                   bool eliminado = await EliminarMonumentoAsync(monumentoSeleccionado.Id);
                   if (eliminado)
                   {
                        await CargarDatosTablaSeleccionada(comboBoxTablas.SelectedItem.ToString());
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún monumento para eliminar.");
                }
            }
        }

        private Monumento ObtenerMonumentoSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                return filaSeleccionada.DataBoundItem as Monumento;
            }

            return null;
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = dataGridView1.SelectedRows.Count > 0;
            btnModificar.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private async Task<bool> EliminarMonumentoAsync(long id)
        {
            try
            {
                HttpResponseMessage response = await apiService.DeleteMonumentoAsync(id);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Monumento eliminado correctamente.");
                    return true;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Monumento no encontrado.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el monumento.");
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el monumento: " + ex.Message);
                return false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTablas.SelectedItem.ToString();
            Monumento monumento = ObtenerMonumentoSeleccionado();
            Form formToOpen = null;

            switch (selectedTable)
            {
                case "monumentos":
                    formToOpen = new MonumentoForm(true, monumento);
                    break;
                case "localidades":
                    formToOpen = new LocalidadForm();
                    break;
                case "artistas":
                    formToOpen = new ArtistaForm();
                    break;
                case "usuarios":
                    formToOpen = new UsuarioForm();
                    break;
                case "comentarios":
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione una tabla válida.");
                    return;
            }

            if (formToOpen != null)
            {
                formToOpen.ShowDialog();
            }
        }
    }
}
