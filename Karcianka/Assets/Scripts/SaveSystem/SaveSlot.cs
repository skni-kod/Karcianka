using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private string saveId = "";
    [SerializeField] private StartPanelController startPanelController;
    [SerializeField] private GameObject noData;
    [SerializeField] private GameObject dataHas;
    [SerializeField] private TextMeshProUGUI nickname;
    [SerializeField] private TextMeshProUGUI date;
    [SerializeField] private Button deleteBtn;

    private Loader loader;
    private bool firstClick;
    private bool hasData;

    private void Start()
    {
        loader = GameObject.Find("Loader").GetComponent<Loader>();
        firstClick = true;
    }
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
        SaveGameManager.instance.setSelectedSlotId(saveId);
        deleteBtn.interactable = false;
        if (!hasData)
        {
            startPanelController.changePanelActiveUp();
        }
        else if (hasData)
        {
            SaveGameManager.instance.LoadGame();
            loader.loadScene(1);
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
