# Descontrolada-App

Aplicativo simples utilizando Blazor WebAssembly para cadastro e visualização de produtos.

## Conteúdo

- [Recursos](#recursos)
- [Requisitos](#requisitos)
- [Configuração](#configuração)
- [Banco de dados](#banco-de-dados)

## Recursos

A aplicação oferece as seguintes funcionalidades:

- Cadastro de produtos (*nome, preço de venda, descrição, quantidade, tipo(orgãnico ou não orgãnico), data de cadastro*).
- Visualização de produtos cadastrados (5 produtos por página).

## Requisitos

Antes de iniciar o projeto, certifique-se de atender aos seguintes requisitos:

- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/).
- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado.
- Pacotes e dependências listados no arquivo `.csproj` instalados.

## Configuração

Siga as etapas abaixo para configurar e executar o projeto:

1. Clone este repositório:

   ```sh
   [git clone https://github.com/yThiagoFS/balta.io_challenge.git](https://github.com/yThiagoFS/Descontrolada-App.git)
   
2. Executando a API:
   2.1. Acesse a pasta da API
   ```sh
   cd src/Server/Descontrolada.API
   ```

   2.2. Execute o projeto
   ```
   dotnet run
   ```
   A API estará disponível em: `https://localhost:7019`.

   

3. Executando a aplicação Blazor:
   3.1. Acesse a pasta da aplicação Blazor:
   ```sh
   cd src/Client/Descontrolada.Blazor
   ```

   3.2. Execute o projeto
   ```sh
   dotnet run OU dotnet watch run
   ```
   A aplicação estará disponível em: `http://localhost:5277`.

## Banco de dados

A API está utilizando um banco de dados em memória, logo, não é necessário nenhuma configuração adicional para banco de dados.
