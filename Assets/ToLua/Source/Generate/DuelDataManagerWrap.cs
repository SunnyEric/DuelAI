﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DuelDataManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DuelDataManager), typeof(System.Object));
		L.RegFunction("InitialArray", InitialArray);
		L.RegFunction("SortCard", SortCard);
		L.RegFunction("ChangeNextPlayer", ChangeNextPlayer);
		L.RegFunction("GetAllCards", GetAllCards);
		L.RegFunction("New", _CreateDuelDataManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("playerNum", get_playerNum, set_playerNum);
		L.RegVar("areaNum", get_areaNum, set_areaNum);
		L.RegVar("turnNum", get_turnNum, set_turnNum);
		L.RegVar("duelPhase", get_duelPhase, set_duelPhase);
		L.RegVar("player", get_player, set_player);
		L.RegVar("opWho", get_opWho, set_opWho);
		L.RegVar("cardData", get_cardData, set_cardData);
		L.RegVar("duelcase", get_duelcase, set_duelcase);
		L.RegVar("duelbuff", get_duelbuff, set_duelbuff);
		L.RegVar("eventDate", get_eventDate, set_eventDate);
		L.RegVar("record", get_record, set_record);
		L.RegVar("LP", get_LP, set_LP);
		L.RegVar("deck", get_deck, set_deck);
		L.RegVar("extra", get_extra, set_extra);
		L.RegVar("grave", get_grave, set_grave);
		L.RegVar("except", get_except, set_except);
		L.RegVar("handcard", get_handcard, set_handcard);
		L.RegVar("monster", get_monster, set_monster);
		L.RegVar("magictrap", get_magictrap, set_magictrap);
		L.RegVar("fieldcard", get_fieldcard, set_fieldcard);
		L.RegVar("special", get_special, set_special);
		L.RegVar("normalsummon", get_normalsummon, set_normalsummon);
		L.RegVar("chainEffect", get_chainEffect, set_chainEffect);
		L.RegVar("waitEffect", get_waitEffect, set_waitEffect);
		L.RegVar("effectChain", get_effectChain, set_effectChain);
		L.RegVar("activatableEffect", get_activatableEffect, set_activatableEffect);
		L.RegVar("placeSelect", get_placeSelect, set_placeSelect);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDuelDataManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				DuelDataManager obj = new DuelDataManager(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: DuelDataManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitialArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DuelDataManager obj = (DuelDataManager)ToLua.CheckObject<DuelDataManager>(L, 1);
			obj.InitialArray();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortCard(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DuelDataManager obj = (DuelDataManager)ToLua.CheckObject<DuelDataManager>(L, 1);
			System.Collections.Generic.List<DuelCard> arg0 = (System.Collections.Generic.List<DuelCard>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<DuelCard>));
			obj.SortCard(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeNextPlayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DuelDataManager obj = (DuelDataManager)ToLua.CheckObject<DuelDataManager>(L, 1);
			obj.ChangeNextPlayer();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllCards(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DuelDataManager obj = (DuelDataManager)ToLua.CheckObject<DuelDataManager>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			System.Collections.Generic.List<DuelCard> o = obj.GetAllCards(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_playerNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.playerNum;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index playerNum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_areaNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.areaNum;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index areaNum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_turnNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.turnNum;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index turnNum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_duelPhase(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.duelPhase;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index duelPhase on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_player(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.player;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index player on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_opWho(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.opWho;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index opWho on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cardData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			CardDataManager ret = obj.cardData;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cardData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_duelcase(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCase> ret = obj.duelcase;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index duelcase on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_duelbuff(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelBuff> ret = obj.duelbuff;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index duelbuff on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eventDate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<EventData> ret = obj.eventDate;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index eventDate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_record(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelRecord> ret = obj.record;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index record on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LP(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int[] ret = obj.LP;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index LP on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deck(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] ret = obj.deck;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index deck on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_extra(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] ret = obj.extra;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index extra on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_grave(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] ret = obj.grave;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index grave on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_except(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] ret = obj.except;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index except on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_handcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] ret = obj.handcard;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index handcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_monster(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[][] ret = obj.monster;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index monster on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_magictrap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[][] ret = obj.magictrap;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index magictrap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fieldcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[] ret = obj.fieldcard;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fieldcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_special(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[][] ret = obj.special;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index special on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normalsummon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int[] ret = obj.normalsummon;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index normalsummon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_chainEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<CardEffect> ret = obj.chainEffect;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index chainEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_waitEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<CardEffect> ret = obj.waitEffect;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index waitEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectChain(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			bool ret = obj.effectChain;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index effectChain on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activatableEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<CardEffect> ret = obj.activatableEffect;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index activatableEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_placeSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int ret = obj.placeSelect;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index placeSelect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_playerNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.playerNum = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index playerNum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_areaNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.areaNum = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index areaNum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_turnNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.turnNum = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index turnNum on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_duelPhase(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.duelPhase = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index duelPhase on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_player(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.player = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index player on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_opWho(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.opWho = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index opWho on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cardData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			CardDataManager arg0 = (CardDataManager)ToLua.CheckObject<CardDataManager>(L, 2);
			obj.cardData = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cardData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_duelcase(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCase> arg0 = (System.Collections.Generic.List<DuelCase>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<DuelCase>));
			obj.duelcase = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index duelcase on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_duelbuff(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelBuff> arg0 = (System.Collections.Generic.List<DuelBuff>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<DuelBuff>));
			obj.duelbuff = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index duelbuff on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eventDate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<EventData> arg0 = (System.Collections.Generic.List<EventData>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<EventData>));
			obj.eventDate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index eventDate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_record(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelRecord> arg0 = (System.Collections.Generic.List<DuelRecord>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<DuelRecord>));
			obj.record = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index record on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LP(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.LP = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index LP on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_deck(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] arg0 = ToLua.CheckObjectArray<System.Collections.Generic.List<DuelCard>>(L, 2);
			obj.deck = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index deck on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_extra(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] arg0 = ToLua.CheckObjectArray<System.Collections.Generic.List<DuelCard>>(L, 2);
			obj.extra = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index extra on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_grave(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] arg0 = ToLua.CheckObjectArray<System.Collections.Generic.List<DuelCard>>(L, 2);
			obj.grave = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index grave on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_except(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] arg0 = ToLua.CheckObjectArray<System.Collections.Generic.List<DuelCard>>(L, 2);
			obj.except = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index except on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_handcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<DuelCard>[] arg0 = ToLua.CheckObjectArray<System.Collections.Generic.List<DuelCard>>(L, 2);
			obj.handcard = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index handcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_monster(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[][] arg0 = ToLua.CheckObjectArray<DuelCard[]>(L, 2);
			obj.monster = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index monster on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_magictrap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[][] arg0 = ToLua.CheckObjectArray<DuelCard[]>(L, 2);
			obj.magictrap = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index magictrap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fieldcard(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[] arg0 = ToLua.CheckObjectArray<DuelCard>(L, 2);
			obj.fieldcard = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fieldcard on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_special(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			DuelCard[][] arg0 = ToLua.CheckObjectArray<DuelCard[]>(L, 2);
			obj.special = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index special on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_normalsummon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.normalsummon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index normalsummon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_chainEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<CardEffect> arg0 = (System.Collections.Generic.List<CardEffect>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<CardEffect>));
			obj.chainEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index chainEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_waitEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<CardEffect> arg0 = (System.Collections.Generic.List<CardEffect>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<CardEffect>));
			obj.waitEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index waitEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_effectChain(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.effectChain = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index effectChain on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_activatableEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			System.Collections.Generic.List<CardEffect> arg0 = (System.Collections.Generic.List<CardEffect>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<CardEffect>));
			obj.activatableEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index activatableEffect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_placeSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DuelDataManager obj = (DuelDataManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.placeSelect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index placeSelect on a nil value");
		}
	}
}

