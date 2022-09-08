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
public class ConfigGuideInfoDialogAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18312
{
	// Fields
	private string _title; // 0x18
	private string _content; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _onOKActions; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _onCancelActions; // 0x30

	// Properties
	public string title { /* [XID] */ /* 0x00000001897D21B0-0x00000001897D21D0 */ get => default; /* [XID] */ /* 0x00000001897DA070-0x00000001897DA090 */ private set {} } // 0x00000001829258D0-0x0000000182925970 0x0000000182924F80-0x0000000182925030
	public string content { /* [XID] */ /* 0x00000001897E1340-0x00000001897E1360 */ get => default; /* [XID] */ /* 0x00000001897E8B90-0x00000001897E8BB0 */ private set {} } // 0x00000001829257D0-0x0000000182925870 0x0000000182926310-0x00000001829263C0
	public ConfigGuideAction[] onOKActions { /* [XID] */ /* 0x00000001897F07E0-0x00000001897F0800 */ get => default; /* [XID] */ /* 0x00000001897F7F20-0x00000001897F7F40 */ private set {} } // 0x0000000182924840-0x00000001829248E0 0x0000000182923470-0x0000000182923520
	public ConfigGuideAction[] onCancelActions { /* [XID] */ /* 0x00000001897FF5B0-0x00000001897FF5D0 */ get => default; /* [XID] */ /* 0x0000000189806CF0-0x0000000189806D10 */ private set {} } // 0x0000000182923D60-0x0000000182923E00 0x00000001829239E0-0x0000000182923A90

	// Constructors
	public ConfigGuideInfoDialogAction() {} // 0x0000000182926460-0x00000001829264C0

	// Methods
	// [XID] // 0x000000018980E3D0-0x000000018980E3F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829261C0-0x0000000182926310
	// [XID] // 0x0000000189815AD0-0x0000000189815AF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182925C20-0x0000000182925D50
	// [XID] // 0x000000018981D570-0x000000018981D590
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF93DB */) => default; // 0x00000001829256F0-0x00000001829257D0
	// [XID] // 0x0000000189824A60-0x0000000189824A80
	public override int GetHashNum() => default; // 0x0000000182924090-0x0000000182924160
	// [XID] // 0x000000018982C450-0x000000018982C470
	public override void InitEmpty() {} // 0x00000001829250A0-0x00000001829251B0
	[BlackList] // 0x0000000189833920-0x0000000189833960
	// [XID] // 0x0000000189833920-0x0000000189833960
	public override bool FromJson(JSONNode node) => default; // 0x00000001829249E0-0x0000000182924D60
	// [XID] // 0x000000018983DC40-0x000000018983DC60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182923520-0x00000001829239E0
	[BlackList] // 0x00000001898454D0-0x0000000189845510
	// [XID] // 0x00000001898454D0-0x0000000189845510
	public static new ConfigGuideInfoDialogAction ParseFromJson(JSONNode node) => default; // 0x0000000182925970-0x0000000182925BC0
	// [XID] // 0x000000018984F840-0x000000018984F860
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93DC */, bool useObjectPool = false /* Metadata: 0x00AF93E0 */) => default; // 0x00000001829253F0-0x00000001829256F0
	// [XID] // 0x0000000189856AE0-0x0000000189856B00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93E1 */, bool useObjectPool = false /* Metadata: 0x00AF93E5 */) => default; // 0x00000001829243F0-0x0000000182924840
	// [XID] // 0x000000018985DCB0-0x000000018985DCD0
	public static new ConfigGuideInfoDialogAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93E6 */, bool useObjectPool = false /* Metadata: 0x00AF93EA */) => default; // 0x0000000182924D60-0x0000000182924F80
	[BlackList] // 0x0000000189865730-0x0000000189865770
	// [XID] // 0x0000000189865730-0x0000000189865770
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182923A90-0x0000000182923D60
	// [XID] // 0x000000018986FB80-0x000000018986FBA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182925DD0-0x00000001829261C0
	[BlackList] // 0x0000000189877270-0x00000001898772B0
	// [XID] // 0x0000000189877270-0x00000001898772B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182925300-0x00000001829253F0
	// [XID] // 0x00000001898818A0-0x00000001898818C0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x0000000182924240-0x00000001829243F0
	// [XID] // 0x0000000189888E80-0x0000000189888EA0
	protected override bool Stop() => default; // 0x00000001829233D0-0x0000000182923470
	[BlackList] // 0x00000001898901C0-0x0000000189890200
	// [XID] // 0x00000001898901C0-0x0000000189890200
	public override void AutoAllocTypeFields() {} // 0x0000000182923E00-0x0000000182923EA0
	[BlackList] // 0x000000018989AA50-0x000000018989AA90
	// [XID] // 0x000000018989AA50-0x000000018989AA90
	public override void AutoRecycleTypeFields() {} // 0x0000000182923EA0-0x0000000182923F70
	[BlackList] // 0x00000001898A4EC0-0x00000001898A4F00
	// [XID] // 0x00000001898A4EC0-0x00000001898A4F00
	public override void ReturnToObjectPool() {} // 0x00000001829263C0-0x0000000182926460
}

