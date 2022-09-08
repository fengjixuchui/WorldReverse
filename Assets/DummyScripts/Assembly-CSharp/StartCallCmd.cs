/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StartCallCmd : ActorCommand // TypeDefIndex: 20620
{
	// Fields
	public Action<ILuaActor> call; // 0x18

	// Constructors
	public StartCallCmd() {} // 0x0000000181D67B40-0x0000000181D67BC0

	// Methods
	// [XID] // 0x0000000189781DE0-0x0000000189781E00
	public static StartCallCmd Get(Action<ILuaActor> call) => default; // 0x0000000181D679B0-0x0000000181D67AA0
	// [XID] // 0x00000001897891E0-0x0000000189789200
	public override void ResetObject() {} // 0x0000000181D67AA0-0x0000000181D67B40
}

