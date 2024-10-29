//Random random = new Random();
//int randomNumber = random.Next(1, 10);
//int Number = int.Parse(Console.ReadLine());


//მასეთი ქეისიც შეიძლება დადგეს
//int Number = int.Parse(Console.ReadLine());

//switch (Number)
//{
//    case 1:
//    case 2:
//        Console.WriteLine("samshabati");
//        break;
//    case 3:
//    case 4:
//    case 5:
//    case 6:   
//    case 7:
//        Console.WriteLine("kvira");
//        break;
//    default:
//        Console.WriteLine("araswori ricxvi");
//        break;
//}

//int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());

//switch (a, b)
//{
//    case (11,12):
//        Console.WriteLine("ARASWORI CIFRI");
//        break;
//    case (5,7):
//        Console.WriteLine("SWORI CIFRI");
//        break;
//}

//1.Switch Case: კვირის დღე

//დაწერეთ პროგრამა, რომელიც მიიღებს მომხმარებლისგან მთელ რიცხვს (1-დან 7-მდე) და
//გამოიყენებს switch ოპერატორს კვირის შესაბამისი დღის დასაბეჭდად. თუ შეყვანილი რიცხვი არ არის 1-დან 7-მდე,
//დაბეჭდოს "არასწორი რიცხვი".

//მაგალითად

//// შეყვანილი რიცხვი: 3
//// პასუხი: "ოთხშაბათი"

//using System.Security.Cryptography;

int Number = int.Parse(Console.ReadLine());

switch (Number)
{
    case 1:
        Console.WriteLine("orshabati");
        break;
    case 2:
        Console.WriteLine("samshabati");
        break;
    case 3:
        Console.WriteLine("otxshabati");
        break;
    case 4:
        Console.WriteLine("xutshabati");
        break;
    case 5:
        Console.WriteLine("paraskevi");
        break;
    case 6:
        Console.WriteLine("shabati");
        break;
    case 7:
        Console.WriteLine("kvira");
        break;
    default:
        Console.WriteLine("araswori ricxvi");
        break;
}



//2.While Loop: დადებითი რიცხვების ჯამი

//დაწერეთ პროგრამა, რომელიც while ციკლის გამოყენებით ითხოვს მომხმარებლისგან
//დადებითი რიცხვების შეყვანას. გააგრძელე რიცხვების დამატება, სანამ მომხმარებელი არ შეიყვანს უარყოფით რიცხვს. ამის შემდეგ დაბეჭდე ჯამი.

//მაგალითად
//// შეყვანილი რიცხვები: 5, 10, -1
//// პასუხი: "ჯამი: 15"
///

//Random random = new Random();
//int randomNumber = random.Next(1, 10);


//while (true){
//    Console.WriteLine("new Number");
//    int Num = int.Parse(Console.ReadLine());

//    if (Num== randomNumber)
//    {
//        Console.WriteLine("bingo");
//        break;
//    }
//}

int sum = 0;


while (true)
{

    int num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        break;
    }

    sum += num;
}

Console.WriteLine("JAMI:" + sum);



//3.For Loop: გამრავლების ცხრილი

//დაწერე პროგრამა, რომელიც ითხოვს რიცხვის შეყვანას მომხმარებლისგან და შემდეგ გამოიყენებს for ციკლს,
//რათა დაბეჭდოს ამ რიცხვის გამრავლების ცხრილი 1-დან 10-მდე.

//მაგალითად

// შეყვანილი რიცხვი: 3
// პასუხი:
// "3 x 1 = 3"
// "3 x 2 = 6"
// ...
// "3 x 10 = 30"

int newNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int Sum = i * newNumber;
    Console.WriteLine(i + "x" + newNumber + "=" +  Sum);
}


