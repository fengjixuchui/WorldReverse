/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StatMMAWithDeltaFrame // TypeDefIndex: 27819
{
	// Fields
	public static StatMMAWithDeltaFrame emptyStat; // 0x00
	private Func<BaseComponent, int> onGetDeltaFrame; // 0x10
	private StatMMA stat; // 0x18
	private Vector3 maxPos; // 0x20

	// Constructors
	public StatMMAWithDeltaFrame() {} // Dummy constructor
	public StatMMAWithDeltaFrame(string inName, Func<BaseComponent, int> inGetDeltaFrame) {} // 0x0000000181A02B90-0x0000000181A02C30
	static StatMMAWithDeltaFrame() {} // 0x0000000181A02B00-0x0000000181A02B90

	// Methods
	// [XID] // 0x000000018988A040-0x000000018988A060
	public void StatComponent(BaseComponent inComp, float elapsedTime) {} // 0x0000000181A02250-0x0000000181A023B0
	// [XID] // 0x00000001898914A0-0x00000001898914C0
	public static string ToCSVTitle() => default; // 0x0000000181A024A0-0x0000000181A02540
	// [IDTag] // 0x0000000189898C80-0x0000000189898CC0
	// [XID] // 0x0000000189898C80-0x0000000189898CC0
	public string ToCSVString(string forceName) => default; // 0x0000000181A02600-0x0000000181A02B00
	// [IDTag] // 0x00000001898A3090-0x00000001898A30D0
	// [XID] // 0x00000001898A3090-0x00000001898A30D0
	public string ToCSVString() => default; // 0x0000000181A02540-0x0000000181A02600
	// [XID] // 0x0000000189A13ED0-0x0000000189A13EF0
	public static string ToEmptyCSVString(string statName) => default; // 0x0000000181A023B0-0x0000000181A024A0
}

