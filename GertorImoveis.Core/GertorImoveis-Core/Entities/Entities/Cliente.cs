using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_CLIENTE")]
    public class Cliente : Notifies
    {
        [Column("CLI_ID")]
        [Display(Name = "Código")]
    
        public int Id { get; set; }

        [Column("CLI_NOME")]
        [Display(Name = "NOME")]
        public string Nome { get; set; }

        [Column("CLI_CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("CLI_TELFIXO")]
        [Display(Name = "Telefone Fixo")]
        public string TelefoneFixo { get; set; }

        [Column("CLI_CELULAR")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Column("CLI_EMAIL")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column("CLI_TPCLIENTE")]
        [Display(Name = "Tipo Cliente")]
        public TipoCliente TipoCliente { get; set; }

        [Column("CLI_BAIRRO")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("CLI_CEP")]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Column("CLI_CIDADE")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("CLI_COMPL")]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Column("CLI_COMPL2")]
        [Display(Name = "Complemento2")]
        public string Complemento2 { get; set; }


        [Column("CLI_LOUGRADOURO")]
        [Display(Name = "Lougradouro")]
        public string Lougradouro { get; set; }

        [Column("CLI_NUMIMOV")]
        [Display(Name = "Numero Imovel")]
        public int NumeroImovel { get; set; }

        [Column("CLI_UF")]
        [Display(Name = "UF")]
        public string Uf { get; set; }

        [Column("CLI_DTCAD")]
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Column("CLI_DTALT")]
        [Display(Name = "Data de Alteração")]
        public DateTime DataAlteracao { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }




    }
}
