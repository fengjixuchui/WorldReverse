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
public class AvatarCameraParam : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16363
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigStateCameraParam _cameraParam; // 0x68

	// Properties
	public ConfigStateCameraParam cameraParam { /* [XID] */ /* 0x0000000189B4AB90-0x0000000189B4ABB0 */ get => default; /* [XID] */ /* 0x0000000189B52220-0x0000000189B52240 */ private set {} } // 0x0000000183980080-0x0000000183980120 0x000000018397FA60-0x000000018397FB10
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BDCC80-0x0000000189BDCCA0 */ get => default; } // 0x000000018397FDC0-0x000000018397FE60 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001895E9430-0x00000001895E9450 */ get => default; } // 0x000000018397F340-0x000000018397F3E0 

	// Constructors
	public AvatarCameraParam() {} // 0x0000000183980570-0x00000001839805D0

	// Methods
	// [XID] // 0x0000000189B59BC0-0x0000000189B59BE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183980350-0x0000000183980430
	// [XID] // 0x0000000189B61310-0x0000000189B61330
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018397FEC0-0x000000018397FFA0
	// [XID] // 0x0000000189B68C80-0x0000000189B68CA0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3918 */) => default; // 0x000000018397F980-0x000000018397FA60
	// [XID] // 0x0000000189B70200-0x0000000189B70220
	public override int GetHashNum() => default; // 0x000000018397E5A0-0x000000018397E670
	// [XID] // 0x0000000189B77670-0x0000000189B77690
	public override void InitEmpty() {} // 0x000000018397F3E0-0x000000018397F4B0
	[BlackList] // 0x0000000189B7EC00-0x0000000189B7EC40
	// [XID] // 0x0000000189B7EC00-0x0000000189B7EC40
	public override bool FromJson(JSONNode node) => default; // 0x000000018397ECC0-0x000000018397F040
	// [XID] // 0x0000000189B895D0-0x0000000189B895F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018397DD30-0x000000018397DF70
	[BlackList] // 0x0000000189B90B90-0x0000000189B90BD0
	// [XID] // 0x0000000189B90B90-0x0000000189B90BD0
	public static new AvatarCameraParam ParseFromJson(JSONNode node) => default; // 0x000000018397FB70-0x000000018397FDC0
	// [XID] // 0x0000000189B9AE80-0x0000000189B9AEA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3919 */, bool useObjectPool = false /* Metadata: 0x00AF391D */) => default; // 0x000000018397F680-0x000000018397F980
	// [XID] // 0x0000000189BA26F0-0x0000000189BA2710
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF391E */, bool useObjectPool = false /* Metadata: 0x00AF3922 */) => default; // 0x000000018397E7C0-0x000000018397EA60
	// [XID] // 0x0000000189BA9B40-0x0000000189BA9B60
	public static new AvatarCameraParam ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3923 */, bool useObjectPool = false /* Metadata: 0x00AF3927 */) => default; // 0x000000018397F040-0x000000018397F260
	[BlackList] // 0x0000000189BB13F0-0x0000000189BB1430
	// [XID] // 0x0000000189BB13F0-0x0000000189BB1430
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018397DF70-0x000000018397E240
	// [XID] // 0x0000000189BBB5D0-0x0000000189BBB5F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183980120-0x0000000183980350
	[BlackList] // 0x0000000189BC33D0-0x0000000189BC3410
	// [XID] // 0x0000000189BC33D0-0x0000000189BC3410
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018397F590-0x000000018397F680
	// [XID] // 0x0000000189BCDC20-0x0000000189BCDC40
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183980430-0x00000001839804D0
	// [XID] // 0x0000000189BD5130-0x0000000189BD5150
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018397EA60-0x000000018397EBC0
	[BlackList] // 0x00000001895F0C40-0x00000001895F0C80
	// [XID] // 0x00000001895F0C40-0x00000001895F0C80
	public override void AutoAllocTypeFields() {} // 0x000000018397E240-0x000000018397E2E0
	[BlackList] // 0x00000001895FB490-0x00000001895FB4D0
	// [XID] // 0x00000001895FB490-0x00000001895FB4D0
	public override void AutoRecycleTypeFields() {} // 0x000000018397E2E0-0x000000018397E410
	[BlackList] // 0x0000000189605C50-0x0000000189605C90
	// [XID] // 0x0000000189605C50-0x0000000189605C90
	public override void ReturnToObjectPool() {} // 0x00000001839804D0-0x0000000183980570
}

