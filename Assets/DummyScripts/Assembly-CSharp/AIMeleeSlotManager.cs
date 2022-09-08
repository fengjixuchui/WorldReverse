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

public class AIMeleeSlotManager // TypeDefIndex: 20456
{
	// Fields
	private Dictionary<uint, MeleeSlotInfo> _avatarSlotsList; // 0x10

	// Constructors
	public AIMeleeSlotManager() {} // 0x0000000182DBBA60-0x0000000182DBBC70

	// Methods
	// [XID] // 0x00000001899B5BA0-0x00000001899B5BC0
	public void UpdateComputeThread() {} // 0x0000000182DBB380-0x0000000182DBB580
	// [XID] // 0x0000000189AD05E0-0x0000000189AD0600
	public bool RequestSlot(uint attackerID, uint avatarID, ref Vector3 slotResultPos) => default; // 0x0000000182DBB6A0-0x0000000182DBB7D0
	// [XID] // 0x0000000189BA7510-0x0000000189BA7530
	public void RemoveAvatar(BaseEntity avatar) {} // 0x0000000182DBB580-0x0000000182DBB6A0
	// [XID] // 0x0000000189B64C50-0x0000000189B64C70
	public bool ChangeAvatar(uint fromID, uint toID) => default; // 0x0000000182DBB7D0-0x0000000182DBBA60
}

