/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class VoicePipeline // TypeDefIndex: 11532
{
	// Fields
	public const int INVALID_STUB = -1; // Metadata: 0x00AE995F
	private readonly EventStartCallback _startCallback; // 0x10
	private readonly EventCallback _eventCallback; // 0x18
	private readonly VoicePipelineWaitingList _waitingList; // 0x20
	private static int _autoIncrement; // 0x00
	private VoicePipelineWaitingList.Node _playingNode; // 0x28

	// Properties
	public bool playing { /* [XID] */ /* 0x000000018963F250-0x000000018963F270 */ get; } // 0x00000001846BD4D0-0x00000001846BD580 
	protected EventStartCallback eventStartCallback { /* [XID] */ /* 0x0000000189A7AE70-0x0000000189A7AE90 */ get; } // 0x00000001846BF600-0x00000001846BF6A0 
	protected EventCallback eventCallback { /* [XID] */ /* 0x0000000189A82480-0x0000000189A824A0 */ get; } // 0x00000001846BD670-0x00000001846BD710 
	protected VoicePipelineWaitingList waitingList { /* [XID] */ /* 0x0000000189B27700-0x0000000189B27720 */ get; } // 0x00000001846BED70-0x00000001846BEE10 
	protected VoicePipelineWaitingList.Node playingNode { /* [XID] */ /* 0x0000000189A91520-0x0000000189A91540 */ get; } // 0x00000001846BE200-0x00000001846BE2A0 
	protected virtual bool isContextActive { /* [XID] */ /* 0x0000000189A99050-0x0000000189A99070 */ get; } // 0x00000001846BECD0-0x00000001846BED70 

	// Nested types
	protected class MultiVoiceIdPossessor<TVoicePipeline> // TypeDefIndex: 11533
		where TVoicePipeline : VoicePipeline, IVoiceIdPossessor
	{
		// Fields
		private readonly VoiceIdRegistration _idReg;
		private readonly TVoicePipeline _voicePipeline;
		private readonly HashSet<uint> _possessedVoiceIds;

		// Constructors
		public MultiVoiceIdPossessor() {} // Dummy constructor
		public MultiVoiceIdPossessor(VoiceIdRegistration idReg, TVoicePipeline pipeline) {}

		// Methods
		public void GrantId(uint voiceId) {}
		public void AnnulId(uint voiceId) {}
		public void DropAll(uint voiceId) {}
		public void TryPlayNext() {}
		public void CancelPendingVoiceIdentityApplication() {}
		public void RedeemPlayFailure() {}
		public void OnEventStop(object cookie, AkCallbackType type, MmoronCallbackInfo info) {}
		public void ReleaseVoiceIds() {}
		private uint GetCurrentVoiceIdInUse() => default;
	}

	protected struct SubmissionDecisionArguments // TypeDefIndex: 11534
	{
		// Properties
		public bool dropIntention { /* [XID] */ /* 0x0000000189B7C390-0x0000000189B7C3D0 */ get; /* [XID] */ /* 0x0000000189B86F70-0x0000000189B86FB0 */ set; } // 0x00000001846D1640-0x00000001846D16A0 0x00000001846D14C0-0x00000001846D1520
		public bool cancelPreviousApplication { /* [XID] */ /* 0x0000000189B91340-0x0000000189B91380 */ get; /* [XID] */ /* 0x0000000189B9B630-0x0000000189B9B670 */ set; } // 0x00000001846D1520-0x00000001846D1580 0x00000001846D13A0-0x00000001846D1400
		public bool clearWaitingList { /* [XID] */ /* 0x0000000189BA5AF0-0x0000000189BA5B30 */ get; /* [XID] */ /* 0x0000000189BAFBC0-0x0000000189BAFC00 */ set; } // 0x00000001846D1400-0x00000001846D1460 0x00000001846D1760-0x00000001846D17C0
		public bool addAtFront { /* [XID] */ /* 0x0000000189BBA240-0x0000000189BBA280 */ get; /* [XID] */ /* 0x0000000189BC4F60-0x0000000189BC4FA0 */ set; } // 0x00000001846D16A0-0x00000001846D1760 0x00000001846D1340-0x00000001846D13A0
		public bool stopCurrentPlayingNode { /* [XID] */ /* 0x0000000189BCF8F0-0x0000000189BCF930 */ get; /* [XID] */ /* 0x0000000189BD9E90-0x0000000189BD9ED0 */ set; } // 0x00000001846D1460-0x00000001846D14C0 0x00000001846D1580-0x00000001846D15E0
		public bool tryPlayAfterSubmission { /* [XID] */ /* 0x00000001895E9BA0-0x00000001895E9BE0 */ get; /* [XID] */ /* 0x00000001895F4330-0x00000001895F4370 */ set; } // 0x00000001846D17C0-0x00000001846D1890 0x00000001846D15E0-0x00000001846D1640
	}

	// Constructors
	public VoicePipeline() {} // 0x00000001846BFAB0-0x00000001846BFBB0

	// Methods
	// [XID] // 0x0000000189AA0160-0x0000000189AA0180
	public virtual int Submit(IVoiceIntention intention) => default; // 0x00000001846BD710-0x00000001846BDFD0
	// [XID] // 0x0000000189AA79B0-0x0000000189AA79D0
	public virtual bool Stop(int stub) => default; // 0x00000001846BD120-0x00000001846BD220
	// [XID] // 0x0000000189AAF1D0-0x0000000189AAF1F0
	public virtual void Drop(int stub) {} // 0x00000001846BD220-0x00000001846BD2F0
	// [XID] // 0x0000000189AB6A70-0x0000000189AB6A90
	public virtual void DropAll() {} // 0x00000001846BEE10-0x00000001846BEF10
	// [XID] // 0x0000000189A5FC60-0x0000000189A5FC80
	public virtual void StopCurrent() {} // 0x00000001846BE2A0-0x00000001846BE480
	// [XID] // 0x0000000189AC6110-0x0000000189AC6130
	public virtual bool CheckCurrentIntentionSubmitterIs(IIntentionSubmitter submitter) => default; // 0x00000001846BD3F0-0x00000001846BD4D0
	// [XID] // 0x0000000189851B40-0x0000000189851B60
	public virtual void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001846BF6A0-0x00000001846BF980
	// [XID] // 0x0000000189AD53E0-0x0000000189AD5400
	protected static uint GetVoiceIdFromIntention(IVoiceIntention intention) => default; // 0x00000001846BE9B0-0x00000001846BEA80
	protected abstract SyncId GetSyncId();
	protected abstract void TryPlayNext();
	protected abstract void CancelPendingVoiceIdentityRequest();
	protected abstract void RedeemPlayFailure();
	protected abstract void EventStopCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info);
	// [XID] // 0x0000000189B49EE0-0x0000000189B49F00
	protected virtual int ProcessIntentionSubmission(IVoiceIntention intention, SubmissionDecisionArguments arguments) => default; // 0x00000001846BEF10-0x00000001846BF2D0
	// [XID] // 0x0000000189B9CD60-0x0000000189B9CD80
	protected virtual void StartPlaying() {} // 0x00000001846BE480-0x00000001846BE680
	// [XID] // 0x0000000189AEBD50-0x0000000189AEBD70
	protected virtual AudioPostedEventStatus Play(VoicePipelineWaitingList.Node node) => default; // 0x00000001846BEA80-0x00000001846BECD0
	// [XID] // 0x0000000189AF37C0-0x0000000189AF37E0
	protected virtual void EventStartCallback(uint postId, uint playingId) {} // 0x00000001846BF2D0-0x00000001846BF560
	// [XID] // 0x0000000189AFB020-0x0000000189AFB040
	protected virtual bool CheckCallbackIsProper(object cookie, AkCallbackType type, out VoicePipelineWaitingList.Node intentionNode) {
		intentionNode = default;
		return default;
	} // 0x00000001846BF980-0x00000001846BFAB0
	// [XID] // 0x0000000189B02600-0x0000000189B02620
	protected virtual void InvokeStartEventCallback(VoicePipelineWaitingList.Node intentionNode) {} // 0x00000001846BE8C0-0x00000001846BE9B0
	// [XID] // 0x0000000189B09C20-0x0000000189B09C40
	protected virtual void InvokeEndEventCallback(VoicePipelineWaitingList.Node intentionNode) {} // 0x00000001846BD580-0x00000001846BD670
	// [XID] // 0x0000000189B116A0-0x0000000189B116C0
	protected virtual void AddToPlayingVoiceId(uint playingId) {} // 0x00000001846BE100-0x00000001846BE200
	// [XID] // 0x0000000189655C40-0x0000000189655C60
	protected virtual void RemoveFromPlayingVoiceId(uint playingId) {} // 0x00000001846BD2F0-0x00000001846BD3F0
	// [XID] // 0x00000001896303B0-0x00000001896303D0
	protected virtual void RemovePlayingNode() {} // 0x00000001846BF560-0x00000001846BF600
	// [XID] // 0x0000000189B27620-0x0000000189B27640
	protected virtual VoicePipelineWaitingList.Node AllocateNode(IVoiceIntention intention) => default; // 0x00000001846BE7C0-0x00000001846BE8C0
	// [XID] // 0x0000000189B67E30-0x0000000189B67E50
	protected virtual void DeallocateNode(VoicePipelineWaitingList.Node intentionNode) {} // 0x00000001846BDFD0-0x00000001846BE100
	// [XID] // 0x0000000189B35F90-0x0000000189B35FB0
	protected virtual void ClearWaitingList() {} // 0x00000001846BE680-0x00000001846BE7C0
}

