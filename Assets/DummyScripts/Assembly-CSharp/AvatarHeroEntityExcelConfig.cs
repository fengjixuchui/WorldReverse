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
public class AvatarHeroEntityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15214
{
	// Fields
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x10
	protected byte _prefabPathHashPre; // 0x14
	protected uint _prefabPathHashSuffix; // 0x18

	// Properties
	public uint avatarId { /* [XID] */ /* 0x0000000189935730-0x0000000189935750 */ get => default; /* [XID] */ /* 0x000000018993D250-0x000000018993D270 */ protected set {} } // 0x00000001832D50E0-0x00000001832D51B0 0x00000001832D4830-0x00000001832D4910
	public byte prefabPathHashPre { /* [XID] */ /* 0x0000000189944960-0x0000000189944980 */ get => default; /* [XID] */ /* 0x000000018994BF00-0x000000018994BF20 */ protected set {} } // 0x00000001832D4A90-0x00000001832D4B30 0x00000001832D5030-0x00000001832D50E0
	public uint prefabPathHashSuffix { /* [XID] */ /* 0x00000001899535B0-0x00000001899535D0 */ get => default; /* [XID] */ /* 0x000000018995AD70-0x000000018995AD90 */ protected set {} } // 0x00000001832D5640-0x00000001832D56E0 0x00000001832D5820-0x00000001832D58D0
	public ulong prefabPathHash { /* [XID] */ /* 0x0000000189962970-0x0000000189962990 */ get => default; } // 0x00000001832D51B0-0x00000001832D5280 

	// Constructors
	public AvatarHeroEntityExcelConfig() {} // 0x00000001832D5970-0x00000001832D59D0

	// Methods
	// [IDTag] // 0x0000000189969D40-0x0000000189969D80
	// [XID] // 0x0000000189969D40-0x0000000189969D80
	public virtual bool ParseFromLine(string line) => default; // 0x00000001832D4B30-0x00000001832D4DD0
	// [IDTag] // 0x00000001899746B0-0x00000001899746F0
	// [XID] // 0x00000001899746B0-0x00000001899746F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001832D4DD0-0x00000001832D5030
	// [XID] // 0x000000018997EB00-0x000000018997EB20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0407 */, bool useObjectPool = false /* Metadata: 0x00AF040B */) => default; // 0x00000001832D5280-0x00000001832D5640
	[BlackList] // 0x0000000189986430-0x0000000189986470
	// [XID] // 0x0000000189986430-0x0000000189986470
	public virtual void AutoAllocTypeFields() {} // 0x00000001832D4910-0x00000001832D49B0
	[BlackList] // 0x0000000189991210-0x0000000189991250
	// [XID] // 0x0000000189991210-0x0000000189991250
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832D49B0-0x00000001832D4A90
	[BlackList] // 0x000000018999BD60-0x000000018999BDA0
	// [XID] // 0x000000018999BD60-0x000000018999BDA0
	public virtual void ReturnToObjectPool() {} // 0x00000001832D58D0-0x00000001832D5970
	[BlackList] // 0x00000001899A6710-0x00000001899A6750
	// [XID] // 0x00000001899A6710-0x00000001899A6750
	public virtual void OnPoolAllocated() {} // 0x00000001832D5780-0x00000001832D5820
	[BlackList] // 0x00000001899B11B0-0x00000001899B11F0
	// [XID] // 0x00000001899B11B0-0x00000001899B11F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832D56E0-0x00000001832D5780
}

