﻿using ExemploExplorando.Models;
using System.Globalization;
using ExemploExplorando.Models;
using Newtonsoft.Json;

//Deserializando um objeto
string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto},"+ 
                    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}





















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1,"Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2,"Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);

// File.WriteAllText("Arquivos/venda.json", serializado);
// Console.WriteLine(serializado);


























// // verificar se um número é par ou ímpar

// // if ternário
// int numero = 10;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));




















// int numero = 19;

// if(numero % 2 == 0)
// {
//     Console.WriteLine($"Número {numero} é par.");
// }
// else
// {
//     Console.WriteLine($"Número {numero} é ímpar");
// }











// Pessoa p1 = new Pessoa("Leonardo","Buta");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");































// LeituraArquivo arquivo = new LeituraArquivo();
// // Descarte utiliza o underline _
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquivo:" + QuantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }
























// //Tupla

// (int, string, string, decimal) tupla = (1,"Wellington","Feijó", 1.80M);
// ValueTuple<int, string, string, decimal>outroExemploTupla = (1,"Wellington","Feijó",1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1,"Wellington","Feijó",1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");



// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP","São Paulo");
// estados.Add("BA","Bahia");
// estados.Add("MG","Minas Gerais");

// Console.WriteLine("\n----------------------------\n");
// Console.WriteLine("\nAcessanco valor de uma chave:");
// Console.WriteLine(estados["MG"]);

// Console.WriteLine("\n----------------------------\n");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");

// }

// Console.WriteLine("\n------------------------ Remover chave do Dictionary");
// //Remover chave do Dictionary
// estados.Remove("BA");

// estados["SP"] = "São Paulo - Valor Alterado"; //Alterar o valor correspondente a uma chave
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");

// }

// string chave = "BA";
// Console.WriteLine($"Verificando elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

























// //Fila LIFO
// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);
// pilha.Push(1);

// foreach(int item in pilha)
// {
//     Console.WriteLine($"Lista {item}");
// }

// //Remover objeto da fila
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// //remover da fila
// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}") ;
// fila.Enqueue(10);
// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }







//new ExemploExcecao().Metodo1();
























// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquiv_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado." + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou aqui.");
// }





























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

