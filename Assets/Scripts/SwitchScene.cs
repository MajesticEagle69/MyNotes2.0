using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void SceneChangeCalendar()
    {
        SceneManager.LoadScene("CalendarScene");   
    }

    public void SceneChangeToDo()
    {
        SceneManager.LoadScene("ToDoScene");
    }

    public void SceneChangeNote()
    {
        SceneManager.LoadScene("NotesScene");
    }

    public void SceneChangeMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
