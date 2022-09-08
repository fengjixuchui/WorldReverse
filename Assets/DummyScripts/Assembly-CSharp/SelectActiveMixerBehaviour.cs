/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectActiveMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26238
{
	// Fields
	private GameObject _trackObj; // 0x10
	private List<Renderer> _renders; // 0x18
	private List<CinemachineVirtualCameraBase> _cameras; // 0x20
	private PlayableDirector _playableDirector; // 0x28

	// Constructors
	public SelectActiveMixerBehaviour() {} // 0x0000000184FD19C0-0x0000000184FD1A80

	// Methods
	// [XID] // 0x000000018994B520-0x000000018994B540
	private bool GetTrackBinding(object playerData) => default; // 0x0000000184FD0F50-0x0000000184FD10E0
	// [XID] // 0x0000000189952E40-0x0000000189952E60
	public bool GetDirector(Playable playable) => default; // 0x0000000184FD11B0-0x0000000184FD1370
	// [XID] // 0x000000018995A3F0-0x000000018995A410
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000184FD1370-0x0000000184FD19C0
}

