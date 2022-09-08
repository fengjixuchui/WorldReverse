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

public abstract class AStarNode // TypeDefIndex: 31370
{
	// Fields
	public List<AStarNode> neighbours; // 0x10
	public float gScore; // 0x18
	public float fScore; // 0x1C

	// Properties
	public abstract Vector3 position { get; }

	// Constructors
	protected AStarNode() {} // 0x00000001854115A0-0x0000000185411620

	// Methods
	// [XID] // 0x0000000189997E30-0x0000000189997E50
	public virtual void BuildNeighbours() {} // 0x0000000185411500-0x00000001854115A0
	// [XID] // 0x000000018999F560-0x000000018999F580
	public void ResetSearch() {} // 0x0000000185411450-0x0000000185411500
}

