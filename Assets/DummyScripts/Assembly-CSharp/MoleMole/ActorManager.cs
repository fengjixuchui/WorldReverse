/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class ActorManager : GlobalManager // TypeDefIndex: 21048
	{
		// Fields
		private bool _initialized; // 0x10
		private Dictionary<string, BaseActor> _actorDic; // 0x18
		private List<BaseActor> _actorList; // 0x20
		private Dictionary<uint, QuestActor> _questActorDic; // 0x28
		private Dictionary<int, List<LuaTask>> _taskId2TaskDic; // 0x30
		private Dictionary<string, Transform> _transDic; // 0x38
		private ILuaActorManager _luaActorMgr; // 0x40
		private Dictionary<string, int> _curPausedTag; // 0x48
		private Dictionary<string, List<string>> _action2TaskTags; // 0x50
	
		// Nested types
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public interface ILuaActorManager // TypeDefIndex: 21049
		{
			// Methods
			void InitGlobal();
			void InitSubGlobal();
			ILuaActor GetActor(string alias);
			ILuaActor CreateActor(string alias, string metaPath, bool isAutoStart);
			ILuaActor CreateActorWithData(ILuaActorInfoData data);
			ILuaActor CreateLocalActorWithData(ILuaActorInfoData data);
			ILuaActor CreateQuestActor(string alias, string metaPath, uint mainID, uint mainConfigID);
			void StartActor(string alias);
			void DestroyActor(string alias, bool isActorOnly);
			void DestroyActorMeta(string alias);
			void Destroy();
			void DestroySoft();
			void SetEntityHandler(string alias, uint runtimeID);
			uint GetEntityHandler(string alias);
			void DestroyEntityHandler(string alias);
			void NotifyBanDailyExternal(string alias);
			void NotifyStartDailyExternal(string alias);
			void ChangeActorAlias(ILuaActor actor, string alias);
		}
	
		// Constructors
		public ActorManager() {} // 0x0000000181A4A200-0x0000000181A4A370
	
		// Methods
		// [XID] // 0x000000018992AA80-0x000000018992AAA0
		private List<LuaTask> GetTaskListByTaskId(int taskQueueID) => default; // 0x0000000181A47930-0x0000000181A47A60
		// [XID] // 0x00000001899320C0-0x00000001899320E0
		public void AddTaskByTaskId(int taskQueueID, LuaTask task) {} // 0x0000000181A44280-0x0000000181A44370
		// [XID] // 0x0000000189B24770-0x0000000189B24790
		public void RemoveTaskByTaskId(int taskQueueID, LuaTask task) {} // 0x0000000181A49750-0x0000000181A49850
		// [XID] // 0x0000000189940C40-0x0000000189940C60
		public void FinishTaskByTaskId(int taskQueueID) {} // 0x0000000181A46F20-0x0000000181A47040
		// [XID] // 0x0000000189948600-0x0000000189948620
		public bool FinishAndClearAllTaskByType(int taskQueueID, LuaTaskType taskType) => default; // 0x0000000181A46CE0-0x0000000181A46F20
		// [XID] // 0x000000018994FD50-0x000000018994FD70
		public Transform GetTransByAlias(string alias) => default; // 0x0000000181A47C30-0x0000000181A47D20
		// [XID] // 0x0000000189957340-0x0000000189957360
		public void AddTransByAlias(string alias, Transform trans) {} // 0x0000000181A44370-0x0000000181A44530
		// [XID] // 0x000000018995EDD0-0x000000018995EDF0
		public void RemoveTransByAlias(string alias, Transform trans) {} // 0x0000000181A49850-0x0000000181A499F0
		// [IDTag] // 0x0000000189966690-0x00000001899666D0
		// [XID] // 0x0000000189966690-0x00000001899666D0
		public BaseActor GetActor(string alias) => default; // 0x0000000181A47120-0x0000000181A47240
		// [IDTag] // 0x00000001899711A0-0x00000001899711E0
		// [XID] // 0x00000001899711A0-0x00000001899711E0
		public BaseActor GetActor(BaseEntity tarEntity) => default; // 0x0000000181A47240-0x0000000181A47770
		// [XID] // 0x0000000189706A40-0x0000000189706A60
		public QuestActor GetQuestActor(uint mainID) => default; // 0x0000000181A47840-0x0000000181A47930
		// [XID] // 0x00000001899830B0-0x00000001899830D0
		public override void ReloadRes() {} // 0x0000000181A49250-0x0000000181A492F0
		// [XID] // 0x000000018998A800-0x000000018998A820
		public void AddActor(BaseActor actor) {} // 0x0000000181A43D70-0x0000000181A43F50
		// [XID] // 0x0000000189992100-0x0000000189992120
		public void AddQuestActor(BaseActor actor) {} // 0x0000000181A44130-0x0000000181A44280
		// [XID] // 0x0000000189B2BBC0-0x0000000189B2BBE0
		public void RemoveActor(BaseActor actor) {} // 0x0000000181A492F0-0x0000000181A49400
		// [XID] // 0x0000000189A10B30-0x0000000189A10B50
		public void ChangeActorAlias(BaseActor actor, string alias) {} // 0x0000000181A44530-0x0000000181A44710
		// [XID] // 0x0000000189B3AC50-0x0000000189B3AC70
		private void RemoveQuestActor(BaseActor actor) {} // 0x0000000181A49600-0x0000000181A49750
		// [XID] // 0x00000001899B0930-0x00000001899B0950
		public void DestroyByAlias(string alias, bool isActorOnly = true /* Metadata: 0x00AFED59 */) {} // 0x0000000181A462F0-0x0000000181A463E0
		// [XID] // 0x00000001899B7CF0-0x00000001899B7D10
		public override void Init() {} // 0x0000000181A48510-0x0000000181A485B0
		[BlackList] // 0x00000001899BF6D0-0x00000001899BF710
		// [XID] // 0x00000001899BF6D0-0x00000001899BF710
		public void InjectLuaActorMgr(ILuaActorManager luaActorMgr) {} // 0x0000000181A485B0-0x0000000181A48660
		// [XID] // 0x00000001899C9CE0-0x00000001899C9D00
		public override void Tick() {} // 0x0000000181A49E30-0x0000000181A49F70
		// [XID] // 0x00000001899D1580-0x00000001899D15A0
		private void TickActor() {} // 0x0000000181A49CD0-0x0000000181A49E30
		// [XID] // 0x00000001899D8AF0-0x00000001899D8B10
		public void FireEvent(ActorEvent evt) {} // 0x0000000181A47040-0x0000000181A47120
		// [XID] // 0x00000001899E0160-0x00000001899E0180
		private void DispatchEvent(ActorEvent evt) {} // 0x0000000181A466D0-0x0000000181A469C0
		// [XID] // 0x00000001899E7C80-0x00000001899E7CA0
		public override void Destroy() {} // 0x0000000181A46580-0x0000000181A466D0
		// [XID] // 0x00000001899EF080-0x00000001899EF0A0
		private void DestroyOnDisconnect() {} // 0x0000000181A464B0-0x0000000181A46580
		// [XID] // 0x00000001899F6A50-0x00000001899F6A70
		private void ClearSoft() {} // 0x0000000181A44A70-0x0000000181A44B30
		// [XID] // 0x00000001899FE030-0x00000001899FE050
		private void Clear() {} // 0x0000000181A44B30-0x0000000181A44BF0
		// [XID] // 0x0000000189A05950-0x0000000189A05970
		public void InitLuaGlobal() {} // 0x0000000181A47D20-0x0000000181A47E20
		// [XID] // 0x0000000189A0CC20-0x0000000189A0CC40
		public void InitLuaSubGlobal() {} // 0x0000000181A47E20-0x0000000181A47EE0
		// [XID] // 0x0000000189A14560-0x0000000189A14580
		public void PostInitLuaGlobal() {} // 0x0000000181A48EE0-0x0000000181A49090
		// [XID] // 0x0000000189A1B810-0x0000000189A1B830
		public void PostEnterSceneLuaGlobal() {} // 0x0000000181A48D20-0x0000000181A48EE0
		// [XID] // 0x0000000189A23200-0x0000000189A23220
		private void LocalEntityRewind() {} // 0x0000000181A48660-0x0000000181A48770
		// [XID] // 0x0000000189A2A400-0x0000000189A2A420
		private void RefreshCommonInfoData() {} // 0x0000000181A49140-0x0000000181A49250
		// [XID] // 0x0000000189A31870-0x0000000189A31890
		public void ReconnectInitLuaGlobal() {} // 0x0000000181A49090-0x0000000181A49140
		// [XID] // 0x0000000189A393B0-0x0000000189A393D0
		public void CreateActor(string alias, string metaPath, bool isAutoStart) {} // 0x0000000181A45170-0x0000000181A45270
		[BlackList] // 0x0000000189A40B50-0x0000000189A40B90
		// [XID] // 0x0000000189A40B50-0x0000000189A40B90
		public ILuaActor CreateActorWithInfo(BaseEntity entity, string alias, string metaPath, uint configID, uint dataIndex, Vector3 pos, Vector3 dir, int sceneID, uint roomID, uint questID, bool checkHide, bool clearCmd, bool isAutoStart) => default; // 0x0000000181A44BF0-0x0000000181A45030
		[BlackList] // 0x0000000189A4B1A0-0x0000000189A4B1E0
		// [XID] // 0x0000000189A4B1A0-0x0000000189A4B1E0
		public ILuaActor CreateLocalActorWithInfo(BaseEntity entity, string alias, string metaPath, uint configID, uint dataIndex, Vector3 pos, Vector3 dir, int sceneID, uint roomID, uint questID, bool checkHide, bool clearCmd) => default; // 0x0000000181A45780-0x0000000181A45A90
		[BlackList] // 0x0000000189A55A40-0x0000000189A55A80
		// [XID] // 0x0000000189A55A40-0x0000000189A55A80
		public ILuaActor CreateActorWithLocalInfo(LocalEntityInfoData infoData) => default; // 0x0000000181A45030-0x0000000181A45170
		// [XID] // 0x0000000189A60400-0x0000000189A60420
		public void CreateQuestActor(uint mainID, uint mainConfigID, string alias = null, string metaPath = null) {} // 0x0000000181A46020-0x0000000181A46140
		// [XID] // 0x0000000189A67F90-0x0000000189A67FB0
		public void CreateCutsceneActor(string metaPath, BaseCutsceneTask task, CutsceneManager manager) {} // 0x0000000181A45270-0x0000000181A45470
		// [XID] // 0x0000000189A6F360-0x0000000189A6F380
		public ILuaActor CreateGadgetActor(ILuaActorInfoData actorInfoData) => default; // 0x0000000181A45470-0x0000000181A455D0
		// [XID] // 0x0000000189A76BA0-0x0000000189A76BC0
		public ILuaActor CreateInterActor(string alias, string metaPath) => default; // 0x0000000181A455D0-0x0000000181A45780
		// [XID] // 0x0000000189A7E520-0x0000000189A7E540
		public void StartActor(string alias) {} // 0x0000000181A49C00-0x0000000181A49CD0
		// [XID] // 0x0000000189A85E10-0x0000000189A85E30
		public void DestroyActor(string alias, bool isActorOnly = true /* Metadata: 0x00AFED5A */) {} // 0x0000000181A46210-0x0000000181A462F0
		// [XID] // 0x0000000189A8D6F0-0x0000000189A8D710
		public void DestroyActorMeta(string alias) {} // 0x0000000181A46140-0x0000000181A46210
		// [XID] // 0x0000000189A94CB0-0x0000000189A94CD0
		public void SetEntityHandler(string alias, uint runtimeID) {} // 0x0000000181A49B10-0x0000000181A49C00
		// [XID] // 0x0000000189A9C4F0-0x0000000189A9C510
		public uint GetEntityHandler(string alias) => default; // 0x0000000181A47770-0x0000000181A47840
		// [XID] // 0x0000000189A97690-0x0000000189A976B0
		public void DestroyEntityHandler(string alias) {} // 0x0000000181A463E0-0x0000000181A464B0
		// [XID] // 0x0000000189A71950-0x0000000189A71970
		public void NotifyBanDailyExternal(string alias) {} // 0x0000000181A48770-0x0000000181A48840
		// [XID] // 0x0000000189AE2B20-0x0000000189AE2B40
		public void NotifyStartDailyExternal(string alias) {} // 0x0000000181A48840-0x0000000181A48910
		// [XID] // 0x0000000189ABA7C0-0x0000000189ABA7E0
		public override void ClearOnLevelDestroy() {} // 0x0000000181A44870-0x0000000181A449C0
		// [XID] // 0x0000000189AC2090-0x0000000189AC20B0
		public override void ClearOnDisconnect() {} // 0x0000000181A447D0-0x0000000181A44870
		// [XID] // 0x0000000189AC96C0-0x0000000189AC96E0
		public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFED5B */) {} // 0x0000000181A44710-0x0000000181A447D0
		// [XID] // 0x0000000189AD1090-0x0000000189AD10B0
		public void CreateLocalMonster(string alias, uint configID, uint level, Vector3 bornPos, float yaw, uint dropID, float scale, bool isElite, List<uint> affixList) {} // 0x0000000181A45D60-0x0000000181A46020
		// [XID] // 0x0000000189AD8E30-0x0000000189AD8E50
		public void CreateLocalGadget(string alias, uint configID, Vector3 bornPos, Vector3 bornEuler) {} // 0x0000000181A45A90-0x0000000181A45D60
		// [XID] // 0x0000000189AE0940-0x0000000189AE0960
		public List<string> GetTaskTagsByAction(string name) => default; // 0x0000000181A47B40-0x0000000181A47C30
		// [XID] // 0x0000000189AE7E10-0x0000000189AE7E30
		private void InitTaskTag() {} // 0x0000000181A47EE0-0x0000000181A48510
		// [XID] // 0x0000000189AEFB40-0x0000000189AEFB60
		public void PlayerDie(bool enable) {} // 0x0000000181A48B80-0x0000000181A48C50
		// [XID] // 0x0000000189AF7020-0x0000000189AF7040
		public void PlayerInCombat(bool enable) {} // 0x0000000181A48C50-0x0000000181A48D20
		// [XID] // 0x0000000189AFE630-0x0000000189AFE650
		public void OpenPage(bool enable, BasePageContext page) {} // 0x0000000181A48910-0x0000000181A48A60
		// [XID] // 0x0000000189B05F00-0x0000000189B05F20
		public void Transmiting(bool enable) {} // 0x0000000181A49F70-0x0000000181A4A040
		// [XID] // 0x0000000189B0D610-0x0000000189B0D630
		public void EnterDungeon(bool enable) {} // 0x0000000181A46C10-0x0000000181A46CE0
		// [XID] // 0x0000000189B14A90-0x0000000189B14AB0
		private void PauseByTag(string tag) {} // 0x0000000181A48A60-0x0000000181A48B80
		// [XID] // 0x0000000189B1C450-0x0000000189B1C470
		private void ResumeByTag(string tag) {} // 0x0000000181A499F0-0x0000000181A49B10
		// [XID] // 0x0000000189B239A0-0x0000000189B239C0
		private void AddPauseTag(string tag) {} // 0x0000000181A43F50-0x0000000181A44130
		// [XID] // 0x0000000189772210-0x0000000189772230
		private void RemovePauseTag(string tag) {} // 0x0000000181A49400-0x0000000181A49600
		// [XID] // 0x0000000189B32200-0x0000000189B32220
		private void ClearPauseTag() {} // 0x0000000181A449C0-0x0000000181A44A70
		// [XID] // 0x0000000189B39B90-0x0000000189B39BB0
		public int GetTaskTagPauseCount(string taskTag) => default; // 0x0000000181A47A60-0x0000000181A47B40
		[Preserve] // 0x0000000189B41450-0x0000000189B41490
		// [XID] // 0x0000000189B41450-0x0000000189B41490
		public override string Dump(string tag) => default; // 0x0000000181A469C0-0x0000000181A46C10
	}
}
