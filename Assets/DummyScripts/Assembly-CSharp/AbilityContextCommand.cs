/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AbilityContextCommand // TypeDefIndex: 20572
{
	// Properties
	public virtual CommandType type { /* [XID] */ /* 0x0000000189A43D50-0x0000000189A43D70 */ get => default; } // 0x0000000182E86520-0x0000000182E865C0 

	// Nested types
	public enum CommandType // TypeDefIndex: 20573
	{
		INVALID = -1,
		EVENT = 0,
		BEING_HIT = 1,
		ABILITY_START = 2
	}

	// Constructors
	public AbilityContextCommand() {} // 0x0000000182E865C0-0x0000000182E86620

	// Methods
	// [XID] // 0x0000000189A4B240-0x0000000189A4B260
	public virtual void Destroy() {} // 0x0000000182E86480-0x0000000182E86520
}

