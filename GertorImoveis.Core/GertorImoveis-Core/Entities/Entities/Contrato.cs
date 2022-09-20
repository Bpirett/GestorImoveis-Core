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
    [Table("TB_CONTRATO")]
    public class Contrato : Notifies
    {

        [Column("CTR_ID")]
        [Display(Name = "Codigo")]
        [Key]
        public string Codigo { get; set; }

        [Column("CTR_LOCATARIO")]
        [Display(Name = "Locatario")]
        [MaxLength(200)]
        public string Locatario { get; set; }

        [Column("CTR_LOCADOR")]
        [Display(Name = "Locador")]
        [MaxLength(200)]
        public string Locador { get; set; }

        [Column("CTR_VALOR")]
        [Display(Name = "Valor")]
        public double Valor { get; set; }

        [Column("CTR_DIAPAG")]
        [Display(Name = "Dia Pagamento")]
        public int DiaPagamento { get; set; }

        [Column("CTR_DTENTRADA")]
        [Display(Name = "Entrada")]
        public DateTime DataEntrada { get; set; }

        [Column("CTR_DTSAIDA")]
        [Display(Name = "Saida")]
        public DateTime DataSaida { get; set; }

        [Column("CTR_QTAMESES")]
        [Display(Name = "Bairro")]

        public int QtaMeses { get; set; }

        [Column("CTR_VLRIPTU")]
        [Display(Name = "Bairro")]
        public double VlrIptu { get; set; }

        [Column("CTR_TIPO")]
        [Display(Name = "Bairro")]
        public string TipoImovel { get; set; }

        [Column("CTR_SITUACAO")]
        [Display(Name = "Bairro")]
        public SituacaoContrato SituacaoContrato { get; set; }


        [Column("CTR_BAIRRO")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("CTR_CEP")]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Column("CTR_CIDADE")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("CTR_COMPL")]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Column("CTR_COMPL2")]
        [Display(Name = "Complemento2")]
        public string Complemento2 { get; set; }


        [Column("CTR_LOUGRADOURO")]
        [Display(Name = "Lougradouro")]
        public string Lougradouro { get; set; }

        [Column("CTR_NUMIMOV")]
        [Display(Name = "Numero Imovel")]
        public int NumeroImovel { get; set; }

        [Column("CTR_UF")]
        [Display(Name = "UF")]
        public string Uf { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }



    }
}
