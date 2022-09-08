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
public class ChangeEnviroWeather : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16773
{
	// Fields
	private SimpleSafeUInt32 areaIdRawNum; // 0x68
	private SimpleSafeUInt32 climateTypeRawNum; // 0x6C
	private SimpleSafeFloat transDurationRawNum; // 0x70

	// Properties
	public uint areaId { /* [XID] */ /* 0x0000000189B50C80-0x0000000189B50CA0 */ get => default; /* [XID] */ /* 0x0000000189B58470-0x0000000189B58490 */ private set {} } // 0x000000018348FD40-0x000000018348FE10 0x000000018348E980-0x000000018348EA60
	public uint climateType { /* [XID] */ /* 0x0000000189B5FE00-0x0000000189B5FE20 */ get => default; /* [XID] */ /* 0x0000000189B674A0-0x0000000189B674C0 */ private set {} } // 0x000000018348FAF0-0x000000018348FBC0 0x000000018348FBC0-0x000000018348FCA0
	public float transDuration { /* [XID] */ /* 0x0000000189B6E720-0x0000000189B6E740 */ get => default; /* [XID] */ /* 0x0000000189B75F70-0x0000000189B75F90 */ private set {} } // 0x000000018348F300-0x000000018348F3E0 0x0000000183490E00-0x0000000183490EE0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001895FE2A0-0x00000001895FE2C0 */ get => default; } // 0x0000000183490790-0x0000000183490830 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189605AF0-0x0000000189605B10 */ get => default; } // 0x000000018348FCA0-0x000000018348FD40 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x000000018960D440-0x000000018960D460 */ get => default; } // 0x000000018348ECC0-0x000000018348ED60 

	// Constructors
	public ChangeEnviroWeather() {} // 0x00000001834910B0-0x0000000183491180

	// Methods
	// [XID] // 0x0000000189B7D480-0x0000000189B7D4A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183490EE0-0x0000000183491010
	// [XID] // 0x0000000189B851D0-0x0000000189B851F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183490900-0x00000001834909B0
	// [XID] // 0x0000000189B8C060-0x0000000189B8C080
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF45CE */) => default; // 0x0000000183490400-0x00000001834904E0
	// [XID] // 0x0000000189B93850-0x0000000189B93870
	public override int GetHashNum() => default; // 0x000000018348EBF0-0x000000018348ECC0
	// [XID] // 0x0000000189B9AD60-0x0000000189B9AD80
	public override void InitEmpty() {} // 0x000000018348FE10-0x000000018348FF20
	[BlackList] // 0x0000000189BA2630-0x0000000189BA2670
	// [XID] // 0x0000000189BA2630-0x0000000189BA2670
	public override bool FromJson(JSONNode node) => default; // 0x000000018348F4E0-0x000000018348F860
	// [XID] // 0x0000000189BAC5F0-0x0000000189BAC610
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018348E0D0-0x000000018348E500
	[BlackList] // 0x0000000189BB3ED0-0x0000000189BB3F10
	// [XID] // 0x0000000189BB3ED0-0x0000000189BB3F10
	public static new ChangeEnviroWeather ParseFromJson(JSONNode node) => default; // 0x0000000183490540-0x0000000183490790
	// [XID] // 0x0000000189BBE370-0x0000000189BBE390
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45CF */, bool useObjectPool = false /* Metadata: 0x00AF45D3 */) => default; // 0x0000000183490100-0x0000000183490400
	// [XID] // 0x0000000189BC6020-0x0000000189BC6040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45D4 */, bool useObjectPool = false /* Metadata: 0x00AF45D8 */) => default; // 0x000000018348EEB0-0x000000018348F1E0
	// [XID] // 0x0000000189BCDB20-0x0000000189BCDB40
	public static new ChangeEnviroWeather ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45D9 */, bool useObjectPool = false /* Metadata: 0x00AF45DD */) => default; // 0x000000018348F860-0x000000018348FA80
	[BlackList] // 0x0000000189BD5050-0x0000000189BD5090
	// [XID] // 0x0000000189BD5050-0x0000000189BD5090
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018348E500-0x000000018348E7D0
	// [XID] // 0x0000000189BDFAA0-0x0000000189BDFAC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183490A90-0x0000000183490E00
	[BlackList] // 0x00000001895EC670-0x00000001895EC6B0
	// [XID] // 0x00000001895EC670-0x00000001895EC6B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183490000-0x0000000183490100
	// [XID] // 0x00000001895F6EE0-0x00000001895F6F00
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018348F1E0-0x000000018348F300
	[BlackList] // 0x0000000189614AE0-0x0000000189614B20
	// [XID] // 0x0000000189614AE0-0x0000000189614B20
	public override void AutoAllocTypeFields() {} // 0x000000018348E7D0-0x000000018348E870
	[BlackList] // 0x000000018961F460-0x000000018961F4A0
	// [XID] // 0x000000018961F460-0x000000018961F4A0
	public override void AutoRecycleTypeFields() {} // 0x000000018348E870-0x000000018348E980
	[BlackList] // 0x0000000189629A30-0x0000000189629A70
	// [XID] // 0x0000000189629A30-0x0000000189629A70
	public override void ReturnToObjectPool() {} // 0x0000000183491010-0x00000001834910B0
}

