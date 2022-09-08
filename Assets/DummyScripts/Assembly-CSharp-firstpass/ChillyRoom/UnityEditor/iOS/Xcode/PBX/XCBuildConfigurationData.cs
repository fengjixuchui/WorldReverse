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

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class XCBuildConfigurationData : PBXObjectData // TypeDefIndex: 10388
	{
		// Fields
		protected SortedDictionary<string, BuildConfigEntryData> entries; // 0x20
		public string baseConfigurationReference; // 0x28
	
		// Properties
		public string name { /* [XID] */ /* 0x000000018997AC80-0x000000018997ACA0 */ get => default; } // 0x0000000186D45BB0-0x0000000186D45C60 
	
		// Constructors
		public XCBuildConfigurationData() {} // 0x0000000186D45B00-0x0000000186D45BB0
	
		// Methods
		// [XID] // 0x000000018992FD50-0x000000018992FD70
		private static string EscapeWithQuotesIfNeeded(string name, string value) => default; // 0x0000000186D44AC0-0x0000000186D44C70
		// [XID] // 0x0000000189937250-0x0000000189937270
		public void SetProperty(string name, string value) {} // 0x0000000186D44FB0-0x0000000186D450B0
		// [XID] // 0x0000000189A2B220-0x0000000189A2B240
		public void AddProperty(string name, string value) {} // 0x0000000186D44840-0x0000000186D44990
		// [XID] // 0x0000000189955140-0x0000000189955160
		public void RemoveProperty(string name) {} // 0x0000000186D44EC0-0x0000000186D44FB0
		// [XID] // 0x0000000189989D90-0x0000000189989DB0
		public void RemovePropertyValue(string name, string value) {} // 0x0000000186D44D90-0x0000000186D44EC0
		// [XID] // 0x00000001899991A0-0x00000001899991C0
		public void RemovePropertyValueList(string name, IEnumerable<string> valueList) {} // 0x0000000186D44C70-0x0000000186D44D90
		// [XID] // 0x0000000189A490D0-0x0000000189A490F0
		public static XCBuildConfigurationData Create(string name) => default; // 0x0000000186D44990-0x0000000186D44AC0
		// [XID] // 0x0000000189A6D0D0-0x0000000189A6D0F0
		public override void UpdateProps() {} // 0x0000000186D45170-0x0000000186D45590
		// [XID] // 0x0000000189A57E80-0x0000000189A57EA0
		public override void UpdateVars() {} // 0x0000000186D45590-0x0000000186D45B00
	}
}
