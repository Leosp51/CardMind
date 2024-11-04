using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMind.Services.LocalServices
{
    public class SistemaRecompensaService
    {
        private static int dinheiro;
        public int Dinheiro {
            get => dinheiro;
            set
            {
                dinheiro = value;
            }
        }
        SistemaRecompensaService() {
            Dinheiro = 0;
        }

        public bool Comprar(int valolrCompra)
        {
            if (Dinheiro - valolrCompra < 0) { 
                Dinheiro -= valolrCompra;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
