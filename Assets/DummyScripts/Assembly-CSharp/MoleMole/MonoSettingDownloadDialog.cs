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
	public class MonoSettingDownloadDialog : MonoBehaviour // TypeDefIndex: 31036
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textTitle; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonBG; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _content; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text _textContent; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _progress; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoProgressBar _mask; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textProgressDesc; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textProgress; // 0x50
	
		// Properties
		public string contentText { /* [XID] */ /* 0x0000000189A12940-0x0000000189A12960 */ set {} } // 0x0000000184118B60-0x0000000184118C30
		public string titleText { /* [XID] */ /* 0x0000000189A19B70-0x0000000189A19B90 */ set {} } // 0x0000000184118EA0-0x0000000184118F70
		public string progressDescText { /* [XID] */ /* 0x0000000189A211C0-0x0000000189A211E0 */ set {} } // 0x0000000184118C30-0x0000000184118D00
		public string progressText { /* [XID] */ /* 0x0000000189A287F0-0x0000000189A28810 */ set {} } // 0x0000000184118D00-0x0000000184118DD0
		public float progress { /* [XID] */ /* 0x0000000189A2FDD0-0x0000000189A2FDF0 */ set {} } // 0x0000000184118DD0-0x0000000184118EA0
		public GameObject goContent { /* [XID] */ /* 0x0000000189A377A0-0x0000000189A377C0 */ get => default; } // 0x0000000184118A20-0x0000000184118AC0 
		public GameObject goProgress { /* [XID] */ /* 0x0000000189A3EEB0-0x0000000189A3EED0 */ get => default; } // 0x0000000184118AC0-0x0000000184118B60 
		public Button buttonCancel { /* [XID] */ /* 0x0000000189A46570-0x0000000189A46590 */ get => default; } // 0x0000000184118860-0x0000000184118940 
		public Button buttonOK { /* [XID] */ /* 0x0000000189A4DD60-0x0000000189A4DD80 */ get => default; } // 0x0000000184118940-0x0000000184118A20 
		public Button buttonCancelDownload { /* [XID] */ /* 0x0000000189A55570-0x0000000189A55590 */ get => default; } // 0x0000000184118780-0x0000000184118860 
		public Button buttonBG { /* [XID] */ /* 0x0000000189A5CE30-0x0000000189A5CE50 */ get => default; } // 0x00000001841186E0-0x0000000184118780 
	
		// Constructors
		public MonoSettingDownloadDialog() {} // 0x0000000184118680-0x00000001841186E0
	}
}
