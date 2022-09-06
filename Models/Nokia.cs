using static System.Console;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
         
            
            var frase = "";
            foreach (var letra in nomeApp)
            {
                
                frase = frase + letra;
                WriteLine($"O seu Nokia {Modelo} está instalando {frase}");
                Thread.Sleep(500);
                Console.Clear();
            } 
            WriteLine($"Aplicativo {nomeApp} está instalado em seu {Modelo}.");
            Thread.Sleep(500);

        }
    }
}