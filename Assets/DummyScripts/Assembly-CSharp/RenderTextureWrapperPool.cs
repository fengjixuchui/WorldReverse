/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RenderTextureWrapperPool // TypeDefIndex: 31555
{
	// Fields
	private List<RenderTextureWrapper> _usedList; // 0x10
	private List<RenderTextureWrapper> _availableList; // 0x18

	// Properties
	public List<RenderTextureWrapper> usedList { /* [XID] */ /* 0x0000000189B6DC00-0x0000000189B6DC20 */ get => default; } // 0x000000018569CC90-0x000000018569CD30 

	// Constructors
	public RenderTextureWrapperPool() {} // 0x000000018569CD30-0x000000018569CDE0

	// Methods
	// [XID] // 0x0000000189B75250-0x0000000189B75270
	public int GetUsedCount() => default; // 0x000000018569CA80-0x000000018569CB40
	// [XID] // 0x0000000189B7C6A0-0x0000000189B7C6C0
	public RenderTextureWrapper GetItem() => default; // 0x000000018569CB40-0x000000018569CC90
	// [XID] // 0x0000000189B844A0-0x0000000189B844C0
	public void ReleaseItem(RenderTextureWrapper item) {} // 0x000000018569C990-0x000000018569CA80
}

