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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigControlPartByIKCCD : ConfigControlPartByIK, IAutoAllocRecycle // TypeDefIndex: 18007
{
	// Fields
	private string _rootName; // 0x50
	private MoleMole.Config.Vector _finalAxialFix; // 0x58
	private SimpleSafeFloat verticalDampingRawNum; // 0x64

	// Properties
	public string rootName { /* [XID] */ /* 0x0000000189849A10-0x0000000189849A30 */ get => default; /* [XID] */ /* 0x0000000189851170-0x0000000189851190 */ private set {} } // 0x000000018393CF90-0x000000018393D030 0x000000018393DFB0-0x000000018393E060
	public MoleMole.Config.Vector finalAxialFix { /* [XID] */ /* 0x0000000189858660-0x0000000189858680 */ get => default; /* [XID] */ /* 0x000000018985F710-0x000000018985F730 */ private set {} } // 0x000000018393C350-0x000000018393C430 0x000000018393C200-0x000000018393C2D0
	public float verticalDamping { /* [XID] */ /* 0x0000000189866F90-0x0000000189866FB0 */ get => default; /* [XID] */ /* 0x000000018986E790-0x000000018986E7B0 */ private set {} } // 0x000000018393BED0-0x000000018393BFB0 0x000000018393CE40-0x000000018393CF20

	// Constructors
	public ConfigControlPartByIKCCD() {} // 0x000000018393E100-0x000000018393E190

	// Methods
	// [XID] // 0x0000000189875BA0-0x0000000189875BC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018393DE60-0x000000018393DFB0
	// [XID] // 0x000000018987D7E0-0x000000018987D800
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018393DA10-0x000000018393DAF0
	// [XID] // 0x00000001898846B0-0x00000001898846D0
	public override ConfigControlPart Clone(bool useObjectPool = false /* Metadata: 0x00AF8659 */) => default; // 0x000000018393D620-0x000000018393D700
	// [XID] // 0x000000018988BCE0-0x000000018988BD00
	public override int GetHashNum() => default; // 0x000000018393C0D0-0x000000018393C1A0
	// [XID] // 0x0000000189893450-0x0000000189893470
	public override void InitEmpty() {} // 0x000000018393D030-0x000000018393D150
	[BlackList] // 0x000000018989AB50-0x000000018989AB90
	// [XID] // 0x000000018989AB50-0x000000018989AB90
	public override bool FromJson(JSONNode node) => default; // 0x000000018393C8A0-0x000000018393CC20
	// [XID] // 0x00000001898A5020-0x00000001898A5040
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018393B650-0x000000018393BA70
	[BlackList] // 0x00000001898AC440-0x00000001898AC480
	// [XID] // 0x00000001898AC440-0x00000001898AC480
	public static new ConfigControlPartByIKCCD ParseFromJson(JSONNode node) => default; // 0x000000018393D760-0x000000018393D9B0
	// [XID] // 0x00000001898B6CF0-0x00000001898B6D10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF865A */, bool useObjectPool = false /* Metadata: 0x00AF865E */) => default; // 0x000000018393D320-0x000000018393D620
	// [XID] // 0x00000001898BE3C0-0x00000001898BE3E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF865F */, bool useObjectPool = false /* Metadata: 0x00AF8663 */) => default; // 0x000000018393C430-0x000000018393C7A0
	// [XID] // 0x00000001898C5C50-0x00000001898C5C70
	public static new ConfigControlPartByIKCCD ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8664 */, bool useObjectPool = false /* Metadata: 0x00AF8668 */) => default; // 0x000000018393CC20-0x000000018393CE40
	[BlackList] // 0x00000001898CD3E0-0x00000001898CD420
	// [XID] // 0x00000001898CD3E0-0x00000001898CD420
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018393BA70-0x000000018393BD40
	// [XID] // 0x00000001898D7D20-0x00000001898D7D40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018393DAF0-0x000000018393DE60
	[BlackList] // 0x00000001898DF9E0-0x00000001898DFA20
	// [XID] // 0x00000001898DF9E0-0x00000001898DFA20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018393D230-0x000000018393D320
	[BlackList] // 0x00000001898EA610-0x00000001898EA650
	// [XID] // 0x00000001898EA610-0x00000001898EA650
	public override void AutoAllocTypeFields() {} // 0x000000018393BD40-0x000000018393BDE0
	[BlackList] // 0x00000001898F4BE0-0x00000001898F4C20
	// [XID] // 0x00000001898F4BE0-0x00000001898F4C20
	public override void AutoRecycleTypeFields() {} // 0x000000018393BDE0-0x000000018393BED0
	[BlackList] // 0x00000001898FF3D0-0x00000001898FF410
	// [XID] // 0x00000001898FF3D0-0x00000001898FF410
	public override void ReturnToObjectPool() {} // 0x000000018393E060-0x000000018393E100
}

