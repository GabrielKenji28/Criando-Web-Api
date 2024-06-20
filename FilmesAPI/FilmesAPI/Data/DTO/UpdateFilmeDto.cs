using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O Título do filme é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O Gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatório")]
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
