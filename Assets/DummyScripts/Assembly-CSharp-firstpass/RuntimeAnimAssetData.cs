/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class RuntimeAnimAssetData // TypeDefIndex: 8553
{
	// Fields
	public int width; // 0x10
	public int height; // 0x14
	public int fps; // 0x18
	public uint refCount; // 0x1C
	public ulong assetPathHash; // 0x20
	public int assetId; // 0x28
	public string[] subSkinMeshNames; // 0x30
	public int[] subSkinMeshBonecount; // 0x38
	public float[] clipLengths; // 0x40
	public int[] clipStartFrame; // 0x48
	public Bounds[] animBounds; // 0x50
	public Texture2D generatedTexture1; // 0x58
	public Texture2D generatedTexture2; // 0x60

	// Constructors
	public RuntimeAnimAssetData() {} // 0x00000001868E1D00-0x00000001868E1D70

	// Methods
	public int FindSkinnedMeshName(string name) => default; // 0x00000001868E1820-0x00000001868E1920
	public bool GenerateTextureFromRawData(Color[] dataq, Color[] datat) => default; // 0x00000001868E1920-0x00000001868E1C10
	public void AddRef() {} // 0x00000001868E16D0-0x00000001868E1730
	public void DecRef() {} // 0x00000001868E1730-0x00000001868E1820
	public void ReleaseData(bool bRemove = true /* Metadata: 0x00ADFB2E */) {} // 0x00000001868E1C10-0x00000001868E1D00
}

