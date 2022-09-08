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

public sealed class InLevelGachaGroupContext : BaseGroupContext // TypeDefIndex: 29793
{
	// Fields
	public const uint GACHA_ONE_TIME = 1; // Metadata: 0x00B0FF34
	public const uint GACHA_TEN_TIME = 10; // Metadata: 0x00B0FF38
	public const string GACHASCENE_PREFAB_PATH = "ART/UI/UIScene/GachaScene"; // Metadata: 0x00B0FF3C
	private State _state; // 0x18
	private List<GachaDataInfo> _gachaList; // 0x20
	private uint _gachaRandomNum; // 0x28
	private IList<GachaItem> _gachaItemList; // 0x30
	private int _curGachaPoolIndex; // 0x38
	private uint _gachaScheduleId; // 0x3C
	private DoGachaType _gachaTimes; // 0x40
	private uint _gachaType; // 0x44
	private int _subIndexOfTenTimes; // 0x48
	private bool _directDoGacha; // 0x4C
	private MonoGachaScene _monoGachaScene; // 0x50
	private uint _tryToShowScheduleID; // 0x58
	private GameObject _gachaSceneObj; // 0x60
	private BasePageContext _curContext; // 0x68
	private EmptyPageContext _gachaCutscenePageContext; // 0x70
	private InLevelGachaPageContext _gachaPageContext; // 0x78
	private InLevelGachaSettlementPageContext _gachsSettlePage; // 0x80
	private SkipWidgetContext _skipWidget; // 0x88
	private Dictionary<uint, BaseEntity> _entityCache; // 0x90
	public static int MAX_CACHA_NUM; // 0x00
	private Dictionary<string, uint> _preloadCutsceneHandled; // 0x98
	private static Action<EvtEntityReadyPost> _onWeaponEntityReady; // 0x08

	// Properties
	public State state { /* [XID] */ /* 0x0000000189A69510-0x0000000189A69530 */ get => default; } // 0x00000001834DA770-0x00000001834DA810 

	// Nested types
	public enum State // TypeDefIndex: 29794
	{
		None = 0,
		Init = 1,
		GetGachaPool = 2,
		ShowGachaPool = 3,
		ShowGazing = 4,
		DoGacha = 5,
		StarGazing = 6,
		OneTimeCutscene = 7,
		OneTimeItemCutscene = 8,
		OneTimeShow = 9,
		OneTimeSettlement = 10,
		TenTimeCutscene = 11,
		TenTimeShow = 12,
		TenTimeItemCutscene = 13,
		TenTimeSettlement = 14
	}

	// Constructors
	public InLevelGachaGroupContext() {} // 0x00000001834E13F0-0x00000001834E15A0
	static InLevelGachaGroupContext() {} // 0x00000001834E1310-0x00000001834E13F0

	// Methods
	// [XID] // 0x0000000189A70880-0x0000000189A708A0
	public void InitGroupPage() {} // 0x00000001834DA430-0x00000001834DA500
	// [XID] // 0x0000000189A78130-0x0000000189A78150
	private void CreateGachaScene() {} // 0x00000001834D8C30-0x00000001834D8E40
	// [XID] // 0x0000000189A7F720-0x0000000189A7F740
	public void DestroyGachaScene() {} // 0x00000001834E0D60-0x00000001834E0EB0
	// [XID] // 0x0000000189A87460-0x0000000189A87480
	public MonoGachaScene GetGachaScene() => default; // 0x00000001834E04B0-0x00000001834E05A0
	// [XID] // 0x0000000189A8EC80-0x0000000189A8ECA0
	public int GetSubIndexOfTenTimes() => default; // 0x00000001834DB710-0x00000001834DB7B0
	// [XID] // 0x0000000189A96290-0x0000000189A962B0
	public uint GetGachaScheduleId() => default; // 0x00000001834E0210-0x00000001834E02B0
	// [XID] // 0x0000000189A9D7C0-0x0000000189A9D7E0
	public int GetCurrentGachaNum() => default; // 0x00000001834DF9C0-0x00000001834DFA60
	// [XID] // 0x0000000189AA5090-0x0000000189AA50B0
	public uint GetGachaTimes() => default; // 0x00000001834DA600-0x00000001834DA6C0
	// [XID] // 0x0000000189AAC870-0x0000000189AAC890
	public uint GetGachaItemCost() => default; // 0x00000001834E02B0-0x00000001834E0370
	// [XID] // 0x0000000189AB4110-0x0000000189AB4130
	public uint GetGachaType() => default; // 0x00000001834DECE0-0x00000001834DED80
	// [XID] // 0x0000000189ABBE50-0x0000000189ABBE70
	public IList<GachaDataInfo> GetGachaList() => default; // 0x00000001834D8E40-0x00000001834D8EE0
	// [XID] // 0x0000000189AC35E0-0x0000000189AC3600
	public GachaDataInfo GetCurrentGachaInfo() => default; // 0x00000001834D8EE0-0x00000001834D8FD0
	// [XID] // 0x0000000189ACAC70-0x0000000189ACAC90
	public IList<GachaItem> GetGachaItemList() => default; // 0x00000001834D8FD0-0x00000001834D9070
	// [XID] // 0x0000000189AD26E0-0x0000000189AD2700
	public GachaItem GetCurGachaItem() => default; // 0x00000001834DEC20-0x00000001834DECE0
	// [XID] // 0x0000000189ADA170-0x0000000189ADA190
	public void SetGachaRandomNum(uint gachaRandomNum) {} // 0x00000001834D95D0-0x00000001834D9680
	// [XID] // 0x0000000189AE1A30-0x0000000189AE1A50
	public uint GetGachaRandomNum() => default; // 0x00000001834DA560-0x00000001834DA600
	// [XID] // 0x0000000189AE91E0-0x0000000189AE9200
	public void SetGachaResult(uint gachaScheduleId, uint gachaType, uint costid, uint costnum, uint tenid, uint tennum, uint tenoriginNum, uint lefttimes, uint gachaTimesLimit, uint gachaTimes, IList<GachaItem> gachaItemList) {} // 0x00000001834DC200-0x00000001834DCA90
	// [XID] // 0x0000000189AF0FD0-0x0000000189AF0FF0
	public void MoveNextStep() {} // 0x00000001834DDE80-0x00000001834DDFA0
	// [IDTag] // 0x0000000189AF8450-0x0000000189AF8490
	// [XID] // 0x0000000189AF8450-0x0000000189AF8490
	private void ShowGachaPool() {} // 0x00000001834DEB10-0x00000001834DEC20
	// [XID] // 0x0000000189B02AA0-0x0000000189B02AC0
	private void ShowGazing() {} // 0x00000001834DAFA0-0x00000001834DB160
	// [XID] // 0x0000000189B0A2F0-0x0000000189B0A310
	private void PreloadCutscene(string cutscenePath) {} // 0x00000001834DAAB0-0x00000001834DAC90
	// [XID] // 0x0000000189B11AB0-0x0000000189B11AD0
	private void ReleasePreloadCutscene(string cutscenePath) {} // 0x00000001834D9FA0-0x00000001834DA100
	// [XID] // 0x0000000189B18D80-0x0000000189B18DA0
	private void ReleaseAllPreloadCutscene() {} // 0x00000001834DE170-0x00000001834DE370
	// [XID] // 0x0000000189B203D0-0x0000000189B203F0
	private string GetGachaCutscenePath() => default; // 0x00000001834D8B30-0x00000001834D8C30
	// [XID] // 0x0000000189B27A50-0x0000000189B27A70
	private void AfterGazing() {} // 0x00000001834DB950-0x00000001834DBC80
	// [XID] // 0x0000000189B2ED90-0x0000000189B2EDB0
	private void InitGachaCutscene(string path) {} // 0x00000001834DCCD0-0x00000001834DCE50
	// [XID] // 0x0000000189B36610-0x0000000189B36630
	private void AfterCutscene(bool isSkip = false /* Metadata: 0x00B0FF29 */) {} // 0x00000001834E1040-0x00000001834E1230
	// [XID] // 0x0000000189B3DE70-0x0000000189B3DE90
	private string NeedPlayItemCutscene(GachaItem item) => default; // 0x00000001834DB4B0-0x00000001834DB710
	// [XID] // 0x0000000189B45C10-0x0000000189B45C30
	public void ShowOneItemInTenGacha() {} // 0x00000001834D92B0-0x00000001834D94C0
	// [XID] // 0x0000000189B4D090-0x0000000189B4D0B0
	public void PlayItemCutscene(string cutscenePath) {} // 0x00000001834DF3D0-0x00000001834DF700
	// [XID] // 0x0000000189B54870-0x0000000189B54890
	private void AfterItemCutscene() {} // 0x00000001834E0EB0-0x00000001834E0FE0
	// [XID] // 0x0000000189B5C450-0x0000000189B5C470
	public void NextOneItemInTenGacha() {} // 0x00000001834DA270-0x00000001834DA430
	// [XID] // 0x0000000189B63980-0x0000000189B639A0
	private void AfterTenShow() {} // 0x00000001834DF8C0-0x00000001834DF9C0
	// [XID] // 0x0000000189B6B180-0x0000000189B6B1A0
	private void ShowPage(BasePageContext context, bool fadeOut = true /* Metadata: 0x00B0FF2A */) {} // 0x00000001834E0670-0x00000001834E07C0
	// [XID] // 0x0000000189B727C0-0x0000000189B727E0
	private void CloseCurrentContext(BasePageContext context) {} // 0x00000001834E05A0-0x00000001834E0670
	// [XID] // 0x0000000189B79CF0-0x0000000189B79D10
	public void RestartGacha() {} // 0x00000001834D9110-0x00000001834D91D0
	// [IDTag] // 0x0000000189B81420-0x0000000189B81460
	// [XID] // 0x0000000189B81420-0x0000000189B81460
	public void ShowGachaPool(IList<GachaInfo> gachaList) {} // 0x00000001834DE370-0x00000001834DEB10
	// [XID] // 0x0000000189B8B610-0x0000000189B8B630
	private ShopMaterial GetCostMaterial() => default; // 0x00000001834D9DC0-0x00000001834D9EE0
	// [XID] // 0x0000000189B92D40-0x0000000189B92D60
	public ShopType GetGachaShopType() => default; // 0x00000001834D9070-0x00000001834D9110
	// [XID] // 0x0000000189B9A320-0x0000000189B9A340
	private void BuyGacha(ShopItem shopItem, uint needCount) {} // 0x00000001834E0BD0-0x00000001834E0D60
	// [XID] // 0x0000000189BA1A30-0x0000000189BA1A50
	public void OnBuyGoodsRsp(bool succ) {} // 0x00000001834DD180-0x00000001834DD250
	// [XID] // 0x0000000189BA8E30-0x0000000189BA8E50
	public void SetCurrentGachaPool(int index) {} // 0x00000001834DB400-0x00000001834DB4B0
	// [XID] // 0x0000000189BB0620-0x0000000189BB0640
	public void DoGacha(DoGachaType type) {} // 0x00000001834DD4D0-0x00000001834DDDF0
	// [XID] // 0x0000000189BB79A0-0x0000000189BB79C0
	public void EnableGachaSceneObj(bool enable) {} // 0x00000001834D94C0-0x00000001834D95D0
	// [XID] // 0x0000000189BBF000-0x0000000189BBF020
	public void ShowGachaScene(uint tryToShowScheduleID = 0 /* Metadata: 0x00B0FF2B */, float fadeInDuration = 0.5f /* Metadata: 0x00B0FF2F */) {} // 0x00000001834D9680-0x00000001834D99C0
	// [XID] // 0x0000000189BC6CD0-0x0000000189BC6CF0
	public void HideGachaScene(bool force = false /* Metadata: 0x00B0FF33 */) {} // 0x00000001834DED80-0x00000001834DEF30
	// [XID] // 0x0000000189BCE980-0x0000000189BCE9A0
	public void DoGachaFail() {} // 0x00000001834DBEA0-0x00000001834DBF80
	// [XID] // 0x0000000189BD5C40-0x0000000189BD5C60
	private void EnableSkip() {} // 0x00000001834E0370-0x00000001834E04B0
	// [XID] // 0x0000000189BDD8F0-0x0000000189BDD910
	private void DisableSkip() {} // 0x00000001834DB890-0x00000001834DB950
	// [XID] // 0x00000001895EA4B0-0x00000001895EA4D0
	public void SkipGacha() {} // 0x00000001834DA100-0x00000001834DA1A0
	// [XID] // 0x00000001895F18D0-0x00000001895F18F0
	private void ForceEndCutscene() {} // 0x00000001834DA940-0x00000001834DAAB0
	// [XID] // 0x00000001895F9330-0x00000001895F9350
	private void ForceEndGacha() {} // 0x00000001834E1230-0x00000001834E1310
	// [XID] // 0x0000000189600960-0x0000000189600980
	private void ForceClearCutscene() {} // 0x00000001834DEF30-0x00000001834DF1E0
	// [XID] // 0x0000000189608280-0x00000001896082A0
	public void ReleaseGachaModel() {} // 0x00000001834DCA90-0x00000001834DCCD0
	// [XID] // 0x000000018960FC20-0x000000018960FC40
	public void ClearCurrentGachaModel() {} // 0x00000001834DDFA0-0x00000001834DE110
	// [XID] // 0x0000000189616EC0-0x0000000189616EE0
	private void ShowModel(uint index, GachaItem item) {} // 0x00000001834E07C0-0x00000001834E0B10
	// [XID] // 0x000000018961EA40-0x000000018961EA60
	public void LoadModelView(uint index, GachaItem item) {} // 0x00000001834DAC90-0x00000001834DAFA0
	// [XID] // 0x0000000189625E60-0x0000000189625E80
	private uint GetAvatarConfigIdByExcelConfig(MaterialExcelConfig itemConfig) => default; // 0x00000001834DF1E0-0x00000001834DF3D0
	// [IDTag] // 0x000000018962D7A0-0x000000018962D7E0
	// [XID] // 0x000000018962D7A0-0x000000018962D7E0
	private BaseEntity ShowAvatarModel(MaterialExcelConfig itemConfig) => default; // 0x00000001834DFBC0-0x00000001834DFE40
	// [XID] // 0x0000000189638460-0x0000000189638480
	private void OnAvatarManekinReady(BaseEntity baseEntity) {} // 0x00000001834D91D0-0x00000001834D92B0
	// [IDTag] // 0x000000018963F860-0x000000018963F8A0
	// [XID] // 0x000000018963F860-0x000000018963F8A0
	private void ShowAvatarModel(BaseEntity baseEntity) {} // 0x00000001834DFE40-0x00000001834E0090
	// [XID] // 0x0000000189649F50-0x0000000189649F70
	private void InitHeadController(BaseEntity entity) {} // 0x00000001834DBC80-0x00000001834DBEA0
	// [XID] // 0x0000000189651630-0x0000000189651650
	private void DissolveAvatar(BaseEntity manekinEntity) {} // 0x00000001834DB300-0x00000001834DB400
	// [XID] // 0x0000000189658EB0-0x0000000189658ED0
	private void ResetTrigger(BaseEntity manekinEntity, int triggerNameID) {} // 0x00000001834DB7B0-0x00000001834DB890
	// [XID] // 0x0000000189660580-0x00000001896605A0
	private void SetAvatarManekinEntity(BaseEntity baseEntity) {} // 0x00000001834DBF80-0x00000001834DC200
	// [XID] // 0x0000000189667EC0-0x0000000189667EE0
	private void SetAvatarEquipEntity(BaseEntity baseEntity) {} // 0x00000001834E0090-0x00000001834E0210
	// [XID] // 0x000000018966F930-0x000000018966F950
	public BaseEntity ShowWeaponModel(ItemConfig itemConfig) => default; // 0x00000001834D99C0-0x00000001834D9CD0
	// [IDTag] // 0x0000000189677280-0x00000001896772C0
	// [XID] // 0x0000000189677280-0x00000001896772C0
	private static void OnWeaponEntityReady(EvtEntityReadyPost e) {} // 0x00000001834DF700-0x00000001834DF7E0
	// [XID] // 0x0000000189681AA0-0x0000000189681AC0
	private void SetWeaponEntity(BaseEntity baseEntity) {} // 0x00000001834DD250-0x00000001834DD4D0
	// [IDTag] // 0x0000000189689510-0x0000000189689550
	// [XID] // 0x0000000189689510-0x0000000189689550
	private void OnWeaponEntityReady(BaseEntity baseEntity) {} // 0x00000001834DF7E0-0x00000001834DF8C0
	// [XID] // 0x0000000189693FE0-0x0000000189694000
	private void SetupWeaponView(GameObject weaponGo) {} // 0x00000001834DCE50-0x00000001834DD180
	// [XID] // 0x000000018969B550-0x000000018969B570
	public AvatarExcelConfig ItemId2AvatarConfig(uint itemId) => default; // 0x00000001834DB160-0x00000001834DB300
	// [XID] // 0x00000001896A2C90-0x00000001896A2CB0
	public static bool IsNewBie(GachaDataInfo info) => default; // 0x00000001834DA6C0-0x00000001834DA770
	// [XID] // 0x00000001896AA180-0x00000001896AA1A0
	public static bool IsTimeLimit(GachaDataInfo info) => default; // 0x00000001834D9EE0-0x00000001834D9FA0
	// [XID] // 0x00000001896B0F60-0x00000001896B0F80
	protected override void OnEnable() {} // 0x00000001834DA810-0x00000001834DA8E0
	// [XID] // 0x00000001896B8B90-0x00000001896B8BB0
	protected override void OnDisable() {} // 0x00000001834DA1A0-0x00000001834DA270
	// [XID] // 0x00000001896BFD90-0x00000001896BFDB0
	public override void ClearOnDisconnect() {} // 0x00000001834E0B10-0x00000001834E0BD0
	// [XID] // 0x00000001896C7690-0x00000001896C76B0
	public override void Destroy() {} // 0x00000001834D9CD0-0x00000001834D9DC0
}

