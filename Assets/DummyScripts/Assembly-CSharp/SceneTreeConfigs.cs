/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public sealed class SceneTreeConfigs : ScriptableObjectUseFiEdit // TypeDefIndex: 31862
{
	// Fields
	public List<ScenePropHitEffectConfig> sceneTreeHitEffects; // 0x18
	public List<SceneTreeConfig> sceneTreeConfigs; // 0x20
	[NonSerialized]
	private Dictionary<int, SceneTreeConfig> _name2TreeConfig; // 0x28
	[NonSerialized]
	private Dictionary<int, ScenePropHitEffectConfig> _name2HitEffectConfig; // 0x30

	// Constructors
	public SceneTreeConfigs() {} // 0x0000000181B5DDF0-0x0000000181B5DEF0

	// Methods
	public void Init() {} // 0x0000000181B5DB20-0x0000000181B5DDF0
	public void Clear() {} // 0x0000000181B5D960-0x0000000181B5D9D0
	public SceneTreeConfig GetObjInfoByName(int nameHash) => default; // 0x0000000181B5DA70-0x0000000181B5DB20
	public ScenePropHitEffectConfig GetHitEffectInfoByName(int nameHash) => default; // 0x0000000181B5D9D0-0x0000000181B5DA70
}

