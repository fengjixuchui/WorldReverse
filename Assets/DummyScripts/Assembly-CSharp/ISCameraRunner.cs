/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface ISCameraRunner // TypeDefIndex: 32071
{
	// Properties
	CameraShareData shareData { get; }
	CameraAvatarInfoData avatarInfoData { get; }
	double zoomVelocity { get; }

	// Methods
	void SwitchBackground(bool value);
	void SetCameraShareData(ref CameraShareData shareData);
	void SetCameraAvatarInfoData(ref CameraAvatarInfoData avatarInfoData);
	void SetCameraAvatarPrepareData(CameraAvatarPrepareData avatarPrepareData);
	void RefreshCameraAvatarInfo();
	void UpdateCameraShareDataByPostData(ref SCameraPostData postData);
	void OnSpawn();
	void OnUnSpawn();
	void OnBlendToStart();
	void OnBlendFromStart();
	void OnBlendToFinished();
	void OnBlendFromFinished();
	void AddCmd(SCameraCmd cmd);
	void HandleCmd();
	void HandleSingleCmd(ref SCameraCmd cmd);
	void ClearOnDisconnect();
	bool ShiftWorld(Vector3d newShift, Vector3d oldShift);
}

