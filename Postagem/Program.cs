using System;
using Postagem.Entidades;

namespace Postagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem");
            Comentario c2 = new Comentario("Uau, isso é incrível!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:0" +
                "5:44"),
                "Viajar para a Nova Zelândia",
                "Vou visitar esse país maravilhoso!",
                12);
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Comentario c3 = new Comentario("Boa noite!");
            Comentario c4 = new Comentario("Que a força esteja com você");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa noite, galera",
                "Te vejo amanhã",
                5);
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}