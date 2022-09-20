using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_CPF")]
        [MaxLength(16)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("USR_IDADE")]
        [Display(Name = "Idade")]
        public string Idade { get; set; }


        [Column("USR_NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("USR_TELEFONE")]
        [MaxLength(20)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column("USR_CELULAR")]
        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Column("USR_BAIRRO")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("USR_CEP")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Column("USR_CIDADE")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("USR_COMPL")]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Column("USR_COMPL2")]
        [Display(Name = "Complemento2")]
        public string Complemento2 { get; set; }


        [Column("USR_ENDERECO")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Column("USR_NUMIMOV")]
        [Display(Name = "Numero")]
        public int NumeroImovel { get; set; }

        [Column("USR_UF")]
        [Display(Name = "UF")]
        public string Uf { get; set; }


        [Column("USR_TPUSU")]
        [Display(Name = "Tipo")]
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
