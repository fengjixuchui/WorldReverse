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
public class ConfigParabolaBulletMoveCorrection : ConfigMoveCorrection, IAutoAllocRecycle // TypeDefIndex: 18616
{
	// Fields
	private SimpleSafeFloat deviationRawNum; // 0x10
	private SimpleSafeFloat fixAngleOfVerRawNum; // 0x14
	private SimpleSafeFloat minSpeedRawNum; // 0x18
	private SimpleSafeFloat maxSpeedRawNum; // 0x1C

	// Properties
	public float deviation { /* [XID] */ /* 0x00000001898A94F0-0x00000001898A9510 */ get => default; /* [XID] */ /* 0x00000001898B0DA0-0x00000001898B0DC0 */ private set {} } // 0x0000000182D952C0-0x0000000182D953A0 0x0000000182D96080-0x0000000182D96160
	public float fixAngleOfVer { /* [XID] */ /* 0x00000001898B8480-0x00000001898B84A0 */ get => default; /* [XID] */ /* 0x00000001898BFC00-0x00000001898BFC20 */ private set {} } // 0x0000000182D95920-0x0000000182D95A00 0x0000000182D951E0-0x0000000182D952C0
	public float minSpeed { /* [XID] */ /* 0x00000001898B7650-0x00000001898B7670 */ get => default; /* [XID] */ /* 0x00000001898CEAB0-0x00000001898CEAD0 */ private set {} } // 0x0000000182D96BA0-0x0000000182D96C80 0x0000000182D96D30-0x0000000182D96E10
	public float maxSpeed { /* [XID] */ /* 0x00000001898D6400-0x00000001898D6420 */ get => default; /* [XID] */ /* 0x00000001898DE0E0-0x00000001898DE100 */ private set {} } // 0x0000000182D95D80-0x0000000182D95E60 0x0000000182D96E10-0x0000000182D96EF0

	// Constructors
	public ConfigParabolaBulletMoveCorrection() {} // 0x0000000182D97490-0x0000000182D97560

	// Methods
	// [XID] // 0x00000001898E58E0-0x00000001898E5900
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D972A0-0x0000000182D973F0
	// [XID] // 0x00000001898ED300-0x00000001898ED320
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D96C80-0x0000000182D96D30
	// [XID] // 0x00000001898F4A60-0x00000001898F4A80
	public override ConfigMoveCorrection Clone(bool useObjectPool = false /* Metadata: 0x00AFA5E5 */) => default; // 0x0000000182D967B0-0x0000000182D96890
	// [XID] // 0x00000001898FC2F0-0x00000001898FC310
	public override int GetHashNum() => default; // 0x0000000182D95110-0x0000000182D951E0
	// [XID] // 0x0000000189903D50-0x0000000189903D70
	public override void InitEmpty() {} // 0x0000000182D961D0-0x0000000182D962E0
	[BlackList] // 0x000000018990B2F0-0x000000018990B330
	// [XID] // 0x000000018990B2F0-0x000000018990B330
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D95A00-0x0000000182D95D80
	// [XID] // 0x0000000189915C80-0x0000000189915CA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D94610-0x0000000182D94B70
	[BlackList] // 0x000000018991D6F0-0x000000018991D730
	// [XID] // 0x000000018991D6F0-0x000000018991D730
	public static new ConfigParabolaBulletMoveCorrection ParseFromJson(JSONNode node) => default; // 0x0000000182D968F0-0x0000000182D96B40
	// [XID] // 0x0000000189927D70-0x0000000189927D90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5E6 */, bool useObjectPool = false /* Metadata: 0x00AFA5EA */) => default; // 0x0000000182D964B0-0x0000000182D967B0
	// [XID] // 0x000000018992F4A0-0x000000018992F4C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5EB */, bool useObjectPool = false /* Metadata: 0x00AFA5EF */) => default; // 0x0000000182D95480-0x0000000182D95820
	// [XID] // 0x0000000189936810-0x0000000189936830
	public static new ConfigParabolaBulletMoveCorrection ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5F0 */, bool useObjectPool = false /* Metadata: 0x00AFA5F4 */) => default; // 0x0000000182D95E60-0x0000000182D96080
	[BlackList] // 0x000000018993E430-0x000000018993E470
	// [XID] // 0x000000018993E430-0x000000018993E470
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D94B70-0x0000000182D94E40
	// [XID] // 0x0000000189948A20-0x0000000189948A40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D96EF0-0x0000000182D972A0
	[BlackList] // 0x0000000189950170-0x00000001899501B0
	// [XID] // 0x0000000189950170-0x00000001899501B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D963C0-0x0000000182D964B0
	[BlackList] // 0x000000018995A7D0-0x000000018995A810
	// [XID] // 0x000000018995A7D0-0x000000018995A810
	public override void AutoAllocTypeFields() {} // 0x0000000182D94E40-0x0000000182D94EE0
	[BlackList] // 0x00000001899651D0-0x0000000189965210
	// [XID] // 0x00000001899651D0-0x0000000189965210
	public override void AutoRecycleTypeFields() {} // 0x0000000182D94EE0-0x0000000182D94FF0
	[BlackList] // 0x000000018996F400-0x000000018996F440
	// [XID] // 0x000000018996F400-0x000000018996F440
	public override void ReturnToObjectPool() {} // 0x0000000182D973F0-0x0000000182D97490
}

