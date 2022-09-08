/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoClientPacketConsumer : MonoBehaviour // TypeDefIndex: 21736
	{
		// Fields
		public string host; // 0x18
		public ushort port; // 0x20
		private const float RECONNECT_INTERVAL = 5f; // Metadata: 0x00AFFD6B
		public uint lastServerPacketId; // 0x24
		public uint clientPacketId; // 0x28
		public bool netReachAlreadyInit; // 0x2C
		public NetworkReachability netReach; // 0x30
		public const float CHECK_REACH_TIME_INTERVAL = 1f; // Metadata: 0x00AFFD6F
		public Status _status; // 0x34
	
		// Nested types
		public enum Status // TypeDefIndex: 21737
		{
			Normal = 0,
			WaitingConnect = 1,
			RepeatLogin = 2
		}
	
		// Constructors
		public MonoClientPacketConsumer() {} // 0x0000000184B9F5E0-0x0000000184B9F660
	}
}
