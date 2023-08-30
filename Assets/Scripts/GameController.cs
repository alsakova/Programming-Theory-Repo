using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Animal chicken;
    private Animal dog;
    public TMP_Text chickenText;
    public TMP_Text dogText;
    public TMP_Text chickenName;
    public TMP_Text dogName;

    private void Start()
    {
        chicken = new Chicken(chickenText);
        chicken.name = Storage.Instance.chickenName;

        dog = new Dog(dogText);
        dog.name = Storage.Instance.dogName;

        chickenName.text = chicken.name;
        dogName.text = dog.name;
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
