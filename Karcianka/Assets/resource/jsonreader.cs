using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonreader : MonoBehaviour
{
    public TextAsset textJSON;
    [System.Serializable]

    public class Card
    {
        public string name;
    }

    [System.Serializable]
    public class CardList
    {
        public Card[] card;
    }
    public CardList myCardList = new CardList();
    // Start is called before the first frame update
    void Start()
    {
        myCardList = JsonUtility.FromJson<CardList>(textJSON.text);

        for (int i=0; i<myCardList.card.Length; i++)
        {
            Debug.Log(myCardList.card[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
