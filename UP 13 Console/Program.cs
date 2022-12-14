using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UP_13_Console
{
    internal class Program
    {
        abstract class Edition
        {
            public abstract string Author { get; set; }
            public abstract void OutInfo();
            public abstract void IsDesired();
        }

        class Book : Edition
        {
            public string Name { get; set; }
            public override string Author { get; set; }
            public int EditionYear { get; set; }
            public string EditionName { get; set; }
            public Book(string name, string author, int year, string editionName)
            {
                this.Name = name;
                this.Author = author;
                this.EditionYear = year;
                this.EditionName = editionName;
            }
            public override void OutInfo()
            {
                Console.WriteLine("Информация о книге: ");
                Console.WriteLine($"Название -> {Name}");
                Console.WriteLine($"Автор -> {Author}");
                Console.WriteLine($"Год издания -> {EditionYear}");
                Console.WriteLine($"Издательство -> {EditionName}\n");
            }
            public override void IsDesired()
            {

            }
        }

        class Article : Edition 
        {
            public string Name { get; set; }
            public override string Author { get; set; }
            public string MagazineName { get; set; }
            public int MagazineNumber { get; set; }
            public int EditionYear { get; set; }

            public Article(string name, string author, string magazineName, int magazineNumber, int year)
            {
                this.Name = name;
                this.Author = author;
                this.MagazineName = magazineName;
                this.MagazineNumber = magazineNumber;
                this.EditionYear = year;
            }

            public override void OutInfo()
            {
                Console.WriteLine("Информация о статье: ");
                Console.WriteLine($"Название -> {Name}");
                Console.WriteLine($"Автор -> {Author}");
                Console.WriteLine($"Название журнала -> {MagazineName}");
                Console.WriteLine($"Номер журнала -> {MagazineNumber}");
                Console.WriteLine($"Год издания -> {EditionYear}\n");
            }
            public override void IsDesired()
            {

            }
        }

        class ElectronicResource : Edition
        {
            public string Name { get; set; }
            public override string Author { get; set; }
            public string Url { get; set; }
            public string Annotation { get; set; }

            public ElectronicResource(string name, string author, string url, string annotation)
            {
                this.Name = name;
                this.Author = author;
                this.Url = url;
                this.Annotation = annotation;
            }

            public override void OutInfo()
            {
                Console.WriteLine("Информация об элетронном ресурсе: ");
                Console.WriteLine($"Название -> {Name}");
                Console.WriteLine($"Автор -> {Author}");
                Console.WriteLine($"Ссылка -> {Url}");
                Console.WriteLine($"Аннотация -> {Annotation}\n");
            }
            public override void IsDesired()
            {

            }
        }

        static void Main()
        {
            List <Edition> editions = new List<Edition>();
            int N;
            Console.Write("Введите количество изданий -> ");
            while(!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Введите целое положительное число!\nВведите количество изданий -> ");
            }

            for (int i = 0; i < N; i++)
            {
                int choose;
                Console.WriteLine("Выберите, какое издание добавить:\n1 - Книга\n2 - Статья\n3 - Электронный ресурс");
                Console.Write("Выберите издание ->");
                while (!int.TryParse(Console.ReadLine(), out choose) || choose < 0 || choose > 3)
                {
                    Console.Write("Введите число от 1 до 3\nВыберите издание -> ");
                }

                string name, author;
                int year;
                switch (choose)
                {
                    case 1:
                        Console.Write("Введите название книги -> ");
                        name = Console.ReadLine();
                        Console.Write("Введите фамилию автора -> ");
                        author = Console.ReadLine();
                        Console.Write("Введите год издания -> ");
                        while (!int.TryParse(Console.ReadLine(), out year) || year <= 0 || year > DateTime.Now.Year)
                        {
                            Console.Write("Введите корректный год!\nВведите год издания -> ");
                        }
                        Console.Write("Введите название издательства -> ");
                        string editionName = Console.ReadLine();
                        Book book = new Book(name, author, year, editionName);
                        editions.Add(book);
                        break;
                    case 2:
                        Console.Write("Введите название статьи -> ");
                        name = Console.ReadLine();
                        Console.Write("Введите фамилию автора -> ");
                        author = Console.ReadLine();
                        Console.Write("Введите название журнала -> ");
                        string magazineName = Console.ReadLine();
                        Console.Write("Введите номер журнала -> ");
                        int magazineNumber;
                        while (!int.TryParse(Console.ReadLine(), out magazineNumber) || magazineNumber < 0)
                        {
                            Console.Write("Введите корректный номер журнала!\nВведите год издания -> ");
                        }
                        Console.Write("Введите год издания -> ");
                        while (!int.TryParse(Console.ReadLine(), out year) || year <= 0 || year > DateTime.Now.Year)
                        {
                            Console.Write("Введите корректный год!\nВведите год издания -> ");
                        }
                        Article article = new Article(name, author, magazineName, magazineNumber, year);
                        editions.Add(article);
                        break;
                    case 3:
                        Console.Write("Введите название электронного ресурса -> ");
                        name = Console.ReadLine();
                        Console.Write("Введите фамилию автора -> ");
                        author = Console.ReadLine();
                        Console.Write("Введите ссылку -> ");
                        string url = Console.ReadLine();
                        Console.Write("Введите аннотацию -> ");
                        string annotation = Console.ReadLine();
                        ElectronicResource er = new ElectronicResource(name, author, url, annotation);
                        editions.Add(er);
                        break;
                }

            }
            
            Console.WriteLine("Полная информация из каталога:\n");
            foreach (var e in editions)
            {
                e.OutInfo();
            }

            Console.Write("Введите фамилию автора -> ");
            string aut = Console.ReadLine();
            Console.WriteLine($"Издания с автором \"{aut}\":\n");
            foreach (var e in editions)
            {
                if (e.Author == aut) e.OutInfo();
            }
        }
    }
}
