/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaHomeTask : LuaTask, ICustomEventListener, IDialogVoiceEventResponder // TypeDefIndex: 21147
	{
		// Fields
		private static float DEFAULT_SPEECHBUBBLE_DEALY; // 0x00
		private static float DEFAULT_SPEECHBUBBLE_INTERVAL; // 0x04
		private static uint SPEECHBUBBLE_PRIORITY; // 0x08
		private static float GREET_DIST_MIN; // 0x0C
		private static float GREET_DIST_MAX; // 0x10
		private static float GREET_ANGLE_OFFSET; // 0x14
		private static float GREET_TURN_MIN_ANGLE; // 0x18
		private static float GREET_TURN_DURATION; // 0x1C
		private static bool _constValueInited; // 0x20
		private const float StateLeavingDelayMin = 0.5f; // Metadata: 0x00AFEEED
		private const float StateLeavingDelayMax = 1.5f; // Metadata: 0x00AFEEF1
		private const float StateLeavingCheckStartDelay = 1f; // Metadata: 0x00AFEEF5
		private static int STANDBY_HASH; // 0x24
		private EntityActor _entityActor; // 0x78
		private List<AdvDailyAction> _actionList; // 0x80
		private Dictionary<int, SpeechBubbleData[]> _speechBubbleGroup; // 0x88
		private int _curActionIndex; // 0x90
		private uint _condDirtyFlag; // 0x94
		private bool _needCheckAction; // 0x98
		private bool _needCheckActionForce; // 0x99
		private FreeStyleData _curFreeStyleData; // 0xA0
		private float _curFreeStyleLeftTime; // 0xA8
		private Vector3 _curActionPointPos; // 0xAC
		private Vector3 _curActionPointForward; // 0xB8
		private float _curWaitingQuitFreeStyle; // 0xC4
		private GreetConfig _greetConfig; // 0xC8
		private bool _allowGreet; // 0xD0
		private float _curGreetTurnTime; // 0xD4
		private Vector3 _curGreetForward; // 0xD8
		private GreetState _curGreetState; // 0xE4
		private SpeechBubbleData _curSpeechBubbleData; // 0xE8
		private uint _curSpeechBubbleDialogId; // 0xF0
		private float _nextSpeechBubbleTime; // 0xF4
		private float _curSpeechBubbleLeftTime; // 0xF8
		private uint _nextSpeechBubbleDialogId; // 0xFC
		private bool _isSpeechBubblePlayVoice; // 0x100
		private bool _isInitFinish; // 0x101
		private List<INpcActionCondSubContainer> _tempCondContainerList; // 0x108
	
		// Properties
		public override bool isBackGround { /* [XID] */ /* 0x00000001899DD080-0x00000001899DD0A0 */ get => default; } // 0x0000000184F06B00-0x0000000184F06BA0 
	
		// Nested types
		private enum GreetState // TypeDefIndex: 21148
		{
			None = 0,
			Entering = 1,
			Performing = 2,
			Leaving = 3
		}
	
		private struct SpeechBubbleWrapper : IEnumerable<SpeechBubbleData> // TypeDefIndex: 21149
		{
			// Fields
			private int[] _speechBubbleGroupIds; // 0x00
			private Dictionary<int, SpeechBubbleData[]> _speechBubbleGroupDic; // 0x08
	
			// Constructors
			public SpeechBubbleWrapper(int[] groupIds, Dictionary<int, SpeechBubbleData[]> groupDic) {
				_speechBubbleGroupIds = default;
				_speechBubbleGroupDic = default;
			} // 0x0000000184F1DB60-0x0000000184F1DC00
	
			// Methods
			[DebuggerHidden] // 0x0000000189B30BB0-0x0000000189B30BF0
			// [XID] // 0x0000000189B30BB0-0x0000000189B30BF0
			public IEnumerator<SpeechBubbleData> GetEnumerator() => default; // 0x0000000184F1DA30-0x0000000184F1DB50
			[DebuggerHidden] // 0x0000000189B3B410-0x0000000189B3B450
			// [XID] // 0x0000000189B3B410-0x0000000189B3B450
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184F1DB50-0x0000000184F1DB60
		}
	
		// Constructors
		public LuaHomeTask() {} // 0x0000000184F06A00-0x0000000184F06B00
		static LuaHomeTask() {} // 0x0000000184F06930-0x0000000184F06A00
	
		// Methods
		[BlackList] // 0x00000001899E4C60-0x00000001899E4CA0
		// [XID] // 0x00000001899E4C60-0x00000001899E4CA0
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F02990-0x0000000184F02B00
		// [XID] // 0x00000001899EF060-0x00000001899EF080
		public void InitParam(List<AdvDailyAction> actionList, Dictionary<int, SpeechBubbleData[]> speechBubbleGroup, GreetConfig greetConfig) {} // 0x0000000184F028A0-0x0000000184F02990
		// [XID] // 0x00000001899F6A30-0x00000001899F6A50
		private void StartInit() {} // 0x0000000184F04CF0-0x0000000184F050E0
		// [XID] // 0x00000001899FE010-0x00000001899FE030
		private bool CheckInitFinish() => default; // 0x0000000184F021A0-0x0000000184F022B0
		// [XID] // 0x0000000189A05930-0x0000000189A05950
		private void RefreshConstValue(bool force = false /* Metadata: 0x00AFEEEB */) {} // 0x0000000184F03A80-0x0000000184F04150
		// [XID] // 0x0000000189A0CC00-0x0000000189A0CC20
		private void RegistEvents() {} // 0x0000000184F04150-0x0000000184F043B0
		// [XID] // 0x0000000189A14540-0x0000000189A14560
		private void UnRegistEvents() {} // 0x0000000184F06850-0x0000000184F06930
		// [XID] // 0x0000000189A1B7F0-0x0000000189A1B810
		private static int CompareAction(AdvDailyAction action1, AdvDailyAction action2) => default; // 0x0000000184F024E0-0x0000000184F025B0
		// [XID] // 0x0000000189A231E0-0x0000000189A23200
		protected override void TickInternal() {} // 0x0000000184F06110-0x0000000184F06250
		// [XID] // 0x0000000189A2A3C0-0x0000000189A2A3E0
		public override void StartTask() {} // 0x0000000184F05300-0x0000000184F053C0
		// [XID] // 0x0000000189A31830-0x0000000189A31850
		private void StartWaitingOutFreeStyle() {} // 0x0000000184F053C0-0x0000000184F05460
		// [XID] // 0x0000000189A39370-0x0000000189A39390
		private void StopWaitingOutFreeStyle() {} // 0x0000000184F05530-0x0000000184F055D0
		// [XID] // 0x0000000189A40B10-0x0000000189A40B30
		private bool IsWaitingOutFreeStyle() => default; // 0x0000000184F03300-0x0000000184F033B0
		// [XID] // 0x0000000189A481B0-0x0000000189A481D0
		private bool CheckWaitingOutFreeStyle(float deltaTime) => default; // 0x0000000184F022B0-0x0000000184F024E0
		// [XID] // 0x0000000189A4FAA0-0x0000000189A4FAC0
		private void CheckAction(bool force = false /* Metadata: 0x00AFEEEC */) {} // 0x0000000184F01F40-0x0000000184F020F0
		// [XID] // 0x0000000189A57030-0x0000000189A57050
		private bool IsCondValid(INpcActionCondContainer container) => default; // 0x0000000184F02B00-0x0000000184F02D10
		private T GetRandomCondContainer<T>(IEnumerable<T> condContainerList)
			where T : class, INpcActionCondSubContainer => default;
		// [XID] // 0x0000000189A5EC10-0x0000000189A5EC30
		private void MoveToNextActionPoint(bool resetPos) {} // 0x0000000184F033B0-0x0000000184F036C0
		// [XID] // 0x0000000189A66350-0x0000000189A66370
		private void ApplyFreeStyle(FreeStyleData data) {} // 0x0000000184F01B20-0x0000000184F01DE0
		// [XID] // 0x0000000189A6DAA0-0x0000000189A6DAC0
		private void TickFreeStyle(float deltaTime) {} // 0x0000000184F055D0-0x0000000184F057A0
		// [XID] // 0x0000000189A751D0-0x0000000189A751F0
		private void TickGreet(float deltaTime) {} // 0x0000000184F057A0-0x0000000184F06110
		// [XID] // 0x0000000189A7CE50-0x0000000189A7CE70
		private void PerformGreet() {} // 0x0000000184F039B0-0x0000000184F03A80
		// [XID] // 0x0000000189A84740-0x0000000189A84760
		private bool IsShouldGreet(out Vector3 targetDir) {
			targetDir = default;
			return default;
		} // 0x0000000184F02DC0-0x0000000184F03230
		// [XID] // 0x0000000189A8C040-0x0000000189A8C060
		private bool IsInGreet() => default; // 0x0000000184F02D10-0x0000000184F02DC0
		// [XID] // 0x0000000189A934F0-0x0000000189A93510
		private void ForceStopGreet() {} // 0x0000000184F02670-0x0000000184F02720
		// [XID] // 0x0000000189A9B000-0x0000000189A9B020
		private void StopSpeechBubbleWork() {} // 0x0000000184F05460-0x0000000184F05530
		// [XID] // 0x0000000189AA2370-0x0000000189AA2390
		private void StartSpeechBubbleWork(FreeStyleData data) {} // 0x0000000184F050E0-0x0000000184F05300
		// [XID] // 0x0000000189AA98E0-0x0000000189AA9900
		private bool IsSpeechBubbleRuning() => default; // 0x0000000184F03230-0x0000000184F03300
		// [XID] // 0x0000000189AB16A0-0x0000000189AB16C0
		private void TickSpeechBubble(float deltaTime) {} // 0x0000000184F06250-0x0000000184F06440
		// [XID] // 0x0000000189AB8A20-0x0000000189AB8A40
		private void ShowSpeechBubbleImpl(uint dialogId) {} // 0x0000000184F04840-0x0000000184F04A00
		// [XID] // 0x0000000189AC0650-0x0000000189AC0670
		private void HideSpeechBubbleImpl() {} // 0x0000000184F02720-0x0000000184F028A0
		// [XID] // 0x0000000189AC7FF0-0x0000000189AC8010
		private void ResetEmotion() {} // 0x0000000184F04480-0x0000000184F04670
		// [XID] // 0x0000000189ACF690-0x0000000189ACF6B0
		public void StartEmotion(string emotion, string phoneme) {} // 0x0000000184F04A00-0x0000000184F04CF0
		// [XID] // 0x0000000189AD7440-0x0000000189AD7460
		private void CheckFinish() {} // 0x0000000184F020F0-0x0000000184F021A0
		// [XID] // 0x0000000189ADEF30-0x0000000189ADEF50
		protected override void DestroyInternal() {} // 0x0000000184F025B0-0x0000000184F02670
		// [XID] // 0x0000000189AE6800-0x0000000189AE6820
		protected override void ReleaseTask() {} // 0x0000000184F043B0-0x0000000184F04480
		// [XID] // 0x0000000189AEE160-0x0000000189AEE180
		public override void OnPause() {} // 0x0000000184F037A0-0x0000000184F03850
		// [XID] // 0x0000000189AF58F0-0x0000000189AF5910
		public override void OnResume() {} // 0x0000000184F03850-0x0000000184F03900
		// [XID] // 0x0000000189AFCCF0-0x0000000189AFCD10
		public override void CallDisappearEvent() {} // 0x0000000184F01E90-0x0000000184F01F40
		// [XID] // 0x0000000189B04460-0x0000000189B04480
		public override void CallAppearEvent() {} // 0x0000000184F01DE0-0x0000000184F01E90
		// [XID] // 0x0000000189B0BCD0-0x0000000189B0BCF0
		private void PauseTaskImpl() {} // 0x0000000184F03900-0x0000000184F039B0
		// [XID] // 0x0000000189B132C0-0x0000000189B132E0
		private void ResumeTaskImpl() {} // 0x0000000184F047A0-0x0000000184F04840
		// [XID] // 0x0000000189B1AA80-0x0000000189B1AAA0
		public void OnCustomEvent(CustomEventType eventType, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] objParams) {} // 0x0000000184F036C0-0x0000000184F037A0
		// [XID] // 0x0000000189B29620-0x0000000189B29640
		public void RespondToDialogVoiceEvent(uint dialogId, bool startPlaying) {} // 0x0000000184F04670-0x0000000184F047A0
	}
}
