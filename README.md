# EventEase App
### A Blazor WebAssembly Event Management Application Powered by Microsoft Copilot

**EventEase** is a responsive, data-driven event management application built using **Blazor WebAssembly** and **C#**.  
The app allows users to browse events, register with validation, and track attendance — all while leveraging **Microsoft Copilot** to accelerate development, debugging, and optimization.

---

## Project Overview

This project was completed as part of a three-phase learning series that demonstrates the use of **AI-assisted development** through **Microsoft Copilot**.  
Each phase builds upon the last to create a full-featured, production-ready web application.

| Activity | Focus | Key Deliverables |
|-----------|--------|------------------|
| **Activity 1** | Foundational Components | Event Card component, routing setup, and navigation |
| **Activity 2** | Debugging & Optimization | Validation, routing fixes, and performance improvements |
| **Activity 3** | Advanced Features | Registration form, state management, and attendance tracking |

---

## Features

### Core Functionality
- **Dynamic Event Cards** displaying event name, date, and location with two-way data binding  
- **Multi-page Navigation** between Home, Events, Registration, and Attendance pages  
- **Custom 404 Routing** for invalid paths

### Enhanced Capabilities
- **Input Validation** for all user forms using Blazor’s `DataAnnotationsValidator`  
- **State Management** via a singleton `UserSessionService` to persist user data across sessions  
- **Attendance Tracker** page showing current registration details  
- **Optimized Rendering** with `@foreach` and `@key` directives for large datasets  

### 💡 User Experience
- Clean, responsive layout with Bootstrap-based styling  
- Clear validation messages and feedback on form submission  
- Seamless in-app navigation without reloads  

---

## How Microsoft Copilot Assisted

Throughout the project, **Microsoft Copilot** played an active role in accelerating development and maintaining clean, reliable code.

| Phase | Copilot’s Contribution |
|-------|-------------------------|
| **Activity 1 – Component Generation** | Suggested the initial structure of `EventCard.razor` and parameterized data binding syntax. |
| **Activity 2 – Debugging & Optimization** | Identified validation gaps, recommended `@key` usage for rendering, and improved route handling in `App.razor`. |
| **Activity 3 – Advanced Features** | Generated `EditForm` with validation, service dependency injection setup, and state management patterns. |
| **Documentation & Cleanup** | Assisted in drafting structured explanations, summaries, and this README file. |

> *Copilot acted as a coding partner — guiding implementation, detecting inefficiencies, and speeding up repetitive coding tasks.*

---

## Tech Stack

| Category | Technology |
|-----------|-------------|
| **Framework** | Blazor WebAssembly (.NET 9.0) |
| **Language** | C#, Razor |
| **IDE / Tools** | Visual Studio, Microsoft Copilot |
| **Version Control** | Git & GitHub |
| **Styling** | Bootstrap 5 & Scoped CSS |

---

## Getting Started

### Clone the Repository
```bash
git clone https://github.com/dbpatel20/EventEaseApp.git
cd EventEaseApp
