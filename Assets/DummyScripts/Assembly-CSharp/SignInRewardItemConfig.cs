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
public class SignInRewardItemConfig : IAutoAllocRecycle // TypeDefIndex: 16160
{
	// Fields
	protected SimpleSafeUInt32 itemIdRawNum; // 0x10
	protected SimpleSafeUInt32 countRawNum; // 0x14
	protected SimpleSafeUInt32 qualityRawNum; // 0x18

	// Properties
	public uint itemId { /* [XID] */ /* 0x0000000189960CA0-0x0000000189960CC0 */ get => default; /* [XID] */ /* 0x0000000189968460-0x0000000189968480 */ protected set {} } // 0x00000001829C4A90-0x00000001829C4B60 0x00000001829C4E00-0x00000001829C4EE0
	public uint count { /* [XID] */ /* 0x000000018996F940-0x000000018996F960 */ get => default; /* [XID] */ /* 0x00000001899776E0-0x0000000189977700 */ protected set {} } // 0x00000001829C54A0-0x00000001829C5570 0x00000001829C4FB0-0x00000001829C5090
	public uint quality { /* [XID] */ /* 0x000000018997E980-0x000000018997E9A0 */ get => default; /* [XID] */ /* 0x0000000189986310-0x0000000189986330 */ protected set {} } // 0x00000001829C4EE0-0x00000001829C4FB0 0x00000001829C56B0-0x00000001829C5790

	// Constructors
	public SignInRewardItemConfig() {} // 0x00000001829C5830-0x00000001829C5890

	// Methods
	// [XID] // 0x000000018998DEE0-0x000000018998DF00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829C4B60-0x00000001829C4E00
	// [XID] // 0x0000000189995A50-0x0000000189995A70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32E5 */, bool useObjectPool = false /* Metadata: 0x00AF32E9 */) => default; // 0x00000001829C5090-0x00000001829C54A0
	[BlackList] // 0x000000018999D350-0x000000018999D390
	// [XID] // 0x000000018999D350-0x000000018999D390
	public virtual void AutoAllocTypeFields() {} // 0x00000001829C4900-0x00000001829C49A0
	[BlackList] // 0x00000001899A7FE0-0x00000001899A8020
	// [XID] // 0x00000001899A7FE0-0x00000001899A8020
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829C49A0-0x00000001829C4A90
	[BlackList] // 0x00000001899B2910-0x00000001899B2950
	// [XID] // 0x00000001899B2910-0x00000001899B2950
	public virtual void ReturnToObjectPool() {} // 0x00000001829C5790-0x00000001829C5830
	[BlackList] // 0x00000001899BCD70-0x00000001899BCDB0
	// [XID] // 0x00000001899BCD70-0x00000001899BCDB0
	public virtual void OnPoolAllocated() {} // 0x00000001829C5610-0x00000001829C56B0
	[BlackList] // 0x00000001899C75D0-0x00000001899C7610
	// [XID] // 0x00000001899C75D0-0x00000001899C7610
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829C5570-0x00000001829C5610
}

