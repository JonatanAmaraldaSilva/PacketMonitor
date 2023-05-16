using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_rede
{
    public class Dispositivo
    {

        private int nrdispositivo;
        private string descricao;

        public int NrDispositivo { get => nrdispositivo; set => nrdispositivo = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Dispositivo(int nrdispositivo, string descricao)
        {
            this.nrdispositivo = nrdispositivo;
            this.descricao = descricao;
        }
    }
}
