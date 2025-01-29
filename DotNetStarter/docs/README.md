# DotNetStarter

**DotNetStarter** é uma ferramenta CLI (Command Line Interface) projetada para ajudar desenvolvedores .NET a inicializar projetos de forma rápida, organizada e seguindo boas práticas arquiteturais. Com suporte a múltiplas arquiteturas, como Clean Architecture, Domain-Driven Design (DDD), Hexagonal Architecture, entre outras, o DotNetStarter torna o processo de criação de projetos mais intuitivo e automatizado.

## 🚀 Principais Recursos

- Suporte a múltiplas arquiteturas: **Clean Architecture**, **DDD**, **Hexagonal**, **CQRS + Event Sourcing**, **Onion Architecture**, e **Microservices**.
- Criação dinâmica de projetos e pastas com base no modelo escolhido.
- Integração com o **dotnet CLI** para gerar soluções e projetos automaticamente.
- Modularização e extensibilidade, permitindo fácil adição de novas arquiteturas.
- Experiência visual moderna com **Spectre.Console**.

## 🏗 Arquiteturas Suportadas

### **Clean Architecture**
Estrutura baseada em camadas claras e separação de responsabilidades, com foco em **Application**, **Domain**, **Infrastructure**, **CrossCutting** e **Tests**.

### **CQRS + Event Sourcing**
Separação de comandos e consultas com persistência baseada em eventos. Inclui pastas para **CommandSide**, **QuerySide**, **API**, **Shared** e **Tests**.

### **Domain-Driven Design (DDD)**
Modelo centrado no domínio, com suporte a **Aggregates**, **Entities**, **ValueObjects**, **Events** e **Exceptions**. Inclui camadas como **Application**, **Domain**, **Infrastructure**, **Presentation** e **Tests**.

### **Hexagonal Architecture (Ports and Adapters)**
Permite desacoplar a lógica central da aplicação de interfaces externas. Inclui pastas para **Adapters**, **Application**, **Domain**, **Infrastructure** e **Tests**.

### **Microservices**
Focado em criação de serviços desacoplados com suporte a mensageria e observabilidade. Inclui camadas como **API**, **Application**, **Domain**, **Infrastructure** e **Tests**.

### **Onion Architecture**
Focado em um modelo de camadas concêntricas, com dependências que fluem de fora para dentro. Inclui pastas para **API**, **Core**, **Infrastructure** e **Tests**.

## 🛠 Funcionalidades

### Comandos disponíveis:

#### `init`
Inicia um novo projeto com base na arquitetura escolhida.

```bash
# Criar um projeto usando Clean Architecture
$ dotnetstarter init CleanArchitecture
```

#### `list`
Lista as estruturas das arquiteturas disponíveis.

```bash
# Exibir as estruturas disponíveis
$ dotnetstarter list 
```

#### `help`
Exibe os comandos disponíveis ou as arquiteturas suportadas.

```bash
# Exibir ajuda geral
$ dotnetstarter help
```

## 📂 Estrutura do Projeto Gerado
Dependendo da arquitetura escolhida, o DotNetStarter cria uma solução e organiza os projetos em camadas. Por exemplo, na **Clean Architecture**:

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

## ✨ Como Funciona
O DotNetStarter utiliza **Factories** para encapsular a lógica de criação de cada arquitetura, e **Builders** para realizar operações comuns, como criação de projetos, soluções e pastas. O uso de **Injeção de Dependências (DI)** garante um código extensível e modular.

## 🏗 Tecnologias Utilizadas

- **.NET 6**: Plataforma base para desenvolvimento da ferramenta.
- **Spectre.Console**: Para exibição de uma interface CLI moderna e interativa.
- **Microsoft.Extensions.DependencyInjection**: Para gerenciamento de dependências.

## 📦 Instalação

1. Certifique-se de ter o **.NET SDK** instalado (versão 6 ou superior).

2. Instale a ferramenta DotNetStarter via NuGet:

```bash
$ dotnet tool install -g DotNetStarter
```

3. Verifique se a instalação foi bem-sucedida:

```bash
$ dotnetstarter --help
```

## 🛠 Contribuindo
Contribuições são muito bem-vindas! Para contribuir:

1. Faça um fork do repositório.
2. Crie uma branch para sua feature ou correção: `git checkout -b minha-feature`.
3. Envie suas alterações: `git commit -m 'Adicionei uma nova feature'`.
4. Envie para o repositório remoto: `git push origin minha-feature`.
5. Abra um Pull Request.

## 💬 Contato

Se tiver dúvidas, sugestões ou quiser entrar em contato, fique à vontade para me enviar uma mensagem no [LinkedIn](https://www.linkedin.com/in/rafael-aparecido-silva-oliveira/).

---

Espero que esta ferramenta facilite o desenvolvimento de projetos .NET para você! 🚀