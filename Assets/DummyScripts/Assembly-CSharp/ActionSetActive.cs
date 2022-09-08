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

public struct ActionSetActive : IContextAction // TypeDefIndex: 29456
{
	// Fields
	public object obj; // 0x00
	public bool active; // 0x08
	public bool setParent; // 0x09

	// Constructors
	public ActionSetActive(GameObject gameObject, bool active, bool setParent = false /* Metadata: 0x00B0F80A */) {
		obj = default;
		this.active = default;
		this.setParent = default;
	} // 0x0000000182BCBC40-0x0000000182BCBD40
	public ActionSetActive(Component component, bool active, bool setParent = false /* Metadata: 0x00B0F80B */) {
		obj = default;
		this.active = default;
		this.setParent = default;
	} // 0x0000000182BCBBA0-0x0000000182BCBC40

	// Methods
	// [XID] // 0x0000000189A112B0-0x0000000189A112D0
	public void Execute() {} // 0x0000000182BCBB00-0x0000000182BCBBA0
}

