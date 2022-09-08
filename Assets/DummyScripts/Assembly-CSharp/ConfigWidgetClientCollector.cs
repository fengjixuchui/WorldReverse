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
public class ConfigWidgetClientCollector : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19139
{
	// Fields
	private CollectorType _targetType; // 0x30
	private ElementType _elementType; // 0x34
	private SimpleSafeUInt32 rechargePointsRawNum; // 0x38
	private SimpleSafeUInt32 maxPointsRawNum; // 0x3C
	private SimpleSafeUInt32 effectGadgetIdRawNum; // 0x40
	private SimpleSafeUInt32 useGadgetIdRawNum; // 0x44
	private bool _allowOtherWorld; // 0x48

	// Properties
	public CollectorType targetType { /* [XID] */ /* 0x0000000189949F80-0x0000000189949FA0 */ get => default; /* [XID] */ /* 0x0000000189951A90-0x0000000189951AB0 */ private set {} } // 0x0000000184091F00-0x0000000184091FA0 0x000000018408FFC0-0x0000000184090070
	public ElementType elementType { /* [XID] */ /* 0x0000000189958F70-0x0000000189958F90 */ get => default; /* [XID] */ /* 0x0000000189960780-0x00000001899607A0 */ private set {} } // 0x0000000184091750-0x00000001840917F0 0x0000000184092920-0x00000001840929D0
	public uint rechargePoints { /* [XID] */ /* 0x0000000189968020-0x0000000189968040 */ get => default; /* [XID] */ /* 0x000000018996F340-0x000000018996F360 */ private set {} } // 0x0000000184093490-0x0000000184093560 0x0000000184092840-0x0000000184092920
	public uint maxPoints { /* [XID] */ /* 0x0000000189977000-0x0000000189977020 */ get => default; /* [XID] */ /* 0x000000018997E2E0-0x000000018997E300 */ private set {} } // 0x0000000184090F10-0x0000000184090FE0 0x0000000184092050-0x0000000184092130
	public uint effectGadgetId { /* [XID] */ /* 0x0000000189985E30-0x0000000189985E50 */ get => default; /* [XID] */ /* 0x000000018998DA80-0x000000018998DAA0 */ private set {} } // 0x00000001840937D0-0x00000001840938A0 0x00000001840936F0-0x00000001840937D0
	public uint useGadgetId { /* [XID] */ /* 0x0000000189995570-0x0000000189995590 */ get => default; /* [XID] */ /* 0x000000018999CF90-0x000000018999CFB0 */ private set {} } // 0x0000000184091040-0x0000000184091110 0x0000000184092DD0-0x0000000184092EB0
	public bool allowOtherWorld { /* [XID] */ /* 0x00000001899A4890-0x00000001899A48B0 */ get => default; /* [XID] */ /* 0x00000001899AC1B0-0x00000001899AC1D0 */ private set {} } // 0x0000000184092D30-0x0000000184092DD0 0x0000000184091FA0-0x0000000184092050

	// Constructors
	public ConfigWidgetClientCollector() {} // 0x0000000184093940-0x00000001840939A0

	// Methods
	// [XID] // 0x00000001899B3A00-0x00000001899B3A20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184093560-0x00000001840936F0
	// [XID] // 0x00000001899BAF10-0x00000001899BAF30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184092C80-0x0000000184092D30
	// [XID] // 0x00000001899C2840-0x00000001899C2860
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC31D */) => default; // 0x0000000184092700-0x00000001840927E0
	// [XID] // 0x00000001899C9F60-0x00000001899C9F80
	public override int GetHashNum() => default; // 0x0000000184090E40-0x0000000184090F10
	// [XID] // 0x00000001899D1820-0x00000001899D1840
	public override void InitEmpty() {} // 0x0000000184092130-0x0000000184092230
	[BlackList] // 0x00000001899D8D10-0x00000001899D8D50
	// [XID] // 0x00000001899D8D10-0x00000001899D8D50
	public override bool FromJson(JSONNode node) => default; // 0x00000001840918F0-0x0000000184091C70
	// [XID] // 0x00000001899E3610-0x00000001899E3630
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184090070-0x0000000184090890
	[BlackList] // 0x00000001899EA960-0x00000001899EA9A0
	// [XID] // 0x00000001899EA960-0x00000001899EA9A0
	public static new ConfigWidgetClientCollector ParseFromJson(JSONNode node) => default; // 0x00000001840929D0-0x0000000184092C20
	// [XID] // 0x00000001899F5530-0x00000001899F5550
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC31E */, bool useObjectPool = false /* Metadata: 0x00AFC322 */) => default; // 0x0000000184092400-0x0000000184092700
	// [XID] // 0x00000001899FCB90-0x00000001899FCBB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC323 */, bool useObjectPool = false /* Metadata: 0x00AFC327 */) => default; // 0x0000000184091190-0x0000000184091750
	// [XID] // 0x0000000189A04070-0x0000000189A04090
	public static new ConfigWidgetClientCollector ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC328 */, bool useObjectPool = false /* Metadata: 0x00AFC32C */) => default; // 0x0000000184091C70-0x0000000184091E90
	[BlackList] // 0x0000000189A0B7B0-0x0000000189A0B7F0
	// [XID] // 0x0000000189A0B7B0-0x0000000189A0B7F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184090890-0x0000000184090B60
	// [XID] // 0x0000000189A15DC0-0x0000000189A15DE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184092EB0-0x0000000184093490
	[BlackList] // 0x0000000189A1D2E0-0x0000000189A1D320
	// [XID] // 0x0000000189A1D2E0-0x0000000189A1D320
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184092310-0x0000000184092400
	[BlackList] // 0x0000000189A27700-0x0000000189A27740
	// [XID] // 0x0000000189A27700-0x0000000189A27740
	public override void AutoAllocTypeFields() {} // 0x0000000184090B60-0x0000000184090C00
	[BlackList] // 0x0000000189A31BC0-0x0000000189A31C00
	// [XID] // 0x0000000189A31BC0-0x0000000189A31C00
	public override void AutoRecycleTypeFields() {} // 0x0000000184090C00-0x0000000184090D20
	[BlackList] // 0x0000000189A3C330-0x0000000189A3C370
	// [XID] // 0x0000000189A3C330-0x0000000189A3C370
	public override void ReturnToObjectPool() {} // 0x00000001840938A0-0x0000000184093940
}

