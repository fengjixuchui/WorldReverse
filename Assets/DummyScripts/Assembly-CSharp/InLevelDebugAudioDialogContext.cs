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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugAudioDialogContext : BaseDialogContext // TypeDefIndex: 28590
{
	// Fields
	private MonoInLevelDebugAudioDialog _dialogMono; // 0x178
	private int _currentIndex; // 0x180
	private const string CONFIG_CONTEXT_NAME = "InLevelDebugAudioDialog"; // Metadata: 0x00B0D960
	private const string CONFIG_PREFAB_PATH = "ART/UI/Debug/InLevelDebugAudioDialog"; // Metadata: 0x00B0D97B
	private readonly Dictionary<System.Type, Color> _stateColors; // 0x188
	private Image _imageGameState; // 0x190
	private Dropdown _dropdownLanguage; // 0x198
	private StateAutomaton _stateAutomaton; // 0x1A0
	private AudioManager _audioManager; // 0x1A8

	// Nested types
	private enum DebugAudioTabs // TypeDefIndex: 28591
	{
		CONTROL = 0,
		EVENT = 1,
		INFO = 2
	}

	// Constructors
	public InLevelDebugAudioDialogContext() {} // 0x0000000183A62D90-0x0000000183A62F80

	// Methods
	// [XID] // 0x00000001899306D0-0x00000001899306F0
	public override void SetupView() {} // 0x0000000183A62630-0x0000000183A62CD0
	// [XID] // 0x0000000189937C60-0x0000000189937C80
	private void OnCategoryTabChanged(int index) {} // 0x0000000183A603A0-0x0000000183A60540
	// [XID] // 0x000000018993F6D0-0x000000018993F6F0
	private void OnClickButtonReloadCulling() {} // 0x0000000183A62560-0x0000000183A62630
	// [XID] // 0x0000000189946D20-0x0000000189946D40
	private void OnClickButtonReloadAudioData() {} // 0x0000000183A60710-0x0000000183A60830
	// [XID] // 0x000000018994E360-0x000000018994E380
	private void OnClickButtonPostEventUsePos() {} // 0x0000000183A61C90-0x0000000183A62190
	// [XID] // 0x00000001899559E0-0x0000000189955A00
	private void OnClickButtonSetPosUsePlayer() {} // 0x0000000183A60CC0-0x0000000183A60EC0
	// [XID] // 0x000000018995D4A0-0x000000018995D4C0
	private void OnClickButtonPostEventUseSync() {} // 0x0000000183A61690-0x0000000183A61A10
	// [XID] // 0x0000000189964BC0-0x0000000189964BE0
	private void OnClickButtonSetSetPlayer() {} // 0x0000000183A61A10-0x0000000183A61BD0
	// [XID] // 0x000000018996C1B0-0x000000018996C1D0
	private void OnClickButtonCullingAdd() {} // 0x0000000183A60B10-0x0000000183A60C60
	// [XID] // 0x0000000189973CA0-0x0000000189973CC0
	private void OnClickButtonCullingAddNot() {} // 0x0000000183A601A0-0x0000000183A602F0
	// [XID] // 0x000000018997B370-0x000000018997B390
	private void OnClickButtonCullingClear() {} // 0x0000000183A61BD0-0x0000000183A61C90
	// [XID] // 0x0000000189982DE0-0x0000000189982E00
	private void OnClickButtonCullingReload() {} // 0x0000000183A614C0-0x0000000183A61580
	// [XID] // 0x000000018998A590-0x000000018998A5B0
	public override void UpdateView() {} // 0x0000000183A62CD0-0x0000000183A62D90
	// [XID] // 0x0000000189991EC0-0x0000000189991EE0
	private void OnClickButtonClose() {} // 0x0000000183A602F0-0x0000000183A603A0
	// [XID] // 0x0000000189999BD0-0x0000000189999BF0
	private void OnClickButtonPost2DEvent() {} // 0x0000000183A60540-0x0000000183A60710
	// [XID] // 0x00000001899A12E0-0x00000001899A1300
	private void OnDropdownSelectLanguage(int index) {} // 0x0000000183A60EC0-0x0000000183A610B0
	// [XID] // 0x00000001899A8D30-0x00000001899A8D50
	private void TickGameState() {} // 0x0000000183A61310-0x0000000183A614C0
	// [XID] // 0x00000001899B06B0-0x00000001899B06D0
	private void TickInfo() {} // 0x0000000183A62190-0x0000000183A62560
	// [XID] // 0x00000001899B79E0-0x00000001899B7A00
	private StateAutomaton GetMusicStateAutomaton() => default; // 0x0000000183A60890-0x0000000183A60A00
	// [XID] // 0x00000001899BF380-0x00000001899BF3A0
	private void SetupDropdownLanguageSelection() {} // 0x0000000183A610B0-0x0000000183A61310
	private T FindControl<T>(string path)
		where T : Component => default;
	// [XID] // 0x00000001899C6D70-0x00000001899C6D90
	private void AddClickCallback(Button button, UnityAction action) {} // 0x0000000183A60A00-0x0000000183A60B10
	// [XID] // 0x00000001899CE2A0-0x00000001899CE2C0
	private void AddDropdownSelectCallback(Dropdown dropdown, UnityAction<int> action) {} // 0x0000000183A61580-0x0000000183A61690
}

