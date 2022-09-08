/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class WRRHandle : IDisposable, IWRRHandle // TypeDefIndex: 10617
	{
		// Fields
		private WeightedRoundRobin _wrr; // 0x18
	
		// Properties
		public int _targetWeight { /* [XID] */ /* 0x00000001898DB610-0x00000001898DB650 */ get; private set; } // 0x000000018609BAD0-0x000000018609BB30 0x000000018609BBF0-0x000000018609BC50
		public int _currentWeight { /* [XID] */ /* 0x00000001898EDDB0-0x00000001898EDDF0 */ get; /* [XID] */ /* 0x00000001898F8800-0x00000001898F8840 */ private set; } // 0x000000018609BA70-0x000000018609BAD0 0x000000018609BB90-0x000000018609BBF0
		public bool isSelected { /* [XID] */ /* 0x0000000189902F20-0x0000000189902F60 */ get; /* [XID] */ /* 0x000000018990D880-0x000000018990D8C0 */ private set; } // 0x000000018609BB30-0x000000018609BB90 0x000000018609BC50-0x000000018609BCB0
	
		// Constructors
		public WRRHandle() {} // Dummy constructor
		public WRRHandle(WeightedRoundRobin inWRR, int weight) {} // 0x000000018609B9B0-0x000000018609BA70
	
		// Methods
		// [XID] // 0x0000000189918040-0x0000000189918060
		public void UnSelect() {} // 0x000000018609B8E0-0x000000018609B9B0
		// [XID] // 0x000000018991F730-0x000000018991F750
		public bool OnNext() => default; // 0x000000018609B550-0x000000018609B7D0
		// [XID] // 0x00000001895F1600-0x00000001895F1620
		public void Reset() {} // 0x000000018609B7D0-0x000000018609B8E0
		// [XID] // 0x000000018992E930-0x000000018992E950
		public void Dispose() {} // 0x000000018609B480-0x000000018609B550
	}
}
