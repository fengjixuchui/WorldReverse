/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioBattleInfoCollectorPlugin : AudioComponentPlugin, IIntentionSubmitter // TypeDefIndex: 12006
{
	// Fields
	private const int TICK_INTERVAL = 15; // Metadata: 0x00AEB364
	private int _tickIntervalCounter; // 0x60
	private float _lastTeamHpValue; // 0x64
	private ulong _teammateLowHpVoLastTriggerTime; // 0x68

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189973370-0x0000000189973390 */ get => default; } // 0x0000000181A0D760-0x0000000181A0D800 

	// Constructors
	public AudioBattleInfoCollectorPlugin() {} // Dummy constructor
	public AudioBattleInfoCollectorPlugin(VCBaseAudio component) {} // 0x0000000181A0D6E0-0x0000000181A0D760

	// Methods
	// [XID] // 0x000000018997AC60-0x000000018997AC80
	public override void Tick(float deltaTime) {} // 0x0000000181A0D610-0x0000000181A0D6E0
	// [XID] // 0x00000001899825D0-0x00000001899825F0
	private void TickPlayerTeamHpRTPC() {} // 0x0000000181A0CA80-0x0000000181A0CFD0
	// [XID] // 0x0000000189989D30-0x0000000189989D50
	private float GetHPRatio(AvatarDataItem dataItem) => default; // 0x0000000181A0D4D0-0x0000000181A0D610
	// [XID] // 0x0000000189991650-0x0000000189991670
	private VCAvatarAudio GetLocalAvatarAudio() => default; // 0x0000000181A0D360-0x0000000181A0D460
	// [XID] // 0x0000000189999140-0x0000000189999160
	private void PostTeammateLowHpVoice() {} // 0x0000000181A0CFD0-0x0000000181A0D2E0
}

