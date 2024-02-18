using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudTest.Models;

public class Servico
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }


    [Required(ErrorMessage ="Informe o Nome")]
    [StringLength(80, ErrorMessage ="O nome deve conter atá 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;


    [Required(ErrorMessage ="Informe a Descrição")]
    [StringLength(1200, ErrorMessage ="A descrição deve conter atá 1200 caracteres")]
    [MinLength(5, ErrorMessage = "A descrição deve conter pelo menos 5 caracteres")]
    [DisplayName("Descrição Completa")]
    public string Description { get; set; } = string.Empty;


    [Required(ErrorMessage ="Informe número do WhatsApp")]
    [StringLength(13, ErrorMessage ="O número não pode conter mais de 13 caracteres")]
    [DisplayName("WhatsApp")]
    public string Number { get; set; } = string.Empty;


    [Required(ErrorMessage ="Informe a Categoria")]
    [StringLength(25)]
    [MinLength(4)]
    [DisplayName("Categoria")]
    public string Category { get; set; } = string.Empty;


    [Required(ErrorMessage ="Adicione pelo menos uma imagem")]
    [DisplayName("Imagem")]
    public List<string> ImagePaths { get; set; } = new List<string>();


    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;


    [DataType(DataType.DateTime)]
    [DisplayName("Início")]
    public DateTime StartDate { get; set; }


    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }

}