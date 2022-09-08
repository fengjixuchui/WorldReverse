/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCEmojiBubble : VCBase // TypeDefIndex: 11853
{
	// Fields
	public const string BUBBLE_ATTACH_POINT_NAME = "EmojiBubbleAttachPoint"; // Metadata: 0x00AEAD0E
	public const float MAX_VISIABLE_DISTANCE = 60f; // Metadata: 0x00AEAD28
	private Transform _attachPoint; // 0x108
	private int _currentBubble; // 0x110
	private float _checkTimer; // 0x114
	private CameraEntity _camera; // 0x118

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B9B5B0-0x0000000189B9B5D0 */ get => default; } // 0x00000001828EA5E0-0x00000001828EA680 

	// Constructors
	public VCEmojiBubble() {} // 0x00000001828EA550-0x00000001828EA5E0

	// Methods
	// [XID] // 0x00000001898C4FE0-0x00000001898C5000
	public override void Init() {} // 0x00000001828E9E30-0x00000001828E9ED0
	// [XID] // 0x0000000189BAA140-0x0000000189BAA160
	public override void OnEntityReady() {} // 0x00000001828EA0A0-0x00000001828EA2C0
	// [XID] // 0x0000000189BB1960-0x0000000189BB1980
	public override void Destroy() {} // 0x00000001828E9680-0x00000001828E9720
	// [XID] // 0x00000001898DB670-0x00000001898DB690
	protected override void Tick(float inDeltaTime) {} // 0x00000001828EA2C0-0x00000001828EA550
	// [XID] // 0x0000000189BC0320-0x0000000189BC0340
	private void CheckCamera() {} // 0x00000001828E9720-0x00000001828E9820
	// [XID] // 0x0000000189BC7D20-0x0000000189BC7D40
	public void PlayEmojiBubble(string name) {} // 0x00000001828E9900-0x00000001828E9DB0
	// [XID] // 0x0000000189BCF8B0-0x0000000189BCF8D0
	public void StopCurEmojiBubble() {} // 0x00000001828E9820-0x00000001828E9900
	// [XID] // 0x0000000189918060-0x0000000189918080
	public void OnEffectSetDestory() {} // 0x00000001828E9F30-0x00000001828E9FD0
}

