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
public class EnviroFollowRotateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17026
{
	// Fields
	private MoleMole.Config.Vector _selfRotateOffSet; // 0x30
	private string _deactiveOnCutsecneName; // 0x40

	// Properties
	public MoleMole.Config.Vector selfRotateOffSet { /* [XID] */ /* 0x0000000189B93790-0x0000000189B937B0 */ get => default; /* [XID] */ /* 0x0000000189B9ACC0-0x0000000189B9ACE0 */ private set {} } // 0x0000000181278000-0x00000001812780E0 0x0000000181278A60-0x0000000181278B30
	public string deactiveOnCutsecneName { /* [XID] */ /* 0x0000000189BA2550-0x0000000189BA2570 */ get => default; /* [XID] */ /* 0x0000000189BA9A40-0x0000000189BA9A60 */ private set {} } // 0x0000000181278630-0x00000001812786D0 0x0000000181278160-0x0000000181278210
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189632820-0x0000000189632840 */ get => default; } // 0x0000000181278210-0x00000001812782B0 

	// Constructors
	public EnviroFollowRotateMixin() {} // 0x0000000181279B60-0x0000000181279BC0

	// Methods
	// [XID] // 0x0000000189BB1230-0x0000000189BB1250
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181279990-0x0000000181279AC0
	// [XID] // 0x0000000189BB8360-0x0000000189BB8380
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001812795C0-0x00000001812796A0
	// [XID] // 0x0000000189BBFB90-0x0000000189BBFBB0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF60C9 */) => default; // 0x00000001812791D0-0x00000001812792B0
	// [XID] // 0x0000000189BC76E0-0x0000000189BC7700
	public override int GetHashNum() => default; // 0x0000000181277AD0-0x0000000181277BA0
	// [XID] // 0x0000000189BCF2F0-0x0000000189BCF310
	public override void InitEmpty() {} // 0x0000000181278B30-0x0000000181278C20
	[BlackList] // 0x0000000189BD65C0-0x0000000189BD6600
	// [XID] // 0x0000000189BD65C0-0x0000000189BD6600
	public override bool FromJson(JSONNode node) => default; // 0x00000001812782B0-0x0000000181278630
	// [XID] // 0x00000001895E62B0-0x00000001895E62D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181277270-0x0000000181277580
	[BlackList] // 0x00000001895EDBD0-0x00000001895EDC10
	// [XID] // 0x00000001895EDBD0-0x00000001895EDC10
	public static new EnviroFollowRotateMixin ParseFromJson(JSONNode node) => default; // 0x0000000181279310-0x0000000181279560
	// [XID] // 0x00000001895F8510-0x00000001895F8530
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60CA */, bool useObjectPool = false /* Metadata: 0x00AF60CE */) => default; // 0x0000000181278DF0-0x00000001812790F0
	// [XID] // 0x00000001895FF9D0-0x00000001895FF9F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60CF */, bool useObjectPool = false /* Metadata: 0x00AF60D3 */) => default; // 0x0000000181277C80-0x0000000181277F80
	// [XID] // 0x00000001896071A0-0x00000001896071C0
	public static new EnviroFollowRotateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60D4 */, bool useObjectPool = false /* Metadata: 0x00AF60D8 */) => default; // 0x0000000181278740-0x0000000181278960
	[BlackList] // 0x000000018960EBE0-0x000000018960EC20
	// [XID] // 0x000000018960EBE0-0x000000018960EC20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181277580-0x0000000181277850
	// [XID] // 0x00000001896194C0-0x00000001896194E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001812796A0-0x0000000181279990
	[BlackList] // 0x0000000189620A20-0x0000000189620A60
	// [XID] // 0x0000000189620A20-0x0000000189620A60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181278D00-0x0000000181278DF0
	// [XID] // 0x000000018962B0E0-0x000000018962B100
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001812790F0-0x00000001812791D0
	[BlackList] // 0x000000018963A310-0x000000018963A350
	// [XID] // 0x000000018963A310-0x000000018963A350
	public override void AutoAllocTypeFields() {} // 0x0000000181277850-0x00000001812778F0
	[BlackList] // 0x0000000189644970-0x00000001896449B0
	// [XID] // 0x0000000189644970-0x00000001896449B0
	public override void AutoRecycleTypeFields() {} // 0x00000001812778F0-0x00000001812779B0
	[BlackList] // 0x000000018964EFA0-0x000000018964EFE0
	// [XID] // 0x000000018964EFA0-0x000000018964EFE0
	public override void ReturnToObjectPool() {} // 0x0000000181279AC0-0x0000000181279B60
}

