﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardInfoShow : MonoBehaviour, IPointerClickHandler
{
    public DuelCard duelcard;
    public Image cardImage;
    public Text cardName;
    public Text cardAtt;
    public Text cardDes;
    public Transform cardButtonLayout;
    private int buttonIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCardInfo(DuelCard card, Sprite sprite)
    {
        duelcard = card;
        cardImage.sprite = sprite;
        cardName.text = duelcard.name + " " + duelcard.id + " " + duelcard.series;
        cardAtt.text = duelcard.type;
        if (duelcard.type.Contains(CardType.monster))
            cardAtt.text += " " + duelcard.race + " " + duelcard.attribute + " 星" + duelcard.level + " " + duelcard.atk + "/" + duelcard.def;
        cardDes.text = duelcard.describe;
    }

    public void SetCardButton(string text)
    {
        GameObject buttonObject = cardButtonLayout.GetChild(buttonIndex).gameObject;
        buttonObject.GetComponentInChildren<Text>().text = text;
        buttonObject.SetActive(true);
        buttonIndex++;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        /*
#if UNITY_ANDROID || UNITY_IOS
        if (IsPointerOverGameObject(Input.GetTouch(0).position))
#else
        if (IsPointerOverGameObject(Input.mousePosition))
#endif
        */
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
            HideCardInfo();
    }

    private bool IsPointerOverGameObject(Vector2 mousePosition)
    {
        //创建一个点击事件
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = mousePosition;
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        //向点击位置发射一条射线，检测是否点击UI
        EventSystem.current.RaycastAll(eventData, raycastResults);
        if (raycastResults.Count > 0)
        { // 只有当点击到的第一个ui为CardInfoBackground时，才隐藏ui
            if (raycastResults[0].gameObject == gameObject)
                return true;
        }
        return false;
    }

    public void HideCardInfo()
    {
        foreach (Transform cardButton in cardButtonLayout)
        {
            cardButton.gameObject.SetActive(false);
        }
        buttonIndex = 0;
        gameObject.SetActive(false);
    }
}