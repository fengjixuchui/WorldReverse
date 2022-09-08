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

public sealed class ShaderTransitionPlugin : BaseComponentPlugin // TypeDefIndex: 12151
{
	// Fields
	public const int EXECUTION_ORDER = 8000; // Metadata: 0x00AEB57D
	private List<UnityEngine.Material> _mats; // 0x58
	private List<SpecialTransitionProperty> _stashPropertyList; // 0x60
	private MonoBuffShader_SpecialTransition _shaderData; // 0x68
	private bool _dir; // 0x70
	private float _from; // 0x74
	private float _to; // 0x78
	private float _duration; // 0x7C
	private bool _active; // 0x80
	private float _time; // 0x84

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899493B0-0x00000001899493D0 */ get => default; } // 0x00000001830F1B60-0x00000001830F1C00 

	// Nested types
	public class SpecialTransitionProperty // TypeDefIndex: 12152
	{
		// Fields
		public Texture SPTex; // 0x10
		public Texture SPNoiseTex; // 0x18
		public float SPNoiseScalar; // 0x20
		public float SPIntensity; // 0x24
		public Color SPTransitionColor; // 0x28
		public Color SPOutlineColor; // 0x38
		public float SPTransitionEmissionScalar; // 0x48
		public float SPTransitionBloomFactor; // 0x4C
		public bool bStash; // 0x50

		// Constructors
		public SpecialTransitionProperty() {} // 0x0000000183102710-0x00000001831027C0
	}

	// Constructors
	public ShaderTransitionPlugin() {} // 0x00000001830F1AD0-0x00000001830F1B60

	// Methods
	// [XID] // 0x0000000189950C90-0x0000000189950CB0
	public override void Tick(float inDeltaTime) {} // 0x00000001830F1860-0x00000001830F1AD0
	// [XID] // 0x0000000189958450-0x0000000189958470
	public void StartTransition(List<SpecialStateMaterialData> list, MonoBuffShader_SpecialTransition shaderData, bool dir) {} // 0x00000001830F0A80-0x00000001830F0FD0
	// [XID] // 0x000000018995FB10-0x000000018995FB30
	private void EndTransition() {} // 0x00000001830F1650-0x00000001830F1860
	// [XID] // 0x0000000189967430-0x0000000189967450
	private void StashProperty(UnityEngine.Material mat, int index) {} // 0x00000001830F12F0-0x00000001830F15E0
	// [XID] // 0x000000018996E6A0-0x000000018996E6C0
	private void ApplyStash(UnityEngine.Material mat, int index) {} // 0x00000001830F1050-0x00000001830F12F0
}

