/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExAsrRack : CriDisposable // TypeDefIndex: 7066
{
	// Fields
	public static int defaultRackId; // 0x00
	private int _rackId; // 0x20

	// Properties
	public int rackId { get => default; } // 0x00000001877A3B70-0x00000001877A3BD0 
	public static Config defaultConfig { get => default; } // 0x00000001877A3AC0-0x00000001877A3B70 

	// Nested types
	public struct Config // TypeDefIndex: 7067
	{
		// Fields
		public float serverFrequency; // 0x00
		public int numBuses; // 0x04
		public int outputChannels; // 0x08
		public int outputSamplingRate; // 0x0C
		public CriAtomEx.SoundRendererType soundRendererType; // 0x10
		public int outputRackId; // 0x14
		public IntPtr context; // 0x18
	}

	public struct PlatformConfig // TypeDefIndex: 7068
	{
		// Fields
		public byte reserved; // 0x00
	}

	// Constructors
	public CriAtomExAsrRack() {} // Dummy constructor
	public CriAtomExAsrRack(Config config, PlatformConfig platformConfig) {} // 0x00000001877A3570-0x00000001877A36D0
	static CriAtomExAsrRack() {} // 0x00000001877A3510-0x00000001877A3570

	// Methods
	public override void Dispose() {} // 0x00000001877A3380-0x00000001877A3460
	~CriAtomExAsrRack() {} // 0x00000001877A3460-0x00000001877A3510
	private static extern int CRIWAREFB1E1E0A(in Config config, in PlatformConfig platformConfig); // 0x00000001877A3280-0x00000001877A3380
	private static extern void criAtomExAsrRack_Destroy(int rackId); // 0x00000001877A3900-0x00000001877A39E0
	private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize); // 0x00000001877A37E0-0x00000001877A3900
	private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId); // 0x00000001877A39E0-0x00000001877A3AC0
	private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs); // 0x00000001877A36D0-0x00000001877A37E0
}

