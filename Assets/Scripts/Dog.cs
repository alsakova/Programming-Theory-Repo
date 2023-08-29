using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dog : Animal
{
    public Dog(TMP_Text text) : base(text)
    {
    }

    override public void IMHere()
    {
        ShowAction("Happy!");
    }

    override public void Voice()
    {
        ShowAction("Woof! Woof! Woof!");
    }

    override public void FoodReady()
    {
        ShowAction("Happy!!!");
    }

    override public void NapTime()
    {
        ShowAction("Zzzzzz...");
    }

}
