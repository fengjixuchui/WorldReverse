/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public class GlobalActor : BaseActor, IAutoAllocRecycle // TypeDefIndex: 20203
	{
		// Fields
		protected LevelEntity _levelEntity; // 0xE0
		protected LevelTimeManager _levelTimeMgr; // 0xE8
		protected EnviroSky _enviroSky; // 0xF0
		protected LuaBtnTransmitTask _curBtnTransmitTask; // 0x118
	
		// Events
		protected event Action<int> _OnWeatherChanged;
		protected event LevelTimeManager.isDayCB _OnDayCallBack;
		protected event LevelTimeManager.isNightCB _OnNightCallBack;
		protected event LevelTimeManager.HourPassed _OnHourPassedCallBack;
	
		// Constructors
		public GlobalActor() {} // 0x0000000181F8B470-0x0000000181F8B510
	
		// Methods
		[BlackList] // 0x00000001899606A0-0x00000001899606E0
		// [XID] // 0x00000001899606A0-0x00000001899606E0
		public override void AutoAllocTypeFields() {} // 0x0000000181F88570-0x0000000181F88610
		[BlackList] // 0x000000018996AD80-0x000000018996ADC0
		// [XID] // 0x000000018996AD80-0x000000018996ADC0
		public override void AutoRecycleTypeFields() {} // 0x0000000181F88610-0x0000000181F886F0
		[BlackList] // 0x0000000189975730-0x0000000189975770
		// [XID] // 0x0000000189975730-0x0000000189975770
		public override void ReturnToObjectPool() {} // 0x0000000181F8A970-0x0000000181F8AA10
		// [XID] // 0x00000001899BC730-0x00000001899BC750
		public void ClearBtnTransmitTask() {} // 0x0000000181F88DD0-0x0000000181F88E70
		// [XID] // 0x00000001899C40A0-0x00000001899C40C0
		public virtual void InitGlobal() {} // 0x0000000181F899E0-0x0000000181F89CA0
		// [XID] // 0x0000000189BBBE60-0x0000000189BBBE80
		protected void OnWeatherChange(EnviroWeatherPreset weatherType) {} // 0x0000000181F8A2C0-0x0000000181F8A3A0
		// [XID] // 0x00000001899D2D10-0x00000001899D2D30
		protected void OnDayCallBack() {} // 0x0000000181F8A080-0x0000000181F8A140
		// [XID] // 0x0000000189B957A0-0x0000000189B957C0
		protected void OnNightCallBack() {} // 0x0000000181F8A200-0x0000000181F8A2C0
		// [XID] // 0x00000001899E1DE0-0x00000001899E1E00
		protected void OnHourPassedCallBack(int hour) {} // 0x0000000181F8A140-0x0000000181F8A200
		// [XID] // 0x00000001899E91D0-0x00000001899E91F0
		public override void Destroy(bool isActorOnly) {} // 0x0000000181F89050-0x0000000181F892C0
		// [XID] // 0x00000001899F0A50-0x00000001899F0A70
		public void RegisterDayCallback(LevelTimeManager.isDayCB dayCallback) {} // 0x0000000181F8A6B0-0x0000000181F8A760
		// [XID] // 0x00000001899F8190-0x00000001899F81B0
		public void UnregisterDayCallback(LevelTimeManager.isDayCB dayCallback) {} // 0x0000000181F8B1B0-0x0000000181F8B260
		// [XID] // 0x00000001899FF820-0x00000001899FF840
		public void RegisterNightCallback(LevelTimeManager.isNightCB nightCallback) {} // 0x0000000181F8A810-0x0000000181F8A8C0
		// [XID] // 0x0000000189A07000-0x0000000189A07020
		public void UnregisterNightCallback(LevelTimeManager.isNightCB nightCallback) {} // 0x0000000181F8B310-0x0000000181F8B3C0
		// [XID] // 0x0000000189A0E6B0-0x0000000189A0E6D0
		public void RegisterHourCallback(LevelTimeManager.HourPassed hourPassedCallback) {} // 0x0000000181F8A760-0x0000000181F8A810
		// [XID] // 0x0000000189A15CE0-0x0000000189A15D00
		public void UnregisterHourCallback(LevelTimeManager.HourPassed hourPassedCallback) {} // 0x0000000181F8B260-0x0000000181F8B310
		// [XID] // 0x0000000189A1D170-0x0000000189A1D190
		public bool GetIsNight() => default; // 0x0000000181F897E0-0x0000000181F898A0
		// [XID] // 0x0000000189A24750-0x0000000189A24770
		public void LoadSectorByPos(Vector3 worldPos, Action onFinish) {} // 0x0000000181F89ED0-0x0000000181F8A080
		// [XID] // 0x0000000189A2BC30-0x0000000189A2BC50
		public void RegisterWeatherCallback(Action<int> weatherCallback) {} // 0x0000000181F8A8C0-0x0000000181F8A970
		// [XID] // 0x0000000189A33230-0x0000000189A33250
		public void UnregisterWeatherCallback(Action<int> weatherCallback) {} // 0x0000000181F8B3C0-0x0000000181F8B470
		// [XID] // 0x0000000189A3AB40-0x0000000189A3AB60
		public bool ChangeDefaultWeahter(string weatherName) => default; // 0x0000000181F88800-0x0000000181F88970
		// [XID] // 0x0000000189A42410-0x0000000189A42430
		public bool ChangeWeather(string weatherName) => default; // 0x0000000181F88AF0-0x0000000181F88C60
		// [XID] // 0x0000000189A49A60-0x0000000189A49A80
		public bool LeaveWeather() => default; // 0x0000000181F89D80-0x0000000181F89ED0
		// [XID] // 0x0000000189A51390-0x0000000189A513B0
		public void StopLocalAvatar() {} // 0x0000000181F8AD20-0x0000000181F8AE30
		// [XID] // 0x0000000189A58980-0x0000000189A589A0
		public bool CreateLimitRegion(string name) => default; // 0x0000000181F88E70-0x0000000181F88F60
		// [XID] // 0x0000000189A604A0-0x0000000189A604C0
		public void DestroyLimitRegion(string name) {} // 0x0000000181F88F60-0x0000000181F89050
		// [XID] // 0x0000000189A68090-0x0000000189A680B0
		public Vector3 CheckNeedTrans(Vector3 pos, float offset) => default; // 0x0000000181F88C60-0x0000000181F88DD0
		// [XID] // 0x0000000189A6F480-0x0000000189A6F4A0
		public float GetLimitRegionDis(Vector3 pos, float radius) => default; // 0x0000000181F898A0-0x0000000181F899E0
		// [XID] // 0x0000000189A76C80-0x0000000189A76CA0
		public void ChangeDay24Time(float toTime, bool force = false /* Metadata: 0x00AFD349 */) {} // 0x0000000181F886F0-0x0000000181F88800
		// [XID] // 0x0000000189A7E660-0x0000000189A7E680
		public bool StartGuide(string name) => default; // 0x0000000181F8ABF0-0x0000000181F8AD20
		// [XID] // 0x0000000189A85F50-0x0000000189A85F70
		public bool EndGuide(string name) => default; // 0x0000000181F89570-0x0000000181F896A0
		// [XID] // 0x0000000189A8D850-0x0000000189A8D870
		public void FinishAllNarratorTask() {} // 0x0000000181F896A0-0x0000000181F897E0
		// [XID] // 0x0000000189A94DD0-0x0000000189A94DF0
		public void PlayerBackButtonOn(IBtnTransmitData data) {} // 0x0000000181F8A460-0x0000000181F8A5A0
		// [XID] // 0x0000000189A9C670-0x0000000189A9C690
		public void PlayerBackButtonOff(IBtnTransmitData data) {} // 0x0000000181F8A3A0-0x0000000181F8A460
		[BlackList] // 0x0000000189AA3DA0-0x0000000189AA3DE0
		// [XID] // 0x0000000189AA3DA0-0x0000000189AA3DE0
		public bool DoBtnTransmit() => default; // 0x0000000181F892C0-0x0000000181F89390
		// [XID] // 0x0000000189AAE4F0-0x0000000189AAE510
		public void PlayerEnterDungeon(uint pointId, uint dungeonId) {} // 0x0000000181F8A5A0-0x0000000181F8A6B0
		// [XID] // 0x0000000189AB5D00-0x0000000189AB5D20
		public void ChangeToHero() {} // 0x0000000181F88970-0x0000000181F88AF0
		// [XID] // 0x0000000189ABD850-0x0000000189ABD870
		public bool IsHeroMale() => default; // 0x0000000181F89CA0-0x0000000181F89D80
		// [XID] // 0x0000000189AC5330-0x0000000189AC5350
		public void SpawnAttach(string attachName, uint cfgId) {} // 0x0000000181F8AB00-0x0000000181F8ABF0
		// [XID] // 0x0000000189ACC7E0-0x0000000189ACC800
		public void UnSpawnAttach(string attachName, uint cfgId) {} // 0x0000000181F8B0C0-0x0000000181F8B1B0
		// [XID] // 0x0000000189AD4510-0x0000000189AD4530
		public void SpawnAttachHeroEntity(string attachName, uint cfgId) {} // 0x0000000181F8AA10-0x0000000181F8AB00
		// [XID] // 0x0000000189ADBEE0-0x0000000189ADBF00
		public void UnSpawnAttachHeroEntity(string attachName, uint cfgId) {} // 0x0000000181F8AFD0-0x0000000181F8B0C0
		// [XID] // 0x0000000189AE3830-0x0000000189AE3850
		public void DungeonFogEffects(bool enable, string cameraFogEffectName, string playerFogEffectName, Vector3 localOffSet) {} // 0x0000000181F89390-0x0000000181F89570
	}
}
