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

public class LerpInstance // TypeDefIndex: 14760
{
	// Fields
	private ShaderLerpPlugin _shaderLerpPlugin; // 0x10
	private BaseEntity _entity; // 0x18
	private E_ShaderData _dataType; // 0x20
	private List<SpecialStateMaterialData> _mats; // 0x28
	private MonoBuffShader_Lerp _shaderData; // 0x30
	private bool isEnableTransition; // 0x38
	private bool needRecoverOriginalShader; // 0x39
	private float _duration; // 0x3C
	private bool _active; // 0x40
	private float _time; // 0x44

	// Constructors
	public LerpInstance() {} // Dummy constructor
	public LerpInstance(ShaderLerpPlugin plugin, BaseEntity entity, E_ShaderData dataType, List<SpecialStateMaterialData> list, MonoBuffShader_Lerp shaderData, bool dir, bool recoverOriginalShader) {} // 0x000000018388FF20-0x000000018388FFF0

	// Methods
	// [XID] // 0x0000000189BA9FE0-0x0000000189BAA000
	public void Tick() {} // 0x000000018388F700-0x000000018388F9A0
	// [XID] // 0x0000000189BB1840-0x0000000189BB1860
	public static void LerpMats(E_ShaderData dataType, MonoBuffShader_Lerp shaderData, float normalized, bool enableTransition, List<SpecialStateMaterialData> mats) {} // 0x000000018388F410-0x000000018388F700
	// [XID] // 0x0000000189A13E50-0x0000000189A13E70
	public void StartLerping(UnityEngine.Material sampleMat) {} // 0x000000018388FCE0-0x000000018388FF20
	// [XID] // 0x0000000189BC0200-0x0000000189BC0220
	private void EndTransition() {} // 0x000000018388F9A0-0x000000018388FCE0
	// [XID] // 0x0000000189BC7C00-0x0000000189BC7C20
	public bool IsActive() => default; // 0x000000018388F370-0x000000018388F410
}

