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
public class DungeonRewardPoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14980
{
	// Fields
	private bool _isActive; // 0x60
	private MoleMole.Config.Vector[] _dropPointList; // 0x68

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x00000001899C49C0-0x00000001899C49E0 */ get => default; } // 0x0000000184274580-0x0000000184274620 
	public bool isActive { /* [XID] */ /* 0x00000001899CC0A0-0x00000001899CC0C0 */ get => default; /* [XID] */ /* 0x00000001899D3670-0x00000001899D3690 */ private set {} } // 0x0000000184274DE0-0x0000000184274E80 0x0000000184273710-0x00000001842737C0
	public MoleMole.Config.Vector[] dropPointList { /* [XID] */ /* 0x00000001899DAC00-0x00000001899DAC20 */ get => default; /* [XID] */ /* 0x00000001899E24A0-0x00000001899E24C0 */ private set {} } // 0x00000001842748D0-0x0000000184274970 0x0000000184273E50-0x0000000184273F00

	// Constructors
	public DungeonRewardPoint() {} // 0x0000000184275030-0x0000000184275090

	// Methods
	// [XID] // 0x00000001899E99E0-0x00000001899E9A00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184274E80-0x0000000184274F90
	// [XID] // 0x00000001899F1230-0x00000001899F1250
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001842749D0-0x0000000184274AB0
	// [XID] // 0x00000001899F8AD0-0x00000001899F8AF0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD68 */) => default; // 0x00000001842744A0-0x0000000184274580
	// [XID] // 0x0000000189A00000-0x0000000189A00020
	public override int GetHashNum() => default; // 0x0000000184273200-0x00000001842732D0
	// [XID] // 0x0000000189A07830-0x0000000189A07850
	public override void InitEmpty() {} // 0x0000000184273F00-0x0000000184273FD0
	[BlackList] // 0x0000000189A0EDB0-0x0000000189A0EDF0
	// [XID] // 0x0000000189A0EDB0-0x0000000189A0EDF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184273840-0x0000000184273BC0
	// [XID] // 0x0000000189A192F0-0x0000000189A19310
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001842729D0-0x0000000184272CC0
	[BlackList] // 0x0000000189A20990-0x0000000189A209D0
	// [XID] // 0x0000000189A20990-0x0000000189A209D0
	public static new DungeonRewardPoint ParseFromJson(JSONNode node) => default; // 0x0000000184274680-0x00000001842748D0
	// [XID] // 0x0000000189A2ADC0-0x0000000189A2ADE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD69 */, bool useObjectPool = false /* Metadata: 0x00AEFD6D */) => default; // 0x00000001842741A0-0x00000001842744A0
	// [XID] // 0x0000000189A32300-0x0000000189A32320
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD6E */, bool useObjectPool = false /* Metadata: 0x00AEFD72 */) => default; // 0x00000001842733B0-0x0000000184273690
	// [XID] // 0x0000000189A39D90-0x0000000189A39DB0
	public static new DungeonRewardPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD73 */, bool useObjectPool = false /* Metadata: 0x00AEFD77 */) => default; // 0x0000000184273BC0-0x0000000184273DE0
	[BlackList] // 0x0000000189A41610-0x0000000189A41650
	// [XID] // 0x0000000189A41610-0x0000000189A41650
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184272CC0-0x0000000184272F90
	// [XID] // 0x0000000189A4BBA0-0x0000000189A4BBC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184274B20-0x0000000184274DE0
	[BlackList] // 0x0000000189A53280-0x0000000189A532C0
	// [XID] // 0x0000000189A53280-0x0000000189A532C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001842740B0-0x00000001842741A0
	[BlackList] // 0x0000000189A5DDE0-0x0000000189A5DE20
	// [XID] // 0x0000000189A5DDE0-0x0000000189A5DE20
	public override void AutoAllocTypeFields() {} // 0x0000000184272F90-0x0000000184273030
	[BlackList] // 0x0000000189A689B0-0x0000000189A689F0
	// [XID] // 0x0000000189A689B0-0x0000000189A689F0
	public override void AutoRecycleTypeFields() {} // 0x0000000184273030-0x00000001842730E0
	[BlackList] // 0x0000000189A72EC0-0x0000000189A72F00
	// [XID] // 0x0000000189A72EC0-0x0000000189A72F00
	public override void ReturnToObjectPool() {} // 0x0000000184274F90-0x0000000184275030
}

