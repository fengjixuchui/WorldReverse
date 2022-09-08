/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public interface IConnection // TypeDefIndex: 10672
	{
		// Properties
		Func<IConnection, ArraySegment<byte>, bool> receiveCallback { get; set; }
	
		// Methods
		void Flush();
		void Send(byte[] msg, bool flush = true /* Metadata: 0x00AE8080 */);
		void Send(ArraySegment<byte> msg, bool flush = true /* Metadata: 0x00AE8081 */);
		void Send(string msg, bool flush = true /* Metadata: 0x00AE8082 */);
		void Close();
		bool IsConnecting();
		bool IsConnected();
		bool IsDisconnect();
		string GetName();
	}
}
