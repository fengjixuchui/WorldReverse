/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCGearHeadController : VCSimpleHeadController // TypeDefIndex: 11874
{
	// Fields
	public const string HAS_TAR = "HeadControlHasTarget"; // Metadata: 0x00AEAD6B
	public const string TAR_ANGLE = "TargetToHeadAngle"; // Metadata: 0x00AEAD83
	private List<int> _enabledPoseIDs; // 0x260
	private LCPose _lcPos; // 0x268

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189632F10-0x0000000189632F30 */ get => default; } // 0x0000000181925530-0x00000001819255D0 

	// Constructors
	public VCGearHeadController() {} // Dummy constructor
	public VCGearHeadController(ConfigHeadControl config) {} // 0x0000000181925450-0x0000000181925530

	// Methods
	// [XID] // 0x000000018963AA50-0x000000018963AA70
	public override void PreInit() {} // 0x00000001819251B0-0x0000000181925290
	// [XID] // 0x0000000189642130-0x0000000189642150
	public override void Init() {} // 0x00000001819245E0-0x00000001819247B0
	// [XID] // 0x0000000189649920-0x0000000189649940
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181925290-0x0000000181925450
	// [XID] // 0x0000000189745670-0x0000000189745690
	public override void OnEnable() {} // 0x0000000181925110-0x00000001819251B0
	// [XID] // 0x00000001896587B0-0x00000001896587D0
	public override void OnDisable() {} // 0x0000000181925070-0x0000000181925110
	// [XID] // 0x000000018965FDC0-0x000000018965FDE0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181923C90-0x0000000181923E20
	// [XID] // 0x00000001896678A0-0x00000001896678C0
	public override void Destroy() {} // 0x0000000181923F00-0x0000000181924080
	// [XID] // 0x000000018966F0A0-0x000000018966F0C0
	private void OnThreatTargetChanged(uint oldID, uint newID) {} // 0x00000001819240E0-0x0000000181924280
	// [XID] // 0x00000001896769F0-0x0000000189676A10
	private void CheckTargetToPose() {} // 0x0000000181924DA0-0x0000000181924F90
	// [XID] // 0x000000018975BA70-0x000000018975BA90
	protected override Vector3 GetLookAtPoint(ref TargetData target) => default; // 0x0000000181924280-0x00000001819245E0
	// [XID] // 0x0000000189685A50-0x0000000189685A70
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181924870-0x0000000181924D00
}

