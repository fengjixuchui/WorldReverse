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
public class ConfigParticleEffectSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18167
{
	// Fields
	private bool _halfResolutionParticle; // 0x10
	private ParticleEmitLevelType _particleEmitLevel; // 0x14
	private SimpleSafeFloat particleDecreaseThreshRawNum; // 0x18

	// Properties
	public bool halfResolutionParticle { /* [XID] */ /* 0x0000000189849930-0x0000000189849950 */ get => default; /* [XID] */ /* 0x0000000189851130-0x0000000189851150 */ private set {} } // 0x0000000183264770-0x0000000183264810 0x0000000183263AE0-0x0000000183263B90
	public ParticleEmitLevelType particleEmitLevel { /* [XID] */ /* 0x0000000189858600-0x0000000189858620 */ get => default; /* [XID] */ /* 0x000000018985F670-0x000000018985F690 */ private set {} } // 0x0000000183264B80-0x0000000183264C20 0x0000000183264AD0-0x0000000183264B80
	public float particleDecreaseThresh { /* [XID] */ /* 0x0000000189866F50-0x0000000189866F70 */ get => default; /* [XID] */ /* 0x000000018986E750-0x000000018986E770 */ private set {} } // 0x0000000183264690-0x0000000183264770 0x0000000183263E60-0x0000000183263F40

	// Constructors
	public ConfigParticleEffectSetting() {} // 0x0000000183264F20-0x0000000183264FC0

	// Methods
	// [XID] // 0x0000000189875B40-0x0000000189875B60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183264C20-0x0000000183264D40
	// [XID] // 0x000000018987D780-0x000000018987D7A0
	public void InitEmpty() {} // 0x00000001832642C0-0x0000000183264390
	[BlackList] // 0x00000001898845F0-0x0000000189884630
	// [XID] // 0x00000001898845F0-0x0000000189884630
	public bool FromJson(JSONNode node) => default; // 0x0000000183263F40-0x00000001832642C0
	// [XID] // 0x000000018988EB00-0x000000018988EB20
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832632E0-0x0000000183263690
	// [XID] // 0x0000000189895F40-0x0000000189895F60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8D99 */, bool useObjectPool = false /* Metadata: 0x00AF8D9D */) => default; // 0x0000000183264390-0x0000000183264690
	// [XID] // 0x000000018989D5E0-0x000000018989D600
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8D9E */, bool useObjectPool = false /* Metadata: 0x00AF8DA2 */) => default; // 0x0000000183263B90-0x0000000183263E60
	[BlackList] // 0x00000001898A4F40-0x00000001898A4F80
	// [XID] // 0x00000001898A4F40-0x00000001898A4F80
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183263690-0x0000000183263960
	// [XID] // 0x00000001898AF770-0x00000001898AF790
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183264810-0x0000000183264AD0
	[BlackList] // 0x00000001898B6C10-0x00000001898B6C50
	// [XID] // 0x00000001898B6C10-0x00000001898B6C50
	public virtual void AutoAllocTypeFields() {} // 0x0000000183263960-0x0000000183263A00
	[BlackList] // 0x00000001898C1420-0x00000001898C1460
	// [XID] // 0x00000001898C1420-0x00000001898C1460
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183263A00-0x0000000183263AE0
	[BlackList] // 0x00000001898CBB10-0x00000001898CBB50
	// [XID] // 0x00000001898CBB10-0x00000001898CBB50
	public virtual void ReturnToObjectPool() {} // 0x0000000183264E80-0x0000000183264F20
	[BlackList] // 0x00000001898D6560-0x00000001898D65A0
	// [XID] // 0x00000001898D6560-0x00000001898D65A0
	public virtual void OnPoolAllocated() {} // 0x0000000183264DE0-0x0000000183264E80
	[BlackList] // 0x00000001898E1240-0x00000001898E1280
	// [XID] // 0x00000001898E1240-0x00000001898E1280
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183264D40-0x0000000183264DE0
}

