/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class StoragePool // TypeDefIndex: 10633
	{
		// Fields
		private const int RecycledCacheMaxCount = 64; // Metadata: 0x00AE7DDF
		private List<byte[]> m_storagePool; // 0x10
		private int m_storageSlotsUsedCount; // 0x18
		private static Random m_random; // 0x00
	
		// Constructors
		public StoragePool() {} // 0x00000001868AEF70-0x00000001868AF030
		static StoragePool() {} // 0x00000001868AEEF0-0x00000001868AEF70
	
		// Methods
		// [XID] // 0x00000001899F05C0-0x00000001899F05E0
		public byte[] GetStorage(int minimumCapacityInBytes) => default; // 0x00000001868AEA50-0x00000001868AEC60
		// [XID] // 0x000000018960C420-0x000000018960C440
		public byte[] GetExactStorage(int capacityInBytes) => default; // 0x00000001868AE840-0x00000001868AEA50
		// [XID] // 0x0000000189613A20-0x0000000189613A40
		public void Recycle(byte[] storage) {} // 0x00000001868AEC60-0x00000001868AEEF0
		// [XID] // 0x000000018961B310-0x000000018961B330
		public void Clear() {} // 0x00000001868AE720-0x00000001868AE840
	}
}
