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
public class ConfigAttackInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17680
{
	// Fields
	private string _attackTag; // 0x10
	private string _attenuationTag; // 0x18
	private string _attenuationGroup; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackProperty _attackProperty; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHitPattern _hitPattern; // 0x30
	private bool _canHitHead; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHitPattern _hitHeadPattern; // 0x40
	private bool _forceCameraShake; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCameraShake _cameraShake; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBulletWane _bulletWane; // 0x58
	private CanBeModifiedBy _canBeModifiedBy; // 0x60

	// Properties
	public string attackTag { /* [XID] */ /* 0x000000018972E390-0x000000018972E3B0 */ get => default; /* [XID] */ /* 0x0000000189735AE0-0x0000000189735B00 */ private set {} } // 0x0000000183FB4C60-0x0000000183FB4D00 0x0000000183FB4D00-0x0000000183FB4DB0
	public string attenuationTag { /* [XID] */ /* 0x000000018973D630-0x000000018973D650 */ get => default; /* [XID] */ /* 0x0000000189744B50-0x0000000189744B70 */ private set {} } // 0x0000000183FB61D0-0x0000000183FB6270 0x0000000183FB7730-0x0000000183FB77E0
	public string attenuationGroup { /* [XID] */ /* 0x0000000189863930-0x0000000189863950 */ get => default; /* [XID] */ /* 0x0000000189753B00-0x0000000189753B20 */ private set {} } // 0x0000000183FB5F40-0x0000000183FB5FE0 0x0000000183FB6C00-0x0000000183FB6CB0
	public ConfigAttackProperty attackProperty { /* [XID] */ /* 0x000000018986AC20-0x000000018986AC40 */ get => default; /* [XID] */ /* 0x0000000189762A50-0x0000000189762A70 */ private set {} } // 0x0000000183FB8700-0x0000000183FB87A0 0x0000000183FB7380-0x0000000183FB7430
	public ConfigHitPattern hitPattern { /* [XID] */ /* 0x000000018976A0B0-0x000000018976A0D0 */ get => default; /* [XID] */ /* 0x0000000189771890-0x00000001897718B0 */ private set {} } // 0x0000000183FB6B60-0x0000000183FB6C00 0x0000000183FB7B10-0x0000000183FB7BC0
	public bool canHitHead { /* [XID] */ /* 0x0000000189778FC0-0x0000000189778FE0 */ get => default; /* [XID] */ /* 0x00000001897806A0-0x00000001897806C0 */ private set {} } // 0x0000000183FB77E0-0x0000000183FB7880 0x0000000183FB5FE0-0x0000000183FB6090
	public ConfigHitPattern hitHeadPattern { /* [XID] */ /* 0x0000000189787E80-0x0000000189787EA0 */ get => default; /* [XID] */ /* 0x000000018978F420-0x000000018978F440 */ private set {} } // 0x0000000183FB6130-0x0000000183FB61D0 0x0000000183FB7920-0x0000000183FB79D0
	public bool forceCameraShake { /* [XID] */ /* 0x00000001899AB870-0x00000001899AB890 */ get => default; /* [XID] */ /* 0x000000018979ECB0-0x000000018979ECD0 */ private set {} } // 0x0000000183FB79D0-0x0000000183FB7A70 0x0000000183FB70E0-0x0000000183FB7190
	public ConfigCameraShake cameraShake { /* [XID] */ /* 0x00000001899B3110-0x00000001899B3130 */ get => default; /* [XID] */ /* 0x00000001897AD830-0x00000001897AD850 */ private set {} } // 0x0000000183FB7A70-0x0000000183FB7B10 0x0000000183FB5E90-0x0000000183FB5F40
	public ConfigBulletWane bulletWane { /* [XID] */ /* 0x00000001897B5950-0x00000001897B5970 */ get => default; /* [XID] */ /* 0x00000001897BD680-0x00000001897BD6A0 */ private set {} } // 0x0000000183FB6090-0x0000000183FB6130 0x0000000183FB7030-0x0000000183FB70E0
	public CanBeModifiedBy canBeModifiedBy { /* [XID] */ /* 0x00000001897C4A60-0x00000001897C4A80 */ get => default; /* [XID] */ /* 0x00000001897CC310-0x00000001897CC330 */ private set {} } // 0x0000000183FB7880-0x0000000183FB7920 0x0000000183FB72D0-0x0000000183FB7380

	// Constructors
	public ConfigAttackInfo() {} // 0x0000000183FB8840-0x0000000183FB88B0

	// Methods
	// [XID] // 0x00000001897D3C00-0x00000001897D3C20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183FB8360-0x0000000183FB85C0
	// [XID] // 0x00000001897DB5D0-0x00000001897DB5F0
	public void InitEmpty() {} // 0x0000000183FB7190-0x0000000183FB72D0
	[BlackList] // 0x00000001897E2D40-0x00000001897E2D80
	// [XID] // 0x00000001897E2D40-0x00000001897E2D80
	public bool FromJson(JSONNode node) => default; // 0x0000000183FB6CB0-0x0000000183FB7030
	// [XID] // 0x00000001897ED750-0x00000001897ED770
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183FB4DB0-0x0000000183FB5820
	// [XID] // 0x00000001897F4FD0-0x00000001897F4FF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF776D */, bool useObjectPool = false /* Metadata: 0x00AF7771 */) => default; // 0x0000000183FB7430-0x0000000183FB7730
	// [XID] // 0x00000001897FCAA0-0x00000001897FCAC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7772 */, bool useObjectPool = false /* Metadata: 0x00AF7776 */) => default; // 0x0000000183FB6270-0x0000000183FB6B60
	[BlackList] // 0x0000000189803F90-0x0000000189803FD0
	// [XID] // 0x0000000189803F90-0x0000000189803FD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183FB5820-0x0000000183FB5AF0
	// [XID] // 0x000000018980E4F0-0x000000018980E510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183FB7BC0-0x0000000183FB8360
	[BlackList] // 0x0000000189815C10-0x0000000189815C50
	// [XID] // 0x0000000189815C10-0x0000000189815C50
	public virtual void AutoAllocTypeFields() {} // 0x0000000183FB5AF0-0x0000000183FB5B90
	[BlackList] // 0x0000000189820750-0x0000000189820790
	// [XID] // 0x0000000189820750-0x0000000189820790
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183FB5B90-0x0000000183FB5E90
	[BlackList] // 0x000000018982AC50-0x000000018982AC90
	// [XID] // 0x000000018982AC50-0x000000018982AC90
	public virtual void ReturnToObjectPool() {} // 0x0000000183FB87A0-0x0000000183FB8840
	[BlackList] // 0x00000001898350B0-0x00000001898350F0
	// [XID] // 0x00000001898350B0-0x00000001898350F0
	public virtual void OnPoolAllocated() {} // 0x0000000183FB8660-0x0000000183FB8700
	[BlackList] // 0x000000018983F6D0-0x000000018983F710
	// [XID] // 0x000000018983F6D0-0x000000018983F710
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183FB85C0-0x0000000183FB8660
}

