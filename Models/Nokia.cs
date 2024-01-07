using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {            
            Console.WriteLine($"Instalando {nomeApp}...");
        }

        public override void Ligar(string contato)
        {
            try{
                base.Ligar(contatos[contato]);
            }
            catch
            {
                base.Ligar(contato);
            }
            
        }

        public override void ReceberLigacao(string contato)
        {
            if(contatos[contato] != null){
                base.ReceberLigacao(contatos[contato]);
            }
            else
            {
                base.ReceberLigacao(contato);
            }
            
        }
    }
}