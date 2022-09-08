/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShaderDataManager : InLevelManager // TypeDefIndex: 21003
{
	// Fields
	private MonoBuffShader_Lerp[] ShaderDataList; // 0x10
	private MonoBuffShader_Plus[] ShaderPlusList; // 0x18

	// Constructors
	public ShaderDataManager() {} // 0x0000000183A7D0B0-0x0000000183A7D110

	// Methods
	// [XID] // 0x0000000189A2A420-0x0000000189A2A440
	public override void Init() {} // 0x0000000183A7CC20-0x0000000183A7CDC0
	// [XID] // 0x0000000189A31890-0x0000000189A318B0
	public override void Destroy() {} // 0x0000000183A7C890-0x0000000183A7C930
	// [XID] // 0x0000000189A393D0-0x0000000189A393F0
	public MonoBuffShader_Lerp GetBuffShaderData(E_ShaderData buff) => default; // 0x0000000183A7CDC0-0x0000000183A7D0B0
	// [XID] // 0x0000000189A40B90-0x0000000189A40BB0
	public MonoBuffShader_Plus GetBuffShaderPlus(E_ShaderPlus buff) => default; // 0x0000000183A7C930-0x0000000183A7CC20
	// [XID] // 0x00000001897D0010-0x00000001897D0030
	public static E_ShaderData GetShaderUseType(ShaderUseType shaderType, AbilityState element, VCBaseModel vcModel) => default; // 0x0000000183A7C4A0-0x0000000183A7C890
}

