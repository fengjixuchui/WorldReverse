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
public class TriggerElementSupportMixin : TriggerTypeSupportMixin, IAutoAllocRecycle // TypeDefIndex: 16932
{
	// Fields
	private ElementType _elementType; // 0x38

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189AA5A60-0x0000000189AA5A80 */ get => default; /* [XID] */ /* 0x0000000189AAD0A0-0x0000000189AAD0C0 */ private set {} } // 0x00000001839205B0-0x0000000183920650 0x0000000183921690-0x0000000183921740
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B311D0-0x0000000189B311F0 */ get => default; } // 0x0000000183920750-0x00000001839207F0 

	// Constructors
	public TriggerElementSupportMixin() {} // 0x0000000183921E30-0x0000000183921EA0

	// Methods
	// [XID] // 0x0000000189AB4A70-0x0000000189AB4A90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183921CA0-0x0000000183921D90
	// [XID] // 0x0000000189ABC7A0-0x0000000189ABC7C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001839219F0-0x0000000183921AA0
	// [XID] // 0x0000000189AC4060-0x0000000189AC4080
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5DED */) => default; // 0x0000000183921550-0x0000000183921630
	// [XID] // 0x0000000189ACB5B0-0x0000000189ACB5D0
	public override int GetHashNum() => default; // 0x00000001839201D0-0x00000001839202A0
	// [XID] // 0x0000000189AD2FE0-0x0000000189AD3000
	public override void InitEmpty() {} // 0x0000000183920F00-0x0000000183920FA0
	[BlackList] // 0x0000000189ADAA40-0x0000000189ADAA80
	// [XID] // 0x0000000189ADAA40-0x0000000189ADAA80
	public override bool FromJson(JSONNode node) => default; // 0x00000001839207F0-0x0000000183920B70
	// [XID] // 0x0000000189AE5760-0x0000000189AE5780
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018391FA70-0x000000018391FC90
	[BlackList] // 0x0000000189AECB80-0x0000000189AECBC0
	// [XID] // 0x0000000189AECB80-0x0000000189AECBC0
	public static new TriggerElementSupportMixin ParseFromJson(JSONNode node) => default; // 0x0000000183921740-0x0000000183921990
	// [XID] // 0x0000000189AF76C0-0x0000000189AF76E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DEE */, bool useObjectPool = false /* Metadata: 0x00AF5DF2 */) => default; // 0x0000000183921170-0x0000000183921470
	// [XID] // 0x0000000189AFED50-0x0000000189AFED70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DF3 */, bool useObjectPool = false /* Metadata: 0x00AF5DF7 */) => default; // 0x0000000183920380-0x00000001839205B0
	// [XID] // 0x0000000189B06540-0x0000000189B06560
	public static new TriggerElementSupportMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DF8 */, bool useObjectPool = false /* Metadata: 0x00AF5DFC */) => default; // 0x0000000183920BE0-0x0000000183920E00
	[BlackList] // 0x0000000189B0DB90-0x0000000189B0DBD0
	// [XID] // 0x0000000189B0DB90-0x0000000189B0DBD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018391FC90-0x000000018391FF60
	// [XID] // 0x0000000189B18040-0x0000000189B18060
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183921AA0-0x0000000183921CA0
	[BlackList] // 0x0000000189B1F720-0x0000000189B1F760
	// [XID] // 0x0000000189B1F720-0x0000000189B1F760
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183921080-0x0000000183921170
	// [XID] // 0x0000000189B29C20-0x0000000189B29C40
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183921470-0x0000000183921550
	[BlackList] // 0x0000000189B38850-0x0000000189B38890
	// [XID] // 0x0000000189B38850-0x0000000189B38890
	public override void AutoAllocTypeFields() {} // 0x000000018391FF60-0x0000000183920000
	[BlackList] // 0x0000000189B43250-0x0000000189B43290
	// [XID] // 0x0000000189B43250-0x0000000189B43290
	public override void AutoRecycleTypeFields() {} // 0x0000000183920000-0x00000001839200B0
	[BlackList] // 0x0000000189B4D900-0x0000000189B4D940
	// [XID] // 0x0000000189B4D900-0x0000000189B4D940
	public override void ReturnToObjectPool() {} // 0x0000000183921D90-0x0000000183921E30
}

