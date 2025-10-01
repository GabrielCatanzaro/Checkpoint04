using System;

namespace OracleEfCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            var relatorio = new RelatorioService(context);

            int opcao;
            do
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1 - Listar Usuários");
                Console.WriteLine("2 - Adicionar Usuário");
                Console.WriteLine("3 - Atualizar Usuário");
                Console.WriteLine("4 - Deletar Usuário");
                Console.WriteLine("5 - Relatório Top XP");
                Console.WriteLine("6 - Relatório Top Tasks");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = -1;

                switch (opcao)
                {
                    case 1:
                        relatorio.ListarUsuarios();
                        break;
                    case 2:
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        Console.Write("XP: ");
                        var xp = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Tasks: ");
                        var tasks = int.Parse(Console.ReadLine() ?? "0");
                        relatorio.AdicionarUsuario(nome, xp, tasks);
                        break;
                    case 3:
                        Console.Write("ID do usuário: ");
                        var idUpdate = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Novo Nome: ");
                        var nomeUp = Console.ReadLine();
                        Console.Write("Novo XP: ");
                        var xpUp = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Novas Tasks: ");
                        var tasksUp = int.Parse(Console.ReadLine() ?? "0");
                        relatorio.AtualizarUsuario(idUpdate, nomeUp, xpUp, tasksUp);
                        break;
                    case 4:
                        Console.Write("ID do usuário: ");
                        var idDel = int.Parse(Console.ReadLine() ?? "0");
                        relatorio.DeletarUsuario(idDel);
                        break;
                    case 5:
                        relatorio.MostrarTopXp();
                        break;
                    case 6:
                        relatorio.MostrarTopTasks();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
