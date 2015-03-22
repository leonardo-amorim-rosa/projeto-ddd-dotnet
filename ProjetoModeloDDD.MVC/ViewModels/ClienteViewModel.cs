using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage="O campo Nome é obrigatório.")]
        [MaxLength(150, ErrorMessage="Máximo de {0} caracteres.")]
        [MinLength(10, ErrorMessage="Mínimo de {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobre Nome é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(10, ErrorMessage = "Mínimo de {0} caracteres.")]
        [DisplayName("Sobre Nome")]
        public string Sobrenome { get; set; }

        [EmailAddress(ErrorMessage="Use um email válido.")]
        [Required(ErrorMessage="O campo E-mail é obrigatório.")]
        [MaxLength(100, ErrorMessage="Máximo de {0} caracteres.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
        
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}