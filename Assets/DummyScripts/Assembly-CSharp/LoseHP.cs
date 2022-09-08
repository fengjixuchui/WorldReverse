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
public class LoseHP : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16446
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amount; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByCasterMaxHPRatio; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByTargetMaxHPRatio; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByTargetCurrentHPRatio; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByCasterAttackRatio; // 0x88
	private bool _lethal; // 0x90
	private bool _enableInvincible; // 0x91
	private bool _enableLockHP; // 0x92
	private bool _disableWhenLoading; // 0x93

	// Properties
	public DynamicFloat amount { /* [XID] */ /* 0x0000000189B53AA0-0x0000000189B53AC0 */ get => default; /* [XID] */ /* 0x0000000189B5B3F0-0x0000000189B5B410 */ private set {} } // 0x00000001858A3630-0x00000001858A36D0 0x00000001858A1F10-0x00000001858A1FC0
	public DynamicFloat amountByCasterMaxHPRatio { /* [XID] */ /* 0x0000000189B62820-0x0000000189B62840 */ get => default; /* [XID] */ /* 0x0000000189B6A390-0x0000000189B6A3B0 */ private set {} } // 0x00000001858A1E70-0x00000001858A1F10 0x00000001858A0730-0x00000001858A07E0
	public DynamicFloat amountByTargetMaxHPRatio { /* [XID] */ /* 0x0000000189B71B30-0x0000000189B71B50 */ get => default; /* [XID] */ /* 0x0000000189B78EA0-0x0000000189B78EC0 */ private set {} } // 0x00000001858A41B0-0x00000001858A4250 0x00000001858A14E0-0x00000001858A1590
	public DynamicFloat amountByTargetCurrentHPRatio { /* [XID] */ /* 0x0000000189B80470-0x0000000189B80490 */ get => default; /* [XID] */ /* 0x0000000189B87F60-0x0000000189B87F80 */ private set {} } // 0x00000001858A33D0-0x00000001858A3480 0x00000001858A19D0-0x00000001858A1A80
	public DynamicFloat amountByCasterAttackRatio { /* [XID] */ /* 0x0000000189B8F150-0x0000000189B8F170 */ get => default; /* [XID] */ /* 0x0000000189B96640-0x0000000189B96660 */ private set {} } // 0x00000001858A4B70-0x00000001858A4C20 0x00000001858A2040-0x00000001858A20F0
	public bool lethal { /* [XID] */ /* 0x0000000189B9DAE0-0x0000000189B9DB00 */ get => default; /* [XID] */ /* 0x0000000189BA5510-0x0000000189BA5530 */ private set {} } // 0x00000001858A3C00-0x00000001858A3CB0 0x00000001858A1D60-0x00000001858A1E10
	public bool enableInvincible { /* [XID] */ /* 0x0000000189BAC690-0x0000000189BAC6B0 */ get => default; /* [XID] */ /* 0x0000000189BB3F50-0x0000000189BB3F70 */ private set {} } // 0x00000001858A4AC0-0x00000001858A4B70 0x00000001858A4330-0x00000001858A43E0
	public bool enableLockHP { /* [XID] */ /* 0x0000000189BBB570-0x0000000189BBB590 */ get => default; /* [XID] */ /* 0x0000000189BC33B0-0x0000000189BC33D0 */ private set {} } // 0x00000001858A1160-0x00000001858A1210 0x00000001858A2AD0-0x00000001858A2B80
	public bool disableWhenLoading { /* [XID] */ /* 0x0000000189BCAC10-0x0000000189BCAC30 */ get => default; /* [XID] */ /* 0x0000000189BD2260-0x0000000189BD2280 */ private set {} } // 0x00000001858A31A0-0x00000001858A3250 0x00000001858A1CB0-0x00000001858A1D60
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189662740-0x0000000189662760 */ get => default; } // 0x00000001858A3F60-0x00000001858A4000 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018966A2C0-0x000000018966A2E0 */ get => default; } // 0x00000001858A3330-0x00000001858A33D0 

	// Constructors
	public LoseHP() {} // 0x00000001858A4FA0-0x00000001858A5010

	// Methods
	// [XID] // 0x0000000189BD9800-0x0000000189BD9820
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001858A4C20-0x00000001858A4E60
	// [XID] // 0x00000001895E62D0-0x00000001895E62F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001858A4060-0x00000001858A41B0
	// [XID] // 0x00000001895EDC90-0x00000001895EDCB0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3BAA */) => default; // 0x00000001858A3B20-0x00000001858A3C00
	// [XID] // 0x00000001895F5530-0x00000001895F5550
	public override int GetHashNum() => default; // 0x00000001858A1B70-0x00000001858A1C40
	// [XID] // 0x00000001895FCA90-0x00000001895FCAB0
	public override void InitEmpty() {} // 0x00000001858A3480-0x00000001858A35B0
	[BlackList] // 0x00000001896044B0-0x00000001896044F0
	// [XID] // 0x00000001896044B0-0x00000001896044F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001858A2C00-0x00000001858A2F80
	// [XID] // 0x000000018960ECA0-0x000000018960ECC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001858A0860-0x00000001858A1160
	[BlackList] // 0x00000001896162A0-0x00000001896162E0
	// [XID] // 0x00000001896162A0-0x00000001896162E0
	public static new LoseHP ParseFromJson(JSONNode node) => default; // 0x00000001858A3D10-0x00000001858A3F60
	// [XID] // 0x0000000189620B20-0x0000000189620B40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BAB */, bool useObjectPool = false /* Metadata: 0x00AF3BAF */) => default; // 0x00000001858A3820-0x00000001858A3B20
	// [XID] // 0x0000000189628130-0x0000000189628150
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BB0 */, bool useObjectPool = false /* Metadata: 0x00AF3BB4 */) => default; // 0x00000001858A20F0-0x00000001858A28F0
	// [XID] // 0x000000018962F940-0x000000018962F960
	public static new LoseHP ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BB5 */, bool useObjectPool = false /* Metadata: 0x00AF3BB9 */) => default; // 0x00000001858A2F80-0x00000001858A31A0
	[BlackList] // 0x00000001896374E0-0x0000000189637520
	// [XID] // 0x00000001896374E0-0x0000000189637520
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001858A1210-0x00000001858A14E0
	// [XID] // 0x00000001896419E0-0x0000000189641A00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001858A43E0-0x00000001858A4AC0
	[BlackList] // 0x00000001896493E0-0x0000000189649420
	// [XID] // 0x00000001896493E0-0x0000000189649420
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001858A3730-0x00000001858A3820
	// [XID] // 0x00000001896539E0-0x0000000189653A00
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001858A4E60-0x00000001858A4F00
	// [XID] // 0x000000018965B290-0x000000018965B2B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001858A28F0-0x00000001858A2A50
	[BlackList] // 0x0000000189671F40-0x0000000189671F80
	// [XID] // 0x0000000189671F40-0x0000000189671F80
	public override void AutoAllocTypeFields() {} // 0x00000001858A1590-0x00000001858A1630
	[BlackList] // 0x000000018967C5A0-0x000000018967C5E0
	// [XID] // 0x000000018967C5A0-0x000000018967C5E0
	public override void AutoRecycleTypeFields() {} // 0x00000001858A1630-0x00000001858A1930
	[BlackList] // 0x0000000189686C10-0x0000000189686C50
	// [XID] // 0x0000000189686C10-0x0000000189686C50
	public override void ReturnToObjectPool() {} // 0x00000001858A4F00-0x00000001858A4FA0
}

