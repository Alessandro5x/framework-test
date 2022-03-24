# framework-test
Teste de lógica e programação para um processo seletivo

## 🚀 Começando
Você pode utilizar o gitclone para editar esse projeto na sua máquina

### 📋 Pré-requisitos
O projeto foi desenvolvido utilizando o .Net 5 o qual foi instalado utilizando o sdk disponível no site da Microsoft.

## 🛠️ Construído com
Construído com o Visual Studio Code

## 📦 Desenvolvimento
Para desenvolvimento desse projeto foram utilizadas algumas referências do canal no youtube https://www.youtube.com/c/baltaio e algumas referências do blog do mesmo autor.

Ao longo do projeto devido a alguns problemas de referência do NuGet a versão do .Net foi alterada de 6 para 5.

## ▶️ Executando
Esse projeto contém 3 maneiras para execução:

### 1 - Por meio do console application executando o projeto console, ou utilizando o dotnet run dentro dessa pasta
### 2 - Por meio da API executando o projeto api, o qual já abre no swagger com a descrição.
### 3 - Utilizando docker (Necessário a instalação do memso):
    - Entre na pasta do projeto via linha de comando
    - Execute o comando "docker build -t divisores-api-image -f Dockerfile-api ." o qual executa os comandos do Dockerfile
    - Execute o comando "docker build -t divisores-api-image -f Dockerfile-api ." 
    - Acesse http://localhost:8080/swagger/

## ⚙️ Testes
Foram criados alguns testes unitários para verificação de funcionamento do metodo principal
Sendo eles:
    - NeedToReturnDividers, o qual testas e ela retorna os divisores com sucesso
    - NeedToReturnDividersPrime, o qual testa os divisores primos
    - NeedToReturnInvalidNumber, o qual testa numeros inválidos.
