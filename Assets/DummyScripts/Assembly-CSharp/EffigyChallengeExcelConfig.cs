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
public class EffigyChallengeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15075
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 dayIndexRawNum; // 0x14
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x18
	protected string _prefab; // 0x20
	protected uint _titleTextMapHash; // 0x28
	protected uint _contentTextMapHash; // 0x2C
	protected SimpleSafeUInt32[] _limitingConditionVec; // 0x30
	protected SimpleSafeUInt32[] _upAvatarVec; // 0x38
	protected SimpleSafeUInt32 firstPassRewardIdRawNum; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A8B0E0-0x0000000189A8B100 */ get => default; /* [XID] */ /* 0x0000000189A928F0-0x0000000189A92910 */ protected set {} } // 0x0000000182A71D50-0x0000000182A71E20 0x0000000182A70B70-0x0000000182A70C50
	public uint dayIndex { /* [XID] */ /* 0x0000000189A9A260-0x0000000189A9A280 */ get => default; /* [XID] */ /* 0x0000000189AA1360-0x0000000189AA1380 */ protected set {} } // 0x0000000182A70D00-0x0000000182A70DD0 0x0000000182A70A90-0x0000000182A70B70
	public uint dungeonId { /* [XID] */ /* 0x0000000189AA8AA0-0x0000000189AA8AC0 */ get => default; /* [XID] */ /* 0x0000000189AB0680-0x0000000189AB06A0 */ protected set {} } // 0x0000000182A71950-0x0000000182A71A20 0x0000000182A71E20-0x0000000182A71F00
	public string prefab { /* [XID] */ /* 0x0000000189AB7CE0-0x0000000189AB7D00 */ get => default; /* [XID] */ /* 0x0000000189ABF770-0x0000000189ABF790 */ protected set {} } // 0x0000000182A71B70-0x0000000182A71C10 0x0000000182A6F5A0-0x0000000182A6F650
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189AC7140-0x0000000189AC7160 */ get => default; /* [XID] */ /* 0x0000000189ACE830-0x0000000189ACE850 */ protected set {} } // 0x0000000182A6F3A0-0x0000000182A6F440 0x0000000182A6F4F0-0x0000000182A6F5A0
	public string title { /* [XID] */ /* 0x0000000189AD6720-0x0000000189AD6740 */ get => default; } // 0x0000000182A717D0-0x0000000182A71950 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x0000000189ADE040-0x0000000189ADE060 */ get => default; /* [XID] */ /* 0x0000000189AE5AA0-0x0000000189AE5AC0 */ protected set {} } // 0x0000000182A71730-0x0000000182A717D0 0x0000000182A70C50-0x0000000182A70D00
	public string content { /* [XID] */ /* 0x0000000189AECF40-0x0000000189AECF60 */ get => default; } // 0x0000000182A715B0-0x0000000182A71730 
	public SimpleSafeUInt32[] limitingConditionVec { /* [XID] */ /* 0x0000000189AF4830-0x0000000189AF4850 */ get => default; /* [XID] */ /* 0x0000000189AFBEA0-0x0000000189AFBEC0 */ protected set {} } // 0x0000000182A6F140-0x0000000182A6F1E0 0x0000000182A71AC0-0x0000000182A71B70
	public SimpleSafeUInt32[] upAvatarVec { /* [XID] */ /* 0x0000000189B03750-0x0000000189B03770 */ get => default; /* [XID] */ /* 0x0000000189B0AE80-0x0000000189B0AEA0 */ protected set {} } // 0x0000000182A71A20-0x0000000182A71AC0 0x0000000182A6F440-0x0000000182A6F4F0
	public uint firstPassRewardId { /* [XID] */ /* 0x0000000189B12700-0x0000000189B12720 */ get => default; /* [XID] */ /* 0x0000000189B19A70-0x0000000189B19A90 */ protected set {} } // 0x0000000182A709C0-0x0000000182A70A90 0x0000000182A6F650-0x0000000182A6F730

	// Constructors
	public EffigyChallengeExcelConfig() {} // 0x0000000182A71FA0-0x0000000182A72000

	// Methods
	// [IDTag] // 0x0000000189B20FD0-0x0000000189B21010
	// [XID] // 0x0000000189B20FD0-0x0000000189B21010
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182A70080-0x0000000182A709C0
	// [IDTag] // 0x0000000189B2B630-0x0000000189B2B670
	// [XID] // 0x0000000189B2B630-0x0000000189B2B670
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182A6F730-0x0000000182A70080
	// [XID] // 0x0000000189B35940-0x0000000189B35960
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF001C */, bool useObjectPool = false /* Metadata: 0x00AF0020 */) => default; // 0x0000000182A70DD0-0x0000000182A715B0
	[BlackList] // 0x0000000189B3D100-0x0000000189B3D140
	// [XID] // 0x0000000189B3D100-0x0000000189B3D140
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A6F1E0-0x0000000182A6F280
	[BlackList] // 0x0000000189B47DA0-0x0000000189B47DE0
	// [XID] // 0x0000000189B47DA0-0x0000000189B47DE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A6F280-0x0000000182A6F3A0
	[BlackList] // 0x0000000189B524A0-0x0000000189B524E0
	// [XID] // 0x0000000189B524A0-0x0000000189B524E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182A71F00-0x0000000182A71FA0
	[BlackList] // 0x0000000189B5CF30-0x0000000189B5CF70
	// [XID] // 0x0000000189B5CF30-0x0000000189B5CF70
	public virtual void OnPoolAllocated() {} // 0x0000000182A71CB0-0x0000000182A71D50
	[BlackList] // 0x0000000189B677E0-0x0000000189B67820
	// [XID] // 0x0000000189B677E0-0x0000000189B67820
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A71C10-0x0000000182A71CB0
}

