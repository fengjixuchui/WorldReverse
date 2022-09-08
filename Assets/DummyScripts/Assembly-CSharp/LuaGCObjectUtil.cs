/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class LuaGCObjectUtil // TypeDefIndex: 27728
{
	// Fields
	private static readonly Dictionary<IntPtr, LuaDataMark> _markSet; // 0x00
	private static Stack<LuaDataMark> _markStack; // 0x08
	private const int BIT_ISCOLLECTABLE = 64; // Metadata: 0x00B0CCF8
	private static IntPtr _G; // 0x10
	private static IntPtr _R; // 0x18
	private const int LUA_NUMTAGS = 9; // Metadata: 0x00B0CCFC
	private const int STRCACHE_N = 53; // Metadata: 0x00B0CD00
	private const int STRCACHE_M = 2; // Metadata: 0x00B0CD04

	// Nested types
	public class LuaData // TypeDefIndex: 27729
	{
		// Fields
		public IntPtr ptr; // 0x10
		public int size; // 0x18
		public int selfSize; // 0x1C
		public int type; // 0x20

		// Constructors
		public LuaData() {} // 0x000000018158E8B0-0x000000018158E950
	}

	private class LuaDataMark : LuaData // TypeDefIndex: 27730
	{
		// Fields
		public bool mark; // 0x28
		public HashSet<LuaData> childSet; // 0x30

		// Constructors
		public LuaDataMark() {} // 0x000000018158E680-0x000000018158E8B0
	}

	private enum LuaType // TypeDefIndex: 27731
	{
		NONE = -1,
		TNIL = 0,
		TBOOLEAN = 1,
		TLIGHTUSERDATA = 2,
		TNUMBER = 3,
		TNUMFLT = 3,
		TSTRING = 4,
		TSHRSTR = 4,
		TTABLE = 5,
		TFUNCTION = 6,
		TLCL = 6,
		TUSERDATA = 7,
		TTHREAD = 8,
		NUMTAGS = 9,
		TPROTO = 9,
		TDEADKEY = 10,
		TOTALTAGS = 11,
		TNUMINT = 19,
		MINSTACK = 20,
		TLNGSTR = 20,
		TLCF = 22,
		TCCL = 38
	}

	private struct GCObject // TypeDefIndex: 27732
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
	}

	private struct TString // TypeDefIndex: 27733
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public byte extra; // 0x0A
		public byte shrlen; // 0x0B
		public uint hash; // 0x0C
		public U u; // 0x10

		// Nested types
		public struct U // TypeDefIndex: 27734
		{
			// Fields
			public long lnglen; // 0x00
			public unsafe TString* hnext; // 0x00
		}
	}

	private struct L_Umaxalign // TypeDefIndex: 27735
	{
		// Fields
		public long n; // 0x00
		public double u; // 0x00
		public unsafe void* s; // 0x00
		public int i; // 0x00
		public long l; // 0x00
	}

	private struct UTString // TypeDefIndex: 27736
	{
		// Fields
		public L_Umaxalign dummy; // 0x00
		public TString tsv; // 0x00
	}

	private struct Value // TypeDefIndex: 27737
	{
		// Fields
		public unsafe GCObject* gc; // 0x00
		public unsafe void* p; // 0x00
		public int b; // 0x00
		public IntPtr f; // 0x00
		public long i; // 0x00
		public double n; // 0x00
	}

	private struct TKey // TypeDefIndex: 27738
	{
		// Fields
		public NK nk; // 0x00
		public TValue tvk; // 0x00

		// Nested types
		public struct NK // TypeDefIndex: 27739
		{
			// Fields
			public LuaGCObjectUtil.Value value_; // 0x00
			public int tt_; // 0x08
			public int next; // 0x0C
		}
	}

	private struct Node // TypeDefIndex: 27740
	{
		// Fields
		public TValue i_val; // 0x00
		public TKey i_key; // 0x10
	}

	private struct Table // TypeDefIndex: 27741
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public byte flags; // 0x0A
		public byte lsizenode; // 0x0B
		public uint sizearray; // 0x0C
		public unsafe TValue* array; // 0x10
		public unsafe Node* node; // 0x18
		public unsafe Node* lastfree; // 0x20
		public unsafe Table* metatable; // 0x28
		public unsafe GCObject* gclist; // 0x30
	}

	private struct Udata // TypeDefIndex: 27742
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public byte ttuv_; // 0x0A
		public unsafe Table* metatable; // 0x10
		public long len; // 0x18
		public LuaGCObjectUtil.Value user_; // 0x20
	}

	private struct UUdata // TypeDefIndex: 27743
	{
		// Fields
		public L_Umaxalign dummy; // 0x00
		public Udata uv; // 0x00
	}

	private struct TValue // TypeDefIndex: 27744
	{
		// Fields
		public LuaGCObjectUtil.Value value_; // 0x00
		public int tt_; // 0x08
	}

	private struct CClosure // TypeDefIndex: 27745
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public byte nupvalues; // 0x0A
		public unsafe GCObject* gclist; // 0x10
		public IntPtr f; // 0x18
		public TValue upvalue; // 0x20
	}

	private struct LocVar // TypeDefIndex: 27746
	{
		// Fields
		public unsafe TString* varname; // 0x00
		public int startpc; // 0x08
		public int endpc; // 0x0C
	}

	private struct Upvaldesc // TypeDefIndex: 27747
	{
		// Fields
		public unsafe TString* name; // 0x00
		public byte instack; // 0x08
		public byte idx; // 0x09
	}

	private struct Proto // TypeDefIndex: 27748
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public byte numparams; // 0x0A
		public byte is_vararg; // 0x0B
		public byte maxstacksize; // 0x0C
		public int sizeupvalues; // 0x10
		public int sizek; // 0x14
		public int sizecode; // 0x18
		public int sizelineinfo; // 0x1C
		public int sizep; // 0x20
		public int sizelocvars; // 0x24
		public int linedefined; // 0x28
		public int lastlinedefined; // 0x2C
		public unsafe TValue* k; // 0x30
		public unsafe ulong* code; // 0x38
		public unsafe Proto** p; // 0x40
		public unsafe int* lineinfo; // 0x48
		public unsafe LocVar* locvars; // 0x50
		public unsafe Upvaldesc* upvalues; // 0x58
		public unsafe LClosure* cache; // 0x60
		public unsafe TString* source; // 0x68
		public unsafe GCObject* gclist; // 0x70
	}

	private struct UpVal // TypeDefIndex: 27749
	{
		// Fields
		public unsafe TValue* v; // 0x00
		public ulong refcount; // 0x08
		public U u; // 0x10

		// Nested types
		public struct U // TypeDefIndex: 27750
		{
			// Fields
			public Open open; // 0x00
			public TValue value; // 0x00

			// Nested types
			public struct Open // TypeDefIndex: 27751
			{
				// Fields
				public unsafe UpVal* next; // 0x00
				public int touched; // 0x08
			}
		}
	}

	private struct LClosure // TypeDefIndex: 27752
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public byte nupvalues; // 0x0A
		public unsafe GCObject* gclist; // 0x10
		public unsafe Proto* p; // 0x18
		public unsafe UpVal* upvals; // 0x20
	}

	private struct Closure // TypeDefIndex: 27753
	{
		// Fields
		public CClosure c; // 0x00
		public LClosure l; // 0x00
	}

	private struct StringTable // TypeDefIndex: 27754
	{
		// Fields
		public unsafe TString** hash; // 0x00
		public int nuse; // 0x08
		public int size; // 0x0C
	}

	public enum TMS // TypeDefIndex: 27755
	{
		TM_INDEX = 0,
		TM_NEWINDEX = 1,
		TM_GC = 2,
		TM_MODE = 3,
		TM_LEN = 4,
		TM_EQ = 5,
		TM_ADD = 6,
		TM_SUB = 7,
		TM_MUL = 8,
		TM_MOD = 9,
		TM_POW = 10,
		TM_DIV = 11,
		TM_IDIV = 12,
		TM_BAND = 13,
		TM_BOR = 14,
		TM_BXOR = 15,
		TM_SHL = 16,
		TM_SHR = 17,
		TM_UNM = 18,
		TM_BNOT = 19,
		TM_LT = 20,
		TM_LE = 21,
		TM_CONCAT = 22,
		TM_CALL = 23,
		TM_N = 24
	}

	private struct GlobalState // TypeDefIndex: 27756
	{
		// Fields
		public IntPtr frealloc; // 0x00
		public unsafe void* ud; // 0x08
		public long totalbytes; // 0x10
		public long GCdebt; // 0x18
		public ulong GCmemtrav; // 0x20
		public ulong GCestimate; // 0x28
		public StringTable strt; // 0x30
		public TValue l_registry; // 0x40
		public uint seed; // 0x50
		public byte currentwhite; // 0x54
		public byte gcstate; // 0x55
		public byte gckind; // 0x56
		public byte gcrunning; // 0x57
		public unsafe GCObject* allgc; // 0x58
		public unsafe GCObject** sweepgc; // 0x60
		public unsafe GCObject* finobj; // 0x68
		public unsafe GCObject* gray; // 0x70
		public unsafe GCObject* grayagain; // 0x78
		public unsafe GCObject* weak; // 0x80
		public unsafe GCObject* ephemeron; // 0x88
		public unsafe GCObject* allweak; // 0x90
		public unsafe GCObject* tobefnz; // 0x98
		public unsafe GCObject* fixedgc; // 0xA0
		public unsafe LuaState* twups; // 0xA8
		public uint gcfinnum; // 0xB0
		public int gcpause; // 0xB4
		public int gcstepmul; // 0xB8
		public IntPtr panic; // 0xC0
		public unsafe LuaState* mainthread; // 0xC8
		public unsafe double* version; // 0xD0
		public unsafe TString* memerrmsg; // 0xD8
		public IntPtr[] tmname; // 0xE0
		public IntPtr[] mt; // 0xE8
		public IntPtr[] strcache; // 0xF0
	}

	private struct CallInfo // TypeDefIndex: 27757
	{
		// Fields
		public unsafe TValue* func; // 0x00
		public unsafe TValue* top; // 0x08
		public unsafe CallInfo* previous; // 0x10
		public unsafe CallInfo* next; // 0x18
		public U u; // 0x20
		public IntPtr extra; // 0x38
		public short nresults; // 0x40
		public ushort callstatus; // 0x42

		// Nested types
		public struct U // TypeDefIndex: 27758
		{
			// Fields
			public L l; // 0x00
			public C c; // 0x00

			// Nested types
			public struct L // TypeDefIndex: 27759
			{
				// Fields
				public unsafe TValue* @base; // 0x00
				public unsafe ulong* savedpc; // 0x08
			}

			public struct C // TypeDefIndex: 27760
			{
				// Fields
				public IntPtr k; // 0x00
				public IntPtr old_errfunc; // 0x08
				public IntPtr ctx; // 0x10
			}
		}
	}

	private struct LuaLongJmp // TypeDefIndex: 27761
	{
		// Fields
		public unsafe LuaLongJmp* previous; // 0x00
		public unsafe int* b; // 0x08
		public int status; // 0x10
	}

	private struct LuaState // TypeDefIndex: 27762
	{
		// Fields
		public unsafe GCObject* next; // 0x00
		public byte tt; // 0x08
		public byte marked; // 0x09
		public ushort nci; // 0x0A
		public byte status; // 0x0C
		public unsafe TValue* top; // 0x10
		public IntPtr l_G; // 0x18
		public unsafe CallInfo* ci; // 0x20
		public unsafe ulong* oldpc; // 0x28
		public unsafe TValue* stack_last; // 0x30
		public unsafe TValue* stack; // 0x38
		public unsafe UpVal* openupval; // 0x40
		public unsafe GCObject* gclist; // 0x48
		public unsafe LuaState* twups; // 0x50
		public unsafe LuaLongJmp* errorJmp; // 0x58
		public CallInfo base_ci; // 0x60
		public IntPtr hook; // 0xA8
		public IntPtr errfunc; // 0xB0
		public int stacksize; // 0xB8
		public int basehookcount; // 0xBC
		public int hookcount; // 0xC0
		public ushort nny; // 0xC4
		public ushort nCcalls; // 0xC6
		public int hookmask; // 0xC8
		public byte allowhook; // 0xCC
	}

	private struct GCUnion // TypeDefIndex: 27763
	{
		// Fields
		public GCObject gc; // 0x00
		public TString ts; // 0x00
		public Udata u; // 0x00
		public Closure cl; // 0x00
		public Table h; // 0x00
		public Proto p; // 0x00
		public LuaState th; // 0x00
	}

	// Constructors
	static LuaGCObjectUtil() {} // 0x00000001815813C0-0x0000000181581480

	// Methods
	// [XID] // 0x00000001898D8ED0-0x00000001898D8EF0
	public static void Reset(IntPtr _g, IntPtr _r) {} // 0x000000018157D960-0x000000018157DA50
	// [XID] // 0x00000001898E0BE0-0x00000001898E0C00
	public static void Clear() {} // 0x000000018157EC80-0x000000018157ED80
	// [IDTag] // 0x00000001898E8710-0x00000001898E8750
	// [XID] // 0x00000001898E8710-0x00000001898E8750
	public static void GenerateLuaData(LuaEnv env, LuaData data) {} // 0x000000018157D750-0x000000018157D860
	// [IDTag] // 0x00000001898F2D90-0x00000001898F2DD0
	// [XID] // 0x00000001898F2D90-0x00000001898F2DD0
	public static LuaData GenerateLuaData(LuaEnv env, IntPtr address) => default; // 0x000000018157D4E0-0x000000018157D750
	private static unsafe GCObject* ToGCObject(IntPtr p) => default; // 0x000000018157E560-0x000000018157E5D0
	private static unsafe int RawType(GCObject* g) => default; // 0x00000001815811F0-0x0000000181581260
	private static unsafe int NoVariantType(GCObject* g) => default; // 0x000000018157F4F0-0x000000018157F590
	// [XID] // 0x00000001898FD720-0x00000001898FD740
	private static int NoVariantType(int type) => default; // 0x000000018157F450-0x000000018157F4F0
	private static unsafe int RawTType(TValue* t) => default; // 0x000000018157FC40-0x000000018157FCB0
	private static unsafe int TType(TValue* t) => default; // 0x000000018157D180-0x000000018157D1F0
	private static unsafe int TTypeNoVariant(TValue* t) => default; // 0x000000018157F0F0-0x000000018157F190
	private static unsafe bool IsCollectable(TValue* v) => default; // 0x000000018157E960-0x000000018157EA30
	private static unsafe bool TCheckTag(TValue* v, int type) => default; // 0x000000018157FA50-0x000000018157FB30
	private static unsafe bool TCheckType(TValue* v, int type) => default; // 0x000000018157FB30-0x000000018157FBD0
	// [XID] // 0x0000000189904FC0-0x0000000189904FE0
	private static int CollectableToBit(int t) => default; // 0x000000018157EBE0-0x000000018157EC80
	private static unsafe bool TIsShrString(TValue* v) => default; // 0x000000018157DDC0-0x000000018157DE60
	private static unsafe bool TIsNil(TValue* v) => default; // 0x0000000181581320-0x00000001815813C0
	private static unsafe bool TIsString(TValue* v) => default; // 0x000000018157EEE0-0x000000018157EF70
	// [XID] // 0x000000018990C820-0x000000018990C840
	private static int SizeAlign(int n, int align) => default; // 0x0000000181581260-0x0000000181581320
	private static unsafe TString* ToTString(GCObject* g) => default; // 0x000000018157EB00-0x000000018157EBE0
	private static unsafe TString* ToTString(TValue* v) => default; // 0x000000018157EA30-0x000000018157EB00
	private static unsafe Table* ToTable(GCObject* g) => default; // 0x000000018157DE60-0x000000018157DF70
	private static unsafe Udata* ToUdata(GCObject* g) => default; // 0x000000018157FCB0-0x000000018157FDC0
	private static unsafe LClosure* ToLClosure(GCObject* g) => default; // 0x0000000181580AF0-0x0000000181580C00
	private static unsafe CClosure* ToCClosure(GCObject* g) => default; // 0x000000018157F190-0x000000018157F2A0
	private static unsafe LuaState* ToLuaState(GCObject* g) => default; // 0x0000000181580020-0x0000000181580130
	private static unsafe Proto* ToProto(GCObject* g) => default; // 0x000000018157CF60-0x000000018157D070
	private static unsafe GCObject* ToGCObject(TString* s) => default; // 0x000000018157E260-0x000000018157E340
	private static unsafe GCObject* ToGCObject(Udata* d) => default; // 0x000000018157E3A0-0x000000018157E480
	private static unsafe GCObject* ToGCObject(Table* d) => default; // 0x000000018157E5D0-0x000000018157E6B0
	private static unsafe GCObject* ToGCObject(Proto* p) => default; // 0x000000018157E480-0x000000018157E560
	private static unsafe GCObject* ToGCObject(TValue* v) => default; // 0x000000018157E340-0x000000018157E3A0
	// [XID] // 0x00000001899140B0-0x00000001899140D0
	private static int TStringSize(int length) => default; // 0x0000000181580C00-0x0000000181580CC0
	private static unsafe int TableSize(Table* t) => default; // 0x000000018157ED80-0x000000018157EEE0
	private static unsafe int UdataSize(Udata* d) => default; // 0x000000018157FF90-0x0000000181580020
	private static unsafe int LClosureSize(LClosure* lc) => default; // 0x0000000181580130-0x00000001815801F0
	private static unsafe int CClosureSize(CClosure* lc) => default; // 0x0000000181580940-0x0000000181580A00
	private static unsafe int ThreadSize(LuaState* th) => default; // 0x000000018157DCD0-0x000000018157DDC0
	private static unsafe int ProtoSize(Proto* f) => default; // 0x000000018157EF70-0x000000018157F0F0
	private static unsafe LuaDataMark GetLuaData(GCObject* g) => default; // 0x0000000181580E00-0x0000000181581040
	// [XID] // 0x000000018991BB00-0x000000018991BB20
	private static void PushMarkData(LuaDataMark data, bool addSelf) {} // 0x000000018157F590-0x000000018157F7D0
	// [XID] // 0x00000001899230C0-0x00000001899230E0
	private static void PopMarkData() {} // 0x000000018157D1F0-0x000000018157D4E0
	// [XID] // 0x000000018992A850-0x000000018992A870
	private static LuaDataMark GetLuaData(ref GlobalState g, IntPtr ptr) => default; // 0x0000000181580CC0-0x0000000181580E00
	private static unsafe void MarkObject(ref GlobalState g, GCObject* gc) {} // 0x0000000181580890-0x0000000181580940
	// [XID] // 0x0000000189931ED0-0x0000000189931EF0
	private static void MarkObject(ref GlobalState g, LuaDataMark data) {} // 0x0000000181580480-0x0000000181580890
	private static unsafe int SizeNode(Table* t) => default; // 0x000000018157D070-0x000000018157D0F0
	private static unsafe Node* HashStr(Table* t, TString* key) => default; // 0x000000018157DB90-0x000000018157DCD0
	private static unsafe TValue* GetKey(Node* n) => default; // 0x000000018157E6B0-0x000000018157E720
	private static unsafe Node* GetNode(Table* t, int i) => default; // 0x000000018157CBB0-0x000000018157CC60
	private static unsafe Node* GetNodeLast(Table* t) => default; // 0x0000000181580A00-0x0000000181580AF0
	private static unsafe TValue* GetValue(Node* n) => default; // 0x000000018157FBD0-0x000000018157FC40
	private static unsafe int GetNext(Node* n) => default; // 0x00000001815801F0-0x0000000181580260
	private static unsafe TValue* GetShortStr(Table* t, TString* key) => default; // 0x0000000181581040-0x00000001815811F0
	private static unsafe TValue* GetTM(Table* t, IntPtr ename) => default; // 0x000000018157F2A0-0x000000018157F360
	private static unsafe TValue* GetTM(ref GlobalState g, Table* et, TMS e) => default; // 0x000000018157F360-0x000000018157F450
	private static unsafe byte* GetStr(TString* ts) => default; // 0x000000018157D0F0-0x000000018157D180
	private static unsafe byte* StrChr(byte* value, int length, byte key) => default; // 0x000000018157CD60-0x000000018157CE00
	private static unsafe void MarkWeakValue(ref GlobalState g, Table* h) {} // 0x000000018157CE00-0x000000018157CF60
	private static unsafe void MarkWeakKey(ref GlobalState g, Table* h) {} // 0x0000000181580260-0x0000000181580480
	private static unsafe void MarkStrongTable(ref GlobalState g, Table* h) {} // 0x000000018157E720-0x000000018157E960
	private static unsafe void MarkTable(ref GlobalState g, Table* h) {} // 0x000000018157F7D0-0x000000018157FA50
	private static unsafe void MarkUdata(ref GlobalState g, Udata* u) {} // 0x000000018157FDC0-0x000000018157FEB0
	private static unsafe void MarkLClosure(ref GlobalState g, LClosure* cl) {} // 0x000000018157DA50-0x000000018157DB90
	private static unsafe void MarkCClosure(ref GlobalState g, CClosure* cl) {} // 0x000000018157CC60-0x000000018157CD60
	private static unsafe void MarkValue(ref GlobalState g, TValue* v) {} // 0x000000018157D860-0x000000018157D960
	private static unsafe void MarkThread(ref GlobalState g, LuaState* th) {} // 0x000000018157FEB0-0x000000018157FF90
	private static unsafe void MarkProto(ref GlobalState g, Proto* f) {} // 0x000000018157DF70-0x000000018157E260
}

