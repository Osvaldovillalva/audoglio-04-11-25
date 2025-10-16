using Entidades;
using Modelo;

public class ControladoraUsuarios
{
    private SistemaBibliotecario _context;

    // Constructor donde se inyecta el contexto
    public ControladoraUsuarios(SistemaBibliotecario context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context)); // Aseguramos que el contexto no sea null
    }

    // Método para registrar un nuevo usuario
    public void RegistrarUsuario(string nombre, string apellido, string dni, string clave, string rol)
    {
        // Validación de que los campos no estén vacíos
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(rol))
        {
            throw new ArgumentException("Por favor, complete todos los campos.");
        }

        // Validar que el nombre y apellido solo contengan letras (y espacios)
        if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
        {
            throw new ArgumentException("El nombre solo debe contener letras.");
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(apellido, @"^[a-zA-Z\s]+$"))
        {
            throw new ArgumentException("El apellido solo debe contener letras.");
        }

        // Validar que el DNI solo contenga números
        if (!System.Text.RegularExpressions.Regex.IsMatch(dni, @"^\d+$"))
        {
            throw new ArgumentException("El DNI debe contener solo números.");
        }

        // Asegurarse de que 'PalabraDeSeguridad' no sea nulo ni vacío
        if (string.IsNullOrEmpty(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacío.");
        }

        // Crear el objeto Usuario
        var usuario = new Usuario
        {
            Nombre = nombre,
            Apellido = apellido,
            Dni = dni,
            Clave = dni, // La clave es el DNI del usuario
            Rol = rol,
            NombreDeUsuario = dni, // El nombre de usuario es el DNI
            PalabraDeSeguridad = string.IsNullOrEmpty(nombre) ? "" : nombre // Asegurar que siempre se asigne un valor (cadena vacía si el nombre está vacío)
        };

        try
        {
            // Intentamos agregar el usuario al contexto y guardar los cambios
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            // Si ocurre un error durante el guardado, lanzamos una excepción
            throw new InvalidOperationException("Error al registrar el usuario.", ex);
        }
    }





    public void ModificarUsuario(Usuario usuarioModificado)
    {
        try
        {
            // Buscar el usuario en la base de datos
            var usuarioExistente = _context.Usuarios.Find(usuarioModificado.UsuarioId);

            if (usuarioExistente != null)
            {
                // Actualizar los datos del usuario
                usuarioExistente.Nombre = usuarioModificado.Nombre;
                usuarioExistente.Apellido = usuarioModificado.Apellido;
                usuarioExistente.Dni = usuarioModificado.Dni;
                usuarioExistente.Rol = usuarioModificado.Rol;
                usuarioExistente.Activo = usuarioModificado.Activo;

                // Guardar los cambios en la base de datos
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuario no encontrado.");
            }
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al modificar el usuario: {ex.Message}");
            throw;
        }
    }

    // Método para autenticar al usuario durante el login
    public Usuario AutenticarUsuario(string dni, string clave)
    {
        try
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Dni == dni);
            if (usuario != null && usuario.Clave == clave)  // Comparamos la clave directamente sin encriptarla
            {
                return usuario;
            }
            return null;
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al autenticar el usuario: {ex.Message}");
            throw;
        }
    }

    // Método para cambiar la contraseña de un usuario
    public void CambiarClave(int usuarioId, string nuevaClave)
    {
        try
        {
            var usuario = _context.Usuarios.Find(usuarioId);
            if (usuario != null)
            {
                usuario.Clave = nuevaClave;  // Guardamos la nueva clave directamente sin encriptarla
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuario no encontrado.");
            }
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al cambiar la clave: {ex.Message}");
            throw;
        }
    }

    // Método para obtener un usuario por su ID
    public Usuario ObtenerUsuarioPorId(int id)
    {
        try
        {
            return _context.Usuarios.Find(id);
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al obtener el usuario por ID: {ex.Message}");
            throw;
        }
    }

    // Método para obtener todos los usuarios
    public IQueryable<Usuario> ObtenerTodosLosUsuarios()
    {
        try
        {
            return _context.Usuarios;
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al obtener todos los usuarios: {ex.Message}");
            throw;
        }
    }

    // Método para obtener un usuario por su DNI
    public Usuario ObtenerUsuarioPorDni(string dni)
    {
        try
        {
            return _context.Usuarios.FirstOrDefault(u => u.Dni == dni);
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al obtener el usuario por DNI: {ex.Message}");
            throw;
        }
    }

    // Método para actualizar un permiso en base al índice de columna
    public void ActualizarPermiso(int usuarioId, int columnaIndex, bool permisoActivo)
    {
        try
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.UsuarioId == usuarioId);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado");
            }

            // Convertir el índice de la columna (7 a 15) a un índice relativo a los permisos (0 a 8)
            int permisoIndex = columnaIndex - 7;
            switch (permisoIndex)
            {
                case 0: // PermisoBorrarSocios
                    usuario.PuedeBorrarSocios = permisoActivo;
                    break;
                case 1: // PermisoModificarSocios
                    usuario.PuedeModificarSocios = permisoActivo;
                    break;
                case 2: // PermisoBorrarLibros
                    usuario.PuedeBorrarLibros = permisoActivo;
                    break;
                case 3: // PermisoModificarLibros
                    usuario.PuedeModificarLibros = permisoActivo;
                    break;
                case 4: // PermisoValorCuota
                    usuario.PuedeModificarValorCuota = permisoActivo;
                    break;
                case 5: // PermisoCobrarCuotas
                    usuario.PuedeCobrarCuotas = permisoActivo;
                    break;
                case 6: // PermisoCambiarReglas
                    usuario.PuedeCambiarReglas = permisoActivo;
                    break;
                case 7: // PermisoVerRegistros
                    usuario.PuedeVerRegistros = permisoActivo;
                    break;
                case 8: // PermisoGestionarUsuarios
                    usuario.PuedeGestionarUsuarios = permisoActivo;
                    break;
                default:
                    throw new ArgumentException("Índice de columna no válido", nameof(columnaIndex));
            }

            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine($"Error al actualizar permiso: {ex.Message}");
            throw;
        }
    }







}
