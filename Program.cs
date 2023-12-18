// Print the message "Plan Your Heist!".
// Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
// Prompt the user to enter a team member's name and save that name.
// Prompt the user to enter a team member's skill level and save that skill level with the name.
// Prompt the user to enter a team member's courage factor and save that courage factor with the name.
// Display the team member's information.
// Create a way to store several team members.
// Collect several team members' information.
// Stop collecting team members when a blank name is entered.
// Display a message containing the number of members of the team.
// Display each team member's information.
// Stop displaying each team member's information.
// Store a value for the bank's difficulty level. Set this value to 100.
// Sum the skill levels of the team. Save that number.
// Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
// Create a random number between -10 and 10 for the heist's luck value.
// Add this number to the bank's difficulty level.
// Before displaying the success or failure message, display a report that shows.
// The team's combined skill level
// The bank's difficulty level
// Run the scenario multiple times.
// After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
// At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// At the end of the program, display a report showing the number of successful runs and the number of failed runs.

namespace Heist 
{
    class Program 
    {
        static void Main (string[] args)
        {
            List<CrewMember> HeistTeam = new List<CrewMember>();
            // int bankDifficultyLevel = 100;
          
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter the difficulty level of the bank you want to rob");
            string bank = Console.ReadLine();
            int bankLevel = int.Parse(bank);
            


while(true)
{
    
           
            int totalSkillLevel = HeistTeam.Sum(x => x.Level);
            Console.WriteLine("Enter crew member's name:");
            string name = Console.ReadLine();
            if(name == "")
            {
                int wins = 0;
                int losses = 0;
                
                Console.WriteLine("How many times would you like to rob a bank today?");
                string trialRuns = Console.ReadLine();
                int trials = int.Parse(trialRuns);
                for (int i = 0; i < trials; i++)
                {
            int luckValue = new Random().Next(-10, 10);
            int totalDifficulty = bankLevel + luckValue;
            if(totalSkillLevel >= totalDifficulty){
                // Console.WriteLine($"Difficulty Level: {totalDifficulty} Total Skill Level: {totalSkillLevel}");
                // Console.WriteLine("SUCCESS");
                wins++;
            }
            else 
            {
                // Console.WriteLine($"Difficulty Level: {totalDifficulty} Total Skill Level: {totalSkillLevel}");
                // Console.WriteLine("FAIL");
                losses++;
            }
                }
                Console.WriteLine($"Robbed banks = {wins} Still Poor = {losses}");
                break;
            }
            Console.WriteLine("Enter crew member's level:");
            string level = Console.ReadLine();
            Console.WriteLine("Enter crew member's courage factor:");
            string courage = Console.ReadLine();

            CrewMember newMember = new CrewMember() {
                Name = name,
                Level = int.Parse(level),
                CourageFactor = double.Parse(courage)
            };

            HeistTeam.Add(newMember);
            Console.WriteLine($"You have {HeistTeam.Count} team member(s) on your heist crew");

     


           
}


        }
    }
}