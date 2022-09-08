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
public class ConfigSpeedupField : ConfigConstForceField, IAutoAllocRecycle // TypeDefIndex: 18922
{
	// Fields
	private SimpleSafeFloat attenuationRawNum; // 0x68
	private bool _singleDir; // 0x6C

	// Properties
	public float attenuation { /* [XID] */ /* 0x0000000189BB3AD0-0x0000000189BB3AF0 */ get => default; /* [XID] */ /* 0x0000000189BBB070-0x0000000189BBB090 */ private set {} } // 0x00000001829A6920-0x00000001829A6A00 0x00000001829A6160-0x00000001829A6240
	public bool singleDir { /* [XID] */ /* 0x00000001899EB510-0x00000001899EB530 */ get => default; /* [XID] */ /* 0x0000000189BCA830-0x0000000189BCA850 */ private set {} } // 0x00000001829A5980-0x00000001829A5A20 0x00000001829A5E20-0x00000001829A5ED0

	// Constructors
	public ConfigSpeedupField() {} // 0x00000001829A71A0-0x00000001829A7200

	// Methods
	// [XID] // 0x0000000189BD1DC0-0x0000000189BD1DE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829A6FF0-0x00000001829A7100
	// [XID] // 0x0000000189BD9460-0x0000000189BD9480
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829A6CB0-0x00000001829A6D60
	// [XID] // 0x00000001895E6030-0x00000001895E6050
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB3BB */) => default; // 0x00000001829A67E0-0x00000001829A68C0
	// [XID] // 0x00000001895ED990-0x00000001895ED9B0
	public override int GetHashNum() => default; // 0x00000001829A5470-0x00000001829A5540
	// [XID] // 0x00000001895F5110-0x00000001895F5130
	public override void InitEmpty() {} // 0x00000001829A6240-0x00000001829A6310
	[BlackList] // 0x00000001895FC6B0-0x00000001895FC6F0
	// [XID] // 0x00000001895FC6B0-0x00000001895FC6F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001829A5AA0-0x00000001829A5E20
	// [XID] // 0x0000000189606E80-0x0000000189606EA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829A4BD0-0x00000001829A4F00
	[BlackList] // 0x000000018960E7C0-0x000000018960E800
	// [XID] // 0x000000018960E7C0-0x000000018960E800
	public static new ConfigSpeedupField ParseFromJson(JSONNode node) => default; // 0x00000001829A6A00-0x00000001829A6C50
	// [XID] // 0x0000000189619180-0x00000001896191A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3BC */, bool useObjectPool = false /* Metadata: 0x00AFB3C0 */) => default; // 0x00000001829A64E0-0x00000001829A67E0
	// [XID] // 0x0000000189620700-0x0000000189620720
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3C1 */, bool useObjectPool = false /* Metadata: 0x00AFB3C5 */) => default; // 0x00000001829A5620-0x00000001829A5900
	// [XID] // 0x0000000189627C30-0x0000000189627C50
	public static new ConfigSpeedupField ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3C6 */, bool useObjectPool = false /* Metadata: 0x00AFB3CA */) => default; // 0x00000001829A5ED0-0x00000001829A60F0
	[BlackList] // 0x000000018962F560-0x000000018962F5A0
	// [XID] // 0x000000018962F560-0x000000018962F5A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829A4F00-0x00000001829A51D0
	// [XID] // 0x0000000189639F50-0x0000000189639F70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829A6D60-0x00000001829A6FF0
	[BlackList] // 0x0000000189641460-0x00000001896414A0
	// [XID] // 0x0000000189641460-0x00000001896414A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829A63F0-0x00000001829A64E0
	[BlackList] // 0x000000018964BED0-0x000000018964BF10
	// [XID] // 0x000000018964BED0-0x000000018964BF10
	public override void AutoAllocTypeFields() {} // 0x00000001829A51D0-0x00000001829A5270
	[BlackList] // 0x0000000189656530-0x0000000189656570
	// [XID] // 0x0000000189656530-0x0000000189656570
	public override void AutoRecycleTypeFields() {} // 0x00000001829A5270-0x00000001829A5350
	[BlackList] // 0x0000000189660C10-0x0000000189660C50
	// [XID] // 0x0000000189660C10-0x0000000189660C50
	public override void ReturnToObjectPool() {} // 0x00000001829A7100-0x00000001829A71A0
}

