/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MaterialGroup : IDisposable // TypeDefIndex: 14439
{
	// Fields
	public string groupName; // 0x10
	[NonSerialized]
	public RendererMaterials[] entries; // 0x18
	private MaterialGroup _instancedGroup; // 0x20
	private const string instancedString = " (Instanced)"; // Metadata: 0x00AEB72F

	// Nested types
	public class RendererMaterials // TypeDefIndex: 14440
	{
		// Fields
		public string renderName; // 0x10
		public static UnityEngine.Material[] EMPTY_MATERIALS; // 0x00
		public UnityEngine.Material[] materials; // 0x18
		public MaterialColorModifier[] colorModifiers; // 0x20
		[NonSerialized]
		public bool skipped; // 0x28

		// Constructors
		public RendererMaterials() {} // 0x0000000181309280-0x0000000181309340
		static RendererMaterials() {} // 0x0000000181309200-0x0000000181309280
	}

	// Constructors
	public MaterialGroup() {} // 0x00000001812EFB60-0x00000001812EFBC0
	public MaterialGroup(string groupName) {} // 0x00000001812EFAD0-0x00000001812EFB60
	public MaterialGroup(string groupName, Renderer[] renderers, BaseEntity entity) {} // 0x00000001812EF200-0x00000001812EFAD0

	// Methods
	// [XID] // 0x0000000189BB2E90-0x0000000189BB2EB0
	public void ApplyTo(Renderer[] renderers) {} // 0x00000001812EE770-0x00000001812EE980
	// [XID] // 0x0000000189AC7590-0x0000000189AC75B0
	public MaterialGroup GetInstancedMaterialGroup() => default; // 0x00000001812EEFF0-0x00000001812EF0B0
	// [XID] // 0x0000000189ACEB50-0x0000000189ACEB70
	public MaterialGroup Clone() => default; // 0x00000001812EE980-0x00000001812EEFF0
	// [XID] // 0x0000000189AD6AD0-0x0000000189AD6AF0
	public UnityEngine.Material[] GetAllMaterials() => default; // 0x00000001812EE550-0x00000001812EE770
	// [XID] // 0x0000000189ADE340-0x0000000189ADE360
	private void DestroyInstancedMaterials() {} // 0x00000001812EE240-0x00000001812EE4A0
	// [XID] // 0x0000000189AE5DC0-0x0000000189AE5DE0
	public void Dispose() {} // 0x00000001812EE4A0-0x00000001812EE550
	// [XID] // 0x0000000189AED1B0-0x0000000189AED1D0
	public void ApplyColorModifiers() {} // 0x00000001812EF0B0-0x00000001812EF200
}

