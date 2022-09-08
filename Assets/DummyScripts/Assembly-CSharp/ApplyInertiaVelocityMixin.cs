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
public class ApplyInertiaVelocityMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17002
{
	// Fields
	private SimpleSafeFloat dampingRawNum; // 0x30
	private bool _useXZ; // 0x34
	private bool _useY; // 0x35

	// Properties
	public float damping { /* [XID] */ /* 0x0000000189792600-0x0000000189792620 */ get => default; /* [XID] */ /* 0x0000000189799BB0-0x0000000189799BD0 */ private set {} } // 0x0000000183101410-0x00000001831014F0 0x0000000183101CF0-0x0000000183101DD0
	public bool useXZ { /* [XID] */ /* 0x00000001897A1A20-0x00000001897A1A40 */ get => default; /* [XID] */ /* 0x00000001897A92A0-0x00000001897A92C0 */ private set {} } // 0x0000000183101370-0x0000000183101410 0x0000000183100550-0x0000000183100600
	public bool useY { /* [XID] */ /* 0x00000001897B0A80-0x00000001897B0AA0 */ get => default; /* [XID] */ /* 0x00000001897B87E0-0x00000001897B8800 */ private set {} } // 0x0000000183101B70-0x0000000183101C10 0x0000000183100A10-0x0000000183100AC0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018983C930-0x000000018983C950 */ get => default; } // 0x0000000183100BC0-0x0000000183100C60 

	// Constructors
	public ApplyInertiaVelocityMixin() {} // 0x0000000183102670-0x0000000183102710

	// Methods
	// [XID] // 0x00000001897C0840-0x00000001897C0860
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831024A0-0x00000001831025D0
	// [XID] // 0x00000001897C8110-0x00000001897C8130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001831020E0-0x0000000183102190
	// [XID] // 0x00000001897CF4D0-0x00000001897CF4F0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF600D */) => default; // 0x0000000183101C10-0x0000000183101CF0
	// [XID] // 0x00000001897D6D80-0x00000001897D6DA0
	public override int GetHashNum() => default; // 0x0000000183100480-0x0000000183100550
	// [XID] // 0x00000001897DE430-0x00000001897DE450
	public override void InitEmpty() {} // 0x00000001831014F0-0x00000001831015C0
	[BlackList] // 0x00000001897E5ED0-0x00000001897E5F10
	// [XID] // 0x00000001897E5ED0-0x00000001897E5F10
	public override bool FromJson(JSONNode node) => default; // 0x0000000183100C60-0x0000000183100FE0
	// [XID] // 0x00000001897F0A80-0x00000001897F0AA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001830FFB40-0x00000001830FFF10
	[BlackList] // 0x00000001897F81A0-0x00000001897F81E0
	// [XID] // 0x00000001897F81A0-0x00000001897F81E0
	public static new ApplyInertiaVelocityMixin ParseFromJson(JSONNode node) => default; // 0x0000000183101E30-0x0000000183102080
	// [XID] // 0x0000000189802820-0x0000000189802840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF600E */, bool useObjectPool = false /* Metadata: 0x00AF6012 */) => default; // 0x0000000183101790-0x0000000183101A90
	// [XID] // 0x0000000189809ED0-0x0000000189809EF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6013 */, bool useObjectPool = false /* Metadata: 0x00AF6017 */) => default; // 0x00000001831006E0-0x0000000183100A10
	// [XID] // 0x00000001898115A0-0x00000001898115C0
	public static new ApplyInertiaVelocityMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6018 */, bool useObjectPool = false /* Metadata: 0x00AF601C */) => default; // 0x0000000183101050-0x0000000183101270
	[BlackList] // 0x00000001898190F0-0x0000000189819130
	// [XID] // 0x00000001898190F0-0x0000000189819130
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001830FFF10-0x00000001831001E0
	// [XID] // 0x00000001898233D0-0x00000001898233F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183102190-0x00000001831024A0
	[BlackList] // 0x000000018982AD30-0x000000018982AD70
	// [XID] // 0x000000018982AD30-0x000000018982AD70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831016A0-0x0000000183101790
	// [XID] // 0x00000001898351F0-0x0000000189835210
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183101A90-0x0000000183101B70
	[BlackList] // 0x0000000189844040-0x0000000189844080
	// [XID] // 0x0000000189844040-0x0000000189844080
	public override void AutoAllocTypeFields() {} // 0x00000001831001E0-0x0000000183100280
	[BlackList] // 0x000000018984E480-0x000000018984E4C0
	// [XID] // 0x000000018984E480-0x000000018984E4C0
	public override void AutoRecycleTypeFields() {} // 0x0000000183100280-0x0000000183100360
	[BlackList] // 0x0000000189858820-0x0000000189858860
	// [XID] // 0x0000000189858820-0x0000000189858860
	public override void ReturnToObjectPool() {} // 0x00000001831025D0-0x0000000183102670
}

