/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class SECTR_LODFinInfo // TypeDefIndex: 31954
{
	// Fields
	public string name; // 0x10
	public string lodPatternName; // 0x18
	public VirtualLODType objType; // 0x20
	public SECTR_ScenePropInfo scenePropInfo; // 0x28
	public List<SECTR_LODObjInfo> lodInfos; // 0x30
	public float lodScale; // 0x38
	public float cullScale; // 0x3C
	public ulong colliderPathHash; // 0x40
	public ulong simpleColliderPathHash; // 0x48

	// Constructors
	public SECTR_LODFinInfo() {} // 0x0000000181B58820-0x0000000181B588C0
}

