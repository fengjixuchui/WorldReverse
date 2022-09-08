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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigTimer : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19079
{
	// Fields
	private bool _lifeInfinite; // 0x10
	private SimpleSafeFloat startCheckTimeRawNum; // 0x14
	private SimpleSafeFloat checkIntervalRawNum; // 0x18
	private SimpleSafeFloat lifeTimeRawNum; // 0x1C

	// Properties
	public bool lifeInfinite { /* [XID] */ /* 0x000000018980D5A0-0x000000018980D5C0 */ get => default; /* [XID] */ /* 0x00000001896F8680-0x00000001896F86A0 */ private set {} } // 0x0000000181CA0630-0x0000000181CA06D0 0x0000000181C9FFA0-0x0000000181CA0050
	public float startCheckTime { /* [XID] */ /* 0x0000000189805E50-0x0000000189805E70 */ get => default; /* [XID] */ /* 0x0000000189707690-0x00000001897076B0 */ private set {} } // 0x0000000181C9F4B0-0x0000000181C9F590 0x0000000181C9FDE0-0x0000000181C9FEC0
	public float checkInterval { /* [XID] */ /* 0x000000018970F0A0-0x000000018970F0C0 */ get => default; /* [XID] */ /* 0x0000000189716440-0x0000000189716460 */ private set {} } // 0x0000000181C9FEC0-0x0000000181C9FFA0 0x0000000181C9EF20-0x0000000181C9F000
	public float lifeTime { /* [XID] */ /* 0x000000018971DE80-0x000000018971DEA0 */ get => default; /* [XID] */ /* 0x00000001897253C0-0x00000001897253E0 */ private set {} } // 0x0000000181C9F910-0x0000000181C9F9F0 0x0000000181C9F000-0x0000000181C9F0E0

	// Constructors
	public ConfigTimer() {} // 0x0000000181CA0770-0x0000000181CA07D0

	// Methods
	// [XID] // 0x000000018972CA20-0x000000018972CA40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181CA03B0-0x0000000181CA04F0
	// [XID] // 0x0000000189734110-0x0000000189734130
	public void InitEmpty() {} // 0x0000000181C9F9F0-0x0000000181C9FAE0
	[BlackList] // 0x000000018973B850-0x000000018973B890
	// [XID] // 0x000000018973B850-0x000000018973B890
	public bool FromJson(JSONNode node) => default; // 0x0000000181C9F590-0x0000000181C9F910
	// [XID] // 0x0000000189746160-0x0000000189746180
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C9E580-0x0000000181C9EAB0
	// [XID] // 0x000000018974DD10-0x000000018974DD30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB9E3 */, bool useObjectPool = false /* Metadata: 0x00AFB9E7 */) => default; // 0x0000000181C9FAE0-0x0000000181C9FDE0
	// [XID] // 0x0000000189755370-0x0000000189755390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB9E8 */, bool useObjectPool = false /* Metadata: 0x00AFB9EC */) => default; // 0x0000000181C9F0E0-0x0000000181C9F4B0
	[BlackList] // 0x000000018975C510-0x000000018975C550
	// [XID] // 0x000000018975C510-0x000000018975C550
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C9EAB0-0x0000000181C9ED80
	// [XID] // 0x0000000189766E40-0x0000000189766E60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181CA0050-0x0000000181CA03B0
	[BlackList] // 0x000000018976E340-0x000000018976E380
	// [XID] // 0x000000018976E340-0x000000018976E380
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C9ED80-0x0000000181C9EE20
	[BlackList] // 0x0000000189778D80-0x0000000189778DC0
	// [XID] // 0x0000000189778D80-0x0000000189778DC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C9EE20-0x0000000181C9EF20
	[BlackList] // 0x00000001897834F0-0x0000000189783530
	// [XID] // 0x00000001897834F0-0x0000000189783530
	public virtual void ReturnToObjectPool() {} // 0x0000000181CA06D0-0x0000000181CA0770
	[BlackList] // 0x000000018978DAF0-0x000000018978DB30
	// [XID] // 0x000000018978DAF0-0x000000018978DB30
	public virtual void OnPoolAllocated() {} // 0x0000000181CA0590-0x0000000181CA0630
	[BlackList] // 0x0000000189798300-0x0000000189798340
	// [XID] // 0x0000000189798300-0x0000000189798340
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181CA04F0-0x0000000181CA0590
}

