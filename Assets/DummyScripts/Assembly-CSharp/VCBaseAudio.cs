/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseAudio : VCBase, IIntentionSubmitter // TypeDefIndex: 11804
{
	// Fields
	private const int FORCE_SYNC_INTERVAL = 16; // Metadata: 0x00AEABEF
	private AudioManager _audioManager; // 0x108
	private SyncId _syncId; // 0x110
	private ulong _peerId; // 0x128
	private ListenerPersonality _personality; // 0x130
	private int _forceSyncCounter; // 0x134

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018990BE80-0x000000018990BEA0 */ get => default; } // 0x0000000181B431E0-0x0000000181B43280 
	public bool mute { /* [XID] */ /* 0x0000000189913840-0x0000000189913880 */ get; /* [XID] */ /* 0x000000018991E070-0x000000018991E0B0 */ set; } // 0x0000000181B3FE50-0x0000000181B3FEB0 0x0000000181B411C0-0x0000000181B41230
	public virtual SyncId syncId { /* [XID] */ /* 0x00000001899FAB50-0x00000001899FAB70 */ get => default; /* [XID] */ /* 0x0000000189AF6680-0x0000000189AF66A0 */ protected set {} } // 0x0000000181B41420-0x0000000181B41510 0x0000000181B420A0-0x0000000181B42180
	protected bool isPaused { /* [XID] */ /* 0x0000000189937270-0x00000001899372B0 */ get; /* [XID] */ /* 0x0000000189941970-0x00000001899419B0 */ set; } // 0x0000000181B41700-0x0000000181B41760 0x0000000181B42460-0x0000000181B424D0
	protected virtual bool isStatic { /* [XID] */ /* 0x000000018994C240-0x000000018994C260 */ get => default; } // 0x0000000181B40960-0x0000000181B40A00 
	protected virtual bool isOccEnabled { /* [XID] */ /* 0x0000000189BC0440-0x0000000189BC0460 */ get => default; } // 0x0000000181B422A0-0x0000000181B42340 
	protected virtual AudioManager audioManager { /* [XID] */ /* 0x000000018995B110-0x000000018995B130 */ get => default; /* [XID] */ /* 0x0000000189AFDCB0-0x0000000189AFDCD0 */ set {} } // 0x0000000181B40EC0-0x0000000181B40F70 0x0000000181B423B0-0x0000000181B42460
	protected virtual ulong peerId { /* [XID] */ /* 0x0000000189B43C50-0x0000000189B43C70 */ get => default; /* [XID] */ /* 0x0000000189B05430-0x0000000189B05450 */ set {} } // 0x0000000181B42FF0-0x0000000181B430A0 0x0000000181B424D0-0x0000000181B42580
	protected virtual ListenerPersonality personality { /* [XID] */ /* 0x0000000189B0CBC0-0x0000000189B0CBE0 */ get => default; /* [XID] */ /* 0x0000000189B14140-0x0000000189B14160 */ set {} } // 0x0000000181B41EB0-0x0000000181B41F50 0x0000000181B40320-0x0000000181B403D0

	// Nested types
	protected enum EntityLifeMessage // TypeDefIndex: 11805
	{
		Init = 0,
		Enable = 1,
		Disable = 2,
		Destroy = 3
	}

	// Constructors
	public VCBaseAudio() {} // 0x0000000181B43180-0x0000000181B431E0

	// Methods
	// [XID] // 0x00000001899881F0-0x0000000189988210
	public override void Init() {} // 0x0000000181B41D70-0x0000000181B41EB0
	// [XID] // 0x000000018998FC80-0x000000018998FCA0
	public override void OnEnable() {} // 0x0000000181B42E20-0x0000000181B42EF0
	// [XID] // 0x000000018990A630-0x000000018990A650
	public override void OnDisable() {} // 0x0000000181B42D60-0x0000000181B42E20
	// [XID] // 0x0000000189B1B930-0x0000000189B1B950
	public override void Destroy() {} // 0x0000000181B3FF10-0x0000000181B3FFE0
	[Preserve] // 0x00000001899A6AD0-0x00000001899A6B10
	// [XID] // 0x00000001899A6AD0-0x00000001899A6B10
	public override string Dump() => default; // 0x0000000181B3FFE0-0x0000000181B40230
	// [XID] // 0x00000001899B1720-0x00000001899B1740
	public virtual void PostEvent(uint eventId) {} // 0x0000000181B41510-0x0000000181B41660
	// [XID] // 0x00000001899B89E0-0x00000001899B8A00
	public virtual void PostEvent2D(uint eventId) {} // 0x0000000181B3F440-0x0000000181B3F560
	// [XID] // 0x0000000189B31AE0-0x0000000189B31B00
	public virtual void PostMidiEvent(int instrument, int note) {} // 0x0000000181B41B60-0x0000000181B41CD0
	// [IDTag] // 0x00000001899C7B50-0x00000001899C7B90
	// [XID] // 0x00000001899C7B50-0x00000001899C7B90
	public virtual void PostOneTimeEvent(Vector3 position, AudioOneTimeEvent @event) {} // 0x0000000181B403D0-0x0000000181B404E0
	// [IDTag] // 0x00000001899D2170-0x00000001899D21B0
	// [XID] // 0x00000001899D2170-0x00000001899D21B0
	public virtual void PostOneTimeEvent(Vector3 position, AudioOneTimeEvent @event, AudioCombinedSwitches switches) {} // 0x0000000181B404E0-0x0000000181B407C0
	// [XID] // 0x0000000189B483B0-0x0000000189B483D0
	public virtual void PostGlobalTrigger(uint triggerId) {} // 0x0000000181B3F780-0x0000000181B3F8B0
	// [XID] // 0x00000001899E3F60-0x00000001899E3F80
	public virtual void PostTrigger(uint triggerId) {} // 0x0000000181B40A00-0x0000000181B40B50
	// [XID] // 0x00000001899EB430-0x00000001899EB450
	public virtual void SetGlobalRtpcValue(uint keyId, float value) {} // 0x0000000181B41F50-0x0000000181B42040
	// [XID] // 0x00000001899F30E0-0x00000001899F3100
	public virtual void SetRtpcValue(uint keyId, float value) {} // 0x0000000181B40B50-0x0000000181B40C70
	// [XID] // 0x000000018962E8E0-0x000000018962E900
	public virtual void SetSwitch(uint keyId, uint valueId) {} // 0x0000000181B42580-0x0000000181B42690
	// [XID] // 0x0000000189B6D930-0x0000000189B6D950
	public virtual void SetState(uint keyId, uint valueId) {} // 0x0000000181B40230-0x0000000181B40320
	// [XID] // 0x0000000189A29BC0-0x0000000189A29BE0
	public virtual void Stop() {} // 0x0000000181B3F640-0x0000000181B3F720
	// [XID] // 0x0000000189A10920-0x0000000189A10940
	public virtual bool ExecuteOperation(ConfigAudioOperation operationConfig) => default; // 0x0000000181B42A50-0x0000000181B42B70
	// [XID] // 0x0000000189B1A050-0x0000000189B1A070
	public virtual void OnHittingScene(Collider collider, Vector3 position, ElementType elementType, StrikeType strikeType) {} // 0x0000000181B427C0-0x0000000181B42A50
	// [XID] // 0x000000018985C0A0-0x000000018985C0C0
	public virtual void PostFadeOutEvent() {} // 0x0000000181B42180-0x0000000181B42220
	// [XID] // 0x0000000189A26AB0-0x0000000189A26AD0
	public virtual void StartEmoSync(string emosyncAssetPath) {} // 0x0000000181B42B70-0x0000000181B42D60
	// [XID] // 0x0000000189A2E060-0x0000000189A2E080
	public virtual void StopEmoSync(string emosyncAssetPath) {} // 0x0000000181B3F8B0-0x0000000181B3F960
	// [XID] // 0x0000000189A359A0-0x0000000189A359C0
	public virtual bool PostDialogSpeechEvent(uint dialogId, IDialogVoiceEventResponder responder = null) => default; // 0x0000000181B3FC30-0x0000000181B3FD60
	// [XID] // 0x0000000189A3CF70-0x0000000189A3CF90
	public virtual void PostAnimatorVoiceEvent(uint voiceId) {} // 0x0000000181B41760-0x0000000181B41850
	// [XID] // 0x0000000189A44850-0x0000000189A44870
	public virtual void StopCurrentVoice() {} // 0x0000000181B3FD60-0x0000000181B3FE50
	// [XID] // 0x0000000189A4BF50-0x0000000189A4BF70
	public virtual void PauseOrResumeOnAnimatorSpeedChange(float speed) {} // 0x0000000181B3FA40-0x0000000181B3FC30
	// [XID] // 0x000000018975BA90-0x000000018975BAB0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181B40F70-0x0000000181B41050
	// [XID] // 0x000000018976ABB0-0x000000018976ABD0
	protected override void Tick(float inDeltaTime) {} // 0x0000000181B430A0-0x0000000181B43180
	// [XID] // 0x0000000189A625E0-0x0000000189A62600
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000181B42EF0-0x0000000181B42FF0
	// [XID] // 0x0000000189B85960-0x0000000189B85980
	protected virtual void InitInternal() {} // 0x0000000181B41850-0x0000000181B41B60
	// [XID] // 0x0000000189B22ED0-0x0000000189B22EF0
	protected virtual void ClearInternal() {} // 0x0000000181B407C0-0x0000000181B40900
	// [XID] // 0x0000000189A792B0-0x0000000189A792D0
	protected virtual void PostEntityLifeMessageEvent(EntityLifeMessage message) {} // 0x0000000181B42690-0x0000000181B427C0
	// [XID] // 0x00000001895FA300-0x00000001895FA320
	protected virtual ConfigEntityAudio GetConfigEntityAudio() => default; // 0x0000000181B41CD0-0x0000000181B41D70
	// [XID] // 0x00000001898D1020-0x00000001898D1040
	protected virtual void ImpelSync() {} // 0x0000000181B3F560-0x0000000181B3F640
	// [XID] // 0x0000000189A8FE10-0x0000000189A8FE30
	protected virtual bool ExecuteOperationEvent(ConfigAudioEventOp config) => default; // 0x0000000181B3F960-0x0000000181B3FA40
	// [XID] // 0x0000000189A97410-0x0000000189A97430
	protected virtual bool ExecuteOperationEventEmitter(ConfigAudioEmitterOp config) => default; // 0x0000000181B40CF0-0x0000000181B40EC0
	// [XID] // 0x0000000189A9E7B0-0x0000000189A9E7D0
	protected virtual bool HandleEvtAudio(EvtAudio evt) => default; // 0x0000000181B41230-0x0000000181B413B0
	// [XID] // 0x0000000189AA61A0-0x0000000189AA61C0
	protected virtual bool ShouldIgnoreHittingSceneMessage() => default; // 0x0000000181B41660-0x0000000181B41700
	// [XID] // 0x0000000189B8C7F0-0x0000000189B8C810
	protected virtual ulong GetPeerId(BaseEntity entity) => default; // 0x0000000181B41050-0x0000000181B411C0
}

