using System;

public class Team
{
    // Member variables
    public string teamName;
    public int noOfPlayers;

    // Constructor
    public Team(string teamName, int noOfPlayers)
    {
        this.teamName = teamName;
        this.noOfPlayers = noOfPlayers;
    }

    // Method to add players
    public void AddPlayer(int count)
    {
        noOfPlayers += count;
    }

    // Method to remove players
    public bool RemovePlayer(int count)
    {
        if (noOfPlayers - count < 0)
        {
            return false;
        }
        noOfPlayers -= count;
        return true;
    }
}

public class Subteam : Team
{
    // Constructor for Subteam, calling base constructor
    public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers) { }

    // Method to change the team name
    public void ChangeTeamName(string name)
    {
        teamName = name;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Team team = new Team("Warriors", 10);
        team.AddPlayer(5);
        Console.WriteLine($"Team Name: {team.teamName}, No of Players: {team.noOfPlayers}");
        
        bool result = team.RemovePlayer(3);
        Console.WriteLine($"After removing 3 players: {team.noOfPlayers}, Success: {result}");

        Subteam subteam = new Subteam("SubWarriors", 7);
        subteam.ChangeTeamName("NewSubWarriors");
        Console.WriteLine($"Subteam Name: {subteam.teamName}, No of Players: {subteam.noOfPlayers}");
    }
}
