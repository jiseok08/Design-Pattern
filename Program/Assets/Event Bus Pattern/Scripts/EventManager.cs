using System;
using System.Collections.Generic;

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
        
    }

    static Dictionary<Condition, Action> dictionary = new();
}
