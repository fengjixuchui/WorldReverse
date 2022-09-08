/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HeadCtrlMixerBehaviour : EntityPlayableMixerBehaviour // TypeDefIndex: 26187
{
	// Fields
	private VCNpcHeadController _vcHeadCtrl; // 0x20
	private int _runningClipHash; // 0x28

	// Constructors
	public HeadCtrlMixerBehaviour() {} // 0x00000001827B0CD0-0x00000001827B0D40

	// Methods
	// [XID] // 0x0000000189ADD720-0x0000000189ADD740
	public override void GenBindingGameObject(object playerData) {} // 0x00000001827B0350-0x00000001827B04E0
	// [XID] // 0x0000000189AE4EC0-0x0000000189AE4EE0
	protected override void InitComponent() {} // 0x00000001827B07B0-0x00000001827B08E0
	// [XID] // 0x0000000189AEC510-0x0000000189AEC530
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x00000001827B0940-0x00000001827B0CD0
	// [XID] // 0x0000000189AF3FB0-0x0000000189AF3FD0
	private void PerformHeadCtrl(bool enableHead, Vector3 targetOffsetPos, bool enableBody, float bodyAngle) {} // 0x00000001827B04E0-0x00000001827B07B0
}

