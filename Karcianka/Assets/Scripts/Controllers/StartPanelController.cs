using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartPanelController : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject noSavesText;
    public GameObject[] panels;
    public Button[] buttons;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;
        panels[0].SetActive(true);
        for (int i = 1; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space) && panels[0].activeSelf)
        {
            panels[0].SetActive(false);
            panels[1].SetActive(true);
        }  
    }

    public void onSingleplayerButtonClick()
    {
        panels[1].SetActive(false);
        panels[2].SetActive(true);
        buttons[1].interactable = false;

        SaveGameManager saveGameManager = gameManager.GetSaveGameManager();
        
        if (!saveGameManager.savesExist())
        {
            noSavesText.SetActive(true);
        }
        else
        {
            noSavesText.SetActive(false);
        }
    }

    public void onCreateButtonClicked()
    {
        panels[3].SetActive(true);
    }
    public void onDeleteButtonClicked()
    {

    }
}
