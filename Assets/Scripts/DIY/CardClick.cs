﻿using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardClick : MonoBehaviour, IPointerClickHandler
{
    public static GameObject lastclickedcard;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        if (lastclickedcard != null) 
            lastclickedcard.GetComponent<Image>().color = Color.white;
        gameObject.GetComponent<Image>().color = Color.gray;//设置点击卡片后的状态颜色
        lastclickedcard = gameObject;

        SQLManager sql = new SQLManager();
        sql.ConnectSQL();

        string cardAbstract = gameObject.GetComponentInChildren<Text>().text;
        string[] abs = cardAbstract.Split('\n');
        string id = abs[abs.Length-1];
        SqliteDataReader reader = sql.ReadCardsAll(Main.tableName, id);
        if (reader.Read())
        {
            string name = reader.GetString(reader.GetOrdinal("name"));
            string describe = reader.GetString(reader.GetOrdinal("describe"));
            GameObject.Find("CardNameInputField").GetComponent<InputField>().text = name;
            GameObject.Find("CardIdInputField").GetComponent<InputField>().text = id;
            Dropdown dp = GameObject.Find("Dropdown").GetComponent<Dropdown>();
            dp.value = 0;
            GameObject.Find("DescribeInputField").GetComponent<InputField>().text = describe;
        }
        reader.Close();

        sql.CloseSQLConnection();
    }
}
