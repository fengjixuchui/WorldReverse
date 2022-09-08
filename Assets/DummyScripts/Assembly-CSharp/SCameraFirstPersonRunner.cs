/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraFirstPersonRunner : SCameraStateBaseRunner<SCameraFirstPersonState> // TypeDefIndex: 32077
{
	// Fields
	private SCameraModuleInitialize _initialModule; // 0x658
	private double _fov; // 0x660
	private double startLerpX; // 0x668
	private double startLerpY; // 0x670
	private Vector3d targetVector; // 0x678

	// Properties
	private double fovZoomRatio { /* [XID] */ /* 0x000000018963C5C0-0x000000018963C5E0 */ get => default; } // 0x00000001823E99F0-0x00000001823E9AA0 
	private double minFov { /* [XID] */ /* 0x0000000189643D50-0x0000000189643D70 */ get => default; } // 0x00000001823E92F0-0x00000001823E93A0 
	private double maxFov { /* [XID] */ /* 0x000000018964B490-0x000000018964B4B0 */ get => default; } // 0x00000001823E9240-0x00000001823E92F0 

	// Constructors
	public SCameraFirstPersonRunner() {} // 0x00000001823EA380-0x00000001823EA440

	// Methods
	// [XID] // 0x0000000189652CC0-0x0000000189652CE0
	protected override void InitModules() {} // 0x00000001823E94E0-0x00000001823E95F0
	// [XID] // 0x000000018965A2F0-0x000000018965A310
	public void UpdateByBlendSrc(ICameraState state) {} // 0x00000001823E8A70-0x00000001823E8FD0
	// [XID] // 0x000000018984ED40-0x000000018984ED60
	public void EnterFirstPerson() {} // 0x00000001823E97D0-0x00000001823E98F0
	// [XID] // 0x0000000189669580-0x00000001896695A0
	public void ExitFirstPerson() {} // 0x00000001823E98F0-0x00000001823E99F0
	// [XID] // 0x00000001896710E0-0x0000000189671100
	public override void OnSpawn() {} // 0x00000001823E88D0-0x00000001823E89C0
	// [XID] // 0x0000000189678920-0x0000000189678940
	protected override void CollectPreInternal() {} // 0x00000001823E89C0-0x00000001823E8A70
	// [XID] // 0x000000018967FF80-0x000000018967FFA0
	public override void OnUnSpawn() {} // 0x00000001823EA1C0-0x00000001823EA2A0
	// [XID] // 0x0000000189687BD0-0x0000000189687BF0
	protected override void TickInternal(float deltaTime) {} // 0x00000001823EA2A0-0x00000001823EA380
	// [XID] // 0x000000018968F5B0-0x000000018968F5D0
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x00000001823E95F0-0x00000001823E97D0
	// [XID] // 0x0000000189696F40-0x0000000189696F60
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x00000001823E8790-0x00000001823E88D0
	// [XID] // 0x000000018969E4B0-0x000000018969E4D0
	protected override void HandleInitBackward(ref SCameraCmd cmd) {} // 0x00000001823E8FD0-0x00000001823E91C0
	// [XID] // 0x00000001896A55A0-0x00000001896A55C0
	protected override void HandleLerpBackward(ref SCameraCmd cmd) {} // 0x00000001823E9B00-0x00000001823E9FE0
}

