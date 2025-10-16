using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controladora;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;



namespace Vista
{
    public partial class FormUsuarios : Form
    {
        private ControladoraUsuarios _controladoraUsuarios;

        public FormUsuarios()
        {
            InitializeComponent();
            _controladoraUsuarios = new ControladoraUsuarios(new SistemaBibliotecario());
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.StartPosition = FormStartPosition.Manual;
            // Establecer la ubicación del formulario en la pantalla (por ejemplo, en las coordenadas 100, 100)
            this.Location = new Point(100, 100);
            ConfigurarEventosMouseBotones(this);

        }
        private void ConfigurarEventosMouseBotones(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    // Asociar eventos MouseEnter y MouseLeave al botón
                    button.MouseEnter += (sender, e) => CambiarColorBoton(button, Color.MediumVioletRed);
                    button.MouseLeave += (sender, e) => CambiarColorBoton(button, Color.Black);
                }
            }
        }

        private void CambiarColorBoton(Button button, Color color)
        {
            button.BackColor = color;
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            InicializarDataGridView();
            CargarUsuarios();
            dataGridViewUsuarios.CellValueChanged += dataGridViewUsuarios_CellValueChanged;
            dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellClick;
        }
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 📌 Verificar si se hizo clic en el botón "Editar"
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewUsuarios.Columns["Modificar"].Index)
            {
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells["UsuarioId"].Value);

                using (var context = new SistemaBibliotecario()) // ⚠ Asegurar el contexto correcto
                {
                    var usuario = context.Usuarios.Find(usuarioId);
                    if (usuario != null)
                    {
                        // ✏ Obtener los valores actualizados
                        usuario.Nombre = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                        usuario.Apellido = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                        usuario.Dni = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                        usuario.Rol = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                        usuario.Activo = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Estado"].Value);

                        // 💾 Guardar cambios en la base de datos
                        context.SaveChanges();

                        // 🚀 Volver a cargar los datos para reflejar los cambios
                        CargarUsuarios();

                        // ✅ Confirmar modificación
                        MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si la celda corresponde a la columna del botón "Editar"
                if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                {
                    // Obtener el ID del usuario seleccionado
                    int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells["UsuarioId"].Value);

                    // Obtener el usuario de la base de datos
                    var usuario = _controladoraUsuarios.ObtenerUsuarioPorId(usuarioId);
                    if (usuario != null)
                    {
                        // Actualizar los datos del usuario con los valores de la fila editada
                        usuario.Nombre = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                        usuario.Apellido = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                        usuario.Dni = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                        usuario.Rol = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                        usuario.Activo = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Activo"].Value);
                        usuario.PuedeBorrarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeBorrarSocios"].Value);
                        usuario.PuedeModificarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeModificarSocios"].Value);
                        usuario.PuedeBorrarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeBorrarLibros"].Value);
                        usuario.PuedeModificarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeModificarLibros"].Value);
                        usuario.PuedeModificarValorCuota = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeModificarValorCuota"].Value);
                        usuario.PuedeCobrarCuotas = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeCobrarCuotas"].Value);
                        usuario.PuedeCambiarReglas = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeCambiarReglas"].Value);
                        usuario.PuedeVerRegistros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeVerRegistros"].Value);
                        usuario.PuedeGestionarUsuarios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeGestionarUsuarios"].Value);

                        // Guardar los cambios en la base de datos
                        _controladoraUsuarios.ModificarUsuario(usuario);

                        // 🚀 Recargar la lista para reflejar los cambios
                        CargarUsuarios();
                    }
                }
            }
        }
        private void dataGridViewUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evitar errores si la fila no es válida
            {
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells["UsuarioId"].Value);

                var usuario = _controladoraUsuarios.ObtenerUsuarioPorId(usuarioId);
                if (usuario != null)
                {
                    usuario.Nombre = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    usuario.Apellido = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    usuario.Dni = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                    usuario.Rol = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                    usuario.Activo = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Activo"].Value);
                    usuario.PuedeBorrarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeBorrarSocios"].Value);
                    usuario.PuedeModificarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeModificarSocios"].Value);
                    usuario.PuedeBorrarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeBorrarLibros"].Value);
                    usuario.PuedeModificarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeModificarLibros"].Value);
                    usuario.PuedeModificarValorCuota = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeModificarValorCuota"].Value);
                    usuario.PuedeCobrarCuotas = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeCobrarCuotas"].Value);
                    usuario.PuedeCambiarReglas = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeCambiarReglas"].Value);
                    usuario.PuedeVerRegistros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeVerRegistros"].Value);
                    usuario.PuedeGestionarUsuarios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PuedeGestionarUsuarios"].Value);

                    // Guardar cambios en la base de datos
                    _controladoraUsuarios.ModificarUsuario(usuario);

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Usuario actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🚀 Actualizar DataGridView después de cerrar el mensaje
                    CargarUsuarios();

                    // 💡 Forzar la actualización de la UI
                    dataGridViewUsuarios.Refresh();
                    dataGridViewUsuarios.Update();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0) // Verificar si hay una fila seleccionada
            {
                int filaIndex = dataGridViewUsuarios.SelectedRows[0].Index;
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[filaIndex].Cells["UsuarioId"].Value);

                using (var context = new SistemaBibliotecario()) // 📌 Asegurar contexto correcto
                {
                    var usuario = context.Usuarios.Find(usuarioId);
                    if (usuario != null)
                    {
                        // Sobreescribir los datos en la base de datos
                        usuario.Nombre = dataGridViewUsuarios.Rows[filaIndex].Cells["Nombre"].Value.ToString();
                        usuario.Apellido = dataGridViewUsuarios.Rows[filaIndex].Cells["Apellido"].Value.ToString();
                        usuario.Dni = dataGridViewUsuarios.Rows[filaIndex].Cells["Dni"].Value.ToString();
                        usuario.Rol = dataGridViewUsuarios.Rows[filaIndex].Cells["Rol"].Value.ToString();
                        usuario.Activo = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["Activo"].Value);
                        usuario.PuedeBorrarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeBorrarSocios"].Value);
                        usuario.PuedeModificarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeModificarSocios"].Value);
                        usuario.PuedeBorrarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeBorrarLibros"].Value);
                        usuario.PuedeModificarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeModificarLibros"].Value);
                        usuario.PuedeModificarValorCuota = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeModificarValorCuota"].Value);
                        usuario.PuedeCobrarCuotas = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeCobrarCuotas"].Value);
                        usuario.PuedeCambiarReglas = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeCambiarReglas"].Value);
                        usuario.PuedeVerRegistros = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeVerRegistros"].Value);
                        usuario.PuedeGestionarUsuarios = Convert.ToBoolean(dataGridViewUsuarios.Rows[filaIndex].Cells["PuedeGestionarUsuarios"].Value);

                        context.SaveChanges(); // 💾 Guardar cambios en la base de datos
                    }
                }

                // 🚀 Recargar DataGridView después de actualizar
                CargarUsuarios();

                // 🔄 Forzar la actualización en pantalla
                dataGridViewUsuarios.ClearSelection();
                dataGridViewUsuarios.Refresh();
                dataGridViewUsuarios.Update();

                // ✅ Confirmar modificación
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void InicializarDataGridView()
        {
            dataGridViewUsuarios.Columns.Clear();

            // 🔹 Habilitar edición
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.ReadOnly = false;

            // 🔹 Agregar columna de botón "Editar" al principio
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.Name = "Modificar";
            btnModificar.HeaderText = "Acción";
            btnModificar.Text = "Editar";
            btnModificar.UseColumnTextForButtonValue = true;
            dataGridViewUsuarios.Columns.Add(btnModificar);

            // 🔹 Agregar las demás columnas
            dataGridViewUsuarios.Columns.Add("UsuarioId", "ID");
            dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
            dataGridViewUsuarios.Columns.Add("Apellido", "Apellido");
            dataGridViewUsuarios.Columns.Add("Dni", "DNI");
            dataGridViewUsuarios.Columns.Add("Rol", "Rol");
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Estado", HeaderText = "Estado" });

            // 🔹 Permisos como CheckBox
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoBorrarSocios", HeaderText = "Borrar Socios" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoModificarSocios", HeaderText = "Modificar Socios" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoBorrarLibros", HeaderText = "Borrar Libros" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoModificarLibros", HeaderText = "Modificar Libros" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoValorCuota", HeaderText = "Valor Cuota" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoCobrarCuotas", HeaderText = "Cobrar Cuotas" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoCambiarReglas", HeaderText = "Cambiar Reglas" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoVerRegistros", HeaderText = "Ver Registros" });
            dataGridViewUsuarios.Columns.Add(new DataGridViewCheckBoxColumn { Name = "PermisoGestionarUsuarios", HeaderText = "Gestionar Usuarios" });

            // 🔹 Hacer que la columna ID no sea editable
            dataGridViewUsuarios.Columns["UsuarioId"].ReadOnly = true;
        }

        private void dataGridViewUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 📌 Evitar errores en columnas sin datos
                if (e.ColumnIndex < 0 || dataGridViewUsuarios.Columns[e.ColumnIndex] is DataGridViewButtonColumn) return;

                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells["UsuarioId"].Value);

                using (var context = new SistemaBibliotecario()) // ⚠ Asegurar el contexto correcto
                {
                    var usuario = context.Usuarios.Find(usuarioId);
                    if (usuario != null)
                    {
                        // ✏ Detectar cambios en CheckBoxes y actualizar valores
                        usuario.Activo = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Estado"].Value);
                        usuario.PuedeBorrarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoBorrarSocios"].Value);
                        usuario.PuedeModificarSocios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoModificarSocios"].Value);
                        usuario.PuedeBorrarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoBorrarLibros"].Value);
                        usuario.PuedeModificarLibros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoModificarLibros"].Value);
                        usuario.PuedeModificarValorCuota = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoValorCuota"].Value);
                        usuario.PuedeCobrarCuotas = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoCobrarCuotas"].Value);
                        usuario.PuedeCambiarReglas = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoCambiarReglas"].Value);
                        usuario.PuedeVerRegistros = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoVerRegistros"].Value);
                        usuario.PuedeGestionarUsuarios = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells["PermisoGestionarUsuarios"].Value);

                        // 💾 Guardar cambios en la base de datos
                        context.SaveChanges();

                        // 🚀 Actualizar visualmente
                        dataGridViewUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    }
                }
            }
        }



        private void CargarUsuarios()
        {
            dataGridViewUsuarios.Rows.Clear();

            var usuarios = _controladoraUsuarios.ObtenerTodosLosUsuarios(); // 🚀 Obtener datos actualizados

            foreach (var usuario in usuarios)
            {
                dataGridViewUsuarios.Rows.Add(
                    "Editar", // El botón "Editar"
                    usuario.UsuarioId,
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Dni,
                    usuario.Rol,
                    usuario.Activo,
                    usuario.PuedeBorrarSocios,
                    usuario.PuedeModificarSocios,
                    usuario.PuedeBorrarLibros,
                    usuario.PuedeModificarLibros,
                    usuario.PuedeModificarValorCuota,
                    usuario.PuedeCobrarCuotas,
                    usuario.PuedeCambiarReglas,
                    usuario.PuedeVerRegistros,
                    usuario.PuedeGestionarUsuarios
                );
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario y quitar espacios adicionales
            string nombre = textBoxNombre.Text.Trim();
            string apellido = textBoxApellido.Text.Trim();
            string dni = textBoxDni.Text.Trim();
            string clave = dni; // La clave es el DNI del usuario

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que nombre y apellido contengan solo letras (y espacios)
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre debe contener solo letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(apellido, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El apellido debe contener solo letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el DNI contenga solo números
            if (!System.Text.RegularExpressions.Regex.IsMatch(dni, @"^\d+$"))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un rol en el ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string rol = comboBox1.SelectedItem.ToString();

            // Crear el objeto Usuario y asignar datos básicos
            var nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Rol = rol,
                Activo = true, // Por defecto, el usuario se guarda activo
                ClaveModificada = false // Por defecto, la contraseña no ha sido cambiada
            };

            // Asignar el nombre de usuario (usando el DNI)
            nuevoUsuario.NombreDeUsuario = dni;  // El nombre de usuario es el DNI
            nuevoUsuario.Clave = clave;  // La clave es el DNI
            nuevoUsuario.PalabraDeSeguridad = nombre;  // Asignar el nombre a la palabra de seguridad

            // Asignar permisos según el rol
            if (rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                // Para Administrador, asignar todos los permisos
                nuevoUsuario.PuedeBorrarSocios = true;
                nuevoUsuario.PuedeModificarSocios = true;
                nuevoUsuario.PuedeBorrarLibros = true;
                nuevoUsuario.PuedeModificarLibros = true;
                nuevoUsuario.PuedeModificarValorCuota = true;
                nuevoUsuario.PuedeCobrarCuotas = true;
                nuevoUsuario.PuedeCambiarReglas = true;
                nuevoUsuario.PuedeVerRegistros = true;
                nuevoUsuario.PuedeGestionarUsuarios = true;
            }
            else if (rol.Equals("Bibliotecario", StringComparison.OrdinalIgnoreCase))
            {
                // Para Bibliotecario, asignar permisos más limitados
                nuevoUsuario.PuedeBorrarSocios = false;
                nuevoUsuario.PuedeModificarSocios = false;
                nuevoUsuario.PuedeBorrarLibros = false;
                nuevoUsuario.PuedeModificarLibros = false;
                nuevoUsuario.PuedeModificarValorCuota = false;
                nuevoUsuario.PuedeCobrarCuotas = false;
                nuevoUsuario.PuedeCambiarReglas = false;
                nuevoUsuario.PuedeVerRegistros = true;  // El bibliotecario puede ver registros
                nuevoUsuario.PuedeGestionarUsuarios = false;
            }

            // Llamada al método RegistrarUsuario con los parámetros correctos
            _controladoraUsuarios.RegistrarUsuario(nombre, apellido, dni, clave, rol);

            // Notificar éxito
            MessageBox.Show("Usuario registrado con éxito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }



        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDni.Clear();
            comboBox1.SelectedIndex = -1;
        }



        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ControladoraMultas controladora = new ControladoraMultas();

            // Pasar el objeto 'controladora' al constructor de FormMenu
            FormMenu menuForm = new FormMenu(controladora);
            menuForm.Show(); // Abre el formulario de Menu

            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["UsuarioId"].Value);

                using (var context = new SistemaBibliotecario()) // Asegúrate de usar tu contexto correcto
                {
                    var usuario = context.Usuarios.Find(usuarioId);
                    if (usuario != null)
                    {
                        var confirmacion = MessageBox.Show($"¿Seguro que deseas eliminar al usuario {usuario.Nombre}?",
                                                           "Confirmar eliminación",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Warning);

                        if (confirmacion == DialogResult.Yes)
                        {
                            context.Usuarios.Remove(usuario);
                            context.SaveChanges();
                            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarUsuarios(); // Recarga el DataGridView después de eliminar
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario antes de eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var filaSeleccionada = dataGridViewUsuarios.SelectedRows[0];

                // Verifica si la fila tiene los datos correctos
                string nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value?.ToString();
                string dni = filaSeleccionada.Cells["Dni"].Value?.ToString();
                string rol = filaSeleccionada.Cells["Rol"].Value?.ToString();

                // Mostrar mensaje con los valores obtenidos
                MessageBox.Show($"Nombre: {nombre}, Apellido: {apellido}, DNI: {dni}, Rol: {rol}");

                // Asignar los valores de la fila a los controles correspondientes
                textBoxNombre.Text = nombre ?? string.Empty;
                textBoxApellido.Text = apellido ?? string.Empty;
                textBoxDni.Text = dni ?? string.Empty;

                // Asegúrate de que el ComboBox contenga los valores que puedes seleccionar
                if (!string.IsNullOrEmpty(rol) && comboBox1.Items.Contains(rol))
                {
                    comboBox1.SelectedItem = rol;
                }
                else
                {
                    MessageBox.Show("Rol no encontrado en el ComboBox");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
            string dniIngresado = textBox1.Text.Trim(); // Obtener el DNI desde el TextBox

            if (!string.IsNullOrEmpty(dniIngresado))
            {
                // Usamos la controladora para obtener el usuario por el DNI
                var usuario = _controladoraUsuarios.ObtenerUsuarioPorDni(dniIngresado);

                if (usuario != null)
                {
                    // Actualizar la clave y la palabra de seguridad
                    usuario.Clave = dniIngresado;  // La clave es el DNI
                    usuario.PalabraDeSeguridad = usuario.Nombre;  // La palabra de seguridad es el nombre del usuario

                    try
                    {
                        // Usamos la controladora para modificar al usuario
                        _controladoraUsuarios.ModificarUsuario(usuario);

                        MessageBox.Show("La contraseña y la palabra de seguridad se han actualizado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar los datos: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con el DNI ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
