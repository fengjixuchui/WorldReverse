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
public class ConfigGuideShowTutorialAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18332
{
	// Fields
	private SimpleSafeUInt32 tutorialIDRawNum; // 0x18

	// Properties
	public uint tutorialID { /* [XID] */ /* 0x00000001898E11C0-0x00000001898E11E0 */ get => default; /* [XID] */ /* 0x00000001898E8B80-0x00000001898E8BA0 */ private set {} } // 0x00000001817A2010-0x00000001817A20E0 0x00000001817A18F0-0x00000001817A19D0

	// Constructors
	public ConfigGuideShowTutorialAction() {} // 0x00000001817A3B20-0x00000001817A3B80

	// Methods
	// [XID] // 0x00000001898F02A0-0x00000001898F02C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817A3990-0x00000001817A3A80
	// [XID] // 0x00000001898F7D70-0x00000001898F7D90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001817A3630-0x00000001817A36E0
	// [XID] // 0x00000001898FF370-0x00000001898FF390
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF946B */) => default; // 0x00000001817A3240-0x00000001817A3320
	// [XID] // 0x0000000189906B30-0x0000000189906B50
	public override int GetHashNum() => default; // 0x00000001817A1F40-0x00000001817A2010
	// [XID] // 0x000000018990E650-0x000000018990E670
	public override void InitEmpty() {} // 0x00000001817A2C30-0x00000001817A2D00
	[BlackList] // 0x0000000189915CC0-0x0000000189915D00
	// [XID] // 0x0000000189915CC0-0x0000000189915D00
	public override bool FromJson(JSONNode node) => default; // 0x00000001817A2620-0x00000001817A29A0
	// [XID] // 0x00000001899204D0-0x00000001899204F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817A1690-0x00000001817A18F0
	[BlackList] // 0x0000000189927D90-0x0000000189927DD0
	// [XID] // 0x0000000189927D90-0x0000000189927DD0
	public static new ConfigGuideShowTutorialAction ParseFromJson(JSONNode node) => default; // 0x00000001817A3380-0x00000001817A35D0
	// [XID] // 0x00000001899323E0-0x0000000189932400
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF946C */, bool useObjectPool = false /* Metadata: 0x00AF9470 */) => default; // 0x00000001817A2F40-0x00000001817A3240
	// [XID] // 0x0000000189939DF0-0x0000000189939E10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9471 */, bool useObjectPool = false /* Metadata: 0x00AF9475 */) => default; // 0x00000001817A22B0-0x00000001817A2520
	// [XID] // 0x0000000189940FE0-0x0000000189941000
	public static new ConfigGuideShowTutorialAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9476 */, bool useObjectPool = false /* Metadata: 0x00AF947A */) => default; // 0x00000001817A29A0-0x00000001817A2BC0
	[BlackList] // 0x0000000189948A80-0x0000000189948AC0
	// [XID] // 0x0000000189948A80-0x0000000189948AC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817A19D0-0x00000001817A1CA0
	// [XID] // 0x0000000189953170-0x0000000189953190
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817A3760-0x00000001817A3990
	[BlackList] // 0x000000018995A870-0x000000018995A8B0
	// [XID] // 0x000000018995A870-0x000000018995A8B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817A2E50-0x00000001817A2F40
	// [XID] // 0x0000000189965290-0x00000001899652B0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x00000001817A21C0-0x00000001817A22B0
	// [XID] // 0x000000018996C730-0x000000018996C750
	protected override bool Stop() => default; // 0x00000001817A15F0-0x00000001817A1690
	[BlackList] // 0x00000001899741B0-0x00000001899741F0
	// [XID] // 0x00000001899741B0-0x00000001899741F0
	public override void AutoAllocTypeFields() {} // 0x00000001817A1CA0-0x00000001817A1D40
	[BlackList] // 0x000000018997E3E0-0x000000018997E420
	// [XID] // 0x000000018997E3E0-0x000000018997E420
	public override void AutoRecycleTypeFields() {} // 0x00000001817A1D40-0x00000001817A1E20
	[BlackList] // 0x00000001899893A0-0x00000001899893E0
	// [XID] // 0x00000001899893A0-0x00000001899893E0
	public override void ReturnToObjectPool() {} // 0x00000001817A3A80-0x00000001817A3B20
}

