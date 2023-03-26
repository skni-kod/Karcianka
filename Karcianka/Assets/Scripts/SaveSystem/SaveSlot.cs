using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private string saveId = "";
    [SerializeField] private StartPanelController startPanelController;
    [SerializeField] private GameObject noData;
    [SerializeField] private GameObject dataHas;
    [SerializeField] private TextMeshProUGUI nickname;
    [SerializeField] private TextMeshProUGUI date;
    private bool hasData;
    public void setData(GameData data)
    {
        if (data == null)
        {
            hasData = false;
            noData.SetActive(true);
            dataHas.SetActive(false);
        }
        else
        {
            hasData = true;
            noData.SetActive(false);
            dataHas.SetActive(true);
            nickname.text = data.nickname;
        }
    }
    public void onSlotClicked()
    {
        if (!hasData)
        {

        }
        else if (hasData)
        {
            
        }
    }
    public string getSaveId()
    {
        return saveId;
    }
    public bool hasSlotData()
    {
        return hasData;
    }
}
