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
public class ConfigWidgetClientDetector : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19137
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x30
	private SimpleSafeUInt32 allowCityIdRawNum; // 0x34
	private SimpleSafeUInt32 hintGroupRawNum; // 0x38
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x3C
	private SimpleSafeFloat heightRawNum; // 0x40

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189864190-0x00000001898641B0 */ get => default; /* [XID] */ /* 0x000000018986B5A0-0x000000018986B5C0 */ private set {} } // 0x00000001854B4940-0x00000001854B4A10 0x00000001854B47F0-0x00000001854B48D0
	public uint allowCityId { /* [XID] */ /* 0x0000000189872970-0x0000000189872990 */ get => default; /* [XID] */ /* 0x000000018987A5F0-0x000000018987A610 */ private set {} } // 0x00000001854B54E0-0x00000001854B55B0 0x00000001854B44F0-0x00000001854B45D0
	public uint hintGroup { /* [XID] */ /* 0x0000000189881740-0x0000000189881760 */ get => default; /* [XID] */ /* 0x0000000189888D00-0x0000000189888D20 */ private set {} } // 0x00000001854B39D0-0x00000001854B3AA0 0x00000001854B2B80-0x00000001854B2C60
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189890080-0x00000001898900A0 */ get => default; /* [XID] */ /* 0x00000001898975C0-0x00000001898975E0 */ private set {} } // 0x00000001854B5D50-0x00000001854B5E30 0x00000001854B5E30-0x00000001854B5F10
	public float height { /* [XID] */ /* 0x000000018989EB20-0x000000018989EB40 */ get => default; /* [XID] */ /* 0x00000001898A6580-0x00000001898A65A0 */ private set {} } // 0x00000001854B5B10-0x00000001854B5BF0 0x00000001854B53A0-0x00000001854B5480

	// Constructors
	public ConfigWidgetClientDetector() {} // 0x00000001854B5FB0-0x00000001854B6010

	// Methods
	// [XID] // 0x00000001898ADCD0-0x00000001898ADCF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001854B5BF0-0x00000001854B5D50
	// [XID] // 0x00000001898B5190-0x00000001898B51B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001854B55B0-0x00000001854B5660
	// [XID] // 0x00000001898BCC60-0x00000001898BCC80
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC30D */) => default; // 0x00000001854B5010-0x00000001854B50F0
	// [XID] // 0x00000001898C43C0-0x00000001898C43E0
	public override int GetHashNum() => default; // 0x00000001854B3900-0x00000001854B39D0
	// [XID] // 0x00000001898CB970-0x00000001898CB990
	public override void InitEmpty() {} // 0x00000001854B4A10-0x00000001854B4B40
	[BlackList] // 0x00000001898D3130-0x00000001898D3170
	// [XID] // 0x00000001898D3130-0x00000001898D3170
	public override bool FromJson(JSONNode node) => default; // 0x00000001854B4170-0x00000001854B44F0
	// [XID] // 0x00000001898DDFA0-0x00000001898DDFC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001854B2C60-0x00000001854B3320
	[BlackList] // 0x00000001898E5820-0x00000001898E5860
	// [XID] // 0x00000001898E5820-0x00000001898E5860
	public static new ConfigWidgetClientDetector ParseFromJson(JSONNode node) => default; // 0x00000001854B5150-0x00000001854B53A0
	// [XID] // 0x00000001898F01C0-0x00000001898F01E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC30E */, bool useObjectPool = false /* Metadata: 0x00AFC312 */) => default; // 0x00000001854B4D10-0x00000001854B5010
	// [XID] // 0x00000001898F7CB0-0x00000001898F7CD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC313 */, bool useObjectPool = false /* Metadata: 0x00AFC317 */) => default; // 0x00000001854B3B80-0x00000001854B4070
	// [XID] // 0x00000001898FF1F0-0x00000001898FF210
	public static new ConfigWidgetClientDetector ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC318 */, bool useObjectPool = false /* Metadata: 0x00AFC31C */) => default; // 0x00000001854B45D0-0x00000001854B47F0
	[BlackList] // 0x0000000189906990-0x00000001899069D0
	// [XID] // 0x0000000189906990-0x00000001899069D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001854B3320-0x00000001854B35F0
	// [XID] // 0x0000000189911140-0x0000000189911160
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001854B5660-0x00000001854B5B10
	[BlackList] // 0x0000000189918D60-0x0000000189918DA0
	// [XID] // 0x0000000189918D60-0x0000000189918DA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001854B4C20-0x00000001854B4D10
	[BlackList] // 0x00000001899235C0-0x0000000189923600
	// [XID] // 0x00000001899235C0-0x0000000189923600
	public override void AutoAllocTypeFields() {} // 0x00000001854B35F0-0x00000001854B3690
	[BlackList] // 0x000000018992DCD0-0x000000018992DD10
	// [XID] // 0x000000018992DCD0-0x000000018992DD10
	public override void AutoRecycleTypeFields() {} // 0x00000001854B3690-0x00000001854B37E0
	[BlackList] // 0x0000000189938050-0x0000000189938090
	// [XID] // 0x0000000189938050-0x0000000189938090
	public override void ReturnToObjectPool() {} // 0x00000001854B5F10-0x00000001854B5FB0
}

