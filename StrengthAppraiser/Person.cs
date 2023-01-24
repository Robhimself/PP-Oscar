public class Person
{
  public string Name;
  private readonly Strength[] _strengths;


  public Person(string personName)
  {
      Name = personName;
      _strengths = new Strength[24];
      for (int i = 0; i < _strengths.Length; i++)
      {
        _strengths[i] = new Strength(i);
      }
  }


  public string ShowStrength(int index)
  {
      return _strengths[index].StrengthName;
  }
  public int ShowStrengthScore(int index)
  {
      return _strengths[index].StrengthScore;
  }

  public List<string> ShowStrengths()
  {
      var list = new List<string>();
      for (var i = 0; i < _strengths.Length; i++)
      {
          list.Add(ShowStrength(i));
      }
      return list;
  }

  public void UpdateStrength(string strength, bool isIncrease)
  {
      var index = FindIndex(strength);
    if(isIncrease)
    {
        _strengths[index].IncreaseStrength();
        Console.WriteLine($"{strength} has been increased. Value is now {_strengths[index].StrengthScore}");
    }

  }

  private int FindIndex(string strength)
  {
      var index = 0;
      for (int i = 0; i < _strengths.Length; i++)
      {
          if (_strengths[i].StrengthName == strength)
          {
              index = i;
          }
      }
      return index;
  }


}