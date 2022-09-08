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
public class AttachLight : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16389
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigLightAttach _attach; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigLightComponent _light; // 0x70

	// Properties
	public ConfigLightAttach attach { /* [XID] */ /* 0x0000000189AC0C70-0x0000000189AC0C90 */ get => default; /* [XID] */ /* 0x0000000189AC86D0-0x0000000189AC86F0 */ private set {} } // 0x0000000183989510-0x00000001839895B0 0x000000018398A180-0x000000018398A230
	public ConfigLightComponent light { /* [XID] */ /* 0x0000000189ACFDF0-0x0000000189ACFE10 */ get => default; /* [XID] */ /* 0x0000000189AD7C20-0x0000000189AD7C40 */ private set {} } // 0x0000000183988E50-0x0000000183988EF0 0x000000018398A0D0-0x000000018398A180

	// Constructors
	public AttachLight() {} // 0x000000018398A6B0-0x000000018398A710

	// Methods
	// [XID] // 0x0000000189ADF6F0-0x0000000189ADF710
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018398A500-0x000000018398A610
	// [XID] // 0x0000000189AE6ED0-0x0000000189AE6EF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183989FD0-0x000000018398A0D0
	// [XID] // 0x0000000189AEEA20-0x0000000189AEEA40
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF39F0 */) => default; // 0x0000000183989BE0-0x0000000183989CC0
	// [XID] // 0x0000000189AF5FF0-0x0000000189AF6010
	public override int GetHashNum() => default; // 0x00000001839888C0-0x0000000183988990
	// [XID] // 0x0000000189AFD510-0x0000000189AFD530
	public override void InitEmpty() {} // 0x0000000183989620-0x0000000183989710
	[BlackList] // 0x0000000189B04CC0-0x0000000189B04D00
	// [XID] // 0x0000000189B04CC0-0x0000000189B04D00
	public override bool FromJson(JSONNode node) => default; // 0x0000000183988F70-0x00000001839892F0
	// [XID] // 0x0000000189B0F4B0-0x0000000189B0F4D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183987F40-0x0000000183988280
	[BlackList] // 0x0000000189B16770-0x0000000189B167B0
	// [XID] // 0x0000000189B16770-0x0000000189B167B0
	public static new AttachLight ParseFromJson(JSONNode node) => default; // 0x0000000183989D20-0x0000000183989F70
	// [XID] // 0x0000000189B20E50-0x0000000189B20E70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39F1 */, bool useObjectPool = false /* Metadata: 0x00AF39F5 */) => default; // 0x00000001839898E0-0x0000000183989BE0
	// [XID] // 0x0000000189B28510-0x0000000189B28530
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39F6 */, bool useObjectPool = false /* Metadata: 0x00AF39FA */) => default; // 0x0000000183988A70-0x0000000183988DD0
	// [XID] // 0x0000000189B2F890-0x0000000189B2F8B0
	public static new AttachLight ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39FB */, bool useObjectPool = false /* Metadata: 0x00AF39FF */) => default; // 0x00000001839892F0-0x0000000183989510
	[BlackList] // 0x0000000189B371B0-0x0000000189B371F0
	// [XID] // 0x0000000189B371B0-0x0000000189B371F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183988280-0x0000000183988550
	// [XID] // 0x0000000189B41D10-0x0000000189B41D30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018398A230-0x000000018398A500
	[BlackList] // 0x0000000189B49660-0x0000000189B496A0
	// [XID] // 0x0000000189B49660-0x0000000189B496A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001839897F0-0x00000001839898E0
	[BlackList] // 0x0000000189B53AC0-0x0000000189B53B00
	// [XID] // 0x0000000189B53AC0-0x0000000189B53B00
	public override void AutoAllocTypeFields() {} // 0x0000000183988550-0x00000001839885F0
	[BlackList] // 0x0000000189B5E5C0-0x0000000189B5E600
	// [XID] // 0x0000000189B5E5C0-0x0000000189B5E600
	public override void AutoRecycleTypeFields() {} // 0x00000001839885F0-0x00000001839887A0
	[BlackList] // 0x0000000189B68C40-0x0000000189B68C80
	// [XID] // 0x0000000189B68C40-0x0000000189B68C80
	public override void ReturnToObjectPool() {} // 0x000000018398A610-0x000000018398A6B0
}

