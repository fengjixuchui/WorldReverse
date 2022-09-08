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
public class ByGameTimeIsLocked : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17360
{
	// Fields
	private bool _isLocked; // 0x18

	// Properties
	public bool isLocked { /* [XID] */ /* 0x0000000189AAE860-0x0000000189AAE880 */ get => default; /* [XID] */ /* 0x0000000189AB61A0-0x0000000189AB61C0 */ private set {} } // 0x0000000184FCA320-0x0000000184FCA3C0 0x0000000184FC8E20-0x0000000184FC8ED0

	// Constructors
	public ByGameTimeIsLocked() {} // 0x0000000184FCA910-0x0000000184FCA980

	// Methods
	// [XID] // 0x0000000189ABDBF0-0x0000000189ABDC10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184FCA780-0x0000000184FCA870
	// [XID] // 0x0000000189AC5710-0x0000000189AC5730
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184FCA420-0x0000000184FCA4D0
	// [XID] // 0x0000000189ACCBE0-0x0000000189ACCC00
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B9F */) => default; // 0x0000000184FC9F90-0x0000000184FCA070
	// [XID] // 0x0000000189AD4980-0x0000000189AD49A0
	public override int GetHashNum() => default; // 0x0000000184FC8D50-0x0000000184FC8E20
	// [XID] // 0x0000000189ADC2A0-0x0000000189ADC2C0
	public override void InitEmpty() {} // 0x0000000184FC9A20-0x0000000184FC9AC0
	[BlackList] // 0x0000000189AE3CD0-0x0000000189AE3D10
	// [XID] // 0x0000000189AE3CD0-0x0000000189AE3D10
	public override bool FromJson(JSONNode node) => default; // 0x0000000184FC9410-0x0000000184FC9790
	// [XID] // 0x0000000189AEE800-0x0000000189AEE820
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184FC8610-0x0000000184FC8810
	[BlackList] // 0x0000000189AF5E30-0x0000000189AF5E70
	// [XID] // 0x0000000189AF5E30-0x0000000189AF5E70
	public static new ByGameTimeIsLocked ParseFromJson(JSONNode node) => default; // 0x0000000184FCA0D0-0x0000000184FCA320
	// [XID] // 0x0000000189B00430-0x0000000189B00450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BA0 */, bool useObjectPool = false /* Metadata: 0x00AF6BA4 */) => default; // 0x0000000184FC9C90-0x0000000184FC9F90
	// [XID] // 0x0000000189B07990-0x0000000189B079B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BA5 */, bool useObjectPool = false /* Metadata: 0x00AF6BA9 */) => default; // 0x0000000184FC8FB0-0x0000000184FC91E0
	// [XID] // 0x0000000189B0F230-0x0000000189B0F250
	public static new ByGameTimeIsLocked ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BAA */, bool useObjectPool = false /* Metadata: 0x00AF6BAE */) => default; // 0x0000000184FC9790-0x0000000184FC99B0
	[BlackList] // 0x0000000189B16590-0x0000000189B165D0
	// [XID] // 0x0000000189B16590-0x0000000189B165D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184FC8810-0x0000000184FC8AE0
	// [XID] // 0x0000000189B20C70-0x0000000189B20C90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184FCA580-0x0000000184FCA780
	[BlackList] // 0x0000000189B283B0-0x0000000189B283F0
	// [XID] // 0x0000000189B283B0-0x0000000189B283F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184FC9BA0-0x0000000184FC9C90
	// [XID] // 0x0000000189B328A0-0x0000000189B328C0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184FC91E0-0x0000000184FC9310
	[BlackList] // 0x0000000189B3A1B0-0x0000000189B3A1F0
	// [XID] // 0x0000000189B3A1B0-0x0000000189B3A1F0
	public override void AutoAllocTypeFields() {} // 0x0000000184FC8AE0-0x0000000184FC8B80
	[BlackList] // 0x0000000189B44AD0-0x0000000189B44B10
	// [XID] // 0x0000000189B44AD0-0x0000000189B44B10
	public override void AutoRecycleTypeFields() {} // 0x0000000184FC8B80-0x0000000184FC8C30
	[BlackList] // 0x0000000189B4F230-0x0000000189B4F270
	// [XID] // 0x0000000189B4F230-0x0000000189B4F270
	public override void ReturnToObjectPool() {} // 0x0000000184FCA870-0x0000000184FCA910
}

