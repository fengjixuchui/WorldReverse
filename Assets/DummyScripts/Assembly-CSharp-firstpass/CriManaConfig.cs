/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public class CriManaConfig // TypeDefIndex: 7210
{
	// Fields
	public int numberOfDecoders; // 0x10
	public int numberOfMaxEntries; // 0x14
	public readonly bool graphicsMultiThreaded; // 0x18
	public PCH264PlaybackConfig pcH264PlaybackConfig; // 0x20
	public VitaH264PlaybackConfig vitaH264PlaybackConfig; // 0x28
	public WebGLConfig webglConfig; // 0x30

	// Nested types
	[Serializable]
	public class PCH264PlaybackConfig // TypeDefIndex: 7211
	{
		// Fields
		public bool useH264Playback; // 0x10

		// Constructors
		public PCH264PlaybackConfig() {} // 0x0000000187A3B200-0x0000000187A3B270
	}

	[Serializable]
	public class VitaH264PlaybackConfig // TypeDefIndex: 7212
	{
		// Fields
		public bool useH264Playback; // 0x10
		public int maxWidth; // 0x14
		public int maxHeight; // 0x18
		public bool getMemoryFromTexture; // 0x1C

		// Constructors
		public VitaH264PlaybackConfig() {} // 0x0000000187A4D0C0-0x0000000187A4D140
	}

	[Serializable]
	public class WebGLConfig // TypeDefIndex: 7213
	{
		// Fields
		public string webworkerPath; // 0x10
		public int heapSize; // 0x18

		// Constructors
		public WebGLConfig() {} // 0x0000000187A4D140-0x0000000187A4D9D0
	}

	// Constructors
	public CriManaConfig() {} // 0x0000000187A385F0-0x0000000187A38760
}

