//int jami = int.Parse(Console.ReadLine());
//int jami2 = int.Parse(Console.ReadLine());

//bool result = jami > 3 && 1 > 2; ყოველთვის იქნება false
// bool result = jami > 3 || 1 > 2; პასუხი დამიკიდებულია jami 
// bool result = jami > 3 && 2 > 1; პასუხი დამიკიდებულია jami 
// bool result = jami > 3 || 2 > 1; ყოველთვის იქნება true

//bool result = !(jami > 3 && 1 > 2); ყოველთვის იქნება true, ზევით რაც ეწერა საპირისპირო პასუხია

//if (jami <15 && 5 > 2){

//Console.WriteLine("shecdomaa");}



Random random = new Random();
int randomNumber = random.Next(1, 10);
//int randomNumber = 15;
int tryCount = 0;

int Number = int.Parse(Console.ReadLine());

if (randomNumber == Number)
{
    Console.WriteLine("moiget");
}
else
{
    int attempt = ++tryCount;
    int number2 = int.Parse(Console.ReadLine());
    //Console.WriteLine(attempt);

    if ((attempt == 1) && (randomNumber == number2))
    {
        Console.WriteLine("moiget");
    }
    else
    {
        int attempt1 = ++attempt;
        //Console.WriteLine(attempt1);
        int Number3 = int.Parse(Console.ReadLine());

        if ((attempt == 2) && (randomNumber == Number3))
        {
            Console.WriteLine("moiget");
        }
        else
        {
            Console.WriteLine("waaget");
        }
    }



    
}




