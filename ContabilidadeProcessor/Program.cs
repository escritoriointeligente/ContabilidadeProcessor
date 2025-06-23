using ContabilidadeProcessor.Services;

Console.WriteLine("=== Leitor de Lançamentos Contábeis ===\n");

string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "lancamentos.txt");

var reader = new LancamentoReader();
var lancamentos = reader.LerLancamentos(caminho);

// Exibição simples
foreach (var l in lancamentos)
{
    Console.WriteLine($"{l.Data:dd/MM/yyyy} | Conta: {l.Conta} | {l.Historico} | {l.Tipo} R$ {l.Valor:N2}");
}

