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
	public class BalanceTickBucket : IBalanceTickJobCollection // TypeDefIndex: 10473
	{
		// Fields
		private int _index; // 0x10
		private HashList<BalanceTickObjectProxy> _tickObjects; // 0x18
	
		// Properties
		public int Count { /* [XID] */ /* 0x000000018966A930-0x000000018966A950 */ get => default; } // 0x00000001868ED230-0x00000001868ED2F0 
	
		// Constructors
		public BalanceTickBucket() {} // Dummy constructor
		public BalanceTickBucket(int inIndex) {} // 0x00000001868ED150-0x00000001868ED230
	
		// Methods
		// [XID] // 0x0000000189A8C430-0x0000000189A8C450
		public void AddTickableObject(BalanceTickObjectProxy inObject, double inGlobalTime) {} // 0x00000001868EC780-0x00000001868EC890
		// [XID] // 0x0000000189A9B4C0-0x0000000189A9B4E0
		public void RemoveTickableObject(BalanceTickObjectProxy inObject, double inGlobalTime) {} // 0x00000001868ECBD0-0x00000001868ECE00
		// [XID] // 0x0000000189A8B5F0-0x0000000189A8B610
		public void IteratorTickObjects(Action<BalanceTickObjectProxy> onIterTickObject) {} // 0x00000001868EC890-0x00000001868EC9F0
		// [XID] // 0x0000000189688FE0-0x0000000189689000
		public void RefreshRequestTickInterval(float inGlobalTime, float deltaTime, Action<BalanceTickObjectProxy, int> onRequestIntervalChange) {} // 0x00000001868EC9F0-0x00000001868ECAC0
		// [XID] // 0x0000000189A92BE0-0x0000000189A92C00
		public void UpdateProxyState(double inGlobalTime) {} // 0x00000001868ECE00-0x00000001868ECFF0
		// [XID] // 0x0000000189698420-0x0000000189698440
		public BalanceTickObjectProxy RemoveTail() => default; // 0x00000001868ECAC0-0x00000001868ECBD0
		// [XID] // 0x000000018969F780-0x000000018969F7A0
		public void Validate(Action<BalanceTickObjectProxy> onValidate) {} // 0x00000001868ECFF0-0x00000001868ED150
	}
}
