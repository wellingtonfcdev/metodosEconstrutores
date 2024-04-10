using ExemploExplorando.Models;
using System.Globalization;

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquiv_Leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado." + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou aqui.");
}





























//using System.Reflection.Metadata;





















// string dataString = "2024-04-10 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm",CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} Não é uma data válida.");
// }
















// DateTime data = DateTime.Now;

// Console.WriteLine(data);

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());

// Console.WriteLine(data.ToShortTimeString());


// Console.WriteLine("\n------------------------------------------\n");

// DateTime dt = DateTime.Parse("30/04/2024 18:00");
// Console.WriteLine(dt);












// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero =123456;
// Console.WriteLine(numero.ToString("##-##-##"));








// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




















// Pessoa p1 = new Pessoa(nome:"Wellington",sobrenome:"Feijó");


// Pessoa p2 = new Pessoa(nome:"Eduardo",sobrenome:"Queiroz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



























// Pessoa p1 = new Pessoa();

// p1.Nome = "Wellington";
// p1.Sobrenome = "Feijó";
// p1.Idade = 39;
// p1.Apresentar();

