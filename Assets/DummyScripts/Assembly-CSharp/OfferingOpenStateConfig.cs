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
public class OfferingOpenStateConfig : IAutoAllocRecycle // TypeDefIndex: 15920
{
	// Fields
	protected SimpleSafeUInt32 offeringIdRawNum; // 0x10
	protected OpenStateType _openState; // 0x14
	protected ItemLimitType _itemLimit; // 0x18

	// Properties
	public uint offeringId { /* [XID] */ /* 0x0000000189B43530-0x0000000189B43550 */ get => default; /* [XID] */ /* 0x0000000189B4ACF0-0x0000000189B4AD10 */ protected set {} } // 0x00000001830E7A70-0x00000001830E7B40 0x00000001830E87F0-0x00000001830E88D0
	public OpenStateType openState { /* [XID] */ /* 0x0000000189B52340-0x0000000189B52360 */ get => default; /* [XID] */ /* 0x0000000189B59CC0-0x0000000189B59CE0 */ protected set {} } // 0x00000001830E7CB0-0x00000001830E7D50 0x00000001830E8970-0x00000001830E8A20
	public ItemLimitType itemLimit { /* [XID] */ /* 0x0000000189B613D0-0x0000000189B613F0 */ get => default; /* [XID] */ /* 0x0000000189B68E60-0x0000000189B68E80 */ protected set {} } // 0x00000001830E88D0-0x00000001830E8970 0x00000001830E8330-0x00000001830E83E0

	// Constructors
	public OfferingOpenStateConfig() {} // 0x00000001830E8C00-0x00000001830E8C60

	// Methods
	// [IDTag] // 0x0000000189B702A0-0x0000000189B702E0
	// [XID] // 0x0000000189B702A0-0x0000000189B702E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001830E8020-0x00000001830E8330
	// [IDTag] // 0x0000000189B7A730-0x0000000189B7A770
	// [XID] // 0x0000000189B7A730-0x0000000189B7A770
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001830E7D50-0x00000001830E8020
	// [XID] // 0x0000000189B853D0-0x0000000189B853F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B34 */, bool useObjectPool = false /* Metadata: 0x00AF2B38 */) => default; // 0x00000001830E83E0-0x00000001830E87F0
	[BlackList] // 0x0000000189B8C1E0-0x0000000189B8C220
	// [XID] // 0x0000000189B8C1E0-0x0000000189B8C220
	public virtual void AutoAllocTypeFields() {} // 0x00000001830E7B40-0x00000001830E7BE0
	[BlackList] // 0x0000000189B96720-0x0000000189B96760
	// [XID] // 0x0000000189B96720-0x0000000189B96760
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830E7BE0-0x00000001830E7CB0
	[BlackList] // 0x0000000189BA0C90-0x0000000189BA0CD0
	// [XID] // 0x0000000189BA0C90-0x0000000189BA0CD0
	public virtual void ReturnToObjectPool() {} // 0x00000001830E8B60-0x00000001830E8C00
	[BlackList] // 0x0000000189BAB2A0-0x0000000189BAB2E0
	// [XID] // 0x0000000189BAB2A0-0x0000000189BAB2E0
	public virtual void OnPoolAllocated() {} // 0x00000001830E8AC0-0x00000001830E8B60
	[BlackList] // 0x0000000189BB5630-0x0000000189BB5670
	// [XID] // 0x0000000189BB5630-0x0000000189BB5670
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830E8A20-0x00000001830E8AC0
}

