using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoaTestes
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public string NumeroDeCadastro { get; set; }

        public void FuncionarioCadastrdoNoSistema(string nome, string numeroCadastro)
        {
            this.Nome = nome;
            this.NumeroDeCadastro = numeroCadastro;
        }
        public void Cadastrar(string nomeFuncionario, string numeroCadastro)
        {

            if (numeroCadastro == NumeroDeCadastro)
            {
                Console.WriteLine("O número inserido " + numeroCadastro + " ja está cadastrado no sistema!");
                Console.WriteLine("Verifique os dados e tente novamente!");
                // Recebe FuncionarioCadastrdoNoSistema()
               
            }
            else
            {
                Console.WriteLine("Funcionario Cadastrado com Sucesso!");
            }
        }
}
