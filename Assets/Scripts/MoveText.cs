using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    public ToDoData toDoData;
    public string currentTag;

    public void Start()
    {
        currentTag = gameObject.tag;
    }

    public void moveText()
    {
        switch (currentTag)
        {
            case "arrow1":
                string note1 = toDoData.note1.text;
                string note2 = toDoData.note2.text;

                toDoData.note1.text = note2;
                toDoData.note2.text = note1;
                toDoData.changeNote();
                break;

            case "arrow2":
                note2 = toDoData.note2.text;
                string note3 = toDoData.note3.text;

                toDoData.note2.text = note3;
                toDoData.note3.text = note2;
                toDoData.changeNote();
                break;

            case "arrow3":
                note3 = toDoData.note3.text;
                string note4 = toDoData.note4.text;

                toDoData.note3.text = note4;
                toDoData.note4.text = note3;
                toDoData.changeNote();
                break;

            case "arrow4":
                note4 = toDoData.note4.text;
                string note5 = toDoData.note5.text;

                toDoData.note4.text = note5;
                toDoData.note5.text = note4;
                toDoData.changeNote();
                break;

            case "arrow5":
                note5 = toDoData.note5.text;
                string note6 = toDoData.note6.text;

                toDoData.note5.text = note6;
                toDoData.note6.text = note5;
                toDoData.changeNote();
                break;

            case "arrow6":
                note6 = toDoData.note6.text;
                string note7 = toDoData.note7.text;

                toDoData.note6.text = note7;
                toDoData.note7.text = note6;
                toDoData.changeNote();
                break;
        }
    }
}
