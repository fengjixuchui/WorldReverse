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

public class PlayerOpenStateData // TypeDefIndex: 19478
{
	// Fields
	private Dictionary<uint, bool> _playerOpenStateDic; // 0x10
	public bool useOpenState; // 0x18
	public bool initialized; // 0x19

	// Properties
	public Dictionary<uint, bool> OpenStateDic { /* [XID] */ /* 0x00000001897A8E00-0x00000001897A8E20 */ get => default; } // 0x00000001830A93D0-0x00000001830A9470 

	// Constructors
	public PlayerOpenStateData() {} // 0x00000001830A9C70-0x00000001830A9CE0

	// Methods
	// [XID] // 0x00000001897B06A0-0x00000001897B06C0
	public void InitFromConfig() {} // 0x00000001830A9730-0x00000001830A9A70
	// [XID] // 0x00000001897B8460-0x00000001897B8480
	public void UpdateOpenState(uint id, bool state) {} // 0x00000001830A9520-0x00000001830A9730
	// [XID] // 0x00000001897C0520-0x00000001897C0540
	public bool GetOpenState(OpenStateType id) => default; // 0x00000001830A9A70-0x00000001830A9C70
	// [XID] // 0x00000001897C7DB0-0x00000001897C7DD0
	public void Clear() {} // 0x00000001830A9470-0x00000001830A9520
}

