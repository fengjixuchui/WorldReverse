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
using Unity.IL2CPP.CompilerServices;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SpringMagicBoneManager : InLevelManager // TypeDefIndex: 21322
{
	// Fields
	private List<SpringMagicBone> _newSpringMagicBone; // 0x10
	private SpringMagicBone[] _springMagicBoneArray; // 0x18
	private SpringMagicBone.BoneParticle[] _runtimeBoneParticles; // 0x20
	private List<WindBone> _newWindBone; // 0x28
	private WindBone[] _windBoneArray; // 0x30
	private bool _dirty; // 0x38

	// Constructors
	public SpringMagicBoneManager() {} // 0x000000018330AF40-0x000000018330AFB0

	// Methods
	// [XID] // 0x0000000189810F50-0x0000000189810F70
	public override void Init() {} // 0x000000018330A9F0-0x000000018330AB20
	// [XID] // 0x0000000189818AB0-0x0000000189818AD0
	public override void Destroy() {} // 0x000000018330A950-0x000000018330A9F0
	// [XID] // 0x00000001898202F0-0x0000000189820310
	public override void LateTick() {} // 0x000000018330AB20-0x000000018330AC00
	// [IDTag] // 0x0000000189827950-0x0000000189827990
	// [XID] // 0x0000000189827950-0x0000000189827990
	public void Register(SpringMagicBone bone) {} // 0x000000018330ADA0-0x000000018330AE70
	// [IDTag] // 0x0000000189831BA0-0x0000000189831BE0
	// [XID] // 0x0000000189831BA0-0x0000000189831BE0
	public void Unregister(SpringMagicBone bone) {} // 0x000000018330ACD0-0x000000018330ADA0
	// [IDTag] // 0x000000018983C350-0x000000018983C390
	// [XID] // 0x000000018983C350-0x000000018983C390
	public void Register(WindBone bone) {} // 0x000000018330AE70-0x000000018330AF40
	// [IDTag] // 0x0000000189846930-0x0000000189846970
	// [XID] // 0x0000000189846930-0x0000000189846970
	public void Unregister(WindBone bone) {} // 0x000000018330AC00-0x000000018330ACD0
	// [Il2CppSetOption] // 0x0000000189850CE0-0x0000000189850D90
	// [Il2CppSetOption] // 0x0000000189850CE0-0x0000000189850D90
	// [XID] // 0x0000000189850CE0-0x0000000189850D90
	public void UpdateWindBones(float dt) {} // 0x000000018330A530-0x000000018330A610
	// [Il2CppSetOption] // 0x0000000189865380-0x0000000189865430
	// [Il2CppSetOption] // 0x0000000189865380-0x0000000189865430
	// [XID] // 0x0000000189865380-0x0000000189865430
	public void UpdateSpringMagicBones(float dt) {} // 0x000000018330A3D0-0x000000018330A530
	// [Il2CppSetOption] // 0x000000018987A3B0-0x000000018987A460
	// [Il2CppSetOption] // 0x000000018987A3B0-0x000000018987A460
	// [XID] // 0x000000018987A3B0-0x000000018987A460
	private void RebuildInternalState() {} // 0x000000018330A670-0x000000018330A950
}

