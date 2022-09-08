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
public class ByEntityTypes : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17236
{
	// Fields
	private EntityType[] _entityTypes; // 0x18
	private bool _reject; // 0x20
	private bool _useEventSource; // 0x21
	private SimpleSafeInt16 isAuthorityRawNum; // 0x22

	// Properties
	public EntityType[] entityTypes { /* [XID] */ /* 0x00000001899504F0-0x0000000189950510 */ get => default; /* [XID] */ /* 0x0000000189957AC0-0x0000000189957AE0 */ private set {} } // 0x00000001831CE8C0-0x00000001831CE960 0x00000001831CF560-0x00000001831CF610
	public bool reject { /* [XID] */ /* 0x000000018995F350-0x000000018995F370 */ get => default; /* [XID] */ /* 0x0000000189966C50-0x0000000189966C70 */ private set {} } // 0x00000001831CE0D0-0x00000001831CE170 0x00000001831CE5F0-0x00000001831CE6A0
	public bool useEventSource { /* [XID] */ /* 0x000000018996DF80-0x000000018996DFA0 */ get => default; /* [XID] */ /* 0x0000000189975B50-0x0000000189975B70 */ private set {} } // 0x00000001831CDA50-0x00000001831CDAF0 0x00000001831CCDF0-0x00000001831CCEA0
	public short isAuthority { /* [XID] */ /* 0x000000018997CB30-0x000000018997CB50 */ get => default; /* [XID] */ /* 0x0000000189984930-0x0000000189984950 */ private set {} } // 0x00000001831CCEA0-0x00000001831CCF70 0x00000001831CE9D0-0x00000001831CEAB0

	// Constructors
	public ByEntityTypes() {} // 0x00000001831CFCB0-0x00000001831CFD40

	// Methods
	// [XID] // 0x000000018998C430-0x000000018998C450
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831CFAC0-0x00000001831CFC10
	// [XID] // 0x0000000189994150-0x0000000189994170
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001831CF480-0x00000001831CF560
	// [XID] // 0x000000018999B9E0-0x000000018999BA00
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6797 */) => default; // 0x00000001831CF090-0x00000001831CF170
	// [XID] // 0x00000001899A3170-0x00000001899A3190
	public override int GetHashNum() => default; // 0x00000001831CD980-0x00000001831CDA50
	// [XID] // 0x00000001899AAC20-0x00000001899AAC40
	public override void InitEmpty() {} // 0x00000001831CEAB0-0x00000001831CEBC0
	[BlackList] // 0x00000001899B2650-0x00000001899B2690
	// [XID] // 0x00000001899B2650-0x00000001899B2690
	public override bool FromJson(JSONNode node) => default; // 0x00000001831CE270-0x00000001831CE5F0
	// [XID] // 0x00000001899BCAF0-0x00000001899BCB10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001831CCF70-0x00000001831CD410
	[BlackList] // 0x00000001899C4540-0x00000001899C4580
	// [XID] // 0x00000001899C4540-0x00000001899C4580
	public static new ByEntityTypes ParseFromJson(JSONNode node) => default; // 0x00000001831CF1D0-0x00000001831CF420
	// [XID] // 0x00000001899CEA80-0x00000001899CEAA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6798 */, bool useObjectPool = false /* Metadata: 0x00AF679C */) => default; // 0x00000001831CED90-0x00000001831CF090
	// [XID] // 0x00000001899D61D0-0x00000001899D61F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF679D */, bool useObjectPool = false /* Metadata: 0x00AF67A1 */) => default; // 0x00000001831CDBD0-0x00000001831CDFA0
	// [XID] // 0x00000001899DD620-0x00000001899DD640
	public static new ByEntityTypes ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67A2 */, bool useObjectPool = false /* Metadata: 0x00AF67A6 */) => default; // 0x00000001831CE6A0-0x00000001831CE8C0
	[BlackList] // 0x00000001899E5320-0x00000001899E5360
	// [XID] // 0x00000001899E5320-0x00000001899E5360
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001831CD410-0x00000001831CD6E0
	// [XID] // 0x00000001899EF6D0-0x00000001899EF6F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831CF6C0-0x00000001831CFAC0
	[BlackList] // 0x00000001899F6F30-0x00000001899F6F70
	// [XID] // 0x00000001899F6F30-0x00000001899F6F70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831CECA0-0x00000001831CED90
	// [XID] // 0x0000000189A01210-0x0000000189A01230
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001831CDFA0-0x00000001831CE0D0
	[BlackList] // 0x0000000189A08B70-0x0000000189A08BB0
	// [XID] // 0x0000000189A08B70-0x0000000189A08BB0
	public override void AutoAllocTypeFields() {} // 0x00000001831CD6E0-0x00000001831CD780
	[BlackList] // 0x0000000189A133A0-0x0000000189A133E0
	// [XID] // 0x0000000189A133A0-0x0000000189A133E0
	public override void AutoRecycleTypeFields() {} // 0x00000001831CD780-0x00000001831CD860
	[BlackList] // 0x0000000189A1D640-0x0000000189A1D680
	// [XID] // 0x0000000189A1D640-0x0000000189A1D680
	public override void ReturnToObjectPool() {} // 0x00000001831CFC10-0x00000001831CFCB0
}

