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
public class AvatarEnterFocus : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16357
{
	// Fields
	private MoleMole.Config.Vector _cameraFollowLower; // 0x68
	private MoleMole.Config.Vector _cameraFollowUpper; // 0x74
	private SimpleSafeFloat cameraFollowMaxDegreeRawNum; // 0x80
	private SimpleSafeFloat cameraFollowMinDegreeRawNum; // 0x84
	private bool _cameraFastFocusMode; // 0x88
	private bool _faceToTarget; // 0x89
	private SimpleSafeFloat faceToTargetAngleThresholdRawNum; // 0x8C
	private bool _changeMainSkillID; // 0x90
	private string _dragButtonName; // 0x98
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private FocusAssistanceGroup _assistance; // 0xA0
	private bool _canMove; // 0xA8
	private bool _showCrosshair; // 0xA9
	private SimpleSafeFloat vcam_fovRawNum; // 0xAC
	private SimpleSafeFloat focusAnchorHorAngleRawNum; // 0xB0
	private SimpleSafeFloat focusAnchorVerAngleRawNum; // 0xB4
	private bool _disableAnim; // 0xB8

	// Properties
	public MoleMole.Config.Vector cameraFollowLower { /* [XID] */ /* 0x0000000189819270-0x0000000189819290 */ get => default; /* [XID] */ /* 0x0000000189820AB0-0x0000000189820AD0 */ private set {} } // 0x0000000183628A20-0x0000000183628B00 0x0000000183627C80-0x0000000183627D50
	public MoleMole.Config.Vector cameraFollowUpper { /* [XID] */ /* 0x0000000189828000-0x0000000189828020 */ get => default; /* [XID] */ /* 0x000000018982F280-0x000000018982F2A0 */ private set {} } // 0x00000001836281B0-0x0000000183628290 0x0000000183628290-0x0000000183628360
	public float cameraFollowMaxDegree { /* [XID] */ /* 0x0000000189836B70-0x0000000189836B90 */ get => default; /* [XID] */ /* 0x000000018983DFA0-0x000000018983DFC0 */ private set {} } // 0x0000000183625240-0x0000000183625320 0x0000000183628F30-0x0000000183629010
	public float cameraFollowMinDegree { /* [XID] */ /* 0x0000000189845830-0x0000000189845850 */ get => default; /* [XID] */ /* 0x000000018984CDC0-0x000000018984CDE0 */ private set {} } // 0x0000000183626AC0-0x0000000183626BA0 0x00000001836280D0-0x00000001836281B0
	public bool cameraFastFocusMode { /* [XID] */ /* 0x0000000189853EA0-0x0000000189853EC0 */ get => default; /* [XID] */ /* 0x000000018985B930-0x000000018985B950 */ private set {} } // 0x000000018362AF40-0x000000018362AFF0 0x0000000183629AE0-0x0000000183629B90
	public bool faceToTarget { /* [XID] */ /* 0x0000000189862ED0-0x0000000189862EF0 */ get => default; /* [XID] */ /* 0x000000018986A2C0-0x000000018986A2E0 */ private set {} } // 0x000000018362AAC0-0x000000018362AB70 0x0000000183628630-0x00000001836286E0
	public float faceToTargetAngleThreshold { /* [XID] */ /* 0x00000001898716F0-0x0000000189871710 */ get => default; /* [XID] */ /* 0x0000000189878F10-0x0000000189878F30 */ private set {} } // 0x00000001836287C0-0x00000001836288A0 0x00000001836295B0-0x0000000183629690
	public bool changeMainSkillID { /* [XID] */ /* 0x0000000189880580-0x00000001898805A0 */ get => default; /* [XID] */ /* 0x0000000189887B00-0x0000000189887B20 */ private set {} } // 0x000000018362A930-0x000000018362A9E0 0x00000001836294A0-0x0000000183629550
	public string dragButtonName { /* [XID] */ /* 0x000000018988EDE0-0x000000018988EE00 */ get => default; /* [XID] */ /* 0x0000000189896340-0x0000000189896360 */ private set {} } // 0x00000001836264E0-0x0000000183626590 0x0000000183629310-0x00000001836293C0
	public FocusAssistanceGroup assistance { /* [XID] */ /* 0x000000018989D9E0-0x000000018989DA00 */ get => default; /* [XID] */ /* 0x00000001898A52E0-0x00000001898A5300 */ private set {} } // 0x0000000183628B00-0x0000000183628BB0 0x0000000183626DA0-0x0000000183626E50
	public bool canMove { /* [XID] */ /* 0x00000001898AC860-0x00000001898AC880 */ get => default; /* [XID] */ /* 0x00000001898B3D80-0x00000001898B3DA0 */ private set {} } // 0x000000018362B220-0x000000018362B2D0 0x00000001836278C0-0x0000000183627970
	public bool showCrosshair { /* [XID] */ /* 0x00000001898BBA50-0x00000001898BBA70 */ get => default; /* [XID] */ /* 0x00000001898C2E80-0x00000001898C2EA0 */ private set {} } // 0x000000018362AFF0-0x000000018362B0A0 0x0000000183627B50-0x0000000183627C00
	public float vcam_fov { /* [XID] */ /* 0x00000001898CA800-0x00000001898CA820 */ get => default; /* [XID] */ /* 0x00000001898D1F10-0x00000001898D1F30 */ private set {} } // 0x00000001836288A0-0x0000000183628980 0x000000018362A9E0-0x000000018362AAC0
	public float focusAnchorHorAngle { /* [XID] */ /* 0x00000001898D9850-0x00000001898D9870 */ get => default; /* [XID] */ /* 0x00000001898E15D0-0x00000001898E15F0 */ private set {} } // 0x0000000183629C70-0x0000000183629D50 0x000000018362AE60-0x000000018362AF40
	public float focusAnchorVerAngle { /* [XID] */ /* 0x00000001898E9020-0x00000001898E9040 */ get => default; /* [XID] */ /* 0x00000001898F0800-0x00000001898F0820 */ private set {} } // 0x000000018362B140-0x000000018362B220 0x000000018362A850-0x000000018362A930
	public bool disableAnim { /* [XID] */ /* 0x00000001898F8170-0x00000001898F8190 */ get => default; /* [XID] */ /* 0x00000001898FF750-0x00000001898FF770 */ private set {} } // 0x0000000183626C10-0x0000000183626CC0 0x0000000183628580-0x0000000183628630
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018998AF40-0x000000018998AF60 */ get => default; } // 0x00000001836298E0-0x0000000183629980 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189992850-0x0000000189992870 */ get => default; } // 0x0000000183628980-0x0000000183628A20 

	// Constructors
	public AvatarEnterFocus() {} // 0x000000018362B370-0x000000018362B4A0

	// Methods
	// [XID] // 0x0000000189906F70-0x0000000189906F90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018362AB70-0x000000018362AE60
	// [XID] // 0x000000018990E990-0x000000018990E9B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001836299E0-0x0000000183629AE0
	// [XID] // 0x0000000189915FC0-0x0000000189915FE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF38E8 */) => default; // 0x00000001836293C0-0x00000001836294A0
	// [XID] // 0x000000018991DAB0-0x000000018991DAD0
	public override int GetHashNum() => default; // 0x00000001836269F0-0x0000000183626AC0
	// [XID] // 0x00000001899251E0-0x0000000189925200
	public override void InitEmpty() {} // 0x0000000183628BB0-0x0000000183628D60
	[BlackList] // 0x000000018992C800-0x000000018992C840
	// [XID] // 0x000000018992C800-0x000000018992C840
	public override bool FromJson(JSONNode node) => default; // 0x0000000183627D50-0x00000001836280D0
	// [XID] // 0x0000000189936CB0-0x0000000189936CD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183625320-0x0000000183626210
	[BlackList] // 0x000000018993E890-0x000000018993E8D0
	// [XID] // 0x000000018993E890-0x000000018993E8D0
	public static new AvatarEnterFocus ParseFromJson(JSONNode node) => default; // 0x0000000183629690-0x00000001836298E0
	// [XID] // 0x0000000189948F00-0x0000000189948F20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38E9 */, bool useObjectPool = false /* Metadata: 0x00AF38ED */) => default; // 0x0000000183629010-0x0000000183629310
	// [XID] // 0x0000000189950690-0x00000001899506B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38EE */, bool useObjectPool = false /* Metadata: 0x00AF38F2 */) => default; // 0x0000000183626E50-0x00000001836278C0
	// [XID] // 0x0000000189957CA0-0x0000000189957CC0
	public static new AvatarEnterFocus ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38F3 */, bool useObjectPool = false /* Metadata: 0x00AF38F7 */) => default; // 0x0000000183628360-0x0000000183628580
	[BlackList] // 0x000000018995F550-0x000000018995F590
	// [XID] // 0x000000018995F550-0x000000018995F590
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183626210-0x00000001836264E0
	// [XID] // 0x0000000189969BA0-0x0000000189969BC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183629D50-0x000000018362A850
	[BlackList] // 0x0000000189971940-0x0000000189971980
	// [XID] // 0x0000000189971940-0x0000000189971980
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183628E40-0x0000000183628F30
	// [XID] // 0x000000018997BBA0-0x000000018997BBC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018362B0A0-0x000000018362B140
	// [XID] // 0x0000000189983710-0x0000000189983730
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183627970-0x0000000183627AD0
	[BlackList] // 0x000000018999A5D0-0x000000018999A610
	// [XID] // 0x000000018999A5D0-0x000000018999A610
	public override void AutoAllocTypeFields() {} // 0x0000000183626590-0x0000000183626630
	[BlackList] // 0x00000001899A4C90-0x00000001899A4CD0
	// [XID] // 0x00000001899A4C90-0x00000001899A4CD0
	public override void AutoRecycleTypeFields() {} // 0x0000000183626630-0x0000000183626860
	[BlackList] // 0x00000001899AF650-0x00000001899AF690
	// [XID] // 0x00000001899AF650-0x00000001899AF690
	public override void ReturnToObjectPool() {} // 0x000000018362B2D0-0x000000018362B370
}

