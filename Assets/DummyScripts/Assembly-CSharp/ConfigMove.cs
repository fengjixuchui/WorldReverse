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
public class ConfigMove : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18573
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveVelocityForce _velocityForce; // 0x10

	// Properties
	public ConfigMoveVelocityForce velocityForce { /* [XID] */ /* 0x000000018962DE50-0x000000018962DE70 */ get => default; /* [XID] */ /* 0x0000000189635A90-0x0000000189635AB0 */ private set {} } // 0x00000001824E4460-0x00000001824E4500 0x00000001824E4890-0x00000001824E4940

	// Constructors
	public ConfigMove() {} // 0x00000001824E5490-0x00000001824E54F0

	// Methods
	// [XID] // 0x000000018963D0F0-0x000000018963D110
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001824E51D0-0x00000001824E52B0
	// [XID] // 0x0000000189644670-0x0000000189644690
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001824E4F20-0x00000001824E4FF0
	// [XID] // 0x000000018964BF10-0x000000018964BF30
	public virtual ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA47B */) => default; // 0x00000001824E4C40-0x00000001824E4D20
	// [XID] // 0x0000000189653560-0x0000000189653580
	public virtual int GetHashNum() => default; // 0x00000001824E3DC0-0x00000001824E3E90
	// [XID] // 0x000000018965AD90-0x000000018965ADB0
	public virtual void InitEmpty() {} // 0x00000001824E46D0-0x00000001824E47A0
	[BlackList] // 0x0000000189662340-0x0000000189662380
	// [XID] // 0x0000000189662340-0x0000000189662380
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001824E40E0-0x00000001824E4460
	// [XID] // 0x000000018966CB20-0x000000018966CB40
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001824E3730-0x00000001824E3930
	[BlackList] // 0x0000000189674910-0x0000000189674950
	// [XID] // 0x0000000189674910-0x0000000189674950
	public static ConfigMove ParseFromJson(JSONNode node) => default; // 0x00000001824E4D20-0x00000001824E4F20
	// [XID] // 0x000000018967EF00-0x000000018967EF20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA47C */, bool useObjectPool = false /* Metadata: 0x00AFA480 */) => default; // 0x00000001824E4940-0x00000001824E4C40
	// [XID] // 0x0000000189686870-0x0000000189686890
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA481 */, bool useObjectPool = false /* Metadata: 0x00AFA485 */) => default; // 0x00000001824E3E90-0x00000001824E40E0
	// [XID] // 0x000000018968E670-0x000000018968E690
	public static ConfigMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA486 */, bool useObjectPool = false /* Metadata: 0x00AFA48A */) => default; // 0x00000001824E4500-0x00000001824E46D0
	[BlackList] // 0x0000000189696110-0x0000000189696150
	// [XID] // 0x0000000189696110-0x0000000189696150
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001824E3930-0x00000001824E3C00
	// [XID] // 0x00000001896A0390-0x00000001896A03B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001824E4FF0-0x00000001824E51D0
	[BlackList] // 0x00000001896A7860-0x00000001896A78A0
	// [XID] // 0x00000001896A7860-0x00000001896A78A0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001824E47A0-0x00000001824E4890
	[BlackList] // 0x00000001896B16F0-0x00000001896B1730
	// [XID] // 0x00000001896B16F0-0x00000001896B1730
	public virtual void AutoAllocTypeFields() {} // 0x00000001824E3C00-0x00000001824E3CA0
	[BlackList] // 0x00000001896BBF00-0x00000001896BBF40
	// [XID] // 0x00000001896BBF00-0x00000001896BBF40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001824E3CA0-0x00000001824E3DC0
	[BlackList] // 0x00000001896C64D0-0x00000001896C6510
	// [XID] // 0x00000001896C64D0-0x00000001896C6510
	public virtual void ReturnToObjectPool() {} // 0x00000001824E53F0-0x00000001824E5490
	[BlackList] // 0x00000001896D0A20-0x00000001896D0A60
	// [XID] // 0x00000001896D0A20-0x00000001896D0A60
	public virtual void OnPoolAllocated() {} // 0x00000001824E5350-0x00000001824E53F0
	[BlackList] // 0x00000001896DAFE0-0x00000001896DB020
	// [XID] // 0x00000001896DAFE0-0x00000001896DB020
	public virtual void OnBeforePoolRecycled() {} // 0x00000001824E52B0-0x00000001824E5350
}

