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
public class ConfigWidgetPredict_CollisionDetect : ConfigWidgetPredict, IAutoAllocRecycle // TypeDefIndex: 19178
{
	// Fields
	private SimpleSafeFloat widgetDistanceRawNum; // 0x10
	private SimpleSafeFloat widgetRadiusRawNum; // 0x14
	private bool _includeWater; // 0x18
	private bool _includeNpc; // 0x19

	// Properties
	public float widgetDistance { /* [XID] */ /* 0x0000000189737480-0x00000001897374A0 */ get => default; /* [XID] */ /* 0x000000018973EEE0-0x000000018973EF00 */ private set {} } // 0x000000018343B1D0-0x000000018343B2B0 0x000000018343AB50-0x000000018343AC30
	public float widgetRadius { /* [XID] */ /* 0x0000000189746140-0x0000000189746160 */ get => default; /* [XID] */ /* 0x000000018974DCF0-0x000000018974DD10 */ private set {} } // 0x000000018343BD90-0x000000018343BE70 0x000000018343C5D0-0x000000018343C6B0
	public bool includeWater { /* [XID] */ /* 0x0000000189755350-0x0000000189755370 */ get => default; /* [XID] */ /* 0x000000018975C4F0-0x000000018975C510 */ private set {} } // 0x000000018343B960-0x000000018343BA00 0x000000018343BF80-0x000000018343C030
	public bool includeNpc { /* [XID] */ /* 0x0000000189763E40-0x0000000189763E60 */ get => default; /* [XID] */ /* 0x000000018976B6A0-0x000000018976B6C0 */ private set {} } // 0x000000018343A400-0x000000018343A4A0 0x000000018343C3D0-0x000000018343C480

	// Constructors
	public ConfigWidgetPredict_CollisionDetect() {} // 0x000000018343C750-0x000000018343C7B0

	// Methods
	// [XID] // 0x0000000189772C00-0x0000000189772C20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018343C480-0x000000018343C5D0
	// [XID] // 0x000000018977A300-0x000000018977A320
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018343BED0-0x000000018343BF80
	// [XID] // 0x0000000189781F40-0x0000000189781F60
	public override ConfigWidgetPredict Clone(bool useObjectPool = false /* Metadata: 0x00AFC467 */) => default; // 0x000000018343BA00-0x000000018343BAE0
	// [XID] // 0x0000000189789320-0x0000000189789340
	public override int GetHashNum() => default; // 0x000000018343A4A0-0x000000018343A570
	// [XID] // 0x0000000189790970-0x0000000189790990
	public override void InitEmpty() {} // 0x000000018343B320-0x000000018343B400
	[BlackList] // 0x0000000189798280-0x00000001897982C0
	// [XID] // 0x0000000189798280-0x00000001897982C0
	public override bool FromJson(JSONNode node) => default; // 0x000000018343AC30-0x000000018343AFB0
	// [XID] // 0x00000001897A2E80-0x00000001897A2EA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183439840-0x0000000183439D50
	[BlackList] // 0x00000001897AA4E0-0x00000001897AA520
	// [XID] // 0x00000001897AA4E0-0x00000001897AA520
	public static new ConfigWidgetPredict_CollisionDetect ParseFromJson(JSONNode node) => default; // 0x000000018343BB40-0x000000018343BD90
	// [XID] // 0x00000001897B5750-0x00000001897B5770
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC468 */, bool useObjectPool = false /* Metadata: 0x00AFC46C */) => default; // 0x000000018343B5D0-0x000000018343B8D0
	// [XID] // 0x00000001897BD400-0x00000001897BD420
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC46D */, bool useObjectPool = false /* Metadata: 0x00AFC471 */) => default; // 0x000000018343A650-0x000000018343AA50
	// [XID] // 0x00000001897C4740-0x00000001897C4760
	public static new ConfigWidgetPredict_CollisionDetect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC472 */, bool useObjectPool = false /* Metadata: 0x00AFC476 */) => default; // 0x000000018343AFB0-0x000000018343B1D0
	[BlackList] // 0x00000001897CBEF0-0x00000001897CBF30
	// [XID] // 0x00000001897CBEF0-0x00000001897CBF30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183439D50-0x000000018343A020
	// [XID] // 0x00000001897D6860-0x00000001897D6880
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018343C030-0x000000018343C3D0
	[BlackList] // 0x00000001897DE0D0-0x00000001897DE110
	// [XID] // 0x00000001897DE0D0-0x00000001897DE110
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018343B4E0-0x000000018343B5D0
	[BlackList] // 0x00000001897E8A90-0x00000001897E8AD0
	// [XID] // 0x00000001897E8A90-0x00000001897E8AD0
	public override void AutoAllocTypeFields() {} // 0x000000018343A020-0x000000018343A0C0
	[BlackList] // 0x00000001897F3730-0x00000001897F3770
	// [XID] // 0x00000001897F3730-0x00000001897F3770
	public override void AutoRecycleTypeFields() {} // 0x000000018343A0C0-0x000000018343A1B0
	[BlackList] // 0x00000001897FDAA0-0x00000001897FDAE0
	// [XID] // 0x00000001897FDAA0-0x00000001897FDAE0
	public override void ReturnToObjectPool() {} // 0x000000018343C6B0-0x000000018343C750
	// [XID] // 0x00000001898081A0-0x00000001898081C0
	public override bool DoPredict(LCWidget lcWidget, QuickWidgetGeneral widget) => default; // 0x000000018343A2D0-0x000000018343A400
}

