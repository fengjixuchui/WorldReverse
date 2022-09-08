/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAudioReadStream // TypeDefIndex: 7112
{
	// Fields
	private InternalDelegate internalDelegate; // 0x10

	// Properties
	public IntPtr callbackFunction { get; private set; } // 0x0000000187A2A670-0x0000000187A2A6D0 0x0000000187A2A730-0x0000000187A2A790
	public IntPtr callbackPointer { get; private set; } // 0x0000000187A2A6D0-0x0000000187A2A730 0x0000000187A2A790-0x0000000187A2A7F0

	// Nested types
	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 7113; 0x0000000187A3A490-0x0000000187A3A670

	public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 7114; 0x0000000187A39640-0x0000000187A398F0

	// Constructors
	public CriAudioReadStream() {} // Dummy constructor
	public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer) {} // 0x0000000187A2A300-0x0000000187A2A3E0
	public CriAudioReadStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x00ADE51E */) {} // 0x0000000187A2A3E0-0x0000000187A2A670
}

