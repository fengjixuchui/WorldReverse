/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FPSIndicator // TypeDefIndex: 31544
{
	// Fields
	public float updateInterval; // 0x10
	private float _time; // 0x20
	private int _frames; // 0x24
	private float _timeleft; // 0x28
	private float _totalTime; // 0x2C
	private int _totalFrames; // 0x30

	// Properties
	public float fps { /* [XID] */ /* 0x00000001898FD260-0x00000001898FD2A0 */ get; /* [XID] */ /* 0x0000000189907C90-0x0000000189907CD0 */ private set; } // 0x0000000184FCAC30-0x0000000184FCACA0 0x0000000184FCB080-0x0000000184FCB0F0
	public float fpsMax { /* [XID] */ /* 0x00000001899124B0-0x00000001899124F0 */ get; /* [XID] */ /* 0x000000018991CE20-0x000000018991CE60 */ private set; } // 0x0000000184FCABC0-0x0000000184FCAC30 0x0000000184FCAFA0-0x0000000184FCB010
	public float fpsMin { /* [XID] */ /* 0x0000000189927430-0x0000000189927470 */ get; /* [XID] */ /* 0x0000000189931A00-0x0000000189931A40 */ private set; } // 0x0000000184FCB0F0-0x0000000184FCB160 0x0000000184FCB010-0x0000000184FCB080

	// Constructors
	public FPSIndicator() {} // 0x0000000184FCB160-0x0000000184FCB1E0

	// Methods
	// [XID] // 0x000000018993C3E0-0x000000018993C400
	public void Reset() {} // 0x0000000184FCACA0-0x0000000184FCAE10
	// [XID] // 0x0000000189943A30-0x0000000189943A50
	public void Update(float deltaTime, float unscaledDeltaTime) {} // 0x0000000184FCAE10-0x0000000184FCAFA0
}

