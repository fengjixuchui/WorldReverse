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
public class ConfigWidgetTreasureMapDetector : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19143
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x30
	private SimpleSafeUInt32 radiusSuccRawNum; // 0x34
	private SimpleSafeUInt32 detectRangeRawNum; // 0x38
	private SimpleSafeUInt32 gadgetDurationRawNum; // 0x3C

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189AFA4A0-0x0000000189AFA4C0 */ get => default; /* [XID] */ /* 0x0000000189B01980-0x0000000189B019A0 */ private set {} } // 0x0000000183143000-0x00000001831430D0 0x0000000183142EB0-0x0000000183142F90
	public uint radiusSucc { /* [XID] */ /* 0x0000000189B08E90-0x0000000189B08EB0 */ get => default; /* [XID] */ /* 0x0000000189B10950-0x0000000189B10970 */ private set {} } // 0x00000001831437E0-0x00000001831438B0 0x0000000183144280-0x0000000183144360
	public uint detectRange { /* [XID] */ /* 0x0000000189B17A40-0x0000000189B17A60 */ get => default; /* [XID] */ /* 0x0000000189B1F400-0x0000000189B1F420 */ private set {} } // 0x0000000183142130-0x0000000183142200 0x0000000183144360-0x0000000183144440
	public uint gadgetDuration { /* [XID] */ /* 0x0000000189B26C80-0x0000000189B26CA0 */ get => default; /* [XID] */ /* 0x0000000189B2DED0-0x0000000189B2DEF0 */ private set {} } // 0x0000000183144060-0x0000000183144130 0x0000000183142200-0x00000001831422E0

	// Constructors
	public ConfigWidgetTreasureMapDetector() {} // 0x00000001831444E0-0x0000000183144540

	// Methods
	// [XID] // 0x0000000189B35280-0x0000000189B352A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183144130-0x0000000183144280
	// [XID] // 0x0000000189B3CB20-0x0000000189B3CB40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183143B60-0x0000000183143C10
	// [XID] // 0x0000000189B44810-0x0000000189B44830
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC33D */) => default; // 0x00000001831436A0-0x0000000183143780
	// [XID] // 0x0000000189B4C100-0x0000000189B4C120
	public override int GetHashNum() => default; // 0x0000000183142060-0x0000000183142130
	// [XID] // 0x0000000189B53660-0x0000000189B53680
	public override void InitEmpty() {} // 0x00000001831430D0-0x00000001831431D0
	[BlackList] // 0x0000000189B5AE10-0x0000000189B5AE50
	// [XID] // 0x0000000189B5AE10-0x0000000189B5AE50
	public override bool FromJson(JSONNode node) => default; // 0x0000000183142910-0x0000000183142C90
	// [XID] // 0x0000000189B654A0-0x0000000189B654C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183141530-0x0000000183141AC0
	[BlackList] // 0x0000000189B6CAC0-0x0000000189B6CB00
	// [XID] // 0x0000000189B6CAC0-0x0000000189B6CB00
	public static new ConfigWidgetTreasureMapDetector ParseFromJson(JSONNode node) => default; // 0x00000001831438B0-0x0000000183143B00
	// [XID] // 0x0000000189B770D0-0x0000000189B770F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC33E */, bool useObjectPool = false /* Metadata: 0x00AFC342 */) => default; // 0x00000001831433A0-0x00000001831436A0
	// [XID] // 0x0000000189B7E740-0x0000000189B7E760
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC343 */, bool useObjectPool = false /* Metadata: 0x00AFC347 */) => default; // 0x00000001831423C0-0x0000000183142810
	// [XID] // 0x0000000189B86380-0x0000000189B863A0
	public static new ConfigWidgetTreasureMapDetector ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC348 */, bool useObjectPool = false /* Metadata: 0x00AFC34C */) => default; // 0x0000000183142C90-0x0000000183142EB0
	[BlackList] // 0x0000000189B8D3F0-0x0000000189B8D430
	// [XID] // 0x0000000189B8D3F0-0x0000000189B8D430
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183141AC0-0x0000000183141D90
	// [XID] // 0x0000000189B979A0-0x0000000189B979C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183143C10-0x0000000183144060
	[BlackList] // 0x0000000189B9EDF0-0x0000000189B9EE30
	// [XID] // 0x0000000189B9EDF0-0x0000000189B9EE30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831432B0-0x00000001831433A0
	[BlackList] // 0x0000000189BA94E0-0x0000000189BA9520
	// [XID] // 0x0000000189BA94E0-0x0000000189BA9520
	public override void AutoAllocTypeFields() {} // 0x0000000183141D90-0x0000000183141E30
	[BlackList] // 0x0000000189BB3A50-0x0000000189BB3A90
	// [XID] // 0x0000000189BB3A50-0x0000000189BB3A90
	public override void AutoRecycleTypeFields() {} // 0x0000000183141E30-0x0000000183141F40
	[BlackList] // 0x0000000189BBDEF0-0x0000000189BBDF30
	// [XID] // 0x0000000189BBDEF0-0x0000000189BBDF30
	public override void ReturnToObjectPool() {} // 0x0000000183144440-0x00000001831444E0
}

