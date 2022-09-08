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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCAnimatorEvent : VCBase // TypeDefIndex: 11781
{
	// Fields
	private Animator _animator; // 0x108
	public Action<AnimatorParameterEntry> onUserInputControllerChanged; // 0x110
	public Action<int, AnimatorStateInfo, AnimatorStateInfo, AnimatorStateChangeExtra> onAnimatorStateTransitionFinish; // 0x118
	private Dictionary<int, Dictionary<int, List<int>>> _activeAnimatorEventPatterns; // 0x120
	private Dictionary<int, int> _filterOldPattern2newPattern; // 0x128
	public Action<int, float> processNormalizedTimeActions; // 0x130
	public Queue<CompensateDiffInfo> authorityEventQueue; // 0x138
	public Queue<CompensateDiffInfo> remoteEventQueue; // 0x140
	private VCMoveData _moveData; // 0x148
	private VCSyncAnimator _vcSyncAnimator; // 0x150
	public int MAX_ALLOW_COMPENSATE_TIME; // 0x158
	private const int FRAME_EXIT_ANIMATOR_STATE_BUFFER_COUNT = 4; // Metadata: 0x00AEAAF5
	private List<int> _layerIndexes; // 0x160
	private Dictionary<int, AnimatorLayerItem> _layerItems; // 0x168
	private Dictionary<int, string> _layerIndex2Name; // 0x170

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897364B0-0x00000001897364D0 */ get => default; } // 0x0000000183CE8300-0x0000000183CE83A0 

	// Nested types
	private enum TriggerMode // TypeDefIndex: 11782
	{
		NormalTrigger = 0,
		ForceTriggerOnEnter = 1,
		ForceTriggerOnExitImediately = 2,
		ForceTriggerOnExitTransition = 3,
		ForceTriggerOnExitTransitionFinish = 4
	}

	public class AnimatorEventPatternProcessItem // TypeDefIndex: 11783
	{
		// Fields
		public List<int> patterns; // 0x10
		public AnimatorStateInfo stateInfo; // 0x18
		public float lastTime; // 0x3C

		// Constructors
		public AnimatorEventPatternProcessItem() {} // 0x0000000183CF4A20-0x0000000183CF4A80
	}

	public class AnimatorLayerItem // TypeDefIndex: 11784
	{
		// Fields
		public AnimatorStateInfo lastAnimatorStateInfo; // 0x10
		public AnimatorStateInfo curAnimationStateInfo; // 0x34
		public AnimatorStateInfo prevAnimationStateInfo; // 0x58
		public bool wasInTransition; // 0x7C
		public AnimatorEventPatternProcessItem curPatternItem; // 0x80
		public AnimatorEventPatternProcessItem prevPatternItem; // 0x88
		public AnimatorStateInfo[] sameFrameExitStates; // 0x90
		public int sameFrameExitCount; // 0x98
		public int layerIndex; // 0x9C

		// Constructors
		public AnimatorLayerItem() {} // Dummy constructor
		public AnimatorLayerItem(int layer) {} // 0x0000000183CF4C70-0x0000000183CF4ED0

		// Methods
		// [XID] // 0x000000018984A350-0x000000018984A370
		public void Clear(bool force) {} // 0x0000000183CF4A80-0x0000000183CF4C70
	}

	// Constructors
	public VCAnimatorEvent() {} // 0x0000000183CE81F0-0x0000000183CE8300

	// Methods
	// [XID] // 0x000000018973E300-0x000000018973E320
	public override void Init() {} // 0x0000000183CE5120-0x0000000183CE52D0
	// [XID] // 0x00000001897455D0-0x00000001897455F0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183CE80F0-0x0000000183CE81F0
	// [XID] // 0x000000018974D0D0-0x000000018974D0F0
	public override void OnEntityReady() {} // 0x0000000183CE7CD0-0x0000000183CE7D70
	// [XID] // 0x0000000189754670-0x0000000189754690
	private void CheckLayerInvalid() {} // 0x0000000183CE37E0-0x0000000183CE3C90
	// [XID] // 0x000000018975B890-0x000000018975B8B0
	protected override void LateTick(float inDeltaTime) {} // 0x0000000183CE6B40-0x0000000183CE6DD0
	// [XID] // 0x000000018993AA10-0x000000018993AA30
	public void AddAnimatorEventPattern(int layerIndex, Dictionary<string, string[]> animatorStates) {} // 0x0000000183CE5700-0x0000000183CE5970
	// [XID] // 0x0000000189941B10-0x0000000189941B30
	private void AttachAnimatorEventPattern(int layerIndex, int animatorStateHash, int eventPatternHash) {} // 0x0000000183CE6DD0-0x0000000183CE6FC0
	// [XID] // 0x0000000189772090-0x00000001897720B0
	private void DetachAnimatorEventPattern(int layerIndex, int animatorStateHash, int eventPatternHash) {} // 0x0000000183CE5970-0x0000000183CE5B60
	// [XID] // 0x0000000189779880-0x00000001897798A0
	public void ClearAnimatorEventPattern() {} // 0x0000000183CE7030-0x0000000183CE7220
	// [XID] // 0x0000000189781200-0x0000000189781220
	private void OnAnimatorStateChanged(int layerIndex, AnimatorStateInfo fromState, AnimatorStateInfo toState, AnimatorStateChangeExtra extraInfo) {} // 0x0000000183CE52D0-0x0000000183CE5500
	// [XID] // 0x00000001897886C0-0x00000001897886E0
	private void OnAnimatorStateTransitionFinish(int layerIndex, AnimatorStateInfo fromState, AnimatorStateInfo toState, AnimatorStateChangeExtra extraInfo) {} // 0x0000000183CE69C0-0x0000000183CE6B40
	// [XID] // 0x000000018978FD20-0x000000018978FD40
	public void ReplaceEventPattern(int oldPattern, int newPattern, bool isReplace) {} // 0x0000000183CE43A0-0x0000000183CE44C0
	// [XID] // 0x00000001897975D0-0x00000001897975F0
	public string ReverseLookUpAnimatorStateName(int shorNameHash) => default; // 0x0000000183CE5650-0x0000000183CE5700
	// [XID] // 0x000000018979F4F0-0x000000018979F510
	public void CreateStateLayer(int layerIndex, string layerName) {} // 0x0000000183CE44C0-0x0000000183CE46D0
	// [XID] // 0x00000001897A6AC0-0x00000001897A6AE0
	private void ProcessAnimatorStatesByLayer(int layerIndex) {} // 0x0000000183CE18C0-0x0000000183CE21B0
	// [XID] // 0x00000001897AE220-0x00000001897AE240
	private void ChangePrevProcessItem(AnimatorLayerItem layerItem, bool isInTransition, bool forceTriggerCurrent) {} // 0x0000000183CE5B60-0x0000000183CE69C0
	// [XID] // 0x00000001897B6330-0x00000001897B6350
	private void HandleProcessItem(AnimatorEventPatternProcessItem processItem, AnimatorStateInfo processStateInfo, TriggerMode mode = TriggerMode.NormalTrigger /* Metadata: 0x00AEAAE3 */) {} // 0x0000000183CE46D0-0x0000000183CE4890
	// [XID] // 0x00000001897BE0A0-0x00000001897BE0C0
	private void ProcessAnimatorPattern(AnimatorLayerItem layerItem) {} // 0x0000000183CE7870-0x0000000183CE7B70
	// [XID] // 0x00000001897C5710-0x00000001897C5730
	private void ProcessAnimatorActions(AnimatorLayerItem layerItem) {} // 0x0000000183CE7280-0x0000000183CE73D0
	// [IDTag] // 0x00000001897CCD40-0x00000001897CCD80
	// [XID] // 0x00000001897CCD40-0x00000001897CCD80
	private void ProcessTimeRange(AnimatorEventPatternProcessItem processItem, float from, float to, TriggerMode mode) {} // 0x0000000183CE3550-0x0000000183CE3760
	// [IDTag] // 0x00000001897D75D0-0x00000001897D7610
	// [XID] // 0x00000001897D75D0-0x00000001897D7610
	private void ProcessTimeRange(int patternIndex, float t1, float t2, AnimatorStateInfo curStateInfo, TriggerMode mode) {} // 0x0000000183CE22E0-0x0000000183CE3550
	// [XID] // 0x0000000189AA6300-0x0000000189AA6320
	public float GetProcessingStateNormalizedTime(int layerIndex = 0 /* Metadata: 0x00AEAAE7 */) => default; // 0x0000000183CE5560-0x0000000183CE5650
	// [XID] // 0x0000000189ABE680-0x0000000189ABE6A0
	public AnimatorStateInfo GetProcessingStateInfo(int layerIndex = 0 /* Metadata: 0x00AEAAEB */) => default; // 0x0000000183CE4B40-0x0000000183CE4CB0
	// [XID] // 0x0000000189B1B950-0x0000000189B1B970
	public List<int> GetStateLayerIndexes() => default; // 0x0000000183CE4A90-0x0000000183CE4B40
	// [XID] // 0x00000001898765F0-0x0000000189876610
	public int SyncGetProcessingAnimatorStateHash(int layerIndex = 0 /* Metadata: 0x00AEAAEF */) => default; // 0x0000000183CE3EF0-0x0000000183CE3FD0
	// [XID] // 0x00000001898000C0-0x00000001898000E0
	private void HandleAnimatorEvent(AnimatorEvent evt, AnimatorStateInfo curStateInfo) {} // 0x0000000183CE4890-0x0000000183CE4A90
	// [XID] // 0x00000001898077A0-0x00000001898077C0
	private void ClearLayerItems(bool force = false /* Metadata: 0x00AEAAF3 */, bool process = false /* Metadata: 0x00AEAAF4 */) {} // 0x0000000183CE4CB0-0x0000000183CE5120
	// [XID] // 0x000000018980EE20-0x000000018980EE40
	public override void OnEnable() {} // 0x0000000183CE7C20-0x0000000183CE7CD0
	// [XID] // 0x00000001898164B0-0x00000001898164D0
	public override void OnDisable() {} // 0x0000000183CE7B70-0x0000000183CE7C20
	// [XID] // 0x000000018981DE70-0x000000018981DE90
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183CE2220-0x0000000183CE22E0
	// [XID] // 0x0000000189825240-0x0000000189825260
	public override void Destroy() {} // 0x0000000183CE3CF0-0x0000000183CE3EF0
	// [XID] // 0x0000000189A8FEB0-0x0000000189A8FED0
	private void ClearActiveAnimatorEventPattern() {} // 0x0000000183CE3FD0-0x0000000183CE4340
	// [XID] // 0x0000000189834360-0x0000000189834380
	private void MatchCompensatePosDiffByQueue() {} // 0x0000000183CE7440-0x0000000183CE7870
	// [XID] // 0x000000018983B730-0x000000018983B750
	private void MatchCompensatePosDiffInfo(ref CompensateDiffInfo authorityInfo, ref CompensateDiffInfo remoteInfo) {} // 0x0000000183CE7D70-0x0000000183CE80F0
	// [XID] // 0x00000001898430F0-0x0000000189843110
	public void DisableCompensate() {} // 0x0000000183CE1760-0x0000000183CE1860
}

