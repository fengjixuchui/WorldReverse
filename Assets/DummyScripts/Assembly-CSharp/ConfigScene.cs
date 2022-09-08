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
public class ConfigScene : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18936
{
	// Fields
	private SimpleSafeFloat transRadiusRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigScenePoint> _points; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigSceneArea> _areas; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigForceField> _forces; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigLocalEntity> _entities; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigLoadingDoor> _doors; // 0x38

	// Properties
	public float transRadius { /* [XID] */ /* 0x0000000189626420-0x0000000189626440 */ get => default; /* [XID] */ /* 0x000000018962DDB0-0x000000018962DDD0 */ private set {} } // 0x0000000183AE2320-0x0000000183AE2400 0x0000000183AE3650-0x0000000183AE3730
	public Dictionary<string, ConfigScenePoint> points { /* [XID] */ /* 0x00000001896359F0-0x0000000189635A10 */ get => default; /* [XID] */ /* 0x000000018963D0D0-0x000000018963D0F0 */ private set {} } // 0x0000000183AE35B0-0x0000000183AE3650 0x0000000183AE3D30-0x0000000183AE3DE0
	public Dictionary<string, ConfigSceneArea> areas { /* [XID] */ /* 0x0000000189644650-0x0000000189644670 */ get => default; /* [XID] */ /* 0x000000018964BEB0-0x000000018964BED0 */ private set {} } // 0x0000000183AE30C0-0x0000000183AE3160 0x0000000183AE3010-0x0000000183AE30C0
	public Dictionary<string, ConfigForceField> forces { /* [XID] */ /* 0x0000000189653540-0x0000000189653560 */ get => default; /* [XID] */ /* 0x000000018965AD50-0x000000018965AD70 */ private set {} } // 0x0000000183AE3460-0x0000000183AE3500 0x0000000183AE3500-0x0000000183AE35B0
	public Dictionary<string, ConfigLocalEntity> entities { /* [XID] */ /* 0x00000001896622C0-0x00000001896622E0 */ get => default; /* [XID] */ /* 0x0000000189669EA0-0x0000000189669EC0 */ private set {} } // 0x0000000183AE2400-0x0000000183AE24A0 0x0000000183AE24A0-0x0000000183AE2550
	public Dictionary<string, ConfigLoadingDoor> doors { /* [XID] */ /* 0x0000000189671B00-0x0000000189671B20 */ get => default; /* [XID] */ /* 0x00000001896792B0-0x00000001896792D0 */ private set {} } // 0x0000000183AE2E20-0x0000000183AE2EC0 0x0000000183AE3730-0x0000000183AE37E0

	// Constructors
	public ConfigScene() {} // 0x0000000183AE4130-0x0000000183AE4190

	// Methods
	// [XID] // 0x0000000189680A40-0x0000000189680A60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AE3DE0-0x0000000183AE3F50
	// [XID] // 0x0000000189688540-0x0000000189688560
	public void InitEmpty() {} // 0x0000000183AE2EC0-0x0000000183AE3010
	[BlackList] // 0x000000018968FE00-0x000000018968FE40
	// [XID] // 0x000000018968FE00-0x000000018968FE40
	public bool FromJson(JSONNode node) => default; // 0x0000000183AE2AA0-0x0000000183AE2E20
	// [XID] // 0x0000000189792CF0-0x0000000189792D10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AE17D0-0x0000000183AE1E50
	// [XID] // 0x00000001899F5F60-0x00000001899F5F80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB435 */, bool useObjectPool = false /* Metadata: 0x00AFB439 */) => default; // 0x0000000183AE3160-0x0000000183AE3460
	// [XID] // 0x00000001896A9040-0x00000001896A9060
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB43A */, bool useObjectPool = false /* Metadata: 0x00AFB43E */) => default; // 0x0000000183AE2550-0x0000000183AE2AA0
	[BlackList] // 0x00000001896B01B0-0x00000001896B01F0
	// [XID] // 0x00000001896B01B0-0x00000001896B01F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AE1E50-0x0000000183AE2120
	// [XID] // 0x00000001896BA890-0x00000001896BA8B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AE37E0-0x0000000183AE3D30
	[BlackList] // 0x00000001896C1940-0x00000001896C1980
	// [XID] // 0x00000001896C1940-0x00000001896C1980
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AE2120-0x0000000183AE21C0
	[BlackList] // 0x00000001896CC050-0x00000001896CC090
	// [XID] // 0x00000001896CC050-0x00000001896CC090
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AE21C0-0x0000000183AE2320
	[BlackList] // 0x00000001896D6720-0x00000001896D6760
	// [XID] // 0x00000001896D6720-0x00000001896D6760
	public virtual void ReturnToObjectPool() {} // 0x0000000183AE4090-0x0000000183AE4130
	[BlackList] // 0x00000001896E0EF0-0x00000001896E0F30
	// [XID] // 0x00000001896E0EF0-0x00000001896E0F30
	public virtual void OnPoolAllocated() {} // 0x0000000183AE3FF0-0x0000000183AE4090
	[BlackList] // 0x00000001896EB2E0-0x00000001896EB320
	// [XID] // 0x00000001896EB2E0-0x00000001896EB320
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AE3F50-0x0000000183AE3FF0
}

