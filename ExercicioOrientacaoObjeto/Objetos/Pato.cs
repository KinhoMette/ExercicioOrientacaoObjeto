using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoObjeto.Objetos
{
    public class Pato : Animal
    {
        public override void CadastrarAnimal()
        {
            Nome = "pato";
            Peso = 1.5;
            Cor = "Branco";
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Quack quack");
        }
    }
}