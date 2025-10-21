using System;
using System.Collections.Generic;
using Unity.VisualScripting;

public enum Condition
{ 
    START,
    PAUSE,
    FINISH
}

public class EventManager
{
    public static void Subscribe(Condition condition, Action action)
    {
        if (dictionary.ContainsKey(condition))
        {
            dictionary[condition] += action;
        }
        else
        {
            dictionary[condition] = action;
        }
    }

    public static void Unsubscribe(Condition condition, Action action)
    {
        if (dictionary.ContainsKey(condition))
        {
            dictionary[condition] -= action;
        }
    }

    public static void Pubish(Condition condition)
    {
        if (dictionary.TryGetValue(condition, out var action))
        {

        }
    }

    public static Dictionary<Condition, Action> dictionary = new();
}
