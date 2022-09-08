/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaSpeechBubbleTask : LuaTask // TypeDefIndex: 21161
	{
		// Fields
		private static float FIRST_TIME_QUEST_DELAY_MAX; // 0x00
		private static float FIRST_TIME_NPC_DELAY_MAX; // 0x04
		private static float TICK_DAILY_COND_INTERVAL_MIN; // 0x08
		private static float TICK_DAILY_COND_INTERVAL_MAX; // 0x0C
		private float _dailyCondLeftTickTime; // 0x78
		private bool _isDailyBubbleStart; // 0x7C
		private BubbleType bubbleType; // 0x80
		private int dailyBubbleIndex; // 0x84
		private List<BubbleData> currentDailyList; // 0x88
		private List<DailyBubbleData> dailyBubbleDataList; // 0x90
		private List<RuntimeBubble> runtimeBubbleList; // 0x98
	
		// Nested types
		private enum BubbleType // TypeDefIndex: 21162
		{
			None = 0,
			Quest = 1,
			Npc = 2
		}
	
		private enum DailyCondition // TypeDefIndex: 21163
		{
			AllDay = 0,
			Day = 1,
			Night = 2
		}
	
		// Constructors
		public LuaSpeechBubbleTask() {} // 0x0000000184F14790-0x0000000184F14860
		static LuaSpeechBubbleTask() {} // 0x0000000184F14710-0x0000000184F14790
	
		// Methods
		[BlackList] // 0x00000001897B1D50-0x00000001897B1D90
		// [XID] // 0x00000001897B1D50-0x00000001897B1D90
		public NpcModule.SpeechBubblePriority GetPriority() => default; // 0x0000000184F13700-0x0000000184F137C0
		[BlackList] // 0x00000001897BD210-0x00000001897BD250
		// [XID] // 0x00000001897BD210-0x00000001897BD250
		public float GetFirstTimeDelay() => default; // 0x0000000184F135E0-0x0000000184F13700
		[BlackList] // 0x00000001897C7BB0-0x00000001897C7BF0
		// [XID] // 0x00000001897C7BB0-0x00000001897C7BF0
		public void OnBubbleStopped() {} // 0x0000000184F137C0-0x0000000184F13860
		// [XID] // 0x00000001897D1DD0-0x00000001897D1DF0
		public void AddDailyBubbleData(ILuaSpeechBubbleConfigData data) {} // 0x0000000184F12CC0-0x0000000184F12E40
		// [XID] // 0x00000001897D9C30-0x00000001897D9C50
		public void StartDailyBubble() {} // 0x0000000184F13A50-0x0000000184F13B00
		// [XID] // 0x00000001897E0F60-0x00000001897E0F80
		public void CreateNpcSpeechBubble(uint npcId, uint mainQuestId, uint dialogId, float duration, float intervalMin, float intervalMax) {} // 0x0000000184F12E40-0x0000000184F12FF0
		// [XID] // 0x00000001897E8630-0x00000001897E8650
		public void CreateQuestSpeechBubble(uint npcId, uint mainQuestId, uint dialogId, float duration, float intervalMin, float intervalMax, bool loop) {} // 0x0000000184F12FF0-0x0000000184F13230
		// [XID] // 0x00000001897F0340-0x00000001897F0360
		public void StopQuestSpeechBubbleByNpc(uint npcId, uint mainQuestId) {} // 0x0000000184F13C50-0x0000000184F13DE0
		// [XID] // 0x00000001897F7AB0-0x00000001897F7AD0
		public void StopAllQuestSpeechBubble() {} // 0x0000000184F13B00-0x0000000184F13C50
		[BlackList] // 0x00000001897FF110-0x00000001897FF150
		// [XID] // 0x00000001897FF110-0x00000001897FF150
		public void UpdateDailyBubbleList() {} // 0x0000000184F14000-0x0000000184F143C0
		// [XID] // 0x0000000189809800-0x0000000189809820
		private void RandomStartDailyBubble() {} // 0x0000000184F13860-0x0000000184F13980
		// [XID] // 0x0000000189810F90-0x0000000189810FB0
		private List<BubbleData> GetBestDailyBubbleDataList() => default; // 0x0000000184F133D0-0x0000000184F135E0
		// [XID] // 0x0000000189818B30-0x0000000189818B50
		private void Update() {} // 0x0000000184F144E0-0x0000000184F14710
		// [XID] // 0x0000000189820350-0x0000000189820370
		private void UpdateDailyCond() {} // 0x0000000184F143C0-0x0000000184F144E0
		// [XID] // 0x00000001898279D0-0x00000001898279F0
		protected override void TickInternal() {} // 0x0000000184F13DE0-0x0000000184F13E80
		// [XID] // 0x000000018982EBF0-0x000000018982EC10
		public override void FinishTask() {} // 0x0000000184F13320-0x0000000184F133D0
		// [XID] // 0x0000000189836590-0x00000001898365B0
		protected override void DestroyInternal() {} // 0x0000000184F13230-0x0000000184F13320
		// [XID] // 0x000000018983D980-0x000000018983D9A0
		protected override void ReleaseTask() {} // 0x0000000184F13980-0x0000000184F13A50
	}
}
