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
	public sealed class MonoEffectPluginShaderFade : BaseMonoEffectPlugin // TypeDefIndex: 19738
	{
		// Fields
		private bool _played; // 0x28
		public Vector2 fadeRange; // 0x2C
		public string shaderParamName; // 0x38
		public float duration; // 0x40
		public Renderer[] renderers; // 0x48
		private int _shaderParamName; // 0x50
		private bool _isFadeIn; // 0x54
		private MaterialPropertyBlock _mpb; // 0x58
		private float _curValue; // 0x60
		private float _offsetValue; // 0x64
	
		// Constructors
		public MonoEffectPluginShaderFade() {} // 0x0000000183C94490-0x0000000183C94530
	
		// Methods
		// [XID] // 0x0000000189AD8FF0-0x0000000189AD9010
		public override void Awaked() {} // 0x0000000183C93C60-0x0000000183C93D20
		// [XID] // 0x0000000189AE0A60-0x0000000189AE0A80
		public override void Init() {} // 0x0000000183C93E00-0x0000000183C93EB0
		// [XID] // 0x0000000189AE7F10-0x0000000189AE7F30
		private bool IsFadeEnd() => default; // 0x0000000183C93EB0-0x0000000183C93F70
		// [XID] // 0x0000000189AEFD00-0x0000000189AEFD20
		public override void Tick(float inDeltaTime) {} // 0x0000000183C942F0-0x0000000183C943E0
		// [XID] // 0x0000000189AF7240-0x0000000189AF7260
		private void UpdateValue(float inDeltaTime) {} // 0x0000000183C94060-0x0000000183C94170
		// [XID] // 0x0000000189AFE870-0x0000000189AFE890
		public void TryEffectStop() {} // 0x0000000183C943E0-0x0000000183C94490
		// [XID] // 0x0000000189B06120-0x0000000189B06140
		private void SetOffsetValue() {} // 0x0000000183C93F70-0x0000000183C94060
		// [XID] // 0x0000000189B0D8B0-0x0000000189B0D8D0
		public void SetValue(float value) {} // 0x0000000183C94170-0x0000000183C942F0
	}
}
