/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Keyboard : BaseInputDevice // TypeDefIndex: 29974
{
	// Fields
	private const string DEFAULT_KEY_SETTING = "Data/UI/DefaultKeyboardInputSetting"; // Metadata: 0x00B103C2
	private uint _configHandle; // 0x10
	private KeyboardInputSetting _config; // 0x18

	// Constructors
	public Keyboard() {} // 0x0000000183D92C10-0x0000000183D92C80

	// Methods
	// [XID] // 0x0000000189934B30-0x0000000189934B50
	public override void Init() {} // 0x0000000183D92850-0x0000000183D92960
	// [XID] // 0x000000018993C600-0x000000018993C620
	public override void Destroy() {} // 0x0000000183D92770-0x0000000183D92850
	// [XID] // 0x0000000189943C70-0x0000000189943C90
	public override void HandleInput(InputMode inputMode) {} // 0x0000000183D92B00-0x0000000183D92C10
	// [XID] // 0x000000018994B170-0x000000018994B190
	private void HandleNormalInput() {} // 0x0000000183D92610-0x0000000183D926D0
	// [XID] // 0x0000000189952BA0-0x0000000189952BC0
	private bool HandleOpenMenuInput() => default; // 0x0000000183D92960-0x0000000183D92A00
	// [XID] // 0x000000018995A130-0x000000018995A150
	private bool HandleChangeAvatarInput() => default; // 0x0000000183D926D0-0x0000000183D92770
	// [XID] // 0x0000000189961B00-0x0000000189961B20
	private void HandleMoveInput() {} // 0x0000000183D92570-0x0000000183D92610
	// [XID] // 0x00000001899691D0-0x00000001899691F0
	private void HandleMenuInput() {} // 0x0000000183D92A60-0x0000000183D92B00
}

