/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UISceneSkyboxPlugin : BaseUIScenePlugin // TypeDefIndex: 28555
{
	// Fields
	private AnimationCurve _skyBoxColorLerpCurve; // 0x18
	private AnimationCurve _skyBoxAlphaLerpCurve; // 0x20
	private AnimationCurve _skyBoxScaleLerpCurve; // 0x28
	private float _maxLerpTime; // 0x30
	private float _curLerpTime; // 0x34
	private static int _skyboxLightColorId; // 0x00
	private static int _skyboxDarkColorId; // 0x04
	private static int _skyboxHDRColorId; // 0x08
	private static int _skyboxOpacity; // 0x0C
	private static int _skyBoxZtestMode; // 0x10
	private static int _skyboxMaterial02Color01; // 0x14
	private static int _skyboxMaterial02Color02; // 0x18
	private static int _skyboxMaterial03FadeValue; // 0x1C
	private static int _skyboxMaterial03BGColor; // 0x20
	private static int _skyboxMaterial03DarkColor; // 0x24
	private static int _skyboxMaterial03LightColor; // 0x28
	private Color _curLightColor; // 0x38
	private Color _curDarkColor; // 0x48
	private Color _curThirdColor; // 0x58
	private Color _curMaterial02Color01; // 0x68
	private Color _curMaterial02Color02; // 0x78
	private Color _curMaterial03BGColor; // 0x88
	private Color _curMaterial03DarkColor; // 0x98
	private Color _curMaterial03LightColor; // 0xA8
	private Color _targetLightColor; // 0xB8
	private Color _targetDarkColor; // 0xC8
	private Color _targetThirdColor; // 0xD8
	private Color _targetMaterial02Color01; // 0xE8
	private Color _targetMaterial02Color02; // 0xF8
	private Color _targetMaterial03BGColor; // 0x108
	private Color _targetMaterial03DarkColor; // 0x118
	private Color _targetMaterial03LightColor; // 0x128
	private float _curMaterial03FadeValue; // 0x138
	private float _targetMaterial03FadeValue; // 0x13C
	private float _galaxyFadeLerpTime; // 0x140
	private bool _updateSkyboxColor3; // 0x144
	private Renderer _skyboxRenderer; // 0x148
	private MaterialPropertyBlock _mpb; // 0x150

	// Properties
	public bool updateSkyboxColor3 { /* [XID] */ /* 0x0000000189857EA0-0x0000000189857EC0 */ set {} } // 0x0000000182766A20-0x0000000182766AD0

	// Constructors
	public UISceneSkyboxPlugin() {} // 0x0000000182768EC0-0x00000001827690F0
	static UISceneSkyboxPlugin() {} // 0x0000000182768CF0-0x0000000182768EC0

	// Methods
	// [XID] // 0x000000018985EFB0-0x000000018985EFD0
	protected override void Init() {} // 0x0000000182767890-0x00000001827679D0
	// [XID] // 0x0000000189866770-0x0000000189866790
	protected override void Tick() {} // 0x00000001827679D0-0x0000000182767A80
	// [XID] // 0x000000018986E070-0x000000018986E090
	protected override void OnDisable() {} // 0x0000000182766CA0-0x0000000182766D40
	// [XID] // 0x00000001898754A0-0x00000001898754C0
	public void SetSkyboxActive(bool active) {} // 0x0000000182767AE0-0x0000000182767BC0
	// [XID] // 0x000000018987CFB0-0x000000018987CFD0
	public void SetSkyboxRenderSetting(int renderQueue, int zTestMode) {} // 0x00000001827671D0-0x0000000182767330
	// [XID] // 0x0000000189883F70-0x0000000189883F90
	public void SetDefaultSkyboxColor() {} // 0x0000000182766EC0-0x00000001827671D0
	// [IDTag] // 0x000000018988B690-0x000000018988B6D0
	// [XID] // 0x000000018988B690-0x000000018988B6D0
	public void SetSkyboxStyle(ElementStyle.Style elementStyle) {} // 0x0000000182767510-0x0000000182767740
	// [IDTag] // 0x0000000189895980-0x00000001898959C0
	// [XID] // 0x0000000189895980-0x00000001898959C0
	public void SetSkyboxStyle(EquipRarityStyle.Style style) {} // 0x0000000182767330-0x0000000182767510
	// [XID] // 0x000000018989FD10-0x000000018989FD30
	public void SetSkyBoxStyle(UISkyBoxStyle.Style skyBoxStyle) {} // 0x0000000182768B40-0x0000000182768CF0
	// [XID] // 0x00000001898A76A0-0x00000001898A76C0
	public void ResetSkyBoxOpacity() {} // 0x0000000182766B30-0x0000000182766CA0
	// [XID] // 0x00000001898AF080-0x00000001898AF0A0
	private void UpdateSkyboxColor() {} // 0x0000000182767BC0-0x00000001827682C0
	// [XID] // 0x00000001898B6530-0x00000001898B6550
	public void SetSkyboxAlphaByLerpRatio(float lerpRatio) {} // 0x0000000182768690-0x0000000182768870
	// [XID] // 0x00000001898BDDA0-0x00000001898BDDC0
	public void SetSkyboxScale(Vector3 scale) {} // 0x0000000182768540-0x0000000182768690
	// [XID] // 0x00000001898C5620-0x00000001898C5640
	public Vector3 GetSkyboxScale() => default; // 0x0000000182766D40-0x0000000182766EC0
	// [XID] // 0x00000001898CCBA0-0x00000001898CCBC0
	public void SetSkyboxScaleByLerpRatio(float lerpRatio, Vector3 startScale, Vector3 endScale) {} // 0x0000000182768870-0x0000000182768AA0
	// [XID] // 0x00000001898D45E0-0x00000001898D4600
	public void RestartLerpSkyboxColor() {} // 0x0000000182768AA0-0x0000000182768B40
	// [XID] // 0x00000001898DBE40-0x00000001898DBE60
	public void SetSkyboxGalaxyFadeValue(float fadeValue, bool isInit = false /* Metadata: 0x00B0D911 */) {} // 0x00000001827677A0-0x0000000182767890
	// [XID] // 0x00000001898E3980-0x00000001898E39A0
	private void UpdateSkyboxGalaxyFadeValue() {} // 0x00000001827682C0-0x0000000182768540
}

