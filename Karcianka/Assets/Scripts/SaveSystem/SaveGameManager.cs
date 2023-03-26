using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SaveGameManager : MonoBehaviour
{
    public static SaveGameManager instance;
    private FileDataHandler fileDataHandler;
    private GameData gameData;
    private List<IGameData> gameDataObjects;
    private string selectedSlotId;

    private void Start()
    {
        fileDataHandler = new FileDataHandler();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            fileDataHandler = new FileDataHandler();
        }
    }
    public static SaveGameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SaveGameManager>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }
    public void setSelectedSlotId(string newSlotId)
    {
        selectedSlotId = newSlotId;
    }
    public void NewGame(string nickname)
    {
        gameData = new GameData(nickname);
        fileDataHandler.Save(gameData, selectedSlotId);
    }
    public void LoadGame()
    {
        gameData = fileDataHandler.Load(selectedSlotId);
        if (gameData != null)
        {

        }
    }
    public void SaveGame()
    {
        fileDataHandler.Save(gameData, selectedSlotId);
    }
    public Dictionary<string,GameData> LoadAllSaves()
    {
        return fileDataHandler.LoadAllSaves();
    }
}
