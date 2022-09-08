/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MoveVelocityForcePlugin : BaseComponentPlugin // TypeDefIndex: 12139
{
	// Fields
	private Dictionary<int, MoveVelocityForce> _forceDic; // 0x58
	public bool _ignoreAirGY; // 0x61
	private bool _isInForce; // 0x62
	private bool _hasPositionForce; // 0x63
	private bool _hasNegitiveForce; // 0x64
	private static readonly VelocityForceType[] _velocityForceValues; // 0x00

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A17F10-0x0000000189A17F30 */ get => default; } // 0x0000000182D5AAB0-0x0000000182D5AB50 
	public bool ignoreAirGY { /* [XID] */ /* 0x0000000189A1F510-0x0000000189A1F550 */ get; /* [XID] */ /* 0x0000000189A299C0-0x0000000189A29A00 */ private set; } // 0x0000000182D59EB0-0x0000000182D59F10 0x0000000182D58330-0x0000000182D58390
	public Vector3 curFinalVelocity { /* [XID] */ /* 0x0000000189A33EE0-0x0000000189A33F20 */ get; /* [XID] */ /* 0x0000000189A3E830-0x0000000189A3E870 */ private set; } // 0x0000000182D57400-0x0000000182D57470 0x0000000182D5A010-0x0000000182D5A080

	// Constructors
	public MoveVelocityForcePlugin() {} // Dummy constructor
	static MoveVelocityForcePlugin() {} // 0x0000000182D5A8A0-0x0000000182D5A9A0
	public MoveVelocityForcePlugin(VCBaseMove vcBaseMove) {} // 0x0000000182D5A9A0-0x0000000182D5AAB0

	// Methods
	// [XID] // 0x0000000189A48ED0-0x0000000189A48EF0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182D58AB0-0x0000000182D58B90
	// [XID] // 0x0000000189A50860-0x0000000189A50880
	public override void Destroy() {} // 0x0000000182D58110-0x0000000182D58330
	// [XID] // 0x0000000189A57D20-0x0000000189A57D40
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182D5A4A0-0x0000000182D5A680
	// [XID] // 0x0000000189A5F990-0x0000000189A5F9B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182D5A200-0x0000000182D5A3B0
	// [XID] // 0x0000000189A672B0-0x0000000189A672D0
	private void InitForces(VCBaseMove vcBaseMove) {} // 0x0000000182D579B0-0x0000000182D57CA0
	// [XID] // 0x0000000189A6E900-0x0000000189A6E920
	public void GetDefaultForceTypes(VCBaseMove vcBaseMove, ref List<VelocityForceType> forceTypes, bool muteAll, bool useAll, VelocityForceType[] includeForces, VelocityForceType[] excludeForces) {} // 0x0000000182D57470-0x0000000182D579B0
	// [XID] // 0x0000000189A76190-0x0000000189A761B0
	public void DoRefreshVelocityDict(List<VelocityForceType> forceTypes, VCBaseMove vcBaseMove) {} // 0x0000000182D58C40-0x0000000182D59330
	// [XID] // 0x0000000189A7DB60-0x0000000189A7DB80
	public void RecoverVelocityDict(VCBaseMove vcBaseMove) {} // 0x0000000182D57CA0-0x0000000182D57F50
	// [XID] // 0x0000000189A853D0-0x0000000189A853F0
	public void RefreshVelocityDict(VelocityForceMixin config, VCBaseMove vcBaseMove) {} // 0x0000000182D588B0-0x0000000182D58AB0
	// [IDTag] // 0x0000000189A8CE00-0x0000000189A8CE40
	// [XID] // 0x0000000189A8CE00-0x0000000189A8CE40
	public bool IsInForce() => default; // 0x0000000182D5A080-0x0000000182D5A120
	// [XID] // 0x0000000189A97390-0x0000000189A973B0
	public bool IsHasPositionForce() => default; // 0x0000000182D58B90-0x0000000182D58C40
	// [XID] // 0x0000000189A9E730-0x0000000189A9E750
	public bool IsHasNegitiveForce() => default; // 0x0000000182D59390-0x0000000182D59440
	// [XID] // 0x0000000189A92DA0-0x0000000189A92DC0
	public MoveVelocityForce GetForce(VelocityForceType forceType) => default; // 0x0000000182D5A3B0-0x0000000182D5A4A0
	// [IDTag] // 0x0000000189AAD720-0x0000000189AAD760
	// [XID] // 0x0000000189AAD720-0x0000000189AAD760
	public bool IsInForce(VelocityForceType forceType) => default; // 0x0000000182D5A120-0x0000000182D5A200
	// [XID] // 0x0000000189AB7FA0-0x0000000189AB7FC0
	private void UpdateFinalVelocity() {} // 0x0000000182D59440-0x0000000182D59B90
	// [XID] // 0x0000000189ABFA40-0x0000000189ABFA60
	public override void Tick(float inDeltaTime) {} // 0x0000000182D5A680-0x0000000182D5A8A0
	// [IDTag] // 0x0000000189AC7630-0x0000000189AC7670
	// [XID] // 0x0000000189AC7630-0x0000000189AC7670
	public void SetForce(VelocityForceType velocityForceType, Vector3 direction, float? attenuation = default) {} // 0x0000000182D58650-0x0000000182D58830
	// [IDTag] // 0x0000000189AD1E00-0x0000000189AD1E40
	// [XID] // 0x0000000189AD1E00-0x0000000189AD1E40
	public void SetForce(VelocityForceType velocityForceType, Vector3 direction, Vector3 targetPos, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool disableForceByAnimFirstFrame, bool checkAnimatorStateOnExitOnly, float? attenuation = default) {} // 0x0000000182D58390-0x0000000182D58650
	// [XID] // 0x0000000189ADCC70-0x0000000189ADCC90
	public void UnsetForce(VelocityForceType velocityForceType) {} // 0x0000000182D57F50-0x0000000182D58060
	// [XID] // 0x0000000189AE44E0-0x0000000189AE4500
	public void OnFallOnGround() {} // 0x0000000182D59F10-0x0000000182D5A010
	// [XID] // 0x0000000189AEBC90-0x0000000189AEBCB0
	public void SetIgnoreAirGY(bool setIgnoreAirGY) {} // 0x0000000182D58060-0x0000000182D58110
	// [XID] // 0x0000000189AF36E0-0x0000000189AF3700
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000182D59B90-0x0000000182D59DC0
}

