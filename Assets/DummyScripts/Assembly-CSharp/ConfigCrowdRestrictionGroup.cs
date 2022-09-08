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
public class ConfigCrowdRestrictionGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17770
{
	// Fields
	private CrowdSpawnConditionType _spawnCondition; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdQuestRestriction[] _questRes; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdActivityRestriction[] _activityRes; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdTimeRestriction[] _timeRes; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdSceneTagRestriction[] _sceneTags; // 0x30

	// Properties
	public CrowdSpawnConditionType spawnCondition { /* [XID] */ /* 0x000000018993B810-0x000000018993B830 */ get => default; /* [XID] */ /* 0x00000001899428B0-0x00000001899428D0 */ private set {} } // 0x00000001843E7F00-0x00000001843E7FA0 0x00000001843E79A0-0x00000001843E7A50
	public ConfigCrowdQuestRestriction[] questRes { /* [XID] */ /* 0x000000018994A140-0x000000018994A160 */ get => default; /* [XID] */ /* 0x0000000189951C30-0x0000000189951C50 */ private set {} } // 0x00000001843E7E60-0x00000001843E7F00 0x00000001843E74D0-0x00000001843E7580
	public ConfigCrowdActivityRestriction[] activityRes { /* [XID] */ /* 0x00000001899590F0-0x0000000189959110 */ get => default; /* [XID] */ /* 0x0000000189960980-0x00000001899609A0 */ private set {} } // 0x00000001843E6E50-0x00000001843E6EF0 0x00000001843E7420-0x00000001843E74D0
	public ConfigCrowdTimeRestriction[] timeRes { /* [XID] */ /* 0x0000000189968160-0x0000000189968180 */ get => default; /* [XID] */ /* 0x000000018996F560-0x000000018996F580 */ private set {} } // 0x00000001843E6420-0x00000001843E64C0 0x00000001843E7370-0x00000001843E7420
	public ConfigCrowdSceneTagRestriction[] sceneTags { /* [XID] */ /* 0x00000001899771E0-0x0000000189977200 */ get => default; /* [XID] */ /* 0x000000018997E580-0x000000018997E5A0 */ private set {} } // 0x00000001843E7900-0x00000001843E79A0 0x00000001843E8430-0x00000001843E84E0

	// Constructors
	public ConfigCrowdRestrictionGroup() {} // 0x00000001843E8820-0x00000001843E8880

	// Methods
	// [XID] // 0x0000000189986010-0x0000000189986030
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843E84E0-0x00000001843E8640
	// [XID] // 0x000000018998DCE0-0x000000018998DD00
	public void InitEmpty() {} // 0x00000001843E7A50-0x00000001843E7B60
	[BlackList] // 0x0000000189995770-0x00000001899957B0
	// [XID] // 0x0000000189995770-0x00000001899957B0
	public bool FromJson(JSONNode node) => default; // 0x00000001843E7580-0x00000001843E7900
	// [XID] // 0x00000001899A00D0-0x00000001899A00F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001843E64C0-0x00000001843E6A10
	// [XID] // 0x00000001899A7C20-0x00000001899A7C40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B91 */, bool useObjectPool = false /* Metadata: 0x00AF7B95 */) => default; // 0x00000001843E7B60-0x00000001843E7E60
	// [XID] // 0x00000001899AF3F0-0x00000001899AF410
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B96 */, bool useObjectPool = false /* Metadata: 0x00AF7B9A */) => default; // 0x00000001843E6EF0-0x00000001843E7370
	[BlackList] // 0x00000001899B6890-0x00000001899B68D0
	// [XID] // 0x00000001899B6890-0x00000001899B68D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001843E6A10-0x00000001843E6CE0
	// [XID] // 0x00000001899C12F0-0x00000001899C1310
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843E7FA0-0x00000001843E8430
	[BlackList] // 0x00000001899C88E0-0x00000001899C8920
	// [XID] // 0x00000001899C88E0-0x00000001899C8920
	public virtual void AutoAllocTypeFields() {} // 0x00000001843E6CE0-0x00000001843E6D80
	[BlackList] // 0x00000001899D30B0-0x00000001899D30F0
	// [XID] // 0x00000001899D30B0-0x00000001899D30F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843E6D80-0x00000001843E6E50
	[BlackList] // 0x00000001899DD520-0x00000001899DD560
	// [XID] // 0x00000001899DD520-0x00000001899DD560
	public virtual void ReturnToObjectPool() {} // 0x00000001843E8780-0x00000001843E8820
	[BlackList] // 0x00000001899E8020-0x00000001899E8060
	// [XID] // 0x00000001899E8020-0x00000001899E8060
	public virtual void OnPoolAllocated() {} // 0x00000001843E86E0-0x00000001843E8780
	[BlackList] // 0x00000001899F27C0-0x00000001899F2800
	// [XID] // 0x00000001899F27C0-0x00000001899F2800
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843E8640-0x00000001843E86E0
}

