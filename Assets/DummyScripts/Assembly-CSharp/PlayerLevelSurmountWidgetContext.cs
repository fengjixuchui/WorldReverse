/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerLevelSurmountWidgetContext : BaseWidgetContext // TypeDefIndex: 29240
{
	// Fields
	private MonoPlayerLevelSurmountWidget _widgetMono; // 0x168
	private uint _worldLevel; // 0x170
	private uint _nextLevel; // 0x174
	private PlayerLevelLockExcelConfig _playerLockConfig; // 0x178
	private PlayerLevelLockExcelConfig _playerLimitLockConfig; // 0x180
	private AdjustType _adjustType; // 0x188

	// Nested types
	public enum AdjustType // TypeDefIndex: 29241
	{
		None = 0,
		AdjustUp = 1,
		AdjustDown = 2
	}

	// Constructors
	public PlayerLevelSurmountWidgetContext() {} // Dummy constructor
	public PlayerLevelSurmountWidgetContext(uint worldLevel, uint nextLevel = 0 /* Metadata: 0x00B0EE88 */, AdjustType adjustType = AdjustType.None /* Metadata: 0x00B0EE8C */) {} // 0x0000000181C7F080-0x0000000181C7F190

	// Methods
	// [XID] // 0x00000001897E54B0-0x00000001897E54D0
	public override void SetupView() {} // 0x0000000181C7E780-0x0000000181C7F080
	// [XID] // 0x00000001897ED050-0x00000001897ED070
	private void RefreshTextRow(Transform trans, int index) {} // 0x0000000181C7E350-0x0000000181C7E5A0
	// [XID] // 0x00000001897F4890-0x00000001897F48B0
	private void RefreshAdjustTextRow(Transform trans, int index) {} // 0x0000000181C7E5A0-0x0000000181C7E720
}

