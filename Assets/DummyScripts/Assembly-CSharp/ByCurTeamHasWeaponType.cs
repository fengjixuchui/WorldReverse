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
public class ByCurTeamHasWeaponType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17296
{
	// Fields
	private string _weaponType; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x20
	private RelationalOperator _logic; // 0x24

	// Properties
	public string weaponType { /* [XID] */ /* 0x00000001895EF340-0x00000001895EF360 */ get => default; /* [XID] */ /* 0x00000001895F6D60-0x00000001895F6D80 */ private set {} } // 0x000000018528C170-0x000000018528C210 0x000000018528C050-0x000000018528C100
	public uint number { /* [XID] */ /* 0x00000001895FE160-0x00000001895FE180 */ get => default; /* [XID] */ /* 0x00000001896059B0-0x00000001896059D0 */ private set {} } // 0x000000018528B380-0x000000018528B450 0x000000018528CD60-0x000000018528CE40
	public RelationalOperator logic { /* [XID] */ /* 0x000000018960D2C0-0x000000018960D2E0 */ get => default; /* [XID] */ /* 0x00000001896149E0-0x0000000189614A00 */ private set {} } // 0x000000018528C930-0x000000018528C9D0 0x000000018528BFA0-0x000000018528C050

	// Constructors
	public ByCurTeamHasWeaponType() {} // 0x000000018528D400-0x000000018528D460

	// Methods
	// [XID] // 0x000000018961C360-0x000000018961C380
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018528D230-0x000000018528D360
	// [XID] // 0x0000000189623740-0x0000000189623760
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018528CC80-0x000000018528CD60
	// [XID] // 0x000000018962B0C0-0x000000018962B0E0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF69AB */) => default; // 0x000000018528C7F0-0x000000018528C8D0
	// [XID] // 0x00000001896327E0-0x0000000189632800
	public override int GetHashNum() => default; // 0x000000018528B1D0-0x000000018528B2A0
	// [XID] // 0x000000018963A2B0-0x000000018963A2D0
	public override void InitEmpty() {} // 0x000000018528C210-0x000000018528C320
	[BlackList] // 0x0000000189641800-0x0000000189641840
	// [XID] // 0x0000000189641800-0x0000000189641840
	public override bool FromJson(JSONNode node) => default; // 0x000000018528BA00-0x000000018528BD80
	// [XID] // 0x000000018964C190-0x000000018964C1B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018528A830-0x000000018528AC60
	[BlackList] // 0x00000001896538A0-0x00000001896538E0
	// [XID] // 0x00000001896538A0-0x00000001896538E0
	public static new ByCurTeamHasWeaponType ParseFromJson(JSONNode node) => default; // 0x000000018528C9D0-0x000000018528CC20
	// [XID] // 0x000000018965DED0-0x000000018965DEF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69AC */, bool useObjectPool = false /* Metadata: 0x00AF69B0 */) => default; // 0x000000018528C4F0-0x000000018528C7F0
	// [XID] // 0x0000000189665610-0x0000000189665630
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69B1 */, bool useObjectPool = false /* Metadata: 0x00AF69B5 */) => default; // 0x000000018528B450-0x000000018528B7D0
	// [XID] // 0x000000018966CD40-0x000000018966CD60
	public static new ByCurTeamHasWeaponType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69B6 */, bool useObjectPool = false /* Metadata: 0x00AF69BA */) => default; // 0x000000018528BD80-0x000000018528BFA0
	[BlackList] // 0x0000000189674BD0-0x0000000189674C10
	// [XID] // 0x0000000189674BD0-0x0000000189674C10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018528AC60-0x000000018528AF30
	// [XID] // 0x000000018967F1A0-0x000000018967F1C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018528CEF0-0x000000018528D230
	[BlackList] // 0x0000000189686AD0-0x0000000189686B10
	// [XID] // 0x0000000189686AD0-0x0000000189686B10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018528C400-0x000000018528C4F0
	// [XID] // 0x0000000189691AD0-0x0000000189691AF0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018528B7D0-0x000000018528B900
	[BlackList] // 0x0000000189699020-0x0000000189699060
	// [XID] // 0x0000000189699020-0x0000000189699060
	public override void AutoAllocTypeFields() {} // 0x000000018528AF30-0x000000018528AFD0
	[BlackList] // 0x00000001896A3420-0x00000001896A3460
	// [XID] // 0x00000001896A3420-0x00000001896A3460
	public override void AutoRecycleTypeFields() {} // 0x000000018528AFD0-0x000000018528B0B0
	[BlackList] // 0x00000001896AD710-0x00000001896AD750
	// [XID] // 0x00000001896AD710-0x00000001896AD750
	public override void ReturnToObjectPool() {} // 0x000000018528D360-0x000000018528D400
}

