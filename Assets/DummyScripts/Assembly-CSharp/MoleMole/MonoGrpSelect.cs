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
	public class MonoGrpSelect : MonoSpriteProxy // TypeDefIndex: 31077
	{
		// Fields
		private MonoReusableList _reusableList; // 0x20
		private MonoPrefabPlugin _prefabPlugin; // 0x28
		private int _currSelection; // 0x30
		private bool _waitingButtonAnim; // 0x34
	
		// Properties
		public int CurrSelection { /* [XID] */ /* 0x0000000189B79B30-0x0000000189B79B50 */ get => default; /* [XID] */ /* 0x0000000189B812A0-0x0000000189B812C0 */ set {} } // 0x0000000184082F30-0x0000000184082FD0 0x0000000184082FD0-0x0000000184083080
		public bool showSelectGrp { /* [XID] */ /* 0x0000000189BA6150-0x0000000189BA6170 */ set {} } // 0x0000000184083080-0x0000000184083170
	
		// Constructors
		public MonoGrpSelect() {} // 0x0000000184082EC0-0x0000000184082F30
	
		// Methods
		// [XID] // 0x0000000189B88A30-0x0000000189B88A50
		public void ChangeSelection(bool increase = true /* Metadata: 0x00B11E87 */, GameObject keyIcon = null) {} // 0x0000000184082000-0x0000000184082170
		// [XID] // 0x0000000189B8FEE0-0x0000000189B8FF00
		public void ConfirmSelection() {} // 0x0000000184082170-0x0000000184082480
		// [XID] // 0x0000000189B97320-0x0000000189B97340
		public void RefreshHightLight(GameObject keyIcon = null) {} // 0x0000000184082480-0x00000001840826D0
		// [XID] // 0x0000000189B9E7A0-0x0000000189B9E7C0
		public void SetupSelectItemByConfig(List<SelectItemParam> nextValidList, bool isTalk = true /* Metadata: 0x00B11E88 */) {} // 0x00000001840826D0-0x0000000184082EC0
	}
}
