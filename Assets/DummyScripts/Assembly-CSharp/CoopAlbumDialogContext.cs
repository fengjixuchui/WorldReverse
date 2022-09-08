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

public sealed class CoopAlbumDialogContext : BaseDialogContext // TypeDefIndex: 30126
{
	// Fields
	private MonoCoopAlbumDialog _dialogMono; // 0x178
	private List<CoopCg> _cgConfigList; // 0x180
	private uint _chapterId; // 0x188

	// Constructors
	public CoopAlbumDialogContext() {} // Dummy constructor
	public CoopAlbumDialogContext(uint chapterId) {} // 0x00000001851DDC50-0x00000001851DDD10

	// Methods
	// [XID] // 0x0000000189B236F0-0x0000000189B23710
	public void CoopAlbumUpdateChapterId(uint chapterId) {} // 0x00000001851DD7E0-0x00000001851DD890
	// [XID] // 0x0000000189B2A950-0x0000000189B2A970
	public override void SetupView() {} // 0x00000001851DDB30-0x00000001851DDC50
	// [XID] // 0x0000000189B31EC0-0x0000000189B31EE0
	public override void ClearView() {} // 0x00000001851DCA20-0x00000001851DCAE0
	// [XID] // 0x0000000189B39680-0x0000000189B396A0
	protected override void BindViewCallbacks() {} // 0x00000001851DC8B0-0x00000001851DCA20
	// [XID] // 0x0000000189B40FD0-0x0000000189B40FF0
	private void RefreshAlbum() {} // 0x00000001851DD120-0x00000001851DD6A0
	// [XID] // 0x0000000189B48940-0x0000000189B48960
	private void RefreshCGInfo(Transform trans, int index) {} // 0x00000001851DCD20-0x00000001851DD120
	// [XID] // 0x0000000189B500B0-0x0000000189B500D0
	private int SortFunc(CoopCg x, CoopCg y) => default; // 0x00000001851DD6A0-0x00000001851DD7E0
	// [XID] // 0x0000000189B578E0-0x0000000189B57900
	private void InitCGList() {} // 0x00000001851DCAE0-0x00000001851DCBC0
	// [XID] // 0x0000000189B5F230-0x0000000189B5F250
	private void ClearCGList() {} // 0x00000001851DC7E0-0x00000001851DC8B0
	// [XID] // 0x0000000189B66840-0x0000000189B66860
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B10811 */) {} // 0x00000001851DD8F0-0x00000001851DDB30
}

