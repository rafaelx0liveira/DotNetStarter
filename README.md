# DotNetStarter

**DotNetStarter** is a CLI (Command Line Interface) tool designed to help .NET developers quickly and efficiently initialize projects in an organized way, following architectural best practices. With support for multiple architectures such as Clean Architecture, Domain-Driven Design (DDD), Hexagonal Architecture, and more, DotNetStarter makes project creation more intuitive and automated.

## 🚀 Main Features

- Support for multiple architectures: **Clean Architecture**, **DDD**, **Hexagonal**, **CQRS + Event Sourcing**, **Onion Architecture**, and **Microservices**.
- Dynamic project and folder creation based on the chosen template.
- Integration with the **dotnet CLI** to automatically generate solutions and projects.
- Modularity and extensibility, making it easy to add new architectures.
- Modern visual experience using **Spectre.Console**.

## 🏗 Supported Architectures

### **Clean Architecture**
Layered structure with clear separation of concerns, focusing on **Application**, **Domain**, **Infrastructure**, **CrossCutting**, and **Tests**.

### **CQRS + Event Sourcing**
Separation of commands and queries with event-based persistence. Includes folders for **CommandSide**, **QuerySide**, **API**, **Shared**, and **Tests**.

### **Domain-Driven Design (DDD)**
Domain-centered model with support for **Aggregates**, **Entities**, **ValueObjects**, **Events**, and **Exceptions**. Includes layers such as **Application**, **Domain**, **Infrastructure**, **Presentation**, and **Tests**.

### **Hexagonal Architecture (Ports and Adapters)**
Decouples core application logic from external interfaces. Includes folders for **Adapters**, **Application**, **Domain**, **Infrastructure**, and **Tests**.

### **Microservices**
Focused on building decoupled services with support for messaging and observability. Includes layers like **API**, **Application**, **Domain**, **Infrastructure**, and **Tests**.

### **Onion Architecture**
Layered model with concentric circles, where dependencies flow from the outer layers to the inner ones. Includes folders for **API**, **Core**, **Infrastructure**, and **Tests**.

## 🛠 Features

### Available Commands:

#### `init`
Initializes a new project based on the chosen architecture.

```bash
# Create a project using Clean Architecture
$ dotnetstarter init CleanArchitecture
```

#### `list`
Lists the available architecture structures.

```bash
# Show available structures
$ dotnetstarter list 
```

#### `help`
Displays available commands or supported architectures.

```bash
# Show general help
$ dotnetstarter help
```

## 📂 Generated Project Structure
Depending on the selected architecture, DotNetStarter creates a solution and organizes the projects in layers. For example, in **Clean Architecture**:

```plaintext
MyProject.sln
├── MyProject.Application
│   ├── DTOs
│   ├── Interfaces
│   ├── Services
│   └── UseCases
├── MyProject.Domain
│   ├── Entities
│   ├── Interfaces
│   ├── ValueObjects
├── MyProject.Infrastructure
│   ├── Context
│   ├── Migrations
│   └── Repositories
├── MyProject.CrossCutting
│   └── DependencyInjection
├── MyProject.Tests
    └── UnitTests
```

## ✨ How It Works
DotNetStarter uses **Factories** to encapsulate the logic for creating each architecture and **Builders** to perform common operations such as creating projects, solutions, and folders. The use of **Dependency Injection (DI)** ensures extensible and modular code.

## 🏗 Technologies Used

- **.NET 6**: Core platform for tool development.
- **Spectre.Console**: Provides a modern and interactive CLI interface.
- **Microsoft.Extensions.DependencyInjection**: For dependency management.

## 📦 Installation

1. Make sure you have the **.NET SDK** installed (version 6 or higher).

2. Install the DotNetStarter tool via NuGet:

```bash
$ dotnet tool install -g DotNetStarter
```

3. Verify the installation:

```bash
$ dotnetstarter --help
```

## 🛠 Contributing
Contributions are very welcome! To contribute:

1. Fork the repository.
2. Create a branch for your feature or fix: `git checkout -b my-feature`.
3. Commit your changes: `git commit -m 'Added a new feature'`.
4. Push to the remote repository: `git push origin my-feature`.
5. Open a Pull Request.

## 💬 Contact

If you have questions, suggestions, or want to reach out, feel free to send me a message on [LinkedIn](https://www.linkedin.com/in/rafael-aparecido-silva-oliveira/).

---

I hope this tool makes .NET project development easier for you! 🚀

---

Se quiser, posso gerar a versão do arquivo em inglês pra você baixar também.
