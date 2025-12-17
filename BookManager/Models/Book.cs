using BookManager.Enums;

namespace BookManager.Models;

public struct Book
{
    public string Title;
    public string Author;
    public int NbPages;
    public Status Status;

    public string DisplayInformation()
    {
        return $"[{Status}] {Title} de {Author} ({NbPages} pages)";
    }

    public void UpdateStatus(Status newStatus)
    {
        if (!Enum.IsDefined(typeof(Status), newStatus)) return;

        Status = newStatus;
    }

    public bool IsRead ()
    {
        return Status == Status.Completed;
    }
}
