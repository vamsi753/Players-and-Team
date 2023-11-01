using System;
using System.Collections.Generic;

public class OneDayTeam : ITeam
{
    public static List<Player> oneDayTeam = new List<Player>();

    public OneDayTeam()
    {
        oneDayTeam.Capacity = 11;
    }

    public void Add(Player player)
    {
        if (oneDayTeam.Count < oneDayTeam.Capacity)
        {
            oneDayTeam.Add(player);
            Console.WriteLine("Player added to the team.");
        }
        else
        {
            Console.WriteLine("The team is already full (11 players).");
        }
    }

    public void Remove(int playerId)
    {
        Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
        if (playerToRemove != null)
        {
            oneDayTeam.Remove(playerToRemove);
            Console.WriteLine("Player removed from the team.");
        }
        else
        {
            Console.WriteLine("Player not found in the team.");
        }
    }

    public Player GetPlayerById(int playerId)
    {
        return oneDayTeam.Find(p => p.PlayerId == playerId);
    }

    public Player GetPlayerByName(string playerName)
    {
        return oneDayTeam.Find(p => p.PlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase));
    }

    public List<Player> GetAllPlayers()
    {
        return oneDayTeam;
    }
}
