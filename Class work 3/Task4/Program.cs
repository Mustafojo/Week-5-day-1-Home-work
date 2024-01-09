class Actor {
     string fullName;
     string gender;
     List<string> moviesPlayed;
     int age;

     public Actor(){}
    public Actor(string name, int sub, string gender){
        fullName = name;
        age = sub ;
        this.gender = gender;
    }

    
    public void AddMovie(string movieTitle){
        moviesPlayed.Add(movieTitle);
    }
    public List<string> GetMoviesPlayed(){
       return moviesPlayed;
    }
   
     public void SetAge(int years){
        age = years;
    }
    public int GetExperience(){
        return age;
    }
     public void SetGender(string gender1){
        gender = gender1;
    }
    public string GetGender(){
        return gender;
    }
    
}