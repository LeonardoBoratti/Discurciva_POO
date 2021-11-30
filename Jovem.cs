using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDiscurciva
{ 
    class Jovem   
    {

        public string nome;
        public string sexo;
        public string idade;
        public string situacao;
        public void HomensTrab()
        {
            nome = "\n1-Luiz Alberto de Souza \n2-Vitor Silva\n3-João Vargas\n4-Teodoro Veiga\n5-Antonio Santos\n6-Jose Da Silva\n7-Francisco Alves" +
                      "\n8-Igor Sanches\n9-Inacio Oliveira\n10-João scarpa\n11-Afonso Padilha\n12-Argeu Eccel\n13-Jaison Gili\n14-Rafael Ramos\n15-Matheus Garcia" +
                      "\n16-Leandro Montes\n17-Evandro Silva\n18-Robson Alexandre\n19-Leonardo Boratti ";
            sexo = "Masculinos";
            idade = "16 à 54 Anos";
            situacao = "Trabalhando";
            Console.WriteLine("Cadastro dos Homens que trabalham!!! ");
            Console.WriteLine("Nomes:" + nome + "\nSexo:" + sexo + "\nIdade: " + idade + "\nGenero: " + situacao + "\n");
        }
        public void HomensNaoTrab()
        {
            nome = "\n1-Junior Ramos\n2-Willian Gambeta\n3-Talles Alves\n4-Timoteo Tavares\n5-Celio Silva" +
                "\n6-Sinesio Boratti\n7-João Bacca\n8-Vanderlei Marques\n9-Algusto Durkop";
            idade = "16 à 32 Anos";
            situacao = "Não Trabalha";
            Console.WriteLine("Cadastro dos Homens que NÃO Trabalham!!! ");
            Console.WriteLine("Nomes:" + nome + "\nSexo:" + sexo + "\nIdade: " + idade + "\nGenero: " + situacao + "\n");

        }
        public void MulhesTrab()
        {
            nome = "\n1-Albertina de Souza \n2-Stefany Silva\n3-Jessica Vargas\n4-Tatiana Santos\n5-Amelia Raitz\n6-Josiane Ramos\n7-Francisca Albino" +
                      "\n8-Maria das Dores";
            idade = "16 à 51 Anos";
            situacao = "Trabalhando";
            Console.WriteLine("Cadastro dos Mulheres que trabalham!!! ");
            Console.WriteLine("Nomes:" + nome + "\nSexo:" + sexo + "\nIdade: " + idade + "\nGenero: " + situacao + "\n");
        }
        public void MulhesNaoTrab()
        {
            nome = "\n1-Jurema Gatis\n2-Priscila Gambeta\n3-Jaqueline Tavares\n4-Flavia Farias\n5-Celia Silva" +
                "\n6-Silene Boratti\n7-Ana Bacca\n8-Monica Ferraz\n9-Sintia Santos\n10-Rafaela Booz" +
                "\n11-Suzana dos Anjos\n12-Camila Gomes\n13-Julia Valentini";
            idade = "16 à 25 Anos";
            situacao = "Não Trabalha";
            Console.WriteLine("Cadastro dos Mulheres que NÃO Trabalham!!! ");
            Console.WriteLine("Nomes:" + nome + "\nSexo:" + sexo + "\nIdade: " + idade + "\nGenero: " + situacao + "\n");
        }
    }
}