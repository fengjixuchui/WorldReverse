/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMallBasePanel : MonoBehaviour // TypeDefIndex: 31048
	{
		// Fields
		protected List<ShopMaterial> _shopMaterialsList; // 0x18
		protected MallPageContext _mallContext; // 0x20
		protected ShopData _shopData; // 0x28
	
		// Constructors
		public MonoMallBasePanel() {} // 0x0000000184290A20-0x0000000184290A80
	
		// Methods
		// [XID] // 0x00000001896C7570-0x00000001896C7590
		public virtual int GetCurTabIndex() => default; // 0x0000000184290800-0x00000001842908A0
		// [XID] // 0x00000001896CECD0-0x00000001896CECF0
		public virtual void InitPanel(ShopData data, List<ShopMaterial> list, MallPageContext context) {} // 0x00000001842908A0-0x0000000184290980
		// [XID] // 0x00000001896D60D0-0x00000001896D60F0
		public virtual void RefreshPanel() {} // 0x0000000184290980-0x0000000184290A20
		// [XID] // 0x00000001896DD660-0x00000001896DD680
		public virtual void ClearPanel() {} // 0x0000000184290760-0x0000000184290800
	}
}
