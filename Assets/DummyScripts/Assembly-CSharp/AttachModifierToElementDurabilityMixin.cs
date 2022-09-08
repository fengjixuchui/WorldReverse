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
public class AttachModifierToElementDurabilityMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17045
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DynamicFloat[] _valueSteps; // 0x30
	private string[] _modifierNameSteps; // 0x38

	// Properties
	public DynamicFloat[] valueSteps { /* [XID] */ /* 0x00000001897E8E70-0x00000001897E8E90 */ get => default; /* [XID] */ /* 0x00000001897F0A60-0x00000001897F0A80 */ private set {} } // 0x0000000182FFD820-0x0000000182FFD8C0 0x0000000182FFD450-0x0000000182FFD500
	public string[] modifierNameSteps { /* [XID] */ /* 0x00000001897F8180-0x00000001897F81A0 */ get => default; /* [XID] */ /* 0x00000001897FF910-0x00000001897FF930 */ private set {} } // 0x0000000182FFCF10-0x0000000182FFCFB0 0x0000000182FFCDE0-0x0000000182FFCE90
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189881A80-0x0000000189881AA0 */ get => default; } // 0x0000000182FFD030-0x0000000182FFD0D0 

	// Constructors
	public AttachModifierToElementDurabilityMixin() {} // 0x0000000182FFE960-0x0000000182FFE9C0

	// Methods
	// [XID] // 0x0000000189807030-0x0000000189807050
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FFE7B0-0x0000000182FFE8C0
	// [XID] // 0x000000018980E650-0x000000018980E670
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182FFE3C0-0x0000000182FFE4C0
	// [XID] // 0x0000000189815DD0-0x0000000189815DF0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6163 */) => default; // 0x0000000182FFDFD0-0x0000000182FFE0B0
	// [XID] // 0x000000018981D770-0x000000018981D790
	public override int GetHashNum() => default; // 0x0000000182FFC920-0x0000000182FFC9F0
	// [XID] // 0x0000000189824C80-0x0000000189824CA0
	public override void InitEmpty() {} // 0x0000000182FFD930-0x0000000182FFDA20
	[BlackList] // 0x000000018982C5D0-0x000000018982C610
	// [XID] // 0x000000018982C5D0-0x000000018982C610
	public override bool FromJson(JSONNode node) => default; // 0x0000000182FFD0D0-0x0000000182FFD450
	// [XID] // 0x0000000189836A70-0x0000000189836A90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182FFC0B0-0x0000000182FFC3D0
	[BlackList] // 0x000000018983DF00-0x000000018983DF40
	// [XID] // 0x000000018983DF00-0x000000018983DF40
	public static new AttachModifierToElementDurabilityMixin ParseFromJson(JSONNode node) => default; // 0x0000000182FFE110-0x0000000182FFE360
	// [XID] // 0x00000001898482E0-0x0000000189848300
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6164 */, bool useObjectPool = false /* Metadata: 0x00AF6168 */) => default; // 0x0000000182FFDBF0-0x0000000182FFDEF0
	// [XID] // 0x000000018984FA60-0x000000018984FA80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6169 */, bool useObjectPool = false /* Metadata: 0x00AF616D */) => default; // 0x0000000182FFCAD0-0x0000000182FFCDE0
	// [XID] // 0x0000000189856DE0-0x0000000189856E00
	public static new AttachModifierToElementDurabilityMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF616E */, bool useObjectPool = false /* Metadata: 0x00AF6172 */) => default; // 0x0000000182FFD570-0x0000000182FFD790
	[BlackList] // 0x000000018985DEF0-0x000000018985DF30
	// [XID] // 0x000000018985DEF0-0x000000018985DF30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FFC3D0-0x0000000182FFC6A0
	// [XID] // 0x00000001898689B0-0x00000001898689D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FFE4C0-0x0000000182FFE7B0
	[BlackList] // 0x000000018986FE40-0x000000018986FE80
	// [XID] // 0x000000018986FE40-0x000000018986FE80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182FFDB00-0x0000000182FFDBF0
	// [XID] // 0x000000018987A990-0x000000018987A9B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182FFDEF0-0x0000000182FFDFD0
	[BlackList] // 0x0000000189889120-0x0000000189889160
	// [XID] // 0x0000000189889120-0x0000000189889160
	public override void AutoAllocTypeFields() {} // 0x0000000182FFC6A0-0x0000000182FFC740
	[BlackList] // 0x00000001898935D0-0x0000000189893610
	// [XID] // 0x00000001898935D0-0x0000000189893610
	public override void AutoRecycleTypeFields() {} // 0x0000000182FFC740-0x0000000182FFC800
	[BlackList] // 0x000000018989D840-0x000000018989D880
	// [XID] // 0x000000018989D840-0x000000018989D880
	public override void ReturnToObjectPool() {} // 0x0000000182FFE8C0-0x0000000182FFE960
}

