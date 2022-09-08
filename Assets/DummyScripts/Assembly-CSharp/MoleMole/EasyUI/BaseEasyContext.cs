/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.EasyUI
{
	public class BaseEasyContext // TypeDefIndex: 28565
	{
		// Fields
		public string name; // 0x10
		protected GameObject go; // 0x18
	
		// Constructors
		public BaseEasyContext() {} // Dummy constructor
		public BaseEasyContext(string name, GameObject go) {} // 0x0000000184D77140-0x0000000184D771D0
	
		// Methods
		// [XID] // 0x0000000189B76D70-0x0000000189B76D90
		private void SetupView(string name, GameObject go) {} // 0x0000000184D76F90-0x0000000184D77060
		// [XID] // 0x0000000189B7E300-0x0000000189B7E320
		public virtual void OnEnter() {} // 0x0000000184D76D80-0x0000000184D76E30
		// [XID] // 0x0000000189B85F20-0x0000000189B85F40
		public virtual void OnExit() {} // 0x0000000184D76E30-0x0000000184D76EE0
		// [XID] // 0x0000000189B8CF50-0x0000000189B8CF70
		public virtual void OnRecover() {} // 0x0000000184D76EE0-0x0000000184D76F90
		// [XID] // 0x0000000189B94740-0x0000000189B94760
		public virtual void OnCovered() {} // 0x0000000184D76CD0-0x0000000184D76D80
		// [XID] // 0x0000000189B9BDB0-0x0000000189B9BDD0
		protected virtual void ShowView() {} // 0x0000000184D77060-0x0000000184D77140
		// [XID] // 0x0000000189BA34F0-0x0000000189BA3510
		protected virtual void HideView() {} // 0x0000000184D76C00-0x0000000184D76CD0
		// [XID] // 0x0000000189BAA850-0x0000000189BAA870
		public virtual void ClearView() {} // 0x0000000184D76B60-0x0000000184D76C00
	}
}
