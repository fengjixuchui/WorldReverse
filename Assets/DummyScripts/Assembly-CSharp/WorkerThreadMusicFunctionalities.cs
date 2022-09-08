/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Audio.Music;
using MoleMole.Audio.Music.Miiha;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorkerThreadMusicFunctionalities : WorkerThreadFunctionalities<SharedMusicFunctionalities> // TypeDefIndex: 11387
{
	// Fields
	private readonly MusicInstructor _instructor; // 0x20

	// Constructors
	public WorkerThreadMusicFunctionalities() {} // Dummy constructor
	public WorkerThreadMusicFunctionalities(WorkerThreadContext context, SharedMusicFunctionalities shared) {} // 0x0000000182799530-0x00000001827995E0

	// Methods
	// [XID] // 0x00000001898A2890-0x00000001898A28B0
	public override void Init() {} // 0x00000001827990E0-0x0000000182799180
	// [XID] // 0x000000018979A5B0-0x000000018979A5D0
	public override void Destroy() {} // 0x0000000182798DC0-0x0000000182798EB0
	// [XID] // 0x00000001897C8A60-0x00000001897C8A80
	public override void Tick(TimeSpan deltaTime) {} // 0x00000001827992A0-0x00000001827993A0
	// [XID] // 0x00000001898B91C0-0x00000001898B91E0
	public void Start(SyncId syncId) {} // 0x0000000182798FB0-0x00000001827990E0
	// [XID] // 0x00000001898C0760-0x00000001898C0780
	public void Stop() {} // 0x0000000182798CD0-0x0000000182798DC0
	// [XID] // 0x00000001898C7F20-0x00000001898C7F40
	public void ChangeOccasion(MusicOccasion occasion) {} // 0x00000001827993A0-0x0000000182799530
	public void UpdateGameParamValue<TValue>(MusicGameParam gameParam, TValue value) {}
	public void AddGameParamValue<TValue>(MusicGameParam gameParam, TValue value)
		where TValue : struct {}
	public void RemoveGameParamValue<TValue>(MusicGameParam gameParam, TValue value)
		where TValue : struct {}
	// [XID] // 0x00000001898CF700-0x00000001898CF720
	public void HandleStimulus(MusicStimulus stimulus) {} // 0x0000000182798EB0-0x0000000182798FB0
	public void HandleStimulus<T>(MusicStimulus stimulus, T parameter) {}
	// [XID] // 0x000000018971D430-0x000000018971D450
	public void PostTrigger(uint hashId, SyncId syncId) {} // 0x0000000182799180-0x00000001827992A0
	private void HandleWrappedStimulus<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter) {}
}

