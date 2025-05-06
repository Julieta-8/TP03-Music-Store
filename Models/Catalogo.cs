namespace TP3_Usoz.Models;

static class Catalogo{
    static public Dictionary<int, Disco> disco{get; private set;}
static public void InicializarDisco(){
    disco = new Dictionary<int, Disco>();
  Disco disco1 = new Disco(1, "Face Value","Phill Collins", "Hugh Padgham", "Pop Rock", "FACE VALUE.png",new List<Tema>{new Tema(5.30, "In the Air Tonight" ),new Tema(3.46, "I Missed Again" ),new Tema(3.55, "Behind the Lines" ),new Tema(4.14, "Thunder and Lightning" ),new Tema(4.56, "If Leaving Me Is Easy" ),new Tema(3.56, "This Must Be Love" ),new Tema(2.33 ,"You Know What I Mean" ),new Tema(2.35, "I'm Not Moving" ), new Tema(4.47, "Tomorrow Never Knows" )});
  disco.Add(1, disco1 );
  
  
  Disco disco2 = new Disco(2,"Salad Days","Mac DeMarco", "Mac DeMarco", "Indie Rock", "Salad Days.png",
  new List<Tema>{new Tema(2.49, "Salad Days" ),new Tema(2.25, "Blue Boy" ), new Tema(3.08, "Brother" ),new Tema(2.22, "Let My Baby Stay" ),new Tema(2.26, "IOld Dog's New Tricks" ),new Tema(3.09, "Passing Out Pieces" ),new Tema(3.13, "Chamber of Reflection" ),new Tema(2.24, "Go Easy" ), new Tema(3.24, "Treat Her Better" )});
  disco.Add(2, disco2 );

  Disco disco3 = new Disco(3,"1989","Taylor Swift", "Max Martin", "Pop", "1989.png",
  new List<Tema>{new Tema(3.34, "Welcome to New York" ),new Tema(3.51, "Blank Space" ),new Tema(3.51, "Style" ),new Tema(3.55, "Out of The Woods" ),new Tema(3.13, "All you Had to Do Was Stay" ),new Tema(3.39, "Shake It Off" ),new Tema(3.30, "Bad Blood" ),new Tema(3.40, "Wildest Dreams" ), new Tema(3.28, "Hoy You Get the Girl" )});
  disco.Add(3, disco3 );
 Disco disco4 = new Disco(4,
    "EEIDIWCW?", 
    "The Cranberries", 
    "Stephen Street", 
    "Alternative Rock", 
    "Cranberries.png", 
    new List<Tema>{ new Tema(2.30, "I Still Do") ,
     new Tema(2.29, "Dreams") ,
     new Tema(2.42, "Sunday") ,
   new Tema(3.04, "Pretty") ,
    new Tema(2.53, "Wanted") ,
     new Tema(2.29, "Not Sorry") ,
     new Tema(3.04, "Linger") ,
    new Tema(3.01, "Still Can't..." ) }
);
  disco.Add(4, disco4);


Disco disco5 = new Disco(5,
    "Abbey Road", 
    "The Beatles", 
    "George Martin", 
    "Rock", 
    "Beatles.png", 
    new List<Tema>{ new Tema(4.47, "Come Together") ,
    new Tema(2.59, "Something") ,
     new Tema(2.43, "Maxwell's Silver Hammer") ,
     new Tema(3.16, "Oh! Darling") ,
     new Tema(2.59, "Octopus's Garden") ,
     new Tema(2.56, "I Want You (She’s So Heavy)") ,
    new Tema(3.05, "Here Comes the Sun") ,
     new Tema(2.34, "Because") ,
     new Tema(3.03, "You Never Give Me Your Money") ,
    new Tema(1.11, "Sun King") ,
     new Tema(1.50, "Mean Mr. Mustard") ,
     new Tema(2.02, "Polythene Pam") ,
     new Tema(3.03, "She Came in Through the Bathroom Window") ,
    new Tema(1.57, "Golden Slumbers") ,
     new Tema(2.09, "Carry That Weight") ,
     new Tema(1.59, "The End") }
);
disco.Add(5, disco5);




Disco disco6 = new Disco(6,
    "A Night at the Opera", 
    "Queen", 
    "Roy Thomas Baker", 
    "Rock", 
    "Queen.png", 
    new List<Tema>{ new Tema(6.07, "Bohemian Rhapsody") ,
     new Tema(4.00, "You're My Best Friend") ,
     new Tema(3.42, "Love of My Life") ,
     new Tema(5.49, "Death on Two Legs (Dedicated to...)" ) ,
     new Tema(2.47, "I'm in Love with My Car") }
);
disco.Add(6, disco6);


Disco disco7 = new Disco(7,
    "Lush", 
    "Mitski", 
    "Mitski", 
    "Indie Pop", 
    "Lush.png", 
    new List<Tema>{ new Tema(3.04, "Liquid Smooth") ,
     new Tema(3.09, "First Love / Late Spring") ,
     new Tema(3.20, "Bag of Bones") ,
     new Tema(3.00, "Brand New City") }
);
disco.Add(7, disco7);



Disco disco8 = new Disco(8,
    "Blind", 
    "The Sundays", 
    "Harvey Williams", 
    "Alternative Rock", 
    "Blind.png", 
    new List<Tema>{ new Tema(4.23, "Here's Where the Story Ends") ,
     new Tema(3.44, "Can't Be Sure") ,
     new Tema(3.27, "I Kicked a Boy") ,
    new Tema(4.02, "Blind") ,
     new Tema(3.22, "My Finest Hour") }
);
disco.Add(8, disco8);




Disco disco9 = new Disco(9,
    "Toys in the Attic", 
    "Aerosmith", 
    "Jack Douglas", 
    "Hard Rock", 
    "Aerosmith.png", 
    new List<Tema>{ new Tema(3.06, "Toys in the Attic") ,
     new Tema(3.37, "Sweet Emotion") ,
     new Tema(4.32, "No More No More") ,
     new Tema(4.24, "Adam's Apple") ,
     new Tema(4.02, "Walk This Way") }
);
disco.Add(9, disco9);


Disco disco10 = new Disco(10,
    "Diamond Life", 
    "Sade", 
    "Sade Adu", 
    "Soul", 
    "Sade.png", 
    new List<Tema>{ new Tema(4.16, "Smooth Operator") ,
     new Tema(3.34, "Your Love Is King") ,
     new Tema(3.53, "Hang on to Your Love") ,
     new Tema(4.20, "When Am I Going to Make a Living") ,
     new Tema(4.18, "Diamond Life") }
);
disco.Add(10, disco10);



}
}