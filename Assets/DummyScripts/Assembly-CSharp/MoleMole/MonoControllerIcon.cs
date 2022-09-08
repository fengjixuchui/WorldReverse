/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoControllerIcon : MonoBaseJoypadController // TypeDefIndex: 30735
	{
		// Fields
		[SerializeField] // 0x0000000189B3F800-0x0000000189B3F860
		[Space] // 0x0000000189B3F800-0x0000000189B3F860
		// [Tooltip] // 0x0000000189B3F800-0x0000000189B3F860
		private Image _icon; // 0x38
		[SerializeField] // 0x0000000189B4E820-0x0000000189B4E860
		// [Tooltip] // 0x0000000189B4E820-0x0000000189B4E860
		private MonoUIContainer _container; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ContextEventType _contextEvent; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Sprite _touchIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _keyboardIcon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _joypadIcon; // 0x60
		[ReadOnly] // 0x0000000189B7B200-0x0000000189B7B240
		[SerializeField] // 0x0000000189B7B200-0x0000000189B7B240
		[Space] // 0x0000000189B7B200-0x0000000189B7B240
		private Target _target; // 0x68
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private Sprite _defaultIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _handleEvent; // 0x78
		[SerializeField] // 0x0000000189B9A140-0x0000000189B9A180
		// [Tooltip] // 0x0000000189B9A140-0x0000000189B9A180
		private Button _eventButton; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _actionContainer; // 0x88
		// [Header] // 0x0000000189BAD460-0x0000000189BAD4A0
		[SerializeField] // 0x0000000189BAD460-0x0000000189BAD4A0
		private InputActionType _defaultInputEvent; // 0x90
		public bool needResolveMonoIconElement; // 0x94
		private MonoControlElement monoControlElement; // 0x98
	
		// Properties
		public ContextEventType contextEvent { /* [XID] */ /* 0x0000000189B42410-0x0000000189B42430 */ get => default; /* [XID] */ /* 0x00000001896098C0-0x00000001896098E0 */ set {} } // 0x0000000184BB5990-0x0000000184BB5A30 0x0000000184BB5AD0-0x0000000184BB5B80
		public Sprite joypadIcon { /* [XID] */ /* 0x00000001896110E0-0x0000000189611100 */ get => default; /* [XID] */ /* 0x0000000189618AB0-0x0000000189618AD0 */ set {} } // 0x0000000184BB5A30-0x0000000184BB5AD0 0x0000000184BB5B80-0x0000000184BB5C30
	
		// Nested types
		private enum Target // TypeDefIndex: 30736
		{
			None = 0,
			Image = 1,
			Container = 2
		}
	
		// Constructors
		public MonoControllerIcon() {} // 0x0000000184BB58E0-0x0000000184BB5990
	
		// Methods
		// [XID] // 0x0000000189BB9010-0x0000000189BB9030
		private void Awake() {} // 0x0000000184BB41D0-0x0000000184BB4490
		// [XID] // 0x0000000189BC0E20-0x0000000189BC0E40
		private void OnEnable() {} // 0x0000000184BB4D30-0x0000000184BB4DD0
		// [XID] // 0x0000000189BC8530-0x0000000189BC8550
		public override bool IsInvalid() => default; // 0x0000000184BB4B70-0x0000000184BB4CC0
		// [XID] // 0x0000000189BCFDD0-0x0000000189BCFDF0
		public override bool IsActive() => default; // 0x0000000184BB4A20-0x0000000184BB4B70
		// [XID] // 0x0000000189BD73D0-0x0000000189BD73F0
		public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184BB4590-0x0000000184BB49A0
		// [XID] // 0x0000000189BDEED0-0x0000000189BDEEF0
		public override void ResetByInputActionEvents(InputActionEvent[] actionEventList) {} // 0x0000000184BB5320-0x0000000184BB5790
		// [XID] // 0x00000001895EBB60-0x00000001895EBB80
		public void SetIconByActionType(InputActionType actionType) {} // 0x0000000184BB5790-0x0000000184BB58E0
		// [XID] // 0x00000001895F2EE0-0x00000001895F2F00
		public void ReplacePlatformIcon() {} // 0x0000000184BB4DD0-0x0000000184BB4F50
		// [XID] // 0x00000001895FA740-0x00000001895FA760
		public void ReplaceTarget(Sprite sprite) {} // 0x0000000184BB4F50-0x0000000184BB5320
	}
}
