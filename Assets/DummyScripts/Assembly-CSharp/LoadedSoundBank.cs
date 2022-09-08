/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Audio.Data.SoundBank;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LoadedSoundBank : IReusable // TypeDefIndex: 11501
{
	// Fields
	private UnloadPolicy _unloadPolicy; // 0x10
	private float _timeLeft; // 0x18
	private int _refEventCount; // 0x1C

	// Properties
	public uint bankId { /* [XID] */ /* 0x00000001899C66C0-0x00000001899C6700 */ get; /* [XID] */ /* 0x00000001899D0CA0-0x00000001899D0CE0 */ private set; } // 0x0000000181A92DE0-0x0000000181A92E40 0x0000000181A92810-0x0000000181A92870
	public bool stageDestroyed { /* [XID] */ /* 0x00000001899DB040-0x00000001899DB080 */ get; /* [XID] */ /* 0x00000001899E5CB0-0x00000001899E5CE0 */ set; } // 0x0000000181A92680-0x0000000181A926E0 0x0000000181A92CE0-0x0000000181A92D40
	public bool finished { /* [XID] */ /* 0x0000000189A4C220-0x0000000189A4C240 */ get => default; } // 0x0000000181A929D0-0x0000000181A92AB0 

	// Nested types
	public class Spawner : ISpawner<LoadedSoundBank, uint, UnloadPolicy> // TypeDefIndex: 11502
	{
		// Constructors
		public Spawner() {} // 0x0000000181A83520-0x0000000181A83580

		// Methods
		// [XID] // 0x0000000189A327F0-0x0000000189A32810
		public LoadedSoundBank Spawn(uint param1, UnloadPolicy param2) => default; // 0x0000000181A83400-0x0000000181A83520
	}

	public class Polisher : IPolisher<LoadedSoundBank, uint, UnloadPolicy> // TypeDefIndex: 11503
	{
		// Constructors
		public Polisher() {} // 0x0000000181A831A0-0x0000000181A832B0

		// Methods
		// [XID] // 0x0000000189A3A150-0x0000000189A3A170
		public void Polish(LoadedSoundBank reused, uint param1, UnloadPolicy param2) {} // 0x0000000181A83060-0x0000000181A831A0
	}

	// Constructors
	public LoadedSoundBank() {} // Dummy constructor
	private LoadedSoundBank(uint id, UnloadPolicy unloadPolicy) {} // 0x0000000181A92F60-0x0000000181A93030

	// Methods
	// [XID] // 0x00000001899F77A0-0x00000001899F77C0
	public static LoadedSoundBank New(uint bankId, UnloadPolicy unloadPolicy) => default; // 0x0000000181A92E40-0x0000000181A92F60
	// [XID] // 0x00000001899FEE80-0x00000001899FEEA0
	public void Tick(float deltaTime) {} // 0x0000000181A92AB0-0x0000000181A92B70
	// [XID] // 0x0000000189A06740-0x0000000189A06760
	public void Touch() {} // 0x0000000181A92B70-0x0000000181A92C20
	// [XID] // 0x0000000189A0DC40-0x0000000189A0DC60
	public void AddUsageCount() {} // 0x0000000181A92D40-0x0000000181A92DE0
	// [XID] // 0x0000000189B142F0-0x0000000189B14310
	public void SubtractUsageCount() {} // 0x0000000181A92930-0x0000000181A929D0
	// [XID] // 0x0000000189A1C4D0-0x0000000189A1C4F0
	public void ChangeUnloadPolicy(UnloadPolicy policy) {} // 0x0000000181A92C20-0x0000000181A92CE0
	// [XID] // 0x0000000189AF9A50-0x0000000189AF9A70
	public void BeforeRecycle() {} // 0x0000000181A926E0-0x0000000181A92810
	// [XID] // 0x000000018984D770-0x000000018984D790
	public void Recycle() {} // 0x0000000181A92870-0x0000000181A92930
}

