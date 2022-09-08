/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class BindingListenOptions // TypeDefIndex: 7594
	{
		// Fields
		public bool IncludeControllers; // 0x10
		public bool IncludeUnknownControllers; // 0x11
		public bool IncludeNonStandardControls; // 0x12
		public bool IncludeMouseButtons; // 0x13
		public bool IncludeMouseScrollWheel; // 0x14
		public bool IncludeKeys; // 0x15
		public bool IncludeModifiersAsFirstClassKeys; // 0x16
		public uint MaxAllowedBindings; // 0x18
		public uint MaxAllowedBindingsPerType; // 0x1C
		public bool AllowDuplicateBindingsPerSet; // 0x20
		public bool UnsetDuplicateBindingsOnSet; // 0x21
		public bool RejectRedundantBindings; // 0x22
		public BindingSource ReplaceBinding; // 0x28
		public Func<PlayerAction, BindingSource, bool> OnBindingFound; // 0x30
		public Action<PlayerAction, BindingSource> OnBindingAdded; // 0x38
		public Action<PlayerAction, BindingSource, BindingSourceRejectionType> OnBindingRejected; // 0x40
		public Action<PlayerAction> OnBindingEnded; // 0x48
	
		// Constructors
		public BindingListenOptions() {} // 0x0000000187DA99F0-0x0000000187DA9A90
	
		// Methods
		// [XID] // 0x0000000189BC9950-0x0000000189BC9970
		public bool CallOnBindingFound(PlayerAction playerAction, BindingSource bindingSource) => default; // 0x0000000187DA9820-0x0000000187DA9900
		// [XID] // 0x000000018963F050-0x000000018963F070
		public void CallOnBindingAdded(PlayerAction playerAction, BindingSource bindingSource) {} // 0x0000000187DA9680-0x0000000187DA9760
		// [XID] // 0x0000000189646960-0x0000000189646980
		public void CallOnBindingRejected(PlayerAction playerAction, BindingSource bindingSource, BindingSourceRejectionType bindingSourceRejectionType) {} // 0x0000000187DA9900-0x0000000187DA99F0
		// [XID] // 0x00000001896559B0-0x00000001896559D0
		public void CallOnBindingEnded(PlayerAction playerAction) {} // 0x0000000187DA9760-0x0000000187DA9820
	}
}
