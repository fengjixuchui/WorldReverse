/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using InControl;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MultiplayerWithBindingsExample
{
	public class PlayerActions : PlayerActionSet // TypeDefIndex: 7580
	{
		// Fields
		public PlayerAction Green; // 0xA0
		public PlayerAction Red; // 0xA8
		public PlayerAction Blue; // 0xB0
		public PlayerAction Yellow; // 0xB8
		public PlayerAction Left; // 0xC0
		public PlayerAction Right; // 0xC8
		public PlayerAction Up; // 0xD0
		public PlayerAction Down; // 0xD8
		public PlayerTwoAxisAction Rotate; // 0xE0
	
		// Constructors
		public PlayerActions() {} // 0x00000001853DD110-0x00000001853DD270
	
		// Methods
		// [XID] // 0x00000001899C6830-0x00000001899C6850
		public static PlayerActions CreateWithKeyboardBindings() => default; // 0x00000001853DCCE0-0x00000001853DD110
		// [XID] // 0x00000001899CDD90-0x00000001899CDDB0
		public static PlayerActions CreateWithJoystickBindings() => default; // 0x00000001853DCA90-0x00000001853DCCE0
	}
}
