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
public class WorldAreaLevelupConsumeItem : IAutoAllocRecycle // TypeDefIndex: 16300
{
	// Fields
	protected SimpleSafeUInt32 item_idRawNum; // 0x10
	protected SimpleSafeUInt32 item_numRawNum; // 0x14

	// Properties
	public uint item_id { /* [XID] */ /* 0x00000001897E9010-0x00000001897E9030 */ get => default; /* [XID] */ /* 0x00000001897F0BE0-0x00000001897F0C00 */ protected set {} } // 0x0000000183776CF0-0x0000000183776DC0 0x0000000183776B40-0x0000000183776C20
	public uint item_num { /* [XID] */ /* 0x00000001897F83C0-0x00000001897F83E0 */ get => default; /* [XID] */ /* 0x00000001897FFB30-0x00000001897FFB50 */ protected set {} } // 0x0000000183776C20-0x0000000183776CF0 0x00000001837764E0-0x00000001837765C0

	// Constructors
	public WorldAreaLevelupConsumeItem() {} // 0x0000000183776FA0-0x0000000183777000

	// Methods
	// [XID] // 0x00000001898071B0-0x00000001898071D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001837765C0-0x00000001837767E0
	// [XID] // 0x000000018980E770-0x000000018980E790
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF36FC */, bool useObjectPool = false /* Metadata: 0x00AF3700 */) => default; // 0x00000001837767E0-0x0000000183776B40
	[BlackList] // 0x0000000189815F10-0x0000000189815F50
	// [XID] // 0x0000000189815F10-0x0000000189815F50
	public virtual void AutoAllocTypeFields() {} // 0x0000000183776360-0x0000000183776400
	[BlackList] // 0x0000000189820AD0-0x0000000189820B10
	// [XID] // 0x0000000189820AD0-0x0000000189820B10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183776400-0x00000001837764E0
	[BlackList] // 0x000000018982AEB0-0x000000018982AEF0
	// [XID] // 0x000000018982AEB0-0x000000018982AEF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183776F00-0x0000000183776FA0
	[BlackList] // 0x0000000189835350-0x0000000189835390
	// [XID] // 0x0000000189835350-0x0000000189835390
	public virtual void OnPoolAllocated() {} // 0x0000000183776E60-0x0000000183776F00
	[BlackList] // 0x000000018983F9F0-0x000000018983FA30
	// [XID] // 0x000000018983F9F0-0x000000018983FA30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183776DC0-0x0000000183776E60
}

