// See https://aka.ms/new-console-template for more information


List<People> PassengerList = new List<People>();

List<string> FlightInfo = new List<string>();


//new people have first an age, then a name, then which seat they are in (string since seats can be 15B)
People Mike = new People(55,"Mike", "Whole Plane");
PassengerList.Add(Mike);

//first value flight number, second number of seats availiable, third and fourth are the captains
FlightInfo.Add("Flight Number 1547A");
FlightInfo.Add ("246");
FlightInfo.Add("Captain John");
FlightInfo.Add("Captain Czhesyat");

Flight Flight1547A = new Flight(PassengerList, FlightInfo);

int seatsAvailiable = Flight1547A.SeatsAvailiable();

System.Console.WriteLine($"Number of seats availiable is {seatsAvailiable}");

public class People
{
    private int age;
    private string name; 
    private string seat;
    public People(int age, string name, string seat)
    {
        this.age = age;
        this.name = name;
        this.seat = seat;

    }
}

 public class Flight
{

private List<string> FlightInfo;
private int count;
private List<People> PassengerList;
 public Flight(List<People> PassengerList, List<string> FlightInfo)
 {
     this.PassengerList = PassengerList;

     count = PassengerList.Count;

     this.FlightInfo = FlightInfo;
 }

public int SeatsAvailiable()
 {

     return int.Parse(FlightInfo[1]) - count;
 }
    
}

