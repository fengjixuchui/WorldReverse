/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugNpcDialogContext : BaseDialogContext // TypeDefIndex: 28625
{
	// Fields
	private static List<BaseEntity> _npcList; // 0x00
	private static BaseEntity _currEntity; // 0x08
	private static List<int> _freeStyleIdList; // 0x10
	private InputField _inputField; // 0x178
	private List<string> _oldCmdList; // 0x180
	private int _curCmdIndex; // 0x188

	// Constructors
	public InLevelDebugNpcDialogContext() {} // 0x0000000183638550-0x0000000183638630
	static InLevelDebugNpcDialogContext() {} // 0x0000000183638480-0x0000000183638550

	// Methods
	// [XID] // 0x0000000189B650C0-0x0000000189B650E0
	public override void SetupView() {} // 0x0000000183638040-0x00000001836381A0
	// [XID] // 0x0000000189B6C6A0-0x0000000189B6C6C0
	public override void ClearView() {} // 0x00000001836359F0-0x0000000183635A90
	// [XID] // 0x0000000189B73E30-0x0000000189B73E50
	public override void UpdateView() {} // 0x00000001836381A0-0x0000000183638480
	// [XID] // 0x0000000189B7B4E0-0x0000000189B7B500
	protected override void BindViewCallbacks() {} // 0x0000000183634F70-0x00000001836358B0
	// [XID] // 0x0000000189B82DE0-0x0000000189B82E00
	private void SetupNpcDropdown() {} // 0x0000000183636E60-0x00000001836371C0
	// [XID] // 0x0000000189B8A400-0x0000000189B8A420
	private void SetUpCurNpcDropDown() {} // 0x00000001836360E0-0x0000000183636390
	// [XID] // 0x0000000189B919C0-0x0000000189B919E0
	private void OnNpcAdd(BaseEntity tarEntity) {} // 0x0000000183634CD0-0x0000000183634ED0
	// [XID] // 0x0000000189B98DE0-0x0000000189B98E00
	private void OnSpawnNpc() {} // 0x0000000183637C40-0x0000000183637E70
	// [XID] // 0x0000000189BA01C0-0x0000000189BA01E0
	private void SpawnByInputId() {} // 0x00000001836358B0-0x00000001836359F0
	// [XID] // 0x0000000189BA7A00-0x0000000189BA7A20
	private void SpawnNpc(uint configID) {} // 0x0000000183635A90-0x0000000183635F00
	// [XID] // 0x0000000189BAEDD0-0x0000000189BAEDF0
	private void SaveCurFreeStyle() {} // 0x0000000183636390-0x0000000183636650
	// [XID] // 0x0000000189BB6480-0x0000000189BB64A0
	private void CreateFreeStyleItem(int freeStyleId, ref Transform template, Transform parent) {} // 0x0000000183637300-0x0000000183637720
	// [XID] // 0x0000000189BBDB00-0x0000000189BBDB20
	private void SetupCurFreeSyle() {} // 0x0000000183636C30-0x0000000183636E60
	// [XID] // 0x0000000189BC57E0-0x0000000189BC5800
	private void DeleteCurFreeStyle(GameObject obj, int freeStyleId) {} // 0x00000001836371C0-0x0000000183637300
	// [XID] // 0x0000000189BCD240-0x0000000189BCD260
	private void CurNPCDoInputFreeStyle() {} // 0x0000000183637E70-0x0000000183638040
	// [XID] // 0x0000000189BD4740-0x0000000189BD4760
	private void CurNPCIdle() {} // 0x0000000183634ED0-0x0000000183634F70
	// [XID] // 0x0000000189BDC2B0-0x0000000189BDC2D0
	private void CurNPCDoFreeStyle(int freeStyleId) {} // 0x0000000183636840-0x0000000183636B10
	// [XID] // 0x00000001895E8B10-0x00000001895E8B30
	private void ExecuteCommand(string cmd) {} // 0x0000000183635F00-0x00000001836360E0
	// [XID] // 0x00000001895F0360-0x00000001895F0380
	private void DoFreeStyle(string cmd) {} // 0x0000000183637920-0x0000000183637B70
	// [XID] // 0x00000001895F7DD0-0x00000001895F7DF0
	private void ClearNpc() {} // 0x0000000183637B70-0x0000000183637C40
	// [XID] // 0x00000001895FF1B0-0x00000001895FF1D0
	public static void Clear() {} // 0x0000000183636650-0x0000000183636840
}

