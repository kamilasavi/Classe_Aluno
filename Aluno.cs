using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aluno
{
    internal class Aluno
    {
        private string nome;
        private string endereco;
        private string resultado;
        private double nota1;
        private double nota2;
        private double nota3;
        private double media;
        DateTime dataNasc;

        //Método construtor
        public Aluno()
        {
            this.nome = "";
            this.endereco = "";
            this.nota1 = 0;
            this.nota2 = 0;
            this.nota3 = 0;
            dataNasc = DateTime.Today;
        }

        //Método Set
        public void setNome(string paramNome)
        {
            this.nome = paramNome;
        }

        public void setEndereco(string paramEndereco)
        {
            this.endereco = paramEndereco;
        }

        public void setNota1(double paramNota1)
        {
            this.nota1 = paramNota1;
        }
        public void setNota2(double paramNota2)
        {
            this.nota2 = paramNota2;
        }
        public void setNota3(double paramNota3)
        {
            this.nota3 = paramNota3;
        }
        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }

        public void setMedia(double paramMedia)
        {
            this.media = paramMedia;
        }

        public void setResultado(string paramResultado)
        {
            this.resultado = paramResultado;
        }

        //Método get
        public string getNome()
        {
            return this.nome;
        }

        public string getEndereco()
        {
            return this.endereco;
        }

        public double getNota1()
        {
            return this.nota1;
        }

        public double getNota2()
        {
            return this.nota2;
        }

        public double getNota3()
        {
            return this.nota3;
        }

        public DateTime getDataNasc()
        {
            return this.dataNasc;
        }

        public double getMedia()
        {
            return this.media;
        }

        public string getResultado()
        {
            return this.resultado;
        }

        //Calcula a média
        public void calculamedia()
        {
            this.media = (this.nota1 + this.nota2 + this.nota3) / 3;
            this.media = Math.Round(this.media, 2);
        }

        //Avaliar se o aluno está aprovado
        public void verificarAprova()
        {
            if (this.media > 7)
            {
                this.resultado = "Aprovado";
            }
            else
            {
                this.resultado = "Reprovado";
            }
        }

    }
}

