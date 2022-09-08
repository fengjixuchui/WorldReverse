/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AudioEnableDelay // TypeDefIndex: 10943
{
	// Fields
	private int _remainingFrameCount; // 0x10
	private IAudioDelayedWorker _worker; // 0x18

	// Properties
	public bool finished { /* [XID] */ /* 0x0000000189B516E0-0x0000000189B51700 */ get => default; } // 0x000000018191AF80-0x000000018191B030 

	// Constructors
	public AudioEnableDelay() {} // 0x000000018191B360-0x000000018191B3C0

	// Methods
	public static AudioEnableDelay Allocate<THost, TWorker>(AudioEnableDelayParams @params, THost host)
		where THost : IAudioUiTickable
		where TWorker : AudioDelayedWorker<THost>, new() => default;
	// [XID] // 0x0000000189B606D0-0x0000000189B606F0
	public static void Deallocate(AudioEnableDelay instance) {} // 0x000000018191AEA0-0x000000018191AF80
	// [XID] // 0x00000001898636A0-0x00000001898636C0
	public AudioEnableDelay Tick() => default; // 0x000000018191B030-0x000000018191B1A0
	// [XID] // 0x00000001897F72A0-0x00000001897F72C0
	private static int GetFrameCountFromParams(AudioEnableDelayParams @params) => default; // 0x000000018191B260-0x000000018191B360
	private static void DoWork<THost, TWorker>(THost host)
		where THost : IAudioUiTickable
		where TWorker : AudioDelayedWorker<THost>, new() {}
	// [XID] // 0x000000018983A240-0x000000018983A260
	private void SetCountdown(int frameCount) {} // 0x000000018191B1A0-0x000000018191B260
}

