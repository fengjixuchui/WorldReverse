/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SECTR_ServerVolume : ISECTR_BaseVolume // TypeDefIndex: 31870
{
	// Fields
	private Bounds bounds; // 0x10

	// Constructors
	public SECTR_ServerVolume() {} // Dummy constructor
	public SECTR_ServerVolume(Vector3 center, float radius) {} // 0x00000001840BE700-0x00000001840BE870
	public SECTR_ServerVolume(Vector3 center, Vector3 size) {} // 0x00000001840BE870-0x00000001840BE9A0

	// Methods
	// [XID] // 0x0000000189A62BD0-0x0000000189A62BF0
	public virtual void Load() {} // 0x00000001840BE2D0-0x00000001840BE3E0
	// [XID] // 0x0000000189A6A7F0-0x0000000189A6A810
	public virtual void Unload() {} // 0x00000001840BE530-0x00000001840BE640
	// [XID] // 0x0000000189A71E40-0x0000000189A71E60
	public virtual bool InvalidInLoading() => default; // 0x00000001840BE150-0x00000001840BE1F0
	// [XID] // 0x0000000189A79AC0-0x0000000189A79AE0
	public bool ValidToUpdate(Vector3 pos) => default; // 0x00000001840BE640-0x00000001840BE700
	// [XID] // 0x0000000189A80F20-0x0000000189A80F40
	public virtual bool IsPosInVolume(Vector3 pos) => default; // 0x00000001840BE1F0-0x00000001840BE2D0
	// [XID] // 0x0000000189A88950-0x0000000189A88970
	public virtual bool FilterLod(ISECTR_LODLoader lod, SECTR_BaseVolume.LODType type) => default; // 0x00000001840BDEB0-0x00000001840BE030
	// [XID] // 0x0000000189A90190-0x0000000189A901B0
	public virtual bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x00000001840BDDC0-0x00000001840BDEB0
	// [XID] // 0x0000000189A97940-0x0000000189A97960
	public virtual bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x00000001840BE3E0-0x00000001840BE490
	// [XID] // 0x0000000189A9ED00-0x0000000189A9ED20
	public virtual bool ShouldFilterStreamPos() => default; // 0x00000001840BE490-0x00000001840BE530
	// [XID] // 0x0000000189AA6610-0x0000000189AA6630
	public virtual void ActiveVolume() {} // 0x00000001840BDC80-0x00000001840BDD20
	// [XID] // 0x0000000189AADCC0-0x0000000189AADCE0
	public virtual void DeactiveVolume() {} // 0x00000001840BDD20-0x00000001840BDDC0
	// [XID] // 0x0000000189AB55D0-0x0000000189AB55F0
	public virtual Vector3 FilterStreamPos(Vector3 pos) => default; // 0x00000001840BE030-0x00000001840BE150
}

