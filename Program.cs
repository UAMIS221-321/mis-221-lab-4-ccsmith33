//main 

int choice = GetUserChoice();
while(choice != 4){
Route(choice);
choice = GetUserChoice();
}


//main end

static void Menu(){
    Console.Clear();
    System.Console.WriteLine("1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");

}

static int GetUserChoice(){
    Menu();
    int choice = 0;
    try{
          choice = int.Parse(Console.ReadLine());

    } catch(Exception e){
        System.Console.WriteLine(e.Message);
        System.Console.WriteLine("Press Any key to continue");
        Console.ReadKey();
        return GetUserChoice();
    }

      
        if(choice != 1&&choice != 2&&choice != 3&&choice != 4){
        System.Console.WriteLine("Invalid Selection, Please Try again\nPress Any key to continue");
        Console.ReadKey();
        GetUserChoice();
    }
    
     return choice;
}

static void Route(int choice){
    Random rnd = new Random();
    int size = rnd.Next(8,13);
    if(choice == 1){
        Plain(size);
    } else if(choice == 2){
        Cheese(size);
    } else{
        Pepperoni(size);
    }

    System.Console.WriteLine("Press Any Key to Continue");
    Console.ReadKey();
}

static void Plain(int size){
    for(int i = size; i > 0 ; i--){
        for(int j = 0; j < i ; j++){
        System.Console.Write("*\t");
    }
    Console.WriteLine("");
    }

}
static void Cheese(int size){

    for(int i = size; i > 0 ; i--){
        for(int j = 0; j < i ; j++){
        if(i == size || j == 0 || j == i-1){
        System.Console.Write("*\t");
        } else{
        System.Console.Write("#\t");
        }   
       
    }
    Console.WriteLine("");
    }
    
}
static void Pepperoni(int size){

    Random rnd = new Random();
    int pep;

    for(int i = size; i > 0 ; i--){
        for(int j = 0; j < i ; j++){
        pep = rnd.Next(i);
        if(i == size || j == 0 || j == i-1){ 
        System.Console.Write("*\t");
        } else if (j == pep){
        System.Console.Write("[]\t");
        }else{
        System.Console.Write("#\t");
        }   
       
    }
    Console.WriteLine("");
    }
    
}