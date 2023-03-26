using System.Linq;
using TMPro;
using UnityEngine;



public class StartPanelController : MonoBehaviour
{
    private GameManager gameManager;
    private SaveGameManager saveGameManager;
    private GameObject[] panels;
    private short activePanel;
    [SerializeField] private GameObject savesArea;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;
        saveGameManager = gameManager.GetSaveGameManager();
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
        panels[activePanel].SetActive(false);
        panels[activePanel - 1].SetActive(true);
        activePanel--;
    }

    public void onSingleplayerButtonClick()
    {
        changePanelActiveUp();
    }

    public void onCreateSaveGameButtonClicked()
    {

    }
}
