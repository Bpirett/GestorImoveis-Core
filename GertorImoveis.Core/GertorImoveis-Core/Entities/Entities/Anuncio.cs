using Entities.Notifications;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("TB_ANUNCIO")]
    public class Anuncio : Notifies
    {

        [Column("ANC_ID")]
        [Display(Name = "Código")]
        [Key]
        public int Id { get; set; }

        [Column("ANC_VALOR")]
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public double Valor { get; set; }

        [Column("ANC_END")]
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Endereco { get; set; }

        [Column("ANC_VLRIPTU")]
        [Display(Name = "Vlr Iptu")]
        public double VlrIptu { get; set; }

        [Column("ANC_TPIMOVEL")]
        [Display(Name = "Tipo Imovel")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string TipoImovel { get; set; }

        [Column("ANC_TPNEG")]
        [Display(Name = "Negocio")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Negocio { get; set; }

        [Column("ANC_QTDORMI")]
        [Display(Name = "Domitorio")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public int Dormitorio { get; set; }

        [Column("ANC_QTSUITES")]
        [Display(Name = "Suites")]
        public int Suites { get; set; }

        [Column("ANC_QTVAGAS")]
        [Display(Name = "Vagas")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public int Vagas { get; set; }

        [Column("ANC_AREA")]
        [Display(Name = "Area")]
        public int Area { get; set; }

        [Column("ANC_CIDADE")]
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Cidade { get; set; }

        [Column("ANC_BAIRRO")]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Bairro { get; set; }

        [Column("ANC_DESCRICAO")]
        [Display(Name = "Descrição")]
        [MaxLength(200000)]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Obs { get; set; }

        [Column("ANC_DTCAD")]
        [Display(Name = "Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Column("ANC_ATIVO")]
        [Display(Name = "Ativo")]
        public string Ativo { get; set; }

        [Column("ANC_DTATUALI")]
        [Display(Name = "Data Atualizaçao")]
        public DateTime DataAtualizacao { get; set; }

        [Column("ANC_PERMUTA")]
        [Display(Name = "Permuta")]
        public bool Permuta { get; set; }

        [Column("ANC_CHURRASQUEIRA")]
        [Display(Name = "Churrasqueira")]
        public bool Churrasqueira { get; set; }

        [Column("ANC_PISCINA")]
        [Display(Name = "Piscina")]
        public bool Piscina { get; set; }

        [Column("ANC_BRINQUE")]
        [Display(Name = "Brinquedoteca")]
        public bool Brinquedoteca { get; set; }

        [Column("ANC_PLAYGROUD")]
        [Display(Name = "Playgroud")]
        public bool Playgroud { get; set; }


        [Column("ANC_POLIESP")]
        [Display(Name = "Poliesportiva")]
        public bool Poliesportiva { get; set; }


        [Column("ANC_GISNASTICA")]
        [Display(Name = "Ginastica")]
        public bool Ginastica { get; set; }

        [Column("ANC_SFESTA")]
        [Display(Name = "Salão de Festas")]
        public bool Festas { get; set; }

        [Column("ANC_SJOGOS")]
        [Display(Name = "Salão de Jogos")]
        public bool Jogos { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
