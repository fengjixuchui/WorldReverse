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
public class NewActivitySaleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15896
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected NewActivitySaleType _saleType; // 0x14
	protected string[] _saleParam; // 0x18
	protected uint _bufftipsTextMapHash; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B41E10-0x0000000189B41E30 */ get => default; /* [XID] */ /* 0x0000000189B49780-0x0000000189B497A0 */ protected set {} } // 0x0000000184B525B0-0x0000000184B52680 0x0000000184B51C10-0x0000000184B51CF0
	public NewActivitySaleType saleType { /* [XID] */ /* 0x0000000189B50E00-0x0000000189B50E20 */ get => default; /* [XID] */ /* 0x0000000189B585D0-0x0000000189B585F0 */ protected set {} } // 0x0000000184B523D0-0x0000000184B52470 0x0000000184B51CF0-0x0000000184B51DA0
	public string[] saleParam { /* [XID] */ /* 0x0000000189B5FFC0-0x0000000189B5FFE0 */ get => default; /* [XID] */ /* 0x0000000189B676C0-0x0000000189B676E0 */ protected set {} } // 0x0000000184B51B70-0x0000000184B51C10 0x0000000184B51AC0-0x0000000184B51B70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint bufftipsTextMapHash { /* [XID] */ /* 0x0000000189B6E8C0-0x0000000189B6E8E0 */ get => default; /* [XID] */ /* 0x0000000189B76170-0x0000000189B76190 */ protected set {} } // 0x0000000184B51180-0x0000000184B51220 0x0000000184B50F50-0x0000000184B51000
	public string bufftips { /* [XID] */ /* 0x0000000189B7D6A0-0x0000000189B7D6C0 */ get => default; } // 0x0000000184B52250-0x0000000184B523D0 

	// Constructors
	public NewActivitySaleExcelConfig() {} // 0x0000000184B52720-0x0000000184B52780

	// Methods
	// [IDTag] // 0x0000000189B85410-0x0000000189B85450
	// [XID] // 0x0000000189B85410-0x0000000189B85450
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B51640-0x0000000184B51AC0
	// [IDTag] // 0x0000000189B8F250-0x0000000189B8F290
	// [XID] // 0x0000000189B8F250-0x0000000189B8F290
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B51220-0x0000000184B51640
	// [XID] // 0x0000000189B996C0-0x0000000189B996E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A87 */, bool useObjectPool = false /* Metadata: 0x00AF2A8B */) => default; // 0x0000000184B51DA0-0x0000000184B52250
	[BlackList] // 0x0000000189BA0CD0-0x0000000189BA0D10
	// [XID] // 0x0000000189BA0CD0-0x0000000189BA0D10
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B51000-0x0000000184B510A0
	[BlackList] // 0x0000000189BAB2E0-0x0000000189BAB320
	// [XID] // 0x0000000189BAB2E0-0x0000000189BAB320
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B510A0-0x0000000184B51180
	[BlackList] // 0x0000000189BB5670-0x0000000189BB56B0
	// [XID] // 0x0000000189BB5670-0x0000000189BB56B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B52680-0x0000000184B52720
	[BlackList] // 0x0000000189BBFDD0-0x0000000189BBFE10
	// [XID] // 0x0000000189BBFDD0-0x0000000189BBFE10
	public virtual void OnPoolAllocated() {} // 0x0000000184B52510-0x0000000184B525B0
	[BlackList] // 0x0000000189BCAD30-0x0000000189BCAD70
	// [XID] // 0x0000000189BCAD30-0x0000000189BCAD70
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B52470-0x0000000184B52510
}

