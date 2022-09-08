/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public abstract class JContainer : JToken, IList<JToken>, ITypedList, IBindingList // TypeDefIndex: 5435
	{
		// Fields
		internal ListChangedEventHandler _listChanged; // 0x30
		internal AddingNewEventHandler _addingNew; // 0x38
		private object _syncRoot; // 0x40
		private bool _busy; // 0x48
	
		// Properties
		protected abstract IList<JToken> ChildrenTokens { get; }
		public override bool HasValues { get; } // 0x0000000186C6D050-0x0000000186C6D0E0 
		public override JToken First { get; } // 0x0000000186C6CFA0-0x0000000186C6D050 
		public override JToken Last { get; } // 0x0000000186C6D0E0-0x0000000186C6D190 
		JToken IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get => default; set {} } // 0x0000000186C6C2B0-0x0000000186C6C330 0x0000000186C6C330-0x0000000186C6C3C0
		bool ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; } // 0x0000000186C6C0D0-0x0000000186C6C120 
		bool IList.IsFixedSize { get; } // 0x0000000186C6C920-0x0000000186C6C970 
		bool IList.IsReadOnly { get; } // 0x0000000186C6C970-0x0000000186C6C9C0 
		object IList.this[int index] { get => default; set {} } // 0x0000000186C6C9C0-0x0000000186C6CA40 0x0000000186C6CA40-0x0000000186C6CAE0
		public int Count { get; } // 0x0000000186C6CF10-0x0000000186C6CFA0 
		bool ICollection.IsSynchronized { get; } // 0x0000000186C6C450-0x0000000186C6C4A0 
		object ICollection.SyncRoot { get; } // 0x0000000186C6C4A0-0x0000000186C6C540 
	
		// Constructors
		internal JContainer() {} // 0x0000000186C6CE50-0x0000000186C6CF10
		internal JContainer(JContainer other) {} // 0x0000000186C6CC20-0x0000000186C6CE50
	
		// Methods
		internal void CheckReentrancy() {} // 0x0000000186C695C0-0x0000000186C696B0
		protected virtual void OnListChanged(ListChangedEventArgs e) {} // 0x0000000186C6AAD0-0x0000000186C6ABA0
		internal bool ContentsEqual(JContainer container) => default; // 0x0000000186C69B80-0x0000000186C69CF0
		public override JEnumerable<JToken> Children() => default; // 0x0000000186C696B0-0x0000000186C69740
		public IEnumerable<JToken> Descendants() => default; // 0x0000000186C6A260-0x0000000186C6A2D0
		internal IEnumerable<JToken> GetDescendants(bool self) => default; // 0x0000000186C6A4D0-0x0000000186C6A580
		internal bool IsMultiContent(object content) => default; // 0x0000000186C6A8F0-0x0000000186C6A9D0
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck) => default; // 0x0000000186C6A2D0-0x0000000186C6A3E0
		internal abstract int IndexOfItem(JToken item);
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) {} // 0x0000000186C6A620-0x0000000186C6A8F0
		internal virtual void RemoveItemAt(int index) {} // 0x0000000186C6B6D0-0x0000000186C6B9C0
		internal virtual bool RemoveItem(JToken item) => default; // 0x0000000186C6B9C0-0x0000000186C6BA60
		internal virtual JToken GetItem(int index) => default; // 0x0000000186C6A580-0x0000000186C6A620
		internal virtual void SetItem(int index, JToken item) {} // 0x0000000186C6BB50-0x0000000186C6BE50
		internal virtual void ClearItems() {} // 0x0000000186C69740-0x0000000186C69AF0
		internal virtual void ReplaceItem(JToken existing, JToken replacement) {} // 0x0000000186C6BA60-0x0000000186C6BB50
		internal virtual bool ContainsItem(JToken item) => default; // 0x0000000186C69AF0-0x0000000186C69B80
		internal virtual void CopyItemsTo(Array array, int arrayIndex) {} // 0x0000000186C69F20-0x0000000186C6A190
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) => default; // 0x0000000186C6A9D0-0x0000000186C6AAD0
		internal virtual void ValidateToken(JToken o, JToken existing) {} // 0x0000000186C6CAE0-0x0000000186C6CC20
		public virtual void Add(object content) {} // 0x0000000186C69510-0x0000000186C695C0
		internal void AddAndSkipParentCheck(JToken token) {} // 0x0000000186C69160-0x0000000186C69210
		public void AddFirst(object content) {} // 0x0000000186C69210-0x0000000186C69290
		internal void AddInternal(int index, object content, bool skipParentCheck) {} // 0x0000000186C69290-0x0000000186C69510
		internal static JToken CreateFromContent(object content) => default; // 0x0000000186C6A190-0x0000000186C6A260
		public void RemoveAll() {} // 0x0000000186C6B660-0x0000000186C6B6D0
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) {} // 0x0000000186C6B450-0x0000000186C6B660
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) {} // 0x0000000186C6ABA0-0x0000000186C6B450
		internal int ContentsHashCode() => default; // 0x0000000186C69CF0-0x0000000186C69F20
		int IList<JToken>.IndexOf(JToken item) => default; // 0x0000000186C6C120-0x0000000186C6C1A0
		void IList<JToken>.Insert(int index, JToken item) {} // 0x0000000186C6C1A0-0x0000000186C6C230
		void IList<JToken>.RemoveAt(int index) {} // 0x0000000186C6C230-0x0000000186C6C2B0
		void ICollection<JToken>.Add(JToken item) {} // 0x0000000186C6BE50-0x0000000186C6BED0
		void ICollection<JToken>.Clear() {} // 0x0000000186C6BED0-0x0000000186C6BF40
		bool ICollection<JToken>.Contains(JToken item) => default; // 0x0000000186C6BF40-0x0000000186C6BFC0
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex) {} // 0x0000000186C6BFC0-0x0000000186C6C050
		bool ICollection<JToken>.Remove(JToken item) => default; // 0x0000000186C6C050-0x0000000186C6C0D0
		private JToken EnsureValue(object value) => default; // 0x0000000186C6A3E0-0x0000000186C6A4D0
		int IList.Add(object value) => default; // 0x0000000186C6C540-0x0000000186C6C5E0
		void IList.Clear() {} // 0x0000000186C6C5E0-0x0000000186C6C650
		bool IList.Contains(object value) => default; // 0x0000000186C6C650-0x0000000186C6C6E0
		int IList.IndexOf(object value) => default; // 0x0000000186C6C6E0-0x0000000186C6C770
		void IList.Insert(int index, object value) {} // 0x0000000186C6C770-0x0000000186C6C810
		void IList.Remove(object value) {} // 0x0000000186C6C890-0x0000000186C6C920
		void IList.RemoveAt(int index) {} // 0x0000000186C6C810-0x0000000186C6C890
		void ICollection.CopyTo(Array array, int index) {} // 0x0000000186C6C3C0-0x0000000186C6C450
	}
}
