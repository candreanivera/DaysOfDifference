//This program prompts the user to input a date and then calculates the number of days between that date and today

//To measure the performance of the program
using System.Diagnostics;
Stopwatch timeMeasure = new Stopwatch();
timeMeasure.Start();

String answer = "";
DateTime today = DateTime.Today;

do {
    //Ask for a date from the user.
    Console.WriteLine("Insert the date you want to calculate. Or Write 'exit' to finish.");
    answer = Console.ReadLine();
    //If the answer is "break", the program finishes
    if(answer == "exit"){
        break;
    }
    //Console.WriteLine($"The date introduced was: {answer}");

    //Formating the date introduced:
    DateTime result;
    if (DateTime.TryParse(answer, out result)){
        Console.WriteLine($"The date of today is: {today}");

        if (today == result) {
            Console.WriteLine($"The day is today!");
        } else {
            switch (today > result){
                case true: 
                    TimeSpan difference = today - result;
                    Console.WriteLine($"That date was {difference.Days} days ago");
                    break;
                case false:
                    TimeSpan difference2 = result - today;
                    Console.WriteLine($"That date will be in {difference2.Days} days");
                    break;
                    Console.WriteLine($"The day is today!");
                    break;
            }
        }

    }
    else {
        Console.WriteLine($"Don't valid date '{answer}', please try again");
    }

    //Calculating the difference between the day introduced and the day of today:

}while (answer != "exit");

timeMeasure.Stop();
Console.WriteLine($"Time elapsed: {timeMeasure.Elapsed.TotalMilliseconds/1000} seconds");

