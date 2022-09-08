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
public class ConfigMonsterInitialPose : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18025
{
	// Fields
	private SimpleSafeInt32 initialPoseIDRawNum; // 0x10
	private bool _released; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPoseInitialParam _initialPoseParams; // 0x18

	// Properties
	public int initialPoseID { /* [XID] */ /* 0x00000001898DC6B0-0x00000001898DC6D0 */ get => default; /* [XID] */ /* 0x00000001898E4160-0x00000001898E4180 */ private set {} } // 0x00000001830C58B0-0x00000001830C5980 0x00000001830C5470-0x00000001830C5550
	public bool released { /* [XID] */ /* 0x00000001898EBC50-0x00000001898EBC70 */ get => default; /* [XID] */ /* 0x00000001898F3480-0x00000001898F34A0 */ private set {} } // 0x00000001830C5AD0-0x00000001830C5B70 0x00000001830C5980-0x00000001830C5A30
	public ConfigPoseInitialParam initialPoseParams { /* [XID] */ /* 0x0000000189722F20-0x0000000189722F40 */ get => default; /* [XID] */ /* 0x00000001899025C0-0x00000001899025E0 */ private set {} } // 0x00000001830C5A30-0x00000001830C5AD0 0x00000001830C5EF0-0x00000001830C5FA0

	// Constructors
	public ConfigMonsterInitialPose() {} // 0x00000001830C69E0-0x00000001830C6A50

	// Methods
	// [XID] // 0x0000000189909B80-0x0000000189909BA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830C66C0-0x00000001830C6800
	// [XID] // 0x0000000189911360-0x0000000189911380
	public void InitEmpty() {} // 0x00000001830C5FA0-0x00000001830C60A0
	[BlackList] // 0x0000000189918F00-0x0000000189918F40
	// [XID] // 0x0000000189918F00-0x0000000189918F40
	public bool FromJson(JSONNode node) => default; // 0x00000001830C5B70-0x00000001830C5EF0
	// [XID] // 0x0000000189923780-0x00000001899237A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830C4BD0-0x00000001830C4FA0
	// [XID] // 0x000000018992AE40-0x000000018992AE60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8713 */, bool useObjectPool = false /* Metadata: 0x00AF8717 */) => default; // 0x00000001830C60A0-0x00000001830C63A0
	// [XID] // 0x0000000189932480-0x00000001899324A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8718 */, bool useObjectPool = false /* Metadata: 0x00AF871C */) => default; // 0x00000001830C5550-0x00000001830C58B0
	[BlackList] // 0x0000000189939EB0-0x0000000189939EF0
	// [XID] // 0x0000000189939EB0-0x0000000189939EF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830C4FA0-0x00000001830C5270
	// [XID] // 0x0000000189944440-0x0000000189944460
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830C63A0-0x00000001830C66C0
	[BlackList] // 0x000000018994B9E0-0x000000018994BA20
	// [XID] // 0x000000018994B9E0-0x000000018994BA20
	public virtual void AutoAllocTypeFields() {} // 0x00000001830C5270-0x00000001830C5310
	[BlackList] // 0x0000000189955FC0-0x0000000189956000
	// [XID] // 0x0000000189955FC0-0x0000000189956000
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830C5310-0x00000001830C5470
	[BlackList] // 0x00000001899608E0-0x0000000189960920
	// [XID] // 0x00000001899608E0-0x0000000189960920
	public virtual void ReturnToObjectPool() {} // 0x00000001830C6940-0x00000001830C69E0
	[BlackList] // 0x000000018996AFF0-0x000000018996B030
	// [XID] // 0x000000018996AFF0-0x000000018996B030
	public virtual void OnPoolAllocated() {} // 0x00000001830C68A0-0x00000001830C6940
	[BlackList] // 0x00000001899759D0-0x0000000189975A10
	// [XID] // 0x00000001899759D0-0x0000000189975A10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830C6800-0x00000001830C68A0
}

