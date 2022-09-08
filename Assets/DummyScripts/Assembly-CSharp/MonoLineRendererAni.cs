/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
public class MonoLineRendererAni : MonoBehaviour // TypeDefIndex: 31747
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private int LineLength; // 0x18
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Vector3 LineTailOffset; // 0x1C
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Vector3 PointOffsetRandom; // 0x28
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Vector3 WaveOffset; // 0x34
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float WaveSpeed; // 0x40
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float FollowSpeed; // 0x44
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private ParticleSystemSimulationSpace simulationSpace; // 0x48
	[CustomSimulationSpace] // 0x000000018984C020-0x000000018984C050
	[SerializeField] // 0x000000018984C020-0x000000018984C050
	private Transform customSimulationSpace; // 0x50
	private LineRenderer lineR; // 0x58
	private Vector3[] positions; // 0x60
	private Matrix4x4? matCustomSpaceWL; // 0x68
	private Matrix4x4? matCustomSpaceOffset; // 0xAC
	private bool _need_reset; // 0xF0
	private bool bWaveOffset; // 0xF1
	private bool bPointOffsetRandom; // 0xF2
	private Vector3 noiseVec; // 0xF4
	private Matrix4x4 space; // 0x100

	// Constructors
	public MonoLineRendererAni() {} // 0x0000000181D85040-0x0000000181D85180

	// Methods
	private void OnEnable() {} // 0x0000000181D83C80-0x0000000181D83CE0
	private void OnDisable() {} // 0x0000000181D83B10-0x0000000181D83C80
	private void reset() {} // 0x0000000181D85180-0x0000000181D85710
	private void Update() {} // 0x0000000181D84FE0-0x0000000181D85040
	private void UpdatePoints() {} // 0x0000000181D84210-0x0000000181D84FE0
	private void SetCustomSpaceOffset() {} // 0x0000000181D83CE0-0x0000000181D84210
}

