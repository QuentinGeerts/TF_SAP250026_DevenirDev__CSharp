/*
 * Exercice récapitulatif - Gestionnaire de livres
 */


using BookManager.Enums;
using BookManager.Models;

List<Book> books = new List<Book>();

#region Création des livres

Book b1 = new Book
{
    Title = "L'épée de vérité",
    Author = "Terry GoodKind",
    NbPages = 576,
    Status = Status.InProgress
};

Book b2 = new Book
{
    Title = "Le Petit Prince",
    Author = "Antoine de Saint-Exupéry",
    NbPages = 96,
    Status = Status.Completed
};

Book b3 = new Book
{
    Title = "Dune",
    Author = "Frank Herbert",
    NbPages = 688,
    Status = Status.NotStarted
};

Book b4 = new Book
{
    Title = "Les Misérables",
    Author = "Victor Hugo",
    NbPages = 1463,
    Status = Status.Abandoned
};

Book b5 = new Book
{
    Title = "Le Seigneur des Anneaux",
    Author = "J.R.R. Tolkien",
    NbPages = 1178,
    Status = Status.Completed
};

books.AddRange([b1, b2, b3, b4, b5]);

#endregion

#region Menu
Menu userInput = Menu.None;

while (userInput != Menu.Quit)
{
    Console.WriteLine($" --- Gestionnaire de livres --- ");

    Console.WriteLine($" 1. Afficher tous les livres");
    Console.WriteLine($" 2. Afficher uniquement les livres terminés");
    Console.WriteLine($" 3. Afficher les livres par statut(demander le statut à l'utilisateur)");
    Console.WriteLine($" 4. Changer le statut d'un livre");
    Console.WriteLine($" 5. Quitter");

    Console.WriteLine($"Choix: ");
    while (!Enum.TryParse(Console.ReadLine(), true, out userInput))
    {
        Console.WriteLine($"Erreur, réessayez: ");
    }

    switch (userInput)
    {
        case Menu.GetAllBooks:
            Console.WriteLine($" --- Liste des livres ---");

            DisplayBooks();

            Pause();
            break;

        case Menu.GetCompletedBooks:
            Console.WriteLine($" --- Liste des livres terminés ---");

            DisplayBooks(Status.Completed);

            Pause();
            break;

        case Menu.GetBooksByStatus:
            Console.WriteLine($" --- Liste des livres filtrées ---");

            Status status = GetStatus();

            DisplayBooks(status);

            Pause();
            break;

        case Menu.UpdateBookStatus:
            Console.WriteLine($" --- Mise à jour du statut ---");

            Console.WriteLine($"Liste des livres:");

            DisplayBooks();

            Console.WriteLine($"Entrez le nom du livre à modifier: ");
            string bookTitle = Console.ReadLine()!;

            Book selectedBook;
            int index = -1;

            while (!ContainsBook(bookTitle, out selectedBook, out index))
            {
                Console.WriteLine($"Introuvable, réessayez:");
                bookTitle = Console.ReadLine()!;
            }
            
            Console.WriteLine($"Livre selectionné: {selectedBook.Title} - Statut: {selectedBook.Status}");

            Status newStatus = GetStatus();

            selectedBook.Status = newStatus;
            books.RemoveAt(index);
            books.Insert(index, selectedBook);

            Console.WriteLine($"Le statut a été mis à jour.");

            Pause();
            break;

        case Menu.Quit:
            Console.WriteLine($"Au revoir !");
            break;
    }
}

#endregion

#region Utilitaires

void Pause()
{
    Console.WriteLine($"Appuyez sur une touche pour continuer...");
    Console.ReadLine();
    Console.Clear();
}

bool ContainsBook(string title, out Book selectedBook, out int index)
{
    foreach (Book book in books)
    {
        if (book.Title == title)
        {
            selectedBook = book;
            index = books.IndexOf(book);
            return true;
        }
    }
    selectedBook = default;
    index = -1;
    return false;
}

Status GetStatus ()
{
    Console.WriteLine($"Liste des status: ");
    foreach (Status s in Enum.GetValues<Status>())
    {
        Console.WriteLine($"{(int)s}. {s}");
    }

    Console.WriteLine($"Choix:");

    Status status;
    while (!Enum.TryParse(Console.ReadLine(), true, out status))
    {
        Console.WriteLine($"Erreur, réessayez: ");
    }
    return status;
}

void DisplayBooks (Status? status = null)
{
    foreach (Book book in books)
    {
        if ((status != null && book.Status == status) || status == null)
        {
            Console.WriteLine($" - {book.DisplayInformation()}");
        }
    }
}

#endregion
