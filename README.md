# 🚀 Explorando C# com POO: Sistema de Reservas de Hotel

Projeto desenvolvido no módulo **Explorando a linguagem C#**, da trilha **.NET** da [DIO](https://www.dio.me).

Este desafio teve como objetivo consolidar conceitos fundamentais da linguagem C# e aplicar boas práticas de programação orientada a objetos (POO) na construção de um sistema de hospedagem.

---

## 📌 Desafio de Projeto

Construir um sistema de hotelaria capaz de:

* Gerenciar **hóspedes** (`Pessoa`),
* Definir **suítes** (`Suite`),
* Controlar **reservas** (`Reserva`).

O sistema deve permitir o cálculo do valor total da diária com base no número de dias reservados, aplicar descontos quando aplicável e validar a capacidade da suíte conforme o número de hóspedes.

---

## 🎯 Habilidades Desenvolvidas

Durante a implementação do projeto, foram reforçadas e praticadas as seguintes habilidades:

* ✅ **Programação Orientada a Objetos (POO)**: criação e relacionamento de classes (`Pessoa`, `Suite`, `Reserva`).
* ✅ **Encapsulamento**: definição de propriedades e métodos para proteger dados e expor apenas o necessário.
* ✅ **Validações de regras de negócio**: garantir que uma suíte não seja reservada para mais hóspedes do que sua capacidade.
* ✅ **Tratamento de exceções**: lançamento de erros personalizados para cenários inválidos.
* ✅ **Lógica de cálculos e descontos**: aplicação de fórmulas para valor da diária e regras de desconto progressivo.
* ✅ **Boas práticas em C#**: uso de construtores, métodos de retorno, tipagem forte e clareza no código.

---

## 📖 Regras e Validações Implementadas

1. Não é permitido realizar reserva de suíte com capacidade inferior ao número de hóspedes.

   * Exemplo: Suíte para 2 pessoas não pode receber 3 hóspedes.
2. O método `ObterQuantidadeHospedes` deve retornar o número total de hóspedes.
3. O método `CalcularValorDiaria` deve multiplicar os dias reservados pelo valor da diária.
4. Reservas **iguais ou superiores a 10 dias** recebem **10% de desconto** no valor final.

---

## 🛠️ Estrutura do Sistema

* **Classe `Pessoa`** → Representa um hóspede.
* **Classe `Suite`** → Define informações da suíte (capacidade e valor da diária).
* **Classe `Reserva`** → Relaciona hóspedes e suíte, contendo regras de negócio e cálculos.

---

## 📊 Diagrama de Classes

![Diagrama de classe hotel](diagrama_classe_hotel.png)

---

## 🚀 Aprendizados

Este desafio proporcionou uma experiência prática com:

* Modelagem de sistemas reais utilizando POO.
* Implementação de regras de negócio em classes.
* Cálculo automatizado com base em condições específicas.
* Uso de **C#** em um cenário próximo ao mercado.
