using System;
namespace Challenge_1
{
    class Bookstore
    {
        public List<Book> books = new List<Book>();
        public List<Member> members = new List<Member>();
        public double totalSales = 0;
        public double membershipFees = 0;

        public void AddBook()
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter publisher: ");
            string publisher = Console.ReadLine();

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter stock: ");
            int stock = int.Parse(Console.ReadLine());

            Console.Write("Enter year of publication: ");
            int year = int.Parse(Console.ReadLine());

            string[] authors = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter author {i + 1} (or press Enter to skip): ");
                authors[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(authors[i])) break;
            }

            books.Add(new Book(title, authors, publisher, isbn, price, stock, year));
            Console.WriteLine("Book added successfully!\n");
        }

        public void SearchBookByTitle()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.DisplayBook();
                    return;
                }
            }
            Console.WriteLine("Book not found!\n");
        }

        public void AddMember()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter member ID: ");
            int memberId = int.Parse(Console.ReadLine());

            Console.Write("Enter money in bank: ");
            double moneyInBank = double.Parse(Console.ReadLine());

            members.Add(new Member(name, memberId, moneyInBank));
            membershipFees += 10; 
            Console.WriteLine("Member added successfully!\n");
        }

        public void DisplayTotalSales()
        {
            Console.WriteLine($"Total Sales: {totalSales:C}\nTotal Membership Fees: {membershipFees:C}\n");
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Welcome! ---");
                Console.WriteLine("1. Add Book\n2. Search Book\n3. Add Member\n4. Display Total Sales\n5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        SearchBookByTitle();
                        break;
                    case 3:
                        AddMember();
                        break;
                    case 4:
                        DisplayTotalSales();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.\n");
                        break;
                }
            }
        }
    }
}