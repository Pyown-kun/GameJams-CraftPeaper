using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScripts : MonoBehaviour
{
    public Text CodeUI;

    public string Code;

    private void Update()
    {
        CodeUI.text = Code;
    }

    public void CopyCode()
    {
        TextEditor textEditor = new TextEditor();

        textEditor.text = Code;
        textEditor.SelectAll();
        textEditor.Copy();
    }
}
