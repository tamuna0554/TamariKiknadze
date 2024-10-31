
// დავალება #2

//int[] randomNumbers = new int[10];

//for (int i = 0; i < randomNumbers.Length; i++)
//{
//    Random random = new Random(); 
//    int input = random.Next(1,10);
//    randomNumbers[i] = input;
//}

//for (int i = 0;i < randomNumbers.Length; i++)
//{
//    Console.Write(randomNumbers[i] + " ");
//}


//int[,] myArr = new int[,] { { 1, 2, 4 }, { 1, 2, 6 }, { 1, 2, 9 }, { 1, 2, 8,  } };

//for (int i = 0; i < myArr.GetLength(0); i++)
//{
//    for (int j = 0; j < myArr.GetLength(1); j++)
//    {
//        Console.Write(myArr[i, j]);
//    }
//    Console.WriteLine();
//}

//მაქსიმალური ქულისთვის, დავალება #2, ორგანზომილებიანი მასივი:
//შექმენით 3x2 ზომის 2D int-ის მასივი სახელად grades, რომელიც წარმოადგენს სტუდენტების ქულებს. ( 3 სტუდენტი, თითო 2 ქულით )
//სამივე სტუდენტს უნდა დაუწეროთ ორი სხვადასხვა საგნის ქულა
//( უნდა დაბეჭდოთ სტუდენტის სახელი და შემდეგ მომხმარებელმა ორი ქულა უნდა შეიყვანოს, რითიც 2D მასივს შეავსებთ )
//დაბეჭდეთ ცალ-ცალკე ხაზად სტუდენტის სახელი და შემდეგ მისი ქულები ორივე საგანში.

int[,] grades = new int[3, 2];
string[] studentNames = { "giorgi", "ana", "davit" };

for (int i = 0; i < grades.GetLength(0); i++)

{
    Console.WriteLine(studentNames[i]);



    for (int j = 0; j < grades.GetLength(1); j++)
	{
		int qula = int.Parse(Console.ReadLine());
		grades[i, j] = qula;
	}
}


Console.WriteLine();
for (int i = 0; i < grades.GetLength(0); i++)
{
    Console.WriteLine($"{studentNames[i]}: qula 1 = {grades[i, 0]}, qula 2 = {grades[i, 1]}");
}

