Person:

-name
-StrengthScore ( int + int + int = rating)

private int[] Strengths; - Liste med alle styrker


Strength:
- private int







Person. []  - alle class Strength.



Robert.IncreaseStrenght(strength)


Persons.json
["Robert"] = {
    Strengths : {
        Humor: 12,

    }
}


var textToFile = $@"[{name}] = {
    Strengths : {
        Humor: 12,

}
}"

/*
System.IO.File.WriteAllText (@"D:\path.txt", contents);
If the file exists, this overwrites it.
If the file does not exist, this creates it.
Please make sure you have appropriate privileges to write at the location,
otherwise you will get an exception.

#SAVE NOTIFICATION/ALERT;
*/