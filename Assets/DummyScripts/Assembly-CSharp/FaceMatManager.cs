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

public sealed class FaceMatManager : InLevelManager // TypeDefIndex: 19803
{
	// Fields
	public FaceMatInfo EmptyMatInfo; // 0x10
	private Dictionary<string, Texture2D> _faceMatMap; // 0x28
	private Dictionary<string, AtlasMapItem> _staticAtlasMap; // 0x30
	private List<uint> _texturesToUnload; // 0x38

	// Constructors
	public FaceMatManager() {} // 0x0000000181A26F20-0x0000000181A27020

	// Methods
	// [XID] // 0x00000001896684E0-0x0000000189668500
	public override void Init() {} // 0x0000000181A26BF0-0x0000000181A26C90
	// [XID] // 0x000000018966FF90-0x000000018966FFB0
	public void FetchMatInfoProvider(string path, Action<AtlasMatInfoProvider> callback) {} // 0x0000000181A26C90-0x0000000181A26F20
	// [XID] // 0x00000001896778A0-0x00000001896778C0
	public void ClearAllMatInfoProvider() {} // 0x0000000181A26460-0x0000000181A266A0
	// [XID] // 0x000000018967EDA0-0x000000018967EDC0
	public FaceMatInfo GetFaceMatInfo(string textureName, Vector4 rect) => default; // 0x0000000181A26810-0x0000000181A26AE0
	// [XID] // 0x00000001896866D0-0x00000001896866F0
	private void CalcTileAndOffset(Vector4 rect, out Vector2 tile, out Vector2 offset) {
		tile = default;
		offset = default;
	} // 0x0000000181A26AE0-0x0000000181A26BF0
	// [XID] // 0x000000018968E4B0-0x000000018968E4D0
	public override void Destroy() {} // 0x0000000181A266A0-0x0000000181A26810
}

