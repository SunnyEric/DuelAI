﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Duel : MonoBehaviour
{
    public GameObject mainLayout;
    public DeckOwn deckOwn;
    public DeckOps deckOps;
    public HandCardOwn handOwn;
    public HandCardOps handOps;
    public MonsterOwn monserOwn;
    public MonsterOps monserOps;
    public GameObject endTurnButton;
    public Text phaseText;
    public GameObject mainPhaseButton;
    public static CardSpriteManager spriteManager;
    public static Sprite UIMask;
    public static DuelDataManager duelData;
    public AI ai;

    // Start is called before the first frame update
    void Start()
    {
        duelData = new DuelDataManager(2);
        spriteManager = new CardSpriteManager();
        ai = new AI();
        UIMask = GameObject.Find("DeckImageOwn").GetComponent<Image>().sprite;//保存UIMask
        monserOwn = GameObject.Find("MonsterAreaOwn").GetComponent<MonsterOwn>();
        monserOps = GameObject.Find("MonsterAreaOps").GetComponent<MonsterOps>();
        //读取卡组
        ReadDeckFile();
        //加载卡组数据
        duelData.LoadDeckData();
        //放置卡组
        deckOwn.DeckUpdate();
        deckOps.DeckUpdate();
        //初始化回合和阶段
        duelData.whoTurn = 0;
        ChangePhase(0);
        //各自起手5张卡
        StartCoroutine(DrawCardOwn(5));
        StartCoroutine(DrawCardOps(5));
        //决斗开始
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnQuitClick()
    {
        Destroy(gameObject);
        Instantiate(mainLayout, GameObject.Find("Canvas").transform);
    }

    public void ReadDeckFile()
    {
        string deckpath = Main.rulePath + "/deck/mycard.ydk";
        string[] strs = File.ReadAllLines(deckpath);
        int i = 0;
        while (!strs[i].Equals("#main")) i++;
        i++;
        while (!strs[i].Equals("#extra"))
        {
            int rmindex = strs[i].IndexOf('#');
            if (rmindex >= 0) strs[i] = strs[i].Remove(rmindex);
            duelData.deck[0].Add(strs[i]);
            duelData.deck[1].Add(strs[i]);
            i++;
        }
        i++;
        while (!strs[i].Equals("!side"))
        {
            int rmindex = strs[i].IndexOf('#');
            if (rmindex >= 0) strs[i] = strs[i].Remove(rmindex);
            duelData.extra[0].Add(strs[i]);
            duelData.extra[1].Add(strs[i]);
            i++;
        }
    }

    public void ChangePhase(int phase)
    {
        if (phase >= 7)
        {
            phase = 0;
            duelData.whoTurn = 1 - duelData.whoTurn;
        }
        duelData.duelPhase = phase;
        PhaseButtonShow();
        if (duelData.duelPhase == 0)
        {
            if (duelData.whoTurn == 0) phaseText.text = "我的回合";
            else phaseText.text = "对方回合";
            StartCoroutine(PhaseWait());
        }
        if (duelData.duelPhase == 1)
        {
            phaseText.text = "抽卡阶段";
            if(duelData.whoTurn == 0) StartCoroutine(DrawCardOwn(1));
            else StartCoroutine(DrawCardOps(1));
            StartCoroutine(PhaseWait());
        }
        if (duelData.duelPhase == 2)
        {
            phaseText.text = "准备阶段";
            StartCoroutine(PhaseWait());
        }
        if (duelData.duelPhase == 3)
        {
            phaseText.text = "主一阶段";
            ChangeMainPhaseButtonText();
            if (duelData.whoTurn == 0)
            {
                NormalSummonFromHandCardOwn(2, 2);
                StartCoroutine(PhaseWait());
            }
            else
            {
                NormalSummonFromHandCardOps(2, 2);
                StartCoroutine(PhaseWait());
            }
        }
        if (duelData.duelPhase == 4)
        {
            phaseText.text = "战斗阶段";
            ChangeMainPhaseButtonText();
        }
        if (duelData.duelPhase == 5)
        {
            phaseText.text = "主二阶段";
        }
        if (duelData.duelPhase == 6)
        {
            phaseText.text = "结束阶段";
            StartCoroutine(PhaseWait());
        }
    }

    public IEnumerator PhaseWait()
    {
        yield return new WaitForSeconds(1);
        ChangePhase(++duelData.duelPhase);
    }

    public void PhaseButtonShow()
    {
        if (duelData.duelPhase >= 3 && duelData.duelPhase <= 4) mainPhaseButton.SetActive(true);
        else mainPhaseButton.SetActive(false);
        if (duelData.duelPhase >= 3 && duelData.duelPhase <= 5) endTurnButton.SetActive(true);
        else endTurnButton.SetActive(false);
    }

    public void OnEndTurnButtonClick()
    {
        ChangePhase(6);
    }

    public void ChangeMainPhaseButtonText()
    {
        Text buttonText = mainPhaseButton.GetComponentInChildren<Text>();
        if (duelData.duelPhase == 3) buttonText.text = "开始战斗";
        if (duelData.duelPhase == 4) buttonText.text = "结束战斗";
    }

    public void OnMainPhaseButtonClick()
    {
        if (duelData.duelPhase == 4) ChangePhase(5);
        if (duelData.duelPhase == 3) ChangePhase(4);
    }

    /// <summary>
    /// 自己抽卡
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public IEnumerator DrawCardOwn(int num)
    {
        while (num > 0)
        {
            yield return new WaitForSeconds(0.1f);
            handOwn.AddHandCardFromDeck();
            duelData.handcard[duelData.opWhoOwn].Add(duelData.deck[duelData.opWhoOwn][0]);
            duelData.deck[duelData.opWhoOwn].RemoveAt(0);
            deckOwn.DeckUpdate();
            num--;
        }
    }

    /// <summary>
    /// 对方抽卡
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public IEnumerator DrawCardOps(int num)
    {
        while (num > 0)
        {
            yield return new WaitForSeconds(0.1f);
            handOps.AddHandCardFromDeck();
            duelData.handcard[duelData.opWhoOps].Add(duelData.deck[duelData.opWhoOps][0]);
            duelData.deck[duelData.opWhoOps].RemoveAt(0);
            deckOps.DeckUpdate();
            num--;
        }
    }

    /// <summary>
    /// 自己从手卡通常召唤
    /// </summary>
    /// <param name="index"></param>
    /// <param name="position"></param>
    public void NormalSummonFromHandCardOwn(int index, int position)
    {
        handOwn.RemoveHandCard(index);
        monserOwn.ShowMonsterCard(index, position);
        duelData.monster[duelData.opWhoOwn][position] = duelData.handcard[duelData.opWhoOwn][index];
        duelData.handcard[duelData.opWhoOwn].RemoveAt(index);
    }

    /// <summary>
    /// 对方从手卡通常召唤
    /// </summary>
    /// <param name="index"></param>
    /// <param name="position"></param>
    public void NormalSummonFromHandCardOps(int index, int position)
    {
        handOps.RemoveHandCard(index);
        monserOps.ShowMonsterCard(index, position);
        duelData.monster[duelData.opWhoOps][position] = duelData.handcard[duelData.opWhoOps][index];
        duelData.handcard[duelData.opWhoOps].RemoveAt(index);
    }
}
