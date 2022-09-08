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
	public class MonoPlayerListItem : MonoBehaviour // TypeDefIndex: 31256
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _actionBtn; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _label; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _prefixIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _postfixIcon; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _squadLeaderMark; // 0x38
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x0000000189B752B0-0x0000000189B752D0 */ get => default; } // 0x000000018371FA30-0x000000018371FAD0 
		public string UID { /* [XID] */ /* 0x0000000189B7C6C0-0x0000000189B7C6E0 */ set {} } // 0x000000018371FAD0-0x000000018371FBA0
		public Sprite prefixIcon { /* [XID] */ /* 0x0000000189B844C0-0x0000000189B844E0 */ set {} } // 0x000000018371FDD0-0x000000018371FF20
		public Sprite postfixIcon { /* [XID] */ /* 0x0000000189B8B370-0x0000000189B8B390 */ set {} } // 0x000000018371FC80-0x000000018371FDD0
		public bool isSquadLeader { /* [XID] */ /* 0x0000000189B92B20-0x0000000189B92B40 */ set {} } // 0x000000018371FBA0-0x000000018371FC80
	
		// Constructors
		public MonoPlayerListItem() {} // 0x000000018371F9C0-0x000000018371FA30
	}
}
