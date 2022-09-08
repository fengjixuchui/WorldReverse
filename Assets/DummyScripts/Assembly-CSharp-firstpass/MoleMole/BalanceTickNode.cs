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
	public class BalanceTickNode : IBalanceTickJobCollection // TypeDefIndex: 10474
	{
		// Fields
		public int interval; // 0x10
		private BalanceTickBucket[] _tickBuckets; // 0x18
		private BucketCache _bucketCache; // 0x20
	
		// Properties
		private bool bNeedBalanceBucket { /* [XID] */ /* 0x0000000189B12AF0-0x0000000189B12B10 */ get => default; } // 0x00000001868EF080-0x00000001868EF130 
	
		// Nested types
		private struct BucketCache // TypeDefIndex: 10475
		{
			// Fields
			public int minCount; // 0x00
			public int maxCount; // 0x04
			public int minIdx; // 0x08
			public int maxIdx; // 0x0C
		}
	
		// Constructors
		public BalanceTickNode() {} // Dummy constructor
		public BalanceTickNode(int inIntveral) {} // 0x00000001868EEF50-0x00000001868EF080
	
		// Methods
		// [XID] // 0x0000000189A565E0-0x0000000189A56600
		private void CacheBucketInfo() {} // 0x00000001868EE6A0-0x00000001868EE8E0
		// [XID] // 0x0000000189A5E1F0-0x0000000189A5E210
		private void BalanceTickBuckets(double inGlobalTime) {} // 0x00000001868EE520-0x00000001868EE6A0
		// [XID] // 0x00000001896BCA20-0x00000001896BCA40
		public void AddTickableObject(BalanceTickObjectProxy inProxy, double inGlobalTime) {} // 0x00000001868EE400-0x00000001868EE520
		// [XID] // 0x0000000189A9A6A0-0x0000000189A9A6C0
		public void RemoveTickableObject(BalanceTickObjectProxy inProxy, double inGlobalTime) {} // 0x00000001868EEB60-0x00000001868EED10
		// [XID] // 0x00000001896CB3D0-0x00000001896CB3F0
		public void IteratorTickObjects(Action<BalanceTickObjectProxy> onIterTickObject) {} // 0x00000001868EE8E0-0x00000001868EEA00
		// [XID] // 0x0000000189BC18E0-0x0000000189BC1900
		public void RefreshRequestTickInterval(float inGlobalTime, float deltaTime, Action<BalanceTickObjectProxy, int> onRequestIntervalChange) {} // 0x00000001868EEA00-0x00000001868EEB60
		// [XID] // 0x0000000189AB8000-0x0000000189AB8020
		public void UpdateProxyState(double inGlobalTime) {} // 0x00000001868EED10-0x00000001868EEE30
		// [XID] // 0x0000000189AC76B0-0x0000000189AC76D0
		public void Validate(Action<BalanceTickObjectProxy> onValidate) {} // 0x00000001868EEE30-0x00000001868EEF50
	}
}
