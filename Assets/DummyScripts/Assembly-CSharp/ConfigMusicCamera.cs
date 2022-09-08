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
public class ConfigMusicCamera : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18778
{
	// Fields
	private string _resName; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private CameraPlayCondition[] _conditionList; // 0x18

	// Properties
	public string resName { /* [XID] */ /* 0x0000000189A64EE0-0x0000000189A64F00 */ get => default; /* [XID] */ /* 0x0000000189A6C660-0x0000000189A6C680 */ private set {} } // 0x0000000184B27DC0-0x0000000184B27E60 0x0000000184B28B20-0x0000000184B28BD0
	public CameraPlayCondition[] conditionList { /* [XID] */ /* 0x0000000189A73E70-0x0000000189A73E90 */ get => default; /* [XID] */ /* 0x0000000189A7B940-0x0000000189A7B960 */ private set {} } // 0x0000000184B281E0-0x0000000184B28280 0x0000000184B28BD0-0x0000000184B28C80

	// Constructors
	public ConfigMusicCamera() {} // 0x0000000184B28D20-0x0000000184B28D80

	// Methods
	// [XID] // 0x0000000189A83180-0x0000000189A831A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B288D0-0x0000000184B289E0
	// [XID] // 0x0000000189A8AA10-0x0000000189A8AA30
	public void InitEmpty() {} // 0x0000000184B28280-0x0000000184B28360
	[BlackList] // 0x0000000189A92310-0x0000000189A92350
	// [XID] // 0x0000000189A92310-0x0000000189A92350
	public bool FromJson(JSONNode node) => default; // 0x0000000184B27E60-0x0000000184B281E0
	// [XID] // 0x0000000189A9C8D0-0x0000000189A9C8F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B27410-0x0000000184B276E0
	// [XID] // 0x0000000189AA3FE0-0x0000000189AA4000
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABF3 */, bool useObjectPool = false /* Metadata: 0x00AFABF7 */) => default; // 0x0000000184B28360-0x0000000184B28660
	// [XID] // 0x0000000189AAB530-0x0000000189AAB550
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABF8 */, bool useObjectPool = false /* Metadata: 0x00AFABFC */) => default; // 0x0000000184B27B00-0x0000000184B27DC0
	[BlackList] // 0x0000000189AB2E40-0x0000000189AB2E80
	// [XID] // 0x0000000189AB2E40-0x0000000189AB2E80
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B276E0-0x0000000184B279B0
	// [XID] // 0x0000000189ABD9B0-0x0000000189ABD9D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B28660-0x0000000184B288D0
	[BlackList] // 0x0000000189AC54D0-0x0000000189AC5510
	// [XID] // 0x0000000189AC54D0-0x0000000189AC5510
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B279B0-0x0000000184B27A50
	[BlackList] // 0x0000000189ACF9F0-0x0000000189ACFA30
	// [XID] // 0x0000000189ACF9F0-0x0000000189ACFA30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B27A50-0x0000000184B27B00
	[BlackList] // 0x0000000189ADA760-0x0000000189ADA7A0
	// [XID] // 0x0000000189ADA760-0x0000000189ADA7A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B28C80-0x0000000184B28D20
	[BlackList] // 0x0000000189AE53E0-0x0000000189AE5420
	// [XID] // 0x0000000189AE53E0-0x0000000189AE5420
	public virtual void OnPoolAllocated() {} // 0x0000000184B28A80-0x0000000184B28B20
	[BlackList] // 0x0000000189AEFE40-0x0000000189AEFE80
	// [XID] // 0x0000000189AEFE40-0x0000000189AEFE80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B289E0-0x0000000184B28A80
}

