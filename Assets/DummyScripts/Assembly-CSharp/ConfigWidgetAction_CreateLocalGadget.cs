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
public class ConfigWidgetAction_CreateLocalGadget : ConfigWidgetAction, IAutoAllocRecycle // TypeDefIndex: 19165
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x10

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189822FF0-0x0000000189823010 */ get => default; /* [XID] */ /* 0x000000018982AA30-0x000000018982AA50 */ private set {} } // 0x0000000183ACD800-0x0000000183ACD8D0 0x0000000183ACD6B0-0x0000000183ACD790

	// Constructors
	public ConfigWidgetAction_CreateLocalGadget() {} // 0x0000000183ACE850-0x0000000183ACE8B0

	// Methods
	// [XID] // 0x0000000189831ED0-0x0000000189831EF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183ACE6C0-0x0000000183ACE7B0
	// [XID] // 0x00000001898394E0-0x0000000189839500
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183ACE3E0-0x0000000183ACE490
	// [XID] // 0x0000000189840B60-0x0000000189840B80
	public override ConfigWidgetAction Clone(bool useObjectPool = false /* Metadata: 0x00AFC3F7 */) => default; // 0x0000000183ACDFF0-0x0000000183ACE0D0
	// [XID] // 0x0000000189847FA0-0x0000000189847FC0
	public override int GetHashNum() => default; // 0x0000000183ACCBF0-0x0000000183ACCCC0
	// [XID] // 0x000000018984F6E0-0x000000018984F700
	public override void InitEmpty() {} // 0x0000000183ACD960-0x0000000183ACDA30
	[BlackList] // 0x00000001898568C0-0x0000000189856900
	// [XID] // 0x00000001898568C0-0x0000000189856900
	public override bool FromJson(JSONNode node) => default; // 0x0000000183ACD110-0x0000000183ACD490
	// [XID] // 0x0000000189860D70-0x0000000189860D90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183ACC420-0x0000000183ACC680
	[BlackList] // 0x0000000189868590-0x00000001898685D0
	// [XID] // 0x0000000189868590-0x00000001898685D0
	public static new ConfigWidgetAction_CreateLocalGadget ParseFromJson(JSONNode node) => default; // 0x0000000183ACE130-0x0000000183ACE380
	// [XID] // 0x0000000189872950-0x0000000189872970
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3F8 */, bool useObjectPool = false /* Metadata: 0x00AFC3FC */) => default; // 0x0000000183ACDC00-0x0000000183ACDF00
	// [XID] // 0x000000018987A5D0-0x000000018987A5F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3FD */, bool useObjectPool = false /* Metadata: 0x00AFC401 */) => default; // 0x0000000183ACCDA0-0x0000000183ACD010
	// [XID] // 0x0000000189881720-0x0000000189881740
	public static new ConfigWidgetAction_CreateLocalGadget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC402 */, bool useObjectPool = false /* Metadata: 0x00AFC406 */) => default; // 0x0000000183ACD490-0x0000000183ACD6B0
	[BlackList] // 0x0000000189888CC0-0x0000000189888D00
	// [XID] // 0x0000000189888CC0-0x0000000189888D00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183ACC680-0x0000000183ACC950
	// [XID] // 0x0000000189893270-0x0000000189893290
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183ACE490-0x0000000183ACE6C0
	[BlackList] // 0x000000018989A970-0x000000018989A9B0
	// [XID] // 0x000000018989A970-0x000000018989A9B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183ACDB10-0x0000000183ACDC00
	[BlackList] // 0x00000001898A4D80-0x00000001898A4DC0
	// [XID] // 0x00000001898A4D80-0x00000001898A4DC0
	public override void AutoAllocTypeFields() {} // 0x0000000183ACC950-0x0000000183ACC9F0
	[BlackList] // 0x00000001898AF570-0x00000001898AF5B0
	// [XID] // 0x00000001898AF570-0x00000001898AF5B0
	public override void AutoRecycleTypeFields() {} // 0x0000000183ACC9F0-0x0000000183ACCAD0
	[BlackList] // 0x00000001898B9F80-0x00000001898B9FC0
	// [XID] // 0x00000001898B9F80-0x00000001898B9FC0
	public override void ReturnToObjectPool() {} // 0x0000000183ACE7B0-0x0000000183ACE850
	// [XID] // 0x00000001898C43A0-0x00000001898C43C0
	public override void DoAction(LCWidget lcWidget, QuickWidgetGeneral widget) {} // 0x0000000183ACDF00-0x0000000183ACDFF0
}

