namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        public string Imei { get; set; }
        public string Modelo { get; set; }
        public int Rom { get; set; }


        public Smartphone(string numero, string imei, string modelo, int rom)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Imei = imei;
            Modelo = modelo;
            Rom = rom;
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