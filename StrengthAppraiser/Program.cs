using System.IO;

// lese fra tekstfil

// populere fra tekstfil

//


var content = @"[""Oscar""] = {    strengths: {    bravery: 0,    hope: 0,},";

File.WriteAllText(@"data.txt", content);
var personsFile = File.ReadAllText(@"data.txt");
Console.WriteLine(personsFile);
        string? afterTrim;
        char[] removeChar = { '[', ']', '=', ':', ' ' };
//        foreach (char c in removeChar)
//        {
//            personsFile.Trim(removeChar);
//
//        }

        for (var i = 0; i < removeChar.Length; i++)
        {
            personsFile = personsFile.Trim(removeChar[i]);
        }


        Console.WriteLine(personsFile);

var persons = new Person[2]
{
    new Person("Oscar"),
    new Person("Robert"),
};



while (true)
{
    // Startup
    Console.WriteLine($"Your Team Members");

    for (var i = 0; i < persons.Length; i++)
    {
        Console.WriteLine($"[{i +1}] - {persons[i].Name}");
    }


    //Action List ( add person, choose person.)
    //AddPerson()
    //SelectPerson()


    //
    Console.Write("If you spotted a strength in a team member, Choose the person from the list and enter their number: ");
    var selectedPerson = Convert.ToInt32(Console.ReadLine());
    if (selectedPerson > persons.Length +1)
    {
        Console.WriteLine("This person does not exist!");
        return;
    }

    var chosenPerson = persons[selectedPerson -1];
    var strList = chosenPerson.ShowStrengths();

    for (var i = 0; i < strList.Count; i++)
    {
        Console.WriteLine($"[{i +1}] - {strList[i]}: {chosenPerson.ShowStrengthScore(i)}");
    }


    //IncreaseStrength()
    Console.Write("Write the number of the strength you would like to change: ");
    int strengthNumber = Convert.ToInt32(Console.ReadLine());
    int strengthIndex = strengthNumber - 1;

    var strength = chosenPerson.ShowStrength(strengthIndex);
    Console.WriteLine($"Do you really want to increase {chosenPerson.Name}'s {strength} by 1?: ");
    Console.WriteLine($"[1] - Yes");
    Console.WriteLine($"[2] - No");
    int actionConfirmation = Convert.ToInt32(Console.ReadLine());
    if (actionConfirmation == 1)
    {
        chosenPerson.UpdateStrength(strength,true);
    }

}

//

// skrive til tekstfil