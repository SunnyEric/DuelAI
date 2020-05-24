﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 对lua开放的API
/// </summary>
public class DuelEvent : MonoBehaviour
{
    private Duel duel;
    public DuelDataManager duelData;
    public DuelCard thiscard;//当前卡
    public bool precheck;//发动效果和支付代价前预先检查能否执行
    public bool activatable;//卡牌能否发动

    // Start is called before the first frame update
    void Start()
    {
        duel = gameObject.GetComponent<Duel>();
        duelData = Duel.duelData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 设置当前卡
    /// </summary>
    /// <param name="duelcard"></param>
    public void SetThisCard(DuelCard duelcard)
    {
        thiscard = duelcard;
        precheck = false;
        activatable = true;
    }

    /// <summary>
    /// 是否在可以发动主动效果的阶段中
    /// </summary>
    /// <returns></returns>
    public bool InActivePhase()
    {
        if (duelData.duelPhase == 3 || duelData.duelPhase == 5)
        {
            if (!duelData.effectChain) return true;
        }
        return false;
    }

    /// <summary>
    /// 检查效果能否发动
    /// </summary>
    public void Precheck()
    {
        precheck = true;
    }

    /// <summary>
    /// 设置1速的效果，之后可以进行发动
    /// </summary>
    /// <param name="effect"></param>
    /// <param name="cost"></param>
    public void SetActivatableEffect(int effect, bool cost = false)
    {
        precheck = false;
        if (activatable) duel.SetActivatableEffect(thiscard, effect, 1, cost);
        activatable = true;
    }

    /// <summary>
    /// 设置2速的效果，之后可选择以进行发动
    /// </summary>
    /// <param name="effect"></param>
    /// <param name="cost"></param>
    public void SetChainableEffect(int effect, bool cost = false)
    {
        precheck = false;
        if (activatable) duel.SetActivatableEffect(thiscard, effect, 2, cost);
        activatable = true;
    }

    /// <summary>
    /// 设置3速的效果，之后可选择以进行发动
    /// </summary>
    /// <param name="effect"></param>
    /// <param name="cost"></param>
    public void SetCounterableEffect(int effect, bool cost = false)
    {
        precheck = false;
        if (activatable) duel.SetActivatableEffect(thiscard, effect, 3, cost);
        activatable = true;
    }

    /// <summary>
    /// 判断是否把这张卡抽到
    /// </summary>
    /// <param name="card"></param>
    /// <returns></returns>
    public bool DrawnCard(string card)
    {
        //判断刚刚是否有抽卡
        int drawNum = duelData.cardsJustDrawn[duelData.opWho].Count;
        if (drawNum == 0) return false;
        if (card.Equals(""))
        {
            //判断是否在手卡
            if (thiscard.position != CardPosition.handcard) return false;
            //判断是否在抽到的卡中
            int drawIndex = duelData.handcard[duelData.opWho].Count - drawNum;
            if (thiscard.index < drawIndex) return false;
            else return true;
        }
        else
        {
            return duelData.cardsJustDrawn[duelData.opWho].Contains(card);
        }
    }

    /// <summary>
    /// 抽卡
    /// </summary>
    /// <param name="who"></param>
    /// <param name="num"></param>
    public void DrawCard(int who, int num)
    {
        if (precheck) return;
        EventData eData = new EventData
        {
            oplayer = duelData.opWho,
            gameEvent = GameEvent.drawcard,
            data = new Dictionary<string, object>
            {
                { "drawplayer", who },
                { "drawnum", num }
            }
        };
        duelData.eventDate.Add(eData);
    }

    /// <summary>
    /// 把这张卡给对方观看
    /// </summary>
    public void ShowCard(string card)
    {
        if (precheck) return;
        if (card.Equals(""))
        {
            card = thiscard.id;
        }
        Debug.Log("给对方观看卡牌  " + duelData.cardDic[card].name);
    }

    /// <summary>
    /// 手卡的一只怪兽通常召唤
    /// </summary>
    /// <param name="index"></param>
    public void NormalSummon(DuelCard duelcard)
    {
        if (precheck) return;
        EventData eData = new EventData
        {
            oplayer = duelData.opWho,
            gameEvent = GameEvent.normalsummon,
            data = new Dictionary<string, object>
                {
                    { "handcard", duelcard }
                }
        };
        duelData.eventDate.Add(eData);
    }

    /// <summary>
    /// 把这张卡特殊召唤
    /// </summary>
    /// <param name="card"></param>
    public void SpecialSummon(string card)
    {
        if (precheck)
        {
            if (!duel.SpecialSummonCheck()) activatable = false;
            return;
        }
        if (card.Equals(""))
        {
            EventData eData = new EventData
            {
                oplayer = duelData.opWho,
                gameEvent = GameEvent.specialsummon,
                data = new Dictionary<string, object>
                {
                    { "monstercard", thiscard }
                }
            };
            duelData.eventDate.Add(eData);
        }
    }

    /// <summary>
    /// 怪兽变更表示形式
    /// </summary>
    /// <param name="index"></param>
    public void ChangeMean(DuelCard duelcard, int mean = 0)
    {
        if (precheck) return;
        EventData eData = new EventData
        {
            oplayer = duelData.opWho,
            gameEvent = GameEvent.changemean,
            data = new Dictionary<string, object>
                {
                    { "monstercard", duelcard },
                    { "monstermean", mean }
                }
        };
        duelData.eventDate.Add(eData);
    }

    /// <summary>
    /// 战斗
    /// </summary>
    /// <param name="atkmonster"></param>
    /// <param name="antimonster"></param>
    public void Battle(DuelCard atkmonster)
    {
        if (precheck) return;
        EventData eData = new EventData
        {
            oplayer = duelData.opWho,
            gameEvent = GameEvent.battle,
            data = new Dictionary<string, object>
                {
                    { "atkmonster", atkmonster }
                }
        };
        duelData.eventDate.Add(eData);
    }
}
