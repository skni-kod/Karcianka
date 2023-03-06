using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private SaveGameManager saveGameManager;
    private GameData gameData;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        saveGameManager = SaveGameManager.Instance;
    }
    private void Start()
    {
        saveGameManager = SaveGameManager.Instance;
    }
    public SaveGameManager GetSaveGameManager()
    {
        return saveGameManager;
    }
}
