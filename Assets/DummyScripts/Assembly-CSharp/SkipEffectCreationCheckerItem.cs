/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SkipEffectCreationCheckerItem // TypeDefIndex: 19853
{
	// Fields
	private ConfigSkipUnindexedEffectCreation _skipConfig; // 0x10
	private EffectPoolItem _poolItem; // 0x18
	private bool withinDistance; // 0x20
	private Vector3 checkPos; // 0x24

	// Constructors
	public SkipEffectCreationCheckerItem() {} // 0x0000000181669C00-0x0000000181669C60

	// Methods
	// [XID] // 0x00000001897F96B0-0x00000001897F96D0
	public void Init(ConfigSkipUnindexedEffectCreation skipConfig, EffectPoolItem poolItem) {} // 0x00000001816698C0-0x0000000181669990
	// [XID] // 0x00000001898002A0-0x00000001898002C0
	public void Destroy() {} // 0x0000000181669820-0x00000001816698C0
	// [XID] // 0x0000000189808140-0x0000000189808160
	public bool CanSkipCreation(Vector3 initPos) => default; // 0x0000000181669AC0-0x0000000181669C00
	// [XID] // 0x000000018980FB50-0x000000018980FB70
	private bool CheckCanSkipCreationByDistance(Vector3 initPos) => default; // 0x0000000181669990-0x0000000181669AC0
	// [XID] // 0x0000000189817E40-0x0000000189817E60
	public void VisitAndCheckDistance(MonoEffect effect) {} // 0x00000001816695E0-0x0000000181669820
}

