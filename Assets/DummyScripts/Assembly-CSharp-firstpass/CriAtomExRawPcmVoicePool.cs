/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool // TypeDefIndex: 7108
{
	// Nested types
	public enum RawPcmFormat // TypeDefIndex: 7109
	{
		Sint16 = 0,
		Float32 = 1
	}

	protected struct RawPcmPlayerConfig // TypeDefIndex: 7110
	{
		// Fields
		public RawPcmFormat format; // 0x00
		public int maxChannels; // 0x04
		public int maxSamplingRate; // 0x08
		public int soundRendererType; // 0x0C
		public int decodeLatency; // 0x10
	}

	protected struct RawPcmVoicePoolConfig // TypeDefIndex: 7111
	{
		// Fields
		public uint identifier; // 0x00
		public int numVoices; // 0x04
		public RawPcmPlayerConfig playerConfig; // 0x08
	}

	// Constructors
	public CriAtomExRawPcmVoicePool() {} // Dummy constructor
	public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0 /* Metadata: 0x00ADE512 */) {} // 0x00000001877B9CA0-0x00000001877B9E70

	// Methods
	private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size); // 0x00000001877B9E70-0x00000001877B9F80
}

