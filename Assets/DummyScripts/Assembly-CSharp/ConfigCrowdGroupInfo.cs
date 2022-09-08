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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigCrowdGroupInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17771
{
	// Fields
	private SimpleSafeInt32 crowdGroupIDRawNum; // 0x10
	private MoleMole.Config.Vector _boundCenter; // 0x14
	private MoleMole.Config.Vector _boundSize; // 0x20
	private bool _spawnByDefault; // 0x2C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdRestrictionGroup[] _crowdRestrictionGroups; // 0x30
	private SimpleSafeInt32 cutsceneIDRawNum; // 0x38
	private bool _ignoreLowPerfMode; // 0x3C

	// Properties
	public int crowdGroupID { /* [XID] */ /* 0x0000000189A0B990-0x0000000189A0B9B0 */ get => default; /* [XID] */ /* 0x0000000189A13220-0x0000000189A13240 */ private set {} } // 0x000000018444E260-0x000000018444E330 0x000000018444E180-0x000000018444E260
	public MoleMole.Config.Vector boundCenter { /* [XID] */ /* 0x0000000189A1A450-0x0000000189A1A470 */ get => default; /* [XID] */ /* 0x0000000189A21B30-0x0000000189A21B50 */ private set {} } // 0x000000018444ECE0-0x000000018444EDC0 0x000000018444DB10-0x000000018444DBE0
	public MoleMole.Config.Vector boundSize { /* [XID] */ /* 0x0000000189A29120-0x0000000189A29140 */ get => default; /* [XID] */ /* 0x0000000189A30750-0x0000000189A30770 */ private set {} } // 0x000000018444EF40-0x000000018444F020 0x000000018444EE70-0x000000018444EF40
	public bool spawnByDefault { /* [XID] */ /* 0x0000000189A380D0-0x0000000189A380F0 */ get => default; /* [XID] */ /* 0x0000000189A3F800-0x0000000189A3F820 */ private set {} } // 0x000000018444D6F0-0x000000018444D790 0x000000018444DBE0-0x000000018444DC90
	public ConfigCrowdRestrictionGroup[] crowdRestrictionGroups { /* [XID] */ /* 0x0000000189A46EF0-0x0000000189A46F10 */ get => default; /* [XID] */ /* 0x0000000189A4E810-0x0000000189A4E830 */ private set {} } // 0x000000018444E330-0x000000018444E3D0 0x000000018444E0D0-0x000000018444E180
	public int cutsceneID { /* [XID] */ /* 0x0000000189A55F20-0x0000000189A55F40 */ get => default; /* [XID] */ /* 0x0000000189A5D940-0x0000000189A5D960 */ private set {} } // 0x000000018444D620-0x000000018444D6F0 0x000000018444D540-0x000000018444D620
	public bool ignoreLowPerfMode { /* [XID] */ /* 0x0000000189A650A0-0x0000000189A650C0 */ get => default; /* [XID] */ /* 0x0000000189A6C800-0x0000000189A6C820 */ private set {} } // 0x000000018444CF50-0x000000018444CFF0 0x000000018444EDC0-0x000000018444EE70

	// Constructors
	public ConfigCrowdGroupInfo() {} // 0x000000018444F0C0-0x000000018444F160

	// Methods
	// [XID] // 0x0000000189A740D0-0x0000000189A740F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018444E9D0-0x000000018444EBA0
	// [XID] // 0x0000000189A7BA40-0x0000000189A7BA60
	public void InitEmpty() {} // 0x000000018444DC90-0x000000018444DDD0
	[BlackList] // 0x0000000189A83300-0x0000000189A83340
	// [XID] // 0x0000000189A83300-0x0000000189A83340
	public bool FromJson(JSONNode node) => default; // 0x000000018444D790-0x000000018444DB10
	// [XID] // 0x0000000189A8DBF0-0x0000000189A8DC10
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018444C3B0-0x000000018444CAD0
	// [XID] // 0x0000000189A951D0-0x0000000189A951F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B9B */, bool useObjectPool = false /* Metadata: 0x00AF7B9F */) => default; // 0x000000018444DDD0-0x000000018444E0D0
	// [XID] // 0x0000000189A9CA30-0x0000000189A9CA50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BA0 */, bool useObjectPool = false /* Metadata: 0x00AF7BA4 */) => default; // 0x000000018444CFF0-0x000000018444D540
	[BlackList] // 0x0000000189AA4220-0x0000000189AA4260
	// [XID] // 0x0000000189AA4220-0x0000000189AA4260
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018444CAD0-0x000000018444CDA0
	// [XID] // 0x0000000189AAE780-0x0000000189AAE7A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018444E3D0-0x000000018444E9D0
	[BlackList] // 0x0000000189AB5FE0-0x0000000189AB6020
	// [XID] // 0x0000000189AB5FE0-0x0000000189AB6020
	public virtual void AutoAllocTypeFields() {} // 0x000000018444CDA0-0x000000018444CE40
	[BlackList] // 0x0000000189AC0A70-0x0000000189AC0AB0
	// [XID] // 0x0000000189AC0A70-0x0000000189AC0AB0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018444CE40-0x000000018444CF50
	[BlackList] // 0x0000000189ACB430-0x0000000189ACB470
	// [XID] // 0x0000000189ACB430-0x0000000189ACB470
	public virtual void ReturnToObjectPool() {} // 0x000000018444F020-0x000000018444F0C0
	[BlackList] // 0x0000000189AD6340-0x0000000189AD6380
	// [XID] // 0x0000000189AD6340-0x0000000189AD6380
	public virtual void OnPoolAllocated() {} // 0x000000018444EC40-0x000000018444ECE0
	[BlackList] // 0x0000000189AE0CE0-0x0000000189AE0D20
	// [XID] // 0x0000000189AE0CE0-0x0000000189AE0D20
	public virtual void OnBeforePoolRecycled() {} // 0x000000018444EBA0-0x000000018444EC40
}

