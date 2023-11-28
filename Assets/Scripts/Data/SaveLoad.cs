using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public ToDoData toDoData;

    public void SaveData()
    {
        SaveSystem.Save(toDoData.data);
    }

    public void LoadData()
    {
        toDoData.data = SaveSystem.Load();

        toDoData.LoadData();
    }

    public void Awake()
    {
        toDoData.data = SaveSystem.Load();

        toDoData.LoadData();
    }

    public void OnApplicationQuit()
    {
        SaveSystem.Save(toDoData.data);
    }
}
