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
    
    [Table("TB_BOLETO")]
    public class Boleto : Notifies
    {
        [Column("BOL_ID")]
        [Display(Name = "Codigo")]
        [Key]
        public string Codigo { get; set; }


        [Display(Name = "Contrato")]
        [ForeignKey("Contrato")]
        [Column(Order = 1)]
        public string IdContrato { get; set; }
        public virtual Contrato Contrato { get; set; }

        [Column("BOL_NUMBOL")]
        [Display(Name = "Numero boleto")]
        public string NumBoleto { get; set; }

        [Column("BOL_LOCATARIO")]
        [Display(Name = "Locatario")]
        public string Locatario { get; set; }

        [Column("BOL_LOCADOR")]
        [Display(Name = "Locador")]
        public string Locador { get; set; }

        [Column("BOL_TPIMOVEL")]
        [Display(Name = "TipoImovel")]
        public string TipoImovel { get; set; }

        [Column("BOL_VALOR")]
        [Display(Name = "Valor")]
        public double Valor { get; set; }

        [Column("BOL_ENDERECO")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        [Column("BOL_DTVENC")]
        [Display(Name = "Data Vencimento")]
        public DateTime DataVencimento { get; set; }

        [Column("BOL_JRMULTA")]
        [Display(Name = "% Multa")]
        public double JrMulta { get; set; }

        [Column("BOL_VLRMULTA")]
        [Display(Name = "Valor Multa")]
        public double VlrMulta { get; set; }


        [Column("BOL_VLRIPTU")]
        [Display(Name = "Valor IPTU")]
        public double VlrIptu { get; set; }

        [Column("BOL_TXDESC")]
        [Display(Name = "% Desconto")]
        public double TxDesconto { get; set; }

        [Column("BOL_VLRDESC")]
        [Display(Name = "Vlr Desconto")]
        public double VlrDesconto { get; set; }

        [Column("BOL_PAGBOL")]
        [Display(Name = "boleto pago")]
        public Pagamento PagBoleto { get; set; }

        [Column("BOL_DTPAG")]
        [Display(Name = "Data Pagamento")]
        public DateTime DataPagamento { get; set; }

        [Column("BOL_TXADM")]
        [Display(Name = "% Administração")]
        public double TxAdministracao { get; set; }

        [Column("BOL_VLRADM")]
        [Display(Name = "Vlr Administração")]
        public double VlrAdministracao { get; set; }

        [Column("BOL_DTINI")]
        [Display(Name = "Data inicio")]
        public DateTime PeriodoInicio { get; set; }

        [Column("BOL_DTFIM")]
        [Display(Name = "Data fim")]
        public DateTime PeriodoFim { get; set; }

    }
}
