﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTrapOwn : MonoBehaviour
{
    public Transform magictrapArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMagicTrapCard(DuelCard duelcard)
    {
        Transform montrans = magictrapArea.GetChild(duelcard.index);
        Sprite sprite = Duel.spriteManager.GetCardSprite(duelcard.id, false);
        if (duelcard.mean == CardMean.faceupmgt)
        {//表侧表示
            montrans.rotation = Quaternion.Euler(90, 0, 0);
        }
        if (duelcard.mean == CardMean.facedownmgt)
        {//里侧表示
            montrans.rotation = Quaternion.Euler(90, 0, 0);
            sprite = Duel.spriteManager.GetTextureSprite("cover");
        }
        if (sprite == null)
            montrans.GetComponent<Renderer>().material.mainTexture = null;
        else
            montrans.GetComponent<Renderer>().material.mainTexture = sprite.texture;
        montrans.gameObject.SetActive(true);
    }

    public void HideMagicTrapCard(DuelCard duelcard)
    {
        Transform montrans = magictrapArea.GetChild(duelcard.index);
        montrans.gameObject.SetActive(false);
    }
}
