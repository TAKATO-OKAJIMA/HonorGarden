using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Suit : int
{
    NONE = 0,
    HEARTS,
    DIAMONDS,
    SPEADS,
    CLUBS
};

static class SuitString
{
    private static string[] suits = { "None", "Hearts,", "Diamonds", "Speads", "Clubs" };

    public static string String(this Suit suit)
    {
        return suits[(int)suit];
    }
}