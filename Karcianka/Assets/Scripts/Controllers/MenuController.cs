using TMPro;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameManager gameManager;
    private Loader loader;
    [SerializeField] TMP_Text username;

    // Start is called before the first frame update
    private void Start()
    {
        setup();
    }
    private void Awake()
    {
        setup();
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    private void setup()
    {
        gameManager = GameManager.Instance;
        loader = GameObject.Find("Loader").GetComponent<Loader>();
        username.text = gameManager.getGameData().nickname;
    }
    public void onPlayButtonClicked()
    {
        loader.loadScene(5);
    }
    public void onDecksButtonClick()
    {
        loader.loadScene(4);
    }
    public void onCardsShopButtonClicked()
    {
        loader.loadScene(2);
    }
    public void onChestsShopButtonClicked()
    {
        loader.loadScene(3);
    }
    public void onOptionsButtonClicked()
    {

    }
    public void onExitButtonClicked()
    {
        Application.Quit();
    }
}
