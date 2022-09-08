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
	public class MonoChatItemDialog : MonoChatItemBase // TypeDefIndex: 28482
	{
		// Fields
		public Transform contentAnchor; // 0x30
		public UnityEngine.UI.Text playerName; // 0x38
		public Image playerIcon; // 0x40
		public Image playerIndexIndicator; // 0x48
		public GameObject playerIndexGo; // 0x50
		public Button iconButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _onlineID; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _blockChatImg; // 0x68
		private uint _uid; // 0x70
		private GameObject _content; // 0x78
		private MonoChatContentBase _monoContent; // 0x80
		private readonly Vector2 otherContentPivot; // 0x88
	
		// Properties
		public bool showOnlineID { /* [XID] */ /* 0x0000000189B44450-0x0000000189B44470 */ set {} } // 0x0000000184B9ECF0-0x0000000184B9EDD0
		public RectTransform blockChatImg { /* [XID] */ /* 0x0000000189B4BB20-0x0000000189B4BB40 */ get => default; } // 0x0000000184B9EA50-0x0000000184B9EAF0 
		public string onlineID { /* [XID] */ /* 0x0000000189B530B0-0x0000000189B530D0 */ set {} } // 0x0000000184B9EB90-0x0000000184B9ECF0
		public uint uid { /* [XID] */ /* 0x0000000189B5AA20-0x0000000189B5AA40 */ get => default; } // 0x0000000184B9EAF0-0x0000000184B9EB90 
	
		// Constructors
		public MonoChatItemDialog() {} // 0x0000000184B9E970-0x0000000184B9EA50
	
		// Methods
		// [XID] // 0x0000000189B61EB0-0x0000000189B61ED0
		public override void RefreshData(ChatData chatData, ChatChannel channel) {} // 0x0000000184B9DE80-0x0000000184B9E860
		// [XID] // 0x0000000189B69B60-0x0000000189B69B80
		public override void PlayAnim() {} // 0x0000000184B9DB90-0x0000000184B9DC60
		// [XID] // 0x0000000189B71100-0x0000000189B71120
		public override void PlayToEnd() {} // 0x0000000184B9DC60-0x0000000184B9DD30
		// [XID] // 0x0000000189B786D0-0x0000000189B786F0
		public override void Recycle() {} // 0x0000000184B9DD30-0x0000000184B9DE80
		// [XID] // 0x0000000189B7FC90-0x0000000189B7FCB0
		private void OnIconButtonClick() {} // 0x0000000184B9D910-0x0000000184B9DAD0
		// [XID] // 0x0000000189B87700-0x0000000189B87720
		public void SetSelect(bool select) {} // 0x0000000184B9E860-0x0000000184B9E970
	}
}
