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

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class MonoEffectPluginModulateDaytimeGradient : MonoBehaviour // TypeDefIndex: 19840
	{
		// Fields
		public Gradient gradient; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public RendererEntry[] entries; // 0x20
		public bool noTick; // 0x28
		private float _preTimeOfDay; // 0x2C
		private Color _preTimeColor; // 0x30
		private bool _isColorInited; // 0x40
		private List<ColorSharedMaterialModulater> _modulators; // 0x48
	
		// Nested types
		[Serializable]
		public struct RendererEntry : ISerializationCallbackReceiver // TypeDefIndex: 19841
		{
			// Fields
			public Renderer particleSystemRenderer; // 0x00
			public string colorProperty; // 0x08
			public float ratio; // 0x10
	
			// Methods
			// [XID] // 0x00000001896B14D0-0x00000001896B14F0
			public void OnBeforeSerialize() {} // 0x0000000184E561E0-0x0000000184E56210
			// [XID] // 0x00000001896B8FF0-0x00000001896B9010
			public void OnAfterDeserialize() {} // 0x0000000184E56130-0x0000000184E561E0
		}
	
		private class ColorSharedMaterialModulater // TypeDefIndex: 19842
		{
			// Fields
			public Renderer renderer; // 0x10
			private Color _originalColor; // 0x18
			private int _colorID; // 0x28
			private float _ratio; // 0x2C
	
			// Constructors
			public ColorSharedMaterialModulater() {} // Dummy constructor
			public ColorSharedMaterialModulater(Renderer renderer, string colorProperty, float ratio) {} // 0x0000000184E361C0-0x0000000184E362F0
	
			// Methods
			// [XID] // 0x00000001896C0330-0x00000001896C0350
			public void Modulate(Color c) {} // 0x0000000184E36060-0x0000000184E361C0
		}
	
		// Constructors
		public MonoEffectPluginModulateDaytimeGradient() {} // 0x0000000184E4FE40-0x0000000184E4FF00
	
		// Methods
		// [XID] // 0x000000018968CA20-0x000000018968CA40
		public void Awake() {} // 0x0000000184E4F540-0x0000000184E4F7A0
		// [XID] // 0x0000000189694530-0x0000000189694550
		public void OnEnable() {} // 0x0000000184E4FD80-0x0000000184E4FE40
		// [XID] // 0x000000018969BB30-0x000000018969BB50
		public void LateUpdate() {} // 0x0000000184E4FC30-0x0000000184E4FCE0
		// [XID] // 0x00000001896A31A0-0x00000001896A31C0
		private void UpdateColor() {} // 0x0000000184E4F7A0-0x0000000184E4FC30
		// [XID] // 0x00000001896AA610-0x00000001896AA630
		public void OnDestroy() {} // 0x0000000184E4FCE0-0x0000000184E4FD80
	}
}
