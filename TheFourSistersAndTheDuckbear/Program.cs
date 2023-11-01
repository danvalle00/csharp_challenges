Console.WriteLine("How much eggs was gathered today? ");
int gatheredEggs, sistersEggs, duckbearReminder;
gatheredEggs = Convert.ToInt32(Console.ReadLine());
sistersEggs = gatheredEggs / 4;
duckbearReminder = gatheredEggs % 4;

Console.WriteLine("Each Sister will receive " + sistersEggs + " eggs and the Duckbear will receive " + duckbearReminder + " eggs");
