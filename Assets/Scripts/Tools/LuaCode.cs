﻿using LuaInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LuaCode
{
    private static LuaState luaState;
    public string testcard;

    public LuaCode()
    {
        InitLoader();
        luaState = new LuaState();
        LuaBinder.Bind(luaState);
        luaState.Start();
    }

    protected LuaFileUtils InitLoader()
    {
        return new LuaResLoader();
    }

    public void SetCode(string code)
    {
        luaState.DoString(code);
    }

    public void SetTestCard()
    {
        luaState.DoFile("test.lua");
        testcard = (string)luaState["testcard"];
    }

    public void Run(string function)
    {
        try
        {
            LuaFunction func = luaState.GetFunction(function);
            func.Call();
            func.Dispose();
        }
        catch(Exception e)
        {
#if UNITY_EDITOR || UNITY_STANDALONE
            File.AppendAllText("error.log", e.ToString());
#elif UNITY_ANDROID
            File.WriteAllText(Main.rulePath+"/error.log", e.ToString());
#endif
        }
    }

    public void Close()
    {
        luaState.Dispose();
    }

    public void Test()
    {
        string code = 
            @"
            function Card1()
                print('运行成功1')
            end
            ";
        SetCode(code);
        code =
            @"
            function Card2()
                print('运行成功2')
            end
            ";
        SetCode(code);
        Run("Card1");
        Run("Card2");
    }

    public static void TestLog(object msg)
    {
        Debug.Log(msg.ToString());
#if UNITY_EDITOR || UNITY_STANDALONE
        File.WriteAllText("1.log", "运行成功");
#elif UNITY_ANDROID
        File.WriteAllText(Main.rulePath + "/1.log", "运行成功");
#endif
    }
}
