public class Strength
{

    public string StrengthName {get; private set;}
    public int StrengthScore {get; private set;}

    public Strength(int index)
    {
        StrengthName = GetStrengthName(index);
        StrengthScore = 0;
    }



    public void IncreaseStrength()
    {
        StrengthScore++;
    }

    
    private string GetStrengthName(int index)
    {
        var nameList = new string[24]
        {
            "AppreciationOfBeautyAndExcellence",
            "Bravery",
            "Creativity",
            "Curiosity",
            "Fairness",
            "Forgiveness",
            "Gratitude",
            "Honesty",
            "Hope",
            "Humility",
            "Humor",
            "Judgment",
            "Kindness",
            "Leadership",
            "Love",
            "LoveOfLearning",
            "Perseverance",
            "Perspective",
            "Prudence",
            "SelfRegulation",
            "SocialIntelligence",
            "Spirituality",
            "TeamWork",
            "Zest"
        };

        return nameList[index];
    }

}