using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;
using Sapiens.Shared.Models;

//criar o contexto 

//Aluno

var aluno = new Aluno();
aluno.Nome = "Maros Melo";
aluno.Cpf = "906.543.789-23";
aluno.Situacao = SituacaoAluno.Ativo;
//aluno.Curso=   
//context.Ad

var endereco = new Endereco();
endereco.Uf = "RO";
endereco.Municipio = "Porto Velho";
endereco.Cep = "76824-316";


var coordenador = new Coordenador();
coordenador.Nome = "Allan";
coordenador.Cpf = "123.456.789.00";
coordenador.Titulacao = Titulacao.Mestrado;
//coordenador.Endereco.Municipio = endereco.Municipio;
//coordenador.Endereco.Municipio = "Porto Velho"; --não pode fazer isso.
coordenador.Endereco = new()
{
    Uf = "RO",
    Municipio = "Porto Velho"
};


var curso = new Curso();
curso.Nome="Sistemas de Informação";
curso.CargaHoraria = 3200;
curso.Tipo = TipoCurso.Bacharelado;
curso.Coordenador = coordenador;
//context.AdicionaCurso(professor);


Console.WriteLine($"Curso: { curso.Nome}");
Console.WriteLine($"Coordenador: {coordenador.Nome}");
Console.WriteLine($"Endereço {endereco.Municipio}");
Console.WriteLine($"Endereço {endereco.Uf}");

Console.ReadLine();
