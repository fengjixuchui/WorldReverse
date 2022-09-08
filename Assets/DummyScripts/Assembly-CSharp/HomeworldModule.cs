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
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeworldModule : BaseModule // TypeDefIndex: 21522
{
	// Fields
	public const uint HOME_COIN_ITEM_ID = 204; // Metadata: 0x00AFF8BE
	public const uint HOME_EXP_ITEM_ID = 121; // Metadata: 0x00AFF8C2
	public const uint HOME_SAVE_TEMP_VERSION = 1; // Metadata: 0x00AFF8C6
	private HomeworldSaveDataEx _lastSaveData; // 0x18
	private uint MaxHomeworldUnlockBlockCount; // 0x20
	public const uint EnterInteriorGadgetId = 77015006; // Metadata: 0x00AFF8CA
	public const uint ExitInteriorGadgetId = 77015007; // Metadata: 0x00AFF8CE
	public const uint djinnGroupId = 999999900; // Metadata: 0x00AFF8D2
	public uint[] djinnGadgetIds; // 0x28
	public uint[] djinnConfigIds; // 0x30
	public const uint djinnConfigIdWeekend = 2000; // Metadata: 0x00AFF8D6
	public GadgetEntity djinnGadgetEntity; // 0x38
	public GadgetEntity djinnGadgetEntityWeekend; // 0x40
	private Coroutine _checkDjinnGadget; // 0x48
	private const float CHECK_INTERVAL = 5f; // Metadata: 0x00AFF8DA
	private List<uint> _unlockedModuleIdList; // 0x60
	private List<uint> _levelUpRewardGotLevelList; // 0x68
	private HomeModuleSnapshot _currHomeModuleSnapshot; // 0x78
	private Dictionary<uint, uint> furnitureArrangeCountDict; // 0x80
	private HashSet<uint> _unlockedFurnitureMakeSet; // 0x88
	private Dictionary<uint, FurnitureBuildSlotData> _furnitureBuildSlotDict; // 0x90
	private RepeatedMessageField<FurnitureMakeHelpData> _furnitureMakeHelpData; // 0x98
	private RepeatedMessageField<FurnitureMakeBeHelpedData> _furnitureMakeHelpedData; // 0xA0
	private Dictionary<uint, uint> _furnitureMakeTimesDict; // 0xA8
	private bool _hasFinishedMake; // 0xB0
	private HomeworldUltiliyData _homeUtilData; // 0xB8
	private HashSet<uint> _unlockedFurnitureSuiteSet; // 0xC0
	private HashSet<uint> _freezeFurnitureSet; // 0xC8

	// Properties
	public HomeBasicInfo homeBasicInfo { /* [XID] */ /* 0x000000018967D660-0x000000018967D6A0 */ get; /* [XID] */ /* 0x0000000189688240-0x0000000189688280 */ private set; } // 0x000000018159C760-0x000000018159C7C0 0x0000000181597CD0-0x0000000181597D30
	public HomeLimitedShopInfo homeLimitedShopInfo { /* [XID] */ /* 0x0000000189692DF0-0x0000000189692E10 */ get => default; } // 0x00000001815A0740-0x00000001815A0910 
	public HomeComfortInfoNotify homeComfortInfoNotify { /* [XID] */ /* 0x000000018985C650-0x000000018985C690 */ get; /* [XID] */ /* 0x0000000189866970-0x00000001898669B0 */ private set; } // 0x00000001815A3100-0x00000001815A3160 0x000000018159B100-0x000000018159B160
	public HomeResourceNotify homeResourceNotify { /* [XID] */ /* 0x0000000189870E00-0x0000000189870E40 */ get; /* [XID] */ /* 0x000000018987B7C0-0x000000018987B800 */ private set; } // 0x00000001815A2610-0x00000001815A2670 0x00000001815A0EB0-0x00000001815A0F10
	public uint homeworldLevel { /* [XID] */ /* 0x0000000189BCB480-0x0000000189BCB4A0 */ get => default; } // 0x0000000181599A90-0x0000000181599C70 
	public ulong homeworldExp { /* [XID] */ /* 0x000000018988D060-0x000000018988D080 */ get => default; } // 0x00000001815A2FC0-0x00000001815A3100 
	public uint chooseModuleId { /* [XID] */ /* 0x000000018989BCC0-0x000000018989BCE0 */ get => default; } // 0x000000018159EA40-0x000000018159EB80 
	public List<uint> unlockedModuleIdList { /* [XID] */ /* 0x000000018995ED10-0x000000018995ED30 */ get => default; } // 0x000000018159B260-0x000000018159B300 
	public List<uint> levelUpRewardGotLevelList { /* [XID] */ /* 0x00000001899665B0-0x00000001899665D0 */ get => default; } // 0x00000001815A2E30-0x00000001815A2ED0 
	public HomeSnapshot currHomeSnapshot { /* [XID] */ /* 0x000000018996D970-0x000000018996D9B0 */ get; /* [XID] */ /* 0x0000000189978A90-0x0000000189978AD0 */ set; } // 0x00000001815A2120-0x00000001815A2180 0x00000001815A2370-0x00000001815A23D0
	public HomeModuleSnapshot currHomeModuleSnapshot { /* [XID] */ /* 0x0000000189982FF0-0x0000000189983010 */ get => default; } // 0x000000018159CCA0-0x000000018159CF90 
	public HomeSceneSnapshot currExteriorSnapshot { /* [XID] */ /* 0x000000018998A7A0-0x000000018998A7C0 */ get => default; } // 0x000000018159B6C0-0x000000018159B8C0 
	public uint correspondingSceneID { /* [XID] */ /* 0x0000000189992040-0x0000000189992060 */ get => default; } // 0x00000001815A12B0-0x00000001815A1460 
	public bool haveNewModuleToBeUnlocked { /* [XID] */ /* 0x0000000189BC3C50-0x0000000189BC3C70 */ get => default; } // 0x0000000181599300-0x0000000181599410 
	public HashSet<uint> unlockedFurnitureMakeSet { /* [XID] */ /* 0x00000001899F3AB0-0x00000001899F3AD0 */ get => default; } // 0x000000018159C220-0x000000018159C2D0 
	public Dictionary<uint, FurnitureBuildSlotData> furnitureBuildSlotDict { /* [XID] */ /* 0x00000001899FB390-0x00000001899FB3B0 */ get => default; } // 0x0000000181593AE0-0x0000000181593B90 
	public RepeatedMessageField<FurnitureMakeHelpData> furnitureMakeHelpData { /* [XID] */ /* 0x0000000189A025B0-0x0000000189A025D0 */ get => default; } // 0x000000018159A9C0-0x000000018159AA70 
	public RepeatedMessageField<FurnitureMakeBeHelpedData> furnitureMakeHelpedData { /* [XID] */ /* 0x0000000189A09D40-0x0000000189A09D60 */ get => default; } // 0x0000000181594300-0x00000001815943B0 
	public Dictionary<uint, uint> furnitureMakeTimesDict { /* [XID] */ /* 0x0000000189A11580-0x0000000189A115A0 */ get => default; } // 0x000000018159C6B0-0x000000018159C760 
	public bool HasFinishedFurnitureMakeNow { /* [XID] */ /* 0x0000000189A18990-0x0000000189A189B0 */ get => default; } // 0x000000018159DDF0-0x000000018159E020 

	// Nested types
	public enum BuildDataRefreshReason // TypeDefIndex: 21523
	{
		NoReasonForceRefresh = 0,
		StartBuild = 1,
		CancelBuild = 2,
		GetHelped = 3,
		GetFinishFurniture = 4,
		MakeCountUpdate = 5
	}

	public class HomeworldUltiliyData // TypeDefIndex: 21524
	{
		// Fields
		public HomeSceneSnapshot snapShot; // 0x10
		public HomeFurnitureData mainHouseFurnitureData; // 0x18
		public HomeWorldFurnitureExcelConfig mainHouseExcelConfig; // 0x20

		// Constructors
		public HomeworldUltiliyData() {} // 0x00000001815AD560-0x00000001815AD5C0
	}

	// Constructors
	public HomeworldModule() {} // 0x00000001815A36A0-0x00000001815A38E0

	// Methods
	// [XID] // 0x000000018969A0B0-0x000000018969A0D0
	public override void ClearOnBackHome() {} // 0x000000018159A8E0-0x000000018159A9C0
	// [XID] // 0x00000001896A18C0-0x00000001896A18E0
	public override bool OnPacket(Packet pkt) => default; // 0x0000000181594E10-0x0000000181595350
	// [XID] // 0x00000001896A8D80-0x00000001896A8DA0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001815A29C0-0x00000001815A2B50
	// [XID] // 0x00000001896AFDB0-0x00000001896AFDD0
	private void OnLevelLoadFinish() {} // 0x0000000181594940-0x0000000181594A90
	// [XID] // 0x000000018962D160-0x000000018962D180
	public bool IsHomeworld() => default; // 0x000000018159ECD0-0x000000018159EDD0
	// [XID] // 0x00000001896BE910-0x00000001896BE930
	public bool IsHomeworldExterior() => default; // 0x00000001815A18E0-0x00000001815A19F0
	// [XID] // 0x00000001896C6210-0x00000001896C6230
	public bool IsHomeworldInterior() => default; // 0x00000001815A0150-0x00000001815A0250
	// [XID] // 0x00000001896CD830-0x00000001896CD850
	public void TryEnterHomeworldReq(uint worldUID) {} // 0x0000000181594200-0x0000000181594300
	// [XID] // 0x00000001896D4C60-0x00000001896D4C80
	public void TryExitHomeworldReq() {} // 0x00000001815A0AF0-0x00000001815A0BD0
	// [XID] // 0x00000001896DC2E0-0x00000001896DC300
	public void EnterHomeworld() {} // 0x000000018159E3A0-0x000000018159E440
	// [XID] // 0x00000001896E3AB0-0x00000001896E3AD0
	public void ExitHomeworld() {} // 0x0000000181599870-0x0000000181599920
	// [XID] // 0x00000001896EAEA0-0x00000001896EAEC0
	public void TryEnterHomeworldEditMode(bool isEnter) {} // 0x0000000181593B90-0x0000000181593C90
	// [XID] // 0x00000001896F2270-0x00000001896F2290
	public void TryEnterHomeworldInterior() {} // 0x0000000181594BA0-0x0000000181594C90
	// [XID] // 0x00000001896F9C10-0x00000001896F9C30
	public void TryExitHomeworldInterior() {} // 0x0000000181597260-0x0000000181597350
	// [XID] // 0x0000000189701440-0x0000000189701460
	public void UploadHomeworldBlockDataReq(HomeworldSaveDataEx saveData, bool saveToDefault = false /* Metadata: 0x00AFF8BD */) {} // 0x000000018159F0E0-0x000000018159FE00
	// [XID] // 0x0000000189708C40-0x0000000189708C60
	public void GetHomeGetBasicInfoReq() {} // 0x000000018159BCD0-0x000000018159BDB0
	// [XID] // 0x00000001897104E0-0x0000000189710500
	public void GetHomeworldArrangementInfoReq(uint sceneID) {} // 0x000000018159D690-0x000000018159D8B0
	// [XID] // 0x0000000189717860-0x0000000189717880
	private void OnTryEnterHomeRsp(TryEnterHomeRsp rsp) {} // 0x000000018159CF90-0x000000018159D1B0
	// [XID] // 0x000000018971F390-0x000000018971F3B0
	private void OnHomeUpdateArrangementInfoRsp(HomeUpdateArrangementInfoRsp rsp) {} // 0x0000000181597480-0x0000000181597CD0
	// [XID] // 0x0000000189726980-0x00000001897269A0
	private void OnHomeGetArrangementInfoRsp(HomeGetArrangementInfoRsp rsp) {} // 0x0000000181598CE0-0x0000000181598FA0
	// [XID] // 0x000000018972DED0-0x000000018972DEF0
	private void OnHomeHomeChangeEditModeRsp(HomeChangeEditModeRsp rsp) {} // 0x000000018159A6F0-0x000000018159A8E0
	// [XID] // 0x0000000189735570-0x0000000189735590
	private void OnHomeBasicInfoNotify(HomeBasicInfoNotify notify) {} // 0x00000001815A1B70-0x00000001815A2120
	// [XID] // 0x000000018973D0D0-0x000000018973D0F0
	public bool IsOwner() => default; // 0x00000001815938A0-0x0000000181593AE0
	// [XID] // 0x00000001897445F0-0x0000000189744610
	public override void ClearOnLevelDestroy() {} // 0x0000000181595350-0x00000001815953F0
	// [XID] // 0x000000018974C2B0-0x000000018974C2D0
	public override void ClearOnDisconnect() {} // 0x00000001815A1AD0-0x00000001815A1B70
	// [XID] // 0x0000000189753560-0x0000000189753580
	public void RequestHomeworldScenePoints() {} // 0x0000000181598720-0x0000000181598810
	// [XID] // 0x000000018975AA80-0x000000018975AAA0
	private void SetMaxUnlockBlockCount() {} // 0x00000001815A2180-0x00000001815A2370
	// [XID] // 0x00000001897625F0-0x0000000189762610
	private void CheckAreaLevelUnlock(uint homeworldLevel) {} // 0x0000000181597F90-0x0000000181598270
	// [XID] // 0x0000000189769C70-0x0000000189769C90
	private void SetHomeworldPaimon() {} // 0x000000018159EE80-0x000000018159F0E0
	// [XID] // 0x0000000189771260-0x0000000189771280
	private void SetPaimonRegion(uint sceneID, uint areaID) {} // 0x0000000181598870-0x0000000181598AF0
	// [XID] // 0x0000000189778AE0-0x0000000189778B00
	private void OnLevelUPAreaUnlock(uint lastLevel, uint level, bool isOwner) {} // 0x000000018159E750-0x000000018159EA40
	// [XID] // 0x00000001897800A0-0x00000001897800C0
	public BaseEntity TryCreateInteriorDoorEntity(Vector3 pos, bool isEnter) => default; // 0x000000018159BED0-0x000000018159C100
	// [XID] // 0x0000000189787940-0x0000000189787960
	public void TryGreateDjinnGadgetEntity(int index) {} // 0x0000000181593160-0x0000000181593720
	// [XID] // 0x000000018978EF60-0x000000018978EF80
	public void CheckCreateDjinnGadget() {} // 0x0000000181593C90-0x0000000181594020
	// [XID] // 0x00000001897967D0-0x00000001897967F0
	public void UpdateDjinnTransfrom() {} // 0x00000001815A05C0-0x00000001815A0740
	// [XID] // 0x000000018979E8B0-0x000000018979E8D0
	public void SetDjinnVisible(bool visible) {} // 0x000000018159D230-0x000000018159D300
	// [XID] // 0x00000001897A5FC0-0x00000001897A5FE0
	public void CheckDestroyDjinnGadget() {} // 0x000000018159B300-0x000000018159B410
	// [XID] // 0x00000001897AD490-0x00000001897AD4B0
	private void DjinnGadgetLevelUp() {} // 0x0000000181592E50-0x0000000181592F00
	// [XID] // 0x00000001897B55B0-0x00000001897B55D0
	public Vector3 GetDjinnPos() => default; // 0x0000000181595750-0x00000001815959B0
	// [XID] // 0x00000001897BD190-0x00000001897BD1B0
	private Vector3 GetDjinnRot() => default; // 0x000000018159FF60-0x00000001815A0150
	// [XID] // 0x00000001897C4520-0x00000001897C4540
	public Vector3 GetDjinnWeekendPos() => default; // 0x00000001815A1120-0x00000001815A12B0
	// [XID] // 0x00000001897CBD10-0x00000001897CBD30
	private Vector3 GetDjinnWeekendRot() => default; // 0x0000000181595EA0-0x0000000181596030
	// [XID] // 0x00000001897D3740-0x00000001897D3760
	private void CheckCreateDjinnGadgetWeekend() {} // 0x0000000181599410-0x0000000181599790
	// [XID] // 0x00000001897DB1D0-0x00000001897DB1F0
	public bool IsDjinnGadgetWeekendTime() => default; // 0x0000000181597D30-0x0000000181597E90
	// [XID] // 0x00000001897E2880-0x00000001897E28A0
	public bool IsDjinnGadgetWeekendRefreshNotSeen() => default; // 0x0000000181597350-0x0000000181597480
	// [XID] // 0x00000001897E9F80-0x00000001897E9FA0
	public void SetDjinnGadgetWeekendRefreshSeen() {} // 0x000000018159DAF0-0x000000018159DCC0
	// [XID] // 0x00000001897F1C70-0x00000001897F1C90
	private void CheckDestroyDjinnGadgetWeekend() {} // 0x000000018159C2D0-0x000000018159C3E0
	// [XID] // 0x00000001897F9470-0x00000001897F9490
	private void TryStartDjinnGadgetCoroutine() {} // 0x0000000181594610-0x0000000181594710
	[DebuggerHidden] // 0x0000000189800A70-0x0000000189800AB0
	// [XID] // 0x0000000189800A70-0x0000000189800AB0
	private IEnumerator CheckDjinnGadgetCoroutine() => default; // 0x0000000181596810-0x0000000181596920
	// [XID] // 0x000000018980AF50-0x000000018980AF70
	private void OnDjinnReady(BaseEntity entity) {} // 0x000000018159D300-0x000000018159D3C0
	// [XID] // 0x00000001898125E0-0x0000000189812600
	private void SetDjinnComfortLevel() {} // 0x000000018159DCC0-0x000000018159DDF0
	// [XID] // 0x000000018981A220-0x000000018981A240
	private void SetDjinnBilloard() {} // 0x0000000181599920-0x0000000181599A90
	// [XID] // 0x0000000189821970-0x0000000189821990
	public void OpenHomeworldLevelPage(Action finishCallback) {} // 0x00000001815A0910-0x00000001815A0AF0
	// [XID] // 0x0000000189828F00-0x0000000189828F20
	public void OpenHomeworldBuildPage(Action finishCallback) {} // 0x00000001815A0F10-0x00000001815A1120
	// [XID] // 0x0000000189830410-0x0000000189830430
	public void OpenHomeworldSwitchPage(Action finishCallback) {} // 0x0000000181595CC0-0x0000000181595EA0
	// [XID] // 0x0000000189837AF0-0x0000000189837B10
	public void OpenHomeworldShopPage(Action finishCallback) {} // 0x0000000181596030-0x0000000181596210
	// [XID] // 0x000000018983F250-0x000000018983F270
	public void OpenHomeworldLimitedShopPage(Action finishCallback) {} // 0x0000000181596210-0x00000001815963F0
	// [XID] // 0x0000000189846850-0x0000000189846870
	public void TryAddAllMarks() {} // 0x000000018159EDD0-0x000000018159EE80
	// [XID] // 0x000000018984DE00-0x000000018984DE20
	public void TryAddDjinnMarks() {} // 0x00000001815A0250-0x00000001815A05C0
	// [XID] // 0x0000000189854EB0-0x0000000189854ED0
	public void TryAddMainHouseMark() {} // 0x000000018159D8B0-0x000000018159DA90
	// [XID] // 0x00000001898946D0-0x00000001898946F0
	public ulong GetHomeworldExpNeededForNextLevel(uint level) => default; // 0x0000000181596AF0-0x0000000181596BE0
	// [XID] // 0x00000001898A31E0-0x00000001898A3200
	public string GetModuleName(uint moduleId) => default; // 0x00000001815A3440-0x00000001815A3520
	// [XID] // 0x00000001898AA600-0x00000001898AA620
	public uint GetModuleComfortMaxForCurrentHomeworldLevel() => default; // 0x000000018159ADA0-0x000000018159AE80
	// [XID] // 0x00000001898B20B0-0x00000001898B20D0
	public uint GetModuleComfortMaxForMaxHomeworldLevel() => default; // 0x000000018159C4B0-0x000000018159C6B0
	// [XID] // 0x00000001898B9DE0-0x00000001898B9E00
	public uint GetChooseModuleComfort() => default; // 0x000000018159D5E0-0x000000018159D690
	// [XID] // 0x00000001898C1100-0x00000001898C1120
	public uint GetModuleComfortHighest() => default; // 0x00000001815A2670-0x00000001815A28C0
	// [XID] // 0x00000001898C8A20-0x00000001898C8A40
	public HomeModuleComfortInfo GetModuleComfortInfo(uint moduleId) => default; // 0x00000001815943B0-0x0000000181594610
	// [XID] // 0x00000001898D03E0-0x00000001898D0400
	public uint GetModuleComfort(uint moduleId) => default; // 0x000000018159D3C0-0x000000018159D5E0
	// [XID] // 0x00000001898D7A20-0x00000001898D7A40
	private void OnHomeComfortInfoNotify(HomeComfortInfoNotify rsp) {} // 0x0000000181592F00-0x00000001815930C0
	// [XID] // 0x00000001898DF6B0-0x00000001898DF6D0
	public HomeWorldComfortLevelExcelConfig GetComfortLevelData(uint level) => default; // 0x0000000181596BE0-0x0000000181596CB0
	// [XID] // 0x00000001898E7150-0x00000001898E7170
	public HomeWorldComfortLevelExcelConfig GetComfortLevelDataByComfort(uint comfort) => default; // 0x000000018159BA80-0x000000018159BCD0
	// [XID] // 0x00000001898EE920-0x00000001898EE940
	public string GetChooseModuleLevelComfortName() => default; // 0x0000000181599230-0x0000000181599300
	// [XID] // 0x00000001898F60A0-0x00000001898F60C0
	public HomeworldLevelExcelConfig GetHomeworldLevelExcelConfig(uint level) => default; // 0x000000018159C3E0-0x000000018159C4B0
	// [XID] // 0x00000001898FD980-0x00000001898FD9A0
	public uint GetMaxStoreHomeCoin() => default; // 0x0000000181593720-0x00000001815938A0
	// [XID] // 0x00000001899051E0-0x0000000189905200
	public uint GetCurrentStoreHomeCoin() => default; // 0x000000018159EB80-0x000000018159ECD0
	// [XID] // 0x000000018990C9D0-0x000000018990C9F0
	public bool IsStoreHomeCoinFull() => default; // 0x0000000181596920-0x0000000181596AF0
	// [XID] // 0x0000000189914160-0x0000000189914180
	public bool IsStoreCompanionshipExpFull() => default; // 0x00000001815930C0-0x0000000181593160
	// [XID] // 0x00000001896B8690-0x00000001896B86B0
	public bool HasLevelRewardToGet() => default; // 0x0000000181596CB0-0x0000000181596DC0
	// [XID] // 0x0000000189923220-0x0000000189923240
	public bool IsDjinnLevelUp(uint level) => default; // 0x0000000181599C70-0x0000000181599D80
	// [XID] // 0x000000018992AA40-0x000000018992AA60
	public int GetDjinnLevelUpIndex(uint level) => default; // 0x000000018159E660-0x000000018159E750
	// [XID] // 0x0000000189932020-0x0000000189932040
	public bool CanGetLevelReward(int level) => default; // 0x000000018159C100-0x000000018159C220
	// [XID] // 0x00000001899399D0-0x00000001899399F0
	public RewardExcelConfig GetLevelReward(uint level) => default; // 0x0000000181595660-0x0000000181595750
	// [XID] // 0x0000000189940BE0-0x0000000189940C00
	public uint GetCurrentHomeCoinSpeed() => default; // 0x0000000181596700-0x0000000181596810
	// [XID] // 0x0000000189948580-0x00000001899485A0
	public uint GetCurrentCompanionshipExpSpeed() => default; // 0x0000000181594A90-0x0000000181594BA0
	// [XID] // 0x000000018994FCF0-0x000000018994FD10
	public string GetHomeworldExteriorAreaName(uint moduleId, uint areaId) => default; // 0x00000001815A0BD0-0x00000001815A0EB0
	// [XID] // 0x0000000189957260-0x0000000189957280
	private void OnHomeResourceNotify(HomeResourceNotify notify) {} // 0x00000001815A2460-0x00000001815A2610
	// [XID] // 0x0000000189999DD0-0x0000000189999DF0
	public HomeworldModuleExcelConfig GetHomeworldModuleConfig() => default; // 0x0000000181594710-0x00000001815948C0
	// [XID] // 0x00000001899A14B0-0x00000001899A14D0
	public void RequestPlayerHomeCompInfo() {} // 0x0000000181599790-0x0000000181599870
	// [XID] // 0x00000001899A8EE0-0x00000001899A8F00
	private void OnPlayerHomeCompInfoNotify(PlayerHomeCompInfoNotify ntf) {} // 0x0000000181596DC0-0x0000000181597260
	// [XID] // 0x00000001899B0870-0x00000001899B0890
	private void OnHomeSnapshotNotify(HomeSnapshotNotify ntf) {} // 0x00000001815A28C0-0x00000001815A29C0
	// [XID] // 0x00000001899B7C10-0x00000001899B7C30
	public void RequestChangeModule(uint moduleId) {} // 0x000000018159CBA0-0x000000018159CCA0
	// [XID] // 0x00000001899BF630-0x00000001899BF650
	private void OnHomeChangeModuleRsp(HomeChangeModuleRsp rsp) {} // 0x000000018159AB40-0x000000018159ADA0
	// [XID] // 0x00000001899C6FD0-0x00000001899C6FF0
	public void RequestChooseModule(uint moduleId) {} // 0x0000000181597E90-0x0000000181597F90
	// [XID] // 0x00000001899CE470-0x00000001899CE490
	private void OnHomeChooseModuleRsp(HomeChooseModuleRsp rsp) {} // 0x00000001815A2B50-0x00000001815A2E30
	// [XID] // 0x00000001899D5C30-0x00000001899D5C50
	public void RequestFurnitureCurModuleArrangeCount() {} // 0x000000018159C880-0x000000018159C960
	// [XID] // 0x00000001899DCFE0-0x00000001899DD000
	private void OnFurnitureCurModuleArrangeCountNotify(FurnitureCurModuleArrangeCountNotify ntf) {} // 0x000000018159E440-0x000000018159E660
	// [XID] // 0x00000001899E4BA0-0x00000001899E4BC0
	public uint GetFurnitureCurrentArrangementNum(uint furnitureId) => default; // 0x00000001815A2ED0-0x00000001815A2FC0
	// [XID] // 0x0000000189A20010-0x0000000189A20030
	private void OnUnlockedFurnitureFormulaDataNotify(UnlockedFurnitureFormulaDataNotify ntf) {} // 0x00000001815963F0-0x0000000181596700
	// [XID] // 0x0000000189A273A0-0x0000000189A273C0
	public void RequestFurnitureBuildData() {} // 0x000000018159A610-0x000000018159A6F0
	// [XID] // 0x0000000189A2EBE0-0x0000000189A2EC00
	private void OnFurnitureMakeRsp(FurnitureMakeRsp rsp) {} // 0x00000001815A1460-0x00000001815A18E0
	// [XID] // 0x0000000189A364F0-0x0000000189A36510
	private void RefreshFurnitureBuildSlotInternal(RepeatedMessageField<FurnitureMakeData> list) {} // 0x000000018159B410-0x000000018159B6C0
	// [XID] // 0x0000000189A3DB10-0x0000000189A3DB30
	public void RequestFetchFinishFurniture(uint index, uint makeId, bool isFastTake) {} // 0x0000000181598B90-0x0000000181598CE0
	// [XID] // 0x0000000189A45250-0x0000000189A45270
	private void OnTakeFurnitureMakeRsp(TakeFurnitureMakeRsp rsp) {} // 0x000000018159E020-0x000000018159E3A0
	// [XID] // 0x0000000189A4C960-0x0000000189A4C980
	public void RequestFurnitureMakeStart(uint makeId) {} // 0x000000018159B160-0x000000018159B260
	// [XID] // 0x0000000189A54190-0x0000000189A541B0
	private void OnFurnitureMakeStartRsp(FurnitureMakeStartRsp rsp) {} // 0x000000018159C960-0x000000018159CBA0
	// [XID] // 0x0000000189A5BBA0-0x0000000189A5BBC0
	public void RequestFurnitureMakeCancel(uint index, uint makeId) {} // 0x000000018159BDB0-0x000000018159BED0
	// [XID] // 0x0000000189A63330-0x0000000189A63350
	private void OnFurnitureMakeCancelRsp(FurnitureMakeCancelRsp rsp) {} // 0x000000018159A230-0x000000018159A610
	// [XID] // 0x0000000189A6AE50-0x0000000189A6AE70
	private void OnFurnitureMakeFinishNotify(FurnitureMakeFinishNotify ntf) {} // 0x000000018159C7C0-0x000000018159C880
	// [XID] // 0x0000000189A72500-0x0000000189A72520
	private void OnFurnitureMakeBeHelpedNotify(FurnitureMakeBeHelpedNotify ntf) {} // 0x0000000181598270-0x0000000181598470
	// [XID] // 0x0000000189A7A110-0x0000000189A7A130
	public void RequestFurnitureMakeHelp() {} // 0x000000018159AF00-0x000000018159AFE0
	// [XID] // 0x0000000189A815B0-0x0000000189A815D0
	private void OnFurnitureMakeHelpRsp(FurnitureMakeHelpRsp rsp) {} // 0x00000001815A3160-0x00000001815A3440
	// [XID] // 0x0000000189A89010-0x0000000189A89030
	private void OnFunitureMakeMakeInfoChangeNotify(FunitureMakeMakeInfoChangeNotify ntf) {} // 0x0000000181594020-0x0000000181594200
	// [XID] // 0x0000000189A90810-0x0000000189A90830
	private Vector3 GetMainHousePositionFromSnapshot() => default; // 0x000000018159FE00-0x000000018159FF60
	// [XID] // 0x0000000189A98030-0x0000000189A98050
	public Vector3 GetMainHousePosition() => default; // 0x0000000181594C90-0x0000000181594E10
	// [XID] // 0x0000000189A9F410-0x0000000189A9F430
	public bool IsInteriorSecondFloor() => default; // 0x0000000181598AF0-0x0000000181598B90
	// [XID] // 0x0000000189AA6C20-0x0000000189AA6C40
	public int GetPlayerCurrentFloor() => default; // 0x00000001815A3520-0x00000001815A36A0
	// [XID] // 0x0000000189AAE370-0x0000000189AAE390
	public HomeWorldFurnitureExcelConfig GetHomeworldMainhouseConfig() => default; // 0x0000000181599D80-0x0000000181599E70
	// [XID] // 0x0000000189AB5BC0-0x0000000189AB5BE0
	public HomeworldUltiliyData GetHomeworldUltilityData() => default; // 0x0000000181598FA0-0x0000000181599230
	// [XID] // 0x0000000189ABD650-0x0000000189ABD670
	public uint GetCurrSceneModuleComfortLevel() => default; // 0x0000000181599E70-0x000000018159A230
	// [XID] // 0x0000000189AC50F0-0x0000000189AC5110
	public uint GetHomeworldLevel() => default; // 0x00000001815959B0-0x0000000181595CC0
	// [XID] // 0x0000000189ACC620-0x0000000189ACC640
	public bool IsFurnitureSuiteUnlocked(uint suiteID) => default; // 0x000000018159AFE0-0x000000018159B100
	// [XID] // 0x0000000189AD4350-0x0000000189AD4370
	private void OnFurnitureSuiteUnlockNotify(UnlockedFurnitureSuiteDataNotify notify) {} // 0x0000000181598470-0x0000000181598720
	// [XID] // 0x0000000189ADBCA0-0x0000000189ADBCC0
	public bool IsFurnitureFreeze(uint itemID) => default; // 0x000000018159AA70-0x000000018159AB40
	// [XID] // 0x0000000189AE3670-0x0000000189AE3690
	private void OnFurnitureFreezeNotify(ClosedItemNotify closeItemNoitfy) {} // 0x000000018159B8C0-0x000000018159BA80
	// [XID] // 0x0000000189AEAF50-0x0000000189AEAF70
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001815953F0-0x0000000181595660
	// [XID] // 0x0000000189AF28A0-0x0000000189AF28C0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001815A19F0-0x00000001815A1AD0
}

