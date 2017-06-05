using System.Collections;
using System.Collections.Generic;

public class Game
{
    static List<KeyValuePair<Item, int>> package;

    static void Initialize()
    {
        package.Add(new KeyValuePair<Item, int>(new IStone(), 1));
    }
}