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
using UnityEngine;
using UnityEngine.UI;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class LuaManager : LuaBaseManager // TypeDefIndex: 21130
	{
		// Fields
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		private ILuaReload _luaReload; // 0x18
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		private ILuaHotFix _luaHotfix; // 0x20
		private ILuaMain _luaMain; // 0x28
		private ActorManager.ILuaActorManager _luaActorMgr; // 0x30
		private LuaTable _console; // 0x38
		private LuaTable _testGod; // 0x40
		public Action reloadCallback; // 0x48
		private LuaEnv.CustomLoader _customLoader; // 0x50
		private uint _gcCnt; // 0x58
		private const uint GC_FULL_GAP = 4294967295; // Metadata: 0x00AFEEAF
		public bool gcEnabled; // 0x5C
		private bool _isStarted; // 0x5D
		private bool _hotfixInited; // 0x5E
		private LuaTable _patchTable; // 0x60
		private LuaMemoryLeakChecker.Data _memoryData; // 0x68
		private float _leakCheckPoint; // 0x70
		private const float LEAK_CHECK_GAP = 5f; // Metadata: 0x00AFEEB3
		private bool _leakCheckStarted; // 0x74
	
		// Properties
		[BlackList] // 0x0000000189811090-0x00000001898110A0
		public ActorManager.ILuaActorManager luaActorMgr { /* [XID] */ /* 0x0000000189B107D0-0x0000000189B107F0 */ get => default; } // 0x0000000184F0FC90-0x0000000184F0FD30 
	
		// Nested types
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void RequireDelegate(string funcName); // TypeDefIndex: 21131; 0x0000000184F1D640-0x0000000184F1D8A0
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public interface ILuaMain // TypeDefIndex: 21132
		{
			// Methods
			void OnStart();
			void OnLevelLoad(uint sceneID);
			void OnRequire(string moduleName);
			void OnClearLevel();
		}
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public interface ILuaReload // TypeDefIndex: 21133
		{
			// Methods
			void Reload();
			ILuaHotFix GetHotfixFuncs();
		}
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public interface ILuaHotFix // TypeDefIndex: 21134
		{
			// Methods
			bool HotfixDispatch(string funcName, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args);
			LuaTable GetPatchTable();
		}
	
		// Constructors
		public LuaManager() {} // 0x0000000184F0FBE0-0x0000000184F0FC90
	
		// Methods
		// [XID] // 0x0000000189B178C0-0x0000000189B178E0
		private void InitLuaTest() {} // 0x0000000184F09430-0x0000000184F09500
		// [XID] // 0x0000000189B1F1C0-0x0000000189B1F1E0
		public void CallLuaTestFunc(string funcName, int index = 1 /* Metadata: 0x00AFEEA0 */) {} // 0x0000000184F083D0-0x0000000184F08640
		// [XID] // 0x0000000189B26A50-0x0000000189B26A70
		private void AddCustomLoader() {} // 0x0000000184F07F50-0x0000000184F080D0
		// [XID] // 0x0000000189B2DC20-0x0000000189B2DC40
		private void InitLuaConsole() {} // 0x0000000184F09360-0x0000000184F09430
		// [XID] // 0x0000000189B35090-0x0000000189B350B0
		public void CallLuaConsole(string funcName, string args) {} // 0x0000000184F081D0-0x0000000184F083D0
		// [XID] // 0x0000000189B3C940-0x0000000189B3C960
		private void GCTick() {} // 0x0000000184F08DB0-0x0000000184F08EF0
		// [XID] // 0x0000000189B446B0-0x0000000189B446D0
		public void ForceGC() {} // 0x0000000184F08CA0-0x0000000184F08DB0
		// [XID] // 0x0000000189B4BE60-0x0000000189B4BE80
		public void Start() {} // 0x0000000184F0F3D0-0x0000000184F0F490
		// [XID] // 0x00000001896985F0-0x0000000189698610
		public void LoadHotFixFile() {} // 0x0000000184F09D20-0x0000000184F09DD0
		// [XID] // 0x0000000189B5ACB0-0x0000000189B5ACD0
		public void FixAfterSilenceDownload() {} // 0x0000000184F08C00-0x0000000184F08CA0
		// [XID] // 0x0000000189B620F0-0x0000000189B62110
		public void FixAfterBundleDownload() {} // 0x0000000184F08B60-0x0000000184F08C00
		// [XID] // 0x0000000189B69D50-0x0000000189B69D70
		protected override void InitLua() {} // 0x0000000184F09500-0x0000000184F09710
		// [XID] // 0x0000000189B71280-0x0000000189B712A0
		private byte[] LoadCustomLuaFile(ref string filePath, out bool recycleBytes) {
			recycleBytes = default;
			return default;
		} // 0x0000000184F09B10-0x0000000184F09D20
		// [XID] // 0x0000000189B788E0-0x0000000189B78900
		private byte[] LoadCustomLuaFileByHash(long pathHash, out bool recycleBytes) {
			recycleBytes = default;
			return default;
		} // 0x0000000184F09A10-0x0000000184F09B10
		// [XID] // 0x0000000189B7FE30-0x0000000189B7FE50
		protected override void OnLoadLuaFinish() {} // 0x0000000184F09F70-0x0000000184F0A030
		// [XID] // 0x0000000189B87900-0x0000000189B87920
		private void StartLuaGlobal() {} // 0x0000000184F0F0C0-0x0000000184F0F240
		// [XID] // 0x0000000189B8EA40-0x0000000189B8EA60
		public void InitReloadHotfix() {} // 0x0000000184F09710-0x0000000184F098D0
		// [XID] // 0x0000000189B95EE0-0x0000000189B95F00
		public void ReloadDataHotfix() {} // 0x0000000184F0EDA0-0x0000000184F0EEB0
		// [XID] // 0x0000000189B9D4A0-0x0000000189B9D4C0
		public bool CallHotfixLuaFunc(string functionName, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000184F080D0-0x0000000184F081D0
		// [XID] // 0x0000000189BAC0D0-0x0000000189BAC0F0
		public LuaTable GetPatchTable() => default; // 0x0000000184F09140-0x0000000184F091E0
		// [XID] // 0x0000000189BB3890-0x0000000189BB38B0
		public void RefreshPatchTable() {} // 0x0000000184F0ECD0-0x0000000184F0EDA0
		public T GetILua<T>(string luaObj) => default;
		// [XID] // 0x0000000189BBAE20-0x0000000189BBAE40
		public void OnLevelLoad(uint sceneID) {} // 0x0000000184F09E80-0x0000000184F09F70
		// [XID] // 0x0000000189BC2E50-0x0000000189BC2E70
		public override void Tick() {} // 0x0000000184F0F700-0x0000000184F0F840
		// [XID] // 0x0000000189BCA5B0-0x0000000189BCA5D0
		public override void LateTick() {} // 0x0000000184F098D0-0x0000000184F09A10
		// [XID] // 0x0000000189BD1BE0-0x0000000189BD1C00
		public override void Require(string scriptPath) {} // 0x0000000184F0EFE0-0x0000000184F0F0C0
		// [XID] // 0x0000000189BD91D0-0x0000000189BD91F0
		public void Reload() {} // 0x0000000184F0EEB0-0x0000000184F0EFE0
		// [XID] // 0x00000001895E5D90-0x00000001895E5DB0
		public void Clear() {} // 0x0000000184F08710-0x0000000184F087D0
		// [XID] // 0x00000001899496F0-0x0000000189949710
		public void LuaGc() {} // 0x0000000184F09DD0-0x0000000184F09E80
		// [XID] // 0x00000001895F4D60-0x00000001895F4D80
		public override void ClearOnDisconnect() {} // 0x0000000184F08640-0x0000000184F08710
		// [XID] // 0x00000001895FC4F0-0x00000001895FC510
		public void StartMemoryLeakCheck() {} // 0x0000000184F0F240-0x0000000184F0F3D0
		// [XID] // 0x0000000189603E90-0x0000000189603EB0
		public void StopMemoryLeakCheck() {} // 0x0000000184F0F490-0x0000000184F0F530
		// [XID] // 0x000000018960B790-0x000000018960B7B0
		public void TickMemoryLeakCheck() {} // 0x0000000184F0F530-0x0000000184F0F700
		// [XID] // 0x0000000189612C20-0x0000000189612C40
		public float GetLuaMemoryMB() => default; // 0x0000000184F08EF0-0x0000000184F08FC0
		// [XID] // 0x000000018961A4E0-0x000000018961A500
		public string GetMemoryLeakReport(int maxLevel = 10 /* Metadata: 0x00AFEEA4 */) => default; // 0x0000000184F08FC0-0x0000000184F09140
		// [XID] // 0x0000000189621A60-0x0000000189621A80
		public void PrintMemoryLeakReport(int maxLevel = 10 /* Metadata: 0x00AFEEA8 */) {} // 0x0000000184F0EBB0-0x0000000184F0ECD0
		[LuaCallCSharp] // 0x0000000189629370-0x00000001896293B0
		// [XID] // 0x0000000189629370-0x00000001896293B0
		public void YieldCallback(object to_yield, Action callback, bool addToManager = true /* Metadata: 0x00AFEEAC */) {} // 0x0000000184F0FAA0-0x0000000184F0FBE0
		[LuaCallCSharp] // 0x0000000189633C30-0x0000000189633C70
		// [XID] // 0x0000000189633C30-0x0000000189633C70
		public Coroutine CoroutineCall(object to_yield, Action callback, bool addToManager = true /* Metadata: 0x00AFEEAD */) => default; // 0x0000000184F08920-0x0000000184F08A70
		[LuaCallCSharp] // 0x000000018963E320-0x000000018963E360
		// [XID] // 0x000000018963E320-0x000000018963E360
		public void CoroutineStop(Coroutine coroutine) {} // 0x0000000184F08A70-0x0000000184F08B60
		[DebuggerHidden] // 0x0000000189648A60-0x0000000189648AA0
		// [XID] // 0x0000000189648A60-0x0000000189648AA0
		private IEnumerator CoBody(object to_yield, Action callback, bool addToManager = true /* Metadata: 0x00AFEEAE */) => default; // 0x0000000184F087D0-0x0000000184F08920
		[LuaCallCSharp] // 0x0000000189653340-0x0000000189653380
		// [XID] // 0x0000000189653340-0x0000000189653380
		public void ImmediateCallback(object obj, Action callback) {} // 0x0000000184F091E0-0x0000000184F09360
		// [XID] // 0x000000018965DAF0-0x000000018965DB10
		public bool OnUIBeginStartup(BaseContext context) => default; // 0x0000000184F0C010-0x0000000184F0C290
		// [XID] // 0x0000000189B49EC0-0x0000000189B49EE0
		public bool OnUIEndStartup(BaseContext context) => default; // 0x0000000184F0E5D0-0x0000000184F0E850
		// [XID] // 0x000000018966C860-0x000000018966C880
		public bool OnUIBeginSetupView(BaseContext context) => default; // 0x0000000184F0BA30-0x0000000184F0BCB0
		// [XID] // 0x0000000189674670-0x0000000189674690
		public bool OnUIEndSetupView(BaseContext context) => default; // 0x0000000184F0DFF0-0x0000000184F0E270
		// [XID] // 0x000000018967BFA0-0x000000018967BFC0
		public bool OnUIBeginPostSetupView(BaseContext context) => default; // 0x0000000184F0B7B0-0x0000000184F0BA30
		// [XID] // 0x00000001899AB950-0x00000001899AB970
		public bool OnUIEndPostSetupView(BaseContext context) => default; // 0x0000000184F0DD70-0x0000000184F0DFF0
		// [XID] // 0x000000018968B1B0-0x000000018968B1D0
		public bool OnUIBeginHandleSetActiveEnabled(BaseContext context) => default; // 0x0000000184F0AE70-0x0000000184F0B0F0
		// [XID] // 0x0000000189692E90-0x0000000189692EB0
		public bool OnUIEndHandleSetActiveEnabled(BaseContext context) => default; // 0x0000000184F0D430-0x0000000184F0D6B0
		// [XID] // 0x000000018969A110-0x000000018969A130
		public bool OnUIBeginHandleSetActiveDisabled(BaseContext context) => default; // 0x0000000184F0ABF0-0x0000000184F0AE70
		// [XID] // 0x00000001896A1920-0x00000001896A1940
		public bool OnUIEndHandleSetActiveDisabled(BaseContext context) => default; // 0x0000000184F0D1B0-0x0000000184F0D430
		// [XID] // 0x00000001899B4720-0x00000001899B4740
		public bool OnUIBeginDestroy(BaseContext context) => default; // 0x0000000184F0A610-0x0000000184F0A890
		// [XID] // 0x0000000189A13EF0-0x0000000189A13F10
		public bool OnUIEndDestroy(BaseContext context) => default; // 0x0000000184F0CBD0-0x0000000184F0CE50
		// [XID] // 0x00000001896B7800-0x00000001896B7820
		public bool OnUIBeginDestroyForce(BaseContext context) => default; // 0x0000000184F0A390-0x0000000184F0A610
		// [XID] // 0x00000001896BE970-0x00000001896BE990
		public bool OnUIEndDestroyForce(BaseContext context) => default; // 0x0000000184F0C950-0x0000000184F0CBD0
		// [XID] // 0x00000001896C6270-0x00000001896C6290
		public bool OnUIBeginButtonClick(BaseContext context, Button button) => default; // 0x0000000184F0A030-0x0000000184F0A390
		// [XID] // 0x00000001896CD890-0x00000001896CD8B0
		public bool OnUIEndButtonClick(BaseContext context, Button button) => default; // 0x0000000184F0C5F0-0x0000000184F0C950
		// [XID] // 0x00000001896D4D00-0x00000001896D4D20
		public bool OnUIBeginInputFieldEndEdit(BaseContext context, InputField inputField) => default; // 0x0000000184F0B0F0-0x0000000184F0B450
		// [XID] // 0x00000001896DC360-0x00000001896DC380
		public bool OnUIEndInputFieldEndEdit(BaseContext context, InputField inputField) => default; // 0x0000000184F0D6B0-0x0000000184F0DA10
		// [XID] // 0x00000001896E3BB0-0x00000001896E3BD0
		public bool OnUIBeginDropdownValueChanged(BaseContext context, Dropdown dropdown) => default; // 0x0000000184F0A890-0x0000000184F0ABF0
		// [XID] // 0x00000001896EAF60-0x00000001896EAF80
		public bool OnUIEndDropdownValueChanged(BaseContext context, Dropdown dropdown) => default; // 0x0000000184F0CE50-0x0000000184F0D1B0
		// [XID] // 0x00000001896F2350-0x00000001896F2370
		public bool OnUIBeginToggleValueChanged(BaseContext context, Toggle toggle) => default; // 0x0000000184F0C290-0x0000000184F0C5F0
		// [XID] // 0x00000001896F9CD0-0x00000001896F9CF0
		public bool OnUIEndToggleValueChanged(BaseContext context, Toggle toggle) => default; // 0x0000000184F0E850-0x0000000184F0EBB0
		// [XID] // 0x00000001897014A0-0x00000001897014C0
		public bool OnUIBeginSliderValueChanged(BaseContext context, Slider slider) => default; // 0x0000000184F0BCB0-0x0000000184F0C010
		// [XID] // 0x0000000189708CA0-0x0000000189708CC0
		public bool OnUIEndSliderValueChanged(BaseContext context, Slider slider) => default; // 0x0000000184F0E270-0x0000000184F0E5D0
		// [XID] // 0x0000000189710540-0x0000000189710560
		public bool OnUIBeginPanelClick(BaseContext context, Transform trans) => default; // 0x0000000184F0B450-0x0000000184F0B7B0
		// [XID] // 0x0000000189717920-0x0000000189717940
		public bool OnUIEndPanelClick(BaseContext context, Transform trans) => default; // 0x0000000184F0DA10-0x0000000184F0DD70
	}
}
