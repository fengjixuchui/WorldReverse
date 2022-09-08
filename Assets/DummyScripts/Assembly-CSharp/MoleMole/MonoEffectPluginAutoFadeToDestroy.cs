/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginAutoFadeToDestroy : BaseMonoEffectPlugin // TypeDefIndex: 19686
	{
		// Fields
		public string propertyName; // 0x28
		public float keepTime; // 0x30
		public float fadeTime; // 0x34
		private float _keepLeftTime; // 0x38
		private float _fadeLeftTime; // 0x3C
		private MeshRenderer[] _meshRenderers; // 0x40
	
		// Properties
		private MeshRenderer[] MeshRenderers { /* [XID] */ /* 0x00000001897C6340-0x00000001897C6360 */ get => default; } // 0x00000001846A0870-0x00000001846A0940 
		private float TimeScale { /* [XID] */ /* 0x00000001897CDB80-0x00000001897CDBA0 */ get => default; } // 0x00000001846A0940-0x00000001846A0AD0 
	
		// Constructors
		public MonoEffectPluginAutoFadeToDestroy() {} // 0x00000001846A0ED0-0x00000001846A0F60
	
		// Methods
		// [XID] // 0x00000001897D5050-0x00000001897D5070
		public override void Init() {} // 0x00000001846A0BC0-0x00000001846A0C70
		// [XID] // 0x00000001897DC850-0x00000001897DC870
		public override void Tick(float inDeltaTime) {} // 0x00000001846A0D80-0x00000001846A0ED0
		// [XID] // 0x00000001897E4250-0x00000001897E4270
		private void UpdateFade(float ratio) {} // 0x00000001846A0740-0x00000001846A0870
		// [XID] // 0x00000001897EBD60-0x00000001897EBD80
		public override bool IsToBeDeallocated() => default; // 0x00000001846A0C70-0x00000001846A0D20
		// [XID] // 0x00000001897F36F0-0x00000001897F3710
		public override void Clear() {} // 0x00000001846A06A0-0x00000001846A0740
	}
}
