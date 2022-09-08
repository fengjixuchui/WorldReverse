/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class BaseContextComponent // TypeDefIndex: 30317
	{
		// Fields
		protected BaseContext _parent; // 0x10
		private List<NotifyTypes> _registerNotifyList; // 0x18
		private List<int> _registerPacketList; // 0x20
		private List<InputEventType> _registerActionList; // 0x28
	
		// Constructors
		public BaseContextComponent() {} // 0x0000000181ACB7E0-0x0000000181ACB850
	
		// Methods
		// [XID] // 0x00000001897946F0-0x0000000189794710
		public void InitComponent(BaseContext context, GameObject view) {} // 0x0000000181ACAC90-0x0000000181ACAD70
		// [XID] // 0x000000018979CB80-0x000000018979CBA0
		public void DestroyComponent() {} // 0x0000000181ACA8E0-0x0000000181ACAB30
		// [XID] // 0x00000001897A3FE0-0x00000001897A4000
		protected void RegisterNotfiy(NotifyTypes type) {} // 0x0000000181ACB220-0x0000000181ACB360
		// [XID] // 0x000000018977F7E0-0x000000018977F800
		protected void UnregisterNotfiy(NotifyTypes type) {} // 0x0000000181ACB580-0x0000000181ACB660
		// [XID] // 0x00000001897B3330-0x00000001897B3350
		protected void RegisterPacket(int cmdid) {} // 0x0000000181ACB360-0x0000000181ACB4A0
		// [XID] // 0x00000001897BB250-0x00000001897BB270
		protected void UnregisterPacket(int cmdid) {} // 0x0000000181ACB660-0x0000000181ACB740
		// [XID] // 0x00000001897C2A30-0x00000001897C2A50
		protected void RegisterActionEvent(InputEventType evt) {} // 0x0000000181ACB0E0-0x0000000181ACB220
		// [XID] // 0x00000001897D2E90-0x00000001897D2EB0
		protected void UnregisterActionEvent(InputEventType evt) {} // 0x0000000181ACB4A0-0x0000000181ACB580
		// [XID] // 0x00000001897D18F0-0x00000001897D1910
		public virtual void Init(GameObject view) {} // 0x0000000181ACAD70-0x0000000181ACAE20
		// [XID] // 0x000000018969FA10-0x000000018969FA30
		public virtual void OnEnable() {} // 0x0000000181ACAEC0-0x0000000181ACAF60
		// [XID] // 0x00000001897E0AB0-0x00000001897E0AD0
		public virtual void OnDisable() {} // 0x0000000181ACAE20-0x0000000181ACAEC0
		// [XID] // 0x0000000189985390-0x00000001899853B0
		public virtual void BindViewCallbacks() {} // 0x0000000181ACA840-0x0000000181ACA8E0
		// [XID] // 0x00000001897EFE10-0x00000001897EFE30
		public virtual void UpdateView() {} // 0x0000000181ACB740-0x0000000181ACB7E0
		// [XID] // 0x00000001897F7600-0x00000001897F7620
		public virtual bool OnNotify(Notify ntf) => default; // 0x0000000181ACAF60-0x0000000181ACB030
		// [XID] // 0x00000001896CB5C0-0x00000001896CB5E0
		public virtual bool OnPacket(Packet packet) => default; // 0x0000000181ACB030-0x0000000181ACB0E0
		// [XID] // 0x0000000189806450-0x0000000189806470
		public virtual void Destroy() {} // 0x0000000181ACAB30-0x0000000181ACABD0
		// [XID] // 0x000000018980DB30-0x000000018980DB50
		public virtual bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181ACABD0-0x0000000181ACAC90
	}
}
