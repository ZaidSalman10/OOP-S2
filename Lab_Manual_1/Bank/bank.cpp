#include<iostream>
using namespace std;

float balance;

string menu()
{
    string option = "0";
    while (option != "1" && option != "2" && option != "3")
    {
        system("cls");
        cout << "1. Customer" <<endl;
        cout << "2. Bank" << endl;
        cout << "3. Exit" << endl;
        cout << "Select your option: ";
        cin >> option;
    }
    return option;
}

string customer()
{
    string option = "0";
    while (option != "1" && option != "2" && option != "3" && option != "4" && option != "5")
    {
        system("cls");
        cout << "1. Deposit" <<endl;
        cout << "2. Withdraw" << endl;
        cout << "3. Request Loan" <<endl;
        cout << "4. Check Balance" <<endl;
        cout << "5. Exit" << endl;
        cout << "Select your option: ";
        cin >> option;
    }
    return option;
}

string bank()
{
    string option = "0";
    while (option != "1" && option != "2" && option != "3" )
    {
        system("cls");
        cout << "1. Deduct Zakat" <<endl;
        cout << "2. Loan Requests" << endl;
        cout << "3. Exit" << endl;
        cout << "Select your option: ";
        cin >> option;
    }
    return option;
}

void deposit()
{
    float amount, acc;
    int pin;
    cout << "Enter the amount you want to deposit in your Bank account: ";
    cin >> amount;
    cout << "Enter your Acc No: ";
    cin >> acc;
    cout << "Enter your PIN code: ";
    cin >> pin;
    balance = balance + amount;
    cout << "Amount added sucessfully..." <<endl;
    cout << "Press Enter key to continue..." <<endl;
    getchar();
}

void withdraw()
{
    float amount = balance + 1, acc;
    int pin;
    while(amount > balance)
    {
        system("cls");
        cout << "Enter the amount you want to withdraw in your Bank account: ";
        cin >> amount;
        if (amount > balance)
        {
            cout << "Not enough cash in you account. Please try again..." <<endl;
            cout << "Press Enter key to continue..." <<endl;
            getchar();
        }
    }
    cout << "Enter your Acc No: ";
    cin >> acc;
    cout << "Enter your PIN code: ";
    cin >> pin;
    balance = balance - amount;
    cout << "Amount retrived sucessfully..." <<endl;
    cout << "Press Enter key to continue..." <<endl;
    getchar();
}

float loan()
{
    float amount, acc;
    int pin;
    cout << "Enter the amount you want to borrow from Bank: ";
    cin >> amount;
    cout << "Enter your Acc No: ";
    cin >> acc;
    cout << "Enter your PIN code: ";
    cin >> pin;
    cout << "Amount requested sucessfully..." <<endl;
    cout << "Press Enter key to continue..." <<endl;
    getchar();
    return amount;
}

void view(float loan_amount)
{
    cout << "Your Balance: " << balance << endl;
    cout << "Loan Request Status: ";
    if(loan_amount > 0){cout << "Request Pending";}
    else{cout << "No Request Pending";}
    cout << endl;
    cout << "Press Enter key to continue..." <<endl;
    getchar();
    getchar();
}

void deduct()
{
    balance = balance - (balance * (2.5/100));
    cout << "Amount deducted: " << balance * (2.5/100) <<endl;
    cout << "Remaining amount: " << balance <<endl;
    cout << "Zakat deducted sucessfully..." <<endl;
    cout << "Press Enter key to continue..." <<endl;
    getchar();
    getchar();
}

void requests(float loan_amount)
{
    string choice;
    while(choice != "1" && choice != "2")
    {
        system("cls");
        cout << "Loan Requested: " << loan_amount <<endl;
        cout << "Press '1' to accept or '2' to reject" <<endl;
        cin >> choice;
    }
    if (choice == "1")
    {
        balance = balance + loan_amount;
        cout << "Amount added in customers Acc sucessfully..." <<endl;
        cout << "Press Enter key to continue..." <<endl;
    }
    else
    {
        cout << "Request rejected sucessfully..." <<endl;
        cout << "Press Enter key to continue..." <<endl;
    }
    getchar();
    getchar();
}

main()
{
    string op;
    float loan_amount;
    while(op != "3")
    {
        op = "0";
        system("cls");
        op = menu();
        if(op == "1")
        {
            op == "0";
            string op1;
            while(op1 != "5")
            {
                op1 = customer();
                system("cls");
                if (op1 == "1")
                {
                    deposit();
                }
                if (op1 == "2")
                {
                    withdraw();
                }
                if (op1 == "3")
                {
                    loan_amount = loan();
                }
                if (op1 == "4")
                {
                    view(loan_amount);
                }
            }
        }
        if(op == "2")
        {
            op == "0";
            string op2;
            while(op2 != "3")
            {
                op2 = bank();
                system("cls");
                if (op2 == "1")
                {
                    deduct();
                }
                if (op2 == "2")
                {
                    if(loan_amount > 0){requests(loan_amount);}
                    else
                    {
                        cout << "No loan Requested..." <<endl;
                        cout << "Press Enter key to continue..." <<endl;
                        getchar(); 
                    }
                }
            }   
        }
    }
}
