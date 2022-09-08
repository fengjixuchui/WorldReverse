/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct StatAverage // TypeDefIndex: 27874
{
	// Fields
	public double total; // 0x00
	public int framesCounted; // 0x08

	// Properties
	public double average { /* [XID] */ /* 0x0000000189B66AE0-0x0000000189B66B00 */ get => default; } // 0x0000000181C87BF0-0x0000000181C87C00 

	// Methods
	// [XID] // 0x0000000189B6DFC0-0x0000000189B6DFE0
	public double GetAverageAndClear() => default; // 0x0000000181C879A0-0x0000000181C87A50
	// [XID] // 0x0000000189B75670-0x0000000189B75690
	public void Accumulate(double value) {} // 0x0000000181C87B20-0x0000000181C87BF0
	// [XID] // 0x0000000189B7CAC0-0x0000000189B7CAE0
	public void Clear() {} // 0x0000000181C87A50-0x0000000181C87B20
}

