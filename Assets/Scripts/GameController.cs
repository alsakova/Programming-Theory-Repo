using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Animal chicken;
    private Animal dog;
    public TMP_Text chickenText;
    public TMP_Text dogText;

    private void Start()
    {
        chicken = new Chicken(chickenText);
        dog = new Dog(dogText);
    }
    public void IAmhereCommand()
    {
        chicken.IMHere();
        dog.IMHere();
    }

    public void VoiceCommand()
    {
        chicken.Voice();
        dog.Voice();
    }

    public void FoodCommand()
    {
        chicken.FoodReady();
        dog.FoodReady();
    }
    public void NapCommand()
    {
        chicken.NapTime(); 
        dog.NapTime();
    }
}
