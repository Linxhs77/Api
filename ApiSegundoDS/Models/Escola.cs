namespace ApiSegundoDS.Models
{
    public class Escola
    {

        public int id  { get; set;  }
        public string? CNPJ  { get; set;  }
        public string? Nome { get; set; }
        public int ProfessorID { get; set; }
        public int AlunoID { get; set; }


    }
}