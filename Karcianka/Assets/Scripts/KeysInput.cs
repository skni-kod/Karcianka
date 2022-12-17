using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysInput : MonoBehaviour
{
    public GameObject menu;
    private bool isMenuActive = false;
    void Start()
    {
        menu.SetActive(false);
    }

    void Update()
    {
        bool down = Input.GetButtonDown("Cancel");
        if (down && !isMenuActive)
        {
            menu.SetActive(true);
            isMenuActive = true;
        }else if (down && isMenuActive)
        {
            menu.SetActive(false);
            isMenuActive = false;
        }
    }
}
