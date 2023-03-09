using System;

[System.Serializable]
public class GameData
{
    public DateTime dateTime;
    public string nickname;
    public GameData(string nickname)
    {
        dateTime = DateTime.Now;
        this.nickname = nickname;
    }
}
