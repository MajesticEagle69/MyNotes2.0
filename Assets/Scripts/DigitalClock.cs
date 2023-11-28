using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class DigitalClock : MonoBehaviour
{
    public TextMeshProUGUI Time;
    public TextMeshProUGUI Date;

    private void Update()
    {
        string time = System.DateTime.Now.ToLocalTime().ToString("HH:mm:ss");
        Time.text = time;

        string date = System.DateTime.Now.ToLocalTime().ToString("dd-MM-yyyy");
        Date.text = date;
    }
}

