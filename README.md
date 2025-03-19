# Verificador de triângulos 

![](https://i.imgur.com/4j4AMqu.gif.gif)

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

---
## Detalhes

Ao iniciar o jogo, é exibido um menu simples onde o usuário deve inserir 
três lados de um triângulo. Com base nesses dados, o programa classifica
o triângulo como equilátero, isósceles ou escaleno.

---
## Entrada

 O usuário pode interagir com o console, que retorna um feedback logo após a confirmação da
 interação. O programa solicita três lados diferentes de um triângulo e, após
 exibir o resultado, o usuário pode escolher entre verificar novos lados ou sair do programa.

---
## Funcionalidades

* Validação de Entrada: O programa verifica se os valores inseridos pelo usuário são numéricos e positivos antes de prosseguir.
 
* Verificação dos Lados: Após receber os três lados, o programa valida se eles formam um triângulo válido com base na desigualdade triangular.
* Feedback Instantâneo: O usuário recebe uma resposta imediata informando se os valores inseridos formam um triângulo e, se sim, qual é o seu tipo (equilátero, isósceles ou escaleno). Após isso, pode optar por testar novos valores ou sair do programa.

---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
https://github.com/LeandroJader/classifica-o_dos_tri-ngulos
```

#### Navegue até a pasta raiz da solução
```
classificação_dos_triângulos
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
classificação_dos_triângulos
```

#### Execute o projeto
```
dotnet run
```