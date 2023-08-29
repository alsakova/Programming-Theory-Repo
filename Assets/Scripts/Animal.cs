using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Animal 
{
    private TMP_Text text;

    public Animal(TMP_Text text)
    {
        this.text = text;
    }

    virtual public void IMHere()
    {
        Console.WriteLine("Woof");
    }

    virtual public void Voice() 
    { 

    }

    virtual public void FoodReady() 
    {

    }

    virtual public void NapTime() 
    {
    
    }

   virtual protected void ShowAction(string action)
    {
        Debug.Log(action);
        text.text = action;
    }
    
}
