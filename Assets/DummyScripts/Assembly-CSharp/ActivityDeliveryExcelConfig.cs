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
public class ActivityDeliveryExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15054
{
	// Fields
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _dailyConfigIdList; // 0x18
	protected SimpleSafeUInt32 needPlayerLevelRawNum; // 0x20

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x00000001898D5350-0x00000001898D5370 */ get => default; /* [XID] */ /* 0x00000001898DCC30-0x00000001898DCC50 */ protected set {} } // 0x00000001818EFFB0-0x00000001818F0080 0x00000001818F0F50-0x00000001818F1030
	public SimpleSafeUInt32[] dailyConfigIdList { /* [XID] */ /* 0x00000001898E4660-0x00000001898E4680 */ get => default; /* [XID] */ /* 0x00000001898EC0B0-0x00000001898EC0D0 */ protected set {} } // 0x00000001818F0080-0x00000001818F0120 0x00000001818F1030-0x00000001818F10E0
	public uint needPlayerLevel { /* [XID] */ /* 0x00000001898F38E0-0x00000001898F3900 */ get => default; /* [XID] */ /* 0x00000001898FB020-0x00000001898FB040 */ protected set {} } // 0x00000001818F10E0-0x00000001818F11B0 0x00000001818F0A60-0x00000001818F0B40

	// Constructors
	public ActivityDeliveryExcelConfig() {} // 0x00000001818F1390-0x00000001818F13F0

	// Methods
	// [IDTag] // 0x0000000189902B00-0x0000000189902B40
	// [XID] // 0x0000000189902B00-0x0000000189902B40
	public virtual bool ParseFromLine(string line) => default; // 0x00000001818F02B0-0x00000001818F06B0
	// [IDTag] // 0x000000018990D330-0x000000018990D370
	// [XID] // 0x000000018990D330-0x000000018990D370
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001818F06B0-0x00000001818F0A60
	// [XID] // 0x0000000189917D00-0x0000000189917D20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF87 */, bool useObjectPool = false /* Metadata: 0x00AEFF8B */) => default; // 0x00000001818F0B40-0x00000001818F0F50
	[BlackList] // 0x000000018991F220-0x000000018991F260
	// [XID] // 0x000000018991F220-0x000000018991F260
	public virtual void AutoAllocTypeFields() {} // 0x00000001818F0120-0x00000001818F01C0
	[BlackList] // 0x0000000189929C00-0x0000000189929C40
	// [XID] // 0x0000000189929C00-0x0000000189929C40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001818F01C0-0x00000001818F02B0
	[BlackList] // 0x0000000189934040-0x0000000189934080
	// [XID] // 0x0000000189934040-0x0000000189934080
	public virtual void ReturnToObjectPool() {} // 0x00000001818F12F0-0x00000001818F1390
	[BlackList] // 0x000000018993EAD0-0x000000018993EB10
	// [XID] // 0x000000018993EAD0-0x000000018993EB10
	public virtual void OnPoolAllocated() {} // 0x00000001818F1250-0x00000001818F12F0
	[BlackList] // 0x0000000189949100-0x0000000189949140
	// [XID] // 0x0000000189949100-0x0000000189949140
	public virtual void OnBeforePoolRecycled() {} // 0x00000001818F11B0-0x00000001818F1250
}

