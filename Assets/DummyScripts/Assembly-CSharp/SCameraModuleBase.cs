/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SCameraModuleBase // TypeDefIndex: 32070
{
	// Fields
	public PipelineCameraModuleConfig config; // 0x10
	public PipelineCameraGlobalConfig globalConfig; // 0x18
	protected SCameraBaseState _state; // 0x20

	// Properties
	public virtual CameraModuleType moduleType { /* [XID] */ /* 0x0000000189B5EF90-0x0000000189B5EFB0 */ get => default; } // 0x0000000181FAC810-0x0000000181FAC8B0 

	// Constructors
	public SCameraModuleBase() {} // 0x0000000181FAD310-0x0000000181FAD380

	// Methods
	// [XID] // 0x0000000189B665C0-0x0000000189B665E0
	protected bool IsInCombat() => default; // 0x0000000181FACDC0-0x0000000181FACEC0
	// [XID] // 0x0000000189B63200-0x0000000189B63220
	public static PipelineCameraModuleConfig GetModuleConfig(CameraModuleType moduleType, CameraProfile profile) => default; // 0x0000000181FAC8B0-0x0000000181FACA00
	// [XID] // 0x0000000189B751D0-0x0000000189B751F0
	public virtual void Init(CameraProfile profile, SCameraBaseState state) {} // 0x0000000181FACBF0-0x0000000181FACCF0
	// [XID] // 0x0000000189B7C620-0x0000000189B7C640
	public virtual bool CheckEnable(ref CameraShareData data) => default; // 0x0000000181FAC760-0x0000000181FAC810
	// [XID] // 0x0000000189B84440-0x0000000189B84460
	public virtual void Start(ref CameraShareData data) {} // 0x0000000181FACA00-0x0000000181FACAB0
	// [XID] // 0x0000000189B8B2F0-0x0000000189B8B310
	public virtual void Collect(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000181FAC680-0x0000000181FAC760
	// [XID] // 0x0000000189B92A20-0x0000000189B92A40
	public virtual void Tick(double deltaTime, ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData) {} // 0x0000000181FACCF0-0x0000000181FACDC0
	// [XID] // 0x0000000189B99FA0-0x0000000189B99FC0
	public virtual void Flush(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000181FAD0A0-0x0000000181FAD170
	// [XID] // 0x0000000189BA16A0-0x0000000189BA16C0
	public virtual void PostFlushTop(ref CameraShareData data, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000181FACEC0-0x0000000181FACF90
	// [XID] // 0x0000000189BA8B10-0x0000000189BA8B30
	public virtual void Dispose() {} // 0x0000000181FAD270-0x0000000181FAD310
	// [XID] // 0x0000000189BB01B0-0x0000000189BB01D0
	protected void CopyLast(ref CameraShareData data) {} // 0x0000000181FACAB0-0x0000000181FACBF0
	// [XID] // 0x0000000189BB76A0-0x0000000189BB76C0
	protected virtual void CopyOutput(ref CameraShareData data) {} // 0x0000000181FACF90-0x0000000181FAD0A0
	// [XID] // 0x0000000189BBED40-0x0000000189BBED60
	public virtual bool ShiftWorld(Vector3d newShift, Vector3d oldShift) => default; // 0x0000000181FAD170-0x0000000181FAD270
}

