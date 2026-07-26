# Sigma 
#### ⚠️ Observação: Código "Ogânico" sem a utilização de IA para desenvolvimento do mesmo. ⚠️

Projeto desenvolvido utilizando .net 10, seguindo os princípios da clean architecture.
Solução é dividida em camadas, onde cada projeto possui uma responsabilidade específica dentro da aplicação. essa organização busca facilitar a manutenção, evolução, testabilidade e separação de responsabilidades do sistema.
A escolha da clean architecture visa o crescimento do projeto e o trabalho simultaneo de várias pessoas no mesmo, reduzindo impactos de mudanças, por exemplo: caso seja dedicido a troca de algum framework ou tecnologia não é necessário escrever a regra de negócio.

## Estrutura em camadas utilizada

<img width="400" height="600" alt="clean" src="https://github.com/user-attachments/assets/55984f8b-2394-40ac-b7d2-5bc8252beb8d" />

Imagem apresentada acima fornecida pela publicação, que aliás, recomendo a leitura: https://www.linkedin.com/posts/m-bilal-shaukat-6b7197243_dotnet-aspnetcore-cleanarchitecture-share-7362739961940393984-g_uy/


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
```
## Estrutura de comunicação de camadas

```text
 Sigma.Api -> Sigma.Application
 Sigma.Api -> Sigma.Infrastructure

 Sigma.Application -> Sigma.Core

 Sigma.Infrastructure -> Sigma.Application
