/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class EntityPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 26167
{
	// Fields
	protected GameObject _bindingGameObject; // 0x10
	protected BaseEntity _entity; // 0x18
	protected bool _needPlay; // 0x20
	protected bool _isPlaying; // 0x21

	// Constructors
	protected EntityPlayableBehaviour() {} // 0x0000000183691D00-0x0000000183691D70

	// Methods
	public abstract void GenBindingGameObject(object playerData);
	protected void CreateTLEntity() {} // 0x0000000183691700-0x0000000183691820
	protected virtual void InitComponent() {} // 0x0000000183691820-0x0000000183691870
	protected void CheckStartPlay() {} // 0x00000001836915F0-0x0000000183691680
	protected virtual void OnStartPlay() {} // 0x0000000183691B70-0x0000000183691BC0
	protected void CheckStopPlay() {} // 0x0000000183691680-0x0000000183691700
	protected virtual void OnStopPlay() {} // 0x0000000183691BC0-0x0000000183691C10
	public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000183691980-0x0000000183691A40
	public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000183691870-0x0000000183691980
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000183691C10-0x0000000183691D00
	public override void OnPlayableDestroy(Playable playable) {} // 0x0000000183691A40-0x0000000183691B70
}

