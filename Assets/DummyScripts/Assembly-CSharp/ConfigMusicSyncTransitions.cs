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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicSyncTransitions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18743
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _beatTransitions; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _barTransitions; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _gridTransitions; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _cueTransitions; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMusicTransitions _exitTransitions; // 0x30

	// Properties
	public ConfigMusicTransitions beatTransitions { /* [XID] */ /* 0x00000001895F3750-0x00000001895F3770 */ get => default; /* [XID] */ /* 0x00000001895FB070-0x00000001895FB090 */ private set {} } // 0x0000000182C9E740-0x0000000182C9E7E0 0x0000000182C9EC00-0x0000000182C9ECB0
	public ConfigMusicTransitions barTransitions { /* [XID] */ /* 0x00000001896027F0-0x0000000189602810 */ get => default; /* [XID] */ /* 0x000000018960A130-0x000000018960A150 */ private set {} } // 0x0000000182C9F560-0x0000000182C9F600 0x0000000182C9E260-0x0000000182C9E310
	public ConfigMusicTransitions gridTransitions { /* [XID] */ /* 0x00000001896B4080-0x00000001896B40A0 */ get => default; /* [XID] */ /* 0x00000001896191E0-0x0000000189619200 */ private set {} } // 0x0000000182C9F050-0x0000000182C9F0F0 0x0000000182C9ECB0-0x0000000182C9ED60
	public ConfigMusicTransitions cueTransitions { /* [XID] */ /* 0x0000000189620760-0x0000000189620780 */ get => default; /* [XID] */ /* 0x0000000189627C50-0x0000000189627C70 */ private set {} } // 0x0000000182C9EF10-0x0000000182C9EFB0 0x0000000182C9E690-0x0000000182C9E740
	public ConfigMusicTransitions exitTransitions { /* [XID] */ /* 0x000000018962F5A0-0x000000018962F5C0 */ get => default; /* [XID] */ /* 0x0000000189637140-0x0000000189637160 */ private set {} } // 0x0000000182C9EFB0-0x0000000182C9F050 0x0000000182C9DC20-0x0000000182C9DCD0

	// Constructors
	public ConfigMusicSyncTransitions() {} // 0x0000000182C9F970-0x0000000182C9F9D0

	// Methods
	// [XID] // 0x000000018963E640-0x000000018963E660
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C9F600-0x0000000182C9F790
	// [XID] // 0x0000000189645DC0-0x0000000189645DE0
	public void InitEmpty() {} // 0x0000000182C9E7E0-0x0000000182C9E900
	[BlackList] // 0x000000018964D6A0-0x000000018964D6E0
	// [XID] // 0x000000018964D6A0-0x000000018964D6E0
	public bool FromJson(JSONNode node) => default; // 0x0000000182C9E310-0x0000000182C9E690
	// [XID] // 0x0000000189657D70-0x0000000189657D90
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C9D000-0x0000000182C9D5D0
	// [XID] // 0x000000018965F420-0x000000018965F440
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAAF */, bool useObjectPool = false /* Metadata: 0x00AFAAB3 */) => default; // 0x0000000182C9E900-0x0000000182C9EC00
	// [XID] // 0x0000000189666CD0-0x0000000189666CF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAAB4 */, bool useObjectPool = false /* Metadata: 0x00AFAAB8 */) => default; // 0x0000000182C9DCD0-0x0000000182C9E260
	[BlackList] // 0x000000018966E420-0x000000018966E460
	// [XID] // 0x000000018966E420-0x000000018966E460
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C9D5D0-0x0000000182C9D8A0
	// [XID] // 0x0000000189679350-0x0000000189679370
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C9F0F0-0x0000000182C9F560
	// [XID] // 0x0000000189680A60-0x0000000189680A80
	public void BuildGameParamMask(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) {} // 0x0000000182C9ED60-0x0000000182C9EF10
	[BlackList] // 0x0000000189688560-0x00000001896885A0
	// [XID] // 0x0000000189688560-0x00000001896885A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C9D8A0-0x0000000182C9D940
	[BlackList] // 0x0000000189693160-0x00000001896931A0
	// [XID] // 0x0000000189693160-0x00000001896931A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C9D940-0x0000000182C9DC20
	[BlackList] // 0x000000018969D730-0x000000018969D770
	// [XID] // 0x000000018969D730-0x000000018969D770
	public virtual void ReturnToObjectPool() {} // 0x0000000182C9F8D0-0x0000000182C9F970
	[BlackList] // 0x00000001896A7780-0x00000001896A77C0
	// [XID] // 0x00000001896A7780-0x00000001896A77C0
	public virtual void OnPoolAllocated() {} // 0x0000000182C9F830-0x0000000182C9F8D0
	[BlackList] // 0x00000001896B1630-0x00000001896B1670
	// [XID] // 0x00000001896B1630-0x00000001896B1670
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C9F790-0x0000000182C9F830
}

