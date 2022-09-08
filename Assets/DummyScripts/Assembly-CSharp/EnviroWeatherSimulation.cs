/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x00000001897398C0-0x0000000189739920
// [RequireComponent] // 0x00000001897398C0-0x0000000189739920
public class EnviroWeatherSimulation : MonoBehaviour // TypeDefIndex: 31520
{
	// Fields
	public Shader visualizeWeatherMapShader; // 0x18
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public UnityEngine.Material visualizeWeatherMapMaterial; // 0x20
	// [Header] // 0x0000000189750220-0x0000000189750250
	public UnityEngine.Material generateWeatherMapMaterial; // 0x28
	public bool useFixedWeatherMap; // 0x30
	public Texture2D fixedWeatherMap; // 0x38
	// [Header] // 0x0000000189758D20-0x0000000189758D50
	public int weatherMapSize; // 0x40
	public EnviroConfigFloat cloudCoverageRemap; // 0x48
	// [Range] // 0x0000000189B2BB80-0x0000000189B2BBA0
	public float cloudCoverageSpeedStrength; // 0x78
	// [Header] // 0x0000000189769680-0x00000001897696B0
	public EnviroConfigFloat cloudShadowHorizontalStretch; // 0x80
	// [Range] // 0x0000000189808F90-0x0000000189808FB0
	public float cloudShadowHorizontalStretchSpeedStrength; // 0xB0
	public EnviroConfigFloat cloudShadowVerticalStretch; // 0xB8
	// [Range] // 0x0000000189808F90-0x0000000189808FB0
	public float cloudShadowVerticalStretchSpeedStrength; // 0xE8
	private RenderTexture _weatherMapRenderTexture; // 0xF0
	private int _weatherMapID; // 0xF8
	private const float CLOUD_COVERAGEMAP_ROTATE_SPEED = 20f; // Metadata: 0x00B12861
	private float _cloudCoverageCurrentSpeed; // 0xFC
	private float _cloudCoverageCurrentTimeOffset; // 0x100
	private float _cloudShadowHorizontalStretchCurrentSpeed; // 0x104
	private float _cloudShadowHorizontalStretchCurrentTimeOffset; // 0x108
	private float _cloudShadowVerticalStretchCurrentSpeed; // 0x10C
	private float _cloudShadowVerticalStretchCurrentTimeOffset; // 0x110
	private CameraEvent _renderWeatherMapEvent; // 0x114
	private Dictionary<Camera, CommandBuffer> _renderWeatherMapCameras; // 0x118

	// Constructors
	public EnviroWeatherSimulation() {} // 0x000000018341EFA0-0x000000018341F1E0

	// Methods
	private void OnEnable() {} // 0x000000018341E5B0-0x000000018341E630
	private bool CheckAssets() => default; // 0x000000018341E1F0-0x000000018341E3D0
	private void Init() {} // 0x000000018341E480-0x000000018341E550
	private void OnDisable() {} // 0x000000018341E550-0x000000018341E5B0
	private void ReleaseAssets() {} // 0x000000018341E840-0x000000018341EAD0
	private void OnWillRenderObject() {} // 0x000000018341E630-0x000000018341E840
	public void UpdateWeatherMap(float cloudSpeed, Vector2 cloudDirection, float cloudCoverage) {} // 0x000000018341EAD0-0x000000018341EFA0
	public Texture GetWeatherMap() => default; // 0x000000018341E3D0-0x000000018341E480
}

