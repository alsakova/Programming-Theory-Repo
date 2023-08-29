using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Chicken : Animal
{
    public Chicken(TMP_Text text) : base(text)
    {
    }


    override public void IMHere()
    {
        ShowAction("Eating...");
    }

    override public void Voice()
    {
        ShowAction("Eating...");
    }

    override public void FoodReady()
    {
        ShowAction("Eating...");
    }

    override public void NapTime()
    {
        ShowAction("Eating...");
    }
}
