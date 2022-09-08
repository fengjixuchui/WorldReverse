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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraHomeWorldStateRunner : SCameraStateBaseRunner<SCameraHomeWorldState> // TypeDefIndex: 32085
{
	// Fields
	private SCameraModuleHomeWorld _homeworldModule; // 0x658
	private Vector3d _refAnchorPosition; // 0x660
	private Vector3d _cameraPosition; // 0x678
	private Vector2d _zoomLimit; // 0x690

	// Constructors
	public SCameraHomeWorldStateRunner() {} // 0x0000000182C8F630-0x0000000182C8F6A0

	// Methods
	// [XID] // 0x00000001897FD430-0x00000001897FD450
	protected override void InitModules() {} // 0x0000000182C8ED10-0x0000000182C8EE10
	// [XID] // 0x0000000189804A20-0x0000000189804A40
	public void UpdateByBlendSrc(ICameraState state) {} // 0x0000000182C8E0B0-0x0000000182C8E160
	// [XID] // 0x000000018980C030-0x000000018980C050
	public void EnterHomeworld() {} // 0x0000000182C8F030-0x0000000182C8F150
	// [XID] // 0x0000000189813700-0x0000000189813720
	public void ExitHomeworld() {} // 0x0000000182C8E160-0x0000000182C8E260
	// [XID] // 0x000000018981B310-0x000000018981B330
	public override void OnSpawn() {} // 0x0000000182C8DCF0-0x0000000182C8DDC0
	// [XID] // 0x00000001898228C0-0x00000001898228E0
	protected override void CollectPreInternal() {} // 0x0000000182C8DF40-0x0000000182C8DFF0
	// [XID] // 0x000000018982A230-0x000000018982A250
	public override void OnUnSpawn() {} // 0x0000000182C8F490-0x0000000182C8F570
	// [XID] // 0x00000001898315B0-0x00000001898315D0
	protected override void TickInternal(float deltaTime) {} // 0x0000000182C8F570-0x0000000182C8F630
	// [XID] // 0x0000000189838C80-0x0000000189838CA0
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000182C8EE10-0x0000000182C8F030
	// [XID] // 0x0000000189840340-0x0000000189840360
	protected override void HandleSetFov(ref SCameraCmd cmd) {} // 0x0000000182C8F1B0-0x0000000182C8F260
	// [XID] // 0x0000000189847910-0x0000000189847930
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x0000000182C8D490-0x0000000182C8D580
	// [XID] // 0x000000018984F060-0x000000018984F080
	protected override void HandleMoveCmd(ref SCameraCmd cmd) {} // 0x0000000182C8D580-0x0000000182C8DCF0
	// [XID] // 0x0000000189856140-0x0000000189856160
	protected override void HandleSetRefAnchorPosition(ref SCameraCmd cmd) {} // 0x0000000182C8E680-0x0000000182C8E750
	// [XID] // 0x000000018985D410-0x000000018985D430
	protected override void HandleSetCameraPosition(ref SCameraCmd cmd) {} // 0x0000000182C8E2E0-0x0000000182C8E500
	// [XID] // 0x0000000189864DF0-0x0000000189864E10
	protected override void HandleSetClampRotatePitch(ref SCameraCmd cmd) {} // 0x0000000182C8F2C0-0x0000000182C8F390
	// [XID] // 0x000000018986C450-0x000000018986C470
	protected override void HandleSetClampZoomScale(ref SCameraCmd cmd) {} // 0x0000000182C8DFF0-0x0000000182C8E0B0
	// [XID] // 0x00000001898737B0-0x00000001898737D0
	protected override void HandleMoveRotateVertically(ref SCameraCmd cmd) {} // 0x0000000182C8E830-0x0000000182C8E990
	// [XID] // 0x000000018987B2F0-0x000000018987B310
	private Vector2 TransformXZCoord(float angle, Vector3 vec) => default; // 0x0000000182C8DDC0-0x0000000182C8DF40
	// [XID] // 0x00000001898824D0-0x00000001898824F0
	private Vector3 BackTransformXZCoord(float angle, Vector2 vec) => default; // 0x0000000182C8E9F0-0x0000000182C8EB90
}

