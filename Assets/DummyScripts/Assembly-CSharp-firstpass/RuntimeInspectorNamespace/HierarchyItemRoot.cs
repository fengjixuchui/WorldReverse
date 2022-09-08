/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class HierarchyItemRoot : HierarchyItem // TypeDefIndex: 9965
	{
		// Fields
		private List<GameObject> childObjects; // 0x98
	
		// Properties
		protected override bool IsValid { /* [XID] */ /* 0x0000000189B7DC00-0x0000000189B7DC20 */ get => default; } // 0x00000001867F1E40-0x00000001867F1F40 
		protected override int ChildCount { /* [XID] */ /* 0x00000001896169B0-0x00000001896169D0 */ get => default; } // 0x00000001867F1D20-0x00000001867F1DE0 
		public IHierarchyRootContent Content { /* [XID] */ /* 0x000000018961E340-0x000000018961E380 */ get; /* [XID] */ /* 0x0000000189628940-0x0000000189628980 */ private set; } // 0x00000001867F1DE0-0x00000001867F1E40 0x00000001867F1F40-0x00000001867F1FB0
	
		// Constructors
		public HierarchyItemRoot() {} // 0x00000001867F1C80-0x00000001867F1D20
	
		// Methods
		// [XID] // 0x0000000189633210-0x0000000189633230
		public void BindTo(IHierarchyRootContent target) {} // 0x00000001867F14E0-0x00000001867F16E0
		// [XID] // 0x0000000189938CE0-0x0000000189938D00
		public override void Unbind() {} // 0x00000001867F1B80-0x00000001867F1C80
		// [XID] // 0x00000001896422D0-0x00000001896422F0
		protected override void OnSkinChanged() {} // 0x00000001867F17C0-0x00000001867F18F0
		// [XID] // 0x0000000189736450-0x0000000189736470
		protected override void RefreshContent() {} // 0x00000001867F18F0-0x00000001867F1A60
		// [XID] // 0x0000000189BAA160-0x0000000189BAA180
		protected override Transform GetChild(int index) => default; // 0x00000001867F16E0-0x00000001867F17C0
	}
}
