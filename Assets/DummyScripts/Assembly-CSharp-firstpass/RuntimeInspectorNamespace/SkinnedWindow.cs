/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public abstract class SkinnedWindow : MonoBehaviour // TypeDefIndex: 10036
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UISkin m_skin; // 0x18
		private int m_skinVersion; // 0x20
	
		// Properties
		public UISkin Skin { /* [XID] */ /* 0x00000001896F6740-0x00000001896F6760 */ get; /* [XID] */ /* 0x00000001896FDE90-0x00000001896FDEB0 */ set; } // 0x0000000186750750-0x00000001867507F0 0x00000001867507F0-0x0000000186750930
	
		// Constructors
		protected SkinnedWindow() {} // 0x00000001867506E0-0x0000000186750750
	
		// Methods
		// [XID] // 0x0000000189705210-0x0000000189705230
		protected virtual void Awake() {} // 0x00000001867504E0-0x00000001867505E0
		// [XID] // 0x000000018970C8C0-0x000000018970C8E0
		protected virtual void Update() {} // 0x00000001867505E0-0x00000001867506E0
		protected abstract void RefreshSkin();
	}
}
