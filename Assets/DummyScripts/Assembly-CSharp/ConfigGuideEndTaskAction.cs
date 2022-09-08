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
public class ConfigGuideEndTaskAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18319
{
	// Fields
	private string _taskName; // 0x18

	// Properties
	public string taskName { /* [XID] */ /* 0x0000000189A4FE40-0x0000000189A4FE60 */ get => default; /* [XID] */ /* 0x0000000189A57370-0x0000000189A57390 */ private set {} } // 0x0000000184581CC0-0x0000000184581D60 0x00000001845819C0-0x0000000184581A70

	// Constructors
	public ConfigGuideEndTaskAction() {} // 0x00000001845822B0-0x0000000184582310

	// Methods
	// [XID] // 0x0000000189A5EED0-0x0000000189A5EEF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184582120-0x0000000184582210
	// [XID] // 0x0000000189A66860-0x0000000189A66880
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184581DC0-0x0000000184581EA0
	// [XID] // 0x0000000189A6E060-0x0000000189A6E080
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF940B */) => default; // 0x0000000184581880-0x0000000184581960
	// [XID] // 0x0000000189A754F0-0x0000000189A75510
	public override int GetHashNum() => default; // 0x0000000184580630-0x0000000184580700
	// [XID] // 0x0000000189A7D230-0x0000000189A7D250
	public override void InitEmpty() {} // 0x0000000184581270-0x0000000184581340
	[BlackList] // 0x0000000189A84A20-0x0000000189A84A60
	// [XID] // 0x0000000189A84A20-0x0000000189A84A60
	public override bool FromJson(JSONNode node) => default; // 0x0000000184580C60-0x0000000184580FE0
	// [XID] // 0x0000000189A8F3B0-0x0000000189A8F3D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018457FEC0-0x00000001845800F0
	[BlackList] // 0x0000000189A96920-0x0000000189A96960
	// [XID] // 0x0000000189A96920-0x0000000189A96960
	public static new ConfigGuideEndTaskAction ParseFromJson(JSONNode node) => default; // 0x0000000184581A70-0x0000000184581CC0
	// [XID] // 0x0000000189AA0CA0-0x0000000189AA0CC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF940C */, bool useObjectPool = false /* Metadata: 0x00AF9410 */) => default; // 0x0000000184581580-0x0000000184581880
	// [XID] // 0x0000000189AA8260-0x0000000189AA8280
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9411 */, bool useObjectPool = false /* Metadata: 0x00AF9415 */) => default; // 0x00000001845808F0-0x0000000184580B60
	// [XID] // 0x0000000189AAFFE0-0x0000000189AB0000
	public static new ConfigGuideEndTaskAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9416 */, bool useObjectPool = false /* Metadata: 0x00AF941A */) => default; // 0x0000000184580FE0-0x0000000184581200
	[BlackList] // 0x0000000189AB7730-0x0000000189AB7770
	// [XID] // 0x0000000189AB7730-0x0000000189AB7770
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001845800F0-0x00000001845803C0
	// [XID] // 0x0000000189AC23E0-0x0000000189AC2400
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184581F20-0x0000000184582120
	[BlackList] // 0x0000000189AC9AE0-0x0000000189AC9B20
	// [XID] // 0x0000000189AC9AE0-0x0000000189AC9B20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184581490-0x0000000184581580
	// [XID] // 0x0000000189AD4780-0x0000000189AD47A0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x00000001845807E0-0x00000001845808F0
	// [XID] // 0x0000000189ADC0C0-0x0000000189ADC0E0
	protected override bool Stop() => default; // 0x000000018457FE20-0x000000018457FEC0
	[BlackList] // 0x0000000189AE3A70-0x0000000189AE3AB0
	// [XID] // 0x0000000189AE3A70-0x0000000189AE3AB0
	public override void AutoAllocTypeFields() {} // 0x00000001845803C0-0x0000000184580460
	[BlackList] // 0x0000000189AEE5C0-0x0000000189AEE600
	// [XID] // 0x0000000189AEE5C0-0x0000000189AEE600
	public override void AutoRecycleTypeFields() {} // 0x0000000184580460-0x0000000184580510
	[BlackList] // 0x0000000189AF8D30-0x0000000189AF8D70
	// [XID] // 0x0000000189AF8D30-0x0000000189AF8D70
	public override void ReturnToObjectPool() {} // 0x0000000184582210-0x00000001845822B0
}

