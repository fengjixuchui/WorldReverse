/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MihoyoButton : UIDButton // TypeDefIndex: 30285
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private bool _findGroupOnAwake; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MihoyoSelectableGroup _group; // 0xF0
		public bool playBagSelect; // 0xF8
	
		// Properties
		public MihoyoSelectableGroup group { /* [XID] */ /* 0x000000018998A3D0-0x000000018998A3F0 */ get => default; /* [XID] */ /* 0x0000000189991CC0-0x0000000189991CE0 */ set {} } // 0x0000000181142900-0x00000001811429B0 0x00000001811429B0-0x0000000181142B60
	
		// Constructors
		public MihoyoButton() {} // 0x0000000181142880-0x0000000181142900
	
		// Methods
		// [XID] // 0x00000001899999B0-0x00000001899999D0
		protected override void Awake() {} // 0x0000000181140AA0-0x0000000181140C10
		// [XID] // 0x00000001899A1080-0x00000001899A10A0
		protected override void OnEnable() {} // 0x0000000181142470-0x0000000181142570
		// [XID] // 0x00000001899A8B90-0x00000001899A8BB0
		protected override void OnDisable() {} // 0x0000000181142360-0x0000000181142470
		// [XID] // 0x00000001899B0490-0x00000001899B04B0
		public override Selectable FindSelectableOnLeft() => default; // 0x0000000181141620-0x00000001811418B0
		// [XID] // 0x00000001899B77C0-0x00000001899B77E0
		public override Selectable FindSelectableOnRight() => default; // 0x00000001811418B0-0x0000000181141B40
		// [XID] // 0x00000001899BF160-0x00000001899BF180
		public override Selectable FindSelectableOnUp() => default; // 0x0000000181141B40-0x0000000181141DD0
		// [XID] // 0x00000001899C6AE0-0x00000001899C6B00
		public override Selectable FindSelectableOnDown() => default; // 0x0000000181141390-0x0000000181141620
		// [XID] // 0x00000001899CE060-0x00000001899CE080
		public Selectable FindSelectableConsiderGroup(Vector3 dir) => default; // 0x0000000181140D30-0x0000000181141390
		// [XID] // 0x00000001899D5800-0x00000001899D5820
		public override void OnSelect(BaseEventData eventData) {} // 0x0000000181142570-0x0000000181142670
		// [XID] // 0x00000001899DCB30-0x00000001899DCB50
		private static new Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) => default; // 0x0000000181142010-0x0000000181142360
		// [XID] // 0x00000001899E47B0-0x00000001899E47D0
		public void ToNormal() {} // 0x00000001811427D0-0x0000000181142880
		// [XID] // 0x00000001899EBB00-0x00000001899EBB20
		public void ToHighlight() {} // 0x0000000181142720-0x00000001811427D0
		// [XID] // 0x00000001899F3610-0x00000001899F3630
		public void ToDisabled() {} // 0x0000000181142670-0x0000000181142720
	}
}
