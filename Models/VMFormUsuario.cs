using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICE.Models
{
    public class VMFormUsuario
    {
        public long usuarioUID { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }

        public VMFormUsuario()
        {
        }

        public VMFormUsuario(Usuario usuario)
        {
            this.usuarioUID = usuario.usuarioUID;
            this.nome = "";
            this.email = usuario.email;
            this.cpf = usuario.cpf;
            this.senha = "";
        }
    }
}