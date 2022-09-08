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

public class AudioMultiPositionEvent // TypeDefIndex: 11488
{
	// Fields
	private readonly List<Transform> _list; // 0x10
	private readonly HashSet<int> _hashSet; // 0x18
	private readonly SyncId _syncId; // 0x20

	// Properties
	public bool isPlaying { /* [XID] */ /* 0x0000000189B0CAA0-0x0000000189B0CAE0 */ get; /* [XID] */ /* 0x0000000189B16D00-0x0000000189B16D40 */ set; } // 0x0000000182D9A780-0x0000000182D9A7E0 0x0000000182D9B060-0x0000000182D9B0C0
	public bool changed { /* [XID] */ /* 0x0000000189B213B0-0x0000000189B213F0 */ get; /* [XID] */ /* 0x0000000189B2BA80-0x0000000189B2BAC0 */ set; } // 0x0000000182D9AD80-0x0000000182D9ADE0 0x0000000182D9AA80-0x0000000182D9AAE0
	public AkMultiPositionType multiPositionType { /* [XID] */ /* 0x0000000189B35FB0-0x0000000189B35FF0 */ get; /* [XID] */ /* 0x0000000189B40A30-0x0000000189B40A70 */ set; } // 0x0000000182D9B0C0-0x0000000182D9B120 0x0000000182D9A7E0-0x0000000182D9A840
	public bool empty { /* [XID] */ /* 0x00000001896E1D70-0x00000001896E1D90 */ get => default; } // 0x0000000182D9A6C0-0x0000000182D9A780 
	public SyncId syncId { /* [XID] */ /* 0x00000001896999D0-0x00000001896999F0 */ get => default; } // 0x0000000182D9A840-0x0000000182D9A930 

	// Constructors
	public AudioMultiPositionEvent() {} // 0x0000000182D9B120-0x0000000182D9B240

	// Methods
	// [XID] // 0x00000001897BCA40-0x00000001897BCA60
	public void Add(Transform t) {} // 0x0000000182D9AC30-0x0000000182D9AD80
	// [XID] // 0x0000000189B61800-0x0000000189B61820
	public void Remove(Transform t) {} // 0x0000000182D9A930-0x0000000182D9AA80
	// [XID] // 0x000000018979E230-0x000000018979E250
	public void FinishedPlaying(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x0000000182D9AAE0-0x0000000182D9AC30
	// [XID] // 0x0000000189B70870-0x0000000189B70890
	public AudioPositionArray BuildMultiDirectionArray() => default; // 0x0000000182D9ADE0-0x0000000182D9B060
}

