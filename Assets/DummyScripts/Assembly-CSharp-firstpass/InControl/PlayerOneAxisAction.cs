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
	public class PlayerOneAxisAction : OneAxisInputControl // TypeDefIndex: 7611
	{
		// Fields
		private PlayerAction negativeAction; // 0x78
		private PlayerAction positiveAction; // 0x80
		public BindingSourceType LastInputType; // 0x88
	
		// Properties
		public object UserData { get; set; } // 0x0000000187F123C0-0x0000000187F12420 0x0000000187F12540-0x0000000187F125B0
	
		// Events
		public event Action<BindingSourceType> OnLastInputTypeChanged;
	
		// Constructors
		public PlayerOneAxisAction() {} // Dummy constructor
		internal PlayerOneAxisAction(PlayerAction negativeAction, PlayerAction positiveAction) {} // 0x0000000187F12200-0x0000000187F122A0
	
		// Methods
		// [XID] // 0x0000000189673EA0-0x0000000189673EC0
		internal void Update(ulong updateTick, float deltaTime) {} // 0x0000000187F12090-0x0000000187F12200
		// [XID] // 0x000000018967B640-0x000000018967B660
		private void ProcessActionUpdate(PlayerAction action) {} // 0x0000000187F11ED0-0x0000000187F12090
	}
}
