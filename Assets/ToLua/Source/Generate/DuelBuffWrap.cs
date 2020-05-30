﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DuelBuffWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DuelBuff), typeof(System.Object));
		L.RegFunction("SetTargetCard", SetTargetCard);
		L.RegFunction("SetConTime", SetConTime);
		L.RegFunction("SetBuff", SetBuff);
		L.RegFunction("New", _CreateDuelBuff);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("fromcard", get_fromcard, set_fromcard);
		L.RegVar("effect", get_effect, set_effect);
		L.RegVar("targetcard", get_targetcard, set_targetcard);
		L.RegVar("conturn", get_conturn, set_conturn);
		L.RegVar("conphase", get_conphase, set_conphase);
		L.RegVar("bufftype", get_bufftype, set_bufftype);
		L.RegVar("buff", get_buff, set_buff);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDuelBuff(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				DuelBuff obj = new DuelBuff();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: DuelBuff.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTargetCard(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DuelBuff obj = (DuelBuff)ToLua.CheckObject<DuelBuff>(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.SetTargetCard(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetConTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			DuelBuff obj = (DuelBuff)ToLua.CheckObject<DuelBuff>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SetConTime(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBuff(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			DuelBuff obj = (DuelBuff)ToLua.CheckObject<DuelBuff>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj.SetBuff(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fromcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			DuelCard ret = obj.fromcard;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fromcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int ret = obj.effect;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index effect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			object ret = obj.targetcard;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_conturn(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int ret = obj.conturn;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index conturn on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_conphase(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int ret = obj.conphase;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index conphase on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bufftype(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int ret = obj.bufftype;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bufftype on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_buff(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			object ret = obj.buff;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index buff on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fromcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			DuelCard arg0 = (DuelCard)ToLua.CheckObject<DuelCard>(L, 2);
			obj.fromcard = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fromcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_effect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.effect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index effect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.targetcard = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_conturn(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.conturn = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index conturn on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_conphase(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.conphase = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index conphase on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bufftype(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.bufftype = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bufftype on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_buff(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelBuff obj = (DuelBuff)o;
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.buff = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index buff on a nil value");
		}
	}
}

