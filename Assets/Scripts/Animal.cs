using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Animal 
{
    private string m_name;

    // ENCAPSULATION
    public string name
    {
        get { return m_name; }
        set
        {
            if (value.Length > 6)
            {
                Debug.LogError("Name cannot be more than six letters");
            }
            else
            {
                m_name = value;
            }
        }
    }

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

    // ABSTRACTION
    virtual protected void ShowAction(string action)
    {
        Debug.Log(action);
        text.text = action;
    }
    
}
