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

public class MoveCachedTransform // TypeDefIndex: 14648
{
	// Fields
	private Transform _transform; // 0x10
	private const float POSITION_DIRTY_METER = 0.01f; // Metadata: 0x00AEBA08
	private const float ROTATION_DIRTY_DEGREE = 0.01f; // Metadata: 0x00AEBA0C
	private Vector3 _position; // 0x18
	private Quaternion _rotation; // 0x24
	private Vector3 _forward; // 0x34
	private Vector3 _up; // 0x40
	private Vector3 _right; // 0x4C
	private Vector3 _localPosition; // 0x58
	private Quaternion _localRotation; // 0x64

	// Properties
	public Vector3 position { /* [XID] */ /* 0x00000001898EAC90-0x00000001898EACB0 */ get => default; /* [XID] */ /* 0x00000001898F2480-0x00000001898F24A0 */ set {} } // 0x0000000183E1DAB0-0x0000000183E1DB90 0x0000000183E1D920-0x0000000183E1DAB0
	public Quaternion rotation { /* [XID] */ /* 0x00000001898F9C40-0x00000001898F9C60 */ get => default; /* [XID] */ /* 0x0000000189901600-0x0000000189901620 */ set {} } // 0x0000000183E1DCB0-0x0000000183E1DD80 0x0000000183E1D4B0-0x0000000183E1D610
	public Vector3 forward { /* [XID] */ /* 0x0000000189908D70-0x0000000189908D90 */ get => default; } // 0x0000000183E1D3D0-0x0000000183E1D4B0 
	public Vector3 up { /* [XID] */ /* 0x00000001899102D0-0x00000001899102F0 */ get => default; } // 0x0000000183E1D210-0x0000000183E1D2F0 
	public Vector3 right { /* [XID] */ /* 0x0000000189917E80-0x0000000189917EA0 */ get => default; } // 0x0000000183E1D2F0-0x0000000183E1D3D0 
	public Transform parent { /* [XID] */ /* 0x000000018991F4D0-0x000000018991F4F0 */ get => default; } // 0x0000000183E1D7A0-0x0000000183E1D850 
	public Vector3 localPosition { /* [XID] */ /* 0x0000000189927020-0x0000000189927040 */ get => default; /* [XID] */ /* 0x000000018992E770-0x000000018992E790 */ set {} } // 0x0000000183E1DD80-0x0000000183E1DE60 0x0000000183E1D610-0x0000000183E1D7A0
	public Quaternion localRotation { /* [XID] */ /* 0x0000000189935A40-0x0000000189935A60 */ get => default; /* [XID] */ /* 0x000000018993D6E0-0x000000018993D700 */ set {} } // 0x0000000183E1D850-0x0000000183E1D920 0x0000000183E1CDA0-0x0000000183E1CF00

	// Constructors
	public MoveCachedTransform() {} // 0x0000000183E1DE60-0x0000000183E1DFC0

	// Methods
	// [IDTag] // 0x00000001898CDA50-0x00000001898CDA90
	// [XID] // 0x00000001898CDA50-0x00000001898CDA90
	public static implicit operator MoveCachedTransform(Transform transform) => default; // 0x0000000183E1CCD0-0x0000000183E1CDA0
	// [IDTag] // 0x00000001898D83C0-0x00000001898D8400
	// [XID] // 0x00000001898D83C0-0x00000001898D8400
	public static implicit operator Transform(MoveCachedTransform debugTransform) => default; // 0x0000000183E1CC20-0x0000000183E1CCD0
	// [XID] // 0x00000001898E2FC0-0x00000001898E2FE0
	public void SyncWithTransform() {} // 0x0000000183E1CF00-0x0000000183E1D210
	// [XID] // 0x0000000189944B90-0x0000000189944BB0
	public void Rotate(Vector3 axis, float angle, Space relativeTo = Space.World /* Metadata: 0x00AEBA04 */) {} // 0x0000000183E1DB90-0x0000000183E1DCB0
}

