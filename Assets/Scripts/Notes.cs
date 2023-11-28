using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour
{
    private TMP_InputField Note1Field;
    private Toggle Note1toggle;

    private float delaySeconds = 3;

    private bool Note1Done = false;

    private void Awake()
    {
        Note1Field = GetComponentInChildren<TMP_InputField>();
        Note1toggle = GetComponentInChildren<Toggle>();

        Note1toggle.isOn = false;
        Note1Field.characterLimit = 200;
        Note1toggle.interactable = false;  
    }

    private void Update()
    {
        if (Note1Field.text != "" && Note1Done == false) Note1toggle.interactable = true;
        else
        {
            Note1toggle.interactable = false;
        }
    }

    public void Done()
    {
        Note1Done = true;

        if (Note1Done == true)
        {
            textFade();
            Invoke("textReset", delaySeconds);
        }
    }

    void textFade()
    {
        Note1toggle.interactable = false;
        Note1Field.readOnly = true;
    }

    void textReset()
    {
        Note1Field.text = "";

        Note1toggle.isOn = false;
        Note1Field.readOnly = false;
        Note1toggle.interactable = false;
        Note1Done = false;
    }
}
