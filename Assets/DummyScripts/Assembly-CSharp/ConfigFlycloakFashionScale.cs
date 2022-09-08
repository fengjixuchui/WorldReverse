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
public class ConfigFlycloakFashionScale : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18080
{
	// Fields
	private SimpleSafeFloat MaleRawNum; // 0x10
	private SimpleSafeFloat LadyRawNum; // 0x14
	private SimpleSafeFloat BoyRawNum; // 0x18
	private SimpleSafeFloat GirlRawNum; // 0x1C
	private SimpleSafeFloat LoliRawNum; // 0x20

	// Properties
	public float Male { /* [XID] */ /* 0x0000000189874BD0-0x0000000189874BF0 */ get => default; /* [XID] */ /* 0x0000000189A306D0-0x0000000189A306F0 */ private set {} } // 0x00000001831390E0-0x00000001831391C0 0x000000018313A0B0-0x000000018313A190
	public float Lady { /* [XID] */ /* 0x0000000189A38070-0x0000000189A38090 */ get => default; /* [XID] */ /* 0x0000000189A3F7E0-0x0000000189A3F800 */ private set {} } // 0x000000018313A810-0x000000018313A8F0 0x0000000183139750-0x0000000183139830
	public float Boy { /* [XID] */ /* 0x0000000189A46E30-0x0000000189A46E50 */ get => default; /* [XID] */ /* 0x0000000189A4E770-0x0000000189A4E790 */ private set {} } // 0x0000000183139830-0x0000000183139910 0x00000001831391C0-0x00000001831392A0
	public float Girl { /* [XID] */ /* 0x000000018988B010-0x000000018988B030 */ get => default; /* [XID] */ /* 0x0000000189A5D760-0x0000000189A5D780 */ private set {} } // 0x00000001831392A0-0x0000000183139380 0x0000000183138D60-0x0000000183138E40
	public float Loli { /* [XID] */ /* 0x0000000189899E10-0x0000000189899E30 */ get => default; /* [XID] */ /* 0x0000000189A6C740-0x0000000189A6C760 */ private set {} } // 0x00000001831383A0-0x0000000183138480 0x0000000183139000-0x00000001831390E0

	// Constructors
	public ConfigFlycloakFashionScale() {} // 0x000000018313A990-0x000000018313AA70

	// Methods
	// [XID] // 0x0000000189A73FF0-0x0000000189A74010
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018313A570-0x000000018313A6D0
	// [XID] // 0x0000000189A7B9E0-0x0000000189A7BA00
	public void InitEmpty() {} // 0x0000000183139C90-0x0000000183139DB0
	[BlackList] // 0x0000000189A83240-0x0000000189A83280
	// [XID] // 0x0000000189A83240-0x0000000189A83280
	public bool FromJson(JSONNode node) => default; // 0x0000000183139910-0x0000000183139C90
	// [XID] // 0x0000000189A8DB50-0x0000000189A8DB70
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183138480-0x0000000183138A90
	// [XID] // 0x0000000189A95110-0x0000000189A95130
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A5F */, bool useObjectPool = false /* Metadata: 0x00AF8A63 */) => default; // 0x0000000183139DB0-0x000000018313A0B0
	// [XID] // 0x0000000189A9C9B0-0x0000000189A9C9D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A64 */, bool useObjectPool = false /* Metadata: 0x00AF8A68 */) => default; // 0x0000000183139380-0x0000000183139750
	[BlackList] // 0x0000000189AA4160-0x0000000189AA41A0
	// [XID] // 0x0000000189AA4160-0x0000000189AA41A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183138A90-0x0000000183138D60
	// [XID] // 0x0000000189AAE760-0x0000000189AAE780
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018313A190-0x000000018313A570
	[BlackList] // 0x0000000189AB5F80-0x0000000189AB5FC0
	// [XID] // 0x0000000189AB5F80-0x0000000189AB5FC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183138E40-0x0000000183138EE0
	[BlackList] // 0x0000000189AC0990-0x0000000189AC09D0
	// [XID] // 0x0000000189AC0990-0x0000000189AC09D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183138EE0-0x0000000183139000
	[BlackList] // 0x0000000189ACB370-0x0000000189ACB3B0
	// [XID] // 0x0000000189ACB370-0x0000000189ACB3B0
	public virtual void ReturnToObjectPool() {} // 0x000000018313A8F0-0x000000018313A990
	[BlackList] // 0x0000000189AD6280-0x0000000189AD62C0
	// [XID] // 0x0000000189AD6280-0x0000000189AD62C0
	public virtual void OnPoolAllocated() {} // 0x000000018313A770-0x000000018313A810
	[BlackList] // 0x0000000189AE0C00-0x0000000189AE0C40
	// [XID] // 0x0000000189AE0C00-0x0000000189AE0C40
	public virtual void OnBeforePoolRecycled() {} // 0x000000018313A6D0-0x000000018313A770
}

