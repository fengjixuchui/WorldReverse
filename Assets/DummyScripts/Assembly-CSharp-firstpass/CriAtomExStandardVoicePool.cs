/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExStandardVoicePool : CriAtomExVoicePool // TypeDefIndex: 7106
{
	// Constructors
	public CriAtomExStandardVoicePool() {} // Dummy constructor
	public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x00ADE50A */) {} // 0x00000001877BAA50-0x00000001877BAC10

	// Methods
	private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001877BAC10-0x00000001877BADD0
}

