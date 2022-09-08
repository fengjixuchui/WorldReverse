/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x0000000189BDA3C0-0x0000000189BDA420
// [RequireComponent] // 0x0000000189BDA3C0-0x0000000189BDA420
public class EnviroEffects : MonoBehaviour // TypeDefIndex: 31447
{
	// Fields
	protected bool supportHDRTextures; // 0x18
	protected bool supportDX11; // 0x19
	protected bool isSupported; // 0x1A

	// Constructors
	public EnviroEffects() {} // 0x0000000183695F90-0x0000000183696000

	// Methods
	protected UnityEngine.Material CheckShaderAndCreateMaterial(Shader s, UnityEngine.Material m2Create) => default; // 0x0000000183694C80-0x0000000183695110
	protected UnityEngine.Material CreateMaterial(Shader s, UnityEngine.Material m2Create) => default; // 0x00000001836956B0-0x0000000183695900
	private void OnEnable() {} // 0x0000000183695E00-0x0000000183695E60
	protected bool CheckSupport() => default; // 0x0000000183695590-0x0000000183695600
	public virtual bool CheckResources() => default; // 0x0000000183694B90-0x0000000183694C80
	protected void Start() {} // 0x0000000183695F40-0x0000000183695F90
	protected bool CheckSupport(bool needDepth) => default; // 0x0000000183695430-0x0000000183695590
	protected bool CheckSupport(bool needDepth, bool needHdr) => default; // 0x0000000183695600-0x00000001836956B0
	public bool Dx11Support() => default; // 0x0000000183695D30-0x0000000183695D90
	protected void ReportAutoDisable() {} // 0x0000000183695E60-0x0000000183695F40
	private bool CheckShader(Shader s) => default; // 0x0000000183695110-0x0000000183695430
	protected void NotSupported() {} // 0x0000000183695D90-0x0000000183695E00
	protected void DrawBorder(RenderTexture dest, UnityEngine.Material material) {} // 0x0000000183695900-0x0000000183695D30
}

