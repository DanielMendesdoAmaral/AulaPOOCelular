using System.Threading;

namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public double tamanho;
        public bool ligado;

        /// <summary>
        /// Se o celular estiver ligado, exibe um erro. Senão, exibe uma mensagem de sucesso e liga o celular.
        /// </summary>
        public void Ligar() {
            if (ligado)
                System.Console.WriteLine("Celular já está ligado.");
            else {
                ligado=true;
                System.Console.WriteLine("Celular ligado com sucesso.");
            }
        }

        /// <summary>
        /// Se o celular estiver desligado, exibe um erro. Senão, exibe uma mensagem de sucesso e desliga o celular.
        /// </summary>
        public void Desligar() {
            if (!ligado)
                System.Console.WriteLine("Celular já está desligado.");
            else {
                ligado=false;
                System.Console.WriteLine("Celular desligado com sucesso.");
            }
        }

        /// <summary>
        /// Se o celular estiver desligado exibe uma mensagem de erro. Senão, exibe uma mensagem de sucesso e faz a ligação.
        /// </summary>
        /// <param name="c">Recebe o nome de um contato para realizar a ligação.</param>
        public void FazerLigacao(string c) {
            if (!ligado)
                System.Console.WriteLine("O celular está desligado.");
            else 
                System.Console.WriteLine($"Ligando para {c}.");
        }

        /// <summary>
        /// Se o celular estiver desligado exibe uma mensagem de erro. Senão, exibe uma mensagem de sucesso e envia a mensagem. 
        /// </summary>
        /// <param name="c">Recebe o nome de um contato para enviar a mensagem.</param>
        public void EnviarMensagem(string c) {
            if (!ligado)
                System.Console.WriteLine("O celular está desligado.");
            else 
                System.Console.WriteLine($"Enviando mensagem para {c}.");
        }
    }
}