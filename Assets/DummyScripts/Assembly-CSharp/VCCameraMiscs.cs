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
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCCameraMiscs : VCBase // TypeDefIndex: 11840
{
	// Fields
	private Camera _camera; // 0x108
	private uint _mainCameraMeshHandle; // 0x110
	private GameObject _mainCameraDisplacementMesh; // 0x118
	private MiHoYoVegetationInteractor _mainCameraDisplacementVegetation; // 0x120
	private SortedList<int, bool> _mainCameraDisplacementEnable; // 0x128
	private MonoUIGraphicUtils _uiGraphicUtils; // 0x130
	private MotionBlur motionBlur; // 0x138
	private MHYDepthOfField mhyDepthOfField; // 0x140
	private ToonLightBuffer toonLightBuffer; // 0x148
	private bool _needToonLightBuffer; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018971BA90-0x000000018971BAB0 */ get => default; } // 0x0000000181FC2AD0-0x0000000181FC2B70 
	public int lastFrameCullResultPointLightCount { /* [XID] */ /* 0x0000000189722E10-0x0000000189722E50 */ get; /* [XID] */ /* 0x000000018972D430-0x000000018972D470 */ private set; } // 0x0000000181FC2600-0x0000000181FC2660 0x0000000181FC15F0-0x0000000181FC1660
	public Camera.CullResultPointLight[] lastFrameCullResultPointLights { /* [XID] */ /* 0x0000000189737E50-0x0000000189737E90 */ get; /* [XID] */ /* 0x00000001897423A0-0x00000001897423E0 */ private set; } // 0x0000000181FC1A30-0x0000000181FC1A90 0x0000000181FC1A90-0x0000000181FC1B00

	// Constructors
	public VCCameraMiscs() {} // 0x0000000181FC2A40-0x0000000181FC2AD0

	// Methods
	// [XID] // 0x0000000189A85570-0x0000000189A85590
	public void ClaimToonLightBuffer() {} // 0x0000000181FC1F70-0x0000000181FC2010
	// [XID] // 0x0000000189754650-0x0000000189754670
	public override void Init() {} // 0x0000000181FC2010-0x0000000181FC2390
	// [XID] // 0x000000018975B850-0x000000018975B870
	public void SetEnableDisplacement(bool isEnable, int reason) {} // 0x0000000181FC1340-0x0000000181FC1430
	// [XID] // 0x00000001897632A0-0x00000001897632C0
	public void ResetEnableDisplacement(int reason) {} // 0x0000000181FC2660-0x0000000181FC2730
	// [XID] // 0x0000000189823C60-0x0000000189823C80
	private void RefreshEnableDisplacement() {} // 0x0000000181FC1660-0x0000000181FC1830
	// [XID] // 0x00000001897EAEC0-0x00000001897EAEE0
	protected override void Tick(float inDeltaTime) {} // 0x0000000181FC2830-0x0000000181FC2A40
	// [XID] // 0x0000000189779860-0x0000000189779880
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181FC23F0-0x0000000181FC2510
	// [XID] // 0x0000000189B1D0F0-0x0000000189B1D110
	public override void Destroy() {} // 0x0000000181FC18B0-0x0000000181FC1A30
	// [XID] // 0x0000000189772170-0x0000000189772190
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181FC1CF0-0x0000000181FC1DD0
	// [XID] // 0x0000000189779940-0x0000000189779960
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000181FC2730-0x0000000181FC2830
	// [XID] // 0x00000001897812A0-0x00000001897812C0
	private bool OnEvtUIBackBlur(EvtUIBackBlur evt) => default; // 0x0000000181FC1B80-0x0000000181FC1CF0
	// [XID] // 0x000000018979F4B0-0x000000018979F4D0
	public void EnableDoF(bool enable) {} // 0x0000000181FC1DD0-0x0000000181FC1F70
	// [XID] // 0x0000000189835B70-0x0000000189835B90
	public void EnableRadioBlur(bool enable, float amount) {} // 0x0000000181FC1490-0x0000000181FC15F0
}

