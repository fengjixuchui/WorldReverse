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

public sealed class ShaderLerpPlugin : BaseComponentPlugin // TypeDefIndex: 12150
{
	// Fields
	public ShaderUseType shaderUseType; // 0x58
	private List<LerpInstance> _lerpInstances; // 0x60
	private List<ShaderRendererPlus> _shaderPlusRenders; // 0x68
	private List<SpecialStateMaterialData> _matListForSpecailState; // 0x70
	private Dictionary<int, int> _newShaderEntries; // 0x78
	public MonoBuffShader_Lerp currentTopShader; // 0x80
	private bool _shaderChanged; // 0x88
	public float curTopToNormalized; // 0x8C
	private BaseEntity _animatorEntity; // 0x90
	private static readonly E_ShaderData[] _enumValues; // 0x00
	private bool _needTick; // 0x98

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898E7F20-0x00000001898E7F40 */ get => default; } // 0x0000000180F87D40-0x0000000180F87DE0 

	// Constructors
	static ShaderLerpPlugin() {} // 0x0000000180F87B70-0x0000000180F87C70
	public ShaderLerpPlugin() {} // 0x0000000180F87C70-0x0000000180F87D40

	// Methods
	// [XID] // 0x00000001898EF5E0-0x00000001898EF600
	public override void Init() {} // 0x0000000180F86F50-0x0000000180F870F0
	// [XID] // 0x00000001898F6ED0-0x00000001898F6EF0
	private void InitMaterialsForSpecialState() {} // 0x0000000180F86600-0x0000000180F86F50
	// [XID] // 0x00000001898FE620-0x00000001898FE640
	public override void Tick(float inDeltaTime) {} // 0x0000000180F877B0-0x0000000180F87B70
	// [XID] // 0x00000001897C59C0-0x00000001897C59E0
	public void StartLerp(E_ShaderData dataType, MonoBuffShader_Lerp shaderData, bool dir, bool recoverOriginalShader, UnityEngine.Material sampleMat) {} // 0x0000000180F86450-0x0000000180F86600
	// [XID] // 0x000000018990D740-0x000000018990D760
	public void StartShaderPlus(E_ShaderPlus plusType, Renderer[] renderers, BodyMaterialType? bodyType, Color? color, float? param1, float? param2, ElementType? element) {} // 0x0000000180F85F40-0x0000000180F86230
	// [XID] // 0x0000000189823C40-0x0000000189823C60
	public void StopShaderPlus(E_ShaderPlus plusType, Renderer[] renderers) {} // 0x0000000180F87150-0x0000000180F87370
	// [XID] // 0x0000000189BB8BA0-0x0000000189BB8BC0
	public bool SetShader(MonoBuffShader_Lerp shaderData, bool dir) => default; // 0x0000000180F873E0-0x0000000180F87740
	// [XID] // 0x0000000189924310-0x0000000189924330
	public int ShaderEntriesCount(E_ShaderData shaderData) => default; // 0x0000000180F86230-0x0000000180F86300
	// [XID] // 0x000000018992B7C0-0x000000018992B7E0
	public void ClearShaderEntries(E_ShaderData shaderData) {} // 0x0000000180F86380-0x0000000180F86450
	// [XID] // 0x0000000189932FA0-0x0000000189932FC0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000180F859A0-0x0000000180F85BD0
	// [XID] // 0x00000001897F7020-0x00000001897F7040
	public void RecoverOriginalShaders() {} // 0x0000000180F85D30-0x0000000180F85F40
	// [XID] // 0x00000001899418F0-0x0000000189941910
	public override void Destroy() {} // 0x0000000180F85BD0-0x0000000180F85D30
}

