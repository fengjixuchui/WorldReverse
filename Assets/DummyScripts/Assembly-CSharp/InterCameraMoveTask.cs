/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InterCameraMoveTask : BaseInterTask // TypeDefIndex: 20862
{
	// Properties
	public override InteractionType dataType { /* [XID] */ /* 0x000000018970A4C0-0x000000018970A4E0 */ get => default; } // 0x00000001841FC380-0x00000001841FC420 

	// Constructors
	public InterCameraMoveTask() {} // 0x00000001841FE8C0-0x00000001841FE920

	// Methods
	// [XID] // 0x0000000189711F90-0x0000000189711FB0
	protected override bool IsTypeValid(InteractionType type) => default; // 0x00000001841FC7E0-0x00000001841FC8A0
	// [XID] // 0x0000000189719550-0x0000000189719570
	private bool GenLogicCameraFromCfg(BaseEntity inteeEntity, BaseEntity interEntity, ConfigCameraMoveInterAction cfg, BaseInterAction interAction, out LogicCamera logicCamera) {
		logicCamera = default;
		return default;
	} // 0x00000001841FB1E0-0x00000001841FC310
	// [XID] // 0x0000000189720AF0-0x0000000189720B10
	private bool GenCameraStoryDataFromCfg(BaseEntity inteeEntity, BaseEntity interEntity, ConfigCameraMoveInterAction cfg, BaseInterAction interAction, out SCameraStoryData storyData) {
		storyData = default;
		return default;
	} // 0x00000001841FC920-0x00000001841FE8C0
	// [XID] // 0x0000000189728130-0x0000000189728150
	protected override void DoActionInternal(BaseInterAction interAction) {} // 0x00000001841FC420-0x00000001841FC7E0
	// [XID] // 0x000000018972F7D0-0x000000018972F7F0
	private void CameraMove(BaseEntity inteeEntity, BaseEntity interEntity, VCStackCamera vcStackCamera, ConfigCameraMoveInterAction cameraMoveCfg, BaseInterAction interAction) {} // 0x00000001841FAA10-0x00000001841FAE50
	// [XID] // 0x0000000189737200-0x0000000189737220
	private void CameraFocus(BaseEntity inteeEntity, BaseEntity interEntity, VCStackCamera vcStackCamera, ConfigCameraMoveInterAction cameraMoveCfg, BaseInterAction interAction, float defaultDuration = 1f /* Metadata: 0x00AFE6DF */) {} // 0x00000001841FAE50-0x00000001841FB160
	// [XID] // 0x000000018973ED60-0x000000018973ED80
	public Vector3 GenFocusTarget(Vector3 interPos, Vector3 inteePos, float height) => default; // 0x00000001841FA800-0x00000001841FAA10
}

