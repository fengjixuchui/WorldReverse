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
public class GlobalSubShieldMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17057
{
	// Fields
	private string _mainShieldModifierName; // 0x30
	private bool _notifyMainshieldWhenHit; // 0x38

	// Properties
	public string mainShieldModifierName { /* [XID] */ /* 0x0000000189858800-0x0000000189858820 */ get => default; /* [XID] */ /* 0x000000018985F8F0-0x000000018985F910 */ private set {} } // 0x0000000181A00170-0x0000000181A00210 0x0000000181A01B20-0x0000000181A01BD0
	public bool notifyMainshieldWhenHit { /* [XID] */ /* 0x00000001898670F0-0x0000000189867110 */ get => default; /* [XID] */ /* 0x000000018986E910-0x000000018986E930 */ private set {} } // 0x00000001819FF920-0x00000001819FF9C0 0x0000000181A01F70-0x0000000181A02020
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898F1E10-0x00000001898F1E30 */ get => default; } // 0x0000000181A00820-0x0000000181A008C0 

	// Constructors
	public GlobalSubShieldMixin() {} // 0x0000000181A020C0-0x0000000181A02130

	// Methods
	// [XID] // 0x0000000189875E00-0x0000000189875E20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A01E60-0x0000000181A01F70
	// [XID] // 0x000000018987DA00-0x000000018987DA20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181A01A40-0x0000000181A01B20
	// [XID] // 0x0000000189884910-0x0000000189884930
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF61C3 */) => default; // 0x0000000181A01650-0x0000000181A01730
	// [XID] // 0x000000018988BF60-0x000000018988BF80
	public override int GetHashNum() => default; // 0x0000000181A00290-0x0000000181A00360
	// [XID] // 0x00000001898935B0-0x00000001898935D0
	public override void InitEmpty() {} // 0x0000000181A00FD0-0x0000000181A010A0
	[BlackList] // 0x000000018989AC90-0x000000018989ACD0
	// [XID] // 0x000000018989AC90-0x000000018989ACD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181A008C0-0x0000000181A00C40
	// [XID] // 0x00000001898A51E0-0x00000001898A5200
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001819FF9C0-0x00000001819FFCB0
	[BlackList] // 0x00000001898AC700-0x00000001898AC740
	// [XID] // 0x00000001898AC700-0x00000001898AC740
	public static new GlobalSubShieldMixin ParseFromJson(JSONNode node) => default; // 0x0000000181A01790-0x0000000181A019E0
	// [XID] // 0x00000001898B6E70-0x00000001898B6E90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61C4 */, bool useObjectPool = false /* Metadata: 0x00AF61C8 */) => default; // 0x0000000181A01270-0x0000000181A01570
	// [XID] // 0x00000001898BE580-0x00000001898BE5A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61C9 */, bool useObjectPool = false /* Metadata: 0x00AF61CD */) => default; // 0x0000000181A00440-0x0000000181A00720
	// [XID] // 0x00000001898C5D30-0x00000001898C5D50
	public static new GlobalSubShieldMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61CE */, bool useObjectPool = false /* Metadata: 0x00AF61D2 */) => default; // 0x0000000181A00CB0-0x0000000181A00ED0
	[BlackList] // 0x00000001898CD560-0x00000001898CD5A0
	// [XID] // 0x00000001898CD560-0x00000001898CD5A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001819FFCB0-0x00000001819FFF80
	// [XID] // 0x00000001898D7E40-0x00000001898D7E60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A01BD0-0x0000000181A01E60
	[BlackList] // 0x00000001898DFC00-0x00000001898DFC40
	// [XID] // 0x00000001898DFC00-0x00000001898DFC40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181A01180-0x0000000181A01270
	// [XID] // 0x00000001898EA7B0-0x00000001898EA7D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181A01570-0x0000000181A01650
	[BlackList] // 0x00000001898F9670-0x00000001898F96B0
	// [XID] // 0x00000001898F9670-0x00000001898F96B0
	public override void AutoAllocTypeFields() {} // 0x00000001819FFF80-0x0000000181A00020
	[BlackList] // 0x0000000189903F50-0x0000000189903F90
	// [XID] // 0x0000000189903F50-0x0000000189903F90
	public override void AutoRecycleTypeFields() {} // 0x0000000181A00020-0x0000000181A000D0
	[BlackList] // 0x000000018990E830-0x000000018990E870
	// [XID] // 0x000000018990E830-0x000000018990E870
	public override void ReturnToObjectPool() {} // 0x0000000181A02020-0x0000000181A020C0
}

