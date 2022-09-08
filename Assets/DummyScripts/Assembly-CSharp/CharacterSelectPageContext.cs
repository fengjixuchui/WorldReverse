/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CharacterSelectPageContext : BasePageContext // TypeDefIndex: 28445
{
	// Fields
	private MonoCharacterSelectScene _scene; // 0x190
	private MonoCharacterSelectCtrl _monoCtrl; // 0x198
	private GameObject _sceneObj; // 0x1A0
	private ulong malePrefabPath; // 0x1A8
	private ulong femalePrefabPath; // 0x1B0
	private uint maleId; // 0x1B8
	private uint femaleId; // 0x1BC
	private const string scenePagePath = "ART/UI/Menus/Page/CharacterSelectPageV2"; // Metadata: 0x00B0D7B7
	private const string enviroProfilePath = "Data/Environment/EnviroSystemProfile/BigWorld/ESP_OpeningCG_Default"; // Metadata: 0x00B0D7E2
	private bool createAvatars; // 0x1C0
	private const string scenePrefabPath = "ART/UI/UIScene/CharacterSelectSceneNew"; // Metadata: 0x00B0D829
	private AsyncJob scenePrefabLoadJob; // 0x1C8
	private uint scenePrefabResHandle; // 0x1D8
	private uint scenePageResHandle; // 0x1DC
	private uint currSelectedId; // 0x1E0
	private bool _curPause; // 0x1E4

	// Constructors
	public CharacterSelectPageContext() {} // 0x0000000181D5A8F0-0x0000000181D5AA80

	// Methods
	// [XID] // 0x00000001898754E0-0x0000000189875500
	public void PreloadRes() {} // 0x0000000181D59C90-0x0000000181D59E60
	// [XID] // 0x000000018987CFF0-0x000000018987D010
	public void Reset2Default() {} // 0x0000000181D59270-0x0000000181D59390
	// [XID] // 0x0000000189883FB0-0x0000000189883FD0
	public void RealBegin() {} // 0x0000000181D596E0-0x0000000181D597E0
	// [XID] // 0x000000018988B6F0-0x000000018988B710
	public void RealHide() {} // 0x0000000181D59B90-0x0000000181D59C90
	// [XID] // 0x0000000189892DF0-0x0000000189892E10
	private void PreloadPage() {} // 0x0000000181D59150-0x0000000181D59270
	// [XID] // 0x000000018989A470-0x000000018989A490
	private void ClearLoadedPage() {} // 0x0000000181D59600-0x0000000181D596E0
	// [XID] // 0x00000001898A1690-0x00000001898A16B0
	private void ClearLoadedScene() {} // 0x0000000181D597E0-0x0000000181D598F0
	// [XID] // 0x00000001898A8F40-0x00000001898A8F60
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181D593F0-0x0000000181D595A0
	// [XID] // 0x00000001898B0880-0x00000001898B08A0
	private void RefreshSelection() {} // 0x0000000181D598F0-0x0000000181D59B90
	// [XID] // 0x00000001898B7ED0-0x00000001898B7EF0
	public override void SetupView() {} // 0x0000000181D5A020-0x0000000181D5A8F0
	// [XID] // 0x00000001898BF5A0-0x00000001898BF5C0
	public override void SetActive(bool enable) {} // 0x0000000181D59F00-0x0000000181D5A020
	// [XID] // 0x00000001898C6EC0-0x00000001898C6EE0
	public override void ClearView() {} // 0x0000000181D58960-0x0000000181D58CF0
	// [XID] // 0x00000001898CE3E0-0x00000001898CE400
	public void SelectCharacter(uint id, bool isMale, CinemachineVirtualCamera viewPoint, Transform trans) {} // 0x0000000181D58680-0x0000000181D588E0
}

