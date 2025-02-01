using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passwords : MonoBehaviour
{
    public PasswordTexts PasswordTexts;

    public void One()
    {
        PasswordTexts.AddNUmber("1");
    }
    
    public void Two()
    {
        PasswordTexts.AddNUmber("2");

    }

    public void Three()
    {
        PasswordTexts.AddNUmber("3");

    }

    public void Four()
    {
        PasswordTexts.AddNUmber("4");

    }

    public void Five()
    {
        PasswordTexts.AddNUmber("5");

    }

    public void Six()
    {
        PasswordTexts.AddNUmber("6");

    }

    public void Seven()
    {
        PasswordTexts.AddNUmber("7");

    }

    public void Eight()
    {
        PasswordTexts.AddNUmber("8");

    }

    public void Nine()
    {
        PasswordTexts.AddNUmber("9");

    }

    public void Zero()
    {
        PasswordTexts.AddNUmber("0");

    }

    public void ResetNumber()
    {
        PasswordTexts.RestartString();
    }
}
