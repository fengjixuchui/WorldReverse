/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FreeStyleCmd : ActorCommand // TypeDefIndex: 20609
{
	// Fields
	public int freeStyleType; // 0x18
	public bool forceInterrupt; // 0x1C
	public float? freeStyleParam; // 0x20
	public bool resetRoute; // 0x28

	// Constructors
	public FreeStyleCmd() {} // 0x0000000182D72EC0-0x0000000182D72FE0

	// Methods
	// [XID] // 0x0000000189702E30-0x0000000189702E50
	public static FreeStyleCmd Get(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default, bool resetRoute = true /* Metadata: 0x00AFDEDA */) => default; // 0x0000000182D72CE0-0x0000000182D72E10
	// [XID] // 0x000000018970A4E0-0x000000018970A500
	public override void ResetObject() {} // 0x0000000182D72E10-0x0000000182D72EC0
}

