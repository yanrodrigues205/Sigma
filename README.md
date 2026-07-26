# Sigma
Projeto desenvolvido utilizando .net 10, seguindo os princípios da clean architecture.
Solução é dividida em camadas, onde cada projeto possui uma responsabilidade específica dentro da aplicação. essa organização busca facilitar a manutenção, evolução, testabilidade e separação de responsabilidades do sistema.
A escolha da clean architecture visa o crescimento do projeto e o trabalho simultaneo de várias pessoas no mesmo, reduzindo impactos de mudanças, por exemplo: caso seja dedicido a troca de algum framework ou tecnologia não é necessário escrever a regra de negócio.


## Exemplo de Estrutura do Projeto
```text
Sigma
│
├── Sigma.Api
│   ├── Controllers
│   └── Properties
│
├── Sigma.Core
│   ├── Entities
│   └── Models
│
├── Sigma.Application
│   ├── Commands
│   └── Queries
│
└── Sigma.Infrastructure
    ├── Repositories
    └── Services
