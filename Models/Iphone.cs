namespace DesafioPOO.Models
{
    // ME CONTRATA XP!!!
    // Implementado: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
        }

        // ME CONTRATA XP!!!
        // Implementado: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} foi baixado da AppStore e instalado com sucesso!");
        }
    }
}