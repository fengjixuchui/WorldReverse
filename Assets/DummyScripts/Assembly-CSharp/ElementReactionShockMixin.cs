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
public class ElementReactionShockMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17123
{
	// Fields
	private SimpleSafeFloat thinkIntervalRawNum; // 0x30
	private string _campGlobalKey; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityAction _attackAction; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityAction _conductAction; // 0x48

	// Properties
	public float thinkInterval { /* [XID] */ /* 0x0000000189913220-0x0000000189913240 */ get => default; /* [XID] */ /* 0x000000018991A990-0x000000018991A9B0 */ private set {} } // 0x00000001829404E0-0x00000001829405C0 0x00000001829420B0-0x0000000182942190
	public string campGlobalKey { /* [XID] */ /* 0x00000001899120B0-0x00000001899120D0 */ get => default; /* [XID] */ /* 0x0000000189929A40-0x0000000189929A60 */ private set {} } // 0x0000000182942190-0x0000000182942230 0x0000000182941B30-0x0000000182941BE0
	public ConfigAbilityAction attackAction { /* [XID] */ /* 0x0000000189930FC0-0x0000000189930FE0 */ get => default; /* [XID] */ /* 0x0000000189938410-0x0000000189938430 */ private set {} } // 0x0000000182941270-0x0000000182941310 0x0000000182942230-0x00000001829422E0
	public ConfigAbilityAction conductAction { /* [XID] */ /* 0x000000018993FD00-0x000000018993FD20 */ get => default; /* [XID] */ /* 0x0000000189947420-0x0000000189947440 */ private set {} } // 0x000000018293FF70-0x0000000182940010 0x0000000182941E90-0x0000000182941F40
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899CBDC0-0x00000001899CBDE0 */ get => default; } // 0x0000000182940B30-0x0000000182940BD0 

	// Constructors
	public ElementReactionShockMixin() {} // 0x00000001829428E0-0x0000000182942950

	// Methods
	// [XID] // 0x000000018994EB80-0x000000018994EBA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829426D0-0x0000000182942840
	// [XID] // 0x00000001899560C0-0x00000001899560E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182941FA0-0x00000001829420B0
	// [XID] // 0x000000018995DBD0-0x000000018995DBF0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF63FD */) => default; // 0x0000000182941A50-0x0000000182941B30
	// [XID] // 0x0000000189965370-0x0000000189965390
	public override int GetHashNum() => default; // 0x00000001829403B0-0x0000000182940480
	// [XID] // 0x000000018996CA10-0x000000018996CA30
	public override void InitEmpty() {} // 0x0000000182941380-0x00000001829414A0
	[BlackList] // 0x0000000189974450-0x0000000189974490
	// [XID] // 0x0000000189974450-0x0000000189974490
	public override bool FromJson(JSONNode node) => default; // 0x0000000182940BD0-0x0000000182940F50
	// [XID] // 0x000000018997E720-0x000000018997E740
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018293F7D0-0x000000018293FCA0
	[BlackList] // 0x0000000189986150-0x0000000189986190
	// [XID] // 0x0000000189986150-0x0000000189986190
	public static new ElementReactionShockMixin ParseFromJson(JSONNode node) => default; // 0x0000000182941C40-0x0000000182941E90
	// [XID] // 0x0000000189990F10-0x0000000189990F30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63FE */, bool useObjectPool = false /* Metadata: 0x00AF6402 */) => default; // 0x0000000182941670-0x0000000182941970
	// [XID] // 0x0000000189998910-0x0000000189998930
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6403 */, bool useObjectPool = false /* Metadata: 0x00AF6407 */) => default; // 0x0000000182940640-0x0000000182940A30
	// [XID] // 0x00000001899A02B0-0x00000001899A02D0
	public static new ElementReactionShockMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6408 */, bool useObjectPool = false /* Metadata: 0x00AF640C */) => default; // 0x0000000182940FC0-0x00000001829411E0
	[BlackList] // 0x00000001899A7DC0-0x00000001899A7E00
	// [XID] // 0x00000001899A7DC0-0x00000001899A7E00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018293FCA0-0x000000018293FF70
	// [XID] // 0x00000001899B2690-0x00000001899B26B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829422E0-0x00000001829426D0
	[BlackList] // 0x00000001899B9970-0x00000001899B99B0
	// [XID] // 0x00000001899B9970-0x00000001899B99B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182941580-0x0000000182941670
	// [XID] // 0x00000001899C45A0-0x00000001899C45C0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182941970-0x0000000182941A50
	[BlackList] // 0x00000001899D32D0-0x00000001899D3310
	// [XID] // 0x00000001899D32D0-0x00000001899D3310
	public override void AutoAllocTypeFields() {} // 0x0000000182940010-0x00000001829400B0
	[BlackList] // 0x00000001899DD640-0x00000001899DD680
	// [XID] // 0x00000001899DD640-0x00000001899DD680
	public override void AutoRecycleTypeFields() {} // 0x00000001829400B0-0x0000000182940290
	[BlackList] // 0x00000001899E81E0-0x00000001899E8220
	// [XID] // 0x00000001899E81E0-0x00000001899E8220
	public override void ReturnToObjectPool() {} // 0x0000000182942840-0x00000001829428E0
}

