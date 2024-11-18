// See https://aka.ms/new-console-template for more information
using stack_and_heap;

Console.WriteLine("Hello, World!");


//შექმენით Person კლასი სახელისა და ასაკის ველებით.
//Main მეთოდში შექმენით ორი ცვლადი სახელისა და ასაკისთვის და მიანიჭეთ ნებისმიერი მნიშვნელობა.
//Main მეთოდში შექმენით Person კლასის ობიექტი და ველების შესავსებად გამოიყენეთ შექმნილი ცვლადები.
//შექმნილი ობიექტი შეინახეთ ახალ ცვლადში და შეუცვალეთ ველებს მნიშვნელობა.
//ამ კოდის დაწერის შემდეგ წარმოადგინეთ გრაფიკული აღწერა სტეკისა და ჰიპის, 
//სად რომელი ცვლადი შეინახება და რომელი რას მიმართავს. ნაბიჯ ნაბიჯ გამოყავით შექმნისა და ცვლილებების მიმდევრობა. 
//ატვირთეთ კოდის ლინკი და ცალკე ფაილი გრაფიკული აღწერისთვის, შეგიძლიათ ფურცელზეც შეასრულოთ.
string name = "Tamuna";
int age = 25;

Person person = new Person(name, age);

//Console.WriteLine(person.Name + " "+ person.Age);

Person person1 = person;

//Console.WriteLine(person1.Name + person1.Age);

person1.Name = "giorgi";
person1.Age = 35;

