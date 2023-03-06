using System;

[System.Serializable]
public class GameData
{
    public DateTime dateTime;
    public GameData()
    {
        dateTime = DateTime.Now;
    }
}
