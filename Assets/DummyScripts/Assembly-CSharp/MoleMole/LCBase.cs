/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class LCBase : BaseComponent // TypeDefIndex: 20623
	{
		// Fields
		private Dictionary<int, BaseComponentPlugin> _onEventResolvedPluginMap; // 0x108
		private Dictionary<int, List<BaseComponentPlugin>> _onEventResolvedPluginsMap; // 0x110
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public List<int> onEventResolvedIDs; // 0x118
		private int[] _selfOnEventResolvedIDsCache; // 0x120
		private bool _isSelfOnEventResolvedIDsCached; // 0x128
	
		// Properties
		public override int categoryType { /* [XID] */ /* 0x00000001897C61B0-0x00000001897C61D0 */ get => default; } // 0x0000000183A2E930-0x0000000183A2E9D0 
	
		// Constructors
		public LCBase() {} // 0x0000000183A2E880-0x0000000183A2E930
	
		// Methods
		// [XID] // 0x00000001897CDA20-0x00000001897CDA40
		protected static EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000183A2C730-0x0000000183A2C7D0
		// [XID] // 0x0000000189773A00-0x0000000189773A20
		public int[] GetSelfOnEventResovledIDs() => default; // 0x0000000183A2C7D0-0x0000000183A2C8D0
		// [XID] // 0x00000001897DC730-0x00000001897DC750
		protected void InitComponentEventResolvedIDs() {} // 0x0000000183A2CB00-0x0000000183A2CC80
		// [XID] // 0x00000001897E4130-0x00000001897E4150
		private void TryToAddEventResolvedPlugin(BaseComponentPlugin plugin, HandleEventType handleEventType) {} // 0x0000000183A2D830-0x0000000183A2DF10
		// [XID] // 0x00000001897EBC60-0x00000001897EBC80
		private void TryToRemoveEventResolvedPlugin(BaseComponentPlugin plugin, HandleEventType handleEventType) {} // 0x0000000183A2DF10-0x0000000183A2E0C0
		// [XID] // 0x00000001897F35B0-0x00000001897F35D0
		private void TryToRemovePluginFromEventResolvedPluginsMap(int eventID, BaseComponentPlugin plugin, HandleEventType handleEventType) {} // 0x0000000183A2E0C0-0x0000000183A2E280
		// [XID] // 0x0000000189A402A0-0x0000000189A402C0
		public override void Destroy() {} // 0x0000000183A2C3B0-0x0000000183A2C490
		// [XID] // 0x0000000189988390-0x00000001899883B0
		protected virtual bool OnEventReconcile(BaseEvent e) => default; // 0x0000000183A2CDE0-0x0000000183A2CE90
		// [XID] // 0x0000000189809840-0x0000000189809860
		protected virtual bool OnRemoteEvtBeingHit(BaseEvent e) => default; // 0x0000000183A2D540-0x0000000183A2D5F0
		// [XID] // 0x0000000189810FF0-0x0000000189811010
		protected virtual bool OnEventResolved(BaseEvent e) => default; // 0x0000000183A2D330-0x0000000183A2D3E0
		// [XID] // 0x0000000189818B90-0x0000000189818BB0
		protected virtual bool OnRemoteEvtBeingHitResolved(BaseEvent e) => default; // 0x0000000183A2D490-0x0000000183A2D540
		// [XID] // 0x00000001898203B0-0x00000001898203D0
		protected override bool OnEvent(BaseEvent e) => default; // 0x0000000183A2D3E0-0x0000000183A2D490
		// [XID] // 0x0000000189827A30-0x0000000189827A50
		protected override bool ListenEvent(BaseEvent e) => default; // 0x0000000183A2CD30-0x0000000183A2CDE0
		// [XID] // 0x000000018982EC90-0x000000018982ECB0
		protected override void Tick(float inDeltaTime) {} // 0x0000000183A2D780-0x0000000183A2D830
		// [XID] // 0x00000001898365F0-0x0000000189836610
		protected override void LateTick(float inDeltaTime) {} // 0x0000000183A2CC80-0x0000000183A2CD30
		// [XID] // 0x0000000189BD4350-0x0000000189BD4370
		public bool OnEventResolvedAction(BaseEvent evt) => default; // 0x0000000183A2CE90-0x0000000183A2D330
		// [XID] // 0x0000000189845250-0x0000000189845270
		protected override void AddPluginActions(BaseComponentPlugin plugin) {} // 0x0000000183A2C080-0x0000000183A2C150
		// [XID] // 0x000000018984C740-0x000000018984C760
		protected override void ClearPluginList() {} // 0x0000000183A2C150-0x0000000183A2C3B0
		// [XID] // 0x00000001898537C0-0x00000001898537E0
		protected override ComponentHelper.ComponentMetaInfo GetMetaInfo() => default; // 0x0000000183A2C490-0x0000000183A2C730
		// [XID] // 0x000000018985B270-0x000000018985B290
		protected override void HandlePluginActions(BaseComponentPlugin plugin) {} // 0x0000000183A2C8D0-0x0000000183A2C9F0
		// [XID] // 0x00000001898627D0-0x00000001898627F0
		public override void HandleSelfComponentActions() {} // 0x0000000183A2C9F0-0x0000000183A2CB00
		// [XID] // 0x0000000189869BC0-0x0000000189869BE0
		public override void RestoreActions() {} // 0x0000000183A2D6C0-0x0000000183A2D780
		// [XID] // 0x0000000189870F60-0x0000000189870F80
		protected override void RemovePluginActions(BaseComponentPlugin plugin) {} // 0x0000000183A2D5F0-0x0000000183A2D6C0
	}
}
