/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BookSuitExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15829
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _suitNameTextMapHash; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189992970-0x0000000189992990 */ get => default; /* [XID] */ /* 0x000000018999A6F0-0x000000018999A710 */ protected set {} } // 0x0000000183E6EDA0-0x0000000183E6EE70 0x0000000183E6E780-0x0000000183E6E860
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint suitNameTextMapHash { /* [XID] */ /* 0x00000001899A1DB0-0x00000001899A1DD0 */ get => default; /* [XID] */ /* 0x00000001899A9700-0x00000001899A9720 */ protected set {} } // 0x0000000183E6EBC0-0x0000000183E6EC60 0x0000000183E6E6D0-0x0000000183E6E780
	public string suitName { /* [XID] */ /* 0x00000001899B1110-0x00000001899B1130 */ get => default; } // 0x0000000183E6E550-0x0000000183E6E6D0 

	// Constructors
	public BookSuitExcelConfig() {} // 0x0000000183E6EF10-0x0000000183E6EF70

	// Methods
	// [IDTag] // 0x00000001899B8390-0x00000001899B83D0
	// [XID] // 0x00000001899B8390-0x00000001899B83D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E6E2E0-0x0000000183E6E550
	// [IDTag] // 0x00000001899C3180-0x00000001899C31C0
	// [XID] // 0x00000001899C3180-0x00000001899C31C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E6E0C0-0x0000000183E6E2E0
	// [XID] // 0x00000001899CD6B0-0x00000001899CD6D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF279F */, bool useObjectPool = false /* Metadata: 0x00AF27A3 */) => default; // 0x0000000183E6E860-0x0000000183E6EBC0
	[BlackList] // 0x00000001899D4B30-0x00000001899D4B70
	// [XID] // 0x00000001899D4B30-0x00000001899D4B70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E6DF50-0x0000000183E6DFF0
	[BlackList] // 0x00000001899DEFD0-0x00000001899DF010
	// [XID] // 0x00000001899DEFD0-0x00000001899DF010
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E6DFF0-0x0000000183E6E0C0
	[BlackList] // 0x00000001899E9880-0x00000001899E98C0
	// [XID] // 0x00000001899E9880-0x00000001899E98C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E6EE70-0x0000000183E6EF10
	[BlackList] // 0x00000001899F45F0-0x00000001899F4630
	// [XID] // 0x00000001899F45F0-0x00000001899F4630
	public virtual void OnPoolAllocated() {} // 0x0000000183E6ED00-0x0000000183E6EDA0
	[BlackList] // 0x00000001899FE8B0-0x00000001899FE8F0
	// [XID] // 0x00000001899FE8B0-0x00000001899FE8F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E6EC60-0x0000000183E6ED00
}

