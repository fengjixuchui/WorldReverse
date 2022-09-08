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

public sealed class FleurFairDungeonRandomDialogContext : BaseDialogContext // TypeDefIndex: 30082
{
	// Fields
	private MonoFleurFairDungeonRandomDialog _dialogMono; // 0x178
	private ActivityInfo _activityInfo; // 0x180
	private int _step; // 0x188
	private FleurFairDungeonExcelConfig _fleurFairDungeonExcelConfig; // 0x190
	private Coroutine _autoClose; // 0x198
	private bool _isCarousel; // 0x1A0
	private float _saveTime; // 0x1A4
	private float _totalTime; // 0x1A8
	private MonoScrollRectExtention _randomScrollRect; // 0x1B0
	private float _movingVelocity; // 0x1B8
	private float _targetPosition; // 0x1BC
	private float _totalLength; // 0x1C0
	private int _prevIndex; // 0x1C4
	private static readonly uint _carouselAudio; // 0x00

	// Constructors
	public FleurFairDungeonRandomDialogContext() {} // 0x00000001817A6640-0x00000001817A6740
	static FleurFairDungeonRandomDialogContext() {} // 0x00000001817A65B0-0x00000001817A6640

	// Methods
	// [XID] // 0x000000018998A3F0-0x000000018998A410
	public override void SetupView() {} // 0x00000001817A6110-0x00000001817A62C0
	// [XID] // 0x0000000189991CE0-0x0000000189991D00
	public override void ClearView() {} // 0x00000001817A4C30-0x00000001817A4CE0
	// [XID] // 0x00000001899999D0-0x00000001899999F0
	protected override void BindViewCallbacks() {} // 0x00000001817A4B90-0x00000001817A4C30
	// [XID] // 0x00000001899A10A0-0x00000001899A10C0
	private void RefreshView() {} // 0x00000001817A5110-0x00000001817A5CF0
	// [XID] // 0x00000001899A8BB0-0x00000001899A8BD0
	private float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float deltaTime) => default; // 0x00000001817A4CE0-0x00000001817A4ED0
	// [XID] // 0x00000001899B04B0-0x00000001899B04D0
	public override void UpdateView() {} // 0x00000001817A62C0-0x00000001817A65B0
	// [XID] // 0x00000001899B77E0-0x00000001899B7800
	private void GoStep1() {} // 0x00000001817A4AD0-0x00000001817A4B90
	// [XID] // 0x00000001899BF180-0x00000001899BF1A0
	private void GoStep2() {} // 0x00000001817A6060-0x00000001817A6110
	// [XID] // 0x00000001899C6B00-0x00000001899C6B20
	private void RefreshGameItem(Transform trans, int index) {} // 0x00000001817A4ED0-0x00000001817A50B0
	// [XID] // 0x00000001899CE0A0-0x00000001899CE0C0
	private void OnBGButton() {} // 0x00000001817A5F40-0x00000001817A6000
	// [XID] // 0x00000001899D5840-0x00000001899D5860
	private uint SearchMiniGamePosition(uint index) => default; // 0x00000001817A5D50-0x00000001817A5EE0
}

