/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CriwareVideoPluginImplement : BaseVideoPluginImplement // TypeDefIndex: 32006
{
	// Fields
	private CriwareMediaPlayer _criwareMediaPlayer; // 0x10
	private GameObject _criwareGameObject; // 0x18
	private readonly Dictionary<string, VideoAudioType> _audioLanguageMap; // 0x20
	private readonly Dictionary<VideoAudioType, int> _languageTrackMap; // 0x28
	private const uint ENCRYPTION_FACTOR_KEY = 3; // Metadata: 0x00B13AF2
	private const string AUTH_DIR_NAME = "VideoAuthentication"; // Metadata: 0x00B13AF6
	private const string DEFAULT_OP_NAME = "MDAQ001_OP"; // Metadata: 0x00B13B0D
	private const ulong MAX_KEY = 72057594037927936; // Metadata: 0x00B13B1B

	// Constructors
	public CriwareVideoPluginImplement() {} // 0x00000001822DAB50-0x00000001822DAD40

	// Methods
	// [XID] // 0x00000001896955C0-0x00000001896955E0
	public override void SetupRenderTarget(GameObject gameObject) {} // 0x00000001822DA650-0x00000001822DA9F0
	// [XID] // 0x000000018969CC30-0x000000018969CC50
	public override void SetEventCallback(VideoPluginInterface.VideoEventCallback eventCallback) {} // 0x00000001822D9DF0-0x00000001822D9EB0
	// [IDTag] // 0x00000001896A3F60-0x00000001896A3FA0
	// [XID] // 0x00000001896A3F60-0x00000001896A3FA0
	public override void AsyncPlay(string videoRuntimePath, VideoAudioType videoAudioType = VideoAudioType.Auto /* Metadata: 0x00B13AE9 */, Action<string> onStartPlay = null, Action<string> onFinishPlay = null, Action<string> onError = null) {} // 0x00000001822DA3B0-0x00000001822DA510
	// [IDTag] // 0x00000001896AE3A0-0x00000001896AE3E0
	// [XID] // 0x00000001896AE3A0-0x00000001896AE3E0
	public override void AsyncPlay(string videoRuntimePath, string subtitleRuntimePath, VideoAudioType videoAudioType = VideoAudioType.AudioSetting /* Metadata: 0x00B13AED */, Action<string> onStartPlay = null, Action<string> onFinishPlay = null, Action<string> onError = null) {} // 0x00000001822DA510-0x00000001822DA650
	// [XID] // 0x00000001896B8920-0x00000001896B8940
	public override void AsyncStop() {} // 0x00000001822DA9F0-0x00000001822DAAA0
	// [XID] // 0x00000001896BFB00-0x00000001896BFB20
	public override void AsyncSkip() {} // 0x00000001822D9BE0-0x00000001822D9DF0
	// [IDTag] // 0x00000001896C7450-0x00000001896C7490
	// [XID] // 0x00000001896C7450-0x00000001896C7490
	private void AsyncPlay(string videoRuntimePath, bool useSubtitle, string subtitleRuntimePath, VideoAudioType videoAudioType, Action<string> onStartPlay, Action<string> onFinishPlay, Action<string> onError) {} // 0x00000001822D9EB0-0x00000001822DA3B0
	// [XID] // 0x00000001896D1730-0x00000001896D1750
	private string TryGetAssetFullPath(string assetPath, bool platformRelated = false /* Metadata: 0x00B13AF1 */) => default; // 0x00000001822D9390-0x00000001822D95B0
	// [XID] // 0x00000001896D8EF0-0x00000001896D8F10
	private string GetSubtitleAssetPath(string subtitleName) => default; // 0x00000001822D98D0-0x00000001822D99E0
	// [XID] // 0x00000001896E07B0-0x00000001896E07D0
	private void onClose() {} // 0x00000001822D95B0-0x00000001822D96A0
	// [XID] // 0x00000001896E79C0-0x00000001896E79E0
	private int GetAudioTrack(VideoAudioType videoAudioType) => default; // 0x00000001822D99E0-0x00000001822D9BE0
	// [XID] // 0x00000001896EF030-0x00000001896EF050
	private ulong GetEncryptionKey(string videoFileName) => default; // 0x00000001822D96A0-0x00000001822D98D0
	// [XID] // 0x00000001896F6B00-0x00000001896F6B20
	private string GetAuthenticationFile(string videoFileName) => default; // 0x00000001822D92B0-0x00000001822D9390
}

