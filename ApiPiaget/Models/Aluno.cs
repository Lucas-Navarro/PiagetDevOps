namespace ApiPiaget.Models
{
    public class Aluno
    {
        // Definindo os atributos do objeto Aluno
        public int Id { get; set; }
        // ? deixa o ponto para poder ser vazio
        public string? Nome { get; set; }
        public string? RGM { get; set; }
        public decimal Nota { get; set; }
    }
}
