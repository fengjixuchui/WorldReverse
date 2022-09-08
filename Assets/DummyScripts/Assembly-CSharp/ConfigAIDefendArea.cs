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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAIDefendArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17402
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeFloat defendRangeRawNum; // 0x14

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001897F2330-0x00000001897F2350 */ get => default; /* [XID] */ /* 0x00000001897F99E0-0x00000001897F9A00 */ private set {} } // 0x0000000181FE69A0-0x0000000181FE6A40 0x0000000181FE6E10-0x0000000181FE6EC0
	public float defendRange { /* [XID] */ /* 0x0000000189ADCFF0-0x0000000189ADD010 */ get => default; /* [XID] */ /* 0x00000001898083E0-0x0000000189808400 */ private set {} } // 0x0000000181FE6210-0x0000000181FE62F0 0x0000000181FE62F0-0x0000000181FE63D0

	// Constructors
	public ConfigAIDefendArea() {} // 0x0000000181FE73F0-0x0000000181FE7490

	// Methods
	// [XID] // 0x0000000189905F90-0x0000000189905FB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FE7100-0x0000000181FE7210
	// [XID] // 0x00000001898174E0-0x0000000189817500
	public void InitEmpty() {} // 0x0000000181FE6A40-0x0000000181FE6B10
	[BlackList] // 0x000000018981EEC0-0x000000018981EF00
	// [XID] // 0x000000018981EEC0-0x000000018981EF00
	public bool FromJson(JSONNode node) => default; // 0x0000000181FE6620-0x0000000181FE69A0
	// [XID] // 0x0000000189829390-0x00000001898293B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181FE5B00-0x0000000181FE5DD0
	// [XID] // 0x0000000189830A60-0x0000000189830A80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D5F */, bool useObjectPool = false /* Metadata: 0x00AF6D63 */) => default; // 0x0000000181FE6B10-0x0000000181FE6E10
	// [XID] // 0x0000000189837FE0-0x0000000189838000
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D64 */, bool useObjectPool = false /* Metadata: 0x00AF6D68 */) => default; // 0x0000000181FE63D0-0x0000000181FE6620
	[BlackList] // 0x000000018983F790-0x000000018983F7D0
	// [XID] // 0x000000018983F790-0x000000018983F7D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FE5DD0-0x0000000181FE60A0
	// [XID] // 0x0000000189849AF0-0x0000000189849B10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FE6EC0-0x0000000181FE7100
	[BlackList] // 0x0000000189851250-0x0000000189851290
	// [XID] // 0x0000000189851250-0x0000000189851290
	public virtual void AutoAllocTypeFields() {} // 0x0000000181FE60A0-0x0000000181FE6140
	[BlackList] // 0x000000018985B630-0x000000018985B670
	// [XID] // 0x000000018985B630-0x000000018985B670
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181FE6140-0x0000000181FE6210
	[BlackList] // 0x0000000189865810-0x0000000189865850
	// [XID] // 0x0000000189865810-0x0000000189865850
	public virtual void ReturnToObjectPool() {} // 0x0000000181FE7350-0x0000000181FE73F0
	[BlackList] // 0x000000018986FD00-0x000000018986FD40
	// [XID] // 0x000000018986FD00-0x000000018986FD40
	public virtual void OnPoolAllocated() {} // 0x0000000181FE72B0-0x0000000181FE7350
	[BlackList] // 0x000000018987A8D0-0x000000018987A910
	// [XID] // 0x000000018987A8D0-0x000000018987A910
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181FE7210-0x0000000181FE72B0
}

