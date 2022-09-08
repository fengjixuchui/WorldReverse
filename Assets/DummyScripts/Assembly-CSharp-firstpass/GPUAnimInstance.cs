/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MoleMole;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class GPUAnimInstance // TypeDefIndex: 8557
{
	// Fields
	public GPUInstState activeState; // 0x10
	public bool enabled; // 0x14
	internal uint runtimeVersion; // 0x18
	private int _animStateID; // 0x1C
	internal float _unityTimeWhenStateStarts; // 0x20
	internal float _currentClipLength; // 0x24
	public float _clipFrameOffset; // 0x28
	public RuntimeAnimAssetData sharedAnimData; // 0x30
	public RuntimeAnimAssetData sharedItemAnimData; // 0x38
	private MeshRenderer[] _instRenderers; // 0x40
	private Color _HairColor; // 0x48
	private Renderer _hairRenderer; // 0x58
	private Renderer _faceRenderer; // 0x60
	public const int MAX_REPLACE_COLOR_COUNT = 5; // Metadata: 0x00ADFB3F
	private Color[] _bodyReplaceColors; // 0x68
	public Renderer _bodyRenderer; // 0x70
	public int protoId; // 0x78
	public uint gameplayID; // 0x7C
	public GameObject go; // 0x80
	public Vector3 position; // 0x88
	public Vector3 positionAbsolute; // 0x94
	public AsyncJob prefabLoadJob; // 0xA0
	public AsyncJob assetJob; // 0xB0
	public AsyncJob itemJob; // 0xC0
	private static readonly int _TimeInstanceID; // 0x00
	private static readonly int[] _BodyReplaceColorID; // 0x08
	private static readonly int[] _BodyDefaultColorID; // 0x10

	// Properties
	public int animStateID { get => default; set {} } // 0x0000000185A37FB0-0x0000000185A38010 0x0000000185A38080-0x0000000185A38100
	public float unityTimeWhenStateStarts { get => default; } // 0x0000000185A38010-0x0000000185A38080 

	// Constructors
	public GPUAnimInstance() {} // 0x0000000185A37D70-0x0000000185A37FB0
	static GPUAnimInstance() {} // 0x0000000185A37AD0-0x0000000185A37D70

	// Methods
	public void Clear() {} // 0x0000000185A35A70-0x0000000185A35B90
	public void StopPendingJobs() {} // 0x0000000185A37450-0x0000000185A374D0
	public void SetAnimStateIndex(int idx, float startTime = 0f /* Metadata: 0x00ADFB3B */) {} // 0x0000000185A36C40-0x0000000185A36E60
	public void SetHairColor(Color color) {} // 0x0000000185A36FB0-0x0000000185A37030
	public void SetBodyReplaceColor(Color color1, Color color2, Color color3, Color color4) {} // 0x0000000185A36E60-0x0000000185A36FB0
	public bool IsVisible() => default; // 0x0000000185A36B60-0x0000000185A36C40
	public void SetVisible(bool visible) {} // 0x0000000185A37300-0x0000000185A37450
	internal bool Initialize(GameObject obj, RuntimeAnimAssetData animasset, RuntimeAnimAssetData itemAnimAsset, int prototypeID) => default; // 0x0000000185A364B0-0x0000000185A36B60
	private void InitSpecialRenderers() {} // 0x0000000185A36100-0x0000000185A364B0
	private static void InitMaterialParams(RuntimeAnimAssetData animasset, List<int> meshIndicesInAsset, List<MeshRenderer> renderers) {} // 0x0000000185A35FF0-0x0000000185A36100
	private static void GenerateMaterialData(RuntimeAnimAssetData animAssetData, List<int> meshIndices, List<MeshRenderer> renderers, out List<UnityEngine.Material> materials, out List<int> materialIndexOffset, out int[] boneOffsets) {
		materials = default;
		materialIndexOffset = default;
		boneOffsets = default;
	} // 0x0000000185A35C70-0x0000000185A35FF0
	private static void SetMaterialParams(RuntimeAnimAssetData animAssetData, List<UnityEngine.Material> materials, List<int> materialIndexOffset, int[] boneOffsets) {} // 0x0000000185A37030-0x0000000185A37300
	internal void UpdateStartTime(float time) {} // 0x0000000185A37970-0x0000000185A37AD0
	public void UpdateInstShaderProperties() {} // 0x0000000185A374D0-0x0000000185A37860
	public void CustomUpdateShaderProperties(Action<MeshRenderer> SetCustomProperty) {} // 0x0000000185A35B90-0x0000000185A35C70
	private static void UpdateOverrideBounds(MeshRenderer[] renderers, Bounds bounds) {} // 0x0000000185A37860-0x0000000185A37970
}

