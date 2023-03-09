using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartPanelController : MonoBehaviour
{
    private GameManager gameManager;
    private SaveGameManager saveGameManager;
    private GameObject[] panels;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;
        saveGameManager = gameManager.GetSaveGameManager();
        panels = transform.GetComponentsInChildren<Transform>(includeInactive: true)
            .Where(t => t.parent == transform)
            .Select(t => t.gameObject).ToArray();

        panels[0].SetActive(true);
        for (int i = 1; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }

    private void Awake()
    {
        gameManager = GameManager.Instance;
        saveGameManager = gameManager.GetSaveGameManager();
    }

    // Update is called once per frame
    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space) && panels[0].activeSelf)
        {
            changePanelActiveUp(0);
        }  
    }
    // Change active panel
    private void changePanelActiveUp(int index)
    {
        panels[index].SetActive(false);
        panels[index+1].SetActive(true);
    }
    private void changePanelActiveDown(int index)
    {
        panels[index].SetActive(false);
        panels[index - 1].SetActive(true);
    }
    public void onSingleplayerButtonClick()
    {
        changePanelActiveUp(1);
        Button[] buttons = panels[1].GetComponentsInChildren<Button>(includeInactive: true);
        TMP_Text noSavesText = GameObject.Find("NoSavesText").GetComponent<TMP_Text>();
        buttons[1].interactable = false;

        if (!saveGameManager.savesExist()) { 
            noSavesText.gameObject.SetActive(true);
        }
        else
        {
            noSavesText.gameObject.SetActive(false);
            //TODO: Pobranie zapisów gry, wyœwyietlanie jako klikalne komponenty
        }
    }

    public void onCreateButtonClicked()
    {
        changePanelActiveUp(2);
    }
    public void onDeleteButtonClicked()
    {
        //TODO: Dodaæ usuwanie wybranego zapsiu gry
        saveGameManager.deleteGameSave("Test");
    }
    public void onBackButtonClicked()
    {
        changePanelActiveDown(3);
    }
    public void onCreateSaveGameButtonClicked()
    {
        //TODO: stworzenie zapisu gry, pobranie nickname
        TMP_InputField input = panels[3].GetComponentInChildren<TMP_InputField>();
        Loader loader = GameObject.Find("Loader").GetComponent<Loader>();
        saveGameManager.createGameSave(input.text);
        loader.loadScene(1);
    }
}
