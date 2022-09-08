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
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CodexQuestPageContext : BasePageContext // TypeDefIndex: 28511
{
	// Fields
	private MonoCodexQuestPage _pageMono; // 0x190
	private QuestType _currentQuestType; // 0x198
	private List<ChapterExcelConfig> _currentQuestChapterList; // 0x1A0
	private MonoCodexSubQuestTitleRow _lastClickedSubQuestRow; // 0x1A8
	private int _currentShowingChapterIndex; // 0x1B0
	private List<uint> _currentQuestIdList; // 0x1B8
	private List<ConfigCodexQuest> _currentQuestList; // 0x1C0
	private List<ConfigCodexQuest> _currentSortedQuestList; // 0x1C8
	private List<bool> _currentQuestStatusList; // 0x1D0
	private bool _isDetailRightArea; // 0x1D8
	private MonoCodexSubQuestTitleRow _lastNaviSelectedSubQuestRow; // 0x1E0
	private MonoCodexSubQuestContentItemRow _lastNaviSelectedSubQuestContentItemRow; // 0x1E8
	private MonoCodexSubQuestContentRow _lastSelectedSubQuestContentRow; // 0x1F0
	private MonoCodexSubQuestContentRow _firstSubQuestContentRow; // 0x1F8
	private MonoCodexQuestTitleRow _currentQuestTitleRow; // 0x200
	private CodexQuestUISceneComponent _uiSceneComp; // 0x208
	private Dictionary<uint, CodexItemState> _questStateDict; // 0x210
	private Dictionary<uint, MonoCodexQuestTitleRow> _questTitleRowDict; // 0x218
	private ConfigCodexQuest _currentProcessingConfig; // 0x220
	private MonoCodexQuestTitleRow _currentProcessingTitleRow; // 0x228
	private int _currentProcessingSubQuestIndex; // 0x230
	private Dictionary<uint, int> _selectIndexDict; // 0x238
	private uint _lastSelectMainQuestId; // 0x240
	private int _lastPlayingSound; // 0x244
	private MonoCodexSubQuestContentItemRow _lastPlayingSoundRow; // 0x248
	private int _currentSelectedSubQuestIndex; // 0x250
	private HashSet<uint> _initMainQuestSet; // 0x258
	private bool _setInitState; // 0x260
	private bool _firstGetSound; // 0x261
	private INavSelectable _currrentNaviSelected; // 0x268
	private JumpFrom _jumpFrom; // 0x270
	private bool _isFoldOrUnfolding; // 0x274
	private Coroutine _clickMainQuestRowCoroutine; // 0x278
	private Coroutine _clickSubQuestRowCoroutine; // 0x280
	private HashSet<uint> _existSoundSet; // 0x288
	private bool _needUpdateAfterGetAudios; // 0x290
	private ConfigCodexQuest _audioQuestConfig; // 0x298
	private Dictionary<CodexQuestTextType, string> _formatDict; // 0x2A0
	private Dictionary<int, QuestType> _dictIndex2QuestType; // 0x2A8

	// Nested types
	public enum JumpFrom // TypeDefIndex: 28512
	{
		CodexHomePage = 0,
		QuestPage = 1
	}

	// Constructors
	public CodexQuestPageContext() {} // Dummy constructor
	public CodexQuestPageContext(JumpFrom from) {} // 0x00000001811DC7B0-0x00000001811DCA70

	// Methods
	// [XID] // 0x00000001896C5F50-0x00000001896C5F70
	protected override void BindViewCallbacks() {} // 0x00000001811D33E0-0x00000001811D36A0
	// [XID] // 0x00000001896CD620-0x00000001896CD640
	private void OnConfirm() {} // 0x00000001811D6610-0x00000001811D67F0
	// [XID] // 0x00000001896D4AB0-0x00000001896D4AD0
	private void SwitchToArea(bool rightArea) {} // 0x00000001811D4DE0-0x00000001811D50D0
	// [XID] // 0x00000001896DC130-0x00000001896DC150
	private void OnBack() {} // 0x00000001811DC180-0x00000001811DC230
	// [XID] // 0x00000001896E3860-0x00000001896E3880
	private void RefreshView() {} // 0x00000001811D8D90-0x00000001811D9010
	// [XID] // 0x00000001896EACD0-0x00000001896EACF0
	private string GetTipsTypeText() => default; // 0x00000001811DC050-0x00000001811DC180
	// [XID] // 0x00000001896F2060-0x00000001896F2080
	private void RefreshQuestList(bool withAnimation) {} // 0x00000001811D5E20-0x00000001811D6200
	// [XID] // 0x00000001896F9A40-0x00000001896F9A60
	private void RefreshQuestRow(Transform trans, int index) {} // 0x00000001811D83A0-0x00000001811D8940
	// [XID] // 0x0000000189701290-0x00000001897012B0
	private void OnRowClick(int index) {} // 0x00000001811D3E00-0x00000001811D3EC0
	// [XID] // 0x0000000189708960-0x0000000189708980
	private void OnBackFromDetail() {} // 0x00000001811D2BF0-0x00000001811D2F60
	// [IDTag] // 0x00000001897102D0-0x0000000189710310
	// [XID] // 0x00000001897102D0-0x0000000189710310
	private void RefreshQuestDetail() {} // 0x00000001811D93F0-0x00000001811D98D0
	// [XID] // 0x000000018971AB30-0x000000018971AB50
	private void OnPrevChapter() {} // 0x00000001811DB0A0-0x00000001811DB160
	// [XID] // 0x0000000189721E30-0x0000000189721E50
	private void OnNextChapter() {} // 0x00000001811D2B10-0x00000001811D2BF0
	// [XID] // 0x0000000189729540-0x0000000189729560
	private void RefreshMainQuestItem(Transform trans, int index) {} // 0x00000001811DA810-0x00000001811DADB0
	// [XID] // 0x0000000189730D00-0x0000000189730D20
	private void OnClickMainQuestRow(MonoCodexQuestTitleRow row, ConfigCodexQuest config, int subQuestIndex) {} // 0x00000001811D8940-0x00000001811D8B40
	// [XID] // 0x0000000189738610-0x0000000189738630
	private void OnClickMainQuestRowImmediately(MonoCodexQuestTitleRow row, ConfigCodexQuest config, int subQuestIndex) {} // 0x00000001811D64A0-0x00000001811D6610
	// [XID] // 0x00000001897403B0-0x00000001897403D0
	private void OnLoadQuestConfig(uint mainQuestId, ConfigCodexQuest quest) {} // 0x00000001811D67F0-0x00000001811D6D30
	// [XID] // 0x0000000189747720-0x0000000189747740
	private void ClearStatus() {} // 0x00000001811DA320-0x00000001811DA570
	// [XID] // 0x000000018974EE90-0x000000018974EEB0
	private void RefreshSubQuestTitle(Transform trans, int index) {} // 0x00000001811D7C50-0x00000001811D7EB0
	// [XID] // 0x0000000189756560-0x0000000189756580
	private void SetInitState(MonoCodexSubQuestTitleRow firstRow) {} // 0x00000001811DA570-0x00000001811DA6F0
	// [XID] // 0x000000018975D9E0-0x000000018975DA00
	private void OnClickSubQuest(MonoCodexQuestTitleRow mainRow, MonoCodexSubQuestTitleRow row, ConfigCodexQuest config, int subQuestIndex) {} // 0x00000001811D7EB0-0x00000001811D80B0
	// [XID] // 0x0000000189764FB0-0x0000000189764FD0
	private void OnClickSubQuestImmediately(MonoCodexQuestTitleRow mainRow, MonoCodexSubQuestTitleRow row, ConfigCodexQuest config, int subQuestIndex) {} // 0x00000001811DA6F0-0x00000001811DA810
	// [XID] // 0x000000018976C9F0-0x000000018976CA10
	private void CheckSetViewed(MonoCodexQuestTitleRow row, ConfigCodexQuest config) {} // 0x00000001811D4480-0x00000001811D47A0
	// [IDTag] // 0x0000000189773E90-0x0000000189773ED0
	// [XID] // 0x0000000189773E90-0x0000000189773ED0
	private void RefreshQuestDetail(ConfigCodexQuest config, int subQuestIndex) {} // 0x00000001811D9070-0x00000001811D93F0
	// [XID] // 0x000000018977E700-0x000000018977E720
	private void RefreshSubQuestContent(Transform trans, int index) {} // 0x00000001811D3160-0x00000001811D33E0
	// [XID] // 0x0000000189785EB0-0x0000000189785ED0
	private void PureRefreshSubQuestContent(Transform trans, int index) {} // 0x00000001811DB160-0x00000001811DB3A0
	// [XID] // 0x000000018978D550-0x000000018978D570
	public void OnSelectDialogChanged(int subQuestIndex, ConfigCodexQuestItem questItem, int selectedIndex) {} // 0x00000001811D47A0-0x00000001811D4A00
	// [XID] // 0x0000000189794990-0x00000001897949B0
	private int CalcNeedShowItemCount(ConfigCodexQuestSubQuest subQuest) => default; // 0x00000001811D9C40-0x00000001811D9E30
	// [XID] // 0x000000018979CDA0-0x000000018979CDC0
	private uint GetNextItemId(ConfigCodexQuestItem item) => default; // 0x00000001811D80B0-0x00000001811D8290
	// [XID] // 0x00000001897A4200-0x00000001897A4220
	private ConfigCodexQuestItem GetItemByIndex(ConfigCodexQuestSubQuest subQuest, int index) => default; // 0x00000001811D4B90-0x00000001811D4D50
	// [XID] // 0x00000001897AB760-0x00000001897AB780
	private void RefreshSubQuestContentItem(Transform trans, int index) {} // 0x00000001811D6E00-0x00000001811D74A0
	// [XID] // 0x00000001897B35B0-0x00000001897B35D0
	private void ClickChooseDialog(int subQuestIndex, ConfigCodexQuestItem questItem) {} // 0x00000001811DB480-0x00000001811DB620
	// [XID] // 0x00000001897BB4F0-0x00000001897BB510
	private void QuerySounds() {} // 0x00000001811D3EC0-0x00000001811D4290
	// [XID] // 0x00000001897C2D10-0x00000001897C2D30
	public override void UpdateView() {} // 0x00000001811DC610-0x00000001811DC7B0
	// [XID] // 0x00000001897CA510-0x00000001897CA530
	private void PlaySound(MonoCodexSubQuestContentItemRow row, uint soundId) {} // 0x00000001811D6200-0x00000001811D6410
	// [XID] // 0x00000001897D1B30-0x00000001897D1B50
	private void PlayStartCallBack(int stub) {} // 0x00000001811DB620-0x00000001811DB6D0
	// [XID] // 0x00000001897D9A30-0x00000001897D9A50
	private void PlayEndCallBack(int stub) {} // 0x00000001811DB3A0-0x00000001811DB480
	// [XID] // 0x00000001897E0D10-0x00000001897E0D30
	private void StopPlaySound() {} // 0x00000001811DBA50-0x00000001811DBB70
	// [IDTag] // 0x00000001897E8370-0x00000001897E83B0
	// [XID] // 0x00000001897E8370-0x00000001897E83B0
	private string GetText(ConfigCodexQuestText text) => default; // 0x00000001811DBCF0-0x00000001811DC050
	// [IDTag] // 0x00000001897F3320-0x00000001897F3360
	// [XID] // 0x00000001897F3320-0x00000001897F3360
	private string GetText(params /* 0x000000018989F6F0-0x000000018989F700 */ ConfigCodexQuestText[] texts) => default; // 0x00000001811DBB70-0x00000001811DBCF0
	// [XID] // 0x0000000189804DA0-0x0000000189804DC0
	private void OnTabClicked(int index) {} // 0x00000001811D74A0-0x00000001811D7630
	// [XID] // 0x000000018980C350-0x000000018980C370
	private string GetTipsIconKey(QuestType type) => default; // 0x00000001811D8290-0x00000001811D83A0
	// [XID] // 0x0000000189813B40-0x0000000189813B60
	private void SetMenuTab() {} // 0x00000001811DB730-0x00000001811DBA50
	// [XID] // 0x000000018981B6B0-0x000000018981B6D0
	public override void SetupView() {} // 0x00000001811DC230-0x00000001811DC610
	// [XID] // 0x0000000189822CA0-0x0000000189822CC0
	public override void ClearView() {} // 0x00000001811D4290-0x00000001811D4380
	// [XID] // 0x000000018982A5D0-0x000000018982A5F0
	private void OnSetSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x00000001811D76C0-0x00000001811D7910
	// [XID] // 0x0000000189831940-0x0000000189831960
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001811D8C90-0x00000001811D8D90
	// [XID] // 0x0000000189839040-0x0000000189839060
	private bool HandleInputActionEventMain(InputActionEvent actionEvent) => default; // 0x00000001811D9F60-0x00000001811DA320
	// [XID] // 0x00000001898406C0-0x00000001898406E0
	private bool HandleInputActionEventDetail(InputActionEvent actionEvent) => default; // 0x00000001811D36A0-0x00000001811D3E00
	// [XID] // 0x0000000189847BB0-0x0000000189847BD0
	private void FocusTitleTrans(Transform trans) {} // 0x00000001811D8B40-0x00000001811D8C30
	// [XID] // 0x000000018984F380-0x000000018984F3A0
	private void FocusContentTrans(Transform trans, bool jumpToTitle = false /* Metadata: 0x00B0D8E9 */) {} // 0x00000001811D4A00-0x00000001811D4B90
	// [XID] // 0x0000000189856500-0x0000000189856520
	private bool TryNavigateNext(MonoCodexSubQuestContentRow subQuestContent, ref MonoCodexSubQuestContentItemRow curSelect) => default; // 0x00000001811D5B90-0x00000001811D5E20
	// [XID] // 0x000000018985D890-0x000000018985D8B0
	private bool TryNavigatePrev(MonoCodexSubQuestContentRow subQuestContent, ref MonoCodexSubQuestContentItemRow curSelect) => default; // 0x00000001811D2F60-0x00000001811D3160
	// [XID] // 0x0000000189865250-0x0000000189865270
	private bool TryNavigateToLast(MonoCodexSubQuestContentRow subQuestContent, ref MonoCodexSubQuestContentItemRow curSelect) => default; // 0x00000001811D5820-0x00000001811D5A90
	// [XID] // 0x000000018986C790-0x000000018986C7B0
	private void NaviSelectTitle(MonoCodexSubQuestContentRow subQuestContent) {} // 0x00000001811DAEC0-0x00000001811DB0A0
	// [XID] // 0x0000000189873BA0-0x0000000189873BC0
	private void SetButtonState(MonoCodexSubQuestContentItemRow row) {} // 0x00000001811D98D0-0x00000001811D9AE0
	// [XID] // 0x000000018987B650-0x000000018987B670
	private void OnNavigationUp() {} // 0x00000001811D54B0-0x00000001811D5820
	// [XID] // 0x00000001898827F0-0x0000000189882810
	private void OnNavigationDown() {} // 0x00000001811D50D0-0x00000001811D54B0
	// [XID] // 0x000000018988A020-0x000000018988A040
	private void SetCurrentQuestTitleRow(MonoCodexQuestTitleRow row) {} // 0x00000001811D9E30-0x00000001811D9F60
	// [XID] // 0x0000000189891480-0x00000001898914A0
	private void SetCurrentNaviSelected(INavSelectable selected) {} // 0x00000001811D5A90-0x00000001811D5B90
	// [XID] // 0x0000000189898AF0-0x0000000189898B10
	private void SetNaviSelectedSubQuest(MonoSimpleReusableList subList) {} // 0x00000001811DADB0-0x00000001811DAEC0
	// [XID] // 0x000000018989FD50-0x000000018989FD70
	private bool MainQuestTitleNavi(ContextEventType upOrDown) => default; // 0x00000001811D7910-0x00000001811D7C50
}

