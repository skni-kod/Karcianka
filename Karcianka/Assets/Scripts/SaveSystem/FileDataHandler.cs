using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class FileDataHandler
{
    private string savesDirectory;

    public FileDataHandler()
    {
        savesDirectory = Application.persistentDataPath + "/gamesaves/";
        if (!Directory.Exists(savesDirectory))
        {
            Directory.CreateDirectory(savesDirectory);
        }
    }
    public void Save(GameData data, string saveId)
    {
        try
        {
            string fullPath = Path.Combine(savesDirectory, saveId) + ".save";
            string dataToStore = JsonUtility.ToJson(data, true);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
    public GameData Load(string saveId)
    {
        string fullPath = Path.Combine(savesDirectory, saveId) + ".save";
        GameData loadedData = null;
        if (File.Exists(fullPath))
        {
            try
            {
                string dataToLoad = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }
                loadedData = JsonUtility.FromJson<GameData>(dataToLoad);
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }
        return loadedData;
    }
    public void Delete(string saveId)
    {
        string fullPath = Path.Combine(savesDirectory, saveId) + ".save";
        try
        {
            File.Delete(fullPath);
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
    public Dictionary<string, GameData> LoadAllSaves()
    {
        Dictionary<string, GameData> loadedData = new Dictionary<string, GameData>();
        string[] saveFiles = Directory.GetFiles(savesDirectory, "*.save");
        foreach (string savePath in saveFiles)
        {
            if (File.Exists(savePath))
            {
                string saveId = savePath.Substring(savePath.Length - 6, 1);
                loadedData.Add(saveId, Load(saveId));
            }
        }
        return loadedData;
    }
}
