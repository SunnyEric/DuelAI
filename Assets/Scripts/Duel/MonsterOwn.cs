﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterOwn : MonoBehaviour
{
    public Transform monsterArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowMonsterCard(DuelCard duelcard)
    {
        Transform montrans = monsterArea.GetChild(duelcard.index);
        Sprite sprite = Duel.spriteManager.GetCardSprite(duelcard.id, false);
        if (duelcard.mean == CardMean.faceupatk)
        {//表侧攻击表示
            montrans.rotation = Quaternion.Euler(90, 0, 0);
        }
        if (duelcard.mean == CardMean.faceupdef)
        {//表侧守备表示
            montrans.rotation = Quaternion.Euler(90, 0, 90);
        }
        if (duelcard.mean == CardMean.facedowndef)
        {//里侧守备表示
            montrans.rotation = Quaternion.Euler(90, 0, 90);
            sprite = Duel.spriteManager.GetTextureSprite("cover");
        }
        if (sprite == null)
            montrans.GetComponent<Renderer>().material.mainTexture = null;
        else
            montrans.GetComponent<Renderer>().material.mainTexture = sprite.texture;
        montrans.gameObject.SetActive(true);
    }

    public void HideMonsterCard(DuelCard duelcard)
    {
        Transform montrans = monsterArea.GetChild(duelcard.index);
        montrans.gameObject.SetActive(false);
    }

    public IEnumerator MonsterPlace(List<int> place)
    {
        /*
        foreach (int index in place)
        {
            monsterArea.GetChild(index).GetComponent<Renderer>().material = Resources.Load("Materials/place") as Material;
            monsterArea.GetChild(index).gameObject.SetActive(true);
        }
        */
        Duel.duelData.placeSelect = -1;
        while (Duel.duelData.placeSelect == -1)
        {
            yield return null;
        }
    }
}
