using Casting_List_Practice;
using Casting_List_Practice.Controllers;
using Casting_List_Practice.Models;


#region homeworkpractice
//Generics<Product> products = new Generics<Product>();

//products.Add(new Product { Id = 1, Name = "Iphone", Price = 3000 });
//products.Add(new Product { Id = 2, Name = "Samsung", Price = 2200 });
//products.Add(new Product { Id = 3, Name = "Xiaomi", Price = 300 });




//foreach (var item in res)
//{
//    Console.WriteLine($"Name : {item.Name}");
//}



//var result = products.GetById(2);

//products.delete(3);


//var res = products.ShowAll();


//foreach (var item in res)
//{
//    Console.WriteLine($"{item.Name}");
//}



//try
//{
//    int num = 5;
//    int factorial = 1;

//    if(num < 0)
//    {
//        throw new LessThanZeroException();
//    }

//    for(int i = 1; i <= num; i++)
//    {
//        factorial *= i;
//    }

//    Console.WriteLine(factorial);
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

#endregion



//Animal animal = new Animal();   

//Fish fish = new Fish();

//Bird bird = new Bird();

//Animal animal1 = fish;

//Fish fish1 = (Fish)animal;


//-------------------------


//int num1 = 10;

//object obj = num1;

//int num2 = (int)obj;


//bool isMarried = true;

//object data = isMarried;

//bool test = (bool)data;


//string name = "Nurlan";

//object data2 = name;

//string name2 = data2.ToString();




//-------------------------------


//byte a = 5;

//int num1 = a;

//byte a1 = (byte)num1;



//double num2 = 10;

//int a2 = (int)num2;



//------------------------------


//Animal animal = new Animal();

//Bird bird = new Bird();

//Fish fish = new Fish();


//object[] datas = { 1, 2, fish, "Nurlan", 100, bird, 155 };


//foreach (var data in datas)
//{
//   if(data is Animal t)
//    {
//        t.Name = "xxx";
//        Console.WriteLine(t.Name);
//    }
//    else
//    {
//        Console.WriteLine($"{data} - cannot change");
//    }

//}


//foreach (var data in datas)
//{
//    Animal animal = data as Animal;
//    if(animal != null)
//    {
//        animal.Name = "test";
//        Console.WriteLine(animal.Name);
//    }
//}




//------------List--------------------


//List<int> nums = new List<int>();

//List<int> nums2 = new List<int>();

//nums2.Add(100);

//nums2.Add(200);

//nums.AddRange(nums2);

//nums.Add(1);
//nums.Add(2);
//nums.Add(3);

//for(int i = 0; i < nums.Count; i++)
//{
//    Console.WriteLine(nums[i]);
//}


//List<string> names = new() { "Nurlan", "Nermin" , "Gunel"};

//for(int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}




//List<string> names = new() { "Nurlan","Nermin","Gunel"};


//static void CheckName(string name,List<string> names)
//{
//    if (names.Contains(name))
//    {
//        Console.WriteLine("Yes");
//    }
//    else
//    {
//        Console.WriteLine("No");
//    }
//}


//CheckName("Nurlan", names);



//List<Product> products = new List<Product>();


//products.Add(new Product { Id = 1, Name = "Iphone", Price = 3000 });
//products.Add(new Product { Id = 2, Name = "Samsung", Price = 2600 });
//products.Add(new Product { Id = 3, Name = "Nokia", Price = 600 });


//static List<Product> Search(string txt,List<Product> products)
//{
//    return products.Where(m => m.Name.Contains(txt)).ToList();

//}




//List<int> nums = new() { 111, 222, 333, 444, 5, 6, 100, 150, 200 };


//for(int i = 0; i < nums.Count; i++)
//{
//    if(i <= 4)
//    {
//        Console.WriteLine(nums[i]);
//    }
//} 


//for (int i = 0;i <= nums.Count; i++)
//{
//    int index = nums.IndexOf(5);

//    if(i <= index)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}




ProductControllers productControllers = new ProductControllers();

//productControllers.GetById();

//productControllers.GetAll();

productControllers.Sort();