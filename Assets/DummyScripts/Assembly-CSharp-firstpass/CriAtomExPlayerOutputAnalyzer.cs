/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Obsolete] // 0x00000001899AFFF0-0x00000001899B0020
public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer // TypeDefIndex: 7087
{
	// Nested types
	public enum Type // TypeDefIndex: 7088
	{
		LevelMeter = 0,
		SpectrumAnalyzer = 1,
		PcmCapture = 2
	}

	public struct Config // TypeDefIndex: 7089
	{
		// Fields
		public int num_spectrum_analyzer_bands; // 0x00
		public int num_stored_output_data; // 0x04

		// Constructors
		public Config(int num_spectrum_analyzer_bands = 8 /* Metadata: 0x00ADE4BE */, int num_stored_output_data = 4096 /* Metadata: 0x00ADE4C2 */) {
			this.num_spectrum_analyzer_bands = default;
			this.num_stored_output_data = default;
		} // 0x00000001877A2F70-0x00000001877A2FE0
	}

	// Constructors
	public CriAtomExPlayerOutputAnalyzer() {} // Dummy constructor
	public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null) {} // 0x00000001877AFDE0-0x00000001877AFF90
}

