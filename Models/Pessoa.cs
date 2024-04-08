using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;

        public string Nome 
        { 
            get => _nome.ToUpper();
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode servazio");
                }
                _nome = value;
            } }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}