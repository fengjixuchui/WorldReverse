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
public class DoTileActionManagerMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17074
{
	// Fields
	private SimpleSafeFloat durationRawNum; // 0x30
	private string _actionID; // 0x38
	private string _actionPosKey; // 0x40
	private string _actionRadiusKey; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x50

	// Properties
	public float duration { /* [XID] */ /* 0x000000018991EFE0-0x000000018991F000 */ get => default; /* [XID] */ /* 0x0000000189926A60-0x0000000189926A80 */ private set {} } // 0x0000000182C75190-0x0000000182C75270 0x0000000182C75A30-0x0000000182C75B10
	public string actionID { /* [XID] */ /* 0x000000018992E070-0x000000018992E090 */ get => default; /* [XID] */ /* 0x00000001899353B0-0x00000001899353D0 */ private set {} } // 0x0000000182C76C10-0x0000000182C76CB0 0x0000000182C76470-0x0000000182C76520
	public string actionPosKey { /* [XID] */ /* 0x000000018993CF70-0x000000018993CF90 */ get => default; /* [XID] */ /* 0x0000000189944580-0x00000001899445A0 */ private set {} } // 0x0000000182C74B40-0x0000000182C74BE0 0x0000000182C776C0-0x0000000182C77770
	public string actionRadiusKey { /* [XID] */ /* 0x000000018994BB60-0x000000018994BB80 */ get => default; /* [XID] */ /* 0x0000000189953370-0x0000000189953390 */ private set {} } // 0x0000000182C753C0-0x0000000182C75460 0x0000000182C763C0-0x0000000182C76470
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x000000018995AB50-0x000000018995AB70 */ get => default; /* [XID] */ /* 0x00000001899626B0-0x00000001899626D0 */ private set {} } // 0x0000000182C771D0-0x0000000182C77270 0x0000000182C75040-0x0000000182C750F0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899E6930-0x00000001899E6950 */ get => default; } // 0x0000000182C75C10-0x0000000182C75CB0 

	// Constructors
	public DoTileActionManagerMixin() {} // 0x0000000182C77980-0x0000000182C779E0

	// Methods
	// [XID] // 0x0000000189969A60-0x0000000189969A80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C77770-0x0000000182C778E0
	// [XID] // 0x00000001899717E0-0x0000000189971800
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C770A0-0x0000000182C771D0
	// [XID] // 0x00000001899790F0-0x0000000189979110
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6243 */) => default; // 0x0000000182C76CB0-0x0000000182C76D90
	// [XID] // 0x00000001899801A0-0x00000001899801C0
	public override int GetHashNum() => default; // 0x0000000182C752F0-0x0000000182C753C0
	// [XID] // 0x00000001899879B0-0x00000001899879D0
	public override void InitEmpty() {} // 0x0000000182C76520-0x0000000182C76660
	[BlackList] // 0x000000018998F560-0x000000018998F5A0
	// [XID] // 0x000000018998F560-0x000000018998F5A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C75CB0-0x0000000182C76030
	// [XID] // 0x000000018999A4B0-0x000000018999A4D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C74560-0x0000000182C74B40
	[BlackList] // 0x00000001899A1B50-0x00000001899A1B90
	// [XID] // 0x00000001899A1B50-0x00000001899A1B90
	public static new DoTileActionManagerMixin ParseFromJson(JSONNode node) => default; // 0x0000000182C76DF0-0x0000000182C77040
	// [XID] // 0x00000001899AC6D0-0x00000001899AC6F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6244 */, bool useObjectPool = false /* Metadata: 0x00AF6248 */) => default; // 0x0000000182C76830-0x0000000182C76B30
	// [XID] // 0x00000001899B3E40-0x00000001899B3E60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6249 */, bool useObjectPool = false /* Metadata: 0x00AF624D */) => default; // 0x0000000182C75540-0x0000000182C75A30
	// [XID] // 0x00000001899BB2B0-0x00000001899BB2D0
	public static new DoTileActionManagerMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF624E */, bool useObjectPool = false /* Metadata: 0x00AF6252 */) => default; // 0x0000000182C760A0-0x0000000182C762C0
	[BlackList] // 0x00000001899C2D80-0x00000001899C2DC0
	// [XID] // 0x00000001899C2D80-0x00000001899C2DC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C74BE0-0x0000000182C74EB0
	// [XID] // 0x00000001899CD490-0x00000001899CD4B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C77270-0x0000000182C776C0
	[BlackList] // 0x00000001899D48F0-0x00000001899D4930
	// [XID] // 0x00000001899D48F0-0x00000001899D4930
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C76740-0x0000000182C76830
	// [XID] // 0x00000001899DECD0-0x00000001899DECF0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182C76B30-0x0000000182C76C10
	[BlackList] // 0x00000001899EDF20-0x00000001899EDF60
	// [XID] // 0x00000001899EDF20-0x00000001899EDF60
	public override void AutoAllocTypeFields() {} // 0x0000000182C74EB0-0x0000000182C74F50
	[BlackList] // 0x00000001899F86F0-0x00000001899F8730
	// [XID] // 0x00000001899F86F0-0x00000001899F8730
	public override void AutoRecycleTypeFields() {} // 0x0000000182C74F50-0x0000000182C75040
	[BlackList] // 0x0000000189A02CF0-0x0000000189A02D30
	// [XID] // 0x0000000189A02CF0-0x0000000189A02D30
	public override void ReturnToObjectPool() {} // 0x0000000182C778E0-0x0000000182C77980
}

