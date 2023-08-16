using GeradorCurriculo.Models;

Console.WriteLine("CRIAR CURRICULO");


//  ---------------------------------------------------------------------------

var pessoa = new Pessoa();

Console.WriteLine("Digite o nome da pessoa do currículo:");
var nome = Console.ReadLine();
Console.WriteLine("Digite a idade da pessoa:");
var idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o email da pessoa:");
var email = Console.ReadLine();

pessoa.Nome = nome;
pessoa.Idade = idade;
pessoa.Email = email;

// -------------------------------------------------------------------------

var habilidade = new Habilidade();

Console.WriteLine("Digite uma habilidade para o Currículo:");
var nomeHabilidade = Console.ReadLine();
Console.WriteLine("Esta habilidade está em qual nível (de 0 - 10):");
var nivel = int.Parse(Console.ReadLine());

habilidade.Nome = nomeHabilidade;
habilidade.Nivel = nivel;


// ----------------------------------------------------------------------------



var formacao = new Formacao();



Console.WriteLine("Digite o ano da formacao:");
var anoformacao =  int.Parse(Console.ReadLine());
Console.WriteLine("Digite a instituição:");
var instituicao = (Console.ReadLine());
Console.WriteLine("Digite o grau:");
var grau = (Console.ReadLine());


formacao.AnoFormacao = anoformacao;
formacao.Instituicao = instituicao;
formacao.Grau = grau;


// -------------------------------------------------------------------------------

var curriculo = new Curriculo();

curriculo.DadosPessoais = pessoa;
curriculo.Habilidade = habilidade;
curriculo.Formacao = formacao;


Console.WriteLine("CURRICULO CRIADO");

Console.WriteLine("-----------------------");

Console.WriteLine("DADOS PESSOAIS:");
Console.WriteLine("Nome: " + curriculo.DadosPessoais.Nome);
Console.WriteLine("Idade: " + curriculo.DadosPessoais.Idade);
Console.WriteLine("Email: " + curriculo.DadosPessoais.Email);

Console.WriteLine("-----------------------");

Console.WriteLine("HABILIDADE:");
Console.WriteLine("Nome: " + curriculo.Habilidade.Nome);
Console.WriteLine("Nível: " + curriculo.Habilidade.Nivel);

Console.WriteLine("-----------------------");

Console.WriteLine("Formação:");
Console.WriteLine("Ano: " + curriculo.Formacao.AnoFormacao);
Console.WriteLine("Instituição: " + curriculo.Formacao.Instituicao);
Console.WriteLine("Grau: " + curriculo.Formacao.Grau);

