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

public sealed class VCCharacterRendering : VCBase // TypeDefIndex: 11844
{
	// Fields
	public static float s_tickInterval; // 0x00
	public static readonly int _pointLightColorID; // 0x04
	public static readonly int _overrideLightDirID; // 0x08
	public static readonly int _overrideLightDirInShadowID; // 0x0C
	// [Header] // 0x00000001898DB430-0x00000001898DB460
	public bool overrideLightDir; // 0x110
	public Vector3 overrideLightEulerAngle; // 0x114
	// [Header] // 0x00000001898E4A30-0x00000001898E4A60
	public float defaultLightDirRollAngle; // 0x120
	public float mainLocalLightDirChangeSpeed; // 0x124
	public float mainLocalLightSingularZoneXZ; // 0x128
	// [Header] // 0x00000001898EDC40-0x00000001898EDC70
	public float maxLightLumScale; // 0x12C
	// [Header] // 0x00000001898F6F10-0x00000001898F6F40
	public bool calcLocalLightByEngine; // 0x130
	// [Header] // 0x0000000189AD9AF0-0x0000000189AD9B20
	public bool drawDebugGizmos; // 0x131
	public bool debugOnlyDrawMainLocalLight; // 0x132
	private Color _finalPointLightColor; // 0x134
	private Vector4 _overrideLightDir; // 0x144
	private Vector4 _overrideLightDirInShadow; // 0x154
	private Color _lastPointLightColor; // 0x164
	private bool _isPointLightColorChanged; // 0x174
	private Vector4 _lastOverrideLightDir; // 0x178
	private bool _isOverrideLightDirChanged; // 0x188
	private static float _2PI; // 0x10
	private List<float> _distToLights; // 0x190
	private Camera.BlendedLocalLightData _BlendedLocalLightData; // 0x198

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897FA4B0-0x00000001897FA4D0 */ get => default; } // 0x0000000181ECF280-0x0000000181ECF320 
	public ConfigCharacterRendering configCharacterRendering { /* [XID] */ /* 0x000000018990EFD0-0x000000018990F010 */ get; /* [XID] */ /* 0x0000000189919960-0x00000001899199A0 */ set; } // 0x0000000181ECBF20-0x0000000181ECBF80 0x0000000181ECCF40-0x0000000181ECCFB0

	// Constructors
	public VCCharacterRendering() {} // 0x0000000181ECF100-0x0000000181ECF280
	static VCCharacterRendering() {} // 0x0000000181ECF020-0x0000000181ECF100

	// Methods
	// [XID] // 0x00000001899243F0-0x0000000189924410
	public override void Init() {} // 0x0000000181ECDA60-0x0000000181ECDC50
	// [XID] // 0x000000018992B840-0x000000018992B860
	public override void OnEnable() {} // 0x0000000181ECEF30-0x0000000181ECF020
	// [XID] // 0x0000000189933000-0x0000000189933020
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181ECE530-0x0000000181ECE920
	// [XID] // 0x000000018967E3C0-0x000000018967E3E0
	private void DrawLocalLightDebugGizmos(int localLightCount, Camera.CullResultPointLight[] localLights, Vector3 characterPosition, bool isMobile) {} // 0x0000000181ECBF80-0x0000000181ECC380
	// [XID] // 0x0000000189941950-0x0000000189941970
	private void SetShaderParamsToEntity(BaseEntity entity) {} // 0x0000000181ECC990-0x0000000181ECCB40
	// [XID] // 0x0000000189949410-0x0000000189949430
	private void SetShaderParamsToAllEnities(BaseEntity rootEntity) {} // 0x0000000181ECC380-0x0000000181ECC620
	// [XID] // 0x0000000189950CD0-0x0000000189950CF0
	private static float CalcWarmCoolTone(Color color) => default; // 0x0000000181ECBD90-0x0000000181ECBF20
	// [XID] // 0x0000000189958510-0x0000000189958530
	private static Vector4 CalcMainLocalLightDir(float rollAngle, Vector3 characterPos, Vector3 lightPosition, float lightRange, float dist, float singularZoneXZ) => default; // 0x0000000181ECD0D0-0x0000000181ECD470
	// [XID] // 0x000000018995FB70-0x000000018995FB90
	private static Vector3 CalcLightDirFromAngle(float yawAngle, float rollAngle) => default; // 0x0000000181ECAF10-0x0000000181ECB0F0
	// [XID] // 0x0000000189654070-0x0000000189654090
	private static float GetYawAngle(Vector3 dir) => default; // 0x0000000181ECDC50-0x0000000181ECDD90
	// [XID] // 0x000000018996E6E0-0x000000018996E700
	private static float RotateAngle(float fromAngle, float toAngle, float maxAngleDelta) => default; // 0x0000000181ECDE70-0x0000000181ECE080
	// [XID] // 0x00000001899D3B00-0x00000001899D3B20
	private static float CalcPointLightIlluminance(ref Camera.CullResultPointLight light, float dist) => default; // 0x0000000181ECCFB0-0x0000000181ECD0D0
	// [XID] // 0x000000018961FBF0-0x000000018961FC10
	private static float CalcSpotLightIlluminance(ref Camera.CullResultPointLight light, float dist, ref Vector3 location) => default; // 0x0000000181ECC620-0x0000000181ECC8B0
	// [IDTag] // 0x00000001899850C0-0x0000000189985100
	// [XID] // 0x00000001899850C0-0x0000000189985100
	private static float CalcLocalLightIlluminance(ref Camera.CullResultPointLight light, float dist, ref Vector3 location) => default; // 0x0000000181ECCB40-0x0000000181ECCC90
	// [XID] // 0x000000018998FC40-0x000000018998FC60
	private static Camera.BlendedLocalLightData CalcBlendedLocalLightAtLocation(Vector3 location, int localLightCount, Camera.CullResultPointLight[] localLights, bool isMobile, bool hasMainDirectionalLight, Vector3 mainDirectionalLightDir, float dirChangeSpeed, float inDeltaTime, float singularZoneXZ, float rollAngle, Vector3 lastIlluminateDir, ref Camera.LocalLightIlluminateInfo lastMaxIlluminanceLight, bool lastNeedDirTransitionInShadow, float lastYawAngleWithTransition, List<float> distToLights) => default; // 0x0000000181ECE080-0x0000000181ECE530
	// [XID] // 0x000000018963DBD0-0x000000018963DBF0
	private static Camera.LocalLightIlluminateInfo FindMaxIllumMainLoclLight(Vector3 location, int localLightCount, Camera.CullResultPointLight[] localLights, bool isMobile, List<float> distToLights) => default; // 0x0000000181ECE920-0x0000000181ECECA0
	// [XID] // 0x0000000189645160-0x0000000189645180
	private static void CalcBlendedLocalLightIlluminateDir(ref Camera.BlendedLocalLightData inoutData, Vector3 location, bool hasMainDirectionalLight, Vector3 mainDirectionalLightDir, float dirChangeSpeed, float inDeltaTime, float rollAngle, float singularZoneXZ, Vector3 lastIlluminateDir, ref Camera.LocalLightIlluminateInfo lastMaxIlluminanceLight) {} // 0x0000000181ECD470-0x0000000181ECDA60
	// [IDTag] // 0x00000001899A6A70-0x00000001899A6AB0
	// [XID] // 0x00000001899A6A70-0x00000001899A6AB0
	private static void CalcLocalLightIlluminance(ref Camera.BlendedLocalLightData inoutData, Vector3 location, int localLightCount, Camera.CullResultPointLight[] localLights, List<float> distToLights) {} // 0x0000000181ECCC90-0x0000000181ECCF40
	// [XID] // 0x0000000189636560-0x0000000189636580
	private void UpdatePointLight(float inDeltaTime) {} // 0x0000000181ECB0F0-0x0000000181ECBD30
	// [XID] // 0x00000001899976D0-0x00000001899976F0
	private static float Luminace(Color color) => default; // 0x0000000181ECDD90-0x0000000181ECDE70
	// [XID] // 0x00000001899C02D0-0x00000001899C02F0
	private Color BlendLocalLightColor(Color srcColor, Color pointLightColor) => default; // 0x0000000181ECED10-0x0000000181ECEF30
}

