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
	public class PlayerTwoAxisAction : TwoAxisInputControl // TypeDefIndex: 7612
	{
		// Fields
		private PlayerAction negativeXAction; // 0x70
		private PlayerAction positiveXAction; // 0x78
		private PlayerAction negativeYAction; // 0x80
		private PlayerAction positiveYAction; // 0x88
		public BindingSourceType LastInputType; // 0x94
	
		// Properties
		public bool InvertXAxis { /* [XID] */ /* 0x00000001896ACC80-0x00000001896ACCC0 */ get; set; } // 0x0000000187F12C70-0x0000000187F12CD0 0x0000000187F12EB0-0x0000000187F12F20
		public bool InvertYAxis { /* [XID] */ /* 0x00000001896BE0E0-0x00000001896BE120 */ get; set; } // 0x0000000187F12CD0-0x0000000187F12D30 0x0000000187F12F20-0x0000000187F12F90
		public object UserData { get; set; } // 0x0000000187F12D30-0x0000000187F12D90 0x0000000187F12F90-0x0000000187F13000
	
		// Events
		public event Action<BindingSourceType> OnLastInputTypeChanged;
	
		// Constructors
		public PlayerTwoAxisAction() {} // Dummy constructor
		internal PlayerTwoAxisAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction) {} // 0x0000000187F12A10-0x0000000187F12B50
	
		// Methods
		// [XID] // 0x0000000189BACE80-0x0000000189BACEA0
		internal void Update(ulong updateTick, float deltaTime) {} // 0x0000000187F12750-0x0000000187F12A10
		// [XID] // 0x00000001899E8CA0-0x00000001899E8CC0
		private void ProcessActionUpdate(PlayerAction action) {} // 0x0000000187F125B0-0x0000000187F12750
	}
}
