/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBaseJoypadController : MonoBehaviour, IJoypadController // TypeDefIndex: 30702
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected int _contextStateID; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected uint[] _priorityLevel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected JoypadControllerAction[] actions; // 0x28
		protected BaseContext _curContext; // 0x30
	
		// Constructors
		public MonoBaseJoypadController() {} // 0x00000001848F7720-0x00000001848F77C0
	
		// Methods
		// [XID] // 0x000000018976AFD0-0x000000018976AFF0
		public virtual void OnDestroy() {} // 0x00000001848F7510-0x00000001848F75C0
		// [XID] // 0x00000001899B31F0-0x00000001899B3210
		public int GetContextStateID() => default; // 0x00000001848F7030-0x00000001848F70D0
		// [XID] // 0x0000000189779C70-0x0000000189779C90
		public virtual void SetBaseContext(BaseContext context) {} // 0x00000001848F7670-0x00000001848F7720
		// [XID] // 0x00000001897818B0-0x00000001897818D0
		public BaseContext GetBaseContext() => default; // 0x00000001848F6F90-0x00000001848F7030
		// [XID] // 0x0000000189B33160-0x0000000189B33180
		public virtual bool IsInvalid() => default; // 0x00000001848F7470-0x00000001848F7510
		// [XID] // 0x0000000189790380-0x00000001897903A0
		public virtual bool IsActive() => default; // 0x00000001848F73D0-0x00000001848F7470
		// [XID] // 0x0000000189797CF0-0x0000000189797D10
		public virtual void ResetByInputActionEvents(InputActionEvent[] actions) {} // 0x00000001848F75C0-0x00000001848F7670
		// [XID] // 0x000000018979F9D0-0x000000018979F9F0
		public virtual bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001848F7170-0x00000001848F7300
		// [XID] // 0x00000001897A6FD0-0x00000001897A6FF0
		public virtual bool HandleJoypadControllerAction(JoypadControllerActionType action, object param) => default; // 0x00000001848F7300-0x00000001848F73D0
		// [XID] // 0x00000001897AE910-0x00000001897AE930
		public virtual uint[] GetPriorityLevel() => default; // 0x00000001848F70D0-0x00000001848F7170
	}
}
