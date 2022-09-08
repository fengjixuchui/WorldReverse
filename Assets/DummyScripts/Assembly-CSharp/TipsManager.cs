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

public sealed class TipsManager : GlobalManager // TypeDefIndex: 29184
{
	// Fields
	private Dictionary<int, ItemTipsDialogContext> _tipsDic; // 0x10

	// Constructors
	public TipsManager() {} // 0x000000018376A840-0x000000018376A8D0

	// Methods
	// [XID] // 0x00000001896A8A00-0x00000001896A8A20
	public override void Init() {} // 0x000000018376A250-0x000000018376A2F0
	// [XID] // 0x00000001896AFB80-0x00000001896AFBA0
	public override void Destroy() {} // 0x000000018376A1A0-0x000000018376A250
	// [XID] // 0x00000001896B74D0-0x00000001896B74F0
	public override void ClearOnLevelDestroy() {} // 0x000000018376A0F0-0x000000018376A1A0
	// [XID] // 0x00000001896BE620-0x00000001896BE640
	public override void ReloadRes() {} // 0x000000018376A790-0x000000018376A840
	// [XID] // 0x00000001896C5ED0-0x00000001896C5EF0
	public void ShowTip(BagItemSlot bagItemSlot, Vector2 pos, TipType tipType = TipType.Normal /* Metadata: 0x00B0EDA2 */) {} // 0x000000018376A4F0-0x000000018376A790
	// [XID] // 0x00000001896CD5A0-0x00000001896CD5C0
	public void CloseTip() {} // 0x000000018376A2F0-0x000000018376A4F0
	// [XID] // 0x00000001896D4A10-0x00000001896D4A30
	private ItemTipsDialogContext GetTipDialog() => default; // 0x000000018376A030-0x000000018376A0F0
}

