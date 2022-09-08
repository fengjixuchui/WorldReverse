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

public sealed class BlackScreenManager : GlobalManager // TypeDefIndex: 20673
{
	// Fields
	private SimpleCurtainDialogContext _curtainDialog; // 0x10
	private List<BlackScreenTask> _taskList; // 0x18
	private float _fadeInTargetTime; // 0x20
	private float _fadeOutTargetTime; // 0x24
	private float _keepingTargetTime; // 0x28
	private float _tempStartTime; // 0x2C
	private float _tempCurrTime; // 0x30
	private float _startAlphaValue; // 0x34
	private BlackScreenState _currState; // 0x38

	// Nested types
	private enum BlackScreenState // TypeDefIndex: 20674
	{
		Stop = 0,
		FadeIn = 1,
		Keeping = 2,
		FadeOut = 3
	}

	// Constructors
	public BlackScreenManager() {} // 0x0000000182E8EF80-0x0000000182E8F030

	// Methods
	// [XID] // 0x0000000189B0D670-0x0000000189B0D690
	public override void Init() {} // 0x0000000182E8E8D0-0x0000000182E8E970
	// [XID] // 0x0000000189B14B90-0x0000000189B14BB0
	public override void Destroy() {} // 0x0000000182E8DF70-0x0000000182E8E010
	// [XID] // 0x0000000189B1C4B0-0x0000000189B1C4D0
	public override void ClearOnLevelDestroy() {} // 0x0000000182E8DDF0-0x0000000182E8DE90
	// [XID] // 0x0000000189B23A20-0x0000000189B23A40
	public override void ClearOnDisconnect() {} // 0x0000000182E8DD50-0x0000000182E8DDF0
	// [XID] // 0x0000000189B2AD40-0x0000000189B2AD60
	public override void ReloadRes() {} // 0x0000000182E8EE10-0x0000000182E8EEB0
	// [XID] // 0x0000000189B32260-0x0000000189B32280
	public override void Tick() {} // 0x0000000182E8EEB0-0x0000000182E8EF80
	// [XID] // 0x0000000189B39C10-0x0000000189B39C30
	private void UpdateBlackScreen() {} // 0x0000000182E8E5D0-0x0000000182E8E8D0
	// [XID] // 0x0000000189B414D0-0x0000000189B414F0
	private void UpdateTaskList() {} // 0x0000000182E8EC40-0x0000000182E8EE10
	// [XID] // 0x0000000189B48EA0-0x0000000189B48EC0
	private void CheckCurtainReady() {} // 0x0000000182E8E140-0x0000000182E8E270
	// [XID] // 0x0000000189B504C0-0x0000000189B504E0
	private bool IsAllCurtainTaskFinish() => default; // 0x0000000182E8E970-0x0000000182E8EAA0
	// [XID] // 0x0000000189B57D50-0x0000000189B57D70
	public void StartBlackScreen(float fadeInTime, float keepTime, float fadeOutTime, Color bgColor, Action fadeInCallback, Action fadeOutCallback, CurtainTask curtainTask = null, string text = null) {} // 0x0000000182E8E270-0x0000000182E8E5D0
	// [XID] // 0x0000000189B5F720-0x0000000189B5F740
	private void ResetAll() {} // 0x0000000182E8DE90-0x0000000182E8DF70
	// [XID] // 0x0000000189B66E00-0x0000000189B66E20
	public void SetBlackScreenColorForce(Color targetColor) {} // 0x0000000182E8DC70-0x0000000182E8DD50
	// [XID] // 0x0000000189B6E140-0x0000000189B6E160
	public Color? GetCurtainColor() => default; // 0x0000000182E8EAA0-0x0000000182E8EBE0
	// [XID] // 0x0000000189B75950-0x0000000189B75970
	public void CloseBlackScreenForce() {} // 0x0000000182E8E010-0x0000000182E8E0E0
}

