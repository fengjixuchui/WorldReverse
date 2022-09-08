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
public class StageReadyMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17043
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onStageReady; // 0x30

	// Properties
	public ConfigAbilityAction[] onStageReady { /* [XID] */ /* 0x0000000189726F80-0x0000000189726FA0 */ get => default; /* [XID] */ /* 0x000000018972E550-0x000000018972E570 */ private set {} } // 0x00000001817DAA90-0x00000001817DAB30 0x00000001817DA3D0-0x00000001817DA480
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897B2310-0x00000001897B2330 */ get => default; } // 0x00000001817D9A70-0x00000001817D9B10 

	// Constructors
	public StageReadyMixin() {} // 0x00000001817DB290-0x00000001817DB2F0

	// Methods
	// [XID] // 0x0000000189735CC0-0x0000000189735CE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817DB100-0x00000001817DB1F0
	// [XID] // 0x000000018973D8B0-0x000000018973D8D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001817DADE0-0x00000001817DAEC0
	// [XID] // 0x0000000189744CB0-0x0000000189744CD0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6153 */) => default; // 0x00000001817DA950-0x00000001817DAA30
	// [XID] // 0x000000018974C920-0x000000018974C940
	public override int GetHashNum() => default; // 0x00000001817D9550-0x00000001817D9620
	// [XID] // 0x0000000189753C40-0x0000000189753C60
	public override void InitEmpty() {} // 0x00000001817DA220-0x00000001817DA2F0
	[BlackList] // 0x000000018975B180-0x000000018975B1C0
	// [XID] // 0x000000018975B180-0x000000018975B1C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001817D9B10-0x00000001817D9E90
	// [XID] // 0x00000001897658D0-0x00000001897658F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817D8DE0-0x00000001817D9010
	[BlackList] // 0x000000018976D160-0x000000018976D1A0
	// [XID] // 0x000000018976D160-0x000000018976D1A0
	public static new StageReadyMixin ParseFromJson(JSONNode node) => default; // 0x00000001817DAB30-0x00000001817DAD80
	// [XID] // 0x0000000189777730-0x0000000189777750
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6154 */, bool useObjectPool = false /* Metadata: 0x00AF6158 */) => default; // 0x00000001817DA570-0x00000001817DA870
	// [XID] // 0x000000018977EE40-0x000000018977EE60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6159 */, bool useObjectPool = false /* Metadata: 0x00AF615D */) => default; // 0x00000001817D9700-0x00000001817D9970
	// [XID] // 0x0000000189786820-0x0000000189786840
	public static new StageReadyMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF615E */, bool useObjectPool = false /* Metadata: 0x00AF6162 */) => default; // 0x00000001817D9F00-0x00000001817DA120
	[BlackList] // 0x000000018978DE10-0x000000018978DE50
	// [XID] // 0x000000018978DE10-0x000000018978DE50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817D9010-0x00000001817D92E0
	// [XID] // 0x0000000189798560-0x0000000189798580
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817DAEC0-0x00000001817DB100
	[BlackList] // 0x00000001897A03D0-0x00000001897A0410
	// [XID] // 0x00000001897A03D0-0x00000001897A0410
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817DA480-0x00000001817DA570
	// [XID] // 0x00000001897AA800-0x00000001897AA820
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001817DA870-0x00000001817DA950
	[BlackList] // 0x00000001897B9D10-0x00000001897B9D50
	// [XID] // 0x00000001897B9D10-0x00000001897B9D50
	public override void AutoAllocTypeFields() {} // 0x00000001817D92E0-0x00000001817D9380
	[BlackList] // 0x00000001897C4C00-0x00000001897C4C40
	// [XID] // 0x00000001897C4C00-0x00000001897C4C40
	public override void AutoRecycleTypeFields() {} // 0x00000001817D9380-0x00000001817D9430
	[BlackList] // 0x00000001897CF470-0x00000001897CF4B0
	// [XID] // 0x00000001897CF470-0x00000001897CF4B0
	public override void ReturnToObjectPool() {} // 0x00000001817DB1F0-0x00000001817DB290
}

