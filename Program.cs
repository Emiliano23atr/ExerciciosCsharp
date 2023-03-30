using System;
using System.Collections.Generic;

// using ExerciciosCsharp.Exercicios;

namespace ExerciciosCsharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // {"Primeiro Programa", Exercicio001.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}