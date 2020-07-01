# Projeto "Restaurante Online"

## Aplicação completa utilizando ASP NET MVC

Esse projeto foi desenvolvido para aplicar todos os conceitos de `ASP NET` utilizando a `arquitetura MVC`.
<br>
Esse projeto utilizou bibliotecas externas, como `bootstrap` e `jQuery`.

<br>

Esse projeto visa que o usuário encontre um Restaurante que satisfaça o seu gosto.

<br>

<img src="/uploads/foto3.png" />

<br>

### 1. Model

O model é responsável por criar as `tabelas no banco de dados`. 
<br>
Esse projeto utilizou o `Database-First`.

<br>

O model pode ser construido a partir de três abordagens de Entity Framework:
<br>

  1. Code-First
    Primeiro as classes de domínios e depois a estrutura do banco de dados.
  2. Model-First :
    Primeiro o modelo conceitual e depois o modelo físico.
  3. Database-First 
    Primeiro o modelo físico do banco de dados.
  
<br>

### 2. Controller

No controller é composto por três componentes:
  1. `navegação por rota`;
  2. `CRUD`;
  3. `regras de negócios`.
  
<br>

<img src="/uploads/foto2.png" />

<br>

### 3. View

O view é responsável pelo `layout` na qual o usuário consumirá.
<br>
O View no ASP NET utiliza `Razor` e `Helpers`.

<br>

_OBS: Não consegui renderizar as imagens na tela, mas consegui encontrar as tags no modo desenvolvedor._

<br>

### 4. Tópicos Extras

<br>

  1. `Repositórios`
    <br>
    No projeto, foi feito um repositório para gerenciar a autenticação a partir de cookies.
  
  <br>
  
  2. `Filtros`
    <br>
    No projeto, foi feito o filtro para que não seja possível que um usuário não logado acesse às áreas administrativas.
  
  <br>
  
  3. `Validação de Dados`
    <br>
    Pode ser realizado tanto no lado servidor quanto no lado cliente.
