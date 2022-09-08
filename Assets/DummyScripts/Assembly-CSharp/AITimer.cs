/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AITimer // TypeDefIndex: 20521
{
	// Fields
	private float startTick; // 0x10
	private bool started; // 0x14

	// Constructors
	public AITimer() {} // 0x0000000182B54E20-0x0000000182B54E80

	// Methods
	// [XID] // 0x0000000189B22F90-0x0000000189B22FB0
	public void CopyFrom(AITimer other) {} // 0x0000000182B54A80-0x0000000182B54B50
	// [XID] // 0x0000000189636EE0-0x0000000189636F00
	public void Reset(float currentTime) {} // 0x0000000182B54B50-0x0000000182B54C00
	// [XID] // 0x000000018963E440-0x000000018963E460
	public void Start(float currentTime) {} // 0x0000000182B54C00-0x0000000182B54CB0
	// [XID] // 0x0000000189645C40-0x0000000189645C60
	public bool IsRunning() => default; // 0x0000000182B54CB0-0x0000000182B54D50
	// [XID] // 0x000000018964D4E0-0x000000018964D500
	public bool IsElapsed(float currentTime, float limit) => default; // 0x0000000182B54D50-0x0000000182B54E20
}

