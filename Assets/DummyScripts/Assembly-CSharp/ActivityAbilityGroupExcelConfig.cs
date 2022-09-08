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
public class ActivityAbilityGroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15001
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 indexRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x18
	protected SimpleSafeUInt32 weaponIdRawNum; // 0x1C
	protected uint _nameTextMapHash; // 0x20

	// Properties
	public uint index { /* [XID] */ /* 0x00000001898B3FC0-0x00000001898B3FE0 */ get => default; /* [XID] */ /* 0x00000001898BBCD0-0x00000001898BBCF0 */ protected set {} } // 0x0000000181FF73B0-0x0000000181FF7480 0x0000000181FF79D0-0x0000000181FF7AB0
	public uint activityId { /* [XID] */ /* 0x00000001898C3220-0x00000001898C3240 */ get => default; /* [XID] */ /* 0x00000001898CAC20-0x00000001898CAC40 */ protected set {} } // 0x0000000181FF7B60-0x0000000181FF7C30 0x0000000181FF72D0-0x0000000181FF73B0
	public uint avatarId { /* [XID] */ /* 0x00000001898D22B0-0x00000001898D22D0 */ get => default; /* [XID] */ /* 0x00000001898D9B10-0x00000001898D9B30 */ protected set {} } // 0x0000000181FF7120-0x0000000181FF71F0 0x0000000181FF6680-0x0000000181FF6760
	public uint weaponId { /* [XID] */ /* 0x00000001898E1770-0x00000001898E1790 */ get => default; /* [XID] */ /* 0x00000001898E92C0-0x00000001898E92E0 */ protected set {} } // 0x0000000181FF7D70-0x0000000181FF7E40 0x0000000181FF71F0-0x0000000181FF72D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001898F0A60-0x00000001898F0A80 */ get => default; /* [XID] */ /* 0x00000001898F8390-0x00000001898F83B0 */ protected set {} } // 0x0000000181FF6910-0x0000000181FF69B0 0x0000000181FF7AB0-0x0000000181FF7B60
	public string name { /* [XID] */ /* 0x00000001898FFA70-0x00000001898FFA90 */ get => default; } // 0x0000000181FF7E40-0x0000000181FF7FC0 

	// Constructors
	public ActivityAbilityGroupExcelConfig() {} // 0x0000000181FF8060-0x0000000181FF80C0

	// Methods
	// [IDTag] // 0x0000000189907250-0x0000000189907290
	// [XID] // 0x0000000189907250-0x0000000189907290
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181FF69B0-0x0000000181FF6D80
	// [IDTag] // 0x0000000189911A20-0x0000000189911A60
	// [XID] // 0x0000000189911A20-0x0000000189911A60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181FF6D80-0x0000000181FF7120
	// [XID] // 0x000000018991C760-0x000000018991C780
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE1B */, bool useObjectPool = false /* Metadata: 0x00AEFE1F */) => default; // 0x0000000181FF7480-0x0000000181FF79D0
	[BlackList] // 0x0000000189923EC0-0x0000000189923F00
	// [XID] // 0x0000000189923EC0-0x0000000189923F00
	public virtual void AutoAllocTypeFields() {} // 0x0000000181FF6760-0x0000000181FF6800
	[BlackList] // 0x000000018992E490-0x000000018992E4D0
	// [XID] // 0x000000018992E490-0x000000018992E4D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181FF6800-0x0000000181FF6910
	[BlackList] // 0x00000001899387B0-0x00000001899387F0
	// [XID] // 0x00000001899387B0-0x00000001899387F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181FF7FC0-0x0000000181FF8060
	[BlackList] // 0x0000000189942E70-0x0000000189942EB0
	// [XID] // 0x0000000189942E70-0x0000000189942EB0
	public virtual void OnPoolAllocated() {} // 0x0000000181FF7CD0-0x0000000181FF7D70
	[BlackList] // 0x000000018994D6B0-0x000000018994D6F0
	// [XID] // 0x000000018994D6B0-0x000000018994D6F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181FF7C30-0x0000000181FF7CD0
}

