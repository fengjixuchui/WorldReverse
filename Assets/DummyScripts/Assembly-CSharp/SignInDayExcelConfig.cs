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
public class SignInDayExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16161
{
	// Fields
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected SimpleSafeUInt32 dayCountRawNum; // 0x14
	protected SimpleSafeUInt32 periodIdRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SignInRewardItemConfig[] _rewardItemList; // 0x20

	// Properties
	public uint configId { /* [XID] */ /* 0x00000001899E0860-0x00000001899E0880 */ get => default; /* [XID] */ /* 0x00000001899E8340-0x00000001899E8360 */ protected set {} } // 0x000000018438E8E0-0x000000018438E9B0 0x000000018438EF30-0x000000018438F010
	public uint dayCount { /* [XID] */ /* 0x00000001899EF950-0x00000001899EF970 */ get => default; /* [XID] */ /* 0x00000001899F7110-0x00000001899F7130 */ protected set {} } // 0x000000018438E9B0-0x000000018438EA80 0x000000018438E690-0x000000018438E770
	public uint periodId { /* [XID] */ /* 0x00000001899FE7F0-0x00000001899FE810 */ get => default; /* [XID] */ /* 0x0000000189A060D0-0x0000000189A060F0 */ protected set {} } // 0x000000018438E770-0x000000018438E840 0x000000018438F010-0x000000018438F0F0
	public SignInRewardItemConfig[] rewardItemList { /* [XID] */ /* 0x0000000189A0D5E0-0x0000000189A0D600 */ get => default; /* [XID] */ /* 0x0000000189A14D20-0x0000000189A14D40 */ protected set {} } // 0x000000018438E840-0x000000018438E8E0 0x000000018438DD50-0x000000018438DE00

	// Constructors
	public SignInDayExcelConfig() {} // 0x000000018438F2D0-0x000000018438F330

	// Methods
	// [IDTag] // 0x0000000189A1BF30-0x0000000189A1BF70
	// [XID] // 0x0000000189A1BF30-0x0000000189A1BF70
	public virtual bool ParseFromLine(string line) => default; // 0x000000018438DE00-0x000000018438E290
	// [IDTag] // 0x0000000189A265A0-0x0000000189A265E0
	// [XID] // 0x0000000189A265A0-0x0000000189A265E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018438E290-0x000000018438E690
	// [XID] // 0x0000000189A30930-0x0000000189A30950
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32EA */, bool useObjectPool = false /* Metadata: 0x00AF32EE */) => default; // 0x000000018438EA80-0x000000018438EF30
	[BlackList] // 0x0000000189A38350-0x0000000189A38390
	// [XID] // 0x0000000189A38350-0x0000000189A38390
	public virtual void AutoAllocTypeFields() {} // 0x000000018438DBB0-0x000000018438DC50
	[BlackList] // 0x0000000189A42AF0-0x0000000189A42B30
	// [XID] // 0x0000000189A42AF0-0x0000000189A42B30
	public virtual void AutoRecycleTypeFields() {} // 0x000000018438DC50-0x000000018438DD50
	[BlackList] // 0x0000000189A4D100-0x0000000189A4D140
	// [XID] // 0x0000000189A4D100-0x0000000189A4D140
	public virtual void ReturnToObjectPool() {} // 0x000000018438F230-0x000000018438F2D0
	[BlackList] // 0x0000000189A57710-0x0000000189A57750
	// [XID] // 0x0000000189A57710-0x0000000189A57750
	public virtual void OnPoolAllocated() {} // 0x000000018438F190-0x000000018438F230
	[BlackList] // 0x0000000189A62010-0x0000000189A62050
	// [XID] // 0x0000000189A62010-0x0000000189A62050
	public virtual void OnBeforePoolRecycled() {} // 0x000000018438F0F0-0x000000018438F190
}

