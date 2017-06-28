using System;

namespace ConceitosRelacionais
{
    abstract class Medico : Funcionario
    {
        private DateTime CRM;

        public DateTime CRM1 { get => CRM; set => CRM = value; }

        // método abstrato
        abstract public void Operar();
        
        // um método não abstrato
        void fazerAlgo()
        {
            // TODO: implementação desejada
        }
    }
}
