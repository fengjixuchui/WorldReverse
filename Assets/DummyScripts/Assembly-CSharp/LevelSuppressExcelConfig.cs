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
public class LevelSuppressExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15784
{
	// Fields
	protected SimpleSafeInt32 levelRawNum; // 0x10
	protected SimpleSafeFloat levelSuppressDamageCoRawNum; // 0x14
	protected SimpleSafeFloat levelSuppressEndureRawNum; // 0x18
	protected SimpleSafeFloat levelSuppressDisMinHorizontalRawNum; // 0x1C
	protected SimpleSafeFloat levelSuppressDisMaxHorizontalRawNum; // 0x20
	protected SimpleSafeFloat levelSuppressDisMinVerticalRawNum; // 0x24
	protected SimpleSafeFloat levelSuppressDisMaxVerticalRawNum; // 0x28
	protected bool _isAttackerPlayer; // 0x2C
	protected bool _isDefenserPlayer; // 0x2D

	// Properties
	public int level { /* [XID] */ /* 0x0000000189AFEED0-0x0000000189AFEEF0 */ get => default; /* [XID] */ /* 0x0000000189B06740-0x0000000189B06760 */ protected set {} } // 0x00000001840A9B20-0x00000001840A9BF0 0x00000001840A9A40-0x00000001840A9B20
	public float levelSuppressDamageCo { /* [XID] */ /* 0x0000000189B0DE70-0x0000000189B0DE90 */ get => default; /* [XID] */ /* 0x0000000189B151F0-0x0000000189B15210 */ protected set {} } // 0x00000001840A80A0-0x00000001840A8180 0x00000001840A7C30-0x00000001840A7D10
	public float levelSuppressEndure { /* [XID] */ /* 0x0000000189B1CC30-0x0000000189B1CC50 */ get => default; /* [XID] */ /* 0x0000000189B241C0-0x0000000189B241E0 */ protected set {} } // 0x00000001840A8260-0x00000001840A8340 0x00000001840A7D10-0x00000001840A7DF0
	public float levelSuppressDisMinHorizontal { /* [XID] */ /* 0x0000000189B2B590-0x0000000189B2B5B0 */ get => default; /* [XID] */ /* 0x0000000189B32AE0-0x0000000189B32B00 */ protected set {} } // 0x00000001840A9CD0-0x00000001840A9DB0 0x00000001840A8E50-0x00000001840A8F30
	public float levelSuppressDisMaxHorizontal { /* [XID] */ /* 0x0000000189B3A410-0x0000000189B3A430 */ get => default; /* [XID] */ /* 0x0000000189B41E50-0x0000000189B41E70 */ protected set {} } // 0x00000001840A9BF0-0x00000001840A9CD0 0x00000001840A9010-0x00000001840A90F0
	public float levelSuppressDisMinVertical { /* [XID] */ /* 0x0000000189B49800-0x0000000189B49820 */ get => default; /* [XID] */ /* 0x0000000189B50E80-0x0000000189B50EA0 */ protected set {} } // 0x00000001840A8F30-0x00000001840A9010 0x00000001840A9DB0-0x00000001840A9E90
	public float levelSuppressDisMaxVertical { /* [XID] */ /* 0x0000000189B58650-0x0000000189B58670 */ get => default; /* [XID] */ /* 0x0000000189B60040-0x0000000189B60060 */ protected set {} } // 0x00000001840A8180-0x00000001840A8260 0x00000001840A9E90-0x00000001840A9F70
	public bool isAttackerPlayer { /* [XID] */ /* 0x0000000189B67700-0x0000000189B67720 */ get => default; /* [XID] */ /* 0x0000000189B6E920-0x0000000189B6E940 */ protected set {} } // 0x00000001840A90F0-0x00000001840A9190 0x00000001840A9190-0x00000001840A9240
	public bool isDefenserPlayer { /* [XID] */ /* 0x0000000189B761F0-0x0000000189B76210 */ get => default; /* [XID] */ /* 0x0000000189B7D700-0x0000000189B7D720 */ protected set {} } // 0x00000001840A8000-0x00000001840A80A0 0x00000001840AA0B0-0x00000001840AA160

	// Constructors
	public LevelSuppressExcelConfig() {} // 0x00000001840AA200-0x00000001840AA260

	// Methods
	// [IDTag] // 0x0000000189B85450-0x0000000189B85490
	// [XID] // 0x0000000189B85450-0x0000000189B85490
	public virtual bool ParseFromLine(string line) => default; // 0x00000001840A8340-0x00000001840A88D0
	// [IDTag] // 0x0000000189B8F2F0-0x0000000189B8F330
	// [XID] // 0x0000000189B8F2F0-0x0000000189B8F330
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001840A88D0-0x00000001840A8E50
	// [XID] // 0x0000000189B99760-0x0000000189B99780
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF25E8 */, bool useObjectPool = false /* Metadata: 0x00AF25EC */) => default; // 0x00000001840A9240-0x00000001840A9A40
	[BlackList] // 0x0000000189BA0D50-0x0000000189BA0D90
	// [XID] // 0x0000000189BA0D50-0x0000000189BA0D90
	public virtual void AutoAllocTypeFields() {} // 0x00000001840A7DF0-0x00000001840A7E90
	[BlackList] // 0x0000000189BAB340-0x0000000189BAB380
	// [XID] // 0x0000000189BAB340-0x0000000189BAB380
	public virtual void AutoRecycleTypeFields() {} // 0x00000001840A7E90-0x00000001840A8000
	[BlackList] // 0x0000000189BB5710-0x0000000189BB5750
	// [XID] // 0x0000000189BB5710-0x0000000189BB5750
	public virtual void ReturnToObjectPool() {} // 0x00000001840AA160-0x00000001840AA200
	[BlackList] // 0x0000000189BBFE10-0x0000000189BBFE50
	// [XID] // 0x0000000189BBFE10-0x0000000189BBFE50
	public virtual void OnPoolAllocated() {} // 0x00000001840AA010-0x00000001840AA0B0
	[BlackList] // 0x0000000189BCAD70-0x0000000189BCADB0
	// [XID] // 0x0000000189BCAD70-0x0000000189BCADB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840A9F70-0x00000001840AA010
}

