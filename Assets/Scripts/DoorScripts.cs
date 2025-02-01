using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class DoorScripts : MonoBehaviour
{
    public GameObject PasswordUI;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.F))
        {
            PasswordUI.SetActive(true);
        }
        
        if (Input.GetKey(KeyCode.Tab))
        {
            PasswordUI.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PasswordUI.SetActive(false);
    }
}
