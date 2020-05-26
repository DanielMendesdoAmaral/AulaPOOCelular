/*

Capacidade: Utilizar o paradigma da programação orientada a objetos
Tipo: Formativa

- Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
- Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
- Só será possível executar tais métodos se o celular estiver ligado.
- Suba o projeto para um repositório no Github, com o título "AulaPOOCelular".
- Envie o link do repositório como entrega desta atividade.

*/

using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular m = new Celular();
            m.cor = "Preto";
            m.modelo = "Moto G6";
            m.tamanho = 5.7;
            m.ligado=false;

            m.Desligar();
            m.Ligar();
            m.Ligar();
            m.FazerLigacao("Paulo");
            m.EnviarMensagem("Carlos");
            m.Desligar();
            m.FazerLigacao("Paulo");
            m.EnviarMensagem("Carlos");
        }
    }
}