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
public class ConfigConstForceField : ConfigForceField, IAutoAllocRecycle // TypeDefIndex: 18916
{
	// Fields
	private SimpleSafeFloat velocityRawNum; // 0x60

	// Properties
	public float velocity { /* [XID] */ /* 0x00000001899FD6B0-0x00000001899FD6D0 */ get => default; /* [XID] */ /* 0x00000001899622B0-0x00000001899622D0 */ private set {} } // 0x000000018478D380-0x000000018478D460 0x000000018478CB50-0x000000018478CC30

	// Constructors
	public ConfigConstForceField() {} // 0x000000018478DB50-0x000000018478DBB0

	// Methods
	// [XID] // 0x00000001899696E0-0x0000000189969700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018478D9B0-0x000000018478DAB0
	// [XID] // 0x00000001899713E0-0x0000000189971400
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018478D710-0x000000018478D7C0
	// [XID] // 0x0000000189978D90-0x0000000189978DB0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB38B */) => default; // 0x000000018478D240-0x000000018478D320
	// [XID] // 0x000000018997FE60-0x000000018997FE80
	public override int GetHashNum() => default; // 0x000000018478C090-0x000000018478C160
	// [XID] // 0x0000000189987650-0x0000000189987670
	public override void InitEmpty() {} // 0x000000018478CCA0-0x000000018478CD70
	[BlackList] // 0x000000018998F260-0x000000018998F2A0
	// [XID] // 0x000000018998F260-0x000000018998F2A0
	public override bool FromJson(JSONNode node) => default; // 0x000000018478C5B0-0x000000018478C930
	// [XID] // 0x000000018999A0F0-0x000000018999A110
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018478B8B0-0x000000018478BB20
	[BlackList] // 0x00000001899A1710-0x00000001899A1750
	// [XID] // 0x00000001899A1710-0x00000001899A1750
	public static new ConfigConstForceField ParseFromJson(JSONNode node) => default; // 0x000000018478D460-0x000000018478D6B0
	// [XID] // 0x00000001899AC250-0x00000001899AC270
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB38C */, bool useObjectPool = false /* Metadata: 0x00AFB390 */) => default; // 0x000000018478CF40-0x000000018478D240
	// [XID] // 0x00000001899B3AA0-0x00000001899B3AC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB391 */, bool useObjectPool = false /* Metadata: 0x00AFB395 */) => default; // 0x000000018478C240-0x000000018478C4B0
	// [XID] // 0x00000001899BAF30-0x00000001899BAF50
	public static new ConfigConstForceField ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB396 */, bool useObjectPool = false /* Metadata: 0x00AFB39A */) => default; // 0x000000018478C930-0x000000018478CB50
	[BlackList] // 0x00000001899C28A0-0x00000001899C28E0
	// [XID] // 0x00000001899C28A0-0x00000001899C28E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018478BB20-0x000000018478BDF0
	// [XID] // 0x00000001899CCFB0-0x00000001899CCFD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018478D7C0-0x000000018478D9B0
	[BlackList] // 0x00000001899D4590-0x00000001899D45D0
	// [XID] // 0x00000001899D4590-0x00000001899D45D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018478CE50-0x000000018478CF40
	[BlackList] // 0x00000001899DE970-0x00000001899DE9B0
	// [XID] // 0x00000001899DE970-0x00000001899DE9B0
	public override void AutoAllocTypeFields() {} // 0x000000018478BDF0-0x000000018478BE90
	[BlackList] // 0x00000001899E9300-0x00000001899E9340
	// [XID] // 0x00000001899E9300-0x00000001899E9340
	public override void AutoRecycleTypeFields() {} // 0x000000018478BE90-0x000000018478BF70
	[BlackList] // 0x00000001899F3EF0-0x00000001899F3F30
	// [XID] // 0x00000001899F3EF0-0x00000001899F3F30
	public override void ReturnToObjectPool() {} // 0x000000018478DAB0-0x000000018478DB50
}

