# Fatec Jundiaí - Projeto de Graduação de Curso
### Sobre ###
Esse projeto é um software web para gestão de oficios, editais, memorandos e portarias utilizando o .net core 2.1 com razor pages, entity framework e mysql

Súmario
=================
<!--ts-->
   * [Sobre](#Sobre)
   * [Tabela de Conteudo](#tabela-de-conteudo)
   * [Instalação](#Instalação)
   * [Começando](#Começando)
   
   * [Tecnologias](#Tecnologias)
<!--te-->
  
 
  # Instalação
  Para executar o projeto são necessarios os seguintes programas:
  
<!--ts-->
   * [.Net Core 2.1(SDK)](https://dotnet.microsoft.com/download/dotnet-core/2.1)
   * [MYSQL](https://dev.mysql.com/downloads/mysql/)
   * [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)
      * [Para usuarios do VSCODE baixar a extensão do C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
   * Opcional - [git](https://git-scm.com/downloads)
<!--te-->
# Começando
### Baixando o projeto
com o git hub instalado crie uma pasta e abra o terminal nela

execute 
```
git init
```
Depois
```
Git clone https://github.com/iTzWeg/OficioMVC.git
```
Pronto os arquivos da solução foram clonados para sua pasta
Após instalar os programas necessarios  basta abrir a pasta do projeto e abrir o arquivo appsettings.json
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "OficioMVCContext": "Server=localhost;port=3307;uid=root;password= - ;database=developDB"
  }
```
Altere a linha de OficioMVCContext para  o connection string do seu banco de dados MySql, atlerando servidor,porta,uid e senha se necessario.

Caso esteja executando a aplicação em ambiente de teste, execute o comando dotnet ef update database para criar o database em seu banco de dados SQL

o script para execução do banco também se encontra na pasta DATA/Create.SQL



Em ambiente de testes o sistema cadastra dois usuarios:
Com nome teste e master ambos com senhas iguais aos seus nomes

Para merito de testes pode se utilizar a seguinte conexão de um banco de dados armazenado na Azure
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "OficioMVCContext": "Server=oficiodb.mysql.database.azure.com; Port=3306; Database=developdb; Uid=DbAdm@oficiodb; Pwd=!aLSLut2; SslMode=Preferred;"
  }
}

```

Dentro da pasta OficioMVC/OficioMVC que foi clonada na pasta que criou em sua máquina abra o terminal e execute o seguinte comando para restaurar as dependencias em sua máquina
```
dotnet tool restore
```
depois para atualizar o banco de dados
```
dotnet ef database update
```
e depois execute a aplicação usando
```
dotnet run 
```
Seu terminal deve ter um resultado do tipo: 


![Image](https://uploaddeimagens.com.br/images/002/984/853/original/Capturar.PNG?1606779870)

Em seu navegador utilize o endereço http://localhost:5000

A seguinte tela se abrirá:
![Image](https://uploaddeimagens.com.br/images/002/984/857/full/Capturar.PNG?1606780616)


Para login utilize
Login: teste

senha: teste

ou

Login Master

senha: master


# Tecnologias

.Net Core versão 2.1
MySQL versão 5.6 
Entity Framework core 2.0
Razor pages
HTML
CSS
JavaScript
JQUERY
