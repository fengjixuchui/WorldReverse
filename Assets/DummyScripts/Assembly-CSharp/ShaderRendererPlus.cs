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

public class ShaderRendererPlus // TypeDefIndex: 14761
{
	// Fields
	public Renderer renderer; // 0x10
	public List<SpecialStateMaterialData> matList; // 0x18
	private BaseEntity _entity; // 0x20
	private static Dictionary<UnityEngine.Material, BodyMaterialType> cacheNameToType; // 0x00
	private MonoBuffShader_Plus _shaderPlusHitFlash; // 0x28
	private float _hitFlashDuration; // 0x30
	private float _hitFlashTimeLeft; // 0x34
	private int _elementColorIndex; // 0x38
	private MonoBuffShader_Plus _shaderPlusEmission; // 0x40
	private float _emissionDuration; // 0x48
	private float _emissionTimeLeft; // 0x4C
	private BodyMaterialType _curMatType; // 0x50
	private MonoBuffShader_Plus _shaderPlusSkillEmission; // 0x58
	private float _skillEmissionDuration; // 0x60
	private float _skillEmissionTimeLeft; // 0x64
	private MonoBuffShader_Plus _shaderPlusOuterGlow; // 0x68
	private Color _outerGlowColor; // 0x70
	private float _outerGlowStrength; // 0x80
	private float _outerTimeLeft; // 0x84
	private bool _isStartOuterGlow; // 0x88
	private float _outerGlowEnableDuration; // 0x8C
	private float _outerGlowDisableDuration; // 0x90

	// Properties
	public bool needTick { /* [XID] */ /* 0x0000000189BCF770-0x0000000189BCF790 */ get => default; /* [XID] */ /* 0x0000000189BD6BA0-0x0000000189BD6BC0 */ set {} } // 0x0000000182FD7980-0x0000000182FD7A60 0x0000000182FD76C0-0x0000000182FD7770

	// Constructors
	public ShaderRendererPlus() {} // Dummy constructor
	public ShaderRendererPlus(ShaderLerpPlugin plugin, BaseEntity entity) {} // 0x0000000182FD91A0-0x0000000182FD9290
	static ShaderRendererPlus() {} // 0x0000000182FD9110-0x0000000182FD91A0

	// Methods
	// [XID] // 0x0000000189BDE920-0x0000000189BDE940
	public void Tick(float inDeltaTime) {} // 0x0000000182FD7250-0x0000000182FD7330
	// [XID] // 0x00000001895EB3D0-0x00000001895EB3F0
	public void Clear() {} // 0x0000000182FD7330-0x0000000182FD73F0
	// [XID] // 0x0000000189883830-0x0000000189883850
	public void StartShaderPlus(E_ShaderPlus plusType, BodyMaterialType? matType, Color? color, float? param1, float? param2, ElementType? element) {} // 0x0000000182FD6C80-0x0000000182FD6E40
	// [XID] // 0x00000001895FA140-0x00000001895FA160
	public void StopShaderPlus(E_ShaderPlus plusType) {} // 0x0000000182FD8020-0x0000000182FD80E0
	// [XID] // 0x0000000189601AF0-0x0000000189601B10
	private void InitHitFlash() {} // 0x0000000182FD7F20-0x0000000182FD8020
	// [XID] // 0x0000000189609280-0x00000001896092A0
	private void TickHitFlash(float inDeltaTime) {} // 0x0000000182FD8500-0x0000000182FD8720
	// [XID] // 0x0000000189610A40-0x0000000189610A60
	private void StartHitFlash(ElementType? element) {} // 0x0000000182FD7770-0x0000000182FD7890
	// [XID] // 0x0000000189617D70-0x0000000189617D90
	private void ClearHitFlash() {} // 0x0000000182FD8CD0-0x0000000182FD8D80
	// [XID] // 0x000000018961FA30-0x000000018961FA50
	private void InitEmission() {} // 0x0000000182FD7890-0x0000000182FD7980
	// [XID] // 0x0000000189626D10-0x0000000189626D30
	private void TickEmission(float inDeltaTime) {} // 0x0000000182FD8A90-0x0000000182FD8CD0
	// [XID] // 0x000000018962E660-0x000000018962E680
	private bool IsInValidMat(UnityEngine.Material mat, BodyMaterialType body) => default; // 0x0000000182FD8720-0x0000000182FD8930
	// [XID] // 0x000000018988B070-0x000000018988B090
	private void StartEmission(BodyMaterialType matType, Color? color, float? param1, float? param2) {} // 0x0000000182FD80E0-0x0000000182FD8460
	// [XID] // 0x000000018963D910-0x000000018963D930
	private void ClearEmission() {} // 0x0000000182FD8460-0x0000000182FD8500
	// [XID] // 0x0000000189644F60-0x0000000189644F80
	private void InitSkillEmission() {} // 0x0000000182FD8D80-0x0000000182FD8E70
	// [XID] // 0x000000018964C9E0-0x000000018964CA00
	private void TickSkillEmission(float inDeltaTime) {} // 0x0000000182FD6A50-0x0000000182FD6C80
	// [XID] // 0x00000001898A10C0-0x00000001898A10E0
	private void StartSkillEmission(Color? color, float? param1, float? param2) {} // 0x0000000182FD6E40-0x0000000182FD7250
	// [XID] // 0x000000018965B7B0-0x000000018965B7D0
	private void ClearSkillEmission() {} // 0x0000000182FD8930-0x0000000182FD8A90
	// [XID] // 0x0000000189662B90-0x0000000189662BB0
	private void InitOuterGlow() {} // 0x0000000182FD6940-0x0000000182FD6A50
	// [XID] // 0x000000018966A6F0-0x000000018966A710
	private void TickOuterGlow(float inDeltaTime) {} // 0x0000000182FD7A60-0x0000000182FD7F20
	// [XID] // 0x0000000189672390-0x00000001896723B0
	private void StartOuterGlow(ElementType? element) {} // 0x0000000182FD73F0-0x0000000182FD7610
	// [XID] // 0x0000000189679C40-0x0000000189679C60
	private void StopOuterGlow() {} // 0x0000000182FD7610-0x0000000182FD76C0
	// [XID] // 0x0000000189681300-0x0000000189681320
	private void ClearOuterGlow() {} // 0x0000000182FD8E70-0x0000000182FD9110
}

