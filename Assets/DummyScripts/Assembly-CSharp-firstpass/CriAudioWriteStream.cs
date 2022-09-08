/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAudioWriteStream // TypeDefIndex: 7116
{
	// Fields
	private InternalDelegate internalDelegate; // 0x10

	// Properties
	public IntPtr callbackFunction { get; private set; } // 0x0000000187A2AB60-0x0000000187A2ABC0 0x0000000187A2AC20-0x0000000187A2AC80
	public IntPtr callbackPointer { get; private set; } // 0x0000000187A2ABC0-0x0000000187A2AC20 0x0000000187A2AC80-0x0000000187A2ACE0

	// Nested types
	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 7117; 0x0000000187A3A670-0x0000000187A3A850

	public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 7118; 0x0000000187A398F0-0x0000000187A39BA0

	// Constructors
	public CriAudioWriteStream() {} // Dummy constructor
	public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer) {} // 0x0000000187A2AA80-0x0000000187A2AB60
	public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x00ADE522 */) {} // 0x0000000187A2A7F0-0x0000000187A2AA80
}

