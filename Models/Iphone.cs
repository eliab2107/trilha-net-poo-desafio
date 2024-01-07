namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Verificando dependências...");
            Console.WriteLine($"Instalando  {nomeApp}...");
            Console.WriteLine($"{nomeApp} Instalado com sucesso");
        }

        public override void AddContato(string nome, string numero)
        {
            Console.WriteLine("Nome: ");
            string nomeC = Console.ReadLine();
            Console.WriteLine("Número: ");
            string numeroC = Console.ReadLine();
            contatos[numeroC] = nomeC;
        }
    }
}