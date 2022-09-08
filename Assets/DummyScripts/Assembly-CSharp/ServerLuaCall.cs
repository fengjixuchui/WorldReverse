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
public class ServerLuaCall : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16795
{
	// Fields
	private LuaCallType _luaCallType; // 0x68
	private bool _isTarget; // 0x6C
	private SimpleSafeUInt32[] _CallParamList; // 0x70
	private string _funcName; // 0x78

	// Properties
	public LuaCallType luaCallType { /* [XID] */ /* 0x0000000189BCC1E0-0x0000000189BCC200 */ get => default; /* [XID] */ /* 0x0000000189BD3810-0x0000000189BD3830 */ private set {} } // 0x0000000183B25CA0-0x0000000183B25D40 0x0000000183B27080-0x0000000183B27130
	public bool isTarget { /* [XID] */ /* 0x0000000189BDB220-0x0000000189BDB240 */ get => default; /* [XID] */ /* 0x00000001895E7B30-0x00000001895E7B50 */ private set {} } // 0x0000000183B26850-0x0000000183B268F0 0x0000000183B25B70-0x0000000183B25C20
	public SimpleSafeUInt32[] CallParamList { /* [XID] */ /* 0x00000001895EF480-0x00000001895EF4A0 */ get => default; /* [XID] */ /* 0x00000001895F6EC0-0x00000001895F6EE0 */ private set {} } // 0x0000000183B28C20-0x0000000183B28CC0 0x0000000183B27A30-0x0000000183B27AE0
	public string funcName { /* [XID] */ /* 0x00000001895FE280-0x00000001895FE2A0 */ get => default; /* [XID] */ /* 0x0000000189605AD0-0x0000000189605AF0 */ private set {} } // 0x0000000183B27EE0-0x0000000183B27F80 0x0000000183B28A20-0x0000000183B28AD0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189689DF0-0x0000000189689E10 */ get => default; } // 0x0000000183B28310-0x0000000183B283B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189691BB0-0x0000000189691BD0 */ get => default; } // 0x0000000183B277C0-0x0000000183B27860 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189699100-0x0000000189699120 */ get => default; } // 0x0000000183B268F0-0x0000000183B26990 

	// Constructors
	public ServerLuaCall() {} // 0x0000000183B28D60-0x0000000183B28DD0

	// Methods
	// [XID] // 0x000000018960D420-0x000000018960D440
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B28AD0-0x0000000183B28C20
	// [XID] // 0x0000000189614AC0-0x0000000189614AE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B28480-0x0000000183B28580
	// [XID] // 0x000000018961C440-0x000000018961C460
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF468E */) => default; // 0x0000000183B27F80-0x0000000183B28060
	// [XID] // 0x00000001896237E0-0x0000000189623800
	public override int GetHashNum() => default; // 0x0000000183B26780-0x0000000183B26850
	// [XID] // 0x000000018962B100-0x000000018962B120
	public override void InitEmpty() {} // 0x0000000183B27860-0x0000000183B27950
	[BlackList] // 0x00000001896328A0-0x00000001896328E0
	// [XID] // 0x00000001896328A0-0x00000001896328E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B271B0-0x0000000183B27530
	// [XID] // 0x000000018963D490-0x000000018963D4B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B25D40-0x0000000183B261D0
	[BlackList] // 0x0000000189644A10-0x0000000189644A50
	// [XID] // 0x0000000189644A10-0x0000000189644A50
	public static new ServerLuaCall ParseFromJson(JSONNode node) => default; // 0x0000000183B280C0-0x0000000183B28310
	// [XID] // 0x000000018964EFE0-0x000000018964F000
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF468F */, bool useObjectPool = false /* Metadata: 0x00AF4693 */) => default; // 0x0000000183B27BE0-0x0000000183B27EE0
	// [XID] // 0x0000000189656870-0x0000000189656890
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4694 */, bool useObjectPool = false /* Metadata: 0x00AF4698 */) => default; // 0x0000000183B26AE0-0x0000000183B26EE0
	// [XID] // 0x000000018965DF70-0x000000018965DF90
	public static new ServerLuaCall ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4699 */, bool useObjectPool = false /* Metadata: 0x00AF469D */) => default; // 0x0000000183B27530-0x0000000183B27750
	[BlackList] // 0x00000001896656B0-0x00000001896656F0
	// [XID] // 0x00000001896656B0-0x00000001896656F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B261D0-0x0000000183B264A0
	// [XID] // 0x0000000189670530-0x0000000189670550
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B28660-0x0000000183B28A20
	[BlackList] // 0x0000000189677D30-0x0000000189677D70
	// [XID] // 0x0000000189677D30-0x0000000189677D70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B27AE0-0x0000000183B27BE0
	// [XID] // 0x0000000189682430-0x0000000189682450
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183B26EE0-0x0000000183B27000
	[BlackList] // 0x00000001896A05F0-0x00000001896A0630
	// [XID] // 0x00000001896A05F0-0x00000001896A0630
	public override void AutoAllocTypeFields() {} // 0x0000000183B264A0-0x0000000183B26540
	[BlackList] // 0x00000001896AA9D0-0x00000001896AAA10
	// [XID] // 0x00000001896AA9D0-0x00000001896AAA10
	public override void AutoRecycleTypeFields() {} // 0x0000000183B26540-0x0000000183B265F0
	[BlackList] // 0x00000001896B5070-0x00000001896B50B0
	// [XID] // 0x00000001896B5070-0x00000001896B50B0
	public override void ReturnToObjectPool() {} // 0x0000000183B28CC0-0x0000000183B28D60
}

