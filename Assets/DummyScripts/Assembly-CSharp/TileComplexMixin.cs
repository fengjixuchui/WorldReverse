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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TileComplexMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17070
{
	// Fields
	private string _attackID; // 0x30
	private string _attachPointName; // 0x38
	private MoleMole.Config.Vector _offset; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private TileShapeInfo _shape; // 0x50

	// Properties
	public string attackID { /* [XID] */ /* 0x00000001897523D0-0x00000001897523F0 */ get => default; /* [XID] */ /* 0x0000000189759940-0x0000000189759960 */ private set {} } // 0x00000001842F1400-0x00000001842F14A0 0x00000001842F14A0-0x00000001842F1550
	public string attachPointName { /* [XID] */ /* 0x0000000189761590-0x00000001897615B0 */ get => default; /* [XID] */ /* 0x0000000189768860-0x0000000189768880 */ private set {} } // 0x00000001842F0750-0x00000001842F07F0 0x00000001842F07F0-0x00000001842F08A0
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x000000018976FEF0-0x000000018976FF10 */ get => default; /* [XID] */ /* 0x0000000189777710-0x0000000189777730 */ private set {} } // 0x00000001842F1D40-0x00000001842F1E20 0x00000001842F2D30-0x00000001842F2E00
	public TileShapeInfo shape { /* [XID] */ /* 0x000000018977EE20-0x000000018977EE40 */ get => default; /* [XID] */ /* 0x0000000189786800-0x0000000189786820 */ private set {} } // 0x00000001842F15B0-0x00000001842F1650 0x00000001842F1C90-0x00000001842F1D40
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018980B500-0x000000018980B520 */ get => default; } // 0x00000001842F1BF0-0x00000001842F1C90 

	// Constructors
	public TileComplexMixin() {} // 0x00000001842F3800-0x00000001842F3860

	// Methods
	// [XID] // 0x000000018978DDF0-0x000000018978DE10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842F35E0-0x00000001842F3760
	// [XID] // 0x00000001897954E0-0x0000000189795500
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001842F30B0-0x00000001842F31C0
	// [XID] // 0x000000018979D8F0-0x000000018979D910
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6223 */) => default; // 0x00000001842F2BF0-0x00000001842F2CD0
	// [XID] // 0x00000001897A4B90-0x00000001897A4BB0
	public override int GetHashNum() => default; // 0x00000001842F1330-0x00000001842F1400
	// [XID] // 0x00000001897AC1E0-0x00000001897AC200
	public override void InitEmpty() {} // 0x00000001842F2530-0x00000001842F2640
	[BlackList] // 0x00000001897B4150-0x00000001897B4190
	// [XID] // 0x00000001897B4150-0x00000001897B4190
	public override bool FromJson(JSONNode node) => default; // 0x00000001842F1E20-0x00000001842F21A0
	// [XID] // 0x00000001897BF190-0x00000001897BF1B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001842F08A0-0x00000001842F0D50
	[BlackList] // 0x00000001897C6760-0x00000001897C67A0
	// [XID] // 0x00000001897C6760-0x00000001897C67A0
	public static new TileComplexMixin ParseFromJson(JSONNode node) => default; // 0x00000001842F2E00-0x00000001842F3050
	// [XID] // 0x00000001897D0CF0-0x00000001897D0D10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6224 */, bool useObjectPool = false /* Metadata: 0x00AF6228 */) => default; // 0x00000001842F2810-0x00000001842F2B10
	// [XID] // 0x00000001897D8BB0-0x00000001897D8BD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6229 */, bool useObjectPool = false /* Metadata: 0x00AF622D */) => default; // 0x00000001842F16D0-0x00000001842F1AF0
	// [XID] // 0x00000001897DFDF0-0x00000001897DFE10
	public static new TileComplexMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF622E */, bool useObjectPool = false /* Metadata: 0x00AF6232 */) => default; // 0x00000001842F2210-0x00000001842F2430
	[BlackList] // 0x00000001897E73D0-0x00000001897E7410
	// [XID] // 0x00000001897E73D0-0x00000001897E7410
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001842F0D50-0x00000001842F1020
	// [XID] // 0x00000001897F23F0-0x00000001897F2410
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842F31C0-0x00000001842F35E0
	[BlackList] // 0x00000001897F9AC0-0x00000001897F9B00
	// [XID] // 0x00000001897F9AC0-0x00000001897F9B00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001842F2720-0x00000001842F2810
	// [XID] // 0x0000000189804130-0x0000000189804150
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001842F2B10-0x00000001842F2BF0
	[BlackList] // 0x0000000189812BC0-0x0000000189812C00
	// [XID] // 0x0000000189812BC0-0x0000000189812C00
	public override void AutoAllocTypeFields() {} // 0x00000001842F1020-0x00000001842F10C0
	[BlackList] // 0x000000018981D730-0x000000018981D770
	// [XID] // 0x000000018981D730-0x000000018981D770
	public override void AutoRecycleTypeFields() {} // 0x00000001842F10C0-0x00000001842F1210
	[BlackList] // 0x0000000189827EE0-0x0000000189827F20
	// [XID] // 0x0000000189827EE0-0x0000000189827F20
	public override void ReturnToObjectPool() {} // 0x00000001842F3760-0x00000001842F3800
}

