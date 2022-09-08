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
public class AvatarSpeechEquipObtain : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17638
{
	// Fields
	private SimpleSafeInt32 qualityRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventName; // 0x18

	// Properties
	public int quality { /* [XID] */ /* 0x0000000189BB2570-0x0000000189BB2590 */ get => default; /* [XID] */ /* 0x0000000189BB99C0-0x0000000189BB99E0 */ private set {} } // 0x000000018341A430-0x000000018341A500 0x000000018341B210-0x000000018341B2F0
	public ConfigWwiseString eventName { /* [XID] */ /* 0x0000000189BC18C0-0x0000000189BC18E0 */ get => default; /* [XID] */ /* 0x0000000189BC8F60-0x0000000189BC8F80 */ private set {} } // 0x000000018341A880-0x000000018341A920 0x000000018341A380-0x000000018341A430

	// Constructors
	public AvatarSpeechEquipObtain() {} // 0x000000018341B390-0x000000018341B3F0

	// Methods
	// [XID] // 0x0000000189BD0790-0x0000000189BD07B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018341AFB0-0x000000018341B0D0
	// [XID] // 0x0000000189BD7D10-0x0000000189BD7D30
	public void InitEmpty() {} // 0x000000018341A920-0x000000018341AA20
	[BlackList] // 0x0000000189BDF920-0x0000000189BDF960
	// [XID] // 0x0000000189BDF920-0x0000000189BDF960
	public bool FromJson(JSONNode node) => default; // 0x000000018341A500-0x000000018341A880
	// [XID] // 0x00000001895EF2E0-0x00000001895EF300
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001834198A0-0x0000000183419BC0
	// [XID] // 0x00000001895F6D00-0x00000001895F6D20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75B3 */, bool useObjectPool = false /* Metadata: 0x00AF75B7 */) => default; // 0x000000018341AA20-0x000000018341AD20
	// [XID] // 0x00000001895FE0A0-0x00000001895FE0C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75B8 */, bool useObjectPool = false /* Metadata: 0x00AF75BC */) => default; // 0x000000018341A090-0x000000018341A380
	[BlackList] // 0x0000000189605870-0x00000001896058B0
	// [XID] // 0x0000000189605870-0x00000001896058B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183419BC0-0x0000000183419E90
	// [XID] // 0x00000001896103B0-0x00000001896103D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018341AD20-0x000000018341AFB0
	[BlackList] // 0x0000000189617650-0x0000000189617690
	// [XID] // 0x0000000189617650-0x0000000189617690
	public virtual void AutoAllocTypeFields() {} // 0x0000000183419E90-0x0000000183419F30
	[BlackList] // 0x0000000189621F00-0x0000000189621F40
	// [XID] // 0x0000000189621F00-0x0000000189621F40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183419F30-0x000000018341A090
	[BlackList] // 0x000000018962C530-0x000000018962C570
	// [XID] // 0x000000018962C530-0x000000018962C570
	public virtual void ReturnToObjectPool() {} // 0x000000018341B2F0-0x000000018341B390
	[BlackList] // 0x0000000189637320-0x0000000189637360
	// [XID] // 0x0000000189637320-0x0000000189637360
	public virtual void OnPoolAllocated() {} // 0x000000018341B170-0x000000018341B210
	[BlackList] // 0x00000001896417A0-0x00000001896417E0
	// [XID] // 0x00000001896417A0-0x00000001896417E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018341B0D0-0x000000018341B170
}

