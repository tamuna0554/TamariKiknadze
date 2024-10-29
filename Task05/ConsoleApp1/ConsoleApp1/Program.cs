
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

string[] Students  = new string[3];

for (int i = 0; i < Students.Length; i++)
{
    string Name = Console.ReadLine();
    Students[i] = Name; 
}

