using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public ToDoData toDoData;

    private void Awake()
    {
        LoadData();
    }

    public void SaveData()
    {
        SaveSystem.Save(toDoData.data);
    }

    public void LoadData()
    {
        toDoData.data = SaveSystem.Load();

        toDoData.LoadData();
    }

    
}
