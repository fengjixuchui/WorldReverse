/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[CreateAssetMenu] // 0x0000000189712E90-0x0000000189712ED0
public class SECTR_StreamingProfile : ScriptableObject // TypeDefIndex: 31909
{
	// Fields
	public string qualityName; // 0x18
	private int _qualityNameHash; // 0x20
	public bool deleteHlodImediately; // 0x24
	public bool deleteGroupImediately; // 0x25
	public float maxAllIntervalTime; // 0x28
	public float layerLoadRatio; // 0x2C
	public float layerActiveRatio; // 0x30
	public float lodRatio; // 0x34
	public float HlodRatio; // 0x38
	public float layerHlodRatio; // 0x3C
	public float sectorHlodRatio; // 0x40
	public float colliderLoadRadius; // 0x44
	public float hideHlodDelayTime; // 0x48
	public int oneFrameLimitCount; // 0x4C
	public float loadMaxDistance; // 0x50
	public bool disableNonflammableGrass; // 0x54
	public SECTR_PlatformType platformType; // 0x58
	public List<SECTR_LayerLoadConfig> layerConfigs; // 0x60
	private Dictionary<string, bool> _canLayerBeLoad; // 0x68

	// Properties
	public int qualityNameHash { get => default; } // 0x0000000181B5ABA0-0x0000000181B5AC00 

	// Constructors
	public SECTR_StreamingProfile() {} // 0x0000000181B5AA90-0x0000000181B5ABA0

	// Methods
	public float GetLayerLoadRatio() => default; // 0x0000000181B5A660-0x0000000181B5A710
	public float GetLayerActiveRatio() => default; // 0x0000000181B5A500-0x0000000181B5A5B0
	public float GetLodRatio() => default; // 0x0000000181B5A710-0x0000000181B5A7C0
	public float GetHLodRatio() => default; // 0x0000000181B5A450-0x0000000181B5A500
	public float GetLayerHlodRatio() => default; // 0x0000000181B5A5B0-0x0000000181B5A660
	public float GetSectorHlodRatio() => default; // 0x0000000181B5A7C0-0x0000000181B5A870
	public void Init() {} // 0x0000000181B5A870-0x0000000181B5A910
	public void Clear() {} // 0x0000000181B5A3D0-0x0000000181B5A450
	public void AddLayerConfig() {} // 0x0000000181B5A1F0-0x0000000181B5A2D0
	public bool CanLayerBeLoad(string name) => default; // 0x0000000181B5A2D0-0x0000000181B5A3D0
	public void RefreshConfigs() {} // 0x0000000181B5A910-0x0000000181B5AA90
}

