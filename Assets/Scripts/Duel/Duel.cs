﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Duel : MonoBehaviour
{
    public GameObject mainLayout;
    public static List<string> owndeck = new List<string>();
    public static List<string> ownextra = new List<string>();
    public static List<string> opsdeck = new List<string>();
    public static List<string> opsextra = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        ReadDeckFile();
    }

    // Update is called once per frame
    void Update()
    {
        
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
            owndeck.Add(strs[i]);
            opsdeck.Add(strs[i]);
            i++;
        }
        i++;
        while (!strs[i].Equals("!side"))
        {
            int rmindex = strs[i].IndexOf('#');
            if (rmindex >= 0) strs[i] = strs[i].Remove(rmindex);
            ownextra.Add(strs[i]);
            opsextra.Add(strs[i]);
            i++;
        }
    }

    public void OnQuitClick()
    {
        Destroy(gameObject);
        Instantiate(mainLayout, GameObject.Find("Canvas").transform);
    }
}
