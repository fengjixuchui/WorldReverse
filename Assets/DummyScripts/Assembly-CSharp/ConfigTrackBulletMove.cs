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
public class ConfigTrackBulletMove : ConfigBulletMove, IAutoAllocRecycle // TypeDefIndex: 18620
{
	// Fields
	private bool _destroyWhenTargetDie; // 0x58
	private bool _traceOnYAxis; // 0x59

	// Properties
	public bool destroyWhenTargetDie { /* [XID] */ /* 0x0000000189A51590-0x0000000189A515B0 */ get => default; /* [XID] */ /* 0x0000000189A58C00-0x0000000189A58C20 */ private set {} } // 0x0000000183574D00-0x0000000183574DA0 0x0000000183574E20-0x0000000183574ED0
	public bool traceOnYAxis { /* [XID] */ /* 0x0000000189A605E0-0x0000000189A60600 */ get => default; /* [XID] */ /* 0x0000000189A682B0-0x0000000189A682D0 */ private set {} } // 0x00000001835754E0-0x0000000183575580 0x0000000183576330-0x00000001835763E0

	// Constructors
	public ConfigTrackBulletMove() {} // 0x0000000183576480-0x00000001835764E0

	// Methods
	// [XID] // 0x0000000189A6F640-0x0000000189A6F660
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183576220-0x0000000183576330
	// [XID] // 0x0000000189A76DD0-0x0000000189A76DF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183575EE0-0x0000000183575F90
	// [XID] // 0x0000000189A7E890-0x0000000189A7E8B0
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA605 */) => default; // 0x0000000183575AF0-0x0000000183575BD0
	// [XID] // 0x0000000189A86150-0x0000000189A86170
	public override int GetHashNum() => default; // 0x0000000183574830-0x0000000183574900
	// [XID] // 0x0000000189A8DA90-0x0000000189A8DAB0
	public override void InitEmpty() {} // 0x0000000183575580-0x0000000183575620
	[BlackList] // 0x0000000189A95010-0x0000000189A95050
	// [XID] // 0x0000000189A95010-0x0000000189A95050
	public override bool FromJson(JSONNode node) => default; // 0x0000000183574ED0-0x0000000183575250
	// [XID] // 0x0000000189A9F770-0x0000000189A9F790
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183574020-0x00000001835742F0
	[BlackList] // 0x0000000189AA6FE0-0x0000000189AA7020
	// [XID] // 0x0000000189AA6FE0-0x0000000189AA7020
	public static new ConfigTrackBulletMove ParseFromJson(JSONNode node) => default; // 0x0000000183575C30-0x0000000183575E80
	// [XID] // 0x0000000189AB1AC0-0x0000000189AB1AE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA606 */, bool useObjectPool = false /* Metadata: 0x00AFA60A */) => default; // 0x00000001835757F0-0x0000000183575AF0
	// [XID] // 0x0000000189AB8D90-0x0000000189AB8DB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA60B */, bool useObjectPool = false /* Metadata: 0x00AFA60F */) => default; // 0x00000001835749E0-0x0000000183574C80
	// [XID] // 0x0000000189AC08D0-0x0000000189AC08F0
	public static new ConfigTrackBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA610 */, bool useObjectPool = false /* Metadata: 0x00AFA614 */) => default; // 0x0000000183575250-0x0000000183575470
	[BlackList] // 0x0000000189AC82B0-0x0000000189AC82F0
	// [XID] // 0x0000000189AC82B0-0x0000000189AC82F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835742F0-0x00000001835745C0
	// [XID] // 0x0000000189AD2D60-0x0000000189AD2D80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183575F90-0x0000000183576220
	[BlackList] // 0x0000000189ADA7A0-0x0000000189ADA7E0
	// [XID] // 0x0000000189ADA7A0-0x0000000189ADA7E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183575700-0x00000001835757F0
	[BlackList] // 0x0000000189AE5440-0x0000000189AE5480
	// [XID] // 0x0000000189AE5440-0x0000000189AE5480
	public override void AutoAllocTypeFields() {} // 0x00000001835745C0-0x0000000183574660
	[BlackList] // 0x0000000189AEFEB0-0x0000000189AEFEF0
	// [XID] // 0x0000000189AEFEB0-0x0000000189AEFEF0
	public override void AutoRecycleTypeFields() {} // 0x0000000183574660-0x0000000183574710
	[BlackList] // 0x0000000189AFA500-0x0000000189AFA540
	// [XID] // 0x0000000189AFA500-0x0000000189AFA540
	public override void ReturnToObjectPool() {} // 0x00000001835763E0-0x0000000183576480
}

