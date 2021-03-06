﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterOps : MonoBehaviour
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

    public Transform GetChildCard(int index)
    {
        return monsterArea.GetChild(index).GetChild(0);
    }

    public Transform GetSelectParticle(int index)
    {
        return monsterArea.GetChild(index).GetChild(1);
    }

    public void SetCover()
    {
        Sprite sprite = Duel.spriteManager.GetTextureSprite("cover");
        for (int index = 0; index < monsterArea.childCount; index++)
        {
            if (sprite == null)
                GetChildCard(index).GetComponent<Renderer>().materials[2].mainTexture = null;
            else
                GetChildCard(index).GetComponent<Renderer>().materials[2].mainTexture = sprite.texture;
        }
    }

    public void ReSetAll()
    {
        for (int index = 0; index < monsterArea.childCount; index++)
        {
            HideMonsterCard(index);
            HideSelectParticle(index);
        }
    }

    public void ShowMonsterCard(DuelCard duelcard)
    {
        Transform montrans = GetChildCard(duelcard.index);
        Sprite sprite = Duel.spriteManager.GetCardSprite(duelcard.id, false);
        if (duelcard.mean == CardMean.faceupatk)
        {//表侧攻击表示
            montrans.rotation = Quaternion.Euler(270, 180, 0);
        }
        if (duelcard.mean == CardMean.faceupdef)
        {//表侧守备表示
            montrans.rotation = Quaternion.Euler(270, 90, 0);
        }
        if (duelcard.mean == CardMean.facedowndef)
        {//里侧守备表示
            montrans.rotation = Quaternion.Euler(90, 270, 0);
        }
        if (sprite == null)
            montrans.GetComponent<Renderer>().material.mainTexture = null;
        else
            montrans.GetComponent<Renderer>().material.mainTexture = sprite.texture;
        montrans.gameObject.SetActive(true);
    }

    public void HideMonsterCard(int index)
    {
        Transform montrans = GetChildCard(index);
        montrans.gameObject.SetActive(false);
    }

    public void ShowSelectParticle(List<int> place)
    {
        foreach (int index in place)
        {
            GetSelectParticle(index).gameObject.SetActive(true);
        }
    }

    public void HideSelectParticle(int index)
    {
        Transform particle = GetSelectParticle(index);
        particle.gameObject.SetActive(false);
    }
}
