/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExLatencyEstimator // TypeDefIndex: 7034
{
	// Nested types
	public enum Status // TypeDefIndex: 7035
	{
		Stop = 0,
		Processing = 1,
		Done = 2,
		Error = 3
	}

	public struct EstimatorInfo // TypeDefIndex: 7036
	{
		// Fields
		public Status status; // 0x00
		public uint estimated_latency; // 0x04
	}

	// Methods
	public static void InitializeModule() {} // 0x00000001877A7540-0x00000001877A7590
	public static void FinalizeModule() {} // 0x00000001877A7490-0x00000001877A74E0
	public static EstimatorInfo GetCurrentInfo() => default; // 0x00000001877A74E0-0x00000001877A7540
}

