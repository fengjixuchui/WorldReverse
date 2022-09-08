/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtShieldAdded : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20161
{
	// Fields
	private ShieldType _shieldType; // 0x30

	// Nested types
	public enum ShieldType // TypeDefIndex: 20162
	{
		EliteShield = 0,
		GlobalShield = 1
	}

	// Constructors
	public EvtShieldAdded() {} // 0x00000001827B0220-0x00000001827B0280

	// Methods
	[BlackList] // 0x00000001898947B0-0x00000001898947F0
	// [XID] // 0x00000001898947B0-0x00000001898947F0
	public override void AutoAllocTypeFields() {} // 0x00000001827AFD90-0x00000001827AFE30
	[BlackList] // 0x000000018989EA00-0x000000018989EA40
	// [XID] // 0x000000018989EA00-0x000000018989EA40
	public override void AutoRecycleTypeFields() {} // 0x00000001827AFE30-0x00000001827AFEE0
	[BlackList] // 0x00000001898A93B0-0x00000001898A93F0
	// [XID] // 0x00000001898A93B0-0x00000001898A93F0
	public override void ReturnToObjectPool() {} // 0x00000001827B0180-0x00000001827B0220
	// [XID] // 0x00000001898B38A0-0x00000001898B38C0
	public void Init(uint targetID, ShieldType shieldType) {} // 0x00000001827AFFE0-0x00000001827B00C0
	// [XID] // 0x00000001898BB650-0x00000001898BB670
	public ShieldType GetShieldType() => default; // 0x00000001827AFEE0-0x00000001827AFF80
}

