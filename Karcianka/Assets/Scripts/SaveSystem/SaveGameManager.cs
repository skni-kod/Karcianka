using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveGameManager : MonoBehaviour
{
    private static SaveGameManager instance;
    private BinaryFormatter formatter;
    private string savesPath;
    
    public static SaveGameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<SaveGameManager>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }

    private void Awake()
    {
        formatter = new BinaryFormatter();
        savesPath = Application.dataPath + "/gamesaves/";
        if (!Directory.Exists(savesPath))
        {
            Directory.CreateDirectory(savesPath);
        }
    }
    public void createGameSave(string saveName)
    {
        GameData data = new GameData();
        string filePath = savesPath + saveName + ".save";
        try
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, data);
                stream.Close();
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
    public void saveGame(string saveName,GameData data)
    {
        formatter = new BinaryFormatter();
        string filePath = savesPath + saveName + ".save";
        try
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, data);
                stream.Close();
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
    public GameData loadGame(string saveName)
    {
        formatter = new BinaryFormatter();
        string filePath = savesPath + saveName + ".save";

        try
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                GameData data = (GameData)formatter.Deserialize(stream);
                stream.Close();
                return data;
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
            return null;
        }
    }
    public void deleteGameSave(string saveName)
    {
        string filePath = savesPath + saveName + ".save";
        try
        {
            File.Delete(filePath);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    } 
    public bool savesExist()
    {
        return Directory.Exists(savesPath) && Directory.GetFiles(savesPath, "*.save").Length > 0;
    }
}
