/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
public class MonoPostProcessCustomEffectParamWrapper : BaseBehavior<FullSerializerSerializer> // TypeDefIndex: 31752
{
	// Fields
	public ParamData[] paramDatasToSync; // 0x38
	public UnityEngine.Material customMaterial; // 0x40
	private MeshRenderer meshRenderer; // 0x48
	private PostProcessLayer postProcessLayer; // 0x50
	private MaterialPropertyBlock mpb; // 0x58

	// Nested types
	public enum ParamType // TypeDefIndex: 31753
	{
		TypeFloat = 0,
		TypeColor = 1,
		TypeTextureTilingAndOffset = 2,
		TypeTransformWorldPos = 3,
		TypeTransformScreenPos = 4
	}

	[Serializable]
	public struct ParamData // TypeDefIndex: 31754
	{
		// Fields
		public string paramName; // 0x00
		public ParamType paramType; // 0x08
		public Transform paramTransValue; // 0x10
	}

	// Constructors
	public MonoPostProcessCustomEffectParamWrapper() {} // 0x0000000181D864F0-0x0000000181D86580

	// Methods
	private void OnEnable() {} // 0x0000000181D86380-0x0000000181D864F0
	private void OnDisable() {} // 0x0000000181D86220-0x0000000181D86380
	private void InitParams() {} // 0x0000000181D85860-0x0000000181D85B20
	private void LateUpdate() {} // 0x0000000181D85B20-0x0000000181D86220
}

