using System;
using System.Threading;

namespace Prog2
{
    class Program
    {
       

        static void Main(string[] args)
        {
           

           int SkillPoints = 10;


           int Strength = 1;

           int BonusDamage = 3;

           int BaseDamage = 8; 

           int Dmg;      

           Dmg = BaseDamage + BonusDamage;
           
           int Agility = 1;

           int BonusSpeed = 3;

           int BaseSpeed = 27;

           int Speed;

           Speed = BaseSpeed + BonusSpeed;

           int Defence = 1;

           int BonusBlockChance = 2;

           int BaseBlockChance = 2;

           int Block;

           Block = BaseBlockChance + BonusBlockChance;

           int Vitality = 1;

           int BonusHealth = 4;

           int BaseHealth = 15;

           int Health;

           Health = BonusHealth + BaseHealth;

           int Stamina = 1;

           int BonusBreath = 3;

           int BaseBreath =15;

           int Breath;

           Breath = BonusBreath + BaseBreath;

           int Timer = 5;



           Console.WriteLine(" Welcome To Hobo Street Fight");

           Thread.Sleep(1000);

           Console.Write(" Choose Your Hobo's Name: ");

           string H1 = Console.ReadLine(); 

           Console.Clear();

           Console.WriteLine(" Welcome");

           Thread.Sleep(1000);

           Console.WriteLine(" Mr." + H1 + " Hobo");
           
           Thread.Sleep(2600);

           Console.Clear();

           Console.WriteLine(" Improve You'r stats");

           Thread.Sleep(2000);

           Console.WriteLine("By typing in the number of the trait you want to improve.");

           Console.WriteLine("Press enter to continue");

           Console.Clear();
           



           while(SkillPoints > 0)
           {

               Console.WriteLine("Stats - Mr. " + H1 + " Hobo   Skill Points---" + SkillPoints + " - You improve your stats by typing in the number o the trait you want.");
               Console.WriteLine();
               Console.WriteLine("1: Strength: " + Strength + " - " + "Damage: " + Dmg);
               Console.WriteLine("2: Agility:  " + Agility + " - " + "Speed: " + Speed);
               Console.WriteLine("3: Defence:  " + Defence + " - " + "BlockChance: " + Block);
               Console.WriteLine("4: Vitality: " + Vitality + " - " + "Health: " + Health);
               Console.WriteLine("5: Stamina:  " + Stamina + " - " + "Breath: " + Breath);
               Console.WriteLine();
               Console.WriteLine("Increase:+1");
               Console.WriteLine("Deacrease:-1");
               Console.Write("Improve Trait: ");
               


               string uppgrade = Console.ReadLine();



           if (uppgrade == "1")
           {
               Strength++;
               SkillPoints--;  

               Dmg = BaseDamage + (BonusDamage * Strength);           
            }
            if (uppgrade == "2")
           {
               Agility++;
               SkillPoints--;  

               Speed = BaseSpeed + (BonusSpeed * Agility);           
            }
            if (uppgrade == "3")
           {
               Defence++;
               SkillPoints--;  

               Block = BaseBlockChance + (BonusBlockChance * Defence);           
            }
            if (uppgrade == "4")
           {
               Vitality++;
               SkillPoints--;  

               Health = BaseHealth + (BonusHealth * Vitality);          
            }
            if (uppgrade == "5")
           {
               Stamina++;
               SkillPoints--;  

               Breath = BaseBreath + (BonusBreath * Stamina);           
            }
            if (uppgrade == "-1" && Strength > 1)
           {
               Strength--;
               SkillPoints++;  

               Dmg = Dmg - BonusDamage;           
            }
            if (uppgrade == "-2" && Agility > 1)
           {
               Agility--;
               SkillPoints++;  

               Speed = BaseSpeed - (BonusSpeed * Agility);           
            }
            if (uppgrade == "-3" && Defence > 1)
           {
               Defence++;
               SkillPoints--;  

               Block = BaseBlockChance + (BonusBlockChance * Defence);           
            }
            if (uppgrade == "-4" && Vitality > 1)
           {
               Vitality++;
               SkillPoints--;  

               Health = BaseHealth + (BonusHealth * Vitality);          
            }
            if (uppgrade == "-5" && Stamina > 1)
           {
               Stamina++;
               SkillPoints--;  

               Breath = BaseBreath + (BonusBreath * Stamina);           
            }        

            if(uppgrade != "1" && uppgrade != "2" && uppgrade != "3" && uppgrade != "4" && uppgrade != "5" && uppgrade != "-1" && uppgrade != "-2" && uppgrade != "-3" && uppgrade != "-4" && uppgrade != "-5" && Strength == -1)
            {
                Console.Clear();

                Console.WriteLine("Stats - Mr. " + H1 + " Hobo   Skill Points---" + SkillPoints);
                Console.WriteLine();
                Console.WriteLine("1: Strength: " + Strength + " - " + "Damage: " + Dmg);
                Console.WriteLine("2: Agility:  " + Agility + " - " + "Speed: " + Speed);
                Console.WriteLine("3: Defence:  " + Defence + " - " + "BlockChance: " + Block);
                Console.WriteLine("4: Vitality: " + Vitality + " - " + "Health: " + Health);
                Console.WriteLine("5: Stamina:  " + Stamina + " - " + "Breath: " + Breath);
                Console.WriteLine();

                Console.WriteLine("Incorrect Input");
                Thread.Sleep(1500);
                Console.WriteLine("   Try Again   ");
                Thread.Sleep(2000);


            }

            Console.Clear();
           }



               Console.WriteLine("Stats - Sir " + H1 + " Hobo   Skill Points---" + SkillPoints);
               Console.WriteLine();
               Console.WriteLine("1: Strength: " + Strength + " - " + "Damage: " + Dmg);
               Console.WriteLine("2: Agility:  " + Agility + " - " + "Speed: " + Speed);
               Console.WriteLine("3: Defence:  " + Defence + " - " + "BlockChance: " + Block);
               Console.WriteLine("4: Vitality: " + Vitality + " - " + "Health: " + Health);
               Console.WriteLine("5: Stamina:  " + Stamina + " - " + "Breath: " + Breath);
               Console.WriteLine();
               Console.WriteLine("No More Skill Points. Continue to the street ----->");

               Thread.Sleep(2800);

               Console.Clear();

               Console.WriteLine("                         ______________________                                                               ");
               Console.WriteLine("                        |                      |                                           ");
               Console.WriteLine("                        |  Shops        Arena  |                                            ");
               Console.WriteLine("                        |  <---          --->  |                                            ");
               Console.WriteLine("                        |______________________|                                           ");
               Console.WriteLine("                                   | |                                                     ");
               Console.WriteLine("                                   | |                                                     ");
               Console.WriteLine("                                   | |                                                     ");
               Console.WriteLine("                                   | |                                                     ");
               Console.WriteLine("                                   | |                                                     ");
               Console.WriteLine("                                   | |                                                     ");
               Console.WriteLine("___________________________________|_|_____________________________________________________");
               Console.WriteLine("                                                                                           ");
               Console.WriteLine("                                                                                           ");
               Console.WriteLine("___________________________________________________________________________________________");
               Console.WriteLine("                                                                                           ");
               Console.WriteLine("                                                                                           ");
               Console.WriteLine("                                                                                           ");
               Console.WriteLine("___________________________________________________________________________________________");

               Console.ReadLine();



               Console.WriteLine("                             |                             |                               ");
               Console.WriteLine("                             |_____________________________|                               ");
               Console.WriteLine("                             |           Street            |                               ");
               Console.WriteLine("                             |           Arena -->         |                               ");
               Console.WriteLine("                             |_____________________________|                               ");
               Console.WriteLine("                                                                                           ");
               Console.WriteLine("  ____________________________________________________________________________________     ");
               Console.WriteLine("  |           1              |              2              |            3            |     ");
               Console.WriteLine("  |         Wepons           |            Armor            |         Potions         |     ");
               Console.WriteLine("  |__________________________|_____________________________|_________________________|     ");
               Console.WriteLine("  |    _________             |    _________                |     _________           |     ");
               Console.WriteLine("  |   |         |            |   |         |               |    |         |          |     ");
               Console.WriteLine("  |   |         |   ______   |   |         |    ______     |    |         |  ______  |     ");
               Console.WriteLine("  |   |         |  |      |  |   |         |   |      |    |    |         | |      | |     ");
               Console.WriteLine("  |   |       . |  |      |  |   |       . |   |      |    |    |       . | |      | |     ");
               Console.WriteLine("  |   |         |  |______|  |   |         |   |______|    |    |         | |______| |     ");
               Console.WriteLine("  |   |         |            |   |         |               |    |         |          |     ");
               Console.WriteLine("  |   |         |            |   |         |               |    |         |          |     ");
               Console.WriteLine("___________________________________________________________________________________________");
               


              
              
              Console.WriteLine();
              
              
              
              
              
              
              
              
               Console.WriteLine("BATTLE-BEGINS");
               Thread.Sleep(1000);
               Console.WriteLine("     I-N      ");
               Thread.Sleep(1100);

               Console.Clear(); 


               while(Timer > 0)
               { 
                   Console.WriteLine("BATTLE-BEGINS");
                   Console.WriteLine("     I-N      ");
                   Console.WriteLine("      " + Timer);
                   Thread.Sleep(1000);
                   Timer--;
                   Console.Clear();
               }

               Console.WriteLine("FIGHT!!!");
               


            




            Console.ReadLine();
        }
    }
}
