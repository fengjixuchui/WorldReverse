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
public class ModifySkillCD : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19048
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x10
	private SimpleSafeFloat cdDeltaRawNum; // 0x14
	private SimpleSafeFloat cdRatioRawNum; // 0x18

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001897120D0-0x00000001897120F0 */ get => default; /* [XID] */ /* 0x0000000189719770-0x0000000189719790 */ private set {} } // 0x00000001851A7370-0x00000001851A7440 0x00000001851A8570-0x00000001851A8650
	public float cdDelta { /* [XID] */ /* 0x0000000189720C90-0x0000000189720CB0 */ get => default; /* [XID] */ /* 0x0000000189728310-0x0000000189728330 */ private set {} } // 0x00000001851A7440-0x00000001851A7520 0x00000001851A8030-0x00000001851A8110
	public float cdRatio { /* [XID] */ /* 0x000000018972FA70-0x000000018972FA90 */ get => default; /* [XID] */ /* 0x00000001897374A0-0x00000001897374C0 */ private set {} } // 0x00000001851A6670-0x00000001851A6750 0x00000001851A7CA0-0x00000001851A7D80

	// Constructors
	public ModifySkillCD() {} // 0x00000001851A8820-0x00000001851A8880

	// Methods
	// [XID] // 0x000000018973EF40-0x000000018973EF60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851A8650-0x00000001851A8780
	// [XID] // 0x0000000189746180-0x00000001897461A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851A8170-0x00000001851A8220
	// [XID] // 0x000000018974DD30-0x000000018974DD50
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB8A9 */) => default; // 0x00000001851A7BC0-0x00000001851A7CA0
	// [XID] // 0x0000000189755390-0x00000001897553B0
	public override int GetHashNum() => default; // 0x00000001851A65A0-0x00000001851A6670
	// [XID] // 0x000000018975C550-0x000000018975C570
	public override void InitEmpty() {} // 0x00000001851A7520-0x00000001851A7630
	[BlackList] // 0x0000000189763E60-0x0000000189763EA0
	// [XID] // 0x0000000189763E60-0x0000000189763EA0
	public override bool FromJson(JSONNode node) => default; // 0x00000001851A6CE0-0x00000001851A7060
	// [XID] // 0x000000018976E380-0x000000018976E3A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851A5B40-0x00000001851A5FF0
	[BlackList] // 0x0000000189775C20-0x0000000189775C60
	// [XID] // 0x0000000189775C20-0x0000000189775C60
	public static new ModifySkillCD ParseFromJson(JSONNode node) => default; // 0x00000001851A7DE0-0x00000001851A8030
	// [XID] // 0x0000000189780340-0x0000000189780360
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8AA */, bool useObjectPool = false /* Metadata: 0x00AFB8AE */) => default; // 0x00000001851A7800-0x00000001851A7B00
	// [XID] // 0x0000000189787B00-0x0000000189787B20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8AF */, bool useObjectPool = false /* Metadata: 0x00AFB8B3 */) => default; // 0x00000001851A6830-0x00000001851A6BE0
	// [XID] // 0x000000018978F120-0x000000018978F140
	public static new ModifySkillCD ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8B4 */, bool useObjectPool = false /* Metadata: 0x00AFB8B8 */) => default; // 0x00000001851A7060-0x00000001851A7280
	[BlackList] // 0x0000000189796930-0x0000000189796970
	// [XID] // 0x0000000189796930-0x0000000189796970
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851A5FF0-0x00000001851A62C0
	// [XID] // 0x00000001897A1580-0x00000001897A15A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851A8220-0x00000001851A8570
	[BlackList] // 0x00000001897A8E60-0x00000001897A8EA0
	// [XID] // 0x00000001897A8E60-0x00000001897A8EA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851A7710-0x00000001851A7800
	// [XID] // 0x00000001897B3C50-0x00000001897B3C70
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x00000001851A7B00-0x00000001851A7BC0
	[BlackList] // 0x00000001897BBA10-0x00000001897BBA50
	// [XID] // 0x00000001897BBA10-0x00000001897BBA50
	public override void AutoAllocTypeFields() {} // 0x00000001851A62C0-0x00000001851A6360
	[BlackList] // 0x00000001897C63A0-0x00000001897C63E0
	// [XID] // 0x00000001897C63A0-0x00000001897C63E0
	public override void AutoRecycleTypeFields() {} // 0x00000001851A6360-0x00000001851A6480
	[BlackList] // 0x00000001897D0A30-0x00000001897D0A70
	// [XID] // 0x00000001897D0A30-0x00000001897D0A70
	public override void ReturnToObjectPool() {} // 0x00000001851A8780-0x00000001851A8820
}

