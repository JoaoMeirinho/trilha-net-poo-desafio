namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo;
        private string _imei;
        private int _memoria;
        public Smartphone(string numero, int memoria, string imei, string modelo)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _memoria = memoria;
            _imei = imei;
            _modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}