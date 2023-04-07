using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanelKeysInputs : MonoBehaviour
{
    [SerializeField] private StartPanelController startPanelController;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            startPanelController.changePanelActiveDown();
        }
    }
}
