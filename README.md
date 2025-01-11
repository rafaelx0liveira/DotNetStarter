# DotNetStarter

O **DotNetStarter** é uma ferramenta CLI projetada para ajudar desenvolvedores a iniciarem rapidamente projetos .NET com arquiteturas modernas e boas práticas de desenvolvimento. Com suporte a várias arquiteturas pré-definidas, ele automatiza a criação de estruturas de pastas e arquivos essenciais, permitindo que você comece a codificar imediatamente.

## Principais Recursos
- Suporte a múltiplas arquiteturas:
  - **Clean Architecture**
  - **DDD (Domain-Driven Design)**
  - **Microservices**
  - **Hexagonal Architecture**
  - **CQRS + Event Sourcing**
  - **Onion Architecture**
- CLI intuitivo e de fácil uso.
- Estruturas de projetos personalizadas e organizadas por camadas.
- Flexível para expandir e adicionar novos templates.

---

## Instalação
Para instalar o **DotNetStarter**, siga os passos abaixo:

1. Certifique-se de que o .NET SDK está instalado:
   ```bash
   dotnet --version
   ```

2. Instale a ferramenta globalmente:
   ```bash
   dotnet tool install --global DotNetStarter.CLI --add-source ./nupkg
   ```

---

## Comandos Disponíveis

### Listar Comandos
Para ver todos os comandos suportados:
```bash
dotnetstarter help
```

### Inicializar um Novo Projeto
Para criar um novo projeto com uma arquitetura específica:
```bash
dotnetstarter init [architecture]
```

- **Parâmetros**:
  - `architecture` (obrigatório): A arquitetura desejada.

#### Exemplo:
```bash
dotnetstarter init hexagonal
```

### Listar Arquiteturas Disponíveis
Para listar as arquiteturas suportadas:
```bash
dotnetstarter help --arch
```

### Listar Estrutura de Pastas
Para visualizar a estrutura de pastas de uma arquitetura:
```bash
dotnetstarter list --arch=[architecture]
```

#### Exemplo:
```bash
dotnetstarter list --arch=ddd
```

---

## Arquiteturas Suportadas

### **Clean Architecture**
Estrutura baseada em camadas claras e separação de responsabilidades.

### **Domain-Driven Design (DDD)**
Modelo centrado no domínio, com suporte a Aggregates, Entities e Value Objects.

### **Microservices**
Focado em criação de serviços desacoplados com suporte a mensageria e observabilidade.

### **Hexagonal Architecture (Ports and Adapters)**
Permite desacoplar a lógica central da aplicação de interfaces externas.

### **CQRS + Event Sourcing**
Separação de comandos e consultas com persistência baseada em eventos.

### **Onion Architecture**
Focado em um modelo de camadas concéntricas, com dependências que fluem de fora para dentro.

---

## Contribuição
Contribuições são bem-vindas! Se você deseja adicionar novas arquiteturas ou melhorar a ferramenta:

1. Clone o repositório:
   ```bash
   git clone https://github.com/rafaelx0liveira/DotNetStarter.git
   ```

2. Crie um branch para sua contribuição:
   ```bash
   git checkout -b feature/nova-arquitetura
   ```

3. Adicione suas alterações e envie um pull request.

---

## Contato
Se você tiver dúvidas ou sugestões, entre em contato:
- **Autor**: Rafael Oliveira

