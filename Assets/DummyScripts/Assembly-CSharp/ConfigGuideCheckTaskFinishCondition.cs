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
public class ConfigGuideCheckTaskFinishCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18254
{
	// Fields
	private SimpleSafeUInt32 taskIdRawNum; // 0x20
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public uint taskId { /* [XID] */ /* 0x0000000189853A60-0x0000000189853A80 */ get => default; /* [XID] */ /* 0x000000018985B4F0-0x000000018985B510 */ private set {} } // 0x0000000180F23640-0x0000000180F23710 0x0000000180F22D90-0x0000000180F22E70

	// Constructors
	public ConfigGuideCheckTaskFinishCondition() {} // 0x0000000180F24720-0x0000000180F24800

	// Methods
	// [XID] // 0x0000000189862A70-0x0000000189862A90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F24590-0x0000000180F24680
	// [XID] // 0x0000000189869EA0-0x0000000189869EC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180F24230-0x0000000180F242E0
	// [XID] // 0x00000001898712B0-0x00000001898712D0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF91A3 */) => default; // 0x0000000180F23E40-0x0000000180F23F20
	// [XID] // 0x0000000189878CB0-0x0000000189878CD0
	public override int GetHashNum() => default; // 0x0000000180F22970-0x0000000180F22A40
	// [XID] // 0x0000000189880240-0x0000000189880260
	public override void InitEmpty() {} // 0x0000000180F238A0-0x0000000180F23970
	[BlackList] // 0x0000000189887760-0x00000001898877A0
	// [XID] // 0x0000000189887760-0x00000001898877A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000180F23030-0x0000000180F233B0
	// [XID] // 0x0000000189891980-0x00000001898919A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180F221A0-0x0000000180F22400
	[BlackList] // 0x00000001898992B0-0x00000001898992F0
	// [XID] // 0x00000001898992B0-0x00000001898992F0
	public static new ConfigGuideCheckTaskFinishCondition ParseFromJson(JSONNode node) => default; // 0x0000000180F23F80-0x0000000180F241D0
	// [XID] // 0x00000001898A35E0-0x00000001898A3600
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91A4 */, bool useObjectPool = false /* Metadata: 0x00AF91A8 */) => default; // 0x0000000180F23B40-0x0000000180F23E40
	// [XID] // 0x00000001898AA980-0x00000001898AA9A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91A9 */, bool useObjectPool = false /* Metadata: 0x00AF91AD */) => default; // 0x0000000180F22B20-0x0000000180F22D90
	// [XID] // 0x00000001898B2330-0x00000001898B2350
	public static new ConfigGuideCheckTaskFinishCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91AE */, bool useObjectPool = false /* Metadata: 0x00AF91B2 */) => default; // 0x0000000180F233B0-0x0000000180F235D0
	[BlackList] // 0x00000001898BA0C0-0x00000001898BA100
	// [XID] // 0x00000001898BA0C0-0x00000001898BA100
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F22400-0x0000000180F226D0
	// [XID] // 0x00000001898C4560-0x00000001898C4580
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F24360-0x0000000180F24590
	[BlackList] // 0x00000001898CBA90-0x00000001898CBAD0
	// [XID] // 0x00000001898CBA90-0x00000001898CBAD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180F23A50-0x0000000180F23B40
	// [XID] // 0x00000001898D6500-0x00000001898D6520
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000180F22F70-0x0000000180F23030
	// [XID] // 0x00000001898DE180-0x00000001898DE1A0
	public override bool Ready(object body = null) => default; // 0x0000000180F23710-0x0000000180F23820
	[BlackList] // 0x00000001898E5960-0x00000001898E59A0
	// [XID] // 0x00000001898E5960-0x00000001898E59A0
	public override void AutoAllocTypeFields() {} // 0x0000000180F226D0-0x0000000180F22770
	[BlackList] // 0x00000001898F02C0-0x00000001898F0300
	// [XID] // 0x00000001898F02C0-0x00000001898F0300
	public override void AutoRecycleTypeFields() {} // 0x0000000180F22770-0x0000000180F22850
	[BlackList] // 0x00000001898FA960-0x00000001898FA9A0
	// [XID] // 0x00000001898FA960-0x00000001898FA9A0
	public override void ReturnToObjectPool() {} // 0x0000000180F24680-0x0000000180F24720
}

