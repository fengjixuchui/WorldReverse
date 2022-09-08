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

public sealed class InLevelMapMarkSelectDialogContext : BaseDialogContext // TypeDefIndex: 29568
{
	// Fields
	private MonoInLevelMapMarkSelectDialog _dialogMono; // 0x178
	private List<MonoMapMark> _nearMarkList; // 0x180
	private Action<MonoMapMark> _onLinkClick; // 0x188
	private Action _onClose; // 0x190
	private const string NORMAL_COLOR = "#FFFFFFFF"; // Metadata: 0x00B0F91C
	private const string HIGHLIGHT_COLOR = "#FFCC33FF"; // Metadata: 0x00B0F929

	// Properties
	public Action<MonoMapMark> onLinkClick { /* [XID] */ /* 0x0000000189726650-0x0000000189726670 */ set {} } // 0x0000000181915570-0x0000000181915620
	public Action onClose { /* [XID] */ /* 0x000000018972DB70-0x000000018972DB90 */ set {} } // 0x00000001819159E0-0x0000000181915A90

	// Constructors
	public InLevelMapMarkSelectDialogContext() {} // Dummy constructor
	public InLevelMapMarkSelectDialogContext(List<MonoMapMark> nearMarks) {} // 0x0000000181916A10-0x0000000181916CB0

	// Methods
	// [XID] // 0x0000000189735330-0x0000000189735350
	protected override void BindViewCallbacks() {} // 0x00000001819153B0-0x00000001819154B0
	// [XID] // 0x000000018973CD90-0x000000018973CDB0
	public override void SetupView() {} // 0x00000001819166F0-0x0000000181916A10
	// [XID] // 0x0000000189744310-0x0000000189744330
	private string GetShowName(MonoMapMark mark) => default; // 0x0000000181915CE0-0x00000001819164A0
	// [XID] // 0x000000018974BFB0-0x000000018974BFD0
	private Sprite GetShowIcon(MonoMapMark mark) => default; // 0x00000001819158D0-0x00000001819159E0
	// [XID] // 0x00000001897532F0-0x0000000189753310
	private bool IsHighLight(MonoMapMark mark) => default; // 0x0000000181915620-0x0000000181915840
	// [XID] // 0x000000018975A6B0-0x000000018975A6D0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181916590-0x00000001819166F0
	// [XID] // 0x0000000189762360-0x0000000189762380
	public override void Close() {} // 0x00000001819154B0-0x0000000181915570
	// [XID] // 0x0000000189769960-0x0000000189769980
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181915B50-0x0000000181915CE0
}

