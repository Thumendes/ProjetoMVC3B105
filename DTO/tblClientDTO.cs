using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVC3B105.DTO
{
    public class tblClientDTO
    {
        private int idCliente, tpUsuario;
        private string nomeCliente, sobrenomeCliente, cpfCliente, senhaCliente, emailCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int TpUsuario { get => tpUsuario; set => tpUsuario = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string SobrenomeCliente { get => sobrenomeCliente; set => sobrenomeCliente = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string SenhaCliente { 
            get => senhaCliente; 
            set
            {
                if (value != string.Empty)
                {
                    this.senhaCliente = value;
                }
                else
                {
                    throw new Exception("Preencha o campo senha.");
                }
            }
        }

        public string EmailCliente { 
            get => emailCliente; 
            set 
            {
                if(value != string.Empty)
                {
                    this.emailCliente = value;
                }
                else
                {
                    throw new Exception("Preencha o campo email.");
                }
            } 
        }
    }
}