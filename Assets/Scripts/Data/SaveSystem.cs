using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using System.Runtime.Serialization;

public static class SaveSystem
{
    public static string directory = "SaveData";
    public static string fileName = "MySave.txt";

    public static void Save(Data data)
    {
        if (!DirectoryExist())
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/" + directory);
        }

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(GetFullPath());
        bf.Serialize(file, data);
        file.Close();
    }

    public static Data Load()
    {
        if(SaveExist())
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(GetFullPath(), FileMode.Open);
                Data data = (Data)bf.Deserialize(file);
                file.Close();

                return data;
            }
            catch (SerializationException)
            {
                Debug.Log("Failed to load file");
            }
        }

        return null;
    }

   private static bool SaveExist()
    {
        return File.Exists(GetFullPath());
    }

    private static bool DirectoryExist()
    {
        return Directory.Exists(Application.persistentDataPath + "/" + directory);
    }

    private static string GetFullPath()
    {
        return Application.persistentDataPath + "/" + directory + "/" + fileName;
    }
}
