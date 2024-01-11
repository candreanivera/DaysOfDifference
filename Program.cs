//This program prompts the user to input a date and then calculates the number of days between that date and today

//To measure the performance of the program
using System.Diagnostics;
Stopwatch timeMeasure = new Stopwatch();
timeMeasure.Start();

String answer = " ";
do {
    //Ask for a date from the user.
    Console.WriteLine("Insert the date you want to calculate. Write 'exit' to finish.");
    answer = Console.ReadLine();
    //If the answer is "break", the program finishes
    if(answer == "exit"){
        break;
    }
    Console.WriteLine($"The text introduced was: {answer}");

    //Formating the date introduced:
    DateTime result;
    if (DateTime.TryParse(answer, out result)){
        Console.WriteLine($"The date {answer} was formated to {result}");
        DateTime today = DateTime.Today;
        Console.WriteLine($"The date of today is: {today}");

        if (today == result) {
            Console.WriteLine($"The day is today!");
        } else {
            switch (today > result){
                case true: 
                    TimeSpan difference = today - result;
                    Console.WriteLine($"The difference of the date is: {difference}");
                    break;
                case false:
                    TimeSpan difference2 = result - today;
                    Console.WriteLine($"The difference of the date is: {difference2}");
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

