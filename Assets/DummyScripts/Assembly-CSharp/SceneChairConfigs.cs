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
public sealed class SceneChairConfigs : ScriptableObjectUseFiEdit // TypeDefIndex: 31842
{
	// Fields
	public List<SceneChairConfig.SitAnimPattern> sitAnimPatterns; // 0x18
	public List<SceneChairConfig> sceneChairConfigs; // 0x20
	[NonSerialized]
	private Dictionary<int, SceneChairConfig> _name2ChairConfig; // 0x28

	// Constructors
	public SceneChairConfigs() {} // 0x0000000181B5D010-0x0000000181B5D0E0

	// Methods
	public void Init() {} // 0x0000000181B5CDF0-0x0000000181B5D010
	public void Clear() {} // 0x0000000181B5CCD0-0x0000000181B5CD40
	public SceneChairConfig GetObjInfoByName(int nameHash) => default; // 0x0000000181B5CD40-0x0000000181B5CDF0
}

