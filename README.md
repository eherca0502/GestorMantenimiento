# 🛠️ GestorMantenimiento

Sistema de gestión y control de equipos informáticos y mantenimientos, desarrollado como una aplicación de escritorio utilizando **C# Windows Forms** y **SQL Server**.

El sistema permite llevar un control centralizado de los equipos, usuarios, mantenimientos realizados, garantías y reportes, facilitando la administración y seguimiento del inventario tecnológico.

## 📋 Características

* 🔐 **Inicio de sesión**

  * Autenticación mediante usuario y contraseña.
  * Control de usuarios activos.
  * Identificación del rol del usuario.

* 💻 **Gestión de equipos**

  * Registro de equipos.
  * Consulta y búsqueda de equipos.
  * Información de marca, modelo, número de serie y características.
  * Usuario y área asignada.
  * Estado del equipo.
  * Fechas de adquisición y garantía.
  * Observaciones.

* 🔧 **Gestión de mantenimientos**

  * Registro de mantenimientos.
  * Asociación del mantenimiento con un equipo.
  * Tipo de mantenimiento.
  * Registro de problema, diagnóstico y solución.
  * Control de costos.
  * Fecha y observaciones.
  * Consulta del historial de mantenimientos.

* 🛡️ **Control de garantías**

  * Consulta de garantías de los equipos.
  * Identificación de garantías vigentes.
  * Detección de garantías próximas a vencer.
  * Identificación de garantías vencidas.
  * Visualización de días restantes.

* 👥 **Gestión de usuarios**

  * Registro y administración de usuarios.
  * Roles de usuario.
  * Activación y desactivación de cuentas.
  * Búsqueda de usuarios.

* 📊 **Reportes**

  * Reportes de equipos.
  * Reportes de mantenimientos.
  * Reportes de garantías.
  * Resumen de equipos registrados.
  * Total de mantenimientos.
  * Garantías vigentes.
  * Costo total de mantenimientos.

* 📈 **Dashboard**

  * Resumen general de la información.
  * Visualización de actividad reciente.
  * Indicadores principales del sistema.

## 🧰 Tecnologías utilizadas

| Tecnología             | Uso                      |
| ---------------------- | ------------------------ |
| **C#**                 | Lenguaje principal       |
| **Windows Forms**      | Interfaz gráfica         |
| **.NET Framework 4.8** | Plataforma de desarrollo |
| **SQL Server**         | Base de datos            |
| **ADO.NET**            | Acceso a datos           |
| **Visual Studio**      | Entorno de desarrollo    |

## 🏗️ Arquitectura

El proyecto utiliza una estructura organizada separando la interfaz, modelos y acceso a datos:

```text
GestorMantenimiento/
│
├── Data/
│   ├── EquipoDAO.cs
│   ├── MantenimientosDAO.cs
│   ├── ReportesDAO.cs
│   └── UsuariosDAO.cs
│
├── Models/
│   ├── Equipo.cs
│   └── Usuario.cs
│
├── EquipoForm.cs
├── EquiposForm.cs
├── GarantiasForm.cs
├── LoginForm.cs
├── MainForm.cs
├── MantenimientosForm.cs
├── ReportesForm.cs
├── UsuariosForm.cs
│
├── Conexion.cs
├── Program.cs
├── App.config
└── GestorMantenimiento.csproj
```

## 🗄️ Base de datos

El sistema utiliza **SQL Server** para almacenar la información relacionada con:

* Usuarios
* Equipos
* Mantenimientos
* Garantías
* Información necesaria para los reportes

La conexión con la base de datos se gestiona mediante la clase:

```text
Conexion.cs
```

> ⚠️ La cadena de conexión debe configurarse de acuerdo con la instancia de SQL Server utilizada en cada equipo.

## 🚀 Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/GestorMantenimiento.git
```

### 2. Abrir el proyecto

Abrir:

```text
GestorMantenimiento.slnx
```

o el archivo de solución compatible con la versión de Visual Studio utilizada.

### 3. Configurar SQL Server

Crear la base de datos necesaria en SQL Server y configurar la conexión utilizada por el proyecto.

### 4. Compilar

Desde Visual Studio:

```text
Build → Build Solution
```

o utilizar:

```text
Ctrl + Shift + B
```

### 5. Ejecutar

Iniciar el proyecto desde Visual Studio con:

```text
F5
```

## 🔑 Acceso

El sistema requiere un usuario registrado y activo en la base de datos para poder iniciar sesión.

Los usuarios y sus roles son administrados desde el módulo correspondiente.

> Por seguridad, no se incluyen credenciales reales dentro del repositorio.

## 📊 Módulos principales

### Dashboard

Presenta un resumen de la información del sistema y actividad reciente para facilitar la supervisión general.

### Equipos

Permite administrar el inventario de equipos informáticos y consultar sus principales características.

### Mantenimientos

Permite registrar y consultar el historial de reparaciones y mantenimientos realizados a cada equipo.

### Garantías

Facilita el seguimiento de las fechas de garantía y permite identificar equipos con garantías próximas a vencer.

### Usuarios

Permite administrar las cuentas utilizadas para acceder al sistema.

### Reportes

Centraliza información de equipos, mantenimientos y garantías para facilitar la consulta y análisis de la información.

## 🔒 Consideraciones de seguridad

Para utilizar el proyecto en un entorno real se recomienda:

* No subir contraseñas reales al repositorio.
* No publicar cadenas de conexión con credenciales.
* Utilizar usuarios de SQL Server con permisos mínimos necesarios.
* Implementar hash de contraseñas en lugar de almacenar contraseñas en texto plano.
* Configurar las credenciales mediante variables de entorno o archivos de configuración fuera del repositorio.

## 📌 Estado del proyecto

**Estado:** En desarrollo / funcional.

El proyecto puede seguir ampliándose con nuevas funcionalidades, mejoras de seguridad, exportación de reportes y nuevas herramientas de administración.




---

⭐ Si este proyecto te resulta útil, considera darle una estrella al repositorio.
