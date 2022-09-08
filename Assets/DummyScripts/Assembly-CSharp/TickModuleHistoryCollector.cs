/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct TickModuleHistoryCollector // TypeDefIndex: 27924
{
	// Fields
	private int _tickCount; // 0x00
	private int _totalCounts; // 0x04
	private string _filePrefix; // 0x08
	public bool bIsCollecting; // 0x10

	// Methods
	public static string GetStatFilePrefix() => default; // 0x000000018523AFB0-0x000000018523B200
	public void StartCollect(int targetFrameCounts) {} // 0x000000018523B290-0x000000018523B320
	public void OnFrameTick() {} // 0x000000018523B200-0x000000018523B290
	private void GeneratePlatformTimestampLog() {} // 0x000000018523AFA0-0x000000018523AFB0
}

