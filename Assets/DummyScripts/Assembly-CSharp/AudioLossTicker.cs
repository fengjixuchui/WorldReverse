/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioLossTicker : AudioStuffTicker<AudioSignificanceLoss> // TypeDefIndex: 11498
{
	// Fields
	private const float LISTENER_POSITION_THRESHOLD = 0.09f; // Metadata: 0x00AE9907
	private const float LISTENER_ROTATION_THRESHOLD = 1f; // Metadata: 0x00AE990B
	private readonly Dictionary<int, int> _goUsageCount; // 0x18
	private readonly CommandThreadContext _context; // 0x20
	private Vector3 _previousListenerPosition; // 0x28
	private Vector3 _currentListenerPosition; // 0x34
	private Quaternion _previousListenerRotation; // 0x40
	private Quaternion _currentListenerRotation; // 0x50
	private bool _listenerHasTranslated; // 0x60
	private bool _listenerHasRotated; // 0x61
	private bool _isInCombatState; // 0x62

	// Constructors
	public AudioLossTicker() {} // Dummy constructor
	public AudioLossTicker(CommandThreadContext context) {} // 0x000000018124C0D0-0x000000018124C180

	// Methods
	// [IDTag] // 0x000000018981AF10-0x000000018981AF50
	// [XID] // 0x000000018981AF10-0x000000018981AF50
	public override void Tick(float deltaTime) {} // 0x000000018124AED0-0x000000018124B010
	// [XID] // 0x0000000189813680-0x00000001898136A0
	public void Add(SyncId syncId, Transform transform) {} // 0x000000018124BA20-0x000000018124BC70
	// [XID] // 0x000000018982CC50-0x000000018982CC70
	public void Remove(SyncId syncId) {} // 0x000000018124B700-0x000000018124B860
	// [XID] // 0x00000001898343C0-0x00000001898343E0
	public void Clear(SyncId syncId) {} // 0x000000018124B2E0-0x000000018124B3D0
	// [XID] // 0x000000018983B750-0x000000018983B770
	protected override void Added(AudioSignificanceLoss t) {} // 0x000000018124ADC0-0x000000018124AED0
	// [IDTag] // 0x0000000189843150-0x0000000189843190
	// [XID] // 0x0000000189843150-0x0000000189843190
	protected override void Tick(float deltaTime, AudioSignificanceLoss t) {} // 0x000000018124B010-0x000000018124B260
	// [XID] // 0x000000018984D460-0x000000018984D480
	protected override bool IsFinished(AudioSignificanceLoss t) => default; // 0x000000018124B930-0x000000018124BA20
	// [XID] // 0x00000001898AEC30-0x00000001898AEC50
	protected override void Terminate(AudioSignificanceLoss t, bool natural) {} // 0x000000018124BFF0-0x000000018124C0D0
	// [XID] // 0x000000018985BEA0-0x000000018985BEC0
	protected override void Removed(AudioSignificanceLoss t) {} // 0x000000018124B650-0x000000018124B700
	// [XID] // 0x00000001898635A0-0x00000001898635C0
	protected override void Destroyed() {} // 0x000000018124BC70-0x000000018124BD10
	// [XID] // 0x000000018986AA50-0x000000018986AA70
	private void TickIfInCombatState() {} // 0x000000018124B860-0x000000018124B930
	// [XID] // 0x000000018981E0E0-0x000000018981E100
	private void TickListenerMovement() {} // 0x000000018124BD10-0x000000018124BFF0
	// [XID] // 0x00000001898796B0-0x00000001898796D0
	private void SetRtpcValues(AudioSignificanceLoss t, bool shallUpdateOcc, bool shallUpdateFocus) {} // 0x000000018124B3D0-0x000000018124B650
}

