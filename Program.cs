// See https://aka.ms/new-console-template for more information

Console.WriteLine("Start of code");

//var data = AccessData.GetData().Take(2);

//foreach(var person in data){
//    Console.WriteLine($"Read data of {person.FirstName} {person.LastName}");
//}

var prime = Generator.GetPrimeNumber();


var iterator = prime.GetEnumerator();

for (int i = 0; i < 10; i++)
{
    if(iterator.MoveNext()){
        Console.WriteLine(iterator.Current);
    }
    else{
        break;
    }


}

int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    if(iterator.MoveNext()){
        Console.WriteLine(iterator.Current);
    }
    else{
        break;
    }


}


Console.WriteLine("End of code");




public class PersonModel{


    public PersonModel(string firstName, string lastName){

        FirstName = firstName;
        LastName = lastName;

        Console.WriteLine($"Initialized {FirstName} {LastName}");

    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class AccessData{

    public static IEnumerable<PersonModel> GetData(){

        
        yield return new PersonModel("Jim", "Carey");
        yield return new PersonModel("Tim", "sweeeny");
        yield return new PersonModel("Jack", "Dorthy");

        

    } 
}

public class Generator{

    public static IEnumerable<int> GetPrimeNumber(){
        int counter = 1;
        while(true){
            if(IsPrimeNumber(counter)){

                yield return counter;
            }
            counter++;
        }
    }

    private static bool IsPrimeNumber(int value){
        bool output = true;
        for (int i= 2; i<=value/2;i++){

            if(value%i==0){
                output = false;
                break;
            }
        }

        return output;

    }
}

