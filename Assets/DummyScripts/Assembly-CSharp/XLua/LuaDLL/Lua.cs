/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua.LuaDLL
{
	public class Lua // TypeDefIndex: 32382
	{
		// Fields
		private const string LUADLL = "xlua"; // Metadata: 0x00B1432F
	
		// Constructors
		public Lua() {} // 0x0000000183EEF520-0x0000000183EEF580
	
		// Methods
		public static extern IntPtr lua_tothread(IntPtr L, int index); // 0x0000000183EF3800-0x0000000183EF3900
		public static extern int xlua_get_lib_version(); // 0x0000000183EF4410-0x0000000183EF44F0
		public static extern int lua_gc(IntPtr L, LuaGCOptions what, int data); // 0x0000000183EF0920-0x0000000183EF0A20
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n); // 0x0000000183EF0BE0-0x0000000183EF0CE0
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n); // 0x0000000183EF2E60-0x0000000183EF2F60
		public static extern int lua_pushthread(IntPtr L); // 0x0000000183EF23C0-0x0000000183EF24B0
		// [XID] // 0x0000000189B943C0-0x0000000189B943E0
		public static bool lua_isfunction(IntPtr L, int stackPos) => default; // 0x0000000183EF0E90-0x0000000183EF0F50
		// [XID] // 0x0000000189B9B970-0x0000000189B9B990
		public static bool lua_islightuserdata(IntPtr L, int stackPos) => default; // 0x0000000183EF1150-0x0000000183EF1210
		// [XID] // 0x0000000189BA3210-0x0000000189BA3230
		public static bool lua_istable(IntPtr L, int stackPos) => default; // 0x0000000183EF14D0-0x0000000183EF1590
		// [XID] // 0x0000000189BAA3E0-0x0000000189BAA400
		public static bool lua_isthread(IntPtr L, int stackPos) => default; // 0x0000000183EF1590-0x0000000183EF1650
		// [XID] // 0x0000000189BB1B90-0x0000000189BB1BB0
		public static int luaL_error(IntPtr L, string message) => default; // 0x0000000183EEFB30-0x0000000183EEFBF0
		public static extern int lua_setfenv(IntPtr L, int stackPos); // 0x0000000183EF2B70-0x0000000183EF2C70
		public static extern IntPtr luaL_newstate(); // 0x0000000183EEFF10-0x0000000183EEFFF0
		public static extern void lua_close(IntPtr L); // 0x0000000183EF0680-0x0000000183EF0770
		public static extern void luaopen_xlua(IntPtr L); // 0x0000000183EF3DC0-0x0000000183EF3EB0
		public static extern void luaL_openlibs(IntPtr L); // 0x0000000183EEFFF0-0x0000000183EF00E0
		public static extern uint xlua_objlen(IntPtr L, int stackPos); // 0x0000000183EF4CE0-0x0000000183EF4DE0
		public static extern void lua_createtable(IntPtr L, int narr, int nrec); // 0x0000000183EF0770-0x0000000183EF0870
		// [XID] // 0x0000000189BB8D50-0x0000000189BB8D70
		public static void lua_newtable(IntPtr L) {} // 0x0000000183EF1750-0x0000000183EF1800
		public static extern int xlua_getglobal(IntPtr L, string name); // 0x0000000183EF45D0-0x0000000183EF46E0
		public static extern int xlua_setglobal(IntPtr L, string name); // 0x0000000183EF6D10-0x0000000183EF6E20
		public static extern void xlua_getloaders(IntPtr L); // 0x0000000183EF46E0-0x0000000183EF47D0
		public static extern void lua_settop(IntPtr L, int newTop); // 0x0000000183EF2D70-0x0000000183EF2E60
		// [XID] // 0x0000000189BC0C40-0x0000000189BC0C60
		public static void lua_pop(IntPtr L, int amount) {} // 0x0000000183EF1A10-0x0000000183EF1AD0
		public static extern void lua_insert(IntPtr L, int newTop); // 0x0000000183EF0CE0-0x0000000183EF0DD0
		public static extern void lua_remove(IntPtr L, int index); // 0x0000000183EF2990-0x0000000183EF2A80
		public static extern int lua_rawget(IntPtr L, int index); // 0x0000000183EF27A0-0x0000000183EF28A0
		public static extern void lua_rawset(IntPtr L, int index); // 0x0000000183EF28A0-0x0000000183EF2990
		public static extern int lua_setmetatable(IntPtr L, int objIndex); // 0x0000000183EF2C70-0x0000000183EF2D70
		public static extern int lua_rawequal(IntPtr L, int index1, int index2); // 0x0000000183EF26A0-0x0000000183EF27A0
		public static extern void lua_pushvalue(IntPtr L, int index); // 0x0000000183EF25B0-0x0000000183EF26A0
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n); // 0x0000000183EF1BD0-0x0000000183EF1CD0
		public static extern void lua_replace(IntPtr L, int index); // 0x0000000183EF2A80-0x0000000183EF2B70
		public static extern int lua_gettop(IntPtr L); // 0x0000000183EF0AF0-0x0000000183EF0BE0
		public static extern LuaTypes lua_type(IntPtr L, int index); // 0x0000000183EF3B00-0x0000000183EF3C00
		// [XID] // 0x0000000189BC82A0-0x0000000189BC82C0
		public static bool lua_isnil(IntPtr L, int index) => default; // 0x0000000183EF1210-0x0000000183EF12D0
		public static extern bool lua_isnumber(IntPtr L, int index); // 0x0000000183EF12D0-0x0000000183EF13D0
		// [XID] // 0x0000000189BCFC70-0x0000000189BCFC90
		public static bool lua_isboolean(IntPtr L, int index) => default; // 0x0000000183EF0DD0-0x0000000183EF0E90
		public static extern int luaL_ref(IntPtr L, int registryIndex); // 0x0000000183EF00E0-0x0000000183EF01E0
		// [XID] // 0x0000000189BD71E0-0x0000000189BD7200
		public static int luaL_ref(IntPtr L) => default; // 0x0000000183EF01E0-0x0000000183EF0290
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index); // 0x0000000183EF6810-0x0000000183EF6910
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index); // 0x0000000183EF6910-0x0000000183EF6A10
		// [XID] // 0x0000000189BDEDE0-0x0000000189BDEE00
		public static void lua_getref(IntPtr L, int reference) {} // 0x0000000183EF0A20-0x0000000183EF0AF0
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref); // 0x0000000183EF3EB0-0x0000000183EF3FB0
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference); // 0x0000000183EF0290-0x0000000183EF0390
		// [XID] // 0x00000001895EB870-0x00000001895EB890
		public static void lua_unref(IntPtr L, int reference) {} // 0x0000000183EF3C00-0x0000000183EF3CD0
		public static extern bool lua_isstring(IntPtr L, int index); // 0x0000000183EF13D0-0x0000000183EF14D0
		public static extern bool lua_isinteger(IntPtr L, int index); // 0x0000000183EF1050-0x0000000183EF1150
		public static extern void lua_pushnil(IntPtr L); // 0x0000000183EF1ED0-0x0000000183EF1FC0
		// [XID] // 0x00000001895F2D20-0x00000001895F2D40
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0 /* Metadata: 0x00B1432B */) {} // 0x0000000183EF20C0-0x0000000183EF21C0
		public static extern int xlua_upvalueindex(int n); // 0x0000000183EF8370-0x0000000183EF8460
		public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x0000000183EF1900-0x0000000183EF1A10
		public static extern double lua_tonumber(IntPtr L, int index); // 0x0000000183EF3400-0x0000000183EF3510
		public static extern int xlua_tointeger(IntPtr L, int index); // 0x0000000183EF7100-0x0000000183EF7200
		public static extern uint xlua_touint(IntPtr L, int index); // 0x0000000183EF7200-0x0000000183EF7300
		public static extern bool lua_toboolean(IntPtr L, int index); // 0x0000000183EF2F60-0x0000000183EF3060
		public static extern IntPtr lua_topointer(IntPtr L, int index); // 0x0000000183EF3510-0x0000000183EF3610
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen); // 0x0000000183EF32E0-0x0000000183EF3400
		// [XID] // 0x00000001895FA590-0x00000001895FA5B0
		public static string lua_tostring(IntPtr L, int index) => default; // 0x0000000183EF3610-0x0000000183EF3800
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf); // 0x0000000183EF0480-0x0000000183EF0580
		public static extern void lua_pushnumber(IntPtr L, double number); // 0x0000000183EF1FC0-0x0000000183EF20C0
		public static extern void lua_pushboolean(IntPtr L, bool value); // 0x0000000183EF1AD0-0x0000000183EF1BD0
		public static extern void xlua_pushinteger(IntPtr L, int value); // 0x0000000183EF6420-0x0000000183EF6510
		public static extern void xlua_pushuint(IntPtr L, uint value); // 0x0000000183EF6720-0x0000000183EF6810
		// [IDTag] // 0x0000000189601F50-0x0000000189601F90
		// [XID] // 0x0000000189601F50-0x0000000189601F90
		public static void lua_pushstring(IntPtr L, string str) {} // 0x0000000183EF2290-0x0000000183EF23C0
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size); // 0x0000000183EF6510-0x0000000183EF6620
		// [XID] // 0x000000018960C6E0-0x000000018960C700
		public static void xlua_pushasciistring(IntPtr L, string str) {} // 0x0000000183EF60D0-0x0000000183EF6200
		// [IDTag] // 0x0000000189613CE0-0x0000000189613D20
		// [XID] // 0x0000000189613CE0-0x0000000189613D20
		public static void lua_pushstring(IntPtr L, byte[] str) {} // 0x0000000183EF21C0-0x0000000183EF2290
		// [XID] // 0x000000018961E6D0-0x000000018961E6F0
		public static byte[] lua_tobytes(IntPtr L, int index) => default; // 0x0000000183EF3060-0x0000000183EF31E0
		public static extern int luaL_newmetatable(IntPtr L, string meta); // 0x0000000183EEFE00-0x0000000183EEFF10
		public static extern int xlua_pgettable(IntPtr L, int idx); // 0x0000000183EF5CB0-0x0000000183EF5DB0
		public static extern int xlua_psettable(IntPtr L, int idx); // 0x0000000183EF5ED0-0x0000000183EF5FD0
		// [XID] // 0x0000000189625A90-0x0000000189625AB0
		public static void luaL_getmetatable(IntPtr L, string meta) {} // 0x0000000183EEFBF0-0x0000000183EEFCC0
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name); // 0x0000000183EF3FB0-0x0000000183EF40E0
		public static extern int xluaL_loadbufferex(IntPtr L, byte[] buff, int size, string name); // 0x0000000183EF40E0-0x0000000183EF4210
		// [XID] // 0x000000018962D330-0x000000018962D350
		public static int luaL_loadbuffer(IntPtr L, string buff, string name) => default; // 0x0000000183EEFCC0-0x0000000183EEFE00
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj); // 0x0000000183EF7000-0x0000000183EF7100
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj); // 0x0000000183EF6F00-0x0000000183EF7000
		// [XID] // 0x0000000189634E70-0x0000000189634E90
		public static int lua_error(IntPtr L) => default; // 0x0000000183EF0870-0x0000000183EF0920
		public static extern bool lua_checkstack(IntPtr L, int extra); // 0x0000000183EF0580-0x0000000183EF0680
		public static extern int lua_next(IntPtr L, int index); // 0x0000000183EF1800-0x0000000183EF1900
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata); // 0x0000000183EF1DD0-0x0000000183EF1ED0
		public static extern IntPtr xlua_tag(); // 0x0000000183EF6E20-0x0000000183EF6F00
		public static extern void luaL_where(IntPtr L, int level); // 0x0000000183EF0390-0x0000000183EF0480
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref); // 0x0000000183EF7300-0x0000000183EF7400
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref); // 0x0000000183EF6200-0x0000000183EF6320
		public static extern int gen_obj_indexer(IntPtr L); // 0x0000000183EEF760-0x0000000183EEF850
		public static extern int gen_obj_newindexer(IntPtr L); // 0x0000000183EEF850-0x0000000183EEF940
		public static extern int gen_cls_indexer(IntPtr L); // 0x0000000183EEF580-0x0000000183EEF670
		public static extern int gen_cls_newindexer(IntPtr L); // 0x0000000183EEF670-0x0000000183EEF760
		public static extern int get_error_func_ref(IntPtr L); // 0x0000000183EEF940-0x0000000183EEFA30
		public static extern int load_error_func(IntPtr L, int Ref); // 0x0000000183EEFA30-0x0000000183EEFB30
		public static extern int luaopen_i64lib(IntPtr L); // 0x0000000183EF3CD0-0x0000000183EF3DC0
		public static extern void lua_pushint64(IntPtr L, long n); // 0x0000000183EF1CD0-0x0000000183EF1DD0
		public static extern void lua_pushuint64(IntPtr L, ulong n); // 0x0000000183EF24B0-0x0000000183EF25B0
		public static extern bool lua_isint64(IntPtr L, int idx); // 0x0000000183EF0F50-0x0000000183EF1050
		public static extern bool lua_isuint64(IntPtr L, int idx); // 0x0000000183EF1650-0x0000000183EF1750
		public static extern long lua_toint64(IntPtr L, int idx); // 0x0000000183EF31E0-0x0000000183EF32E0
		public static extern ulong lua_touint64(IntPtr L, int idx); // 0x0000000183EF3900-0x0000000183EF3A00
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n); // 0x0000000183EF5FD0-0x0000000183EF60D0
		public static extern int xlua_csharp_str_error(IntPtr L, string message); // 0x0000000183EF4300-0x0000000183EF4410
		public static extern int xlua_csharp_error(IntPtr L); // 0x0000000183EF4210-0x0000000183EF4300
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field); // 0x0000000183EF5A80-0x0000000183EF5B90
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field); // 0x0000000183EF8260-0x0000000183EF8370
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field); // 0x0000000183EF5750-0x0000000183EF5860
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field); // 0x0000000183EF7F00-0x0000000183EF8020
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field); // 0x0000000183EF5860-0x0000000183EF5970
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field); // 0x0000000183EF8020-0x0000000183EF8140
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field); // 0x0000000183EF5970-0x0000000183EF5A80
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field); // 0x0000000183EF8140-0x0000000183EF8260
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field); // 0x0000000183EF5640-0x0000000183EF5750
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field); // 0x0000000183EF7DE0-0x0000000183EF7F00
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field); // 0x0000000183EF4EF0-0x0000000183EF5000
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field); // 0x0000000183EF7560-0x0000000183EF7680
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref); // 0x0000000183EF6620-0x0000000183EF6720
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref); // 0x0000000183EF6320-0x0000000183EF6420
		public static extern IntPtr lua_touserdata(IntPtr L, int idx); // 0x0000000183EF3A00-0x0000000183EF3B00
		public static extern int xlua_gettypeid(IntPtr L, int idx); // 0x0000000183EF47D0-0x0000000183EF48D0
		public static extern int xlua_get_registry_index(); // 0x0000000183EF44F0-0x0000000183EF45D0
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path); // 0x0000000183EF5B90-0x0000000183EF5CB0
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path); // 0x0000000183EF5DB0-0x0000000183EF5ED0
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2); // 0x0000000183EF5000-0x0000000183EF5120
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2); // 0x0000000183EF7680-0x0000000183EF77C0
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3); // 0x0000000183EF5120-0x0000000183EF5250
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3); // 0x0000000183EF77C0-0x0000000183EF7930
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4); // 0x0000000183EF5250-0x0000000183EF5390
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4); // 0x0000000183EF7930-0x0000000183EF7AA0
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5); // 0x0000000183EF5390-0x0000000183EF54E0
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5); // 0x0000000183EF7AA0-0x0000000183EF7C30
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6); // 0x0000000183EF54E0-0x0000000183EF5640
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6); // 0x0000000183EF7C30-0x0000000183EF7DE0
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec); // 0x0000000183EF4DE0-0x0000000183EF4EF0
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64); // 0x0000000183EF7400-0x0000000183EF7560
		// [XID] // 0x000000018963C4B0-0x000000018963C4D0
		public static bool xlua_is_eq_str(IntPtr L, int index, string str) => default; // 0x0000000183EF4BE0-0x0000000183EF4CE0
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len); // 0x0000000183EF4AB0-0x0000000183EF4BE0
		public static extern IntPtr xlua_gl(IntPtr L); // 0x0000000183EF48D0-0x0000000183EF49C0
		public static extern void xlua_report_table_size(IntPtr L, TableSizeReport cb, int fast); // 0x0000000183EF6C00-0x0000000183EF6D10
		public static extern void xlua_report_object_relationship(IntPtr L, ObjectRelationshipReport cb); // 0x0000000183EF6B00-0x0000000183EF6C00
		public static extern IntPtr xlua_registry_pointer(IntPtr L); // 0x0000000183EF6A10-0x0000000183EF6B00
		public static extern IntPtr xlua_global_pointer(IntPtr L); // 0x0000000183EF49C0-0x0000000183EF4AB0
	}
}
