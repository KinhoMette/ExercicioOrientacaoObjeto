using ExercicioOrientacaoObjeto.Objetos;
using System;

namespace ExercicioOrientacaoObjeto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cachorro = new Cachorro();
            cachorro.CadastrarAnimal();

            var pato = new Pato();
            pato.CadastrarAnimal();

            var gato = new Gato();
            gato.CadastrarAnimal();

            Animal[] animais = new Animal[3];

            animais[0] = cachorro;
            animais[1] = pato;
            animais[2] = gato;

            for (int i = 0; i < animais.Length; i++)
            {
                animais[i].EmitirSom();
            }
        }
    }
}