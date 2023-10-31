using System;
using System.Collections.Generic;
namespace PlayerAnd_Team
{
        
    class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();
            string continueChoice;

            do
            {
                Console.WriteLine("1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players");


                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {

                        case 1:
                            Console.Write("Enter Player ID: ");
                            if (int.TryParse(Console.ReadLine(), out int playerId))
                            {
                                Console.Write("Enter Player Name: ");
                                string playerName = Console.ReadLine();
                                Console.Write("Enter Player Age: ");
                                int playerAge = int.Parse(Console.ReadLine());

                                Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                                oneDayTeam.Add(newPlayer);
                                
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid player ID.");
                            }
                            break;

                        case 2:
                            Console.Write("Enter Player Id to Remove: ");
                            int idToRemove = int.Parse(Console.ReadLine());
                            oneDayTeam.Remove(idToRemove);
                            break;

                        case 3:
                            Console.Write("Enter Player Id to Get: ");
                            int idToGet = int.Parse(Console.ReadLine());
                            Player playerById = oneDayTeam.GetPlayerById(idToGet);
                            if (playerById != null)
                            {
                                Console.WriteLine($"{playerById.PlayerId}\n{playerById.PlayerName} {playerById.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;

                        case 4:
                            Console.Write("Enter Player Name to Get: ");
                            string nameToGet = Console.ReadLine();
                            Player playerByName = oneDayTeam.GetPlayerByName(nameToGet);
                            if (playerByName != null)
                            {
                                Console.WriteLine($"{playerByName.PlayerId}\n{playerByName.PlayerName} {playerByName.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;

                        case 5:
                            List<Player> allPlayers = oneDayTeam.GetAllPlayers();
                            if (allPlayers.Count > 0)
                            {
                                foreach (var player in allPlayers)
                                {
                                    Console.WriteLine($"{player.PlayerName} {player.PlayerAge} {player.PlayerId}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No players in the team.");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadLine();
                }

                Console.Write("Do you want to continue (yes/no)?: ");
                continueChoice = Console.ReadLine().ToLower();
            } while (continueChoice == "yes");
        }
    }
}