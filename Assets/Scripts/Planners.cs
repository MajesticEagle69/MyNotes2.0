using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Planners : MonoBehaviour
{
    public TextMeshProUGUI DateDay;
    public TextMeshProUGUI DateMonth;
    public string Date;

    public TextMeshProUGUI TimeHour;
    public TextMeshProUGUI TimeMinute;
    public string Time;

    public string currentTime;
    public string currentDate;

    private void Update()
    {
        Date = DateDay.text + "/" + DateMonth.text;
        Time = TimeHour.text + ":" + TimeMinute.text;

        currentTime = System.DateTime.Now.ToString("H:mm");

        if (currentDate.Equals(Date))
        {
            Debug.Log("Date");
        }

        if (Time == currentTime) 
        {
            Debug.Log("Time");
        }
    }

    private void Awake()
    {
        currentDate = System.DateTime.Now.ToString("dd/MM");
    }
}
