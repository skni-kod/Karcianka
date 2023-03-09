using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameManager gameManager;
    private Loader loader;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;
        loader = GameObject.Find("Loader").GetComponent<Loader>();
    }
    private void Awake()
    {
        gameManager = GameManager.Instance;
        loader = GameObject.Find("Loader").GetComponent<Loader>();
    }
    // Update is called once per frame
    private void Update()
    {
        
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

    }
}
