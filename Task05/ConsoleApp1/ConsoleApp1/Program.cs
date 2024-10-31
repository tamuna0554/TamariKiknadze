
//დავალება:

//შექმენით ერთგანზომილებიანი მასივი სახელად students, რომელიც დაიტევს 3 სტუდენტის სახელს.
//მომხმარებელმა უნდა ჩაწეროს ამ მასივში ნებისმიერი 3 სახელი.
//დაბეჭდეთ ყველა სტუდენტის სახელი.შექმენით ერთგანზომილებიანი მასივი სახელად students, რომელიც დაიტევს 3 სტუდენტის სახელს.
//მომხმარებელმა უნდა ჩაწეროს ამ მასივში ნებისმიერი 3 სახელი.
//დაბეჭდეთ ყველა სტუდენტის სახელი.

//string[] students = { "temo", "tamuna", "giorgi" };

//Console.WriteLine(students[0]);

//string a = Console.ReadLine();
//string b = Console.ReadLine();
//string c = Console.ReadLine();

//string[] students = {a, b, c};

//Console.WriteLine(students[0]);

string[] students = new string[3];

for (int i = 0; i
    < students.Length; i++)
{
    string name = Console.ReadLine();
    students[i] = name;
}

for (int i = 0; i < students.Length; i++)
{
    Console.Write(students[i] + " ");

}

