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
public class ResistClimateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17119
{
	// Fields
	private JsonClimateType[] _climateTypes; // 0x30
	private ClimateSourceType _source; // 0x38
	private ClimateTrendType _trend; // 0x3C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _ratio; // 0x40
	private AvatarStageType _type; // 0x48

	// Properties
	public JsonClimateType[] climateTypes { /* [XID] */ /* 0x0000000189719AF0-0x0000000189719B10 */ get => default; /* [XID] */ /* 0x0000000189721050-0x0000000189721070 */ private set {} } // 0x000000018448F250-0x000000018448F2F0 0x000000018448F950-0x000000018448FA00
	public ClimateSourceType source { /* [XID] */ /* 0x00000001897286F0-0x0000000189728710 */ get => default; /* [XID] */ /* 0x000000018972FE40-0x000000018972FE60 */ private set {} } // 0x000000018448C9A0-0x000000018448CA40 0x000000018448DD30-0x000000018448DDE0
	public ClimateTrendType trend { /* [XID] */ /* 0x0000000189737740-0x0000000189737760 */ get => default; /* [XID] */ /* 0x000000018973F260-0x000000018973F280 */ private set {} } // 0x000000018448F8B0-0x000000018448F950 0x000000018448F3A0-0x000000018448F450
	public DynamicFloat ratio { /* [XID] */ /* 0x0000000189746560-0x0000000189746580 */ get => default; /* [XID] */ /* 0x000000018974DFD0-0x000000018974DFF0 */ private set {} } // 0x000000018448D690-0x000000018448D730 0x000000018448E5A0-0x000000018448E650
	public AvatarStageType type { /* [XID] */ /* 0x0000000189755750-0x0000000189755770 */ get => default; /* [XID] */ /* 0x000000018975CA30-0x000000018975CA50 */ private set {} } // 0x000000018448FB70-0x000000018448FC10 0x000000018448F2F0-0x000000018448F3A0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897E15A0-0x00000001897E15C0 */ get => default; } // 0x000000018448DE60-0x000000018448DF00 

	// Constructors
	public ResistClimateMixin() {} // 0x000000018448FCB0-0x000000018448FD30

	// Methods
	// [XID] // 0x00000001897641C0-0x00000001897641E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018448FA00-0x000000018448FB70
	// [XID] // 0x000000018976BA60-0x000000018976BA80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018448F150-0x000000018448F250
	// [XID] // 0x0000000189772F80-0x0000000189772FA0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF63DD */) => default; // 0x000000018448ED60-0x000000018448EE40
	// [XID] // 0x000000018977A5C0-0x000000018977A5E0
	public override int GetHashNum() => default; // 0x000000018448D5C0-0x000000018448D690
	// [XID] // 0x00000001897821A0-0x00000001897821C0
	public override void InitEmpty() {} // 0x000000018448E6C0-0x000000018448E7B0
	[BlackList] // 0x0000000189789520-0x0000000189789560
	// [XID] // 0x0000000189789520-0x0000000189789560
	public override bool FromJson(JSONNode node) => default; // 0x000000018448DF00-0x000000018448E280
	// [XID] // 0x0000000189793B00-0x0000000189793B20
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018448CA40-0x000000018448CFE0
	[BlackList] // 0x000000018979BD50-0x000000018979BD90
	// [XID] // 0x000000018979BD50-0x000000018979BD90
	public static new ResistClimateMixin ParseFromJson(JSONNode node) => default; // 0x000000018448EEA0-0x000000018448F0F0
	// [XID] // 0x00000001897A6440-0x00000001897A6460
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63DE */, bool useObjectPool = false /* Metadata: 0x00AF63E2 */) => default; // 0x000000018448E980-0x000000018448EC80
	// [XID] // 0x00000001897AD990-0x00000001897AD9B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63E3 */, bool useObjectPool = false /* Metadata: 0x00AF63E7 */) => default; // 0x000000018448D810-0x000000018448DCB0
	// [XID] // 0x00000001897B5A90-0x00000001897B5AB0
	public static new ResistClimateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63E8 */, bool useObjectPool = false /* Metadata: 0x00AF63EC */) => default; // 0x000000018448E2F0-0x000000018448E510
	[BlackList] // 0x00000001897BD800-0x00000001897BD840
	// [XID] // 0x00000001897BD800-0x00000001897BD840
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018448CFE0-0x000000018448D2B0
	// [XID] // 0x00000001897C80B0-0x00000001897C80D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018448F450-0x000000018448F8B0
	[BlackList] // 0x00000001897CF410-0x00000001897CF450
	// [XID] // 0x00000001897CF410-0x00000001897CF450
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018448E890-0x000000018448E980
	// [XID] // 0x00000001897DA1B0-0x00000001897DA1D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018448EC80-0x000000018448ED60
	[BlackList] // 0x00000001897E8DF0-0x00000001897E8E30
	// [XID] // 0x00000001897E8DF0-0x00000001897E8E30
	public override void AutoAllocTypeFields() {} // 0x000000018448D2B0-0x000000018448D350
	[BlackList] // 0x00000001897F39F0-0x00000001897F3A30
	// [XID] // 0x00000001897F39F0-0x00000001897F3A30
	public override void AutoRecycleTypeFields() {} // 0x000000018448D350-0x000000018448D4A0
	[BlackList] // 0x00000001897FDDE0-0x00000001897FDE20
	// [XID] // 0x00000001897FDDE0-0x00000001897FDE20
	public override void ReturnToObjectPool() {} // 0x000000018448FC10-0x000000018448FCB0
}

