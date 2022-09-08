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

public class BaseUISceneContextComponent : BaseContextComponent // TypeDefIndex: 28536
{
	// Constructors
	public BaseUISceneContextComponent() {} // 0x000000018236D870-0x000000018236D8D0

	// Methods
	// [XID] // 0x00000001896EF490-0x00000001896EF4B0
	public override void Init(GameObject view) {} // 0x000000018236D450-0x000000018236D520
	// [XID] // 0x00000001896F6E20-0x00000001896F6E40
	public override void Destroy() {} // 0x000000018236D3A0-0x000000018236D450
	// [XID] // 0x00000001896FE750-0x00000001896FE770
	public override void UpdateView() {} // 0x000000018236D7C0-0x000000018236D870
	// [XID] // 0x00000001897058C0-0x00000001897058E0
	protected virtual void InitUIScene() {} // 0x000000018236D300-0x000000018236D3A0
	// [XID] // 0x000000018970D380-0x000000018970D3A0
	protected virtual void ClearUIScene() {} // 0x000000018236D720-0x000000018236D7C0
	// [XID] // 0x0000000189714820-0x0000000189714840
	protected virtual void UpdateUIScene() {} // 0x000000018236D5E0-0x000000018236D680
	// [XID] // 0x000000018971C270-0x000000018971C290
	protected virtual void PrepareUIScenePlugin() {} // 0x000000018236D680-0x000000018236D720
	protected T GetUIScenePlugin<T>(UIScenePluginType pluginType)
		where T : BaseUIScenePlugin => default;
}

