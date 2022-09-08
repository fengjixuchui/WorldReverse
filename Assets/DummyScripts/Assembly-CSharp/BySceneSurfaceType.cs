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
public class BySceneSurfaceType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17250
{
	// Fields
	private SceneSurfaceType[] _filters; // 0x18
	private bool _include; // 0x20
	private MoleMole.Config.Vector _offset; // 0x24

	// Properties
	public SceneSurfaceType[] filters { /* [XID] */ /* 0x00000001897AD930-0x00000001897AD950 */ get => default; /* [XID] */ /* 0x00000001897B5A10-0x00000001897B5A30 */ private set {} } // 0x0000000181A07A00-0x0000000181A07AA0 0x0000000181A087B0-0x0000000181A08860
	public bool include { /* [XID] */ /* 0x00000001897BD740-0x00000001897BD760 */ get => default; /* [XID] */ /* 0x00000001897C4B80-0x00000001897C4BA0 */ private set {} } // 0x0000000181A06F70-0x0000000181A07010 0x0000000181A09430-0x0000000181A094E0
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x00000001897CC3F0-0x00000001897CC410 */ get => default; /* [XID] */ /* 0x00000001897D3D00-0x00000001897D3D20 */ private set {} } // 0x0000000181A08130-0x0000000181A08210 0x0000000181A08FD0-0x0000000181A090A0

	// Constructors
	public BySceneSurfaceType() {} // 0x0000000181A09B20-0x0000000181A09B90

	// Methods
	// [XID] // 0x00000001897DB6B0-0x00000001897DB6D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A09930-0x0000000181A09A80
	// [XID] // 0x00000001897E2E20-0x00000001897E2E40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181A09350-0x0000000181A09430
	// [XID] // 0x00000001897EA640-0x00000001897EA660
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF683F */) => default; // 0x0000000181A08E90-0x0000000181A08F70
	// [XID] // 0x00000001897F2370-0x00000001897F2390
	public override int GetHashNum() => default; // 0x0000000181A07930-0x0000000181A07A00
	// [XID] // 0x00000001897F9A60-0x00000001897F9A80
	public override void InitEmpty() {} // 0x0000000181A088D0-0x0000000181A089C0
	[BlackList] // 0x0000000189800FE0-0x0000000189801020
	// [XID] // 0x0000000189800FE0-0x0000000189801020
	public override bool FromJson(JSONNode node) => default; // 0x0000000181A08210-0x0000000181A08590
	// [XID] // 0x000000018980B4C0-0x000000018980B4E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181A07010-0x0000000181A073E0
	[BlackList] // 0x0000000189812B20-0x0000000189812B60
	// [XID] // 0x0000000189812B20-0x0000000189812B60
	public static new BySceneSurfaceType ParseFromJson(JSONNode node) => default; // 0x0000000181A090A0-0x0000000181A092F0
	// [XID] // 0x000000018981D6F0-0x000000018981D710
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6840 */, bool useObjectPool = false /* Metadata: 0x00AF6844 */) => default; // 0x0000000181A08B90-0x0000000181A08E90
	// [XID] // 0x0000000189824BE0-0x0000000189824C00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6845 */, bool useObjectPool = false /* Metadata: 0x00AF6849 */) => default; // 0x0000000181A07B80-0x0000000181A07F00
	// [XID] // 0x000000018982C590-0x000000018982C5B0
	public static new BySceneSurfaceType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF684A */, bool useObjectPool = false /* Metadata: 0x00AF684E */) => default; // 0x0000000181A08590-0x0000000181A087B0
	[BlackList] // 0x0000000189833B20-0x0000000189833B60
	// [XID] // 0x0000000189833B20-0x0000000189833B60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A073E0-0x0000000181A076B0
	// [XID] // 0x000000018983DE80-0x000000018983DEA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A09590-0x0000000181A09930
	[BlackList] // 0x0000000189845630-0x0000000189845670
	// [XID] // 0x0000000189845630-0x0000000189845670
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181A08AA0-0x0000000181A08B90
	// [XID] // 0x000000018984F9C0-0x000000018984F9E0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181A07F00-0x0000000181A08030
	[BlackList] // 0x0000000189856CE0-0x0000000189856D20
	// [XID] // 0x0000000189856CE0-0x0000000189856D20
	public override void AutoAllocTypeFields() {} // 0x0000000181A076B0-0x0000000181A07750
	[BlackList] // 0x0000000189861150-0x0000000189861190
	// [XID] // 0x0000000189861150-0x0000000189861190
	public override void AutoRecycleTypeFields() {} // 0x0000000181A07750-0x0000000181A07810
	[BlackList] // 0x000000018986B9A0-0x000000018986B9E0
	// [XID] // 0x000000018986B9A0-0x000000018986B9E0
	public override void ReturnToObjectPool() {} // 0x0000000181A09A80-0x0000000181A09B20
}

