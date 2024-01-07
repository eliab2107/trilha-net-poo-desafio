namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        protected Dictionary<string, string> contatos = new Dictionary<string, string>(); 
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        protected string Modelo {get;set;}

        protected string IMEI {get; set;}

        protected int Memoria {get; set;}
    
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public virtual void Ligar(string contato)
        {
            Console.WriteLine($"Ligando para {contato}...");
        }

        public virtual void ReceberLigacao(string contato)
        {
            Console.WriteLine($"Recebendo ligação de {contato}...");
        }

       public abstract void InstalarAplicativo(string nomeApp);

       public virtual void AddContato(string nome, string numero)
       {
         contatos[numero] = nome;
       } 

       public void RemoverContato(string numero)
       {
            try
            {
                contatos.Remove(numero);
            }
            catch
            {
                Console.WriteLine("Esse número não é um de seus contatos");
            }
       }
    }
}