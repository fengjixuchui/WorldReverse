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

public static class VideoPluginInterface // TypeDefIndex: 32008
{
	// Fields
	private static BaseVideoPluginImplement _videoPluginImplement; // 0x00

	// Properties
	private static BaseVideoPluginImplement videoPluginImplement { /* [XID] */ /* 0x00000001897085C0-0x00000001897085E0 */ get; /* [XID] */ /* 0x000000018970FF70-0x000000018970FF90 */ set; } // 0x0000000183C0B380-0x0000000183C0B460 0x0000000183C0B7D0-0x0000000183C0B880

	// Nested types
	public delegate void VideoEventCallback(int type, string[] paramArr); // TypeDefIndex: 32009; 0x0000000183C254A0-0x0000000183C25660

	// Methods
	// [XID] // 0x00000001897172C0-0x00000001897172E0
	public static void SetupRenderTarget(GameObject gameObject) {} // 0x0000000183C0B6D0-0x0000000183C0B7D0
	// [XID] // 0x000000018971ED70-0x000000018971ED90
	public static void SetEventCallback(VideoEventCallback eventCallback) {} // 0x0000000183C0B2C0-0x0000000183C0B380
	// [IDTag] // 0x00000001897262C0-0x0000000189726300
	// [XID] // 0x00000001897262C0-0x0000000189726300
	public static void AsyncPlay(string videoRuntimePath, VideoAudioType videoAudioType = VideoAudioType.Auto /* Metadata: 0x00B13B3F */, Action<string> onStartPlay = null, Action<string> onFinishPlay = null, Action<string> onError = null) {} // 0x0000000183C0B5A0-0x0000000183C0B6D0
	// [IDTag] // 0x0000000189730920-0x0000000189730960
	// [XID] // 0x0000000189730920-0x0000000189730960
	public static void AsyncPlay(string videoRuntimePath, string subtitleRuntimePath, VideoAudioType videoAudioType = VideoAudioType.AudioSetting /* Metadata: 0x00B13B43 */, Action<string> onStartPlay = null, Action<string> onFinishPlay = null, Action<string> onError = null) {} // 0x0000000183C0B460-0x0000000183C0B5A0
	// [XID] // 0x000000018973AFA0-0x000000018973AFC0
	public static void AsyncStop() {} // 0x0000000183C0B880-0x0000000183C0B940
	// [XID] // 0x0000000189742930-0x0000000189742950
	public static void AsyncSkip() {} // 0x0000000183C0B200-0x0000000183C0B2C0
}

