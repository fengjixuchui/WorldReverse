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

public sealed class VCSceneSimpleMove : VCBaseMove // TypeDefIndex: 11954
{
	// Fields
	private Vector3 _blinkPos; // 0x1D8
	private Vector3 _startCorner; // 0x1E4
	private Vector3 _endCorner; // 0x1F0
	private GameObject _lineRenderObj; // 0x200
	private LineRenderer _lineRender; // 0x208
	private float _x; // 0x210
	private float _y; // 0x214
	private float _z; // 0x218
	private bool _scaningEnd; // 0x21C
	private List<Vector3> _listSceneFramePos; // 0x220

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897BE060-0x00000001897BE080 */ get => default; } // 0x0000000183DFE3D0-0x0000000183DFE470 

	// Constructors
	public VCSceneSimpleMove() {} // 0x0000000183DFE310-0x0000000183DFE3D0

	// Methods
	// [XID] // 0x00000001897C56D0-0x00000001897C56F0
	public void Blink(Vector3 pos) {} // 0x0000000183DFE040-0x0000000183DFE170
	// [XID] // 0x00000001897CCCE0-0x00000001897CCD00
	public override void Init() {} // 0x0000000183DFD6C0-0x0000000183DFDFD0
	// [XID] // 0x00000001897D43E0-0x00000001897D4400
	protected override void Tick(float inDeltaTime) {} // 0x0000000183DFE170-0x0000000183DFE310
}

