/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class UIUtil // TypeDefIndex: 28693
{
	// Fields
	private static Dictionary<string, Object2Content> _globalReplaceFuncMap; // 0x08
	private static Dictionary<Regex, Regex2Content> _regexReplaceFuncMap; // 0x10
	private static Regex filterRegex; // 0x18
	private static InLevelCutScenePageContext _cutScenePage; // 0x20
	private static DebugLogMessageDialogContext _debugMessageDialog; // 0x28
	private static Action _nameDialogCB; // 0x30
	private static ErrorDialogContext _errorDialogContext; // 0x38
	private static GeneralDialogContext _queueUpDialog; // 0x40
	private static HashSet<string> _activeLogWhiteList; // 0x48
	private static Regex _pluralTextRegex; // 0x50
	private static Regex _pluralFormatRegex; // 0x58
	private static Regex _plainTextRegex; // 0x60
	private static Dictionary<string, Color> str2color; // 0x68
	private static MPInvitationDialogContext _invitationDialog; // 0x70
	private static MPInvitationListDialogContext _invitationListDialog; // 0x78
	private static MPInvitationDialogContext _matchSuccessDialog; // 0x80
	public const string ITEM_NUM_PAIR_TEMPLATE = "{0} / {1}"; // Metadata: 0x00B0E51E
	public const string ITEM_NUM_INSUFFICENT_PAIR_TEMPLATE = "<color=#FF5E41FF>{0}</color> / {1}"; // Metadata: 0x00B0E52B
	public static WaitForSeconds waitFor1s; // 0x88
	private static Dropdown.DropdownEvent _dropdownEvent; // 0x90
	private static StringBuilder _challengeBuilder; // 0x98
	private static StringBuilder _stringBuilder; // 0xA0
	public const string LIKING_BAR = "ART/UI/Menus/Widget/InLevel/LikingBar"; // Metadata: 0x00B0E551
	private static Vector3[] _rectCenterRefs; // 0xA8
	private static Vector3[] _maskCorners; // 0xB0
	private static Vector3[] _uiCorners; // 0xB8
	public const string lineSpliter = "\r\n"; // Metadata: 0x00B0E57A
	private static byte[] jpgBytes; // 0xC0
	public const int UIBorderOffsetMax = 60; // Metadata: 0x00B0E580
	public const int UIBorderOffsetMin = 1; // Metadata: 0x00B0E584
	private static char[] _vec3Splits; // 0xC8

	// Properties
	public static AddNoGachaAvatarCardNotify addNoGachaAvatarCardNotify { /* [XID] */ /* 0x000000018997B2D0-0x000000018997B310 */ get; /* [XID] */ /* 0x00000001899858F0-0x0000000189985930 */ set; } // 0x0000000181AC5E30-0x0000000181AC5EC0 0x0000000181AB4C40-0x0000000181AB4CD0
	public static InLevelCutScenePageContext blackScreenPage { /* [XID] */ /* 0x00000001899C5540-0x00000001899C5560 */ get; } // 0x0000000181AC60A0-0x0000000181AC61F0 
	public static bool invitationListDialogShowing { /* [XID] */ /* 0x0000000189799370-0x0000000189799390 */ get; } // 0x0000000181ABF440-0x0000000181ABF550 
	public static string OKText { /* [XID] */ /* 0x00000001897C7940-0x00000001897C7960 */ get; } // 0x0000000181AC4610-0x0000000181AC46C0 
	public static string CancelText { /* [XID] */ /* 0x00000001897CEC20-0x00000001897CEC40 */ get; } // 0x0000000181AC6BF0-0x0000000181AC6CA0 
	public static StringBuilder stringBuilder { /* [XID] */ /* 0x00000001898A61E0-0x00000001898A6200 */ get; } // 0x0000000181AC1BB0-0x0000000181AC1D30 

	// Nested types
	private delegate object Object2Content(string content, object obj, string[] contents, int index); // TypeDefIndex: 28694; 0x000000018226C020-0x000000018226C370

	private delegate object Regex2Content(string content, Match match, object obj = null, uint questId = 0 /* Metadata: 0x00B0E588 */); // TypeDefIndex: 28695; 0x000000018224C830-0x000000018224CB80

	public class LevelUpItemQueue // TypeDefIndex: 28696
	{
		// Fields
		private Queue<TeamLevelUpItem> _queue; // 0x10
		private Coroutine levelUpCoroutine; // 0x18

		// Nested types
		public class TeamLevelUpItem // TypeDefIndex: 28697
		{
			// Fields
			public bool playing; // 0x10
			public GameObject levelUpGO; // 0x18
			public GameObject itemPrefab; // 0x20
			public Transform itemTransform; // 0x28
			public Func<int> getSlotIndex; // 0x30
			public uint before; // 0x38
			public uint after; // 0x3C
			public bool showPrefixString; // 0x40

			// Constructors
			public TeamLevelUpItem() {} // 0x000000018226C6A0-0x000000018226C700
		}

		// Constructors
		public LevelUpItemQueue() {} // 0x000000018224C3C0-0x000000018224C460

		// Methods
		// [XID] // 0x0000000189A59FA0-0x0000000189A59FC0
		public void ClearQueue() {} // 0x000000018224C310-0x000000018224C3C0
		// [XID] // 0x0000000189A61790-0x0000000189A617B0
		public void Enqueue(TeamLevelUpItem levelUpItem) {} // 0x000000018224C120-0x000000018224C220
		// [XID] // 0x0000000189A696B0-0x0000000189A696D0
		public void Dequeue() {} // 0x000000018224BD20-0x000000018224BE80
		// [XID] // 0x0000000189A70A40-0x0000000189A70A60
		public void StartPeek() {} // 0x000000018224BE80-0x000000018224C120
		// [XID] // 0x0000000189A78330-0x0000000189A78350
		public void ClearCoroutine() {} // 0x000000018224C220-0x000000018224C310
		[DebuggerHidden] // 0x0000000189A7F8E0-0x0000000189A7F920
		// [XID] // 0x0000000189A7F8E0-0x0000000189A7F920
		private static IEnumerator TeamLevelUpCoroutine(LevelUpItemQueue queue, TeamLevelUpItem currentItem) => default; // 0x000000018224BC00-0x000000018224BD20
	}

	public enum ResourceSizeType // TypeDefIndex: 28699
	{
		Auto = 0,
		KB = 1,
		MB = 2,
		GB = 3,
		B = 4
	}

	// Constructors
	static UIUtil() {} // 0x0000000181AC99D0-0x0000000181ACA480

	// Methods
	// [XID] // 0x00000001899559A0-0x00000001899559C0
	public static void BackToMainPage() {} // 0x0000000181ABAAA0-0x0000000181ABAB80
	// [XID] // 0x000000018995D440-0x000000018995D460
	public static void BackToMainPageMultiPlayer() {} // 0x0000000181AC6A60-0x0000000181AC6BF0
	// [XID] // 0x0000000189964B30-0x0000000189964B50
	public static void OpenTeamPageAccordingly(bool fadeOut = true /* Metadata: 0x00B0E470 */) {} // 0x0000000181AC1D30-0x0000000181AC1EF0
	// [XID] // 0x0000000189BD6F90-0x0000000189BD6FB0
	public static bool IsInMainPage() => default; // 0x0000000181ABC1C0-0x0000000181ABC320
	// [XID] // 0x0000000189973C60-0x0000000189973C80
	public static void TryCloseSpPageAndDialog() {} // 0x0000000181AC0FA0-0x0000000181AC1080
	// [XID] // 0x00000001899905C0-0x00000001899905E0
	public static void TryShowGetNewCharacterPage(AddNoGachaAvatarCardNotify notify) {} // 0x0000000181AC4AB0-0x0000000181AC4DD0
	// [XID] // 0x0000000189998130-0x0000000189998150
	public static void OpenBattlePass() {} // 0x0000000181AC0A40-0x0000000181AC0FA0
	// [XID] // 0x000000018999F870-0x000000018999F890
	private static uint GetRandomID(string content, uint mainQuestId) => default; // 0x0000000181AC8720-0x0000000181AC8890
	// [XID] // 0x00000001899A7450-0x00000001899A7470
	private static string ParseFilterContent(string inputStr, uint mainQuestId) => default; // 0x0000000181AB0AF0-0x0000000181AB0F70
	// [XID] // 0x00000001899AED20-0x00000001899AED40
	public static string FilterRegexContent(string content, uint mainQuestId = 0 /* Metadata: 0x00B0E471 */) => default; // 0x0000000181AC7650-0x0000000181AC79D0
	// [XID] // 0x00000001899B60A0-0x00000001899B60C0
	public static string FilterRegexContentByQuest(string content, uint questId = 0 /* Metadata: 0x00B0E475 */) => default; // 0x0000000181AB1350-0x0000000181AB14A0
	// [XID] // 0x00000001899BDE00-0x00000001899BDE20
	public static void ClearInLevelCutScenePageContext() {} // 0x0000000181AB71F0-0x0000000181AB72C0
	// [XID] // 0x00000001899CCC10-0x00000001899CCC30
	public static bool IsCutScenePageTalking() => default; // 0x0000000181AC7D90-0x0000000181AC7EA0
	// [XID] // 0x00000001899D4210-0x00000001899D4230
	public static void CutsceneSafeCall(Action func) {} // 0x0000000181AB8D90-0x0000000181AB8E80
	// [XID] // 0x00000001899DB800-0x00000001899DB820
	public static bool CanShowCutScenePage() => default; // 0x0000000181ABF550-0x0000000181ABF690
	// [XID] // 0x00000001899E2F00-0x00000001899E2F20
	public static void TryShowCutScenePage(bool needFreeClick = false /* Metadata: 0x00B0E479 */, uint inteeID = 0 /* Metadata: 0x00B0E47A */, bool needHideMouse = false /* Metadata: 0x00B0E47E */) {} // 0x0000000181AB2860-0x0000000181AB2BF0
	// [XID] // 0x00000001899EA610-0x00000001899EA630
	public static void TryShowCutSceneTalkDialog(DialogAction action, bool needFreeClick, uint inteeID, uint mainQuestId) {} // 0x0000000181AC8550-0x0000000181AC8720
	// [XID] // 0x00000001899F20A0-0x00000001899F20C0
	public static void TryHideTalkDialog() {} // 0x0000000181AC8890-0x0000000181AC8990
	// [XID] // 0x00000001899F97E0-0x00000001899F9800
	public static void TrySetCutScenePageNeedFreeClick(bool needFreeClick) {} // 0x0000000181AC6410-0x0000000181AC6570
	// [XID] // 0x0000000189A00B20-0x0000000189A00B40
	public static void TryShowNarratorDialog(string talker, string content) {} // 0x0000000181AB6330-0x0000000181AB64E0
	// [XID] // 0x0000000189A08420-0x0000000189A08440
	public static void TryCloseNarratorDialog() {} // 0x0000000181AB1AA0-0x0000000181AB1C20
	// [XID] // 0x0000000189A0FA00-0x0000000189A0FA20
	public static void TryShowWarningNarratorDialog(string talker, string content) {} // 0x0000000181AC8AE0-0x0000000181AC8CA0
	// [XID] // 0x0000000189A16F00-0x0000000189A16F20
	public static void TryCloseWarningNarratorDialog() {} // 0x0000000181AC8990-0x0000000181AC8AE0
	// [XID] // 0x0000000189A1E5C0-0x0000000189A1E5E0
	public static void TryShowNarratorBubble(string talker, string content) {} // 0x0000000181AC9370-0x0000000181AC9530
	// [XID] // 0x0000000189A25CC0-0x0000000189A25CE0
	public static void TryCloseBubbleDialog() {} // 0x0000000181AB16D0-0x0000000181AB1820
	// [XID] // 0x0000000189A2D140-0x0000000189A2D160
	public static void TryShowTeamPage(bool showExitDialog, uint tutorialId, Action callback) {} // 0x0000000181ABFDD0-0x0000000181AC0040
	// [XID] // 0x0000000189A34B00-0x0000000189A34B20
	public static GeneralDialogContext TryShowGeneralDialog(string title, string desc, Action<bool> callback, UIType uiType = UIType.Dialog /* Metadata: 0x00B0E47F */, WaitForGeneralDialog yieldIns = null, GeneralDialogContext.GeneralDialogType dialogType = GeneralDialogContext.GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E483 */, UIShowPriority mode = UIShowPriority.None /* Metadata: 0x00B0E487 */) => default; // 0x0000000181AC5370-0x0000000181AC5560
	// [XID] // 0x0000000189A3BED0-0x0000000189A3BEF0
	public static GeneralDialogContext TryShowGeneralDialogWithClearViewCB(string title, string desc, int layerOrder, Action<bool> callback, Action<bool> clearViewCallback, UIType uiType = UIType.Dialog /* Metadata: 0x00B0E48B */, WaitForGeneralDialog yieldIns = null, GeneralDialogContext.GeneralDialogType dialogType = GeneralDialogContext.GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E48F */, UIShowPriority mode = UIShowPriority.None /* Metadata: 0x00B0E493 */) => default; // 0x0000000181AC5950-0x0000000181AC5B80
	// [XID] // 0x0000000189A43B20-0x0000000189A43B40
	public static GeneralDialogContext TryShowRootGeneralDialog(string title, string desc, Action<bool> callback, GeneralDialogContext.GeneralDialogType dialogType = GeneralDialogContext.GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E497 */) => default; // 0x0000000181ABA3C0-0x0000000181ABA5A0
	// [XID] // 0x0000000189A4AF50-0x0000000189A4AF70
	public static void TryShowSimpleGeneralDialog(string content, Action buttonCallback) {} // 0x0000000181AC4070-0x0000000181AC4210
	// [XID] // 0x0000000189A52650-0x0000000189A52670
	public static void TryShowGeneralScrollDialog(string title, string desc, Action<bool> callback, GeneralDialogContext.GeneralDialogType type = GeneralDialogContext.GeneralDialogType.DOUBLE_BUTTON /* Metadata: 0x00B0E49B */) {} // 0x0000000181AC2980-0x0000000181AC2B60
	// [XID] // 0x0000000189A59FC0-0x0000000189A59FE0
	public static void TryShowGeneralIntroduceDialog(string title, string desc, Action callback = null) {} // 0x0000000181AB1910-0x0000000181AB1AA0
	// [XID] // 0x0000000189A617B0-0x0000000189A617D0
	public static void TryShowBundleDownloadError(string title, string desc, string leftButton, string rightButton, Action<bool> callback) {} // 0x0000000181AC8110-0x0000000181AC8340
	// [IDTag] // 0x0000000189A696D0-0x0000000189A69710
	// [XID] // 0x0000000189A696D0-0x0000000189A69710
	public static void TryShowConsumeItemDialog(string title, string desc, List<IdCountConfig> itemList, Action callBack) {} // 0x0000000181ABB9A0-0x0000000181ABBB00
	// [IDTag] // 0x0000000189A73920-0x0000000189A73960
	// [XID] // 0x0000000189A73920-0x0000000189A73960
	public static void TryShowConsumeItemDialog(string title, string desc, List<IdCountStruct> itemList, Action callBack) {} // 0x0000000181ABBB00-0x0000000181ABBC60
	// [XID] // 0x0000000189A7E1E0-0x0000000189A7E200
	public static void TryShowTutorialDialog(uint tutorialId, Action callback = null) {} // 0x0000000181AC2010-0x0000000181AC2140
	// [XID] // 0x0000000189A85BE0-0x0000000189A85C00
	public static void TryShowQuestPictureDialog(uint tutorialId, Action callback = null) {} // 0x0000000181AC6650-0x0000000181AC6780
	// [XID] // 0x0000000189A8D4C0-0x0000000189A8D4E0
	public static void PreClearTalk() {} // 0x0000000181ABC790-0x0000000181ABCAC0
	// [XID] // 0x0000000189A94980-0x0000000189A949A0
	public static void ClearTalk() {} // 0x0000000181AC3240-0x0000000181AC3470
	// [XID] // 0x0000000189A9C2C0-0x0000000189A9C2E0
	public static void TryShowItemGotDialog(List<SimpleItemStruct> itemList) {} // 0x0000000181AC17B0-0x0000000181AC1A00
	// [XID] // 0x0000000189AA3990-0x0000000189AA39B0
	public static ItemGotBigDialogContext TryShowItemGotBigDialog(List<SimpleItemStruct> itemList, string reason = null, string tipsText = null, uint orderId = 0 /* Metadata: 0x00B0E49F */, ItemGotBigDialogContext.EffectType effectType = ItemGotBigDialogContext.EffectType.Default /* Metadata: 0x00B0E4A3 */) => default; // 0x0000000181ABB820-0x0000000181ABB9A0
	// [XID] // 0x0000000189AAB010-0x0000000189AAB030
	public static ItemGotBigDialogContext TryShowItemGotBonusBigDialog(List<SimpleItemStruct> basicItemList, List<SimpleItemStruct> bonusItemList, string title = null, string reason = null, string tipsText = null, uint orderId = 0 /* Metadata: 0x00B0E4A7 */, bool showBonusTips = false /* Metadata: 0x00B0E4AB */, ItemGotBigDialogContext.EffectType effectType = ItemGotBigDialogContext.EffectType.Default /* Metadata: 0x00B0E4AC */) => default; // 0x0000000181AB7030-0x0000000181AB71F0
	// [XID] // 0x0000000189AB29A0-0x0000000189AB29C0
	public static void TryShowChapterDialog(uint chapterId, ChapterState chapterState, bool isTimeUnlock) {} // 0x0000000181AC6CA0-0x0000000181AC7020
	// [XID] // 0x0000000189ABA4D0-0x0000000189ABA4F0
	public static void TryShowTutorialDialogInQuest(uint tutorialId) {} // 0x0000000181AC8340-0x0000000181AC8550
	// [XID] // 0x0000000189AC1E60-0x0000000189AC1E80
	public static void TryShowQuestPage(uint mainQuestId) {} // 0x0000000181AB4680-0x0000000181AB4890
	// [IDTag] // 0x0000000189AC9410-0x0000000189AC9450
	// [XID] // 0x0000000189AC9410-0x0000000189AC9450
	public static void TryShowItemTipsDialog(uint itemId) {} // 0x0000000181AC2510-0x0000000181AC2660
	// [IDTag] // 0x0000000189AD4000-0x0000000189AD4040
	// [XID] // 0x0000000189AD4000-0x0000000189AD4040
	public static void TryShowItemTipsDialog(BagItem item) {} // 0x0000000181AC23E0-0x0000000181AC2510
	// [XID] // 0x0000000189ADEC30-0x0000000189ADEC50
	public static void TryShowItemExceedLimitDialog(Action<bool> callback = null) {} // 0x0000000181AB0140-0x0000000181AB0270
	// [XID] // 0x0000000189AE65C0-0x0000000189AE65E0
	public static void ShowBlackScreen(float durationToBlack, float durationKeepBlack, float durationFromBlack, Action callback, Action finishCallback) {} // 0x0000000181AB20A0-0x0000000181AB2380
	// [XID] // 0x0000000189AEDDF0-0x0000000189AEDE10
	public static void TryShowBulletinEmptyPage(bool isPopNotice) {} // 0x0000000181AC6780-0x0000000181AC6A60
	// [XID] // 0x0000000189AF5620-0x0000000189AF5640
	public static void TryShowMonthlyCardPage() {} // 0x0000000181AC79D0-0x0000000181AC7C30
	// [XID] // 0x0000000189AFCB30-0x0000000189AFCB50
	public static void TryShowSystemOpenUIDialog(uint openUIID) {} // 0x0000000181AB8E80-0x0000000181AB90F0
	// [IDTag] // 0x0000000189B042B0-0x0000000189B042F0
	// [XID] // 0x0000000189B042B0-0x0000000189B042F0
	public static void TryShowFriendEditDialog(SocialDetailStruct socialData, FriendInformationDialogType forceType = FriendInformationDialogType.NORMAL /* Metadata: 0x00B0E4B0 */, EditMenuTarget target = null, RectTransform restrictRect = null) {} // 0x0000000181AB37E0-0x0000000181AB3B10
	// [IDTag] // 0x0000000189B0EAB0-0x0000000189B0EAF0
	// [XID] // 0x0000000189B0EAB0-0x0000000189B0EAF0
	public static void TryShowFriendEditDialog(SocialDetail serverData, FriendInformationDialogType forceType = FriendInformationDialogType.NORMAL /* Metadata: 0x00B0E4B4 */, EditMenuTarget target = null, RectTransform restrictRect = null) {} // 0x0000000181AB3B10-0x0000000181AB3D20
	// [XID] // 0x0000000189B18E80-0x0000000189B18EA0
	public static void TryShowFriendInformationDialog(SocialDetailStruct socialData, FriendInformationDialogType forceType = FriendInformationDialogType.NORMAL /* Metadata: 0x00B0E4B8 */) {} // 0x0000000181AC61F0-0x0000000181AC6410
	// [XID] // 0x0000000189B204D0-0x0000000189B204F0
	public static void TryShowSelfInformationDialog() {} // 0x0000000181AC4DD0-0x0000000181AC4FA0
	// [XID] // 0x0000000189B27B70-0x0000000189B27B90
	public static void TryShowWorldLevelDialog() {} // 0x0000000181AB54E0-0x0000000181AB57D0
	// [XID] // 0x0000000189B2EE90-0x0000000189B2EEB0
	public static void TryShowWorldLevelChangeDialog(bool isChange) {} // 0x0000000181AC50A0-0x0000000181AC5370
	// [XID] // 0x0000000189B36750-0x0000000189B36770
	public static void TryShowCoopCGDialog(uint cgConfigId) {} // 0x0000000181AB14A0-0x0000000181AB15B0
	// [XID] // 0x0000000189B3DFC0-0x0000000189B3DFE0
	public static void TryShowCurrentCoopPage() {} // 0x0000000181AB0480-0x0000000181AB0610
	// [XID] // 0x0000000189B45CF0-0x0000000189B45D10
	public static void TryShowCoopDialog(string param, CoopDialogType type) {} // 0x0000000181AB68B0-0x0000000181AB6B60
	// [XID] // 0x0000000189B4D190-0x0000000189B4D1B0
	public static void TryShowDebugMessage(string content) {} // 0x0000000181AC2DB0-0x0000000181AC2FF0
	// [IDTag] // 0x0000000189B54990-0x0000000189B549D0
	// [XID] // 0x0000000189B54990-0x0000000189B549D0
	public static void TryShowMessage(string content) {} // 0x0000000181AB0270-0x0000000181AB0350
	// [IDTag] // 0x0000000189B5F3F0-0x0000000189B5F430
	// [XID] // 0x0000000189B5F3F0-0x0000000189B5F430
	public static void TryShowMessage(string content, Color bgColor, bool showBackground) {} // 0x0000000181AB0350-0x0000000181AB0480
	// [XID] // 0x0000000189B69AE0-0x0000000189B69B00
	public static void TryShowInLevelMessage(string content, bool needMap = false /* Metadata: 0x00B0E4BC */, bool isShowBackground = false /* Metadata: 0x00B0E4BD */) {} // 0x0000000181AB2740-0x0000000181AB2860
	// [XID] // 0x0000000189B631E0-0x0000000189B63200
	public static void TryShowInfoMessage(string content, bool discardIfDuplicated = false /* Metadata: 0x00B0E4BE */, UIShowPriority priority = UIShowPriority.Normal /* Metadata: 0x00B0E4BF */, Action releaseCallback = null) {} // 0x0000000181AB6110-0x0000000181AB6240
	// [XID] // 0x0000000189B9B820-0x0000000189B9B840
	public static void TryShowRootInfoMessage(string content, bool discardIfDuplicated = false /* Metadata: 0x00B0E4C3 */, UIShowPriority priority = UIShowPriority.Error /* Metadata: 0x00B0E4C4 */) {} // 0x0000000181AC8000-0x0000000181AC8110
	// [XID] // 0x0000000189B7FC10-0x0000000189B7FC30
	public static void TryShowInfoMessageWithoutBlockInput(string content, bool discardIfDuplicated = false /* Metadata: 0x00B0E4C8 */, UIShowPriority priority = UIShowPriority.Normal /* Metadata: 0x00B0E4C9 */) {} // 0x0000000181ABA670-0x0000000181ABA780
	// [XID] // 0x0000000189B87680-0x0000000189B876A0
	public static void ShowNameDialog(Action callback) {} // 0x0000000181AC74A0-0x0000000181AC7650
	// [XID] // 0x0000000189B8E7F0-0x0000000189B8E810
	public static void CloseNameDialog() {} // 0x0000000181AC7020-0x0000000181AC7310
	// [XID] // 0x0000000189B95CD0-0x0000000189B95CF0
	public static void DispatchQuestAudio(QuestProxy quest) {} // 0x0000000181AB73A0-0x0000000181AB7490
	// [XID] // 0x0000000189B9D210-0x0000000189B9D230
	public static void ShowErrorDialog(string errCode, string title = "" /* Metadata: 0x00B0E4CD */, Action<bool> continueCallback = null, bool isRepeat = false /* Metadata: 0x00B0E4D1 */, int fontSize = 24 /* Metadata: 0x00B0E4D2 */) {} // 0x0000000181AB2F70-0x0000000181AB3230
	// [XID] // 0x0000000189AA6280-0x0000000189AA62A0
	public static void ShowQueueUpDialog(Action<bool> callback) {} // 0x0000000181AB9150-0x0000000181AB94D0
	// [XID] // 0x0000000189BABEF0-0x0000000189BABF10
	public static void CloseQueueUpDialog() {} // 0x0000000181ABFCB0-0x0000000181ABFDD0
	// [XID] // 0x0000000189BB3560-0x0000000189BB3580
	public static void ShowRetcodeDialog(int retcode, string debugTag = "" /* Metadata: 0x00B0E4D6 */, ReportErrorCode errCode = ReportErrorCode.None /* Metadata: 0x00B0E4DA */, Action<bool> continueCallback = null, bool isRepeat = false /* Metadata: 0x00B0E4DE */) {} // 0x0000000181ABA150-0x0000000181ABA3C0
	// [XID] // 0x0000000189BC57C0-0x0000000189BC57E0
	public static Transform AddChildFromPrefab(Transform parent, Transform itemPrefab, string name) => default; // 0x0000000181AB2660-0x0000000181AB2740
	// [XID] // 0x0000000189BCD220-0x0000000189BCD240
	public static Vector3 WorldToUIPoint(Vector3 pos, bool clampZ = true /* Metadata: 0x00B0E4DF */) => default; // 0x0000000181AC8E20-0x0000000181AC9140
	// [XID] // 0x0000000189BD4720-0x0000000189BD4740
	public static Vector3 UIToWorldPoint(Vector3 screenPos, float depthZ = 0f /* Metadata: 0x00B0E4E0 */) => default; // 0x0000000181ABD790-0x0000000181ABDA40
	// [XID] // 0x0000000189BDC290-0x0000000189BDC2B0
	public static void TrySetActive(GameObject gameObject, bool active, bool optActive = true /* Metadata: 0x00B0E4E4 */) {} // 0x0000000181ABE3E0-0x0000000181ABE540
	// [XID] // 0x00000001895E8AB0-0x00000001895E8AD0
	public static void TrySetLightActive(GameObject gameObject, bool active) {} // 0x0000000181AB7D60-0x0000000181AB7E60
	// [XID] // 0x00000001895F0340-0x00000001895F0360
	public static void TrySetGameObjectActive(Component component, bool active) {} // 0x0000000181AC9530-0x0000000181AC96A0
	// [XID] // 0x00000001895F7DB0-0x00000001895F7DD0
	public static void TrySetGameObjectLightActive(Component component, bool active) {} // 0x0000000181AC2660-0x0000000181AC2780
	// [XID] // 0x00000001895FF150-0x00000001895FF170
	public static void TrySetParentGameObjectActive(Component component, bool active) {} // 0x0000000181ABF200-0x0000000181ABF440
	// [XID] // 0x00000001896069F0-0x0000000189606A10
	public static void LogSetActiveInMainPage(UnityEngine.Object obj, bool active) {} // 0x0000000181AB5960-0x0000000181AB5BE0
	// [XID] // 0x000000018960E370-0x000000018960E390
	public static void TryRebindMonoToggler(Component component) {} // 0x0000000181AB57D0-0x0000000181AB5900
	// [XID] // 0x00000001896159C0-0x00000001896159E0
	public static bool CheckAnmRebindToLight() => default; // 0x0000000181AC4370-0x0000000181AC4430
	// [XID] // 0x000000018961D1A0-0x000000018961D1C0
	public static bool CheckGameObjectActive(Component component) => default; // 0x0000000181AC4FA0-0x0000000181AC50A0
	// [XID] // 0x00000001896246D0-0x00000001896246F0
	public static void TrySetGameObjectActiveByReason(Component component, bool active, int reasonId) {} // 0x0000000181AB5F30-0x0000000181AB6110
	// [XID] // 0x000000018962BE10-0x000000018962BE30
	public static void TrySetParentGameObjectActiveByReason(Component component, bool active, int reasonId) {} // 0x0000000181ABB090-0x0000000181ABB270
	// [XID] // 0x0000000189633950-0x0000000189633970
	public static bool GameObjectActiveInHierarchy(Component component) => default; // 0x0000000181AB6B60-0x0000000181AB6C70
	// [XID] // 0x000000018963B230-0x000000018963B250
	public static void TrySetText(UnityEngine.UI.Text textComp, string str) {} // 0x0000000181AC2780-0x0000000181AC28A0
	// [XID] // 0x0000000189642960-0x0000000189642980
	public static string ReplaceMultiLine(string content) => default; // 0x0000000181AB1820-0x0000000181AB1910
	// [IDTag] // 0x000000018964A090-0x000000018964A0D0
	// [XID] // 0x000000018964A090-0x000000018964A0D0
	public static string GetFormatTextMapString(string text, object arg0) => default; // 0x0000000181AB3EF0-0x0000000181AB3FE0
	// [IDTag] // 0x00000001896549E0-0x0000000189654A20
	// [XID] // 0x00000001896549E0-0x0000000189654A20
	public static string GetFormatTextMapString(string text, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000181AB3FE0-0x0000000181AB40D0
	// [IDTag] // 0x00000001896665E0-0x0000000189666620
	// [XID] // 0x00000001896665E0-0x0000000189666620
	public static string GetFormatString(string format, object arg0) => default; // 0x0000000181ABC410-0x0000000181ABC5D0
	// [IDTag] // 0x0000000189671540-0x0000000189671580
	// [XID] // 0x0000000189671540-0x0000000189671580
	public static string GetFormatString(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000181ABC5D0-0x0000000181ABC790
	// [XID] // 0x00000001896832D0-0x00000001896832F0
	public static string GetTextMapFormatString(string textMapId, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000181ABC320-0x0000000181ABC410
	// [XID] // 0x0000000189692B30-0x0000000189692B50
	public static string GetPluralFormatString(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000181AC1190-0x0000000181AC17B0
	// [XID] // 0x00000001896A1580-0x00000001896A15A0
	public static string GetPlainText(string text) => default; // 0x0000000181AC1080-0x0000000181AC1190
	// [XID] // 0x00000001896A8A60-0x00000001896A8A80
	public static string ColorToHex(Color32 color) => default; // 0x0000000181AB0010-0x0000000181AB0140
	// [XID] // 0x00000001896AFBC0-0x00000001896AFBE0
	public static string ColorToHexFormat(Color32 color) => default; // 0x0000000181AB1C20-0x0000000181AB1D30
	// [XID] // 0x00000001896B7530-0x00000001896B7550
	public static string ColorFormat(Color32 color, string str) => default; // 0x0000000181AB1F90-0x0000000181AB20A0
	// [XID] // 0x00000001896BE680-0x00000001896BE6A0
	public static bool CheckInUICamera(Vector3 pos) => default; // 0x0000000181AB8C00-0x0000000181AB8D90
	// [XID] // 0x00000001896C5F10-0x00000001896C5F30
	public static char OnValidateInput(string text, int charIndex, char addedChar) => default; // 0x0000000181AB3230-0x0000000181AB3330
	// [XID] // 0x00000001896CD5E0-0x00000001896CD600
	public static void ScrollScroller(InputActionEvent actionEvent, ScrollRect scrollRect, bool forceReverseDownEventSign = false /* Metadata: 0x00B0E4E5 */) {} // 0x0000000181AB0610-0x0000000181AB0840
	// [XID] // 0x00000001896D4A70-0x00000001896D4A90
	private static float CameraClampZ(Camera camera, float z) => default; // 0x0000000181AB8670-0x0000000181AB87A0
	// [XID] // 0x00000001896DC0D0-0x00000001896DC0F0
	public static int FloorToIntCustom(float num) => default; // 0x0000000181AC98E0-0x0000000181AC99D0
	// [XID] // 0x00000001896E3840-0x00000001896E3860
	public static Color Str2Color(string name) => default; // 0x0000000181ABF690-0x0000000181ABFAB0
	// [XID] // 0x00000001896EACB0-0x00000001896EACD0
	public static Color GetMonsterLevelColor(int monsterLevel, int avatarLevel) => default; // 0x0000000181AC4430-0x0000000181AC4610
	// [XID] // 0x00000001896F2040-0x00000001896F2060
	public static Color GetDungeonLevelColor(int dungeonLevel, int avatarLevel, int limitLevel) => default; // 0x0000000181AB2DD0-0x0000000181AB2F70
	// [XID] // 0x00000001896F9A20-0x00000001896F9A40
	public static Color GetDungeonRecommendLevelColor(int dungeonLevel, int avatarLevel) => default; // 0x0000000181AB4CD0-0x0000000181AB4E20
	// [XID] // 0x0000000189701270-0x0000000189701290
	public static string GetTransformPath(Transform t) => default; // 0x0000000181ABFAB0-0x0000000181ABFCB0
	// [XID] // 0x0000000189708940-0x0000000189708960
	public static uint GetDungeonActivityMaxMultiFactor(uint dungeonId) => default; // 0x0000000181ABB4F0-0x0000000181ABB820
	// [XID] // 0x0000000189710230-0x0000000189710250
	public static void TryShowNotOpenTip(OpenStateType type) {} // 0x0000000181AB53E0-0x0000000181AB54E0
	// [XID] // 0x0000000189717650-0x0000000189717670
	public static string GetShowNotOpenTip(OpenStateType type) => default; // 0x0000000181AB7490-0x0000000181AB7710
	// [XID] // 0x000000018975D9A0-0x000000018975D9C0
	public static int LeftIndex(int total, int curr, int step) => default; // 0x0000000181AC4210-0x0000000181AC42E0
	// [XID] // 0x0000000189764F30-0x0000000189764F50
	public static int RightIndex(int total, int curr, int step) => default; // 0x0000000181AC6570-0x0000000181AC6650
	// [XID] // 0x000000018976C9B0-0x000000018976C9D0
	public static int UpIndex(int total, int curr, int step) => default; // 0x0000000181AB1EC0-0x0000000181AB1F90
	// [XID] // 0x0000000189773E50-0x0000000189773E70
	public static int DownIndex(int total, int curr, int step) => default; // 0x0000000181AC2CD0-0x0000000181AC2DB0
	// [XID] // 0x000000018977B540-0x000000018977B560
	public static DateTime UnixTimeStampToDateTime(double unixTimeStamp) => default; // 0x0000000181AB6ED0-0x0000000181AB7030
	// [XID] // 0x0000000189783080-0x00000001897830A0
	public static string SecondsToString(uint spanSeconds) => default; // 0x0000000181AC46C0-0x0000000181AC47E0
	// [XID] // 0x000000018978A570-0x000000018978A590
	public static void TryShowMPInvitationDialog(MPRemindType remindType = MPRemindType.GuestApplying /* Metadata: 0x00B0E4E6 */) {} // 0x0000000181AB50A0-0x0000000181AB53E0
	// [XID] // 0x0000000189791CF0-0x0000000189791D10
	public static void TryCloseMPInvitationDialog() {} // 0x0000000181AC7EA0-0x0000000181AC8000
	// [XID] // 0x00000001897A12D0-0x00000001897A12F0
	public static void TryShowMPInvitationListDialog() {} // 0x0000000181ABEF80-0x0000000181ABF200
	// [XID] // 0x00000001897A8880-0x00000001897A88A0
	public static void TryShowMatchSuccessDialog() {} // 0x0000000181AC0320-0x0000000181AC0660
	// [XID] // 0x00000001897B0300-0x00000001897B0320
	public static string GetNameCardPicPath(uint guid, int index = 0 /* Metadata: 0x00B0E4EA */) => default; // 0x0000000181ABE0D0-0x0000000181ABE1C0
	// [XID] // 0x00000001897B7FF0-0x00000001897B8010
	public static string GetEmbeddedTextMap(string textId) => default; // 0x0000000181AC3F70-0x0000000181AC4070
	// [XID] // 0x00000001899DF6E0-0x00000001899DF700
	public static string GetLevelString(uint level) => default; // 0x0000000181AB0940-0x0000000181AB0A40
	// [XID] // 0x00000001897D6300-0x00000001897D6320
	public static string GetTimeString(uint totalTime) => default; // 0x0000000181AB4990-0x0000000181AB4C40
	// [XID] // 0x00000001897DDC00-0x00000001897DDC20
	public static string GetPlayerMarkIcon(int index, bool self) => default; // 0x0000000181AC48F0-0x0000000181AC4AB0
	// [XID] // 0x00000001897E54F0-0x00000001897E5510
	public static MarkIconType GetPlayerMarkIconType(int index) => default; // 0x0000000181ABA780-0x0000000181ABA840
	// [IDTag] // 0x00000001897ED070-0x00000001897ED0B0
	// [XID] // 0x00000001897ED070-0x00000001897ED0B0
	public static void AddMarkToLayer(MonoMapMark mark, RectTransform layerTrans) {} // 0x0000000181AB4350-0x0000000181AB4540
	// [IDTag] // 0x00000001897F77A0-0x00000001897F77E0
	// [XID] // 0x00000001897F77A0-0x00000001897F77E0
	public static void AddMarkToLayer(MonoMapMark mark, RectTransform[] layerTrans) {} // 0x0000000181AB4170-0x0000000181AB4350
	// [XID] // 0x000000018981E6F0-0x000000018981E710
	public static double GetResourceSizeFloat(long size, ResourceSizeType sizeType) => default; // 0x0000000181ABDC90-0x0000000181ABDDA0
	// [XID] // 0x0000000189825BB0-0x0000000189825BD0
	public static string GetResourceSizeStr(long size, ResourceSizeType sizeType) => default; // 0x0000000181AB79E0-0x0000000181AB7D60
	// [XID] // 0x000000018982D300-0x000000018982D320
	public static void ShowResinRecoveryHint(MonoMaterialItemRow ins, ref Coroutine updateRecoveryTextCoroutineOfResin) {} // 0x0000000181AB87A0-0x0000000181AB8AA0
	[DebuggerHidden] // 0x0000000189834A60-0x0000000189834AA0
	// [XID] // 0x0000000189834A60-0x0000000189834AA0
	private static IEnumerator UpdateRecoveryTextOfResin(MonoMaterialItemRow ins) => default; // 0x0000000181ABE000-0x0000000181ABE0D0
	// [XID] // 0x000000018983F050-0x000000018983F070
	public static void TryGetResin() {} // 0x0000000181AC38A0-0x0000000181AC39A0
	// [XID] // 0x00000001898466D0-0x00000001898466F0
	public static string SwitchChallengePattern(string template, uint challengeIndex) => default; // 0x0000000181AC39A0-0x0000000181AC3F70
	// [XID] // 0x000000018984DC80-0x000000018984DCA0
	public static string GetLimitTimeStr(TimeSpan span) => default; // 0x0000000181ABDB10-0x0000000181ABDC90
	// [XID] // 0x0000000189854D40-0x0000000189854D60
	public static string GetShopItemRefreshTime(ShopItem shopItem) => default; // 0x0000000181AB1200-0x0000000181AB1350
	// [XID] // 0x000000018985C500-0x000000018985C520
	public static string GetShopItemLimitInfo(ShopItem shopItem) => default; // 0x0000000181AC0040-0x0000000181AC0320
	// [XID] // 0x0000000189863E60-0x0000000189863E80
	public static string GetShopRefreshTime(ulong nextRefreshTime, string infoText = "SHOP_REFRESH_COUNTDOWN" /* Metadata: 0x00B0E4EE */, bool brief = false /* Metadata: 0x00B0E508 */) => default; // 0x0000000181ABAB80-0x0000000181ABAFA0
	// [XID] // 0x000000018986B190-0x000000018986B1B0
	public static string GetMonthString(uint month) => default; // 0x0000000181ABAFA0-0x0000000181ABB090
	// [XID] // 0x0000000189872560-0x0000000189872580
	public static string GetRandomDungeonDateTips(string dungeonName, List<uint> dungeonList) => default; // 0x0000000181AB64E0-0x0000000181AB68B0
	// [XID] // 0x000000018987A1D0-0x000000018987A1F0
	private static string GetTextMapAbyssusDate(uint date) => default; // 0x0000000181ABB360-0x0000000181ABB4F0
	// [XID] // 0x0000000189881370-0x0000000189881390
	public static string GetActivityCondText(uint activityID, uint condID) => default; // 0x0000000181ABBC60-0x0000000181ABC1C0
	// [XID] // 0x0000000189888940-0x0000000189888960
	public static void TryShowTrialAvatarPreviewPage(uint configId) {} // 0x0000000181AC5560-0x0000000181AC5830
	// [XID] // 0x000000018988FC80-0x000000018988FCA0
	public static void TryShowActivityPage(NewActivityType activityType) {} // 0x0000000181AC8CA0-0x0000000181AC8E20
	// [XID] // 0x0000000189897140-0x0000000189897160
	public static string[] TrySplitString(string str, char charSeparator) => default; // 0x0000000181AC9140-0x0000000181AC92A0
	// [XID] // 0x000000018989E680-0x000000018989E6A0
	public static string GetElementTriggerStr(ElementType type) => default; // 0x0000000181AC5830-0x0000000181AC5950
	// [IDTag] // 0x00000001898AD7D0-0x00000001898AD810
	// [XID] // 0x00000001898AD7D0-0x00000001898AD810
	public static void RefreshItemSlot(MonoItemSlot itemSlot, IdCountStrConfig rewardConfig) {} // 0x0000000181ABA960-0x0000000181ABAAA0
	// [IDTag] // 0x00000001898B7E50-0x00000001898B7E90
	// [XID] // 0x00000001898B7E50-0x00000001898B7E90
	public static void RefreshItemSlot(MonoBagProxySlot itemSlot, IdCountStrConfig rewardConfig) {} // 0x0000000181ABA840-0x0000000181ABA960
	// [XID] // 0x00000001898C2560-0x00000001898C2580
	public static Transform GetElementSwitchVariant(Transform transform, MonoElementSwitch elementSwitch, string name) => default; // 0x0000000181AB3D20-0x0000000181AB3EF0
	// [XID] // 0x00000001898C9F80-0x00000001898C9FA0
	public static MonoUIContainer GetVarientContainer(Transform transform, MonoElementSwitch elementSwitch, string varientName) => default; // 0x0000000181AC5B80-0x0000000181AC5D10
	// [XID] // 0x00000001898D1600-0x00000001898D1620
	public static GameObject GetVarientGameObject(Transform transform, MonoElementSwitch elementSwitch, string varientName) => default; // 0x0000000181AC7310-0x0000000181AC74A0
	// [XID] // 0x00000001898D8E40-0x00000001898D8E60
	public static Button GetVarientContainerButton(Transform transform, MonoElementSwitch elementSwitch, string varientName) => default; // 0x0000000181AB2BF0-0x0000000181AB2DD0
	// [XID] // 0x00000001898E0B30-0x00000001898E0B50
	private static void SendCurrentStatus(Transform transform, MonoElementSwitch elementSwitch, string name) {} // 0x0000000181ABCAC0-0x0000000181ABD430
	// [XID] // 0x00000001898E8670-0x00000001898E8690
	public static void TryShowAntiAddictDialog(int type, string msg, Action<bool> callback) {} // 0x0000000181AC1A00-0x0000000181AC1BB0
	// [XID] // 0x00000001898EFE50-0x00000001898EFE70
	public static void TryShowKoreaAntiAddictDialog(string title, string desc, Action<bool> callback, GeneralDialogContext.GeneralDialogType dialogType = GeneralDialogContext.GeneralDialogType.SINGLE_BUTTON /* Metadata: 0x00B0E509 */, string okBtnText = "\uFFFD" /* Metadata: 0x00B0E50D */, string cancelBtnText = null) {} // 0x0000000181AC0740-0x0000000181AC0A40
	// [XID] // 0x00000001898F7690-0x00000001898F76B0
	public static void TryShowPermissionStorageDialog(GeneralPermissionDialogContext.DialogType type, string msg, Action<bool> callback) {} // 0x0000000181AB0F70-0x0000000181AB1200
	// [XID] // 0x00000001898FEDA0-0x00000001898FEDC0
	public static string GetDownloadInfo(long downloadSize, long totalSize, long downloadSpeed) => default; // 0x0000000181AB6C70-0x0000000181AB6ED0
	// [XID] // 0x0000000189906540-0x0000000189906560
	public static Vector3 GetRectCenterPostion(RectTransform rect) => default; // 0x0000000181ABD430-0x0000000181ABD790
	// [XID] // 0x000000018990DF80-0x000000018990DFA0
	public static bool IsVisibleInMask(SmoothMask mask, RectTransform uiTrans) => default; // 0x0000000181AB3410-0x0000000181AB37E0
	// [XID] // 0x00000001899156F0-0x0000000189915710
	public static void GetToMaskCenterRatio(SmoothMask mask, RectTransform uiTrans, out float xRatio, out float yRatio) {
		xRatio = default;
		yRatio = default;
	} // 0x0000000181AC3470-0x0000000181AC38A0
	// [XID] // 0x000000018991D120-0x000000018991D140
	public static Rect RectTransformToScreenSpace(RectTransform transform, Camera camera) => default; // 0x0000000181AB7710-0x0000000181AB79E0
	// [XID] // 0x000000018992EEE0-0x000000018992EF00
	public static void SetMassiveText(Transform textRoot, string content, int maxTextCountInOneTextComponent = 200 /* Metadata: 0x00B0E517 */) {} // 0x0000000181ABE950-0x0000000181ABEF80
	// [XID] // 0x0000000189936330-0x0000000189936350
	public static bool TrySavePhoto(RenderTexture savedImageTexture) => default; // 0x0000000181AB94D0-0x0000000181AB9F30
	// [XID] // 0x000000018993DCD0-0x000000018993DCF0
	private static bool DoSaveOnPC(byte[] data, string fileName) => default; // 0x0000000181AC2240-0x0000000181AC23E0
	// [XID] // 0x0000000189945420-0x0000000189945440
	public static int GetUIBorderOffsetDelta() => default; // 0x0000000181AC2B60-0x0000000181AC2CD0
	// [XID] // 0x000000018994C960-0x000000018994C980
	public static void OpenDungeonTeamPage(uint dungeonId, uint pointId) {} // 0x0000000181AB5BE0-0x0000000181AB5E20
	// [XID] // 0x0000000189954060-0x0000000189954080
	private static void CheckMultiplayer(uint dungeonId, uint pointId) {} // 0x0000000181AC5EC0-0x0000000181AC60A0
	// [XID] // 0x000000018995B8D0-0x000000018995B8F0
	private static void CheckServerAnnounce(DungeonExcelConfig config, uint pointId, bool multiplayer = false /* Metadata: 0x00B0E51B */, bool bigWorldMultiplayer = false /* Metadata: 0x00B0E51C */) {} // 0x0000000181AB8020-0x0000000181AB8670
	// [XID] // 0x00000001899634C0-0x00000001899634E0
	private static void HintMPInvite(DungeonExcelConfig config, uint pointId) {} // 0x0000000181ABDDA0-0x0000000181ABE000
	// [XID] // 0x000000018996A800-0x000000018996A820
	private static void ConfirmTeam(DungeonExcelConfig config, uint pointId, bool multiplayer = false /* Metadata: 0x00B0E51D */) {} // 0x0000000181AB7E60-0x0000000181AB8020
	// [XID] // 0x0000000189972560-0x0000000189972580
	public static Vector3 GetVec3(string str) => default; // 0x0000000181ABE6D0-0x0000000181ABE950

	// Extension methods
	// [XID] // 0x0000000189BBABA0-0x0000000189BBABE0
	public static void RectTransMatchOther(this RectTransform rt, RectTransform other, Vector3 posOffset) {} // 0x0000000181AB4E20-0x0000000181AB50A0
	// [XID] // 0x000000018971F0F0-0x000000018971F130
	public static void SetAnchoredPositionY(this RectTransform rectTrans, float y) {} // 0x0000000181ABE5F0-0x0000000181ABE6D0
	// [XID] // 0x00000001897294C0-0x0000000189729500
	public static void SetAnchoredPositionX(this RectTransform rectTrans, float x) {} // 0x0000000181AC3150-0x0000000181AC3240
	// [XID] // 0x0000000189733BE0-0x0000000189733C20
	public static void SetLeft(this RectTransform rt, float left) {} // 0x0000000181AB6240-0x0000000181AB6330
	// [XID] // 0x000000018973EB20-0x000000018973EB60
	public static void SetRight(this RectTransform rt, float right) {} // 0x0000000181AC2140-0x0000000181AC2240
	// [XID] // 0x00000001897490C0-0x0000000189749100
	public static void SetTop(this RectTransform rt, float top) {} // 0x0000000181AB4890-0x0000000181AB4990
	// [XID] // 0x00000001897533B0-0x00000001897533F0
	public static void SetBottom(this RectTransform rt, float bottom) {} // 0x0000000181ABB270-0x0000000181ABB360
	public static Tuple<Tkey, TValue> ToTuple<Tkey, TValue>(this KeyValuePair<Tkey, TValue> pair) => default;
	// [XID] // 0x0000000189809590-0x00000001898095D0
	public static void SetValueNoCallback(this Dropdown dropdown, int value) {} // 0x0000000181AC1EF0-0x0000000181AC2010
	// [XID] // 0x0000000189813AE0-0x0000000189813B20
	public static void AddOption(this Dropdown dropdown, string option) {} // 0x0000000181AB15B0-0x0000000181AB16D0
	// [XID] // 0x00000001899249D0-0x0000000189924A10
	public static string HighlightIgnoreCase(this string originStr, string pattern, string highlightFormat) => default; // 0x0000000181AB2380-0x0000000181AB2660
}

