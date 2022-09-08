/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B018C0-0x0000000189B01900
	[RecycleType] // 0x0000000189B018C0-0x0000000189B01900
	public sealed class QuestActor : BaseActor, IAutoAllocRecycle // TypeDefIndex: 20225
	{
		// Fields
		private uint _mainID; // 0x130
		private QuestProxy _quest; // 0x138
	
		// Properties
		public uint mainID { /* [XID] */ /* 0x00000001898AB520-0x00000001898AB540 */ get => default; } // 0x0000000183BB7CC0-0x0000000183BB7D60 
	
		// Events
		public event Action<ILuaActor, QuestProxy> StartQuest;
		public event Action<ILuaActor, QuestProxy> StartSubQuest;
		public event Action<ILuaActor, QuestProxy> FinishSubQuest;
		public event Action<ILuaActor, QuestProxy> FinishQuest;
		public event Action<ILuaActor, QuestProxy> FailMainQuest;
		public event Action<ILuaActor, QuestProxy> CancelMainQuest;
		public event Action<ILuaActor, QuestProxy> FailedSubQuest;
		public event Action<ILuaActor, QuestProxy> RewindQuest;
		private event SoftRewindQuestHandler _SoftRewindQuest;
		public event Action<ILuaActor, ILuaActor, int> StartQuestTask;
	
		// Nested types
		public delegate bool SoftRewindQuestHandler(ILuaActor luaActor, QuestProxy quest); // TypeDefIndex: 20226; 0x0000000183BBE060-0x0000000183BBE310
	
		// Constructors
		public QuestActor() {} // 0x0000000183BB70C0-0x0000000183BB7180
	
		// Methods
		[BlackList] // 0x00000001896883E0-0x0000000189688420
		// [XID] // 0x00000001896883E0-0x0000000189688420
		public override void AutoAllocTypeFields() {} // 0x0000000183BB5530-0x0000000183BB55D0
		[BlackList] // 0x0000000189692F90-0x0000000189692FD0
		// [XID] // 0x0000000189692F90-0x0000000189692FD0
		public override void AutoRecycleTypeFields() {} // 0x0000000183BB55D0-0x0000000183BB56D0
		[BlackList] // 0x000000018969D420-0x000000018969D460
		// [XID] // 0x000000018969D420-0x000000018969D460
		public override void ReturnToObjectPool() {} // 0x0000000183BB6940-0x0000000183BB69E0
		// [XID] // 0x00000001896B6280-0x00000001896B62A0
		public void CallStartQuest() {} // 0x0000000183BB5FE0-0x0000000183BB60C0
		// [XID] // 0x00000001896CBFB0-0x00000001896CBFD0
		public void CallStartSubQuest() {} // 0x0000000183BB60C0-0x0000000183BB61A0
		// [XID] // 0x00000001896E2660-0x00000001896E2680
		public void CallFinishSubQuest() {} // 0x0000000183BB5A50-0x0000000183BB5B30
		// [XID] // 0x00000001896F85A0-0x00000001896F85C0
		public void CallFinishQuest() {} // 0x0000000183BB5970-0x0000000183BB5A50
		// [XID] // 0x000000018970EEA0-0x000000018970EEC0
		public void CallFailMainQuest() {} // 0x0000000183BB57B0-0x0000000183BB5890
		// [XID] // 0x00000001897252A0-0x00000001897252C0
		public void CallCancelMainQuest() {} // 0x0000000183BB56D0-0x0000000183BB57B0
		// [XID] // 0x000000018973B770-0x000000018973B790
		public void CallFailedSubQuest() {} // 0x0000000183BB5890-0x0000000183BB5970
		// [XID] // 0x0000000189751E90-0x0000000189751EB0
		public void CallRewindQuest() {} // 0x0000000183BB5B30-0x0000000183BB5DF0
		// [XID] // 0x00000001897684C0-0x00000001897684E0
		public void RegisterSoftRewindQuest(SoftRewindQuestHandler softRewindQuestCallback) {} // 0x0000000183BB6660-0x0000000183BB6710
		// [XID] // 0x000000018976FB50-0x000000018976FB70
		public void UnregisterSoftRewindQuest(SoftRewindQuestHandler softRewindQuestCallback) {} // 0x0000000183BB7010-0x0000000183BB70C0
		// [XID] // 0x0000000189777350-0x0000000189777370
		public bool CallSoftRewindQuest() => default; // 0x0000000183BB5DF0-0x0000000183BB5ED0
		// [XID] // 0x000000018978D930-0x000000018978D950
		public void CallStartQuestTask(ILuaActor targetActor, int taskUniqId) {} // 0x0000000183BB5ED0-0x0000000183BB5FE0
		// [XID] // 0x000000018979D370-0x000000018979D390
		public void InitMainID(uint mainID) {} // 0x0000000183BB6500-0x0000000183BB65B0
		// [XID] // 0x00000001897A45F0-0x00000001897A4610
		public void RefreshSubQuest(QuestProxy quest) {} // 0x0000000183BB65B0-0x0000000183BB6660
		// [XID] // 0x00000001897ABB00-0x00000001897ABB20
		public void TryFinishCurrQuest(bool isFailed = false /* Metadata: 0x00AFD3E4 */, QuestProxy quest = null) {} // 0x0000000183BB6D20-0x0000000183BB6EF0
		// [XID] // 0x00000001897B3B00-0x00000001897B3B20
		public void TryFinishCurrQuestID(bool isFailed = false /* Metadata: 0x00AFD3E5 */, uint questID = 0 /* Metadata: 0x00AFD3E6 */) {} // 0x0000000183BB6BD0-0x0000000183BB6D20
		// [XID] // 0x00000001897BB8D0-0x00000001897BB8F0
		public string GetRandomFactorValue(string type) => default; // 0x0000000183BB63D0-0x0000000183BB6500
		// [XID] // 0x00000001897C3150-0x00000001897C3170
		public uint GetGivingRecord(uint id) => default; // 0x0000000183BB61A0-0x0000000183BB62B0
		// [XID] // 0x00000001897CA9B0-0x00000001897CA9D0
		public void SetQuestVar(uint mainQuestID, uint index, int value) {} // 0x0000000183BB69E0-0x0000000183BB6B00
		// [XID] // 0x00000001897D1FB0-0x00000001897D1FD0
		public int GetQuestVar(uint mainQuestID, uint index, int value) => default; // 0x0000000183BB62B0-0x0000000183BB63D0
		// [XID] // 0x00000001897D9D90-0x00000001897D9DB0
		public void ReturnQuestNpc(uint npcId) {} // 0x0000000183BB6710-0x0000000183BB6940
		// [XID] // 0x00000001899C9240-0x00000001899C9260
		public void StartMainQuestTask(ILuaActor target, int taskUniqId) {} // 0x0000000183BB6B00-0x0000000183BB6BD0
	}
}
