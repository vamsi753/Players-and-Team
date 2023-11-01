using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        ITeam oneDayTeam = new OneDayTeam();

        while (true)
        {
            Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Player ID:");
            int playerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter Player Age:");
            int playerAge = int.Parse(Console.ReadLine());

            Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
            oneDayTeam.Add(newPlayer);
            break;
                case 2:
                Console.WriteLine("Enter Player ID to remove:");
                int removePlayerId = int.Parse(Console.ReadLine());
                oneDayTeam.Remove(removePlayerId);
                break;
            case 3:
                Console.WriteLine("Enter Player ID to get details:");
                int getPlayerId = int.Parse(Console.ReadLine());
                Player playerById = oneDayTeam.GetPlayerById(getPlayerId);
                if (playerById != null)
                {
                    Console.WriteLine($"Player ID: {playerById.PlayerId}, Name: {playerById.PlayerName}, Age: {playerById.PlayerAge}");
                }
                else
                {
                    Console.WriteLine("Player not found.");
                }
                break;
            case 4:
                Console.WriteLine("Enter Player Name to get details:");
                string getPlayerName = Console.ReadLine();
                Player playerByName = oneDayTeam.GetPlayerByName(getPlayerName);
                if (playerByName != null)
                {
                    Console.WriteLine($"Player ID: {playerByName.PlayerId}, Name: {playerByName.PlayerName}, Age: {playerByName.PlayerAge}");
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
                    Console.WriteLine("All players in the team:");
                    foreach (var player in allPlayers)
                    {
                        Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                    }
                }
                else
                {
                    Console.WriteLine("No players in the team.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
            }
        }
    }
}
