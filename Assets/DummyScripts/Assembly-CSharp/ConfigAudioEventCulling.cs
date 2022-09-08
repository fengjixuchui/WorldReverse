/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAudioEventCulling : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17584
{
	// Fields
	private Dictionary<string, ConfigAudioEventCullingRuleBase[]> _ruleMap; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAudioEventCullingRuleBase[] _globalRules; // 0x18

	// Properties
	public Dictionary<string, ConfigAudioEventCullingRuleBase[]> ruleMap { /* [XID] */ /* 0x0000000189635C10-0x0000000189635C30 */ get => default; /* [XID] */ /* 0x000000018963D310-0x000000018963D330 */ private set {} } // 0x0000000182618990-0x0000000182618A30 0x0000000182618290-0x0000000182618340
	public ConfigAudioEventCullingRuleBase[] globalRules { /* [XID] */ /* 0x0000000189AB3CA0-0x0000000189AB3CC0 */ get => default; /* [XID] */ /* 0x000000018964C0F0-0x000000018964C110 */ private set {} } // 0x0000000182617B00-0x0000000182617BA0 0x0000000182618E20-0x0000000182618ED0

	// Constructors
	public ConfigAudioEventCulling() {} // 0x0000000182619460-0x00000001826194C0

	// Methods
	// [XID] // 0x0000000189653760-0x0000000189653780
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182619170-0x0000000182619280
	// [XID] // 0x000000018965B0D0-0x000000018965B0F0
	public void InitEmpty() {} // 0x0000000182618A30-0x0000000182618B20
	[BlackList] // 0x0000000189662500-0x0000000189662540
	// [XID] // 0x0000000189662500-0x0000000189662540
	public bool FromJson(JSONNode node) => default; // 0x0000000182618610-0x0000000182618990
	// [XID] // 0x000000018966CC80-0x000000018966CCA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182617BA0-0x0000000182617E70
	// [XID] // 0x0000000189674B90-0x0000000189674BB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73BB */, bool useObjectPool = false /* Metadata: 0x00AF73BF */) => default; // 0x0000000182618B20-0x0000000182618E20
	// [XID] // 0x000000018967C440-0x000000018967C460
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73C0 */, bool useObjectPool = false /* Metadata: 0x00AF73C4 */) => default; // 0x0000000182618340-0x0000000182618610
	[BlackList] // 0x0000000189683A70-0x0000000189683AB0
	// [XID] // 0x0000000189683A70-0x0000000189683AB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182617E70-0x0000000182618140
	// [XID] // 0x000000018968E8D0-0x000000018968E8F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182618ED0-0x0000000182619170
	[BlackList] // 0x0000000189696370-0x00000001896963B0
	// [XID] // 0x0000000189696370-0x00000001896963B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182618140-0x00000001826181E0
	[BlackList] // 0x00000001896A0550-0x00000001896A0590
	// [XID] // 0x00000001896A0550-0x00000001896A0590
	public virtual void AutoRecycleTypeFields() {} // 0x00000001826181E0-0x0000000182618290
	[BlackList] // 0x00000001896AA870-0x00000001896AA8B0
	// [XID] // 0x00000001896AA870-0x00000001896AA8B0
	public virtual void ReturnToObjectPool() {} // 0x00000001826193C0-0x0000000182619460
	[BlackList] // 0x00000001896B4D90-0x00000001896B4DD0
	// [XID] // 0x00000001896B4D90-0x00000001896B4DD0
	public virtual void OnPoolAllocated() {} // 0x0000000182619320-0x00000001826193C0
	[BlackList] // 0x00000001896BED10-0x00000001896BED50
	// [XID] // 0x00000001896BED10-0x00000001896BED50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182619280-0x0000000182619320
}

