# 🛒 E-Commerce MVC Platform with C# & .NET

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://dotnet.microsoft.com/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-0078D7?style=for-the-badge&logo=microsoft&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![Microsoft SQL Server](https://img.shields.io/badge/SQL%20Server-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)](https://getbootstrap.com/)
[![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)](https://git-scm.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE)

> Aplicación web integral de comercio electrónico desarrollada con **C#** y la arquitectura **ASP.NET MVC**, respaldada por una base de datos relacional en **Microsoft SQL Server**. Implementa gestión de catálogo, control de pedidos, carrito de compras dinámico y autenticación segura con roles de usuario.

---

## 📌 Tabla de Contenidos
- [Descripción General](#-descripción-general)
- [Características Principales](#-características-principales)
- [Stack Tecnológico y Herramientas](#-stack-tecnológico-y-herramientas)
- [Arquitectura de Software](#-arquitectura-de-software)
- [Modelo de Datos](#-modelo-de-datos)
- [Instalación y Configuración](#-instalación-y-configuración)
- [Pruebas y Calidad de Código](#-pruebas-y-calidad-de-código)
- [Contacto y Portafolio](#-contacto-y-portafolio)

---

## 📖 Descripción General

Este proyecto simula una tienda en línea lista para producción, resolviendo los flujos críticos de un e-commerce contemporáneo: navegación fluida de productos, control de inventario, persistencia segura de carritos de compra y procesamiento de órdenes bajo estándares de código limpio (*Clean Code*) y principios **SOLID**.

---

## ✨ Características Principales

### 👤 Experiencia de Usuario (Cliente)
* **Catálogo Dinámico:** Filtrado por categorías, búsqueda por palabras clave y ordenamiento por precios/popularidad.
* **Carrito de Compras:** Gestión en tiempo real con persistencia de sesión o base de datos.
* **Checkout & Órdenes:** Proceso guiado de facturación, selección de dirección de envío y generación de recibo digital.
* **Autenticación y Perfil:** Registro seguro, inicio de sesión (hashing de contraseñas) e historial de compras.

### ⚙️ Panel de Administración (Backoffice)
* **Gestión de Productos (CRUD):** Creación, edición, carga de imágenes y control de stock.
* **Categorización de Inventario:** Administración jerárquica de líneas de producto.
* **Monitoreo de Pedidos:** Actualización de estados (*Pendiente, Procesado, Enviado, Cancelado*).
* **Control de Acceso Basado en Roles (RBAC):** Restricción de áreas sensibles mediante autorización personalizada (`[Authorize(Roles = "Admin")]`).

---

## 🛠️ Stack Tecnológico y Herramientas

### Lenguajes y Frameworks
| Componente | Tecnología |
| :--- | :--- |
| **Backend** | C# (.NET Framework / .NET Core) |
| **Patrón Arquitectónico** | Model-View-Controller (MVC) |
| **Acceso a Datos** | Entity Framework (ORM) / ADO.NET con Stored Procedures |
| **Frontend** | Razor Views (`.cshtml`), HTML5, CSS3, JavaScript |
| **Diseño Responsivo** | Bootstrap 5 & FontAwesome |

### Base de Datos & Persistencia
* **RDBMS:** Microsoft SQL Server (T-SQL)
* **Normalización:** Tercera Forma Normal (3FN), integridad referencial y disparadores/índices optimizados.

### Herramientas de Desarrollo
* <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/visualstudio/visualstudio-plain.svg" width="18" height="18" alt="Visual Studio"/> **IDE:** Visual Studio / Visual Studio Code
* <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/git/git-original.svg" width="18" height="18" alt="Git"/> **Control de Versiones:** Git & GitHub
* <img src="https://www.svgrepo.com/show/303229/microsoft-sql-server-logo.svg" width="18" height="18" alt="SSMS"/> **Gestión de DB:** SQL Server Management Studio (SSMS)

---

## 🏛️ Arquitectura de Software

El sistema sigue la separación de responsabilidades que promueve el patrón **MVC**:

```mermaid
flowchart TD
    Client([Navegador / Cliente]) <-->|HTTP Requests / Responses| Controller[Controladores MVC]
    
    subgraph Capa MVC
        Controller <-->|Pasa ViewModels / Datos| View[Vistas Razor .cshtml]
        Controller <-->|Consulta & Ejecuta Reglas de Negocio| Service[Servicios / Dominio]
    end

    subgraph Capa de Datos
        Service <-->|Mapeo Objeto-Relacional| ORM[Entity Framework / Data Access Layer]
        ORM <-->|Queries T-SQL / Stored Procedures| DB[(Microsoft SQL Server)]
    end
