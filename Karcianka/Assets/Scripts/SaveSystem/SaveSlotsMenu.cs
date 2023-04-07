using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SaveSlotsMenu : Menu
{
    private SaveSlot[] slots;
    private Button[] buttons;

    private void Start()
    {
        Activate();
    }
    private void Awake()
    {
        slots = GetComponentsInChildren<SaveSlot>();
        buttons = GetComponentsInChildren<Button>();
    }

    public void Activate()
    {
        Dictionary<string, GameData> slotsData = SaveGameManager.instance.LoadAllSaves();
        foreach (SaveSlot slot in slots)
        {
            GameData data = null;
            slotsData.TryGetValue(slot.getSaveId(), out data);
            slot.setData(data);
        }
    }
}