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
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCHumanoidCheckInShadow : VCBase // TypeDefIndex: 11880
{
	// Fields
	public float colliderRadiusScaler; // 0x108
	public int checkpointNum; // 0x10C
	public bool debugDisplay; // 0x110
	public bool debugAlwaysUpdate; // 0x111
	public Type checkType; // 0x114
	public bool usingRayCast; // 0x118
	public float IsMovingThresh; // 0x11C
	public int PrevFrameLen; // 0x120
	private static int _checkpointPopId; // 0x00
	private static int _checkpointNumPropId; // 0x04
	private static int _checkSwitcherPropId; // 0x08
	private static int _checkTypePropId; // 0x0C
	private static int _checkIsInShadowTexId; // 0x10
	private static int _avatarAmbientTexId; // 0x14
	private static int _checkPreFrameIsInShadowTexId; // 0x18
	private static int _checkCurFrameIdUsedInPrevShadowId; // 0x1C
	private static int _checkPreFrameLengthUsedInPrevShadowId; // 0x20
	private static int _mainCameraViewProjectionMatrixID; // 0x24
	private static readonly int RT_WIDTH; // 0x28
	private static readonly int RT_HEIGHT; // 0x2C
	private static readonly int PREV_WIDTH; // 0x30
	private static readonly int PREV_HEIGHT; // 0x34
	private static UnityEngine.Material _blitShadowMaterial; // 0x38
	private static Shader _blitShadowShader; // 0x40
	private static RenderTexture _isInShadowRT; // 0x48
	private static RenderTexture _prevIsInShadowRT; // 0x50
	private static readonly string COMMAND_BUFFER_NAME; // 0x58
	private static UnityEngine.Material _blitAmbientMaterial; // 0x60
	private static RenderTexture _ambientRT; // 0x68
	private static RenderTexture _prevAmbientRT; // 0x70
	private static readonly int FRAME_UPDATE_THRESH_WHEN_IN_STATIC_STATE; // 0x78
	private Light _shadowLight; // 0x128
	private Vector4[] _checkpoints; // 0x130
	private VCHumanoidMove _vcHumanoidMove; // 0x138
	private VCHumanoidModel _modelComponent; // 0x140
	private CommandBuffer _cb; // 0x148
	private bool isInit; // 0x150
	private int _curFrame; // 0x154
	private Vector3 _prevAvatarPos; // 0x158
	private bool _isUpdateAfterStaticState; // 0x164
	private bool _hasRemoveCommandBuffer; // 0x165
	private int _frameCount; // 0x168
	private int _staticFrameCount; // 0x16C
	private Camera _mainCam; // 0x170
	private Light _mainLight; // 0x178

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189986A30-0x0000000189986A50 */ get => default; } // 0x0000000183E42BF0-0x0000000183E42C90 

	// Nested types
	public enum Type // TypeDefIndex: 11881
	{
		Binary = 0,
		Area = 1,
		Fade = 2
	}

	// Constructors
	public VCHumanoidCheckInShadow() {} // 0x0000000183E42B20-0x0000000183E42BF0
	static VCHumanoidCheckInShadow() {} // 0x0000000183E42870-0x0000000183E42B20

	// Methods
	// [XID] // 0x0000000189899D10-0x0000000189899D30
	public override void Init() {} // 0x0000000183E40330-0x0000000183E40B90
	// [XID] // 0x00000001898A0EF0-0x00000001898A0F10
	public override void OnEnable() {} // 0x0000000183E421F0-0x0000000183E422B0
	// [XID] // 0x00000001899ACE50-0x00000001899ACE70
	public override void OnDisable() {} // 0x0000000183E42130-0x0000000183E421F0
	// [XID] // 0x00000001898B0050-0x00000001898B0070
	protected override void Tick(float inDeltaTime) {} // 0x0000000183E42350-0x0000000183E42870
	// [XID] // 0x00000001898B7470-0x00000001898B7490
	private void UpdateIsInShadowInfoAndData() {} // 0x0000000183E3F170-0x0000000183E3F280
	// [XID] // 0x0000000189A06860-0x0000000189A06880
	public override void Destroy() {} // 0x0000000183E3F0A0-0x0000000183E3F170
	// [XID] // 0x00000001898C6500-0x00000001898C6520
	private void UpdateIsInShadowInfo() {} // 0x0000000183E40DA0-0x0000000183E40E60
	// [XID] // 0x00000001899D22D0-0x00000001899D22F0
	private void ComputeCheckpoints() {} // 0x0000000183E3F360-0x0000000183E3F8D0
	// [XID] // 0x00000001898D55F0-0x00000001898D5610
	private void SetCheckPointUsingRayCast(ref Vector3 shadowDir, ref Vector3 leftDir, ref Vector3 rightDir) {} // 0x0000000183E40E60-0x0000000183E42130
	// [XID] // 0x00000001898DCF70-0x00000001898DCF90
	private void SetCheckpoints() {} // 0x0000000183E422B0-0x0000000183E42350
	// [XID] // 0x00000001898E4A10-0x00000001898E4A30
	private void SetSwitcher(bool isOn) {} // 0x0000000183E3ECB0-0x0000000183E3EDC0
	// [XID] // 0x000000018999DAC0-0x000000018999DAE0
	private UnityEngine.Material CreateMaterial(Shader s, UnityEngine.Material m2Create) => default; // 0x0000000183E3EDC0-0x0000000183E3F040
	// [XID] // 0x00000001898F3D20-0x00000001898F3D40
	private void SetBlitMaterialValue() {} // 0x0000000183E3F8D0-0x0000000183E40330
	// [XID] // 0x00000001898FB250-0x00000001898FB270
	private void CleanCommandBuffer() {} // 0x0000000183E40BF0-0x0000000183E40D30
}

