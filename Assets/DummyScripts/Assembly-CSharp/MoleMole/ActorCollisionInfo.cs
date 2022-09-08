/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
	public struct ActorCollisionInfo : ILuaActorCollisionInfo // TypeDefIndex: 21064
	{
		// Fields
		private string _alias; // 0x00
		private bool _isStandby; // 0x08
		private bool _isWalk; // 0x09
		private bool _isRun; // 0x0A
		private bool _isSprint; // 0x0B
		private bool _isFromBack; // 0x0C
	
		// Properties
		public string alias { /* [XID] */ /* 0x000000018970ED60-0x000000018970ED80 */ get => default; /* [XID] */ /* 0x0000000189716180-0x00000001897161A0 */ set {} } // 0x0000000181A3FDA0-0x0000000181A3FE50 0x0000000181A401D0-0x0000000181A40290
		public bool isStandby { /* [XID] */ /* 0x000000018971DC00-0x000000018971DC20 */ get => default; /* [XID] */ /* 0x00000001897250E0-0x0000000189725100 */ set {} } // 0x0000000181A40060-0x0000000181A40110 0x0000000181A40410-0x0000000181A404D0
		public bool isWalk { /* [XID] */ /* 0x000000018972C7C0-0x000000018972C7E0 */ get => default; /* [XID] */ /* 0x0000000189733ED0-0x0000000189733EF0 */ set {} } // 0x0000000181A40110-0x0000000181A401D0 0x0000000181A404D0-0x0000000181A40590
		public bool isRun { /* [XID] */ /* 0x000000018973B670-0x000000018973B690 */ get => default; /* [XID] */ /* 0x0000000189743120-0x0000000189743140 */ set {} } // 0x0000000181A3FF00-0x0000000181A3FFB0 0x0000000181A40290-0x0000000181A40350
		public bool isSprint { /* [XID] */ /* 0x000000018974AC80-0x000000018974ACA0 */ get => default; /* [XID] */ /* 0x0000000189751D70-0x0000000189751D90 */ set {} } // 0x0000000181A3FFB0-0x0000000181A40060 0x0000000181A40350-0x0000000181A40410
		public bool isFromBack { /* [XID] */ /* 0x0000000189759400-0x0000000189759420 */ get => default; } // 0x0000000181A3FE50-0x0000000181A3FF00 
	
		// Methods
		// [XID] // 0x00000001896FFD80-0x00000001896FFDA0
		public static ActorCollisionInfo Create(BaseEntity entity) => default; // 0x0000000181A3FAD0-0x0000000181A3FCF0
		// [XID] // 0x00000001897074A0-0x00000001897074C0
		public void InitInfo(bool isFromBack) {} // 0x0000000181A3FCF0-0x0000000181A3FDA0
	}
}
