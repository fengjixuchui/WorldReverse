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
public class ServerUpdateGlobalValueMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17121
{
	// Fields
	private string _key; // 0x30
	private bool _useLimitRange; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxValue; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _minValue; // 0x48

	// Properties
	public string key { /* [XID] */ /* 0x000000018981EF20-0x000000018981EF40 */ get => default; /* [XID] */ /* 0x0000000189826410-0x0000000189826430 */ private set {} } // 0x0000000181CEB8F0-0x0000000181CEB990 0x0000000181CED3F0-0x0000000181CED4A0
	public bool useLimitRange { /* [XID] */ /* 0x000000018982DAA0-0x000000018982DAC0 */ get => default; /* [XID] */ /* 0x0000000189835190-0x00000001898351B0 */ private set {} } // 0x0000000181CEBA70-0x0000000181CEBB10 0x0000000181CED9E0-0x0000000181CEDA90
	public DynamicFloat maxValue { /* [XID] */ /* 0x000000018983C8D0-0x000000018983C8F0 */ get => default; /* [XID] */ /* 0x0000000189844020-0x0000000189844040 */ private set {} } // 0x0000000181CEC8A0-0x0000000181CEC940 0x0000000181CEB840-0x0000000181CEB8F0
	public DynamicFloat minValue { /* [XID] */ /* 0x000000018984B450-0x000000018984B470 */ get => default; /* [XID] */ /* 0x00000001898525C0-0x00000001898525E0 */ private set {} } // 0x0000000181CED100-0x0000000181CED1A0 0x0000000181CEC0E0-0x0000000181CEC190
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898D4F70-0x00000001898D4F90 */ get => default; } // 0x0000000181CEC040-0x0000000181CEC0E0 

	// Constructors
	public ServerUpdateGlobalValueMixin() {} // 0x0000000181CEDCA0-0x0000000181CEDD40

	// Methods
	// [XID] // 0x000000018985A030-0x000000018985A050
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181CEDA90-0x0000000181CEDC00
	// [XID] // 0x00000001898611D0-0x00000001898611F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181CED500-0x0000000181CED610
	// [XID] // 0x0000000189868990-0x00000001898689B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF63ED */) => default; // 0x0000000181CECFC0-0x0000000181CED0A0
	// [XID] // 0x000000018986FE20-0x000000018986FE40
	public override int GetHashNum() => default; // 0x0000000181CEB770-0x0000000181CEB840
	// [XID] // 0x00000001898774D0-0x00000001898774F0
	public override void InitEmpty() {} // 0x0000000181CEC940-0x0000000181CECA10
	[BlackList] // 0x000000018987ED20-0x000000018987ED60
	// [XID] // 0x000000018987ED20-0x000000018987ED60
	public override bool FromJson(JSONNode node) => default; // 0x0000000181CEC190-0x0000000181CEC510
	// [XID] // 0x0000000189889100-0x0000000189889120
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181CEACC0-0x0000000181CEB130
	[BlackList] // 0x0000000189890480-0x00000001898904C0
	// [XID] // 0x0000000189890480-0x00000001898904C0
	public static new ServerUpdateGlobalValueMixin ParseFromJson(JSONNode node) => default; // 0x0000000181CED1A0-0x0000000181CED3F0
	// [XID] // 0x000000018989AC70-0x000000018989AC90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63EE */, bool useObjectPool = false /* Metadata: 0x00AF63F2 */) => default; // 0x0000000181CECBE0-0x0000000181CECEE0
	// [XID] // 0x00000001898A1FC0-0x00000001898A1FE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63F3 */, bool useObjectPool = false /* Metadata: 0x00AF63F7 */) => default; // 0x0000000181CEBB10-0x0000000181CEBF40
	// [XID] // 0x00000001898A9750-0x00000001898A9770
	public static new ServerUpdateGlobalValueMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63F8 */, bool useObjectPool = false /* Metadata: 0x00AF63FC */) => default; // 0x0000000181CEC580-0x0000000181CEC7A0
	[BlackList] // 0x00000001898B0F80-0x00000001898B0FC0
	// [XID] // 0x00000001898B0F80-0x00000001898B0FC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181CEB130-0x0000000181CEB400
	// [XID] // 0x00000001898BB990-0x00000001898BB9B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181CED610-0x0000000181CED9E0
	[BlackList] // 0x00000001898C2D40-0x00000001898C2D80
	// [XID] // 0x00000001898C2D40-0x00000001898C2D80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181CECAF0-0x0000000181CECBE0
	// [XID] // 0x00000001898CD540-0x00000001898CD560
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181CECEE0-0x0000000181CECFC0
	[BlackList] // 0x00000001898DC8B0-0x00000001898DC8F0
	// [XID] // 0x00000001898DC8B0-0x00000001898DC8F0
	public override void AutoAllocTypeFields() {} // 0x0000000181CEB400-0x0000000181CEB4A0
	[BlackList] // 0x00000001898E7670-0x00000001898E76B0
	// [XID] // 0x00000001898E7670-0x00000001898E76B0
	public override void AutoRecycleTypeFields() {} // 0x0000000181CEB4A0-0x0000000181CEB650
	[BlackList] // 0x00000001898F1DD0-0x00000001898F1E10
	// [XID] // 0x00000001898F1DD0-0x00000001898F1E10
	public override void ReturnToObjectPool() {} // 0x0000000181CEDC00-0x0000000181CEDCA0
}

