/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AudioSurfaceWalker // TypeDefIndex: 14635
{
	// Fields
	private readonly Walker _localWalker; // 0x10
	private Dictionary<uint, Walker> _remoteWalkers; // 0x18

	// Nested types
	private class RtpcSetter : IAudioRtpcSetter // TypeDefIndex: 14636
	{
		// Properties
		public VCAvatarAudio avatarAudio { /* [XID] */ /* 0x0000000189AC44B0-0x0000000189AC44F0 */ get; /* [XID] */ /* 0x0000000189ACEAF0-0x0000000189ACEB30 */ set; } // 0x00000001848C1E90-0x00000001848C1EF0 0x00000001848C1E30-0x00000001848C1E90

		// Constructors
		public RtpcSetter() {} // 0x00000001848C2060-0x00000001848C20C0

		// Methods
		// [XID] // 0x0000000189AD9890-0x0000000189AD98B0
		public void SetRtpc(uint key, float value) {} // 0x00000001848C1EF0-0x00000001848C2060
	}

	private class Walker // TypeDefIndex: 14637
	{
		// Fields
		private const int UPDATE_INTERVAL = 5; // Metadata: 0x00AEB9C7
		private readonly RtpcSetter _rtpcSetter; // 0x10
		private readonly SurfaceBeneathProber _surfaceProber; // 0x18
		private readonly List<VCAvatarAudio> _activeAvatars; // 0x20
		private BaseEntity _targetEntity; // 0x28
		private int _updateCountdown; // 0x30

		// Properties
		public int targetCount { /* [XID] */ /* 0x0000000189AE14D0-0x0000000189AE14F0 */ get => default; } // 0x00000001848C3C60-0x00000001848C3D20 

		// Constructors
		public Walker() {} // 0x00000001848C4650-0x00000001848C4760

		// Methods
		// [XID] // 0x0000000189AE88B0-0x0000000189AE88D0
		public bool NeedUpdate() => default; // 0x00000001848C4570-0x00000001848C4650
		// [XID] // 0x0000000189AF0780-0x0000000189AF07A0
		public void Enable() {} // 0x00000001848C3D20-0x00000001848C3DD0
		// [XID] // 0x0000000189AF7CB0-0x0000000189AF7CD0
		public void Clear() {} // 0x00000001848C3FE0-0x00000001848C4090
		// [XID] // 0x0000000189AFF270-0x0000000189AFF290
		public void SetWeatherOverride(string value) {} // 0x00000001848C4090-0x00000001848C4160
		// [XID] // 0x0000000189B06A70-0x0000000189B06A90
		public void UpdateSurfaceProbes() {} // 0x00000001848C3DD0-0x00000001848C3EC0
		// [XID] // 0x0000000189B0E310-0x0000000189B0E330
		public void AddTargetAvatar(VCAvatarAudio avatarAudio) {} // 0x00000001848C4350-0x00000001848C4570
		// [XID] // 0x00000001898E7FC0-0x00000001898E7FE0
		public void RemoveTargetAvatar(VCAvatarAudio avatarAudio) {} // 0x00000001848C4160-0x00000001848C4350
		// [XID] // 0x0000000189B1CEF0-0x0000000189B1CF10
		private float GetSurfaceProberLiftupFromConfig(VCAvatarAudio avatarAudio) => default; // 0x00000001848C3EC0-0x00000001848C3FE0
	}

	// Constructors
	public AudioSurfaceWalker() {} // 0x00000001848A6700-0x00000001848A6790

	// Methods
	// [XID] // 0x0000000189B940C0-0x0000000189B940E0
	public void UpdateSurfaceInfo() {} // 0x00000001848A5DB0-0x00000001848A5FB0
	// [XID] // 0x0000000189A8CD60-0x0000000189A8CD80
	public void RegisterAvatarAudio(VCAvatarAudio avatarAudio) {} // 0x00000001848A61E0-0x00000001848A62F0
	// [XID] // 0x00000001898C1E30-0x00000001898C1E50
	public void UnregisterAvatarAudio(VCAvatarAudio avatarAudio) {} // 0x00000001848A62F0-0x00000001848A63C0
	// [XID] // 0x0000000189A9BA00-0x0000000189A9BA20
	public void SetWeatherSurfaceOverride(string value) {} // 0x00000001848A5FB0-0x00000001848A61E0
	// [XID] // 0x00000001898AB500-0x00000001898AB520
	private uint GetPeerIdFromAvatar(VCAvatarAudio avatarAudio) => default; // 0x00000001848A63C0-0x00000001848A6510
	// [XID] // 0x00000001898B2D80-0x00000001898B2DA0
	private bool IsLocalAvatar(uint peerId) => default; // 0x00000001848A5CD0-0x00000001848A5DB0
	// [XID] // 0x000000018989CAE0-0x000000018989CB00
	private Walker GetCorrespondingWalkerForAvatar(VCAvatarAudio avatarAudio, bool createNewIfMissing) => default; // 0x00000001848A6510-0x00000001848A6700
}

