﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PlayerSideWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PlayerSide), typeof(System.Object));
		L.RegFunction("New", _CreatePlayerSide);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("own", 0);
		L.RegConstant("ops", 1);
		L.RegConstant("both", 2);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePlayerSide(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PlayerSide obj = new PlayerSide();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PlayerSide.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

