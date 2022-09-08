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
public class SelectActionPointBySelfPos : ConfigActionPointSelectType, IAutoAllocRecycle // TypeDefIndex: 17885
{
	// Fields
	private SimpleSafeFloat distanceRawNum; // 0x10

	// Properties
	public float distance { /* [XID] */ /* 0x0000000189B3E780-0x0000000189B3E7A0 */ get => default; /* [XID] */ /* 0x0000000189B46240-0x0000000189B46260 */ private set {} } // 0x0000000184444470-0x0000000184444550 0x00000001844462C0-0x00000001844463A0

	// Constructors
	public SelectActionPointBySelfPos() {} // 0x0000000184446A90-0x0000000184446B40

	// Methods
	// [XID] // 0x0000000189B4D7D0-0x0000000189B4D7F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844468F0-0x00000001844469F0
	// [XID] // 0x0000000189B54FD0-0x0000000189B54FF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184446650-0x0000000184446700
	// [XID] // 0x0000000189B5C9D0-0x0000000189B5C9F0
	public override ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8029 */) => default; // 0x0000000184446180-0x0000000184446260
	// [XID] // 0x0000000189B64090-0x0000000189B640B0
	public override int GetHashNum() => default; // 0x0000000184444D00-0x0000000184444DD0
	// [XID] // 0x0000000189B6B7F0-0x0000000189B6B810
	public override void InitEmpty() {} // 0x0000000184445BE0-0x0000000184445CB0
	[BlackList] // 0x0000000189B72E30-0x0000000189B72E70
	// [XID] // 0x0000000189B72E30-0x0000000189B72E70
	public override bool FromJson(JSONNode node) => default; // 0x00000001844451E0-0x0000000184445560
	// [XID] // 0x0000000189B7D1C0-0x0000000189B7D1E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184444550-0x00000001844447A0
	[BlackList] // 0x0000000189B84FB0-0x0000000189B84FF0
	// [XID] // 0x0000000189B84FB0-0x0000000189B84FF0
	public static new SelectActionPointBySelfPos ParseFromJson(JSONNode node) => default; // 0x00000001844463A0-0x00000001844465F0
	// [XID] // 0x0000000189B8EE30-0x0000000189B8EE50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF802A */, bool useObjectPool = false /* Metadata: 0x00AF802E */) => default; // 0x0000000184445E80-0x0000000184446180
	// [XID] // 0x0000000189B96340-0x0000000189B96360
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF802F */, bool useObjectPool = false /* Metadata: 0x00AF8033 */) => default; // 0x0000000184444EB0-0x00000001844450E0
	// [XID] // 0x0000000189B9D860-0x0000000189B9D880
	public static new SelectActionPointBySelfPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8034 */, bool useObjectPool = false /* Metadata: 0x00AF8038 */) => default; // 0x00000001844458C0-0x0000000184445AE0
	[BlackList] // 0x0000000189BA52B0-0x0000000189BA52F0
	// [XID] // 0x0000000189BA52B0-0x0000000189BA52F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001844447A0-0x0000000184444A70
	// [XID] // 0x0000000189BAF420-0x0000000189BAF440
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184446700-0x00000001844468F0
	[BlackList] // 0x0000000189BB6A90-0x0000000189BB6AD0
	// [XID] // 0x0000000189BB6A90-0x0000000189BB6AD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184445D90-0x0000000184445E80
	// [XID] // 0x0000000189BC1800-0x0000000189BC1820
	public override LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x0000000184445560-0x00000001844458C0
	[BlackList] // 0x0000000189BC8E40-0x0000000189BC8E80
	// [XID] // 0x0000000189BC8E40-0x0000000189BC8E80
	public override void AutoAllocTypeFields() {} // 0x0000000184444A70-0x0000000184444B10
	[BlackList] // 0x0000000189BD3610-0x0000000189BD3650
	// [XID] // 0x0000000189BD3610-0x0000000189BD3650
	public override void AutoRecycleTypeFields() {} // 0x0000000184444B10-0x0000000184444BE0
	[BlackList] // 0x0000000189BDE060-0x0000000189BDE0A0
	// [XID] // 0x0000000189BDE060-0x0000000189BDE0A0
	public override void ReturnToObjectPool() {} // 0x00000001844469F0-0x0000000184446A90
}

