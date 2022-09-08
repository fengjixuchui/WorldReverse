/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	[Serializable]
	// [ComVisible] // 0x000000018995B450-0x000000018995B4A0
	public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 10282
	{
		// Fields
		private static readonly Dictionary<string, HttpHeaderInfo> _headers; // 0x00
		private bool _internallyUsed; // 0x68
		private HttpHeaderType _state; // 0x6C
	
		// Properties
		internal HttpHeaderType State { /* [XID] */ /* 0x0000000189B9FC00-0x0000000189B9FC20 */ get => default; } // 0x000000018718DC10-0x000000018718DCB0 
		public override string[] AllKeys { /* [XID] */ /* 0x00000001896BDE20-0x00000001896BDE40 */ get => default; } // 0x000000018718D780-0x000000018718D830 
		public override int Count { /* [XID] */ /* 0x0000000189BAE520-0x0000000189BAE540 */ get => default; } // 0x000000018718D830-0x000000018718D8E0 
		public string this[HttpRequestHeader header] { /* [IDTag] */ /* 0x0000000189BB5DD0-0x0000000189BB5E10 */ /* [XID] */ /* 0x0000000189BB5DD0-0x0000000189BB5E10 */ get => default; /* [XID] */ /* 0x0000000189BC0400-0x0000000189BC0440 */ /* [IDTag] */ /* 0x0000000189BC0400-0x0000000189BC0440 */ set {} } // 0x000000018718DA20-0x000000018718DB60 0x000000018718E180-0x000000018718E250
		public string this[HttpResponseHeader header] { /* [XID] */ /* 0x0000000189BCB400-0x0000000189BCB440 */ /* [IDTag] */ /* 0x0000000189BCB400-0x0000000189BCB440 */ get => default; /* [XID] */ /* 0x0000000189BD5670-0x0000000189BD56B0 */ /* [IDTag] */ /* 0x0000000189BD5670-0x0000000189BD56B0 */ set {} } // 0x000000018718D8E0-0x000000018718DA20 0x000000018718E0B0-0x000000018718E180
		public override KeysCollection Keys { /* [XID] */ /* 0x00000001896F9040-0x00000001896F9060 */ get => default; } // 0x000000018718DB60-0x000000018718DC10 
	
		// Constructors
		static WebHeaderCollection() {} // 0x000000018718B330-0x000000018718C290
		internal WebHeaderCollection(HttpHeaderType state, bool internallyUsed) {} // 0x000000018718C470-0x000000018718C4F0
		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x000000018718C290-0x000000018718C470
		public WebHeaderCollection() {} // 0x000000018718C4F0-0x000000018718C550
	
		// Methods
		// [XID] // 0x000000018998D820-0x000000018998D840
		private void add(string name, string value, bool ignoreRestricted) {} // 0x000000018718C770-0x000000018718C8D0
		// [XID] // 0x00000001895F44B0-0x00000001895F44D0
		private void addWithoutCheckingName(string name, string value) {} // 0x000000018718C650-0x000000018718C770
		// [XID] // 0x00000001895FBC00-0x00000001895FBC20
		private void addWithoutCheckingNameAndRestricted(string name, string value) {} // 0x000000018718C550-0x000000018718C650
		// [XID] // 0x00000001897707B0-0x00000001897707D0
		private static HttpHeaderType checkHeaderType(string name) => default; // 0x000000018718C8D0-0x000000018718C9F0
		// [XID] // 0x000000018960AE00-0x000000018960AE20
		private static string checkName(string name) => default; // 0x000000018718C9F0-0x000000018718CC00
		// [XID] // 0x0000000189612310-0x0000000189612330
		private void checkRestricted(string name) {} // 0x000000018718CC00-0x000000018718CD20
		// [XID] // 0x0000000189619C50-0x0000000189619C70
		private void checkState(bool response) {} // 0x000000018718CD20-0x000000018718CE50
		// [XID] // 0x00000001898F25E0-0x00000001898F2600
		private static string checkValue(string value) => default; // 0x000000018718CE50-0x000000018718D020
		// [IDTag] // 0x00000001896288E0-0x0000000189628920
		// [XID] // 0x00000001896288E0-0x0000000189628920
		private void doWithCheckingState(Action<string, string> action, string name, string value, bool setState) {} // 0x000000018718D170-0x000000018718D2F0
		// [IDTag] // 0x0000000189633190-0x00000001896331D0
		// [XID] // 0x0000000189633190-0x00000001896331D0
		private void doWithCheckingState(Action<string, string> action, string name, string value, bool response, bool setState) {} // 0x000000018718D020-0x000000018718D170
		// [XID] // 0x0000000189B91BE0-0x0000000189B91C00
		private void doWithoutCheckingName(Action<string, string> action, string name, string value) {} // 0x000000018718D2F0-0x000000018718D420
		// [XID] // 0x00000001897EADC0-0x00000001897EADE0
		private static HttpHeaderInfo getHeaderInfo(string name) => default; // 0x000000018718D420-0x000000018718D660
		// [XID] // 0x000000018964CD00-0x000000018964CD20
		private static string getHeaderName(string key) => default; // 0x000000018718D660-0x000000018718D780
		// [XID] // 0x0000000189901760-0x0000000189901780
		private static bool isMultiValue(string name, bool response) => default; // 0x000000018718DCB0-0x000000018718DDB0
		// [XID] // 0x000000018965BAD0-0x000000018965BAF0
		private static bool isRestricted(string name, bool response) => default; // 0x000000018718DDB0-0x000000018718DEB0
		// [XID] // 0x0000000189700A50-0x0000000189700A70
		private void removeWithoutCheckingName(string name, string unuse) {} // 0x000000018718DEB0-0x000000018718DF90
		// [XID] // 0x0000000189716D30-0x0000000189716D50
		private void setWithoutCheckingName(string name, string value) {} // 0x000000018718DF90-0x000000018718E0B0
		// [XID] // 0x00000001896725F0-0x0000000189672610
		internal void InternalRemove(string name) {} // 0x0000000187189590-0x0000000187189640
		// [IDTag] // 0x0000000189679E80-0x0000000189679EC0
		// [XID] // 0x0000000189679E80-0x0000000189679EC0
		internal void InternalSet(string header, bool response) {} // 0x0000000187189640-0x00000001871897C0
		// [IDTag] // 0x00000001896843A0-0x00000001896843E0
		// [XID] // 0x00000001896843A0-0x00000001896843E0
		internal void InternalSet(string name, string value, bool response) {} // 0x00000001871897C0-0x00000001871898F0
		// [XID] // 0x000000018968F260-0x000000018968F280
		internal string ToStringMultiValue(bool response) => default; // 0x000000018718A770-0x000000018718A9D0
		// [XID] // 0x0000000189696C10-0x0000000189696C30
		protected void AddWithoutValidate(string headerName, string headerValue) {} // 0x0000000187188750-0x0000000187188830
		// [IDTag] // 0x000000018969E260-0x000000018969E2A0
		// [XID] // 0x000000018969E260-0x000000018969E2A0
		public void Add(string header) {} // 0x0000000187188B70-0x0000000187188D50
		// [IDTag] // 0x00000001896A82F0-0x00000001896A8330
		// [XID] // 0x00000001896A82F0-0x00000001896A8330
		public void Add(HttpRequestHeader header, string value) {} // 0x00000001871889D0-0x0000000187188B70
		// [IDTag] // 0x00000001896B2300-0x00000001896B2340
		// [XID] // 0x00000001896B2300-0x00000001896B2340
		public void Add(HttpResponseHeader header, string value) {} // 0x0000000187188830-0x00000001871889D0
		// [IDTag] // 0x00000001896BCA80-0x00000001896BCAC0
		// [XID] // 0x00000001896BCA80-0x00000001896BCAC0
		public override void Add(string name, string value) {} // 0x0000000187188D50-0x0000000187188E30
		// [XID] // 0x0000000189777F30-0x0000000189777F50
		public override void Clear() {} // 0x0000000187188E30-0x0000000187188EE0
		// [IDTag] // 0x00000001896CE760-0x00000001896CE7A0
		// [XID] // 0x00000001896CE760-0x00000001896CE7A0
		public override string Get(int index) => default; // 0x00000001871894D0-0x0000000187189590
		// [IDTag] // 0x00000001896D8B90-0x00000001896D8BD0
		// [XID] // 0x00000001896D8B90-0x00000001896D8BD0
		public override string Get(string name) => default; // 0x0000000187189410-0x00000001871894D0
		// [XID] // 0x00000001896E3200-0x00000001896E3220
		public override IEnumerator GetEnumerator() => default; // 0x0000000187188EE0-0x0000000187188F90
		// [XID] // 0x00000001897ACA80-0x00000001897ACAA0
		public override string GetKey(int index) => default; // 0x0000000187188F90-0x0000000187189050
		// [IDTag] // 0x00000001896F1730-0x00000001896F1770
		// [XID] // 0x00000001896F1730-0x00000001896F1770
		public override string[] GetValues(int index) => default; // 0x0000000187189340-0x0000000187189410
		// [IDTag] // 0x00000001896FC570-0x00000001896FC5B0
		// [XID] // 0x00000001896FC570-0x00000001896FC5B0
		public override string[] GetValues(string header) => default; // 0x0000000187189270-0x0000000187189340
		// [XID] // 0x0000000189706960-0x0000000189706980
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000187189050-0x0000000187189270
		// [IDTag] // 0x000000018970E2B0-0x000000018970E2F0
		// [XID] // 0x000000018970E2B0-0x000000018970E2F0
		public static bool IsRestricted(string headerName) => default; // 0x0000000187189B30-0x0000000187189C00
		// [IDTag] // 0x00000001897189C0-0x0000000189718A00
		// [XID] // 0x00000001897189C0-0x0000000189718A00
		public static bool IsRestricted(string headerName, bool response) => default; // 0x00000001871898F0-0x0000000187189B30
		// [XID] // 0x0000000189B69760-0x0000000189B69780
		public override void OnDeserialization(object sender) {} // 0x0000000187189C00-0x0000000187189CB0
		// [IDTag] // 0x000000018972A5B0-0x000000018972A5F0
		// [XID] // 0x000000018972A5B0-0x000000018972A5F0
		public void Remove(HttpRequestHeader header) {} // 0x0000000187189F60-0x000000018718A0E0
		// [IDTag] // 0x0000000189734D10-0x0000000189734D50
		// [XID] // 0x0000000189734D10-0x0000000189734D50
		public void Remove(HttpResponseHeader header) {} // 0x0000000187189CB0-0x0000000187189E30
		// [IDTag] // 0x000000018973FB40-0x000000018973FB80
		// [XID] // 0x000000018973FB40-0x000000018973FB80
		public override void Remove(string name) {} // 0x0000000187189E30-0x0000000187189F60
		// [IDTag] // 0x000000018974A0D0-0x000000018974A110
		// [XID] // 0x000000018974A0D0-0x000000018974A110
		public void Set(HttpRequestHeader header, string value) {} // 0x000000018718A280-0x000000018718A420
		// [IDTag] // 0x00000001897547B0-0x00000001897547F0
		// [XID] // 0x00000001897547B0-0x00000001897547F0
		public void Set(HttpResponseHeader header, string value) {} // 0x000000018718A0E0-0x000000018718A280
		// [IDTag] // 0x000000018975ED70-0x000000018975EDB0
		// [XID] // 0x000000018975ED70-0x000000018975EDB0
		public override void Set(string name, string value) {} // 0x000000018718A420-0x000000018718A570
		// [XID] // 0x00000001897F8A00-0x00000001897F8A20
		public byte[] ToByteArray() => default; // 0x000000018718A660-0x000000018718A770
		// [XID] // 0x00000001897708F0-0x0000000189770910
		public override string ToString() => default; // 0x000000018718A9D0-0x000000018718AB70
		// [XID] // 0x000000018980EE00-0x000000018980EE20
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x000000018718A570-0x000000018718A660
	}
}
