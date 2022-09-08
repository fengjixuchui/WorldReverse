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
public class ByBigTeamBodyTypeSort : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17316
{
	// Fields
	private SimpleSafeUInt32 numberRawNum; // 0x18
	private RelationalOperator _logic; // 0x1C

	// Properties
	public uint number { /* [XID] */ /* 0x00000001897D6C80-0x00000001897D6CA0 */ get => default; /* [XID] */ /* 0x00000001897DE3D0-0x00000001897DE3F0 */ private set {} } // 0x000000018151FC60-0x000000018151FD30 0x00000001815213E0-0x00000001815214C0
	public RelationalOperator logic { /* [XID] */ /* 0x00000001897E5E30-0x00000001897E5E50 */ get => default; /* [XID] */ /* 0x00000001897ED830-0x00000001897ED850 */ private set {} } // 0x0000000181520FE0-0x0000000181521080 0x00000001815207E0-0x0000000181520890

	// Constructors
	public ByBigTeamBodyTypeSort() {} // 0x00000001815219E0-0x0000000181521A40

	// Methods
	// [XID] // 0x00000001897F50B0-0x00000001897F50D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181521830-0x0000000181521940
	// [XID] // 0x00000001897FCB40-0x00000001897FCB60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181521330-0x00000001815213E0
	// [XID] // 0x00000001898040B0-0x00000001898040D0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6A4B */) => default; // 0x0000000181520EA0-0x0000000181520F80
	// [XID] // 0x000000018980B4A0-0x000000018980B4C0
	public override int GetHashNum() => default; // 0x000000018151FAB0-0x000000018151FB80
	// [XID] // 0x0000000189812B00-0x0000000189812B20
	public override void InitEmpty() {} // 0x0000000181520900-0x00000001815209D0
	[BlackList] // 0x000000018981A700-0x000000018981A740
	// [XID] // 0x000000018981A700-0x000000018981A740
	public override bool FromJson(JSONNode node) => default; // 0x0000000181520240-0x00000001815205C0
	// [XID] // 0x0000000189824BC0-0x0000000189824BE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018151F200-0x000000018151F540
	[BlackList] // 0x000000018982C550-0x000000018982C590
	// [XID] // 0x000000018982C550-0x000000018982C590
	public static new ByBigTeamBodyTypeSort ParseFromJson(JSONNode node) => default; // 0x0000000181521080-0x00000001815212D0
	// [XID] // 0x00000001898369F0-0x0000000189836A10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A4C */, bool useObjectPool = false /* Metadata: 0x00AF6A50 */) => default; // 0x0000000181520BA0-0x0000000181520EA0
	// [XID] // 0x000000018983DE20-0x000000018983DE40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A51 */, bool useObjectPool = false /* Metadata: 0x00AF6A55 */) => default; // 0x000000018151FD30-0x0000000181520010
	// [XID] // 0x0000000189845610-0x0000000189845630
	public static new ByBigTeamBodyTypeSort ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A56 */, bool useObjectPool = false /* Metadata: 0x00AF6A5A */) => default; // 0x00000001815205C0-0x00000001815207E0
	[BlackList] // 0x000000018984CBC0-0x000000018984CC00
	// [XID] // 0x000000018984CBC0-0x000000018984CC00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018151F540-0x000000018151F810
	// [XID] // 0x0000000189856CA0-0x0000000189856CC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181521570-0x0000000181521830
	[BlackList] // 0x000000018985DE30-0x000000018985DE70
	// [XID] // 0x000000018985DE30-0x000000018985DE70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181520AB0-0x0000000181520BA0
	// [XID] // 0x0000000189868910-0x0000000189868930
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181520010-0x0000000181520140
	[BlackList] // 0x000000018986FD80-0x000000018986FDC0
	// [XID] // 0x000000018986FD80-0x000000018986FDC0
	public override void AutoAllocTypeFields() {} // 0x000000018151F810-0x000000018151F8B0
	[BlackList] // 0x000000018987A910-0x000000018987A950
	// [XID] // 0x000000018987A910-0x000000018987A950
	public override void AutoRecycleTypeFields() {} // 0x000000018151F8B0-0x000000018151F990
	[BlackList] // 0x0000000189884850-0x0000000189884890
	// [XID] // 0x0000000189884850-0x0000000189884890
	public override void ReturnToObjectPool() {} // 0x0000000181521940-0x00000001815219E0
}

