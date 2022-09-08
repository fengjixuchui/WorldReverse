/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigLCGadgetInteeData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18452
	{
		// Fields
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		private Dictionary<string, ConfigLCGadgetIntee> _configDic; // 0x10
	
		// Properties
		public Dictionary<string, ConfigLCGadgetIntee> configDic { /* [XID] */ /* 0x00000001899BC890-0x00000001899BC8B0 */ get => default; /* [XID] */ /* 0x00000001899C42E0-0x00000001899C4300 */ private set {} } // 0x0000000188831DA0-0x0000000188831E40 0x0000000188831E40-0x0000000188831EF0
	
		// Constructors
		public ConfigLCGadgetInteeData() {} // 0x0000000188831D40-0x0000000188831DA0
	
		// Methods
		// [XID] // 0x00000001899CBA40-0x00000001899CBA60
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001888317B0-0x0000000188831890
		// [XID] // 0x00000001899D2F30-0x00000001899D2F50
		public void InitEmpty() {} // 0x0000000188831100-0x00000001888311D0
		[BlackList] // 0x00000001899DA520-0x00000001899DA560
		// [XID] // 0x00000001899DA520-0x00000001899DA560
		public bool FromJson(JSONNode node) => default; // 0x0000000188830D80-0x0000000188831100
		// [XID] // 0x00000001899E50E0-0x00000001899E5100
		private bool InternalFromJson(JSONNode node) => default; // 0x00000001888313E0-0x00000001888315C0
		// [XID] // 0x00000001899EC430-0x00000001899EC450
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98F3 */, bool useObjectPool = false /* Metadata: 0x00AF98F7 */) => default; // 0x0000000188830A80-0x0000000188830D80
		// [XID] // 0x00000001899F4090-0x00000001899F40B0
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98F8 */, bool useObjectPool = false /* Metadata: 0x00AF98FC */) => default; // 0x00000001888311D0-0x00000001888313E0
		[BlackList] // 0x00000001899FB710-0x00000001899FB750
		// [XID] // 0x00000001899FB710-0x00000001899FB750
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188831A70-0x0000000188831D40
		// [XID] // 0x0000000189A05D10-0x0000000189A05D30
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001888315C0-0x00000001888317B0
		[BlackList] // 0x0000000189A0D020-0x0000000189A0D060
		// [XID] // 0x0000000189A0D020-0x0000000189A0D060
		public virtual void AutoAllocTypeFields() {} // 0x0000000188830920-0x00000001888309C0
		[BlackList] // 0x0000000189A173B0-0x0000000189A173F0
		// [XID] // 0x0000000189A173B0-0x0000000189A173F0
		public virtual void AutoRecycleTypeFields() {} // 0x00000001888309C0-0x0000000188830A80
		[BlackList] // 0x0000000189A21A30-0x0000000189A21A70
		// [XID] // 0x0000000189A21A30-0x0000000189A21A70
		public virtual void ReturnToObjectPool() {} // 0x00000001888319D0-0x0000000188831A70
		[BlackList] // 0x0000000189A2BE70-0x0000000189A2BEB0
		// [XID] // 0x0000000189A2BE70-0x0000000189A2BEB0
		public virtual void OnPoolAllocated() {} // 0x0000000188831930-0x00000001888319D0
		[BlackList] // 0x0000000189A368F0-0x0000000189A36930
		// [XID] // 0x0000000189A368F0-0x0000000189A36930
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188831890-0x0000000188831930
	}
}
