using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PasswordTexts : MonoBehaviour
{
    public int Scene;
    public string Number;
    public string CorrectNumber;

    public Text NumberText;

    private void Update()
    {
        if (Number.Length > 6)
        {
            Number=Number.Substring(0,6);
        }

        NumberText.text = Number;
    }

    public void AddNUmber(string number)
    {
        Number += number;
    }

    public void RestartString()
    {
        if (Number == CorrectNumber)
        {
            Number = "Done";
            SceneManager.LoadScene(Scene);
        }
        else
        {
            Number = null;
        }
    }
}
