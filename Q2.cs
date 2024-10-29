using System;
using System.Collections.Generic;

public class NotesStore
{
    // Dictionary to store notes based on their state
    private Dictionary<string, List<string>> notes;

    // Constructor
    public NotesStore()
    {
        notes = new Dictionary<string, List<string>>
        {
            { "completed", new List<string>() },
            { "active", new List<string>() },
            { "others", new List<string>() }
        };
    }

    // Method to add a note
    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be empty");
        }

        if (!notes.ContainsKey(state))
        {
            throw new Exception($"Invalid state {state}");
        }

        notes[state].Add(name);
    }

    // Method to get notes by state
    public List<string> GetNotes(string state)
    {
        if (!notes.ContainsKey(state))
        {
            throw new Exception($"Invalid state {state}");
        }

        return new List<string>(notes[state]);
    }
}

public class Solution
{
    static void Main(string[] args)
    {
        NotesStore store = new NotesStore();
        
        // Example usage
        store.AddNote("active", "Do the laundry");
        store.AddNote("completed", "Finish homework");
        
        var activeNotes = store.GetNotes("active");
        Console.WriteLine("Active Notes:");
        foreach (var note in activeNotes)
        {
            Console.WriteLine(note);
        }
    }
}
