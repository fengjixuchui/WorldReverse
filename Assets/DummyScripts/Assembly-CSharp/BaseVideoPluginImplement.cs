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

public abstract class BaseVideoPluginImplement // TypeDefIndex: 31999
{
	// Fields
	protected const string VIDEO_ASSETS = "VideoAssets"; // Metadata: 0x00B13AC6
	protected static readonly string VIDEO_STREAMING_ASSETS_DIRECTORY; // 0x00
	protected static readonly string VIDEO_PERSISTENT_ASSETS_DIRECTORY; // 0x08
	protected static readonly string[] VIDEO_ASSETS_DIRECTORYS; // 0x10

	// Properties
	protected string PlatformName { /* [XID] */ /* 0x0000000189A03A40-0x0000000189A03A60 */ get; } // 0x00000001837724B0-0x0000000183772560 

	// Constructors
	protected BaseVideoPluginImplement() {} // 0x0000000183772750-0x00000001837727B0
	static BaseVideoPluginImplement() {} // 0x0000000183772560-0x0000000183772750

	// Methods
	public abstract void SetupRenderTarget(GameObject gameObject);
	public abstract void SetEventCallback(VideoPluginInterface.VideoEventCallback eventCallback);
	public abstract void AsyncPlay(string videoRuntimePath, VideoAudioType videoAudioType = VideoAudioType.Auto /* Metadata: 0x00B13ABE */, Action<string> onStartPlay = null, Action<string> onFinishPlay = null, Action<string> onError = null);
	public abstract void AsyncPlay(string videoRuntimePath, string subtitleRuntimePath, VideoAudioType videoAudioType = VideoAudioType.AudioSetting /* Metadata: 0x00B13AC2 */, Action<string> onStartPlay = null, Action<string> onFinishPlay = null, Action<string> onError = null);
	public abstract void AsyncStop();
	public abstract void AsyncSkip();
}

