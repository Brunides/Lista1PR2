using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIsta1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exercicio 1 
            //double metros, centimetros, milimetros;

            //Console.WriteLine("qual o valor em metros");
            //metros = double.Parse(Console.ReadLine());
            //centimetros = metros * 100;
            //milimetros = centimetros * 10;
            //Console.WriteLine(metros + " metros são iguais à:" + centimetros + " centimetros e igual à:" + milimetros + " milimetros");


            // exercicio 2 

            //float fa, ce;
            //Console.WriteLine("qual a temperatura em Fahrenheit:");
            //f = float.Parse(Console.ReadLine ());
            //c = (float)((f - 32.0) * (5.0 / 9.0));
            //Console.WriteLine("o valor em celsius é:" +  c);


            //int fa, ce;
            //Console.WriteLine("qual a temperatura em Fahrenheit:");
            //f = int.Parse(Console.ReadLine ());
            //c = ((f - 32) * (5 / 9));
            //Console.WriteLine("o valor em celsius é:" +  c);

            //o valor é igual a 0 pois 9 / 5 nao resulta em um numero inteiro, o numeros que vierem a seguir da virgula nao serao considerados 

            // exercicio 3

            //double alt, peso, imc;

            //Console.WriteLine("qual a sua altura:");
            //alt = int.Parse(Console.ReadLine());
            //Console.WriteLine("qual a seu peso:");
            //peso = int.Parse(Console.ReadLine());

            //imc = alt * alt / peso;
            //Console.WriteLine("seu imc é igual:" + imc);

            //exercicio 4 

            //double n1, p1, n2, p2, n3, p3, med;

            //Console.WriteLine("qual o valor  ");
            //n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o peso");
            //p1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor  ");
            //n2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o peso");
            //p2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor  ");
            //n3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual o peso");
            //p3 = double.Parse(Console.ReadLine());
            //med = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);
            //Console.WriteLine("essa a media ponderada:"+ med);

            //exercicio 5 

            // calcular velocidade 

            //double t, d, v;

            //Console.WriteLine("qual o tempo:");
            //t = double.Parse(Console.ReadLine ());
            //Console.WriteLine("qual a distancia:");
            //d = double.Parse (Console.ReadLine ());

            //v = d / t;

            //Console.WriteLine(" a velocidade é:" + v);

            // exercicio 6 

            //double a, n;

            //Console.WriteLine("qual o salario:"); 
            //a = double.Parse(Console.ReadLine());
            //n = a * 1.25;
            //Console.WriteLine("o novo salario é:" + n);

            // exercicios 7 

            //double r, d, t;

            //Console.WriteLine("quantos reais:");
            //r = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual a cotação do dolar:");
            //d = double.Parse(Console.ReadLine());
            //t = r / d;
            //Console.WriteLine("voce tem " + t + "dolares");

            //exercicio 8 

            //double a, n;

            //Console.WriteLine("qual o numero:"); 
            //a = double.Parse(Console.ReadLine());
            //n = a * 3 + 1 + a * 2 - 1;
            //Console.WriteLine("o valor é:" + n);

            //exercicio 9 

            //int mi, ce, de, un, n;

            //Console.WriteLine("qual o numero:");
            //n = int.Parse(Console.ReadLine());
            //mi = n / 1000;
            //ce= n / 100 - 10 * mi;
            //de = n / 10 - 100 * mi - 10 * ce;
            //un = n / 1 - 1000 * mi- 100 * ce - 10 * de;

            //Console.WriteLine(mi); 
            //Console.WriteLine(ce);
            //Console.WriteLine(de); 
            //Console.WriteLine(un);


            //exercicio 10

            //double i1, i2, i3, i4, i;
            //i = 1000;

            //i1 = i - i * 0.34;
            //i2 = i1 * 1.28;
            //i3 = i2 * 1.4;
            //i4 = i3 - i3 * 0.85;

            //Console.WriteLine("o valor total do investimento é: " + i4);


            //exercicio 11


            //double n1, n2, n3;

            //Console.WriteLine("digite um número: ");

            //n1 = double.Parse(Console.ReadLine());
            //n2 = n1 * n1;
            //n3 = n1 * n1 * n1;

            //Console.WriteLine("o quadrado do número escolhido é: " + n2 + " e o cubo do número é: " + n3);


            //exercicio 12 


            //double p, m, h;

            //Console.WriteLine("qual o sua altura:");
            //p = double.Parse(Console.ReadLine());

            //h = p * 72.7 - 58;

            //m = p * 62.1 - 44.7;

            //Console.WriteLine("seu peso ideal seria " + h + " para homens e: " + m + " para mulheres");


            //exercicio 13 


            //Estes sistemas de controle possuem a função de registrar quaisquer alterações feitas em cima de um código,armazenando essas informações e permitindo que, caso seja necessário, um(a) programador(a) possa regredir a versões anteriores de uma aplicação de modo simples e rápido.

            //Em outras palavras, GitHub é uma plataforma totalmente online onde você pode criar repositórios e hospedar neles seus projetos, colaborar com softwares open source, seguir outros(as) programadores(as) e interagir com códigos de terceiros.

            //1 - Iniciando um Repositório
            //$ git init
            //2 - Apagando um repositório
            //$ rm -rf .git
            //3 -Listando Arquivos Modificados
            //$ git status
            //4 - Arquivos não monitorados
            //git checkout .
            //5 - Renomear Commit
            //$ git commit --amend
            //6.1 - Listando Branches
            //$ git branch
            //7 - Visualizando o Histórico de Commits
            //$ git log
            //8 - Exibir branches em um modo mais legível
            //            //* a102055 (HEAD -> main) commit 8
            //| //*196d28e(branch - 2) commit 7
            //| //*07e073c commit 3
            //| //*2b077ca new fie
            //| //| *c1369d8(branch - 3) commit 6
            //| | *d11bdcd commit 5
            //| |/
            //|/|
            //* | 2b22b75 commit 2
            //|/
            //*d5a12b0.gitignore
            //* 9535426-- commit 1
            //9 - Atalhos Personalizados
            //            ////deixar o comando disponível apenas no repositório atual
            //            git config alias.dog "log --all --decorate --oneline --graph"
            ////deixar o comando global em sua máquina, ficando disponível para qualquer repositório
            //git config --global alias.dog "log --all --decorate --oneline --graph"
            //            //
            //10.1 - Salvando modificações em um Stash
            //$ git stash










        }
    }
}