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

public class AudioSignificanceLoss // TypeDefIndex: 11499
{
	// Fields
	private const float POSITION_THRESHOLD = 0.09f; // Metadata: 0x00AE990F
	private bool _hasMoved; // 0x10
	private Vector3 _previousPosition; // 0x14
	private Vector3 _currentPosition; // 0x20

	// Properties
	public SyncId syncId { /* [XID] */ /* 0x00000001898B4410-0x00000001898B4450 */ get; /* [XID] */ /* 0x00000001898BED40-0x00000001898BED80 */ set; } // 0x0000000184170560-0x00000001841705D0 0x0000000184170950-0x00000001841709C0
	public Transform transform { /* [XID] */ /* 0x00000001898C97D0-0x00000001898C9810 */ get; /* [XID] */ /* 0x00000001898D3D70-0x00000001898D3DB0 */ set; } // 0x000000018416F7F0-0x000000018416F850 0x00000001841700C0-0x0000000184170120
	public int instanceId { /* [XID] */ /* 0x00000001898DEDD0-0x00000001898DEE10 */ get; /* [XID] */ /* 0x00000001898E98F0-0x00000001898E9930 */ set; } // 0x000000018416F8C0-0x000000018416F920 0x0000000184170060-0x00000001841700C0
	public float lastObstruction { /* [XID] */ /* 0x00000001898F3E40-0x00000001898F3E80 */ get; /* [XID] */ /* 0x00000001898FE6A0-0x00000001898FE6E0 */ private set; } // 0x0000000184170640-0x00000001841706B0 0x0000000184170E10-0x0000000184170E80
	public float lastFocusAngle { /* [XID] */ /* 0x0000000189908ED0-0x0000000189908F10 */ get; /* [XID] */ /* 0x00000001899138C0-0x0000000189913900 */ private set; } // 0x000000018416F850-0x000000018416F8C0 0x00000001841705D0-0x0000000184170640

	// Constructors
	public AudioSignificanceLoss() {} // 0x0000000184170E80-0x0000000184170EE0

	// Methods
	// [XID] // 0x000000018991E0D0-0x000000018991E0F0
	public void SampleTransformStatus() {} // 0x000000018416FE10-0x0000000184170060
	// [XID] // 0x00000001899259C0-0x00000001899259E0
	public bool UpdateOccIfNecessary(Vector3 listenerPosition, Quaternion listenerRotation, bool listenerHasTranslated, bool listenerHasRotated) => default; // 0x00000001841703C0-0x0000000184170560
	// [XID] // 0x000000018992CE70-0x000000018992CE90
	public bool UpdateFocusIfNecessary(Vector3 listenerPosition, Quaternion listenerRotation, bool listenerHasTranslated, bool listenerHasRotated) => default; // 0x00000001841709C0-0x0000000184170B90
	// [XID] // 0x000000018982CDD0-0x000000018982CDF0
	public void ForceUpdate(Vector3 listenerPosition, Quaternion listenerRotation) {} // 0x00000001841706B0-0x0000000184170950
	// [XID] // 0x0000000189A62940-0x0000000189A62960
	public void Clear() {} // 0x0000000184170120-0x00000001841703C0
	// [XID] // 0x0000000189943450-0x0000000189943470
	private float FindObstructionBetween(Vector3 pa, Vector3 pb) => default; // 0x000000018416F920-0x000000018416FE10
	// [XID] // 0x000000018994AB60-0x000000018994AB80
	private float FindRelativeAngle(Vector3 pa, Quaternion ra, Vector3 pb) => default; // 0x0000000184170B90-0x0000000184170E10
}

