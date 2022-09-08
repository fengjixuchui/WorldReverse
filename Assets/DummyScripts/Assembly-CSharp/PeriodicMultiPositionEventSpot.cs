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

public struct PeriodicMultiPositionEventSpot // TypeDefIndex: 11492
{
	// Fields
	private uint _eventId; // 0x00
	private int _idInEvent; // 0x04
	private float _lifeRemaining; // 0x08
	private Vector3 _position; // 0x0C

	// Properties
	public uint eventId { /* [XID] */ /* 0x0000000189695080-0x00000001896950A0 */ get => default; } // 0x0000000185465980-0x0000000185465A30 
	public int idInEvent { /* [XID] */ /* 0x0000000189734F50-0x0000000189734F70 */ get => default; /* [XID] */ /* 0x00000001896A3D30-0x00000001896A3D50 */ set {} } // 0x0000000185465A30-0x0000000185465B10 0x0000000185465BD0-0x0000000185465CC0
	public Vector3 position { /* [XID] */ /* 0x000000018975EF10-0x000000018975EF30 */ get => default; } // 0x0000000185465DB0-0x0000000185465EE0 
	public bool isFinished { /* [XID] */ /* 0x000000018979A570-0x000000018979A590 */ get => default; } // 0x0000000185465FD0-0x0000000185465FE0 

	// Methods
	// [XID] // 0x00000001896B9BA0-0x00000001896B9BC0
	public void Set(uint eventId, float duration, Vector3 position) {} // 0x0000000185465EE0-0x0000000185465FD0
	// [XID] // 0x00000001896C0FC0-0x00000001896C0FE0
	public void Tick(float deltaTime) {} // 0x0000000185465B10-0x0000000185465BD0
	// [XID] // 0x00000001896C84E0-0x00000001896C8500
	public void Clear() {} // 0x0000000185465CC0-0x0000000185465DB0
}

