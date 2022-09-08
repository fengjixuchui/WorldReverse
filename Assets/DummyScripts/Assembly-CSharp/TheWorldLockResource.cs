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

public class TheWorldLockResource // TypeDefIndex: 21332
{
	// Fields
	private TheWorldResourceType _resourceType; // 0x10
	private TheWorldLockType _currLockType; // 0x14
	private Queue<TheWorldLockAction> _waitActionQueue; // 0x18

	// Properties
	public TheWorldResourceType resourceType { /* [XID] */ /* 0x0000000189B2AC80-0x0000000189B2ACA0 */ get => default; } // 0x00000001858A5310-0x00000001858A53B0 
	public TheWorldLockType currLockType { /* [XID] */ /* 0x0000000189B321E0-0x0000000189B32200 */ get => default; } // 0x00000001858A5270-0x00000001858A5310 

	// Nested types
	private class TheWorldLockAction // TypeDefIndex: 21333
	{
		// Fields
		public TheWorldLockType lockType; // 0x10
		public Action action; // 0x18

		// Constructors
		public TheWorldLockAction() {} // Dummy constructor
		public TheWorldLockAction(TheWorldLockType lockType, Action action) {} // 0x00000001858B5FF0-0x00000001858B6130
	}

	// Constructors
	public TheWorldLockResource() {} // Dummy constructor
	public TheWorldLockResource(TheWorldResourceType resourceType) {} // 0x00000001858A53B0-0x00000001858A5430

	// Methods
	// [XID] // 0x000000018984EDE0-0x000000018984EE00
	public void TryLockResource(TheWorldLockType lockType, Action action) {} // 0x00000001858A5120-0x00000001858A5270
	// [XID] // 0x0000000189813500-0x0000000189813520
	public void TryUnlockResource(TheWorldLockType lockType) {} // 0x00000001858A5010-0x00000001858A5120
}

