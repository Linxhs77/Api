﻿namespace ApiSegundoDS.Models
{
    public class Professor
    {

        public int id         { get; set; }
        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Mae { get; set; }
        public string? materia { get; set; }
        public string? ComponenteCurricular { get; set; }
        public string? Pai { get; set; }
        public int EscolaID { get; set; }
        public int AlunoID { get; set; }

    }
}