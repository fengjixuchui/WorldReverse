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

public class ControlData // TypeDefIndex: 32132
{
	// Fields
	public bool rawIsMoving; // 0x10
	public bool hasMovedBySelectTarget; // 0x11
	public float rawJoystickAngle; // 0x14
	public Vector3 rawTargetDir; // 0x18
	public Vector3 rawTargetPosition; // 0x24
	public float rawInputMold; // 0x30
	public bool skillButtonsAvaliable; // 0x34
	public Dictionary<uint, bool> isSkillButtonHold; // 0x38
	public bool isMuteControl; // 0x40
	public bool isInWalkSpeed; // 0x41

	// Properties
	public bool jumpThisFrame { /* [XID] */ /* 0x0000000189916E70-0x0000000189916EB0 */ get; /* [XID] */ /* 0x00000001899215C0-0x0000000189921600 */ set; } // 0x000000018391A920-0x000000018391A980 0x000000018391AAC0-0x000000018391AB20

	// Constructors
	public ControlData() {} // 0x000000018391AB20-0x000000018391ABB0

	// Methods
	// [XID] // 0x000000018992BCB0-0x000000018992BCD0
	public void Reset() {} // 0x000000018391A980-0x000000018391AAC0
}

