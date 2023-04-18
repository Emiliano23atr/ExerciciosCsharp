using System;
using System.Collections.Generic;

using ExerciciosCsharp.Exercicios;

namespace ExerciciosCsharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Deixando tudo pronto", Exercicio001.Executar},
                {"Respondendo ao Usuário", Exercicio002.Executar},
                {"Somando dois números", Exercicio003.Executar},
                // Exercicio004
                {"Antecessor e Sucessor", Exercicio005.Executar},
                {"Dobro, Triplo, Raiz Quadrada", Exercicio006.Executar},
                {"Média Aritmética", Exercicio007.Executar},
                {"Conversor de Medidas", Exercicio008.Executar},
                {"Tabuada", Exercicio009.Executar},
                {"Conversor de Moedas", Exercicio010.Executar},
                {"Pintando Parede", Exercicio011.Executar},
                {"Calculando Descontos", Exercicio012.Executar},
                {"Reajuste Salarial", Exercicio013.Executar},
                {"Conversor de Temperaturas", Exercicio014.Executar},
                {"Aluguel de Carros", Exercicio015.Executar},
                {"Quebrando um número", Exercicio016.Executar},
                {"Catetos e Hipotenusa", Exercicio017.Executar},
                {"Seno, Cosseno e Tangente", Exercicio018.Executar},
                {"Sorteando um item na lista", Exercicio019.Executar},
                // Exercicio020
                // Exercicio021
                {"Analisador de Textos", Exercicio022.Executar},
                {"Separando dígitos de um número", Exercicio023.Executar},
                {"Verificando as primeiras letras de um texto", Exercicio024.Executar},
                {"Procurando uma string dentro de outra", Exercicio025.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}