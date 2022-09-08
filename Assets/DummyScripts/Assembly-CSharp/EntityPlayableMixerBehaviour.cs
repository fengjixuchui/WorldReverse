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

public abstract class EntityPlayableMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26168
{
	// Fields
	protected GameObject _bindingGameObject; // 0x10
	protected BaseEntity _entity; // 0x18

	// Constructors
	protected EntityPlayableMixerBehaviour() {} // 0x00000001836920C0-0x0000000183692130

	// Methods
	public abstract void GenBindingGameObject(object playerData);
	protected void CreateTLEntity() {} // 0x0000000183691D70-0x0000000183691E70
	protected virtual void InitComponent() {} // 0x0000000183691E70-0x0000000183691EC0
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000183691FD0-0x00000001836920C0
	public override void OnPlayableDestroy(Playable playable) {} // 0x0000000183691EC0-0x0000000183691FD0
}

