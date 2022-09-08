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

public static class BenchmarkUtility // TypeDefIndex: 27884
{
	// Fields
	public const string ResourceKey_material = "MAT"; // Metadata: 0x00B0D0BC
	public const string ResourceKey_sharedMaterial = "SMAT"; // Metadata: 0x00B0D0C3
	public const string ResourceKey_meshKey = "MESH"; // Metadata: 0x00B0D0CB
	public static Dictionary<string, delOnLoadUObjByPath> _resourceKeyLoadUObjFuncMap; // 0x00

	// Nested types
	public delegate UnityEngine.Object delOnLoadUObjByPath(string path, out uint handle); // TypeDefIndex: 27885; 0x000000018249D120-0x000000018249D3D0

	// Constructors
	static BenchmarkUtility() {} // 0x0000000182475F90-0x0000000182475FF0

	// Methods
	public static T LoadUObjectByPath<T>(string path, out uint handle)
		where T : UnityEngine.Object {
		handle = default;
		return default;
	}
	// [XID] // 0x00000001896A8AE0-0x00000001896A8B00
	public static void DisposeLoadedResource(uint handle) {} // 0x0000000182475ED0-0x0000000182475F90
	// [XID] // 0x00000001896AFC40-0x00000001896AFC60
	public static UnityEngine.Object LoadUObjectByPathType(string path, string objectType) => default; // 0x0000000182475A60-0x0000000182475ED0
}

