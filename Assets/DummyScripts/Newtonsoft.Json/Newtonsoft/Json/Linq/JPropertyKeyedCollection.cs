/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	// [DefaultMember] // 0x0000000189B45780-0x0000000189B457C0
	[Preserve] // 0x0000000189B45780-0x0000000189B457C0
	internal class JPropertyKeyedCollection : Collection<Newtonsoft.Json.Linq.JToken> // TypeDefIndex: 5417
	{
		// Fields
		private static readonly IEqualityComparer<string> Comparer; // 0x00
		private Dictionary<string, JToken> _dictionary; // 0x20
	
		// Properties
		public ICollection<string> Keys { get => default; } // 0x0000000186C70550-0x0000000186C705E0 
	
		// Constructors
		public JPropertyKeyedCollection() {} // 0x0000000186C704C0-0x0000000186C70550
		static JPropertyKeyedCollection() {} // 0x0000000186C70430-0x0000000186C704C0
	
		// Methods
		private void AddKey(string key, JToken item) {} // 0x0000000186C6F7E0-0x0000000186C6F880
		protected override void ClearItems() {} // 0x0000000186C6F880-0x0000000186C6F900
		public bool Contains(string key) => default; // 0x0000000186C6FC50-0x0000000186C6FD20
		private void EnsureDictionary() {} // 0x0000000186C6FD20-0x0000000186C6FDF0
		private string GetKeyForItem(JToken item) => default; // 0x0000000186C6FDF0-0x0000000186C6FF30
		protected override void InsertItem(int index, JToken item) {} // 0x0000000186C70010-0x0000000186C700C0
		protected override void RemoveItem(int index) {} // 0x0000000186C700C0-0x0000000186C70190
		private void RemoveKey(string key) {} // 0x0000000186C70190-0x0000000186C70210
		protected override void SetItem(int index, JToken item) {} // 0x0000000186C70210-0x0000000186C70390
		public bool TryGetValue(string key, out JToken value) {
			value = default;
			return default;
		} // 0x0000000186C70390-0x0000000186C70430
		public int IndexOfReference(JToken t) => default; // 0x0000000186C6FF30-0x0000000186C70010
		public bool Compare(JPropertyKeyedCollection other) => default; // 0x0000000186C6F900-0x0000000186C6FC50
	}
}
