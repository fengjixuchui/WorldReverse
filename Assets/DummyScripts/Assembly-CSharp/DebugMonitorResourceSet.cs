/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DebugMonitorResourceSet // TypeDefIndex: 27710
{
	// Fields
	private readonly HashSet<UnityEngine.Object>[] _resourceSet; // 0x10
	private readonly HashSet<DebugMonitorResourceSet> _childSet; // 0x18
	private readonly long[] _sizeSet; // 0x20
	private readonly GameObject _gameObject; // 0x28
	private bool _isSizeDirty; // 0x30

	// Properties
	public string name { /* [XID] */ /* 0x0000000189A8A610-0x0000000189A8A630 */ get => default; } // 0x00000001842C4190-0x00000001842C42C0 

	// Nested types
	public enum ResourceType // TypeDefIndex: 27711
	{
		MeshRenderer = 0,
		Mesh = 1,
		SkinnedMeshRenderer = 2,
		Material = 3,
		Shader = 4,
		Texture = 5,
		Animator = 6,
		Animation = 7,
		Particle = 8,
		Count = 9
	}

	// Constructors
	public DebugMonitorResourceSet() {} // 0x00000001842C4370-0x00000001842C44D0
	public DebugMonitorResourceSet(GameObject obj, bool includeChild = false /* Metadata: 0x00B0CC0C */) {} // 0x00000001842C45B0-0x00000001842C4640
	public DebugMonitorResourceSet(Transform transform, bool includeChild = false /* Metadata: 0x00B0CC0D */) {} // 0x00000001842C44D0-0x00000001842C45B0

	// Methods
	// [XID] // 0x0000000189A91DF0-0x0000000189A91E10
	public bool IsEmpty() => default; // 0x00000001842C2A50-0x00000001842C2B60
	// [IDTag] // 0x0000000189A99840-0x0000000189A99880
	// [XID] // 0x0000000189A99840-0x0000000189A99880
	public long GetResourceSize(ResourceType type) => default; // 0x00000001842C2800-0x00000001842C28C0
	// [IDTag] // 0x0000000189AA3A30-0x0000000189AA3A70
	// [XID] // 0x0000000189AA3A30-0x0000000189AA3A70
	public long GetResourceSize(int index) => default; // 0x00000001842C2700-0x00000001842C2800
	// [XID] // 0x0000000189AAE180-0x0000000189AAE1A0
	public long GetTotalSize() => default; // 0x00000001842C2630-0x00000001842C2700
	// [XID] // 0x0000000189AB5A70-0x0000000189AB5A90
	public void Clear() {} // 0x00000001842C2050-0x00000001842C2140
	// [IDTag] // 0x0000000189ABD470-0x0000000189ABD4B0
	// [XID] // 0x0000000189ABD470-0x0000000189ABD4B0
	public void Add(DebugMonitorResourceSet resourceSet) {} // 0x00000001842C39D0-0x00000001842C3C70
	// [IDTag] // 0x0000000189AC7E40-0x0000000189AC7E80
	// [XID] // 0x0000000189AC7E40-0x0000000189AC7E80
	public void Add(Transform transform, bool includeChild = false /* Metadata: 0x00B0CC0E */) {} // 0x00000001842C3180-0x00000001842C3390
	// [IDTag] // 0x0000000189AD2900-0x0000000189AD2940
	// [XID] // 0x0000000189AD2900-0x0000000189AD2940
	public void Add(GameObject gameObject, bool includeChild = false /* Metadata: 0x00B0CC0F */) {} // 0x00000001842C3DC0-0x00000001842C3F80
	// [IDTag] // 0x0000000189ADD660-0x0000000189ADD6A0
	// [XID] // 0x0000000189ADD660-0x0000000189ADD6A0
	public void Add(AnimationClip animation) {} // 0x00000001842C2B60-0x00000001842C2C90
	// [IDTag] // 0x0000000189AE7C70-0x0000000189AE7CB0
	// [XID] // 0x0000000189AE7C70-0x0000000189AE7CB0
	public void Add(Animator animator) {} // 0x00000001842C36C0-0x00000001842C38A0
	// [IDTag] // 0x0000000189AF2700-0x0000000189AF2740
	// [XID] // 0x0000000189AF2700-0x0000000189AF2740
	public void Add(Texture texture) {} // 0x00000001842C2DC0-0x00000001842C2EF0
	// [IDTag] // 0x0000000189AFCB70-0x0000000189AFCBB0
	// [XID] // 0x0000000189AFCB70-0x0000000189AFCBB0
	public void Add(Shader shader) {} // 0x00000001842C38A0-0x00000001842C39D0
	// [IDTag] // 0x0000000189B07330-0x0000000189B07370
	// [XID] // 0x0000000189B07330-0x0000000189B07370
	public void Add(UnityEngine.Material material) {} // 0x00000001842C3390-0x00000001842C3560
	// [IDTag] // 0x0000000189B11C30-0x0000000189B11C70
	// [XID] // 0x0000000189B11C30-0x0000000189B11C70
	public void Add(Renderer renderer) {} // 0x00000001842C3C70-0x00000001842C3DC0
	// [IDTag] // 0x0000000189B1C260-0x0000000189B1C2A0
	// [XID] // 0x0000000189B1C260-0x0000000189B1C2A0
	public void Add(Mesh mesh) {} // 0x00000001842C2EF0-0x00000001842C3020
	// [IDTag] // 0x0000000189B268D0-0x0000000189B26910
	// [XID] // 0x0000000189B268D0-0x0000000189B26910
	public void Add(MeshRenderer meshRenderer) {} // 0x00000001842C3020-0x00000001842C3180
	// [IDTag] // 0x0000000189B30880-0x0000000189B308C0
	// [XID] // 0x0000000189B30880-0x0000000189B308C0
	public void Add(SkinnedMeshRenderer skinnedMeshRenderer) {} // 0x00000001842C3560-0x00000001842C36C0
	// [IDTag] // 0x0000000189B3B1D0-0x0000000189B3B210
	// [XID] // 0x0000000189B3B1D0-0x0000000189B3B210
	public void Add(ParticleSystem particleSystem) {} // 0x00000001842C2C90-0x00000001842C2DC0
	// [XID] // 0x0000000189B45DF0-0x0000000189B45E10
	private void SizeDirty() {} // 0x00000001842C29B0-0x00000001842C2A50
	// [XID] // 0x0000000189B4D210-0x0000000189B4D230
	private void CalculateSize() {} // 0x00000001842C1CD0-0x00000001842C1F90
	// [XID] // 0x0000000189B54A80-0x0000000189B54AA0
	private void ToStringResource(bool detail, int type, StringBuilder buffer, int indent) {} // 0x00000001842C2140-0x00000001842C2630
	// [IDTag] // 0x0000000189B5C530-0x0000000189B5C570
	// [XID] // 0x0000000189B5C530-0x0000000189B5C570
	public void ToString(bool detail, bool includeChild, StringBuilder buffer, int indent = 0 /* Metadata: 0x00B0CC10 */) {} // 0x00000001842C1890-0x00000001842C1CD0
	// [XID] // 0x0000000189B66B20-0x0000000189B66B40
	public void ToStringOverview(StringBuilder buffer) {} // 0x00000001842C4060-0x00000001842C4190
	// [XID] // 0x0000000189B6DFE0-0x0000000189B6E000
	public static void ToStringOverviewEmpty(StringBuilder buffer) {} // 0x00000001842C28C0-0x00000001842C29B0
	// [XID] // 0x0000000189B756B0-0x0000000189B756D0
	public static void ToStringEmpty(StringBuilder buffer) {} // 0x00000001842C1F90-0x00000001842C2050
	// [IDTag] // 0x0000000189B7CB00-0x0000000189B7CB40
	// [XID] // 0x0000000189B7CB00-0x0000000189B7CB40
	public string ToString(bool detail, bool includeChild) => default; // 0x00000001842C1740-0x00000001842C1890
	// [IDTag] // 0x0000000189B87720-0x0000000189B87760
	// [XID] // 0x0000000189B87720-0x0000000189B87760
	public override string ToString() => default; // 0x00000001842C42C0-0x00000001842C4370
	// [XID] // 0x0000000189B91A20-0x0000000189B91A40
	private void PrintIndent(StringBuilder buffer, int indent) {} // 0x00000001842C3F80-0x00000001842C4060
}

