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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelQuestTargetIndicator : InLevelTargetIndicator // TypeDefIndex: 29679
{
	// Fields
	private Coroutine _coroutine; // 0xB8
	private List<uint> _markIdList2FadeOut; // 0xC0
	private bool _needRefreshNavigationEnableAnime; // 0xC8

	// Constructors
	public InLevelQuestTargetIndicator() {} // 0x00000001828FC1C0-0x00000001828FC280

	// Methods
	// [XID] // 0x00000001899CCAD0-0x00000001899CCAF0
	public void FadeOutTargetPoint(uint id, bool isNavigation, bool fadeOut = true /* Metadata: 0x00B0FC76 */) {} // 0x00000001828FA120-0x00000001828FA720
	// [XID] // 0x00000001899D4110-0x00000001899D4130
	public void RefreshNavigationEnableAnime() {} // 0x00000001828F9C80-0x00000001828F9D20
	// [XID] // 0x00000001899DB6E0-0x00000001899DB700
	public override void UpdateView() {} // 0x00000001828FB990-0x00000001828FC1C0
	// [XID] // 0x00000001899E2E00-0x00000001899E2E20
	private void AddQuestTargetPoint(IndicatorKey key, uint value, TargetIndicatorType type, bool isNavigation, bool refreshAnime) {} // 0x00000001828FA780-0x00000001828FAFF0
	// [XID] // 0x00000001899EA510-0x00000001899EA530
	public void AddTargetMark(uint markId, TrackingGroup groupId, bool isNavigation) {} // 0x00000001828FB810-0x00000001828FB990
	// [XID] // 0x00000001899F1F20-0x00000001899F1F40
	public void CheckNavigationMark() {} // 0x00000001828F9D20-0x00000001828FA120
	// [XID] // 0x00000001899F96A0-0x00000001899F96C0
	private void RemoveTargetMark(uint markId, bool isNavigation) {} // 0x00000001828FB6F0-0x00000001828FB810
	// [XID] // 0x0000000189A009C0-0x0000000189A009E0
	public string GetAllMarkInfo() => default; // 0x00000001828FAFF0-0x00000001828FB6F0
}

