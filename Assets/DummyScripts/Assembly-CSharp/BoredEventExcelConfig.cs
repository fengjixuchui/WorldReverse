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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BoredEventExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15285
{
	// Fields
	protected BoardEventType _event_type; // 0x10
	protected SimpleSafeUInt32 paramRawNum; // 0x14
	protected bool _is_enable; // 0x18
	protected SimpleSafeInt32 add_boredRawNum; // 0x1C
	protected SimpleSafeInt32 max_boredRawNum; // 0x20

	// Properties
	public BoardEventType event_type { /* [XID] */ /* 0x00000001897CC7F0-0x00000001897CC810 */ get => default; /* [XID] */ /* 0x00000001897D4040-0x00000001897D4060 */ protected set {} } // 0x00000001846C6CE0-0x00000001846C6D80 0x00000001846C6B90-0x00000001846C6C40
	public uint param { /* [XID] */ /* 0x00000001897DB950-0x00000001897DB970 */ get => default; /* [XID] */ /* 0x00000001897E31E0-0x00000001897E3200 */ protected set {} } // 0x00000001846C7780-0x00000001846C7850 0x00000001846C75D0-0x00000001846C76B0
	public bool is_enable { /* [XID] */ /* 0x00000001897EA940-0x00000001897EA960 */ get => default; /* [XID] */ /* 0x00000001897F2710-0x00000001897F2730 */ protected set {} } // 0x00000001846C6C40-0x00000001846C6CE0 0x00000001846C60C0-0x00000001846C6170
	public int add_bored { /* [XID] */ /* 0x00000001897F9F00-0x00000001897F9F20 */ get => default; /* [XID] */ /* 0x0000000189801480-0x00000001898014A0 */ protected set {} } // 0x00000001846C76B0-0x00000001846C7780 0x00000001846C72D0-0x00000001846C73B0
	public int max_bored { /* [XID] */ /* 0x00000001898088A0-0x00000001898088C0 */ get => default; /* [XID] */ /* 0x0000000189810290-0x00000001898102B0 */ protected set {} } // 0x00000001846C6AC0-0x00000001846C6B90 0x00000001846C73B0-0x00000001846C7490

	// Constructors
	public BoredEventExcelConfig() {} // 0x00000001846C78F0-0x00000001846C7950

	// Methods
	// [IDTag] // 0x0000000189817920-0x0000000189817960
	// [XID] // 0x0000000189817920-0x0000000189817960
	public virtual bool ParseFromLine(string line) => default; // 0x00000001846C6330-0x00000001846C6710
	// [IDTag] // 0x0000000189822290-0x00000001898222D0
	// [XID] // 0x0000000189822290-0x00000001898222D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001846C6710-0x00000001846C6AC0
	// [XID] // 0x000000018982C890-0x000000018982C8B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF065B */, bool useObjectPool = false /* Metadata: 0x00AF065F */) => default; // 0x00000001846C6D80-0x00000001846C72D0
	[BlackList] // 0x0000000189833E00-0x0000000189833E40
	// [XID] // 0x0000000189833E00-0x0000000189833E40
	public virtual void AutoAllocTypeFields() {} // 0x00000001846C6170-0x00000001846C6210
	[BlackList] // 0x000000018983E240-0x000000018983E280
	// [XID] // 0x000000018983E240-0x000000018983E280
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846C6210-0x00000001846C6330
	[BlackList] // 0x00000001898484E0-0x0000000189848520
	// [XID] // 0x00000001898484E0-0x0000000189848520
	public virtual void ReturnToObjectPool() {} // 0x00000001846C7850-0x00000001846C78F0
	[BlackList] // 0x0000000189852820-0x0000000189852860
	// [XID] // 0x0000000189852820-0x0000000189852860
	public virtual void OnPoolAllocated() {} // 0x00000001846C7530-0x00000001846C75D0
	[BlackList] // 0x000000018985CCB0-0x000000018985CCF0
	// [XID] // 0x000000018985CCB0-0x000000018985CCF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846C7490-0x00000001846C7530
}

