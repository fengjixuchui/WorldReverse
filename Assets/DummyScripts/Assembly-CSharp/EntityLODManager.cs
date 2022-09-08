/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityLODManager : InLevelManager // TypeDefIndex: 20724
{
	// Fields
	private EntityLODProfile _curProfile; // 0x10
	private uint _curProfileHandle; // 0x18
	private string _curProfileName; // 0x20
	public EntityLODConfig _lodConfig; // 0x28
	private uint _lodConfigHandle; // 0x30
	public EntityLODInfoMap _lodFinInfoMap; // 0x38
	private uint _lodFinInfoMapHandle; // 0x40

	// Properties
	public EntityLODConfig lodConfig { get => default; } // 0x0000000183691150-0x00000001836912B0 
	public EntityLODInfoMap lodFinInfoMap { get => default; } // 0x00000001836912B0-0x0000000183691410 
	public EntityLODProfile curProfile { get => default; } // 0x0000000183690FF0-0x0000000183691150 

	// Constructors
	public EntityLODManager() {} // 0x0000000183690F40-0x0000000183690FF0

	// Methods
	public void InitUtil() {} // 0x000000018368F9A0-0x000000018368FB20
	public void SetEntityFinInfoMap(string name) {} // 0x000000018368FE90-0x000000018368FFB0
	public void SetEntityLODConfig(string name) {} // 0x000000018368FFB0-0x00000001836900D0
	public void SetSplitProfile(string name) {} // 0x0000000183690D40-0x0000000183690F40
	public override void Init() {} // 0x000000018368FB20-0x000000018368FB80
	public void OnEntityLoaded(BaseEntity entity) {} // 0x000000018368FB80-0x000000018368FC00
	private void SetEntityLod(BaseEntity entity) {} // 0x00000001836900D0-0x0000000183690930
	public void OnNpcCrowdLoaded(MiHoYoLodLoader lodLoader, string patternName) {} // 0x000000018368FC00-0x000000018368FE90
	private void SetLodLoader(MiHoYoLodLoader lodLoader, float[] array, float disableAnimatorLod) {} // 0x0000000183690930-0x00000001836909E0
	public override void Destroy() {} // 0x000000018368F850-0x000000018368F9A0
	public void SetNpcLodToMax(BaseEntity entity) {} // 0x0000000183690B90-0x0000000183690D40
	public void SetNpcLodToDefault(BaseEntity entity) {} // 0x00000001836909E0-0x0000000183690B90
}

