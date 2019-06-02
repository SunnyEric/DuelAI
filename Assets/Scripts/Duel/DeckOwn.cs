﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeckOwn : MonoBehaviour, IPointerClickHandler
{
    public Image image;
    public Text decknum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeckUpdate()
    {
        if (Duel.owndeck.Count > 0)
            image.sprite = Duel.spriteManager.getCardSprite(Duel.owndeck[0], false);
        else
            image.sprite = Duel.UIMask;
        decknum.text = Duel.owndeck.Count.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject.Find("HandCardsLayoutOwn").GetComponent<HandCardOwn>().DrawCard();
    }
}
