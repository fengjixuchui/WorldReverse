/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using XLua;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LuaDebugMonitor // TypeDefIndex: 27725
{
	// Fields
	private static readonly Dictionary<IntPtr, TableData> _tableSet; // 0x00
	private static IntPtr _globalPointer; // 0x08
	private static IntPtr _registryPointer; // 0x10
	private static int _memorySize; // 0x18
	private static StringBuilder _stringBuilder; // 0x20

	// Nested types
	private class TableData : LuaGCObjectUtil.LuaData // TypeDefIndex: 27726
	{
		// Fields
		public int count; // 0x28
		public bool isRoot; // 0x2C
		public List<ChildData> childSet; // 0x30

		// Constructors
		public TableData() {} // 0x0000000182D9DE30-0x0000000182D9DE90
	}

	private class ChildData : LuaGCObjectUtil.LuaData // TypeDefIndex: 27727
	{
		// Fields
		public RelationshipType relationshipType; // 0x28
		public string key; // 0x30
		public int index; // 0x38
		public string upvalueKey; // 0x40

		// Constructors
		public ChildData() {} // 0x0000000182DBD730-0x0000000182DBD790
	}

	// Constructors
	public LuaDebugMonitor() {} // 0x0000000182DAC630-0x0000000182DAC690
	static LuaDebugMonitor() {} // 0x0000000182DAC560-0x0000000182DAC630

	// Methods
	// [MonoPInvokeCallback] // 0x000000018985B000-0x000000018985B060
	// [XID] // 0x000000018985B000-0x000000018985B060
	private static void ReportTableSizeCallback(IntPtr p, int length) {} // 0x0000000182DAAF00-0x0000000182DAB080
	// [XID] // 0x0000000189869950-0x0000000189869970
	private static void GenerateTable(LuaEnv env) {} // 0x0000000182DAB270-0x0000000182DAB420
	// [MonoPInvokeCallback] // 0x0000000189870BB0-0x0000000189870C10
	// [XID] // 0x0000000189870BB0-0x0000000189870C10
	private static void ReportObjectRelationShip(IntPtr parent, IntPtr child, RelationshipType type, string key, double d, string key2) {} // 0x0000000182DABC30-0x0000000182DAC090
	// [XID] // 0x000000018987FBB0-0x000000018987FBD0
	private static void GenerateRelationship(LuaEnv env) {} // 0x0000000182DAC090-0x0000000182DAC2C0
	// [XID] // 0x00000001898871C0-0x00000001898871E0
	private TableData GetGlobal(IntPtr ptr) => default; // 0x0000000182DAB080-0x0000000182DAB190
	// [IDTag] // 0x000000018988E350-0x000000018988E390
	// [XID] // 0x000000018988E350-0x000000018988E390
	private static void GenerateLuaData(LuaEnv env, TableData data) {} // 0x0000000182DAABE0-0x0000000182DAACC0
	// [IDTag] // 0x0000000189898CC0-0x0000000189898D00
	// [XID] // 0x0000000189898CC0-0x0000000189898D00
	private static LuaGCObjectUtil.LuaData GenerateLuaData(LuaEnv env, IntPtr address) => default; // 0x0000000182DAA840-0x0000000182DAA920
	// [IDTag] // 0x00000001898A30D0-0x00000001898A3110
	// [XID] // 0x00000001898A30D0-0x00000001898A3110
	private static void GenerateLuaData(LuaEnv env) {} // 0x0000000182DAA920-0x0000000182DAABE0
	// [IDTag] // 0x00000001898AD8C0-0x00000001898AD900
	// [XID] // 0x00000001898AD8C0-0x00000001898AD900
	private static void GenerateDetail(LuaEnv env, bool gc) {} // 0x0000000182DAC400-0x0000000182DAC560
	// [XID] // 0x00000001898B7F90-0x00000001898B7FB0
	public static void LuaGC() {} // 0x0000000182DAB190-0x0000000182DAB270
	// [IDTag] // 0x00000001898BF6C0-0x00000001898BF700
	// [XID] // 0x00000001898BF6C0-0x00000001898BF700
	public static bool GenerateDetail(bool gc) => default; // 0x0000000182DAC2C0-0x0000000182DAC400
	// [XID] // 0x00000001898CA060-0x00000001898CA080
	private static string FormatString(string value) => default; // 0x0000000182DAACC0-0x0000000182DAAF00
	// [XID] // 0x00000001898D17C0-0x00000001898D17E0
	public static void AddLuaDetail(StringBuilder buffer, bool gc) {} // 0x0000000182DAB420-0x0000000182DABC30
}

