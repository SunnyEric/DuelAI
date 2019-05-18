﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpsDeckClick : MonoBehaviour, IPointerClickHandler
{
    public RectTransform handcardlist;
    public GameObject card;
    private float listwidth;
    private float listheight;
    private float cardwidth;

    // Start is called before the first frame update
    void Start()
    {
        listwidth = handcardlist.rect.width;
        listheight = handcardlist.rect.height;
        cardwidth = card.GetComponent<RectTransform>().rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(card, handcardlist);
        ChangeHandCardPosition();
    }

    public void ChangeHandCardPosition()
    {
        Vector3 vector = new Vector3(0, -listheight/2, 0);
        int cardnum = handcardlist.childCount;
        if (cardnum <= 7)
        {
            for (int i = 0; i < cardnum; i++)
            {
                vector.x = (-cardnum + 1 + 2 * i) * ((cardwidth / 2f) + 3);
                handcardlist.GetChild(i).localPosition = vector;
            }
        }
        else
        {
            float dis = (listwidth - cardwidth) / (cardnum - 1);
            vector.x = -(listwidth - cardwidth) / 2f - dis;
            for (int i = 0; i < cardnum; i++)
            {
                vector.x += dis;
                handcardlist.GetChild(i).localPosition = vector;
            }
        }
    }
}