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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTalkLogDialog : MonoBehaviour // TypeDefIndex: 30588
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _closeBtn; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _dialogRowContainer; // 0x28
		private List<MonoTalkLogRow> _dialogs; // 0x30
		private MonoTalkLogRow _dialogPrefab; // 0x38
	
		// Properties
		public MonoTalkLogRow dialogPrefab { /* [XID] */ /* 0x00000001899B8F60-0x00000001899B8F80 */ get => default; /* [XID] */ /* 0x00000001899C0810-0x00000001899C0830 */ set {} } // 0x00000001850133E0-0x0000000185013480 0x0000000185013480-0x0000000185013530
		public string title { /* [XID] */ /* 0x00000001899C8080-0x00000001899C80A0 */ set {} } // 0x0000000185013530-0x0000000185013600
		public Button closeButton { /* [XID] */ /* 0x00000001899CF9E0-0x00000001899CFA00 */ get => default; } // 0x0000000185013330-0x00000001850133E0 
	
		// Constructors
		public MonoTalkLogDialog() {} // 0x0000000185013280-0x0000000185013330
	
		// Methods
		// [XID] // 0x00000001899D6D70-0x00000001899D6D90
		public MonoTalkLogRow GetDialogAt(int index) => default; // 0x00000001850130C0-0x0000000185013280
		// [XID] // 0x00000001899DE3C0-0x00000001899DE3E0
		public void Clear() {} // 0x0000000185012F60-0x00000001850130C0
	}
}
