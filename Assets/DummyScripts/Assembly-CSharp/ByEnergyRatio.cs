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
public class ByEnergyRatio : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17266
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _ratio; // 0x20

	// Properties
	public DynamicFloat ratio { /* [XID] */ /* 0x0000000189707950-0x0000000189707970 */ get => default; /* [XID] */ /* 0x000000018970F380-0x000000018970F3A0 */ private set {} } // 0x000000018214F960-0x000000018214FA00 0x0000000182150550-0x0000000182150600

	// Constructors
	public ByEnergyRatio() {} // 0x0000000182151540-0x00000001821515A0

	// Methods
	// [XID] // 0x00000001897166E0-0x0000000189716700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001821513C0-0x00000001821514A0
	// [XID] // 0x000000018971E1A0-0x000000018971E1C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182151000-0x00000001821510E0
	// [XID] // 0x0000000189725720-0x0000000189725740
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF68BB */) => default; // 0x0000000182150C10-0x0000000182150CF0
	// [XID] // 0x000000018972CC40-0x000000018972CC60
	public override int GetHashNum() => default; // 0x000000018214F890-0x000000018214F960
	// [XID] // 0x0000000189734470-0x0000000189734490
	public override void InitEmpty() {} // 0x0000000182150670-0x0000000182150740
	[BlackList] // 0x000000018973BD20-0x000000018973BD60
	// [XID] // 0x000000018973BD20-0x000000018973BD60
	public override bool FromJson(JSONNode node) => default; // 0x000000018214FFB0-0x0000000182150330
	// [XID] // 0x0000000189746540-0x0000000189746560
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018214F090-0x000000018214F2D0
	[BlackList] // 0x000000018974DF90-0x000000018974DFD0
	// [XID] // 0x000000018974DF90-0x000000018974DFD0
	public static new ByEnergyRatio ParseFromJson(JSONNode node) => default; // 0x0000000182150D50-0x0000000182150FA0
	// [XID] // 0x00000001897580B0-0x00000001897580D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68BC */, bool useObjectPool = false /* Metadata: 0x00AF68C0 */) => default; // 0x0000000182150910-0x0000000182150C10
	// [XID] // 0x000000018975FBB0-0x000000018975FBD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68C1 */, bool useObjectPool = false /* Metadata: 0x00AF68C5 */) => default; // 0x000000018214FAE0-0x000000018214FD80
	// [XID] // 0x00000001897672A0-0x00000001897672C0
	public static new ByEnergyRatio ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68C6 */, bool useObjectPool = false /* Metadata: 0x00AF68CA */) => default; // 0x0000000182150330-0x0000000182150550
	[BlackList] // 0x000000018976E740-0x000000018976E780
	// [XID] // 0x000000018976E740-0x000000018976E780
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018214F2D0-0x000000018214F5A0
	// [XID] // 0x00000001897790C0-0x00000001897790E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182151190-0x00000001821513C0
	[BlackList] // 0x0000000189780800-0x0000000189780840
	// [XID] // 0x0000000189780800-0x0000000189780840
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182150820-0x0000000182150910
	// [XID] // 0x000000018978B000-0x000000018978B020
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018214FD80-0x000000018214FEB0
	[BlackList] // 0x0000000189792500-0x0000000189792540
	// [XID] // 0x0000000189792500-0x0000000189792540
	public override void AutoAllocTypeFields() {} // 0x000000018214F5A0-0x000000018214F640
	[BlackList] // 0x000000018979D870-0x000000018979D8B0
	// [XID] // 0x000000018979D870-0x000000018979D8B0
	public override void AutoRecycleTypeFields() {} // 0x000000018214F640-0x000000018214F770
	[BlackList] // 0x00000001897A79A0-0x00000001897A79E0
	// [XID] // 0x00000001897A79A0-0x00000001897A79E0
	public override void ReturnToObjectPool() {} // 0x00000001821514A0-0x0000000182151540
}

