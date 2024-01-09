public class Cauntry
{
    string name;
    int population;
    string capital;
    string officialLanguage;
    public void Country(string name,string capital,int population,string officialLanguage )
    {
        this.name = name;
        this.population = population;
        this.capital = capital;
        this.officialLanguage = officialLanguage;
    }
    public string GetName()
    {
        return name;
    }
    public void SetCapital(string capital) 
    {
        this.capital = capital;
    }
   
    public string GetCapital()
    {
        return capital;
    }
      public void SetPopulation(int population) 
    {
         this.population = population;
    }
   
    public int GetPapulation()
    {
        return population;
    }
       public void SetOfficialLanguage(string officialLanguage) 
    {
        this.officialLanguage = officialLanguage;
    }
   
    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }

}