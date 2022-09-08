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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneSubEmitterPlugin : BaseComponentPlugin // TypeDefIndex: 12115
{
	// Fields
	private Dictionary<string, MonoEffectProxy> _subEmitterEffects; // 0x58

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898C3530-0x00000001898C3550 */ get => default; } // 0x0000000182BF9400-0x0000000182BF94A0 

	// Nested types
	private class DoDelayDeallocateHandle : TimerManager.TimerEventHandler // TypeDefIndex: 12116
	{
		// Fields
		private string _effectName; // 0x20
		private Func<float, string, bool> _func; // 0x28

		// Properties
		public override bool autoRecycle { /* [XID] */ /* 0x00000001898E97D0-0x00000001898E97F0 */ get => default; } // 0x0000000182C0BEF0-0x0000000182C0BF90 

		// Constructors
		public DoDelayDeallocateHandle() {} // 0x0000000182C0BE90-0x0000000182C0BEF0

		// Methods
		// [XID] // 0x00000001898E1A40-0x00000001898E1A60
		public void Refine(string effectName, Func<float, string, bool> func) {} // 0x0000000182C0BC30-0x0000000182C0BD00
		// [XID] // 0x00000001898F0D40-0x00000001898F0D60
		protected override bool Invoke(float delay) => default; // 0x0000000182C0BD00-0x0000000182C0BDD0
		// [XID] // 0x00000001898F86C0-0x00000001898F86E0
		public override void Recycle() {} // 0x0000000182C0BDD0-0x0000000182C0BE90
	}

	// Constructors
	public LevelSceneSubEmitterPlugin() {} // 0x0000000182BF9370-0x0000000182BF9400

	// Methods
	// [XID] // 0x00000001898CAE70-0x00000001898CAE90
	public override void Init() {} // 0x0000000182BF91E0-0x0000000182BF92A0
	// [XID] // 0x00000001898D2570-0x00000001898D2590
	public override void Destroy() {} // 0x0000000182BF8CB0-0x0000000182BF8E90
	// [XID] // 0x00000001898D9EB0-0x00000001898D9ED0
	public void EmitSubEmitterParticle(string effectName, Vector3 position, Quaternion bornRot, Vector3 scale) {} // 0x0000000182BF8E90-0x0000000182BF91E0
}

