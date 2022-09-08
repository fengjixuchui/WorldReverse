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

public class BoundsOccluder // TypeDefIndex: 21296
{
	// Fields
	private Matrix4x4 _projectionMatrix; // 0x10
	private Matrix4x4 _worldToCameraMatrix; // 0x50
	private Plane[] _cullFrustumPlanes; // 0x90
	private bool _disableOcculuder; // 0x98

	// Properties
	public Matrix4x4 _mvpMatrix { /* [XID] */ /* 0x0000000189981740-0x0000000189981760 */ get => default; } // 0x0000000184CA8A60-0x0000000184CA8CF0 

	// Constructors
	public BoundsOccluder() {} // 0x0000000184CA8FB0-0x0000000184CA9040

	// Methods
	// [XID] // 0x0000000189988FF0-0x0000000189989010
	public void PrePareCullFrustumPlanes() {} // 0x0000000184CA8E60-0x0000000184CA8FB0
	// [XID] // 0x0000000189990810-0x0000000189990830
	public bool IsCulledByCamera(ref Bounds inBound) => default; // 0x0000000184CA8910-0x0000000184CA8A60
	// [XID] // 0x0000000189998330-0x0000000189998350
	public void RefreshMainCameraMatrixUnityThread(Camera InCamera) {} // 0x0000000184CA8CF0-0x0000000184CA8E60
}

