/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x000000018966AB00-0x000000018966AB30
public class CriManaMovieMaterial : CriMonoBehaviour // TypeDefIndex: 7159
{
	// Fields
	public bool playOnStart; // 0x28
	public bool restartOnEnable; // 0x29
	public RenderMode renderMode; // 0x38
	public OnApplicationPauseCallback onApplicationPauseCallback; // 0x40
	private Player.TimerType _timerType; // 0x48
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private UnityEngine.Material _material; // 0x50
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private string _moviePath; // 0x58
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _loop; // 0x60
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private MaxFrameDrop _maxFrameDrop; // 0x64
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _additiveMode; // 0x68
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _advancedAudio; // 0x69
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _ambisonics; // 0x6A
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _applyTargetAlpha; // 0x6B
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _uiRenderMode; // 0x6C
	private bool materialOwn; // 0x6D
	private bool isMonoBehaviourStartCalled; // 0x6E
	private GameObject ambisonicSource; // 0x70
	private bool wasDisabled; // 0x78
	private bool wasPausedOnDisable; // 0x79
	private WaitForEndOfFrame frameEnd; // 0x80
	private bool unpauseOnApplicationUnpause; // 0x88
	private CriManaMoviePlayerHolder playerHolder; // 0x90

	// Properties
	public string moviePath { get => default; set {} } // 0x000000018643FB40-0x000000018643FBA0 0x00000001864406E0-0x0000000186440780
	public bool loop { get => default; set {} } // 0x000000018643FA20-0x000000018643FA80 0x0000000186440430-0x00000001864404D0
	public MaxFrameDrop maxFrameDrop { get => default; set {} } // 0x000000018643FAE0-0x000000018643FB40 0x00000001864405E0-0x00000001864406E0
	public bool advancedAudio { get => default; set {} } // 0x000000018643F8A0-0x000000018643F900 0x000000018643FDD0-0x000000018643FE80
	public bool ambisonics { get => default; set {} } // 0x000000018643F900-0x000000018643F960 0x000000018643FE80-0x0000000186440330
	public bool additiveMode { get => default; set {} } // 0x000000018643F840-0x000000018643F8A0 0x000000018643FD30-0x000000018643FDD0
	public bool applyTargetAlpha { get => default; set {} } // 0x000000018643F960-0x000000018643F9C0 0x0000000186440330-0x00000001864403D0
	public bool uiRenderMode { get => default; set {} } // 0x000000018643FC60-0x000000018643FCC0 0x0000000186440920-0x00000001864409C0
	public bool isMaterialAvailable { get; private set; } // 0x000000018643F9C0-0x000000018643FA20 0x00000001864403D0-0x0000000186440430
	public Player player { get; private set; } // 0x000000018643FBA0-0x000000018643FC00 0x0000000186440780-0x00000001864407E0
	public UnityEngine.Material material { get => default; set {} } // 0x000000018643FA80-0x000000018643FAE0 0x00000001864404D0-0x00000001864405E0
	public Player.TimerType timerType { get => default; set {} } // 0x000000018643FC00-0x000000018643FC60 0x00000001864407E0-0x0000000186440920
	protected bool HaveRendererOwner { get; private set; } // 0x000000018643F7E0-0x000000018643F840 0x000000018643FCC0-0x000000018643FD30

	// Nested types
	public enum MaxFrameDrop // TypeDefIndex: 7160
	{
		Infinite = -1,
		Disabled = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10
	}

	public enum RenderMode // TypeDefIndex: 7161
	{
		Always = 0,
		OnVisibility = 1,
		Never = 2
	}

	public delegate void OnApplicationPauseCallback(CriManaMovieMaterial manaMovieMaterial, bool appPause); // TypeDefIndex: 7162; 0x00000001864471B0-0x0000000186447460

	// Constructors
	public CriManaMovieMaterial() {} // 0x000000018643F720-0x000000018643F7E0

	// Methods
	public void Play() {} // 0x000000018643E260-0x000000018643E330
	public void Stop() {} // 0x000000018643F5D0-0x000000018643F720
	public void Pause(bool sw) {} // 0x000000018643E190-0x000000018643E260
	protected virtual void OnMaterialAvailableChanged() {} // 0x000000018643E030-0x000000018643E080
	protected virtual void OnMaterialUpdated() {} // 0x000000018643E080-0x000000018643E0D0
	public void PlayerManualInitialize() {} // 0x000000018643E480-0x000000018643E910
	public void PlayerManualFinalize() {} // 0x000000018643E330-0x000000018643E480
	public void PlayerManualSetup() {} // 0x000000018643E910-0x000000018643EE40
	public virtual bool RenderTargetManualSetup() => default; // 0x000000018643F400-0x000000018643F450
	public virtual void RenderTargetManualFinalize() {} // 0x000000018643F3B0-0x000000018643F400
	public void PlayerManualUpdate() {} // 0x000000018643EE40-0x000000018643F1B0
	protected virtual void Awake() {} // 0x000000018643D9C0-0x000000018643DA20
	protected override void OnEnable() {} // 0x000000018643DED0-0x000000018643E030
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator RestartPlayerRoutine() => default; // 0x000000018643F450-0x000000018643F520
	protected override void OnDisable() {} // 0x000000018643DD10-0x000000018643DED0
	protected virtual void OnDestroy() {} // 0x000000018643DC90-0x000000018643DD10
	protected virtual void Start() {} // 0x000000018643F520-0x000000018643F5D0
	public override void CriInternalUpdate() {} // 0x000000018643DBB0-0x000000018643DC10
	public virtual void RenderMovie() {} // 0x000000018643F2F0-0x000000018643F3B0
	public override void CriInternalLateUpdate() {} // 0x000000018643DAF0-0x000000018643DBB0
	protected virtual void OnWillRenderObject() {} // 0x000000018643E0D0-0x000000018643E190
	private void OnApplicationPause(bool appPause) {} // 0x000000018643DC10-0x000000018643DC90
	private void ProcessApplicationPause(bool appPause) {} // 0x000000018643F1B0-0x000000018643F2F0
	private void CreateMaterial() {} // 0x000000018643DA20-0x000000018643DAF0
}

