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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigCameraShake : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14796
{
	// Fields
	private CameraShakeType _shakeType; // 0x10
	private SimpleSafeFloat shakeRangeRawNum; // 0x14
	private SimpleSafeFloat shakeTimeRawNum; // 0x18
	private SimpleSafeFloat shakeDistanceRawNum; // 0x1C
	private MoleMole.Config.Vector _shakeDir; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCameraShakeExt _extension; // 0x30

	// Properties
	public CameraShakeType shakeType { /* [XID] */ /* 0x000000018998CDE0-0x000000018998CE00 */ get => default; /* [XID] */ /* 0x000000018994A720-0x000000018994A740 */ private set {} } // 0x0000000184B3F9A0-0x0000000184B3FA40 0x0000000184B40A20-0x0000000184B40AD0
	public float shakeRange { /* [XID] */ /* 0x00000001899BA400-0x00000001899BA420 */ get => default; /* [XID] */ /* 0x00000001899596B0-0x00000001899596D0 */ private set {} } // 0x0000000184B3E450-0x0000000184B3E530 0x0000000184B3F220-0x0000000184B3F300
	public float shakeTime { /* [XID] */ /* 0x00000001899C1E50-0x00000001899C1E70 */ get => default; /* [XID] */ /* 0x0000000189968740-0x0000000189968760 */ private set {} } // 0x0000000184B3F140-0x0000000184B3F220 0x0000000184B3FE90-0x0000000184B3FF70
	public float shakeDistance { /* [XID] */ /* 0x00000001899C9280-0x00000001899C92A0 */ get => default; /* [XID] */ /* 0x0000000189977AA0-0x0000000189977AC0 */ private set {} } // 0x0000000184B403B0-0x0000000184B40490 0x0000000184B40AD0-0x0000000184B40BB0
	public MoleMole.Config.Vector shakeDir { /* [XID] */ /* 0x00000001899D0DF0-0x00000001899D0E10 */ get => default; /* [XID] */ /* 0x0000000189986550-0x0000000189986570 */ private set {} } // 0x0000000184B3F300-0x0000000184B3F3E0 0x0000000184B3FA40-0x0000000184B3FB10
	public ConfigCameraShakeExt extension { /* [XID] */ /* 0x00000001899D81F0-0x00000001899D8210 */ get => default; /* [XID] */ /* 0x0000000189995C10-0x0000000189995C30 */ private set {} } // 0x0000000184B3F900-0x0000000184B3F9A0 0x0000000184B40490-0x0000000184B40540

	// Constructors
	public ConfigCameraShake() {} // 0x0000000184B41190-0x0000000184B41230

	// Methods
	// [XID] // 0x00000001898BACB0-0x00000001898BACD0
	public Vector3 GetShakeDir(Vector3? hitInput = default) => default; // 0x0000000184B40EA0-0x0000000184B410F0
	// [XID] // 0x000000018999D710-0x000000018999D730
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B40BB0-0x0000000184B40D60
	// [XID] // 0x00000001899A5050-0x00000001899A5070
	public void InitEmpty() {} // 0x0000000184B3FF70-0x0000000184B400B0
	[BlackList] // 0x00000001899ACAB0-0x00000001899ACAF0
	// [XID] // 0x00000001899ACAB0-0x00000001899ACAF0
	public bool FromJson(JSONNode node) => default; // 0x0000000184B3FB10-0x0000000184B3FE90
	// [XID] // 0x00000001899B6E10-0x00000001899B6E30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B3E530-0x0000000184B3EC30
	// [XID] // 0x00000001899BE910-0x00000001899BE930
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5CA */, bool useObjectPool = false /* Metadata: 0x00AEF5CE */) => default; // 0x0000000184B400B0-0x0000000184B403B0
	// [XID] // 0x00000001899C6170-0x00000001899C6190
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5CF */, bool useObjectPool = false /* Metadata: 0x00AEF5D3 */) => default; // 0x0000000184B3F3E0-0x0000000184B3F900
	[BlackList] // 0x00000001899CD8B0-0x00000001899CD8F0
	// [XID] // 0x00000001899CD8B0-0x00000001899CD8F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B3EC30-0x0000000184B3EF00
	// [XID] // 0x00000001899D7CD0-0x00000001899D7CF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B40540-0x0000000184B40A20
	[BlackList] // 0x00000001899DF230-0x00000001899DF270
	// [XID] // 0x00000001899DF230-0x00000001899DF270
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B3EF00-0x0000000184B3EFA0
	[BlackList] // 0x00000001899E9AC0-0x00000001899E9B00
	// [XID] // 0x00000001899E9AC0-0x00000001899E9B00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B3EFA0-0x0000000184B3F140
	[BlackList] // 0x00000001899F47D0-0x00000001899F4810
	// [XID] // 0x00000001899F47D0-0x00000001899F4810
	public virtual void ReturnToObjectPool() {} // 0x0000000184B410F0-0x0000000184B41190
	[BlackList] // 0x00000001899FEBB0-0x00000001899FEBF0
	// [XID] // 0x00000001899FEBB0-0x00000001899FEBF0
	public virtual void OnPoolAllocated() {} // 0x0000000184B40E00-0x0000000184B40EA0
	[BlackList] // 0x0000000189A091B0-0x0000000189A091F0
	// [XID] // 0x0000000189A091B0-0x0000000189A091F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B40D60-0x0000000184B40E00
}

