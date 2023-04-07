using System.Linq;
using TMPro;
using UnityEngine;



public class StartPanelController : Menu
{
    private GameManager gameManager;
    private SaveGameManager saveGameManager;
    private GameObject[] panels;
    private short activePanel;
    private Loader loader;
    [SerializeField] private GameObject savesArea;
    [SerializeField] private TMP_InputField nicknameInput;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;
        saveGameManager = gameManager.GetSaveGameManager();
        loader = GameObject.Find("Loader").GetComponent<Loader>();
        panels = transform.GetComponentsInChildren<Transform>(includeInactive: true)
            .Where(t => t.parent == transform)
            .Select(t => t.gameObject).ToArray();

        panels[0].SetActive(true);
        activePanel = 0;
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
            changePanelActiveUp();
        }  
    }
    // Change active panel
    public void changePanelActiveUp()
    {
        panels[activePanel].SetActive(false);
        panels[activePanel + 1].SetActive(true);
        activePanel++;
    }
    public void changePanelActiveDown()
    {
        if (activePanel > 0)
        {
            panels[activePanel].SetActive(false);
            panels[activePanel - 1].SetActive(true);
            activePanel--;
        }
    }

    public void onSingleplayerButtonClick()
    {
        changePanelActiveUp();
    }

    public void onCreateSaveGameButtonClicked()
    {
        if (nicknameInput.text.Length > 0)
        {
            saveGameManager.NewGame(nicknameInput.text);
            loader.loadScene(1);
        }
    }
}
