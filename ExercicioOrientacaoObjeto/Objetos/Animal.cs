using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoObjeto.Objetos
{
    public abstract class Animal
    {
        public string Nome { get; protected set; }
        public double Peso { get; protected set; }
        public string Cor { get; protected set; }

        public abstract void CadastrarAnimal();

        public abstract void EmitirSom();
    }
}