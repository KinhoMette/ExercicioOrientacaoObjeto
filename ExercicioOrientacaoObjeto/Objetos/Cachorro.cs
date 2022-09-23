using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoObjeto.Objetos
{
    public class Cachorro : Animal
    {
        public override void CadastrarAnimal()
        {
            Nome = "Dog";
            Cor = "Preto";
            Peso = 10;
        }

        public void CadastrarAnimal(string nome, string cor, double peso)
        {
            Nome = nome;
            Cor = cor;
            Peso = peso;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("au au");
        }
    }
}