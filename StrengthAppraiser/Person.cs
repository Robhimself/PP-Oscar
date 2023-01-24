public class Person
{
  private string _name;
//  private string[] _strenghts;
  private Strength _strengths;
  // ["humor: 6", "Lærevillig: 2"]





  public Person(string name)
  {
      _name = name;
      _strengths = new Strength();
  }


  private void UpdateStrenght(string strength)
  {
      _strengths.IncreaseStrenght(strength);
  }


}