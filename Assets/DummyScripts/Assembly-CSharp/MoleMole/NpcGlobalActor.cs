/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public sealed class NpcGlobalActor : GlobalActor, IAutoAllocRecycle // TypeDefIndex: 20222
	{
		// Fields
		private List<ConvData> convDataList; // 0x120
		private List<RuntimeSequence> runtimeSequenceList; // 0x128
		private Dictionary<int, List<uint>> pendingConvDic; // 0x130
		private NormalTimer pendingConvTimer; // 0x138
		private static float PENDING_CONV_WAIT_DURATION; // 0x00
		private Dictionary<int, ActionPointData> actionPointDic; // 0x140
	
		// Constructors
		public NpcGlobalActor() {} // 0x00000001824BCA10-0x00000001824BCA90
		static NpcGlobalActor() {} // 0x00000001824BC9B0-0x00000001824BCA10
	
		// Methods
		[BlackList] // 0x0000000189B36B50-0x0000000189B36B90
		// [XID] // 0x0000000189B36B50-0x0000000189B36B90
		public override void AutoAllocTypeFields() {} // 0x00000001824BB000-0x00000001824BB0A0
		[BlackList] // 0x0000000189B41570-0x0000000189B415B0
		// [XID] // 0x0000000189B41570-0x0000000189B415B0
		public override void AutoRecycleTypeFields() {} // 0x00000001824BB0A0-0x00000001824BB170
		[BlackList] // 0x0000000189B4BF80-0x0000000189B4BFC0
		// [XID] // 0x0000000189B4BF80-0x0000000189B4BFC0
		public override void ReturnToObjectPool() {} // 0x00000001824BC330-0x00000001824BC3D0
		// [XID] // 0x0000000189B56710-0x0000000189B56730
		public override void InitGlobal() {} // 0x00000001824BB360-0x00000001824BB460
		// [XID] // 0x0000000189B5DEC0-0x0000000189B5DEE0
		private bool IsInConversation(uint npcId) => default; // 0x00000001824BB460-0x00000001824BB640
		[BlackList] // 0x0000000189B653E0-0x0000000189B65420
		// [XID] // 0x0000000189B653E0-0x0000000189B65420
		public void RequestEndConversation(int trafficNodeId, uint npcId) {} // 0x00000001824BBE70-0x00000001824BC0D0
		[BlackList] // 0x0000000189B6FA40-0x0000000189B6FA80
		// [XID] // 0x0000000189B6FA40-0x0000000189B6FA80
		public void RequestBeginConversation(int trafficNodeId, uint npcId) {} // 0x00000001824BB640-0x00000001824BBC50
		// [XID] // 0x0000000189B7A0F0-0x0000000189B7A110
		private void RequestStartConvFreestyle(List<BaseEntity> entities) {} // 0x00000001824BC0D0-0x00000001824BC330
		// [XID] // 0x0000000189B81850-0x0000000189B81870
		private void RequestEndConvFreestyle(List<BaseEntity> entities) {} // 0x00000001824BBC50-0x00000001824BBE70
		// [XID] // 0x0000000189B88F30-0x0000000189B88F50
		public void AddBubbleConversationData(IConvData data) {} // 0x00000001824BACF0-0x00000001824BB000
		// [XID] // 0x0000000189B904C0-0x0000000189B904E0
		private void UpdateConversation() {} // 0x00000001824BC660-0x00000001824BC7E0
		// [XID] // 0x0000000189B978F0-0x0000000189B97910
		private void UpdatePendingConvList() {} // 0x00000001824BC7E0-0x00000001824BC9B0
		// [XID] // 0x0000000189B9ECD0-0x0000000189B9ECF0
		public void AddActionPointData(IActionPointData data) {} // 0x00000001824BAAD0-0x00000001824BACF0
		[BlackList] // 0x0000000189BA65E0-0x0000000189BA6620
		// [XID] // 0x0000000189BA65E0-0x0000000189BA6620
		public ActionPointData GetActionPointData(int actionType) => default; // 0x00000001824BB170-0x00000001824BB260
		[BlackList] // 0x0000000189BB0BD0-0x0000000189BB0C10
		// [XID] // 0x0000000189BB0BD0-0x0000000189BB0C10
		public List<int> GetActionPointFreestyleList(int actionType) => default; // 0x00000001824BB260-0x00000001824BB360
		// [XID] // 0x0000000189BBAF00-0x0000000189BBAF20
		public override void Tick() {} // 0x00000001824BC3D0-0x00000001824BC480
	}
}
