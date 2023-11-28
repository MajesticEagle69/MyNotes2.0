using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToDoData : MonoBehaviour
{
    public Data data = new Data();

    [SerializeField] public TMP_InputField note1;
    [SerializeField] public TMP_InputField note2;
    [SerializeField] public TMP_InputField note3;
    [SerializeField] public TMP_InputField note4;
    [SerializeField] public TMP_InputField note5;
    [SerializeField] public TMP_InputField note6;
    [SerializeField] public TMP_InputField note7;

    public void changeNote()
    {
        data.note1Data = note1.text;
        data.note2Data = note2.text;
        data.note3Data = note3.text;
        data.note4Data = note4.text;
        data.note5Data = note5.text;
        data.note6Data = note6.text;
        data.note7Data = note7.text;
    }

    public void LoadData()
    {
        note1.text = data.note1Data;
        note2.text = data.note2Data;
        note3.text = data.note3Data;
        note4.text = data.note4Data;
        note5.text = data.note5Data;
        note6.text = data.note6Data;
        note7.text = data.note7Data;
    }
}
