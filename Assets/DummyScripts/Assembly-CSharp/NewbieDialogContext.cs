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

public sealed class NewbieDialogContext : BaseWidgetContext // TypeDefIndex: 30301
{
	// Fields
	private MonoNewbieDialog _dialogMono; // 0x168
	private ConfigGuideUIMaskAction _maskConfig; // 0x170
	private List<RectTransform> _maskTransList; // 0x178
	private List<BaseContext> _baseContextList; // 0x180
	private List<ConfigGuideWidgetContent> _showWidghtList; // 0x188
	private List<GameObject> _prefabObjList; // 0x190
	private List<string> _prefabObjPathList; // 0x198
	private bool _haveGlobalHint; // 0x1A0
	private bool _haveMaskHint; // 0x1A1
	private ConfigGuideWidgetContent _curMaskHintConfig; // 0x1A8
	private float INTERVAL_TIME; // 0x1B0
	private float intervalTime; // 0x1B4
	private bool enableInterval; // 0x1B8
	private bool isCurMainPage; // 0x1B9
	private static HashSet<string> DisableIntervalContextList; // 0x00
	private static HashSet<string> GlobalWhiteContextList; // 0x08
	private static HashSet<string> MainPageBlackContextList; // 0x10
	private static HashSet<string> DialogBlackContextList; // 0x18

	// Nested types
	private enum MaskResult // TypeDefIndex: 30302
	{
		Disable = 0,
		Duplicate = 1,
		Enable = 2,
		Break = 3
	}

	// Constructors
	public NewbieDialogContext() {} // Dummy constructor
	public NewbieDialogContext(ConfigGuideUIMaskAction actionConfig) {} // 0x000000018277D850-0x000000018277DA40
	static NewbieDialogContext() {} // 0x000000018277D5B0-0x000000018277D850

	// Methods
	// [XID] // 0x0000000189A16CE0-0x0000000189A16D00
	public override void SetupView() {} // 0x000000018277D350-0x000000018277D4D0
	// [XID] // 0x0000000189A1E360-0x0000000189A1E380
	public override void ClearView() {} // 0x0000000182778DC0-0x0000000182778F10
	// [XID] // 0x0000000189A25A40-0x0000000189A25A60
	protected override void BindViewCallbacks() {} // 0x0000000182778B60-0x0000000182778C60
	// [XID] // 0x0000000189A2CEA0-0x0000000189A2CEC0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018277CF60-0x000000018277D190
	// [XID] // 0x0000000189A34870-0x0000000189A34890
	public void ClickDialog() {} // 0x000000018277BDA0-0x000000018277BEE0
	// [XID] // 0x0000000189A3BC90-0x0000000189A3BCB0
	private MaskResult CheckAllMaskTrans() => default; // 0x000000018277AF10-0x000000018277B0B0
	// [XID] // 0x0000000189A43920-0x0000000189A43940
	private MaskResult ShowNormalMask(RectTransform maskTrans, ConfigGuideWidgetContent config) => default; // 0x0000000182777F40-0x0000000182778B60
	// [XID] // 0x0000000189A4AD50-0x0000000189A4AD70
	private MaskResult ShowSelectAvatarMask(RectTransform tabContainer, ConfigGuideWidgetContent config) => default; // 0x000000018277B110-0x000000018277B510
	// [XID] // 0x0000000189A52470-0x0000000189A52490
	private MaskResult ShowTabItemMask(RectTransform tabContainer, ConfigGuideWidgetContent config) => default; // 0x000000018277A9F0-0x000000018277AC50
	// [XID] // 0x0000000189A59DA0-0x0000000189A59DC0
	private MaskResult ShowSynthesisListItemMask(RectTransform tabContainer, ConfigGuideWidgetContent config) => default; // 0x0000000182778F10-0x0000000182779290
	// [XID] // 0x0000000189A61590-0x0000000189A615B0
	private MaskResult ShowQuestSelectItemMask(RectTransform tabContainer, ConfigGuideWidgetContent config, BaseContext curContext) => default; // 0x000000018277AD70-0x000000018277AF10
	// [XID] // 0x0000000189A69450-0x0000000189A69470
	private MaskResult ShowDynUIItemMask(RectTransform container, ConfigGuideWidgetContent config) => default; // 0x000000018277B6B0-0x000000018277B850
	// [XID] // 0x0000000189A70800-0x0000000189A70820
	private MaskResult ShowSlotMask(RectTransform scrollTrans, ConfigGuideWidgetContent config) => default; // 0x000000018277B850-0x000000018277BBE0
	// [XID] // 0x0000000189A780D0-0x0000000189A780F0
	private MaskResult ShowGridScrollerMask(RectTransform scrollTrans, ConfigGuideWidgetContent config) => default; // 0x000000018277BBE0-0x000000018277BDA0
	// [XID] // 0x0000000189A7F6C0-0x0000000189A7F6E0
	private MaskResult ShowSimpleListItemMask(RectTransform tabContainer, ConfigGuideWidgetContent config) => default; // 0x0000000182777D80-0x0000000182777F40
	// [XID] // 0x0000000189A873C0-0x0000000189A873E0
	private MaskResult ShowButtonMask(RectTransform maskTrans, ConfigGuideWidgetContent config) => default; // 0x0000000182778C60-0x0000000182778DC0
	// [XID] // 0x0000000189A8EC00-0x0000000189A8EC20
	private MaskResult ShowCharacterAvatarMask(RectTransform maskTrans, ConfigGuideWidgetContent config) => default; // 0x000000018277BEE0-0x000000018277C050
	// [XID] // 0x0000000189A96210-0x0000000189A96230
	private MaskResult ShowCharacterFuncMask(RectTransform maskTrans, ConfigGuideWidgetContent config, BaseContext curContext) => default; // 0x000000018277A840-0x000000018277A9F0
	// [XID] // 0x0000000189A9D760-0x0000000189A9D780
	private MaskResult ShowOnMask(BaseContext curContext, RectTransform maskTrans, ConfigGuideWidgetContent config) => default; // 0x0000000182779720-0x0000000182779A30
	// [XID] // 0x0000000189AA5010-0x0000000189AA5030
	public override void UpdateView() {} // 0x000000018277D4D0-0x000000018277D5B0
	// [XID] // 0x0000000189AAC7D0-0x0000000189AAC7F0
	private void UpdateAllMask() {} // 0x000000018277B510-0x000000018277B6B0
	// [XID] // 0x0000000189AB4010-0x0000000189AB4030
	protected override void PostProcessOfSetActive() {} // 0x000000018277D190-0x000000018277D230
	// [XID] // 0x0000000189ABBD70-0x0000000189ABBD90
	public override void SetActive(bool enable) {} // 0x000000018277D230-0x000000018277D350
	// [XID] // 0x0000000189AC3540-0x0000000189AC3560
	private void ShowMask(bool isInit = false /* Metadata: 0x00B10972 */) {} // 0x0000000182779290-0x00000001827794F0
	// [XID] // 0x0000000189ACAC10-0x0000000189ACAC30
	private void TryToShowPrefabs() {} // 0x0000000182777640-0x0000000182777D80
	// [XID] // 0x0000000189AD2640-0x0000000189AD2660
	private void ClearPrefabs() {} // 0x000000018277CB20-0x000000018277CE10
	// [XID] // 0x0000000189ADA0B0-0x0000000189ADA0D0
	private void TryToShowWidgets() {} // 0x000000018277C0B0-0x000000018277CB20
	// [XID] // 0x0000000189AE19B0-0x0000000189AE19D0
	private void HideHintItems() {} // 0x00000001827794F0-0x0000000182779720
	// [XID] // 0x0000000189AE9160-0x0000000189AE9180
	private bool HandleEmptyButton(ConfigGuideWidgetContent config) => default; // 0x0000000182779D40-0x000000018277A840
	// [XID] // 0x0000000189AF0F50-0x0000000189AF0F70
	public void SetProgress(float value) {} // 0x0000000182779A90-0x0000000182779CC0
	// [XID] // 0x0000000189AF83D0-0x0000000189AF83F0
	public override void OnDisconnect() {} // 0x000000018277CEA0-0x000000018277CF60
}

