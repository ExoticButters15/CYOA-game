using System;
namespace dle_StockholdSyndrome
{
    public class ChoiceEval
    {
        public static string[] choices = new string[3];

            public static void Evaluations()
            {
                int x = 0;

                //first prompt
                choices[x] = ChoiceMaking.Choice(Items.person[0], Items.person[1], Items.personPrompt);
                x++;

                //first level of eval
                if (choices[0] == Items.person[0])
                {
                    Console.Clear();
                    choices[x] = ChoiceMaking.Choice(Items.officer[0], Items.officer[1], Items.officerPrompt);
                    x++;
                }
                else if (choices[0] == Items.person[1])
                {
                    Console.Clear();
                    choices[x] = ChoiceMaking.Choice(Items.recruiter[0], Items.recruiter[1], Items.recruiterPrompt);
                    x++;
                }

                //second level of eval
                if (choices[1] == Items.officer[0])
                {
                    Console.Clear();
                    choices[x] = ChoiceMaking.Choice(Items.killed[0], Items.killed[1], Items.killedPrompt);
                    x++;
                }
                else if (choices[1] == Items.officer[1])
                {
                    Console.Clear();
                    choices[x] = ChoiceMaking.Choice(Items.facility[0], Items.facility[1], Items.facilityPrompt);
                    x++;
                }
                else if (choices[1] == Items.recruiter[0])
                {
                    Console.Clear();
                    choices[x] = ChoiceMaking.Choice(Items.enlist[0], Items.enlist[1], Items.enlistPrompt);
                    x++;
                }
                else if (choices[1] == Items.recruiter[1])
                {
                    Console.Clear();
                    choices[x] = ChoiceMaking.Choice(Items.leech[0], Items.leech[1], Items.reportPrompt);
                    x++;
                }

                //end of the line
                if (choices[2] == Items.killed[0])
                {
                    Console.Clear();
                    Console.WriteLine(Items.combatFinal);
                }
                else if (choices[2] == Items.killed[1])
                {
                    Console.Clear();
                    Console.WriteLine(Items.drugFinal);
                }
                else if (choices[2] == Items.facility[0])
                {
                    Console.Clear();
                    Console.WriteLine(Items.militaryFinal);
                }
                else if (choices[2] == Items.facility[1])
                {
                    Console.Clear();
                    Console.WriteLine(Items.havocFinal);
                }
                else if (choices[2] == Items.enlist[0])
                {
                    Console.Clear();
                    Console.WriteLine(Items.techFinal);
                }
                else if (choices[2] == Items.enlist[1])
                {
                    Console.Clear();
                    Console.WriteLine(Items.infantryFinal);
                }
                else if (choices[2] == Items.leech[0])
                {
                    Console.Clear();
                    Console.WriteLine(Items.reportFinal);
                }
                else if (choices[2] == Items.leech[1])
                {
                    Console.Clear();
                    Console.WriteLine(Items.leaveFinal);
                }
            }
    }
}
