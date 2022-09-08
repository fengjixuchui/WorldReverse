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
public class CameraBlurMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17106
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCameraRadialBlur _cameraRadialBlur; // 0x30

	// Properties
	public ConfigCameraRadialBlur cameraRadialBlur { /* [XID] */ /* 0x00000001899146E0-0x0000000189914700 */ get => default; /* [XID] */ /* 0x000000018991C260-0x000000018991C280 */ private set {} } // 0x0000000182220730-0x00000001822207D0 0x0000000182220580-0x0000000182220630
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899A02D0-0x00000001899A02F0 */ get => default; } // 0x000000018221FED0-0x000000018221FF70 

	// Constructors
	public CameraBlurMixin() {} // 0x00000001822216D0-0x0000000182221730

	// Methods
	// [XID] // 0x00000001899239A0-0x00000001899239C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182221550-0x0000000182221630
	// [XID] // 0x000000018992AFE0-0x000000018992B000
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182221240-0x0000000182221320
	// [XID] // 0x0000000189932640-0x0000000189932660
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6373 */) => default; // 0x0000000182220E50-0x0000000182220F30
	// [XID] // 0x000000018993A030-0x000000018993A050
	public override int GetHashNum() => default; // 0x000000018221F980-0x000000018221FA50
	// [XID] // 0x0000000189941240-0x0000000189941260
	public override void InitEmpty() {} // 0x00000001822207D0-0x00000001822208A0
	[BlackList] // 0x0000000189948D20-0x0000000189948D60
	// [XID] // 0x0000000189948D20-0x0000000189948D60
	public override bool FromJson(JSONNode node) => default; // 0x000000018221FF70-0x00000001822202F0
	// [XID] // 0x0000000189953350-0x0000000189953370
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018221F180-0x000000018221F3C0
	[BlackList] // 0x000000018995AB10-0x000000018995AB50
	// [XID] // 0x000000018995AB10-0x000000018995AB50
	public static new CameraBlurMixin ParseFromJson(JSONNode node) => default; // 0x0000000182220F90-0x00000001822211E0
	// [XID] // 0x0000000189965390-0x00000001899653B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6374 */, bool useObjectPool = false /* Metadata: 0x00AF6378 */) => default; // 0x0000000182220A70-0x0000000182220D70
	// [XID] // 0x000000018996CA30-0x000000018996CA50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6379 */, bool useObjectPool = false /* Metadata: 0x00AF637D */) => default; // 0x000000018221FB30-0x000000018221FDD0
	// [XID] // 0x0000000189974490-0x00000001899744B0
	public static new CameraBlurMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF637E */, bool useObjectPool = false /* Metadata: 0x00AF6382 */) => default; // 0x0000000182220360-0x0000000182220580
	[BlackList] // 0x000000018997BAC0-0x000000018997BB00
	// [XID] // 0x000000018997BAC0-0x000000018997BB00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018221F3C0-0x000000018221F690
	// [XID] // 0x0000000189986190-0x00000001899861B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182221320-0x0000000182221550
	[BlackList] // 0x000000018998DDA0-0x000000018998DDE0
	// [XID] // 0x000000018998DDA0-0x000000018998DDE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182220980-0x0000000182220A70
	// [XID] // 0x0000000189998930-0x0000000189998950
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182220D70-0x0000000182220E50
	[BlackList] // 0x00000001899A7E00-0x00000001899A7E40
	// [XID] // 0x00000001899A7E00-0x00000001899A7E40
	public override void AutoAllocTypeFields() {} // 0x000000018221F690-0x000000018221F730
	[BlackList] // 0x00000001899B26B0-0x00000001899B26F0
	// [XID] // 0x00000001899B26B0-0x00000001899B26F0
	public override void AutoRecycleTypeFields() {} // 0x000000018221F730-0x000000018221F860
	[BlackList] // 0x00000001899BCB30-0x00000001899BCB70
	// [XID] // 0x00000001899BCB30-0x00000001899BCB70
	public override void ReturnToObjectPool() {} // 0x0000000182221630-0x00000001822216D0
}

