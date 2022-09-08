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

public class SurfaceBeneathProber // TypeDefIndex: 14638
{
	// Fields
	private static readonly int[] _surfaceKeys; // 0x00
	private static readonly Dictionary<string, MoleMole.SceneSurfaceMaterial> _surfaceReverseMap; // 0x08
	private const float RADIUS = 0.5f; // Metadata: 0x00AEB9CB
	private const float DISTANCE = 9f; // Metadata: 0x00AEB9CF
	private const float SQR_THRESHOLD = 1f; // Metadata: 0x00AEB9D3
	private const float EXCLUSIVE_VALUE = 5f; // Metadata: 0x00AEB9D7
	private readonly int _layerMask; // 0x10
	private readonly IAudioRtpcSetter _rtpcSetter; // 0x18
	private readonly Dictionary<int, float> _weightMap; // 0x20
	private readonly Dictionary<int, float> _prevWeights; // 0x28
	private bool _wasSteppingOnTallGrass; // 0x30
	private float _probeLiftup; // 0x34
	private string _weatherSurfaceOverride; // 0x38
	private Vector3 _lastPosition; // 0x40
	private LevelSceneGrassPlugin _levelGrass; // 0x50
	private ConfigAudioSurfaceType _surfaceTypeConfig; // 0x58

	// Constructors
	public SurfaceBeneathProber() {} // Dummy constructor
	static SurfaceBeneathProber() {} // 0x00000001825BB4E0-0x00000001825BB780
	public SurfaceBeneathProber(IAudioRtpcSetter rtpcSetter) {} // 0x00000001825BB780-0x00000001825BB910

	// Methods
	// [XID] // 0x0000000189B24440-0x0000000189B24460
	public void SetLiftupValue(float value) {} // 0x00000001825BA630-0x00000001825BA6F0
	// [XID] // 0x0000000189B2B960-0x0000000189B2B980
	public void OnEnable() {} // 0x00000001825B9F00-0x00000001825BA030
	// [XID] // 0x0000000189B32DF0-0x0000000189B32E10
	public void SetWeatherSurfaceOverride(string value) {} // 0x00000001825BA580-0x00000001825BA630
	// [XID] // 0x0000000189B3A7E0-0x0000000189B3A800
	public void ApplyCachedValues() {} // 0x00000001825BB420-0x00000001825BB4E0
	// [XID] // 0x0000000189B42110-0x0000000189B42130
	public void Probe(Vector3 position) {} // 0x00000001825BAE30-0x00000001825BB030
	// [XID] // 0x0000000189B49B30-0x0000000189B49B50
	private void CrossProbe(Vector3 position) {} // 0x00000001825B9710-0x00000001825B9BF0
	// [IDTag] // 0x0000000189B51210-0x0000000189B51250
	// [XID] // 0x0000000189B51210-0x0000000189B51250
	private MoleMole.SceneSurfaceMaterial ProbeSurfaceBelow(Vector3 position) => default; // 0x00000001825BA480-0x00000001825BA580
	// [IDTag] // 0x0000000189B5BA80-0x0000000189B5BAC0
	// [XID] // 0x0000000189B5BA80-0x0000000189B5BAC0
	private MoleMole.SceneSurfaceMaterial ProbeSurfaceBelow(Vector3 position, out float distance) {
		distance = default;
		return default;
	} // 0x00000001825BA220-0x00000001825BA480
	// [XID] // 0x0000000189B66160-0x0000000189B66180
	private bool IsSteppingOnTallGrass(Vector3 position) => default; // 0x00000001825BB140-0x00000001825BB240
	// [XID] // 0x0000000189B6D670-0x0000000189B6D690
	private void ZeroWeightMap(Dictionary<int, float> weightMap) {} // 0x00000001825B9BF0-0x00000001825B9D30
	// [IDTag] // 0x0000000189B74CB0-0x0000000189B74CF0
	// [XID] // 0x0000000189B74CB0-0x0000000189B74CF0
	private void AddWeight(MoleMole.SceneSurfaceMaterial surface) {} // 0x00000001825BB310-0x00000001825BB420
	// [IDTag] // 0x0000000189B7F1E0-0x0000000189B7F220
	// [XID] // 0x0000000189B7F1E0-0x0000000189B7F220
	private void AddWeight(MoleMole.SceneSurfaceMaterial surface, MoleMole.SceneSurfaceMaterial fallback) {} // 0x00000001825BB240-0x00000001825BB310
	// [XID] // 0x0000000189B89BB0-0x0000000189B89BD0
	private MoleMole.SceneSurfaceMaterial OverrideByWeather(MoleMole.SceneSurfaceMaterial surface) => default; // 0x00000001825BA970-0x00000001825BAAC0
	// [XID] // 0x0000000189B91140-0x0000000189B91160
	private void FindLevelGrass() {} // 0x00000001825BB030-0x00000001825BB140
	// [XID] // 0x0000000189958590-0x00000001899585B0
	private void SetExclusiveTallGrassRtpc() {} // 0x00000001825BA6F0-0x00000001825BA7A0
	// [XID] // 0x0000000189950E70-0x0000000189950E90
	private void ClearTallGrassRtpc() {} // 0x00000001825BAAC0-0x00000001825BAB60
	// [XID] // 0x0000000189BA7170-0x0000000189BA7190
	private void SetTallGrassRtpcValue(float value) {} // 0x00000001825BA120-0x00000001825BA220
	// [XID] // 0x0000000189BAE2A0-0x0000000189BAE2C0
	private void SetBlendRtpcs() {} // 0x00000001825BAD00-0x00000001825BAE30
	// [XID] // 0x0000000189BB5BF0-0x0000000189BB5C10
	private void SetTypeRtpc(int typeKey) {} // 0x00000001825BAB60-0x00000001825BAD00
	// [XID] // 0x0000000189971F70-0x0000000189971F90
	private void SetBlendRtpcsDirectly() {} // 0x00000001825BA7A0-0x00000001825BA970
	// [XID] // 0x0000000189BC4DC0-0x0000000189BC4DE0
	private void ZeroTypeRtpc(int typeKey) {} // 0x00000001825BA030-0x00000001825BA120
	// [IDTag] // 0x0000000189BCC940-0x0000000189BCC980
	// [XID] // 0x0000000189BCC940-0x0000000189BCC980
	private void SetWaterDepthRtpcValue(MoleMole.SceneSurfaceMaterial surface, float value) {} // 0x00000001825B9D30-0x00000001825B9E00
	// [IDTag] // 0x0000000189BD6BC0-0x0000000189BD6C00
	// [XID] // 0x0000000189BD6BC0-0x0000000189BD6C00
	private void SetWaterDepthRtpcValue(float value) {} // 0x00000001825B9E00-0x00000001825B9F00
}

