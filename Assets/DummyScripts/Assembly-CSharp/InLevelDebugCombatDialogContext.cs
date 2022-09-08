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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugCombatDialogContext : BaseDialogContext // TypeDefIndex: 28599
{
	// Fields
	private UnityEngine.UI.Text _textTime; // 0x178
	private UnityEngine.UI.Text _textHurtInfo; // 0x180
	private bool[] isChange; // 0x188
	private int page; // 0x190
	private string onShowAvatar; // 0x198
	private List<GameObject> delete; // 0x1A0
	private EventManager eventManager; // 0x1A8
	private Dictionary<string, List<HurtInfo>> avatarHurt; // 0x1B0
	private List<RectTransform> title; // 0x1B8
	private string startTime; // 0x1C0
	private DateTime startHurtTime; // 0x1C8
	private DateTime curHurtTime; // 0x1D8
	private DateTime lastHurtTime; // 0x1E8
	private float totalDamage; // 0x1F8
	private double hurtSeconds; // 0x200
	private double hurtSecondsDur; // 0x208
	private float width; // 0x210
	private float height; // 0x214

	// Nested types
	private class HurtInfo // TypeDefIndex: 28600
	{
		// Fields
		public string elementType; // 0x10
		public int count; // 0x18
		public float damage; // 0x1C

		// Constructors
		public HurtInfo() {} // Dummy constructor
		public HurtInfo(string elementType, float damage) {} // 0x0000000181D2BE80-0x0000000181D2BF10
	}

	// Constructors
	public InLevelDebugCombatDialogContext() {} // 0x0000000181D38CD0-0x0000000181D38EB0

	// Methods
	// [XID] // 0x0000000189620240-0x0000000189620260
	public override void SetupView() {} // 0x0000000181D37EB0-0x0000000181D38700
	// [XID] // 0x0000000189627710-0x0000000189627730
	public void Minimize() {} // 0x0000000181D33A10-0x0000000181D344A0
	// [XID] // 0x000000018962F1D0-0x000000018962F1F0
	public void Maximize() {} // 0x0000000181D32CE0-0x0000000181D33820
	// [XID] // 0x0000000189636B90-0x0000000189636BB0
	public override void UpdateView() {} // 0x0000000181D38700-0x0000000181D38CD0
	// [XID] // 0x000000018963E0C0-0x000000018963E0E0
	private List<List<string>> AvatarHurt2Lst() => default; // 0x0000000181D35200-0x0000000181D35890
	// [XID] // 0x0000000189645A90-0x0000000189645AB0
	private List<List<string>> GetHurtInfoLst(string avatar) => default; // 0x0000000181D36120-0x0000000181D36660
	// [XID] // 0x000000018964D2A0-0x000000018964D2C0
	private void PageInit() {} // 0x0000000181D36660-0x0000000181D36830
	// [XID] // 0x0000000189654A40-0x0000000189654A60
	private void UpdateAvatarData() {} // 0x0000000181D36930-0x0000000181D37EB0
	// [XID] // 0x000000018965C110-0x000000018965C130
	private void ClickDetail(Button button) {} // 0x0000000181D36830-0x0000000181D36930
	// [XID] // 0x0000000189663790-0x00000001896637B0
	private void Back2Main() {} // 0x0000000181D344A0-0x0000000181D34580
	// [XID] // 0x000000018966B0D0-0x000000018966B0F0
	private void UpdateHurtData() {} // 0x0000000181D34640-0x0000000181D35200
	// [XID] // 0x0000000189672CD0-0x0000000189672CF0
	private void Clear() {} // 0x0000000181D33820-0x0000000181D33A10
	// [XID] // 0x000000018967A3D0-0x000000018967A3F0
	private void ClosePage() {} // 0x0000000181D32BF0-0x0000000181D32CE0
	// [XID] // 0x0000000189681C20-0x0000000189681C40
	private void HandleEvent(BaseEvent evt, int step) {} // 0x0000000181D35890-0x0000000181D36120
}

