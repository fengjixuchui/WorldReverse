/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCSyncAnimator : VCBase // TypeDefIndex: 11967
{
	// Fields
	public bool enableSyncAnimatorState; // 0x108
	public bool enableSyncAnimatorParameter; // 0x109
	private static MuteAnimatorEntry _muteSyncAnimatorTagHash; // 0x00
	private VCAnimatorEvent _vcAnimatorEvent; // 0x110
	private bool enableSyncFadeDuration; // 0x118
	private ulong lastAnimatorStateChangeTime; // 0x120
	public bool ignoreNextSyncCompensation; // 0x128
	private Queue<RemoteStateChangeEntry> _remoteStateChangeQueue; // 0x130
	private VCMoveData _moveData; // 0x138
	public bool isReadyForCompensationAnimatorEvent; // 0x140
	public static Dictionary<int, Tuple<bool, bool, bool, float, float, bool>> syncAnimatorParmeterWhiteList; // 0x08
	private List<AnimatorParameterChangeThrottleEntry> _authorityParameterThrottles; // 0x148

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189880C90-0x0000000189880CB0 */ get => default; } // 0x0000000181E62BC0-0x0000000181E62C60 

	// Nested types
	private struct RemoteStateChangeEntry // TypeDefIndex: 11968
	{
		// Fields
		public int toStateHash; // 0x00
		public float normalizedTimeTo; // 0x04
		public float crossfadeDuration; // 0x08
		public float faceAngle; // 0x0C
		public Vector3 position; // 0x10
	}

	private class AnimatorParameterChangeThrottleEntry // TypeDefIndex: 11969
	{
		// Fields
		public int nameId; // 0x10
		public AnimatorParameterEntry lastSent; // 0x14
		public AnimatorParameterEntry pending; // 0x28
		public float sentTimeAcc; // 0x3C
		public int customIncrSeq; // 0x40

		// Constructors
		public AnimatorParameterChangeThrottleEntry() {} // 0x0000000181E79A70-0x0000000181E79AE0
	}

	// Constructors
	public VCSyncAnimator() {} // 0x0000000181E62B30-0x0000000181E62BC0
	static VCSyncAnimator() {} // 0x0000000181E628C0-0x0000000181E62B30

	// Methods
	// [XID] // 0x0000000189888020-0x0000000189888040
	public override void Init() {} // 0x0000000181E60830-0x0000000181E60B30
	// [XID] // 0x000000018988F580-0x000000018988F5A0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181E62670-0x0000000181E627B0
	// [XID] // 0x0000000189896B20-0x0000000189896B40
	public void EnableSyncFade() {} // 0x0000000181E62400-0x0000000181E624E0
	// [XID] // 0x000000018989DF30-0x000000018989DF50
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181E5E6C0-0x0000000181E5E800
	// [XID] // 0x00000001898A5910-0x00000001898A5930
	private void OnAnimatorStateChanged(EvtAnimatorStateChangedBeforeClear evt) {} // 0x0000000181E60C10-0x0000000181E61A50
	// [XID] // 0x00000001898ACE40-0x00000001898ACE60
	public void OnRemoteEntityAnimatorStateChanged(EvtAnimatorStateChangedInfo packet) {} // 0x0000000181E5F170-0x0000000181E5FA90
	// [XID] // 0x0000000189893D60-0x0000000189893D80
	private void CheckSyncTransitionSetting(int fromStateHash, int toStateHash, out SyncTransitionSettingEntry transitionSetting) {
		transitionSetting = default;
	} // 0x0000000181E60B30-0x0000000181E60C10
	// [XID] // 0x00000001898BC1D0-0x00000001898BC1F0
	private void SyncRemoteAnimatorChange() {} // 0x0000000181E5E080-0x0000000181E5E530
	// [XID] // 0x00000001898C3570-0x00000001898C3590
	private void SyncCrossfadeAnimatorState(int layer, int stateHash, float crossfadeDuration, float targetNormalizedTime) {} // 0x0000000181E61DE0-0x0000000181E62080
	// [XID] // 0x00000001898CAEF0-0x00000001898CAF10
	private void SyncPlayAnimatorState(int layer, int stateHash, float normalizedTime) {} // 0x0000000181E62280-0x0000000181E62390
	// [XID] // 0x00000001898D25B0-0x00000001898D25D0
	public void OnAnimatorParameterSet(AnimatorParameterEntry entry) {} // 0x0000000181E60030-0x0000000181E603D0
	// [XID] // 0x00000001898D9EF0-0x00000001898D9F10
	private void AuthorityAnimatorParameterChangeTick() {} // 0x0000000181E61AB0-0x0000000181E61DE0
	// [XID] // 0x00000001898E1A80-0x00000001898E1AA0
	private void SendEvtAnimatorParameterChanged(AnimatorParameterEntry entry) {} // 0x0000000181E606B0-0x0000000181E60830
	// [XID] // 0x00000001898E9810-0x00000001898E9830
	public void OnRemoteEntityAnimatorParameterChanged(int nameId, AnimatorParameterValueInfo valueInfo) {} // 0x0000000181E5EEC0-0x0000000181E5F170
	// [XID] // 0x0000000189646A40-0x0000000189646A60
	private bool HasSyncAnimatorParameter(int nameId) => default; // 0x0000000181E5DF10-0x0000000181E5E010
	// [XID] // 0x00000001898F8700-0x00000001898F8720
	private void CheckSyncAnimatorWhiteList(int nameId) {} // 0x0000000181E5DD80-0x0000000181E5DF10
	// [XID] // 0x0000000189B08460-0x0000000189B08480
	private bool GetSyncAnimatorParameterReliable(int nameId) => default; // 0x0000000181E5FEA0-0x0000000181E60030
	// [XID] // 0x00000001899076A0-0x00000001899076C0
	private bool GetSyncAnimatorParameterChangedImmediately(int nameId) => default; // 0x0000000181E5E530-0x0000000181E5E6C0
	// [XID] // 0x000000018990EFB0-0x000000018990EFD0
	public bool GetSyncAnimatorParameterHandledInSyncMotion(int nameId) => default; // 0x0000000181E62080-0x0000000181E62210
	// [XID] // 0x0000000189B1E6A0-0x0000000189B1E6C0
	private float GetSyncAnimatorParameterSendInterval(int nameId) => default; // 0x0000000181E5FBB0-0x0000000181E5FD50
	// [XID] // 0x000000018991E030-0x000000018991E050
	private float GetSyncAnimatorParameterSmoothTime(int nameId) => default; // 0x0000000181E603D0-0x0000000181E60570
	// [XID] // 0x0000000189A80D10-0x0000000189A80D30
	private bool GetSyncAnimatorParameterIsServerCache(int nameId) => default; // 0x0000000181E624E0-0x0000000181E62670
	// [XID] // 0x000000018992CDD0-0x000000018992CDF0
	protected override void Tick(float inDeltaTime) {} // 0x0000000181E627B0-0x0000000181E628C0
	// [XID] // 0x00000001899342C0-0x00000001899342E0
	public override void Destroy() {} // 0x0000000181E5FA90-0x0000000181E5FBB0
	// [XID] // 0x000000018993BFD0-0x000000018993BFF0
	public bool IsInSyncRemoteStatesChanged() => default; // 0x0000000181E605F0-0x0000000181E606B0
	// [XID] // 0x00000001899433D0-0x00000001899433F0
	public void ConsiderAnimatorStateChange(EvtAnimatorStateChangedInfo packet, bool needSetPosRot) {} // 0x0000000181E5E800-0x0000000181E5EEC0
	// [XID] // 0x000000018994AAA0-0x000000018994AAC0
	public void FlushQueues() {} // 0x0000000181E5FD50-0x0000000181E5FEA0
}

