namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(
            string numero, string imei, string modelo, int rom) :
            base(numero, imei, modelo, rom)
        {
        }

        // DONE: Sobrescrever o método "InstalarAplicativo"


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iniciando instalação do aplicativo - {nomeApp}");
            Console.WriteLine("Verificando compatibilidade com a versão do SO Android instalado...");
            Console.WriteLine("Ok");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no seu Nokia - {Modelo}!");
        }
    }
}