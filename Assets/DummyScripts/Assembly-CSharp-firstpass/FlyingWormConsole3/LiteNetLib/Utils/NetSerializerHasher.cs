/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	public abstract class NetSerializerHasher // TypeDefIndex: 6922
	{
		// Constructors
		protected NetSerializerHasher() {} // 0x0000000186B44AA0-0x0000000186B44B00
	
		// Methods
		public abstract ulong GetHash(string type);
		public abstract void WriteHash(ulong hash, NetDataWriter writer);
		public abstract ulong ReadHash(NetDataReader reader);
	}
}
