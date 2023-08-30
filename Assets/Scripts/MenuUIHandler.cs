using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField chikenNameText;
    public TMP_InputField dogNameText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        SaveName();
        SceneManager.LoadScene(1);
    }

    public void SaveName()
    {
        Storage.Instance.chickenName = chikenNameText.text;
        Storage.Instance.dogName = dogNameText.text;
    }
}
