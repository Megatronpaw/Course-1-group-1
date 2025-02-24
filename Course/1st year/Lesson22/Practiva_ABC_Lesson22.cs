using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;

public class Letter
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Тело письма
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Новое ли письмо
    /// </summary>
    public bool IsNew { get; set; }

    /// <summary>
    /// Во сколько письмо было получено
    /// </summary>
    public DateTime Received { get; set; }
}
public class Mail
{
    public Mail(string email)
    {
        Email = email;
        Letters = new List<Letter>();
    }

    public string Email { get; set; }

    public List<Letter> Letters { get; set; }

    public void CreateRandomLetters(int count)
    {
        var currentCount = Letters.Count;

        for (int i = currentCount; i < currentCount + count; i++)
        {
            Letters.Add(new Letter
            {
                Id = i,
                Title = $"Title {i}",
                Body = $"Body {i}",
                IsNew = i % 2 == 0,
                Received = DateTime.Now.AddMinutes(i % 2 > 0 ? i : -i)
            });
        }
    }

    public List<int> GetNewLetterIds_Classic()
    {
        var res = new List<int>();
        for (int i = 0; i < Letters.Count; i++)
        {
            if (Letters[i].IsNew)
                res.Add(Letters[i].Id);
        }
        return res;
    }

    public List<int> GetNewLetterIds_Linq()
    {
        var letters = from res in Letters where res.IsNew == true select res.Id;
        return letters.ToList();
    }

    public void SortByRecived_Classic()
    {
        for (int i = 0; i < Letters.Count - 1; i++)
        {
            for (int j = i + 1; j < Letters.Count; j++)
            {
                if (Letters[i].Received > Letters[j].Received)
                {
                    Letter temp = Letters[i];
                    Letters[i] = Letters[j];
                    Letters[j] = temp;
                }
            }
        }  
    }

public void SortByRecived_Linq()
    {
        Letters = Letters.OrderBy(letter => letter.Received).ToList();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // A
        Console.WriteLine("Часть A");
        var mail1 = new Mail("user1@mail.com");
        var mail2 = new Mail("user2@mail.com");
        var mail3 = new Mail("user3@mail.com");
        var mail4 = new Mail("user4@mail.com");
        var mail5 = new Mail("user5@mail.com");
        mail1.CreateRandomLetters(10);
        mail2.CreateRandomLetters(10);
        mail3.CreateRandomLetters(10);
        mail4.CreateRandomLetters(10);
        mail5.CreateRandomLetters(10);

        var countNewLetters_classic = mail1.GetNewLetterIds_Classic();
        Console.WriteLine($"Количество новых писем (Classic): {countNewLetters_classic.Count}");

        var countNewLetters_linq = mail1.GetNewLetterIds_Linq();
        Console.WriteLine($"Количество новых писем(Linq): {countNewLetters_linq.Count}");

        mail1.SortByRecived_Linq();
        mail4.SortByRecived_Linq();

        Console.WriteLine("\nПроверка сортировки LINQ:");
        foreach (var i in mail1.Letters)
        {
            Console.Write($"{i} {i.Id} полученно в ");
            Console.Write($"{i.Received}\n");
        }

        // B

        Console.WriteLine("");
        Console.WriteLine("Часть B");
        Console.WriteLine("Старые письма:");
        mail4.Letters.Where(j => !j.IsNew).ToList().ForEach(j => Console.WriteLine("Письмо новое? {" + j.IsNew + "} получено в " + j.Received));

        var newestEmailTime = mail4.Letters.Where(j => j.IsNew == true).OrderBy(j => j.Received).FirstOrDefault()?.Received;

        Console.WriteLine($"\nСамое новое письмо пришло в: {newestEmailTime}");

        // C
        Console.WriteLine("\nЧасть С");
        string text1 = "The quick brown fox jumps over the lazy dog.";
        string text2 = "The quick fox jumps over a lazy cat.";
        int n = 2;

        var ngrams1 = GetNGrams(text1, n);
        var ngrams2 = GetNGrams(text2, n);

        int distinctNGrams1 = ngrams1.Count;
        int distinctNGrams2 = ngrams2.Count;
        double jaccardCoefficient = CalculateJaccardCoefficient(ngrams1, ngrams2);

        Console.WriteLine("Количество N-грамм в первом тексте: " + distinctNGrams1);
        Console.WriteLine("Количество N-грамм во втором тексте: " + distinctNGrams2);
        Console.WriteLine("Коэффициент Жаккара для текстов: " + jaccardCoefficient);
    }
    static HashSet<string> GetNGrams(string text, int n)
    {
        var ngrams = new HashSet<string>();
        var words = text.Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i <= words.Length - n; i++)
        {
            var ngram = string.Join(" ", words.Skip(i).Take(n));
            ngrams.Add(ngram.ToLower());
        }

        return ngrams;
    }

    static double CalculateJaccardCoefficient(HashSet<string> set1, HashSet<string> set2)
    {
        var intersectionCount = set1.Intersect(set2).Count();
        var unionCount = set1.Union(set2).Count();

        return (double)intersectionCount / unionCount;
    }
}
 