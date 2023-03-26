using System;

[System.Serializable]
public class GameData
{
    public DateTime dateTime;
    public string nickname;
    public int money;
    public int exp;
    public int lvl;
    public GameData(string nickname)
    {
        this.nickname = nickname;
        dateTime = DateTime.Now;
        money = 100;
        exp = 0;
        lvl = 0;
    }
}
