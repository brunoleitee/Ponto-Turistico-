using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace McvCrud.Models
{
    public class Cadastro
    {

        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Estado { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Cidade { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Rua { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public int Numero { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [DisplayName("Referência")]
        public string Referencia { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string CEP {get; set;} 
        


    }
}
