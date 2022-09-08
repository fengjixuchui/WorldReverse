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
public class ModifySkillPoint : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19052
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x10
	private SimpleSafeInt32 pointDeltaRawNum; // 0x14

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001898B0CC0-0x00000001898B0CE0 */ get => default; /* [XID] */ /* 0x00000001898B83A0-0x00000001898B83C0 */ private set {} } // 0x00000001813F3D90-0x00000001813F3E60 0x00000001813F4C80-0x00000001813F4D60
	public int pointDelta { /* [XID] */ /* 0x00000001898BFB60-0x00000001898BFB80 */ get => default; /* [XID] */ /* 0x00000001898C7400-0x00000001898C7420 */ private set {} } // 0x00000001813F2A00-0x00000001813F2AD0 0x00000001813F39A0-0x00000001813F3A80

	// Constructors
	public ModifySkillPoint() {} // 0x00000001813F4F10-0x00000001813F4F70

	// Methods
	// [XID] // 0x00000001898CE9F0-0x00000001898CEA10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001813F4D60-0x00000001813F4E70
	// [XID] // 0x00000001898D6300-0x00000001898D6320
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001813F48E0-0x00000001813F4990
	// [XID] // 0x00000001898DDFC0-0x00000001898DDFE0
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB8C9 */) => default; // 0x00000001813F44F0-0x00000001813F45D0
	// [XID] // 0x00000001898E5860-0x00000001898E5880
	public override int GetHashNum() => default; // 0x00000001813F3070-0x00000001813F3140
	// [XID] // 0x00000001898ED240-0x00000001898ED260
	public override void InitEmpty() {} // 0x00000001813F3E60-0x00000001813F3F60
	[BlackList] // 0x00000001898F49A0-0x00000001898F49E0
	// [XID] // 0x00000001898F49A0-0x00000001898F49E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001813F3620-0x00000001813F39A0
	// [XID] // 0x00000001898FF210-0x00000001898FF230
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001813F2680-0x00000001813F2A00
	[BlackList] // 0x00000001899069D0-0x0000000189906A10
	// [XID] // 0x00000001899069D0-0x0000000189906A10
	public static new ModifySkillPoint ParseFromJson(JSONNode node) => default; // 0x00000001813F4630-0x00000001813F4880
	// [XID] // 0x0000000189911180-0x00000001899111A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8CA */, bool useObjectPool = false /* Metadata: 0x00AFB8CE */) => default; // 0x00000001813F4130-0x00000001813F4430
	// [XID] // 0x0000000189918DC0-0x0000000189918DE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8CF */, bool useObjectPool = false /* Metadata: 0x00AFB8D3 */) => default; // 0x00000001813F3220-0x00000001813F3520
	// [XID] // 0x0000000189920390-0x00000001899203B0
	public static new ModifySkillPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8D4 */, bool useObjectPool = false /* Metadata: 0x00AFB8D8 */) => default; // 0x00000001813F3A80-0x00000001813F3CA0
	[BlackList] // 0x0000000189927C70-0x0000000189927CB0
	// [XID] // 0x0000000189927C70-0x0000000189927CB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001813F2AD0-0x00000001813F2DA0
	// [XID] // 0x0000000189932260-0x0000000189932280
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001813F4990-0x00000001813F4C80
	[BlackList] // 0x0000000189939C30-0x0000000189939C70
	// [XID] // 0x0000000189939C30-0x0000000189939C70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001813F4040-0x00000001813F4130
	// [XID] // 0x0000000189944220-0x0000000189944240
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x00000001813F4430-0x00000001813F44F0
	[BlackList] // 0x000000018994B860-0x000000018994B8A0
	// [XID] // 0x000000018994B860-0x000000018994B8A0
	public override void AutoAllocTypeFields() {} // 0x00000001813F2DA0-0x00000001813F2E40
	[BlackList] // 0x0000000189955E20-0x0000000189955E60
	// [XID] // 0x0000000189955E20-0x0000000189955E60
	public override void AutoRecycleTypeFields() {} // 0x00000001813F2E40-0x00000001813F2F50
	[BlackList] // 0x00000001899607A0-0x00000001899607E0
	// [XID] // 0x00000001899607A0-0x00000001899607E0
	public override void ReturnToObjectPool() {} // 0x00000001813F4E70-0x00000001813F4F10
}

