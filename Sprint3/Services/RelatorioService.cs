using System;
using System.Linq;
using System.Collections.Generic;

namespace OracleEfCoreExample
{
    public class RelatorioService
    {
        private readonly AppDbContext _context;

        public RelatorioService(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 Criar usuário
        public void AdicionarUsuario(string nome, int xp, int tasks)
        {
            var usuario = new Usuario
            {
                Nome = nome,
                Xp = xp,
                TasksConcluidas = tasks
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            Console.WriteLine("Usuário adicionado com sucesso!");
        }

        // 🔹 Listar todos
        public void ListarUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();

            Console.WriteLine("\n=== LISTA DE USUÁRIOS ===");
            Console.WriteLine("ID | NOME | XP | TASKS");
            Console.WriteLine("-------------------------------");

            foreach (var u in usuarios)
            {
                Console.WriteLine($"{u.Id} | {u.Nome} | {u.Xp} | {u.TasksConcluidas}");
            }
        }

        // 🔹 Atualizar
        public void AtualizarUsuario(int id, string nome, int xp, int tasks)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            usuario.Nome = nome;
            usuario.Xp = xp;
            usuario.TasksConcluidas = tasks;

            _context.SaveChanges();

            Console.WriteLine("Usuário atualizado com sucesso!");
        }

        // 🔹 Deletar
        public void DeletarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            Console.WriteLine("Usuário deletado com sucesso!");
        }

        // 🔹 Relatório Top XP
        public void MostrarTopXp()
        {
            var usuarios = _context.Usuarios
                .OrderByDescending(u => u.Xp)
                .Take(5)
                .ToList();

            Console.WriteLine("\n=== TOP 5 XP ===");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"{u.Nome} - XP: {u.Xp}");
            }
        }

        // 🔹 Relatório mais produtivos
        public void MostrarTopTasks()
        {
            var usuarios = _context.Usuarios
                .OrderByDescending(u => u.TasksConcluidas)
                .Take(5)
                .ToList();

            Console.WriteLine("\n=== TOP 5 TASKS ===");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"{u.Nome} - Tasks: {u.TasksConcluidas}");
            }
        }
    }
}
