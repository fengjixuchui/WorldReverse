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
public class ConfigGadgetStateSendEffectTrigger : ConfigGadgetStateAction, IAutoAllocRecycle // TypeDefIndex: 14961
{
	// Fields
	private string _parameter; // 0x20
	private AnimatorParamType _type; // 0x28
	private SimpleSafeInt32 valueRawNum; // 0x2C
	private string _effectPattern; // 0x30

	// Properties
	public string parameter { /* [XID] */ /* 0x0000000189701EA0-0x0000000189701EC0 */ get => default; /* [XID] */ /* 0x0000000189709700-0x0000000189709720 */ private set {} } // 0x0000000182D60A40-0x0000000182D60AE0 0x0000000182D5FCA0-0x0000000182D5FD50
	public AnimatorParamType type { /* [XID] */ /* 0x0000000189711030-0x0000000189711050 */ get => default; /* [XID] */ /* 0x00000001897183F0-0x0000000189718410 */ private set {} } // 0x0000000182D61E60-0x0000000182D61F00 0x0000000182D618A0-0x0000000182D61950
	public int value { /* [XID] */ /* 0x000000018971FD50-0x000000018971FD70 */ get => default; /* [XID] */ /* 0x0000000189727400-0x0000000189727420 */ private set {} } // 0x0000000182D603D0-0x0000000182D604A0 0x0000000182D60270-0x0000000182D60350
	public string effectPattern { /* [XID] */ /* 0x000000018972E970-0x000000018972E990 */ get => default; /* [XID] */ /* 0x00000001897360E0-0x0000000189736100 */ private set {} } // 0x0000000182D60D70-0x0000000182D60E10 0x0000000182D61F00-0x0000000182D61FB0

	// Constructors
	public ConfigGadgetStateSendEffectTrigger() {} // 0x0000000182D62050-0x0000000182D620B0

	// Methods
	// [XID] // 0x00000001896FA810-0x00000001896FA830
	public override void DoAction(BaseEntity entity, GadgetState state) {} // 0x0000000182D61260-0x0000000182D613B0
	// [XID] // 0x000000018973DDF0-0x000000018973DE10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D61D10-0x0000000182D61E60
	// [XID] // 0x0000000189745210-0x0000000189745230
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D617A0-0x0000000182D618A0
	// [XID] // 0x000000018974CCC0-0x000000018974CCE0
	public override ConfigGadgetStateAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFC3D */) => default; // 0x0000000182D613B0-0x0000000182D61490
	// [XID] // 0x0000000189754080-0x00000001897540A0
	public override int GetHashNum() => default; // 0x0000000182D5FB70-0x0000000182D5FC40
	// [XID] // 0x000000018975B4C0-0x000000018975B4E0
	public override void InitEmpty() {} // 0x0000000182D60BE0-0x0000000182D60CF0
	[BlackList] // 0x0000000189762F10-0x0000000189762F50
	// [XID] // 0x0000000189762F10-0x0000000189762F50
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D604A0-0x0000000182D60820
	// [XID] // 0x000000018976D500-0x000000018976D520
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D5F100-0x0000000182D5F600
	[BlackList] // 0x0000000189774970-0x00000001897749B0
	// [XID] // 0x0000000189774970-0x00000001897749B0
	public static new ConfigGadgetStateSendEffectTrigger ParseFromJson(JSONNode node) => default; // 0x0000000182D614F0-0x0000000182D61740
	// [XID] // 0x000000018977F180-0x000000018977F1A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC3E */, bool useObjectPool = false /* Metadata: 0x00AEFC42 */) => default; // 0x0000000182D60F60-0x0000000182D61260
	// [XID] // 0x0000000189786BC0-0x0000000189786BE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC43 */, bool useObjectPool = false /* Metadata: 0x00AEFC47 */) => default; // 0x0000000182D5FDD0-0x0000000182D601F0
	// [XID] // 0x000000018978E1F0-0x000000018978E210
	public static new ConfigGadgetStateSendEffectTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC48 */, bool useObjectPool = false /* Metadata: 0x00AEFC4C */) => default; // 0x0000000182D60820-0x0000000182D60A40
	[BlackList] // 0x00000001897958E0-0x0000000189795920
	// [XID] // 0x00000001897958E0-0x0000000189795920
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D5F600-0x0000000182D5F8D0
	// [XID] // 0x00000001897A0710-0x00000001897A0730
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D61950-0x0000000182D61D10
	[BlackList] // 0x00000001897A7CE0-0x00000001897A7D20
	// [XID] // 0x00000001897A7CE0-0x00000001897A7D20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D60E70-0x0000000182D60F60
	[BlackList] // 0x00000001897B2730-0x00000001897B2770
	// [XID] // 0x00000001897B2730-0x00000001897B2770
	public override void AutoAllocTypeFields() {} // 0x0000000182D5F8D0-0x0000000182D5F970
	[BlackList] // 0x00000001897BDCC0-0x00000001897BDD00
	// [XID] // 0x00000001897BDCC0-0x00000001897BDD00
	public override void AutoRecycleTypeFields() {} // 0x0000000182D5F970-0x0000000182D5FA50
	[BlackList] // 0x00000001897C84D0-0x00000001897C8510
	// [XID] // 0x00000001897C84D0-0x00000001897C8510
	public override void ReturnToObjectPool() {} // 0x0000000182D61FB0-0x0000000182D62050
}

