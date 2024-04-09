using ExemploExplorando.Models;


Pessoa p1 = new Pessoa(nome:"Wellington",sobrenome:"Feijó");


Pessoa p2 = new Pessoa(nome:"Eduardo",sobrenome:"Queiroz");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



























// Pessoa p1 = new Pessoa();

// p1.Nome = "Wellington";
// p1.Sobrenome = "Feijó";
// p1.Idade = 39;
// p1.Apresentar();

