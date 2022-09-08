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

public class DynamicRayTask // TypeDefIndex: 11243
{
	// Fields
	private const int DIVIDE_PER_AXIS = 4; // Metadata: 0x00AE951A
	private const int TOTAL_DIVIDE = 64; // Metadata: 0x00AE951E
	private const int TOTAL_REAL_DIVIDE = 56; // Metadata: 0x00AE9522
	private int _rayPerFrame; // 0x10
	private float _movingLerpRatio; // 0x14
	private float _standLerpRatio; // 0x18
	private float _rayMaxDistance; // 0x1C
	private bool _isDebug; // 0x20
	public uint _rtpcParam; // 0x24
	private bool _running; // 0x28
	private RayInfo[] _rayInfos; // 0x30
	private float _totalVolume; // 0x38
	private float[] _divideThreshold; // 0x40
	private float _calculatedRtpcValue; // 0x48
	private RandomDirectionGenerator _directionGenerator; // 0x50
	private Vector3 _lastPosition; // 0x58
	private float _lerpRatio; // 0x64
	private RaycastHit _rayHit; // 0x68
	private AudioManager _audioMgr; // 0xA8

	// Properties
	public float calculatedValue { /* [XID] */ /* 0x0000000189A4C2C0-0x0000000189A4C2E0 */ get => default; } // 0x0000000185885330-0x00000001858853E0 
	public bool isRunning { /* [XID] */ /* 0x0000000189AF0900-0x0000000189AF0920 */ get => default; } // 0x0000000185886580-0x0000000185886620 

	// Constructors
	public DynamicRayTask() {} // 0x0000000185886830-0x0000000185886920

	// Methods
	// [XID] // 0x0000000189AF7ED0-0x0000000189AF7EF0
	public void Init() {} // 0x0000000185885A50-0x0000000185885D60
	// [XID] // 0x00000001898DA230-0x00000001898DA250
	public void Start() {} // 0x00000001858859B0-0x0000000185885A50
	// [XID] // 0x00000001898E1E30-0x00000001898E1E50
	public void Term() {} // 0x00000001858853E0-0x0000000185885480
	// [XID] // 0x0000000189B0E450-0x0000000189B0E470
	public void Tick(float deltaTime) {} // 0x0000000185885D60-0x00000001858863B0
	// [XID] // 0x0000000189B155F0-0x0000000189B15610
	public void Flush() {} // 0x0000000185886490-0x0000000185886580
	// [XID] // 0x0000000189B1D0B0-0x0000000189B1D0D0
	private void DebugRay(RayInfo[] rayInfos) {} // 0x0000000185885480-0x00000001858859B0
	// [XID] // 0x0000000189B24620-0x0000000189B24640
	private float CalValue(int index, float value) => default; // 0x00000001858863B0-0x0000000185886490
	// [IDTag] // 0x0000000189B2BAE0-0x0000000189B2BB20
	// [XID] // 0x0000000189B2BAE0-0x0000000189B2BB20
	private int GetIndex(float value) => default; // 0x0000000185886620-0x0000000185886720
	// [IDTag] // 0x0000000189B36010-0x0000000189B36050
	// [XID] // 0x0000000189B36010-0x0000000189B36050
	private int GetIndex(Vector3 direction) => default; // 0x0000000185886720-0x0000000185886830
}

