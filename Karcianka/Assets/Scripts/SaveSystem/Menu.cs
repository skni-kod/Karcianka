using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject firstSelected;

    protected virtual void OnEnable()
    {
        StartCoroutine(SerFirstSelected(firstSelected));
    }
    public IEnumerator SerFirstSelected(GameObject firstSelected)
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(firstSelected);
    }
}
