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
public class ByAvatarBodyType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17288
{
	// Fields
	private string _bodyType; // 0x18

	// Properties
	public string bodyType { /* [XID] */ /* 0x00000001898D67A0-0x00000001898D67C0 */ get => default; /* [XID] */ /* 0x00000001898DE420-0x00000001898DE440 */ private set {} } // 0x0000000181A67A40-0x0000000181A67AE0 0x0000000181A67ED0-0x0000000181A67F80

	// Constructors
	public ByAvatarBodyType() {} // 0x0000000181A68110-0x0000000181A68170

	// Methods
	// [XID] // 0x00000001898E5C40-0x00000001898E5C60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A67F80-0x0000000181A68070
	// [XID] // 0x00000001898ED580-0x00000001898ED5A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181A67B40-0x0000000181A67C20
	// [XID] // 0x00000001898F4DE0-0x00000001898F4E00
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF696B */) => default; // 0x0000000181A676B0-0x0000000181A67790
	// [XID] // 0x00000001898FC4B0-0x00000001898FC4D0
	public override int GetHashNum() => default; // 0x0000000181A664B0-0x0000000181A66580
	// [XID] // 0x0000000189903F30-0x0000000189903F50
	public override void InitEmpty() {} // 0x0000000181A67110-0x0000000181A671E0
	[BlackList] // 0x000000018990B490-0x000000018990B4D0
	// [XID] // 0x000000018990B490-0x000000018990B4D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181A66B00-0x0000000181A66E80
	// [XID] // 0x0000000189915E00-0x0000000189915E20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181A65D40-0x0000000181A65F70
	[BlackList] // 0x000000018991D910-0x000000018991D950
	// [XID] // 0x000000018991D910-0x000000018991D950
	public static new ByAvatarBodyType ParseFromJson(JSONNode node) => default; // 0x0000000181A677F0-0x0000000181A67A40
	// [XID] // 0x0000000189928050-0x0000000189928070
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF696C */, bool useObjectPool = false /* Metadata: 0x00AF6970 */) => default; // 0x0000000181A673B0-0x0000000181A676B0
	// [XID] // 0x000000018992F6A0-0x000000018992F6C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6971 */, bool useObjectPool = false /* Metadata: 0x00AF6975 */) => default; // 0x0000000181A66660-0x0000000181A668D0
	// [XID] // 0x0000000189936AF0-0x0000000189936B10
	public static new ByAvatarBodyType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6976 */, bool useObjectPool = false /* Metadata: 0x00AF697A */) => default; // 0x0000000181A66E80-0x0000000181A670A0
	[BlackList] // 0x000000018993E630-0x000000018993E670
	// [XID] // 0x000000018993E630-0x000000018993E670
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A65F70-0x0000000181A66240
	// [XID] // 0x0000000189948D00-0x0000000189948D20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A67CD0-0x0000000181A67ED0
	[BlackList] // 0x00000001899504B0-0x00000001899504F0
	// [XID] // 0x00000001899504B0-0x00000001899504F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181A672C0-0x0000000181A673B0
	// [XID] // 0x000000018995AAB0-0x000000018995AAD0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181A668D0-0x0000000181A66A00
	[BlackList] // 0x0000000189962670-0x00000001899626B0
	// [XID] // 0x0000000189962670-0x00000001899626B0
	public override void AutoAllocTypeFields() {} // 0x0000000181A66240-0x0000000181A662E0
	[BlackList] // 0x000000018996C9B0-0x000000018996C9F0
	// [XID] // 0x000000018996C9B0-0x000000018996C9F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181A662E0-0x0000000181A66390
	[BlackList] // 0x0000000189977360-0x00000001899773A0
	// [XID] // 0x0000000189977360-0x00000001899773A0
	public override void ReturnToObjectPool() {} // 0x0000000181A68070-0x0000000181A68110
}

