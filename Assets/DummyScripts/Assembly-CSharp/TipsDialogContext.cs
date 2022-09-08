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
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TipsDialogContext : BaseDialogContext // TypeDefIndex: 29326
{
	// Fields
	public static readonly Color bgRedColor; // 0x00
	public static readonly Color bgPurpleColor; // 0x10
	public static readonly Color bgGreenColor; // 0x20
	private MonoInfoListPanel _infoPanel; // 0x178
	private Queue<float> _removeTimeQueue; // 0x180
	private string _lastInQueueString; // 0x188
	private List<Tuple<string, bool, Color>> _cachedTips; // 0x190
	private List<Tuple<string, bool, Color>> _inLevelMainPageCachedTips; // 0x198
	private float _closeTime; // 0x1A0

	// Constructors
	public TipsDialogContext() {} // 0x0000000181CEA8B0-0x0000000181CEAA00
	static TipsDialogContext() {} // 0x0000000181CEA760-0x0000000181CEA8B0

	// Methods
	// [XID] // 0x00000001898C6D20-0x00000001898C6D40
	public override void SetupView() {} // 0x0000000181CEA2A0-0x0000000181CEA540
	// [XID] // 0x00000001898CE320-0x00000001898CE340
	public bool HasCachedTips() => default; // 0x0000000181CE9E80-0x0000000181CE9F70
	// [XID] // 0x00000001898D5D50-0x00000001898D5D70
	public override void ClearView() {} // 0x0000000181CE9270-0x0000000181CE93A0
	// [IDTag] // 0x00000001898DDA00-0x00000001898DDA40
	// [XID] // 0x00000001898DDA00-0x00000001898DDA40
	public void AddTips(string tips, bool showBackground = false /* Metadata: 0x00B0F5F3 */) {} // 0x0000000181CE98C0-0x0000000181CE99E0
	// [IDTag] // 0x00000001898E8550-0x00000001898E8590
	// [XID] // 0x00000001898E8550-0x00000001898E8590
	public void AddTipsInLevelMainPageCached(string tips, bool showBackground = false /* Metadata: 0x00B0F5F4 */) {} // 0x0000000181CE9650-0x0000000181CE9860
	// [IDTag] // 0x00000001898F2C60-0x00000001898F2CA0
	// [XID] // 0x00000001898F2C60-0x00000001898F2CA0
	public void AddTips(string tips, Color bgColor, bool showBackground = false /* Metadata: 0x00B0F5F5 */) {} // 0x0000000181CE99E0-0x0000000181CE9D60
	// [IDTag] // 0x00000001898FD580-0x00000001898FD5C0
	// [XID] // 0x00000001898FD580-0x00000001898FD5C0
	public void AddTipsInLevelMainPageCached(string tips, Color bgColor, bool showBackground = false /* Metadata: 0x00B0F5F6 */) {} // 0x0000000181CE93A0-0x0000000181CE9650
	// [XID] // 0x0000000189907F30-0x0000000189907F50
	public void LoadOnInLevelMainPage() {} // 0x0000000181CE9F70-0x0000000181CEA1D0
	// [XID] // 0x000000018990F720-0x000000018990F740
	protected override void OnDisable() {} // 0x0000000181CEA1D0-0x0000000181CEA2A0
	// [XID] // 0x00000001899170F0-0x0000000189917110
	public override void UpdateView() {} // 0x0000000181CEA540-0x0000000181CEA760
}

