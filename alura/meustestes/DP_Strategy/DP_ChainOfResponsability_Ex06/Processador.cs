using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfResponsability_Ex06
{
    public interface Processador
    {
        string Processar(Requisicao requisicao, Conta conta);
    }

    public class ProcessaSaidas
    {
        public string ProcessarSaidas(Requisicao requisicao, Conta conta)
        {
            Processador processaPorcentagem = new ProcessadorPorcento();
            Processador processaXML = new ProcessadorXML(processaPorcentagem);
            Processador processaCSV = new ProcessadorCSV(processaXML);

            return processaCSV.Processar(requisicao, conta);
        }
    }

    public class ProcessadorXML : Processador
    {
        public Processador Proximo { get; private set; }

        public ProcessadorXML(Processador proximo)
        {
            Proximo = proximo;
        }

        public string Processar(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.XML)
            {
                string XML = @"<conta>
                            <Titular>
                                @Titular                                
                            </Titular>
                            <Saldo>
                                @Saldo
                            </Saldo>
                         </conta>";
                XML = XML.Replace("@Titular", conta.Titular);
                XML = XML.Replace("@Saldo", conta.Saldo.ToString());
                return XML;
            }
            else
            {
                return Proximo.Processar(requisicao, conta);
            }
        }
    }

    public class ProcessadorCSV : Processador
    {
        public Processador Proximo { get; private set; }

        public ProcessadorCSV(Processador proximo)
        {
            Proximo = proximo;
        }

        public string Processar(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato.Equals(Formato.CSV))
            {
                return conta.Titular + ";" + conta.Saldo.ToString() + ";";
            }
            else
            {
                return Proximo.Processar(requisicao, conta);
            }
        }
    }

    public class ProcessadorPorcento : Processador
    {
        public Processador Proximo { get; set; }

        public ProcessadorPorcento()
        {
            Proximo = null;
        }

        public string Processar(Requisicao requisicao, Conta conta)
        {
            return conta.Titular + "%" + conta.Saldo.ToString();
        }
    }
}
