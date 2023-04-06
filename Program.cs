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
            });

            central.SelecionarEExecutar();
        }
    }
}