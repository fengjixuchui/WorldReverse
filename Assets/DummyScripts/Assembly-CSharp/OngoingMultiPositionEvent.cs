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

public class OngoingMultiPositionEvent // TypeDefIndex: 11024
{
	// Fields
	private const int UPDATE_INTERVAL = 4; // Metadata: 0x00AE8B08
	private Vector3 _lastPos1; // 0x10
	private Vector3 _lastPos2; // 0x1C
	private int _ticker; // 0x28

	// Properties
	public Transform t1 { /* [XID] */ /* 0x00000001898D5690-0x00000001898D56D0 */ get; /* [XID] */ /* 0x00000001898E04C0-0x00000001898E0500 */ set; } // 0x0000000183980B70-0x0000000183980BD0 0x00000001839814C0-0x0000000183981520
	public Transform t2 { /* [XID] */ /* 0x00000001898EAE10-0x00000001898EAE50 */ get; /* [XID] */ /* 0x00000001898F5730-0x00000001898F5770 */ set; } // 0x0000000183980BD0-0x0000000183980C30 0x0000000183981520-0x0000000183981580
	public SyncId syncId { /* [XID] */ /* 0x00000001899000B0-0x00000001899000F0 */ get; /* [XID] */ /* 0x000000018990A5B0-0x000000018990A5F0 */ set; } // 0x0000000183980ED0-0x0000000183980F40 0x00000001839810C0-0x0000000183981130
	public ExDrivenAudioEvents3D.MultiPositionEvent event { /* [XID] */ /* 0x0000000189914F50-0x0000000189914F90 */ get; /* [XID] */ /* 0x000000018991F6F0-0x000000018991F730 */ set; } // 0x0000000183980B10-0x0000000183980B70 0x0000000183980AB0-0x0000000183980B10
	public uint postId { /* [XID] */ /* 0x000000018992A060-0x000000018992A0A0 */ get; /* [XID] */ /* 0x0000000189934480-0x00000001899344C0 */ set; } // 0x0000000183981060-0x00000001839810C0 0x0000000183980F40-0x0000000183980FA0

	// Constructors
	public OngoingMultiPositionEvent() {} // 0x00000001839819D0-0x0000000183981A30

	// Methods
	// [XID] // 0x000000018983B970-0x000000018983B990
	public void TickPosition() {} // 0x0000000183980FA0-0x0000000183981060
	// [XID] // 0x000000018992A2C0-0x000000018992A2E0
	public void UpdatePosition() {} // 0x0000000183981580-0x00000001839819D0
	// [XID] // 0x0000000189863A50-0x0000000189863A70
	public void Clear() {} // 0x0000000183980C30-0x0000000183980ED0
	// [XID] // 0x0000000189922A70-0x0000000189922A90
	private Vector3[] SpreadPositionsInBetween() => default; // 0x0000000183981130-0x00000001839814C0
}

