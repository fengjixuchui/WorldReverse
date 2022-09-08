/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SCameraStatePostModule : CameraStatePostModule // TypeDefIndex: 32125
{
	// Fields
	protected VCStackCamera _vcCamera; // 0x10

	// Properties
	public VCStackCamera vcCamera { /* [XID] */ /* 0x0000000189781790-0x00000001897817B0 */ get => default; } // 0x0000000183503A20-0x0000000183503AC0 

	// Constructors
	public SCameraStatePostModule() {} // 0x0000000183504000-0x0000000183504070

	// Methods
	// [XID] // 0x0000000189980A20-0x0000000189980A40
	public void SetVCCamera(VCStackCamera vcCamera) {} // 0x0000000183503D30-0x0000000183503DE0
	// [XID] // 0x0000000189790190-0x00000001897901B0
	protected void CopyLast(ref SCameraPostData data) {} // 0x0000000183503AC0-0x0000000183503C00
	// [XID] // 0x0000000189797BB0-0x0000000189797BD0
	public void Collect(double deltaTime, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183503770-0x0000000183503860
	// [XID] // 0x000000018979F870-0x000000018979F890
	protected virtual void CollectInternal(double deltaTime, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183503860-0x0000000183503930
	// [XID] // 0x00000001897A6D90-0x00000001897A6DB0
	public void Tick(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183503C00-0x0000000183503D30
	// [XID] // 0x00000001897AE770-0x00000001897AE790
	protected virtual void TickInternal(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183503930-0x0000000183503A20
	// [XID] // 0x00000001897B66B0-0x00000001897B66D0
	public void Flush(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183503DE0-0x0000000183503F10
	// [XID] // 0x00000001897BE4F0-0x00000001897BE510
	protected virtual void FlushInternal(double deltaTime, ref SCameraPostData data, ref CameraStateData retData, ref CameraAvatarInfoData avatarInfoData, CameraAvatarPrepareData avatarPrepareData) {} // 0x0000000183503F10-0x0000000183504000
}

