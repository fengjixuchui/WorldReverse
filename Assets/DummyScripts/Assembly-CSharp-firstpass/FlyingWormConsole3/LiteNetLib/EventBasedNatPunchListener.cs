/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public class EventBasedNatPunchListener : INatPunchListener // TypeDefIndex: 6895
	{
		// Events
		public event OnNatIntroductionRequest NatIntroductionRequest;
		public event OnNatIntroductionSuccess NatIntroductionSuccess;
	
		// Nested types
		public delegate void OnNatIntroductionRequest(NetEndPoint localEndPoint, NetEndPoint remoteEndPoint, string token); // TypeDefIndex: 6896; 0x00000001863D1BE0-0x00000001863D1ED0
	
		public delegate void OnNatIntroductionSuccess(NetEndPoint targetEndPoint, string token); // TypeDefIndex: 6897; 0x00000001863D2050-0x00000001863D2300
	
		// Constructors
		public EventBasedNatPunchListener() {} // 0x00000001863B4860-0x00000001863B48C0
	
		// Methods
		// [XID] // 0x00000001896B7050-0x00000001896B7070
		void INatPunchListener.OnNatIntroductionRequest(NetEndPoint localEndPoint, NetEndPoint remoteEndPoint, string token) {} // 0x00000001863B4690-0x00000001863B4780
		// [XID] // 0x00000001896BE140-0x00000001896BE160
		void INatPunchListener.OnNatIntroductionSuccess(NetEndPoint targetEndPoint, string token) {} // 0x00000001863B4780-0x00000001863B4860
	}
}
