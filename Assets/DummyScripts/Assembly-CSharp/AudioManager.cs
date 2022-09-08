/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioManager : GlobalManager // TypeDefIndex: 20652
{
	// Fields
	private const long MILLISECONDS_PER_SECOND = 1000; // Metadata: 0x00AFDF6A
	private const float REPORT_TICK_TIME_LIMIT_MS = 1f; // Metadata: 0x00AFDF72
	private readonly AudioSrcWatcherSubmodule _srcWatcher; // 0x10
	private readonly AmbienceSubmodule _ambience; // 0x18
	private readonly ControlSubmodule _control; // 0x20
	private readonly DevSubmodule _dev; // 0x28
	private readonly EngineSubmodule _engine; // 0x30
	private readonly EventSubmodule _events; // 0x38
	private readonly ListenerSubmodule _listeners; // 0x40
	private readonly MusicSubmodule _music; // 0x48
	private readonly QuestSubmodule _quest; // 0x50
	private readonly SoundBankSubmodule _soundBanks; // 0x58
	private readonly SyncSubmodule _syncs; // 0x60
	private readonly UISubmodule _ui; // 0x68
	private readonly VoiceSubmodule _voices; // 0x70
	private readonly SpatialSubmodule _spatial; // 0x78
	private readonly CommandThreadContext _commandContext; // 0x80
	private readonly WorkerThreadContext _workerContext; // 0x88
	private readonly SharedContext _sharedContext; // 0x90
	private readonly Stopwatch _stopwatch; // 0x98
	private readonly long _reportTickTimeLimit; // 0xA0
	private bool _exDrivenAudioClearFlag; // 0xA8
	private AudioManagerTask _audioMgrTask; // 0xB0

	// Properties
	public AudioSrcWatcherSubmodule srcWatcher { /* [XID] */ /* 0x0000000189903AF0-0x0000000189903B10 */ get => default; } // 0x000000018171B350-0x000000018171B3F0 
	public CommandThreadAmbienceFunctionalities ambience { /* [XID] */ /* 0x000000018990AFF0-0x000000018990B030 */ get; private set; } // 0x000000018171E370-0x000000018171E3D0 0x000000018171DCF0-0x000000018171DD60
	public CommandThreadControlFunctionalities control { /* [XID] */ /* 0x000000018991D3F0-0x000000018991D430 */ get; private set; } // 0x000000018171B230-0x000000018171B290 0x000000018171E3D0-0x000000018171E440
	public CommandThreadDevFunctionalities dev { /* [XID] */ /* 0x000000018992F2A0-0x000000018992F2E0 */ get; private set; } // 0x000000018171B290-0x000000018171B2F0 0x000000018171E0B0-0x000000018171E120
	public CommandThreadEventFunctionalities events { /* [XID] */ /* 0x0000000189940CC0-0x0000000189940D00 */ get; private set; } // 0x000000018171C930-0x000000018171C990 0x000000018171BBB0-0x000000018171BC20
	public CommandThreadEngineFunctionalities engine { /* [XID] */ /* 0x0000000189952F90-0x0000000189952FD0 */ get; private set; } // 0x000000018171B2F0-0x000000018171B350 0x000000018171DAE0-0x000000018171DB50
	public CommandThreadListenerFunctionalities listeners { /* [XID] */ /* 0x0000000189964E50-0x0000000189964E90 */ get; private set; } // 0x000000018171D010-0x000000018171D070 0x000000018171DDD0-0x000000018171DE40
	public CommandThreadMusicFunctionalities music { /* [XID] */ /* 0x0000000189976D10-0x0000000189976D50 */ get; private set; } // 0x000000018171CE80-0x000000018171CEE0 0x000000018171DD60-0x000000018171DDD0
	public CommandThreadQuestFunctionalities quest { /* [XID] */ /* 0x00000001899890D0-0x0000000189989110 */ get; private set; } // 0x000000018171D290-0x000000018171D2F0 0x000000018171BC20-0x000000018171BC90
	public CommandThreadSoundBankFunctionalities soundBanks { /* [XID] */ /* 0x000000018999B520-0x000000018999B560 */ get; private set; } // 0x000000018171DF10-0x000000018171DF70 0x000000018171DEA0-0x000000018171DF10
	public CommandThreadSyncFunctionalities syncs { /* [XID] */ /* 0x00000001899AD6E0-0x00000001899AD720 */ get; private set; } // 0x000000018171D070-0x000000018171D0D0 0x000000018171CE10-0x000000018171CE80
	public CommandThreadUiFunctionalities ui { /* [XID] */ /* 0x00000001899BF730-0x00000001899BF770 */ get; private set; } // 0x000000018171CAD0-0x000000018171CB30 0x000000018171CFA0-0x000000018171D010
	public CommandThreadVoiceFunctionalities voices { /* [XID] */ /* 0x00000001899D1600-0x00000001899D1640 */ get; private set; } // 0x000000018171CF40-0x000000018171CFA0 0x000000018171B3F0-0x000000018171B460
	public CommandThreadSpatialFunctionalities spatial { /* [XID] */ /* 0x00000001899E3310-0x00000001899E3350 */ get; set; } // 0x000000018171DA80-0x000000018171DAE0 0x000000018171E300-0x000000018171E370

	// Constructors
	private AudioManager() {} // 0x000000018171F190-0x000000018171FFC0

	// Methods
	// [XID] // 0x00000001899F5410-0x00000001899F5430
	public override void Init() {} // 0x000000018171D790-0x000000018171DA80
	// [XID] // 0x00000001899FCA70-0x00000001899FCA90
	public override void InitByLocalData() {} // 0x000000018171D6A0-0x000000018171D790
	// [XID] // 0x0000000189A03F60-0x0000000189A03F80
	public override void Tick() {} // 0x000000018171E6B0-0x000000018171F190
	// [XID] // 0x0000000189A0B610-0x0000000189A0B630
	public override void LateTick() {} // 0x000000018171DF70-0x000000018171E0B0
	// [XID] // 0x0000000189A12DB0-0x0000000189A12DD0
	public override void ClearOnLevelDestroy() {} // 0x000000018171B500-0x000000018171B700
	// [XID] // 0x0000000189A1A130-0x0000000189A1A150
	public override void ClearOnDisconnect() {} // 0x000000018171B460-0x000000018171B500
	// [XID] // 0x0000000189A21690-0x0000000189A216B0
	public override void ReloadRes() {} // 0x000000018171E610-0x000000018171E6B0
	[Preserve] // 0x0000000189A28C70-0x0000000189A28CB0
	// [XID] // 0x0000000189A28C70-0x0000000189A28CB0
	public override string Dump(string tag) => default; // 0x000000018171BED0-0x000000018171C930
	// [XID] // 0x0000000189A33170-0x0000000189A33190
	public override void Destroy() {} // 0x000000018171BC90-0x000000018171BED0
	// [XID] // 0x0000000189A3AA80-0x0000000189A3AAA0
	public void OnApplicationPause(bool isPause) {} // 0x000000018171CB30-0x000000018171CC80
	// [XID] // 0x0000000189A42390-0x0000000189A423B0
	public void LoadFullResource() {} // 0x000000018171D0D0-0x000000018171D210
	// [XID] // 0x0000000189A499C0-0x0000000189A499E0
	public void EnterHomeWorld(bool firstTime) {} // 0x000000018171D4E0-0x000000018171D6A0
	// [XID] // 0x0000000189A51310-0x0000000189A51330
	public void OnLoginOpenDoor() {} // 0x000000018171DB50-0x000000018171DC50
	// [XID] // 0x000000018963DBB0-0x000000018963DBD0
	public void OnLevelCreate() {} // 0x000000018171B150-0x000000018171B230
	// [XID] // 0x000000018964CC60-0x000000018964CC80
	public void OnLevelEnter() {} // 0x000000018171C990-0x000000018171CAD0
	// [XID] // 0x0000000189A67FD0-0x0000000189A67FF0
	public void StopAll() {} // 0x000000018171CC80-0x000000018171CE10
	// [XID] // 0x0000000189A6F3A0-0x0000000189A6F3C0
	private bool CurrentLevelIsHome() => default; // 0x000000018171D3A0-0x000000018171D4E0
	// [XID] // 0x0000000189A76C00-0x0000000189A76C20
	private void TickDigestReports() {} // 0x000000018171B700-0x000000018171B8D0
	private void RemoveRangeFromList<T>(List<T> list, int start, int count) {}
	// [XID] // 0x0000000189A7E5C0-0x0000000189A7E5E0
	public void WorkerThreadInitExternal() {} // 0x000000018171DC50-0x000000018171DCF0
	// [XID] // 0x0000000189A85E70-0x0000000189A85E90
	public void WorkerThreadTickExternal(TimeSpan deltaTime) {} // 0x000000018171D2F0-0x000000018171D3A0
	// [XID] // 0x0000000189A8D750-0x0000000189A8D770
	public void WorkerThreadDestroyExternal() {} // 0x000000018171BB10-0x000000018171BBB0
	// [XID] // 0x0000000189A94D10-0x0000000189A94D30
	private void WorkerThreadInit() {} // 0x000000018171B930-0x000000018171BB10
	// [XID] // 0x0000000189A9C570-0x0000000189A9C590
	private void WorkerThreadTick(TimeSpan deltaTime) {} // 0x000000018171AE70-0x000000018171B150
	// [XID] // 0x0000000189AA3CE0-0x0000000189AA3D00
	private void WorkerThreadDestroy() {} // 0x000000018171E120-0x000000018171E300
	// [XID] // 0x0000000189AAB270-0x0000000189AAB290
	private void WorkerThreadTickExecuteCmds() {} // 0x000000018171E440-0x000000018171E5B0
}

