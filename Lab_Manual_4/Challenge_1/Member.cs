using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public List<string> BooksBought { get; set; } = new List<string>();
        public int NumBooksBought { get; set; } = 0;
        public double MoneyInBank { get; set; }
        public double AmountSpent { get; set; } = 0;
        public Member(string name, int memberId, double moneyInBank)
        {
            Name = name;
            MemberID = memberId;
            MoneyInBank = moneyInBank;
        }
        public void DisplayMember()
        {
            Console.WriteLine($"Name: {Name}\nMember ID: {MemberID}\nBooks Bought: {NumBooksBought}\nAmount Spent: {AmountSpent:C}\nMoney in Bank: {MoneyInBank:C}\n");
        }
    }
}
