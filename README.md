# 🛠️ GestorMantenimiento

Sistema de escritorio para la **gestión y control de equipos de cómputo, mantenimientos, garantías y tickets de soporte técnico**.

El proyecto fue desarrollado como una aplicación de escritorio utilizando **C# y Windows Forms**, con **SQL Server** como sistema gestor de base de datos.

---

## 📋 Descripción

**GestorMantenimiento** es una aplicación diseñada para facilitar la administración de los equipos tecnológicos de una organización y llevar un control centralizado de sus mantenimientos.

El sistema permite registrar y consultar información de los equipos, administrar usuarios, controlar mantenimientos y dar seguimiento a garantías y tickets de soporte.

Su objetivo es mantener organizada la información del área de sistemas y facilitar el seguimiento de las actividades de mantenimiento.

---

## ✨ Características

* 🔐 Inicio de sesión de usuarios.
* 👥 Gestión de usuarios y roles.
* 💻 Registro y administración de equipos.
* 🔧 Gestión de mantenimientos.
* 🛡️ Control y seguimiento de garantías.
* 🎫 Administración de tickets.
* 📊 Panel principal con indicadores.
* 🔎 Consulta de información mediante tablas.
* ✏️ Registro, edición y eliminación de información.
* 📅 Registro de fechas de adquisición, garantía y mantenimiento.
* 🗄️ Integración con SQL Server.
* 🔒 Control de acceso mediante usuarios y roles.

---

## 📦 Módulos del sistema

### 🔐 Usuarios

Permite administrar los usuarios que tienen acceso al sistema.

Información principal:

* ID
* Nombre de usuario
* Contraseña
* Rol
* Estado activo/inactivo

---

### 💻 Equipos

Permite registrar y administrar el inventario de equipos tecnológicos.

Datos registrados:

* Código
* Tipo de equipo
* Marca
* Modelo
* Número de serie
* Usuario asignado
* Área
* Sistema operativo
* RAM
* Almacenamiento
* Dirección IP
* Fecha de adquisición
* Fecha de garantía
* Estado
* Observaciones
* Fecha de registro

---

### 🔧 Mantenimientos

Permite llevar un historial de los mantenimientos realizados a los equipos.

El módulo permite registrar y consultar información relacionada con las actividades de mantenimiento y su seguimiento.

---

### 🛡️ Garantías

Permite consultar y dar seguimiento a las garantías asociadas con los equipos registrados.

---

### 🎫 Tickets

Permite registrar solicitudes o incidencias relacionadas con soporte técnico y dar seguimiento a su atención.

---

### 📊 Dashboard

El sistema cuenta con un panel principal que permite visualizar información general mediante indicadores, como:

* Total de equipos
* Mantenimientos
* Garantías
* Tickets
* Actividad reciente

---

## 🛠️ Tecnologías utilizadas

| Tecnología             | Uso                       |
| ---------------------- | ------------------------- |
| **C#**                 | Lenguaje principal        |
| **Windows Forms**      | Interfaz gráfica          |
| **.NET Framework 4.8** | Plataforma de desarrollo  |
| **SQL Server**         | Base de datos             |
| **ADO.NET**            | Conexión y acceso a datos |
| **Visual Studio**      | Entorno de desarrollo     |
| **Git / GitHub**       | Control de versiones      |

---

## 🗄️ Base de datos

El proyecto utiliza **Microsoft SQL Server** para almacenar la información del sistema.

La base de datos contiene las estructuras necesarias para trabajar con los diferentes módulos de la aplicación.

Entre las principales entidades se encuentran:

* `usuarios`
* `equipos`
* `mantenimientos`
* `garantias`
* `tickets`

La estructura de la base de datos se encuentra incluida dentro del proyecto para facilitar su configuración.

> **Importante:** antes de ejecutar la aplicación, es necesario configurar correctamente la cadena de conexión de SQL Server de acuerdo con el servidor y la instancia utilizados.

---

## ⚙️ Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/eherca0502/GestorMantenimiento.git
```

### 2. Abrir el proyecto

Abrir el archivo:

```text
GestorMantenimiento.slnx
```

utilizando **Visual Studio**.

---

### 3. Configurar SQL Server

Asegúrate de tener instalado:

* Microsoft SQL Server
* SQL Server Management Studio (SSMS)

Crear o restaurar la base de datos incluida en el proyecto.

Después, configurar la cadena de conexión utilizada por la aplicación.

Ejemplo:

```csharp
Server=SERVIDOR;
Database=GestorMantenimiento;
Integrated Security=True;
TrustServerCertificate=True;
```

Si utilizas una instancia específica de SQL Server:

```csharp
Server=SERVIDOR\INSTANCIA;
Database=GestorMantenimiento;
Integrated Security=True;
TrustServerCertificate=True;
```

> La cadena de conexión debe adaptarse al servidor SQL Server de cada equipo.

---

### 4. Restaurar dependencias

Desde Visual Studio:

**Build → Rebuild Solution**

o ejecutar:

```bash
dotnet restore
```

si corresponde a la configuración del proyecto.

---

### 5. Ejecutar

Una vez configurada la base de datos y la conexión:

1. Abrir la solución en Visual Studio.
2. Establecer el proyecto como proyecto de inicio.
3. Compilar la solución.
4. Ejecutar la aplicación.

---

## 🔑 Acceso al sistema

El acceso se realiza mediante el módulo de inicio de sesión.

Los usuarios son administrados desde la tabla:

```text
usuarios
```

El sistema contempla diferentes roles para controlar el acceso a las funcionalidades disponibles.

---

## 📁 Estructura del proyecto

```text
GestorMantenimiento/
│
├── GestorMantenimiento/
│   ├── DAO/
│   ├── Forms/
│   ├── Models/
│   ├── Conexion.cs
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   └── ...
│
├── .gitignore
├── .gitattributes
├── GestorMantenimiento.slnx
└── README.md
```

> La estructura puede variar conforme el proyecto continúe evolucionando.

---

## 🎯 Objetivo del proyecto

El objetivo principal de **GestorMantenimiento** es proporcionar una herramienta sencilla y organizada para administrar los recursos tecnológicos de una organización.

El sistema busca centralizar la información relacionada con:

**Equipos → Usuarios → Mantenimientos → Garantías → Tickets**

permitiendo mejorar el control del inventario y el seguimiento del soporte técnico.

---

## 🚀 Próximas mejoras

Algunas funcionalidades que pueden incorporarse posteriormente:

* 📈 Reportes y estadísticas avanzadas.
* 📄 Exportación de información a Excel o PDF.
* 🔔 Notificaciones de garantías próximas a vencer.
* ⏰ Alertas de mantenimientos preventivos.
* 📊 Gráficas en el dashboard.
* 🔐 Mejoras adicionales de seguridad.
* 👤 Administración avanzada de permisos por rol.
* 📝 Historial detallado de cambios.
* 💾 Sistema de respaldos de la base de datos.

---



Si este proyecto te resulta útil, puedes darle ⭐ al repositorio.
