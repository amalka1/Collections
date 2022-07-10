// See https://aka.ms/new-console-template for more information
// Arrays 
int[] numbers = {0,1,2,3,4,5,6,7,8,9}; 
string [] names = { "Tim", "Martin", "Nikki", "Sara"};
bool [] alternate = new bool[10];
for (int i = 0; i< alternate.Length;i++){
    if (i%2 == 0){
        alternate[i] = true;
    }else {
        alternate[i]= false;
    }
}

//Creating list.
List<string> iceCreamFlavors = new List<string>();
// Adding items to the list.
iceCreamFlavors.Add("Kiwi");
iceCreamFlavors.Add("Banana");
iceCreamFlavors.Add("Strawberries");
iceCreamFlavors.Add("Chocolate");
iceCreamFlavors.Add("Vanilla");
iceCreamFlavors.Add("Pistachio");
iceCreamFlavors.Add("Coffe");
//Printing list length.
System.Console.WriteLine("List length is " + iceCreamFlavors.Count);
string secondvalue = iceCreamFlavors[2];
//Printing the third item in the list.
System.Console.WriteLine("The third item in the list is " + secondvalue);
// Removing the third item in the list.
iceCreamFlavors.Remove(secondvalue);
// Printing new list length.
System.Console.WriteLine("List new length is " + iceCreamFlavors.Count);

//Creating dictionary.
Dictionary<string, string> namesAndFlavors = new Dictionary<string, string>();
Random rand = new Random();

//Adding key and value pairs to dictionary.
for (int i = 0; i< names.Length; i++){
    int index = rand.Next(0, names.Length-1);

    namesAndFlavors.Add(names[i], iceCreamFlavors[index] );
}
//Printing dictionary out.
foreach (KeyValuePair<string,string> entry in namesAndFlavors)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}


