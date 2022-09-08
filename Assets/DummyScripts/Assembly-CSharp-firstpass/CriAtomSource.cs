/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x00000001896BCC80-0x00000001896BCCB0
public class CriAtomSource : CriMonoBehaviour // TypeDefIndex: 6985
{
	// Fields
	protected CriAtomEx3dSource source; // 0x30
	private Vector3 lastPosition; // 0x38
	private bool hasValidPosition; // 0x44
	private CriAtomRegion currentRegion; // 0x48
	private CriAtomListener currentListener; // 0x50
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _playOnStart; // 0x58
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string _cueName; // 0x60
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string _cueSheet; // 0x68
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private CriAtomRegion _regionOnStart; // 0x70
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private CriAtomListener _listenerOnStart; // 0x78
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _use3dPositioning; // 0x80
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _loop; // 0x81
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float _volume; // 0x84
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private float _pitch; // 0x88
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _androidUseLowLatencyVoicePool; // 0x8C
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool need_to_player_update_all; // 0x8D

	// Properties
	public CriAtomExPlayer player { get; protected set; } // 0x00000001877C46C0-0x00000001877C4720 0x00000001877C54A0-0x00000001877C5500
	public bool playOnStart { get => default; set {} } // 0x00000001877C4660-0x00000001877C46C0 0x00000001877C5440-0x00000001877C54A0
	public string cueName { get => default; set {} } // 0x00000001877C41F0-0x00000001877C4250 0x00000001877C4D30-0x00000001877C4D90
	public string cueSheet { get => default; set {} } // 0x00000001877C4250-0x00000001877C42B0 0x00000001877C4D90-0x00000001877C4DF0
	public bool use3dPositioning { get => default; set {} } // 0x00000001877C4B60-0x00000001877C4BC0 0x00000001877C5840-0x00000001877C59E0
	public CriAtomRegion region3d { get => default; set {} } // 0x00000001877C4720-0x00000001877C4780 0x00000001877C5500-0x00000001877C5690
	public CriAtomListener listener { get => default; set {} } // 0x00000001877C4310-0x00000001877C4370 0x00000001877C4E50-0x00000001877C4FD0
	public CriAtomRegion regionOnStart { get => default; set {} } // 0x00000001877C4780-0x00000001877C47E0 0x00000001877C5690-0x00000001877C56F0
	public CriAtomListener listenerOnStart { get => default; set {} } // 0x00000001877C42B0-0x00000001877C4310 0x00000001877C4DF0-0x00000001877C4E50
	public bool loop { get => default; set {} } // 0x00000001877C4370-0x00000001877C43D0 0x00000001877C4FD0-0x00000001877C5040
	public float volume { get => default; set {} } // 0x00000001877C4BC0-0x00000001877C4C30 0x00000001877C59E0-0x00000001877C5B40
	public float pitch { get => default; set {} } // 0x00000001877C45F0-0x00000001877C4660 0x00000001877C52E0-0x00000001877C5440
	public float pan3dAngle { get => default; set {} } // 0x00000001877C43D0-0x00000001877C44E0 0x00000001877C5040-0x00000001877C5190
	public float pan3dDistance { get => default; set {} } // 0x00000001877C44E0-0x00000001877C45F0 0x00000001877C5190-0x00000001877C52E0
	public int startTime { get => default; set {} } // 0x00000001877C47E0-0x00000001877C48E0 0x00000001877C56F0-0x00000001877C5840
	public long time { get => default; } // 0x00000001877C4A20-0x00000001877C4B60 
	public Status status { get => default; } // 0x00000001877C48E0-0x00000001877C4A20 
	public bool attenuationDistanceSetting { get => default; set {} } // 0x00000001877C4170-0x00000001877C41F0 0x00000001877C4CA0-0x00000001877C4D30
	public bool androidUseLowLatencyVoicePool { get => default; set {} } // 0x00000001877C4110-0x00000001877C4170 0x00000001877C4C30-0x00000001877C4CA0

	// Nested types
	public enum Status // TypeDefIndex: 6986
	{
		Stop = 0,
		Prep = 1,
		Playing = 2,
		PlayEnd = 3,
		Error = 4
	}

	// Constructors
	public CriAtomSource() {} // 0x00000001877C4060-0x00000001877C4110

	// Methods
	protected void SetNeedToPlayerUpdateAll() {} // 0x00000001877C3A90-0x00000001877C3AF0
	protected virtual void InternalInitialize() {} // 0x00000001877C1F60-0x00000001877C20B0
	protected virtual void InternalFinalize() {} // 0x00000001877C1E10-0x00000001877C1F60
	private void Awake() {} // 0x00000001877C1B80-0x00000001877C1BF0
	protected override void OnEnable() {} // 0x00000001877C2270-0x00000001877C2330
	private void OnDestroy() {} // 0x00000001877C2200-0x00000001877C2270
	protected bool SetInitialSourcePosition() => default; // 0x00000001877C3980-0x00000001877C3A90
	protected virtual void SetInitialParameters() {} // 0x00000001877C3740-0x00000001877C3980
	protected virtual void UpdatePosition() {} // 0x00000001877C3E60-0x00000001877C4060
	private void Start() {} // 0x00000001877C3AF0-0x00000001877C3D60
	public override void CriInternalUpdate() {} // 0x00000001877C1D50-0x00000001877C1DA0
	public override void CriInternalLateUpdate() {} // 0x00000001877C1BF0-0x00000001877C1D50
	public CriAtomExPlayback Play() => default; // 0x00000001877C26E0-0x00000001877C2790
	public CriAtomExPlayback Play(string cueName) => default; // 0x00000001877C2AC0-0x00000001877C2DF0
	public CriAtomExPlayback Play(int cueId) => default; // 0x00000001877C2790-0x00000001877C2AC0
	private void PlayOnStart() {} // 0x00000001877C2570-0x00000001877C26E0
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator PlayAsync(string cueName) => default; // 0x00000001877C2490-0x00000001877C2570
	public void Stop() {} // 0x00000001877C3D60-0x00000001877C3E60
	public void Pause(bool sw) {} // 0x00000001877C2330-0x00000001877C2490
	public bool IsPaused() => default; // 0x00000001877C20B0-0x00000001877C2200
	public void SetBusSendLevel(string busName, float level) {} // 0x00000001877C3480-0x00000001877C35E0
	[Obsolete] // 0x00000001897381A0-0x00000001897381D0
	public void SetBusSendLevel(int busId, float level) {} // 0x00000001877C35E0-0x00000001877C3740
	public void SetBusSendLevelOffset(string busName, float levelOffset) {} // 0x00000001877C31C0-0x00000001877C3320
	[Obsolete] // 0x0000000189741260-0x0000000189741290
	public void SetBusSendLevelOffset(int busId, float levelOffset) {} // 0x00000001877C3320-0x00000001877C3480
	public void SetAisacControl(string controlName, float value) {} // 0x00000001877C2DF0-0x00000001877C2F50
	[Obsolete] // 0x000000018974A350-0x000000018974A380
	public void SetAisac(string controlName, float value) {} // 0x00000001877C30B0-0x00000001877C3140
	public void SetAisacControl(uint controlId, float value) {} // 0x00000001877C2F50-0x00000001877C30B0
	[Obsolete] // 0x000000018974A350-0x000000018974A380
	public void SetAisac(uint controlId, float value) {} // 0x00000001877C3140-0x00000001877C31C0
	public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer) {} // 0x00000001877C1A70-0x00000001877C1B80
	public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer) {} // 0x00000001877C1DA0-0x00000001877C1E10
}

