﻿using System;
using Blog.Screens.CategoryScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Blog.Helpers;
using Microsoft.Data.SqlClient;
using Blog.Screens.RelatorioScreens;

namespace Blog
{
    class MenuPrincipalScreen
    {
        private const string CONNECTION_STRING = @"Server=localhost,1435;Database=Blog;User ID=sa;Password=inovafarmaI;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            ConectarNoBancoDeDados();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void ConectarNoBancoDeDados()
        {
            try
            {
                Database.Connection = new SqlConnection(CONNECTION_STRING);
                Database.Connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao se conectar com o banco de dados - {ex.Message}");
                Console.ReadKey();
            }
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Gestão de posts");
            Console.WriteLine("6 - Vincular perfil/usuário");
            Console.WriteLine("7 - Vincular post/tag");
            Console.WriteLine("8 - Relatórios");
            Console.WriteLine();
            Console.WriteLine("Digite um número para acessar o módulo que deseja:");
            short opcaoUsuarioValidada = ValidadorDeTexto.ValidarValorEntradaUsuario((Console.ReadLine()!));

            switch (opcaoUsuarioValidada)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    MenuPostScreen.Load();
                    break;
                case 6:
                    LinkUserScreen.Load();
                    break;
                case 7:
                    LinkPostScreen.Load();
                    break;
                case 8:
                    RelatorioScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
