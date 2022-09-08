/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class PermissionUtil // TypeDefIndex: 21266
{
	// Fields
	private static Action _photoPermissionCallBack; // 0x00

	// Properties
	private static Action photoPermissionCallBack { get; /* [XID] */ /* 0x00000001896668D0-0x00000001896668F0 */ set; } // 0x0000000183193770-0x0000000183193840

	// Constructors
	static PermissionUtil() {} // 0x0000000183195540-0x00000001831955A0

	// Methods
	// [XID] // 0x000000018965F0E0-0x000000018965F100
	public static void DoOpenFeedback() {} // 0x00000001831944E0-0x00000001831946C0
	// [XID] // 0x000000018966DFD0-0x000000018966DFF0
	public static void RequestPhotoPermission(Action permissionCallBack) {} // 0x0000000183193640-0x0000000183193770
	// [XID] // 0x0000000189675E40-0x0000000189675E60
	private static void InitPhotoRequestPermissionDialog() {} // 0x0000000183193AD0-0x0000000183193ED0
	// [XID] // 0x000000018967D6E0-0x000000018967D700
	private static void OnPhotoPermissionResponseAndriod(string response) {} // 0x0000000183193F20-0x0000000183194310
	// [XID] // 0x0000000189684D00-0x0000000189684D20
	private static void OnPhotoPermissionResponseIOS(string response) {} // 0x0000000183194900-0x0000000183194BB0
	// [XID] // 0x000000018968C800-0x000000018968C820
	public static void InitFeedbackRequestPermissionDialog() {} // 0x0000000183194F20-0x0000000183195220
	// [XID] // 0x00000001896942F0-0x0000000189694310
	private static void OnFeedbackPermissionResponse(string response) {} // 0x0000000183194BB0-0x0000000183194F20
}

