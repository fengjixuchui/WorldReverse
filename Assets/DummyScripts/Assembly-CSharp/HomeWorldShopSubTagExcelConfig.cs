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
public class HomeWorldShopSubTagExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15722
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 subIDRawNum; // 0x10
	protected uint _subTagTextMapHash; // 0x14

	// Properties
	public uint subID { /* [XID] */ /* 0x000000018971E400-0x000000018971E420 */ get => default; /* [XID] */ /* 0x00000001897259C0-0x00000001897259E0 */ protected set {} } // 0x0000000183C2FBC0-0x0000000183C2FC90 0x0000000183C2FC90-0x0000000183C2FD70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint subTagTextMapHash { /* [XID] */ /* 0x000000018972CF80-0x000000018972CFA0 */ get => default; /* [XID] */ /* 0x00000001897346D0-0x00000001897346F0 */ protected set {} } // 0x0000000183C2F9A0-0x0000000183C2FA40 0x0000000183C300D0-0x0000000183C30180
	public string subTag { /* [XID] */ /* 0x000000018973C080-0x000000018973C0A0 */ get => default; } // 0x0000000183C2FA40-0x0000000183C2FBC0 

	// Constructors
	public HomeWorldShopSubTagExcelConfig() {} // 0x0000000183C30360-0x0000000183C303C0

	// Methods
	// [IDTag] // 0x0000000189743830-0x0000000189743870
	// [XID] // 0x0000000189743830-0x0000000189743870
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183C2F730-0x0000000183C2F9A0
	// [IDTag] // 0x000000018974E270-0x000000018974E2B0
	// [XID] // 0x000000018974E270-0x000000018974E2B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183C2F510-0x0000000183C2F730
	// [XID] // 0x0000000189758410-0x0000000189758430
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF243B */, bool useObjectPool = false /* Metadata: 0x00AF243F */) => default; // 0x0000000183C2FD70-0x0000000183C300D0
	[BlackList] // 0x000000018975FE50-0x000000018975FE90
	// [XID] // 0x000000018975FE50-0x000000018975FE90
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C2F3A0-0x0000000183C2F440
	[BlackList] // 0x000000018976A370-0x000000018976A3B0
	// [XID] // 0x000000018976A370-0x000000018976A3B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C2F440-0x0000000183C2F510
	[BlackList] // 0x0000000189774790-0x00000001897747D0
	// [XID] // 0x0000000189774790-0x00000001897747D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183C302C0-0x0000000183C30360
	[BlackList] // 0x000000018977EFE0-0x000000018977F020
	// [XID] // 0x000000018977EFE0-0x000000018977F020
	public virtual void OnPoolAllocated() {} // 0x0000000183C30220-0x0000000183C302C0
	[BlackList] // 0x00000001897897C0-0x0000000189789800
	// [XID] // 0x00000001897897C0-0x0000000189789800
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C30180-0x0000000183C30220
}

