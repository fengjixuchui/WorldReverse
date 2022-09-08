/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Data.SoundBank
{
	public class ConfigSoundBankDataReader // TypeDefIndex: 19388
	{
		// Nested types
		private class ConfigAbstraction : ConfigObjectAbstraction<ConfigSoundBankLookup> // TypeDefIndex: 19389
		{
			// Constructors
			public ConfigAbstraction() {} // 0x0000000184E81290-0x0000000184E81300
	
			// Methods
			// [XID] // 0x0000000189947140-0x0000000189947160
			protected override ConfigSoundBankLookup CreateInstance() => default; // 0x0000000184E81000-0x0000000184E810C0
			// [XID] // 0x000000018994E760-0x000000018994E780
			protected override bool FromBinary(ConfigSoundBankLookup instance, ByteArray bytes) => default; // 0x0000000184E810C0-0x0000000184E811B0
			// [XID] // 0x0000000189955D80-0x0000000189955DA0
			protected override bool FromJson(ConfigSoundBankLookup instance, JSONNode json) => default; // 0x0000000184E811B0-0x0000000184E81290
		}
	
		// Constructors
		public ConfigSoundBankDataReader() {} // 0x0000000184E82120-0x0000000184E82180
	
		// Methods
		// [XID] // 0x000000018991BE20-0x000000018991BE40
		public SoundBankLookupData ReadFromConfig() => default; // 0x0000000184E81940-0x0000000184E81AC0
		// [XID] // 0x0000000189923520-0x0000000189923540
		private SoundBankLookupData LoadSoundBankLookupConfig(ConfigMetaConfig.PathHash fileHash) => default; // 0x0000000184E817C0-0x0000000184E81940
		private unsafe SoundBankDataHeader* ConvertConfigToUnmanagedStructPointer(ConfigSoundBankLookup config) => default; // 0x0000000184E81300-0x0000000184E817C0
		// [XID] // 0x000000018992AC20-0x000000018992AC40
		private void WriteEvents(uint[] plainEvents, List<byte> buffer, out int? offset, out int length) {
			offset = default;
			length = default;
		} // 0x0000000184E81BA0-0x0000000184E81D60
		private unsafe void WriteEvent(List<byte> buffer, AudioEventUnion* pEvent) {} // 0x0000000184E81AC0-0x0000000184E81BA0
		// [IDTag] // 0x00000001899321E0-0x0000000189932220
		// [XID] // 0x00000001899321E0-0x0000000189932220
		private void WriteUInt32Array(uint[] array, List<byte> buffer, out int? offset, out int length) {
			offset = default;
			length = default;
		} // 0x0000000184E81F80-0x0000000184E82120
		// [IDTag] // 0x000000018993CBB0-0x000000018993CBF0
		// [XID] // 0x000000018993CBB0-0x000000018993CBF0
		private void WriteUInt32Array(string[] array, List<byte> buffer, out int? offset, out int length) {
			offset = default;
			length = default;
		} // 0x0000000184E81D60-0x0000000184E81F80
	}
}
