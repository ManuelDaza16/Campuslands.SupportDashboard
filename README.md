Campuslands.SupportDashboard/
│
├── Data/
│ └── tickets.json # Datos mock de tickets
│
├── Models/
│ └── Ticket.cs # Modelo principal del ticket
│
├── Pages/
│ └── Tickets.razor # Página principal de gestión de tickets
│
├── Services/
│ └── TicketService.cs # Servicio encargado del consumo HTTP simulado
│
├── Shared/
│ ├── MainLayout.razor # Layout principal tipo dashboard
│ └── NavMenu.razor # Barra lateral de navegación
│
├── wwwroot/
│ ├── css/ # Archivos de estilo (Bootstrap)
│ ├── js/ # Plugins y scripts
│ └── index.html
│
└── Program.cs # Configuración de servicios e inyección de dependencias


---

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
