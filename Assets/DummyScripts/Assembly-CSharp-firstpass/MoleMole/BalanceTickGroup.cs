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

namespace MoleMole
{
	public class BalanceTickGroup // TypeDefIndex: 10476
	{
		// Fields
		private BalanceTickBucket _noTickNode; // 0x10
		private BalanceTickBucket _everyFrameTickNode; // 0x18
		private BalanceTickNode[] _balanceTickNodes; // 0x20
		private List<ProxySwitchIntervalContext> _proxySwtichIntervalRequest; // 0x28
		private Action<BalanceTickObjectProxy, int> _onProxySwitchInterval; // 0x30
		private List<BalanceTickObjectProxy> _collectedTokenProxies; // 0x38
	
		// Nested types
		private struct ProxySwitchIntervalContext // TypeDefIndex: 10477
		{
			// Fields
			public BalanceTickObjectProxy proxy; // 0x00
			public int targetInterval; // 0x08
	
			// Constructors
			public ProxySwitchIntervalContext(BalanceTickObjectProxy inProxy, int inTagetInterval) {
				proxy = default;
				targetInterval = default;
			} // 0x00000001869049D0-0x0000000186904A60
		}
	
		// Constructors
		public BalanceTickGroup() {} // 0x00000001868EE220-0x00000001868EE400
	
		// Methods
		// [XID] // 0x00000001896E90F0-0x00000001896E9110
		private void AddNodeChangeRequest(BalanceTickObjectProxy proxy, int targetInterval) {} // 0x00000001868ED2F0-0x00000001868ED430
		// [XID] // 0x0000000189ABFA60-0x0000000189ABFA80
		protected void OnProxyTickLODChange(BalanceTickObjectProxy inProxy, int currentTickInterval, int requestTickInterval, double inGlobalTime) {} // 0x00000001868EDA80-0x00000001868EDD20
		// [XID] // 0x00000001896F7AD0-0x00000001896F7AF0
		private void ConditionalAdjustBalancedTickNode(BalanceTickObjectProxy inProxy, int requestTickInterval, float inGlobalTime) {} // 0x00000001868ED640-0x00000001868ED7B0
		// [XID] // 0x00000001896FF610-0x00000001896FF630
		private void CollectTokenPriority(BalanceTickObjectProxy inProxy) {} // 0x00000001868ED510-0x00000001868ED640
		// [XID] // 0x0000000189B03BF0-0x0000000189B03C10
		private void CalcTickTokenByTotalToken(float inTotalToken, float inGlobalTime, float deltaTime) {} // 0x00000001868ED430-0x00000001868ED510
		// [XID] // 0x000000018970E290-0x000000018970E2B0
		private void LegacyCalcTickInterval(float inGlobalTime, float deltaTime) {} // 0x00000001868ED850-0x00000001868ED9D0
		// [XID] // 0x0000000189BAE400-0x0000000189BAE420
		public void UpdateProxyState(double inGlobalTime) {} // 0x00000001868EDFA0-0x00000001868EE0E0
		// [XID] // 0x0000000189BB5CF0-0x0000000189BB5D10
		public virtual void UpdateComputeThread(float inGlobalTime, float deltaTime) {} // 0x00000001868EDDC0-0x00000001868EDFA0
		// [XID] // 0x0000000189724650-0x0000000189724670
		public void Flush() {} // 0x00000001868ED7B0-0x00000001868ED850
		// [XID] // 0x000000018972BE00-0x000000018972BE20
		protected virtual void OnPreAddProxy(BalanceTickObjectProxy inProxy) {} // 0x00000001868ED9D0-0x00000001868EDA80
		// [XID] // 0x0000000189733470-0x0000000189733490
		private void ProcessAddRemoveRequestJobThread() {} // 0x00000001868EDD20-0x00000001868EDDC0
		// [XID] // 0x000000018973ACB0-0x000000018973ACD0
		public void Validate(Action<BalanceTickObjectProxy> onValidate) {} // 0x00000001868EE0E0-0x00000001868EE220
	}
}
