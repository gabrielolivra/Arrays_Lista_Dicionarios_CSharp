using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_E_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Para criar uma lista é necessario usar o metodo List<> informando o tipo de
             dados que vai ser armazenada dentro dela.*//*
            var cores = new List<string>()
            {
                "Azul", "Verde", "Vermelho", "Amarelo"
            };

            

            foreach (var cor in cores) { 
                
                Console.WriteLine(cor);

            }
            *//*O metodo .Add() Adiciona uma nova string no final da lista*//*
            cores.Add("Laranja");
            Console.WriteLine("--------------");

            foreach (var cor in cores)
            {
                Console.WriteLine(cor);
            }
            *//*O metodo .Remove() = é necessario passar um parametro para remover
             da lista. EX: .Remove("Laranja"); Vai remover a string Laranja da lista.

              O metodo .RemoveAt() = ele pega o index da lista e remove. Ex: 
              list = ["azul_index_0","verde_index_1", "vermelho_index_2" ];
             .list.RemoveAt(1) = ele vai remover a string verde_index_1;
             *//*
            cores.RemoveAt(1);
            Console.WriteLine("--------------");

            

            foreach (var cor in cores)
            {
                
                Console.WriteLine(cor);

               

            }
            Console.WriteLine("--------Arrays--------");

            *//*Para criar uma Array use o exemplo abaixo *//*
            
            string[] cores2 = new string[]
            {
                 "Azul", "Verde", "Vermelho", "Amarelo"
            };

            for (int i = 0; i < cores2.Length; i++)
            {
              *//*Length verifica o tamanho da lista*/
            /*Metodo Count() conta a quantidade de caracters de uma string dentro da lista*//*

               Console.WriteLine(cores2[i]);
               Console.WriteLine(cores2[i].Count());
           }*/

            /*DICIONARIOS*/

            /*Para criar dicionarios é necessario usar o comando abaixo*/
            Dictionary<string, List<string>> cores = new Dictionary<string, List<string>>();

            cores.Add("ESCURAS", new List<string> { "Azul", "Verde", "Vermelho", "Amarelo" });
            cores.Add("CLARAS", new List<string> { "BRANCO", "CINZA", "ROSA", "AMARELO" });

            foreach (var item in cores)
            {
            /* Para agrupar valores que fiquem todos armazenados em uma unica linha
             é preciso criar uma variavel para armazenar os dados
            e usar o metodo .Join(), onde ele recebe 2 parametros 
            o separador e o valor que vai ser agrupado.*/
                string valores = string.Join(", ", item.Value); 

                Console.WriteLine($"Chave: {item.Key} Valores: {valores}");
            }



        }
    }
}
