# 🧭 Campuslands Support Dashboard

**Proyecto desarrollado como prueba técnica Blazor – Campuslands (Octubre 2025).**  
El objetivo es construir un **mini dashboard administrativo** que permite listar, filtrar y gestionar **tickets de soporte** mediante una API simulada.  
Se enfoca en **buenas prácticas**, **estructura limpia**, **diseño moderno** y **uso correcto de Blazor Server** con asincronía y servicios inyectados.

---

## 🚀 Características principales

- 📋 **Listado de tickets:** muestra todos los tickets registrados en el sistema.  
- 🔍 **Filtrado dinámico:** permite filtrar por estado (`Abierto`, `En progreso`, `Cerrado`) sin recargar toda la lista.  
- 👁️ **Detalle del ticket:** muestra la información completa al seleccionarlo.  
- 🔄 **Cambio de estado:** permite actualizar el estado del ticket mediante un `PATCH` simulado.  
- ⚙️ **Interfaz moderna y responsiva:** implementada con **Bootstrap 5** y **Bootstrap Table**.  

## 🧩 Tecnologías utilizadas

- **.NET 8 Blazor Server**
- **C# 12**
- **Bootstrap 5**
- **Bootstrap Table (plugin JS)**
- **HttpClient (simulado con JSON local)**
- **Dependency Injection**
- **Asincronía con async/await**

---

## 🧠 Principios y buenas prácticas aplicadas

- Separación clara entre **UI**, **lógica de negocio** y **modelos**.
- Estructura modular siguiendo la convención `Pages/`, `Services/`, `Models/`.
- Uso correcto de `@inject` para los servicios.
- Código limpio, nombrado coherente y tipado fuerte.
- Uso de `try/catch` y `Task` asíncronos para consumo de datos.

---

## 🧪 Cómo ejecutar el proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/ManuelDaza16/Campuslands.SupportDashboard.git


Abrir el proyecto en Visual Studio 2022 o VS Code.

Asegurarse de tener instalado .NET 8 SDK.
