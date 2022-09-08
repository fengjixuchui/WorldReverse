/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MiHoYoShaderIndexData : ScriptableObject // TypeDefIndex: 19892
	{
		// Fields
		public static string indexPath; // 0x00
		public static ulong indexHash; // 0x08
		private const int MAX_SHADER_NUM = 1024; // Metadata: 0x00AFD056
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ShaderIndexFile[] shaderWarmupInfos; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int shaderLabMainVersion_; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int shaderLabSubVersion_; // 0x24
	
		// Properties
		public int shaderLabMainVersion { /* [XID] */ /* 0x00000001899D4400-0x00000001899D4420 */ get => default; /* [XID] */ /* 0x00000001899DBB90-0x00000001899DBBB0 */ set {} } // 0x0000000181140800-0x00000001811408A0 0x0000000181140940-0x00000001811409F0
		public int shaderLabSubVersion { /* [XID] */ /* 0x00000001899E3490-0x00000001899E34B0 */ get => default; /* [XID] */ /* 0x00000001899EA8A0-0x00000001899EA8C0 */ set {} } // 0x00000001811408A0-0x0000000181140940 0x00000001811409F0-0x0000000181140AA0
	
		// Nested types
		[Serializable]
		private struct ShaderIndexFile // TypeDefIndex: 19893
		{
			// Fields
			public ulong hash; // 0x00
			public byte[] warmupindexdata; // 0x08
		}
	
		// Constructors
		public MiHoYoShaderIndexData() {} // 0x0000000181140790-0x0000000181140800
		static MiHoYoShaderIndexData() {} // 0x0000000181140710-0x0000000181140790
	
		// Methods
		// [XID] // 0x00000001899F2470-0x00000001899F2490
		public bool SetIndices(List<ulong> filepathes, List<byte[]> datas) => default; // 0x000000018113FEA0-0x00000001811402C0
		// [XID] // 0x00000001899F9A50-0x00000001899F9A70
		public bool CheckContent(ShaderVariantCollection svc) => default; // 0x00000001811403E0-0x0000000181140710
		[DebuggerHidden] // 0x0000000189A00DD0-0x0000000189A00E10
		// [XID] // 0x0000000189A00DD0-0x0000000189A00E10
		public IEnumerator LoadShaderWarmupIndex(Action<float> progressCB) => default; // 0x00000001811402C0-0x00000001811403E0
	}
}
