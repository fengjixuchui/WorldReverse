/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExWaveVoicePool : CriAtomExVoicePool // TypeDefIndex: 7107
{
	// Constructors
	public CriAtomExWaveVoicePool() {} // Dummy constructor
	public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x00ADE50E */) {} // 0x00000001877BCA80-0x00000001877BCC40

	// Methods
	private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001877BCC40-0x00000001877BCE00
}

