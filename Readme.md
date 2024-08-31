# Projeto de Estudos POO - Sistema de Reserva

## Descrição

Este é um projeto de estudos em Programação Orientada a Objetos (POO) desenvolvido por **Danilo Couto**, também conhecido como **Dev Alface**. O projeto foi criado na IDE Visual Studio 2022 e tem como objetivo praticar conceitos de POO utilizando a linguagem C# no contexto de desenvolvimento .NET.

## Estrutura do Projeto

O projeto consiste em três classes principais:

1. **Classe `Pessoa`**:
   - **Propriedades**:
     - `Nome`: string
     - `Sobrenome`: string

2. **Classe `Suite`**:
   - **Propriedades**:
     - `TipoSuite`: string
     - `Capacidade`: int
     - `ValorDiaria`: decimal

3. **Classe `Reserva`**:
   - **Propriedades**:
     - `Hospedes`: List<Pessoa>
     - `Suite`: Suite
     - `DiasReservados`: int
   - **Métodos**:
     - `void CadastrarHospedes(List<Pessoa> hospedes)`: Cadastra os hóspedes na reserva.
     - `void CadastrarSuite(Suite suite)`: Cadastra a suíte escolhida para a reserva.
     - `int ObterQuantidadeHospedes()`: Retorna o número de hóspedes cadastrados na reserva.
     - `decimal CalcularValorEstadia()`: Calcula o valor total da estadia com base na quantidade de dias reservados e no valor da diária da suíte.

## Como Executar

1. **Pré-requisitos**:
   - IDE Visual Studio 2022.
   - .NET SDK 6.0 ou superior.

2. **Passos para Execução**:
   - Clone o repositório para sua máquina local.
   - Abra o projeto na IDE Visual Studio 2022.
   - Compile e execute o projeto através da IDE.

## Exemplos de Uso

Aqui estão alguns exemplos de como utilizar as classes e métodos do sistema:

```csharp
// Criação de instâncias de Pessoa
Pessoa pessoa1 = new Pessoa("Danilo", "Couto");
Pessoa pessoa2 = new Pessoa("Maria", "Silva");

// Criação de uma instância de Suite
Suite suite = new Suite("Luxo", 2, 150.00m);

// Criação de uma instância de Reserva
Reserva reserva = new Reserva(5);

// Cadastrando hóspedes na reserva
reserva.CadastrarHospedes(new List<Pessoa> { pessoa1, pessoa2 });

// Cadastrando a suite escolhida na reserva
reserva.CadastrarSuite(suite);

// Obter a quantidade de hóspedes
int quantidadeHospedes = reserva.ObterQuantidadeHospedes();

// Calcular o valor total da estadia
decimal valorEstadia = reserva.CalcularValorEstadia();
```

## Autor

Projeto desenvolvido por **Danilo Couto**, vulgo **Dev Alface**, como parte de seus estudos em desenvolvimento .NET.

## Licença

Este projeto é destinado ao uso pessoal e educacional. Não possui uma licença específica.
```

Este arquivo `README.md` fornece uma visão geral do projeto, descrevendo as classes e métodos principais, bem como instruções básicas sobre como executar o projeto e exemplos de uso.